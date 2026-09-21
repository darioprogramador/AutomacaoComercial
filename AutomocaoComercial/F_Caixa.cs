using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace AutomocaoComercial
{
    public partial class F_Caixa : Form
    {
        // Guarda o código do produto selecionado
        private int id_Produto;

        // Conexão com o banco de dados
        private readonly string strconn =
            "Data Source=SOB041982L4B1PC\\SQLEXPRESS01;" +
            "Initial Catalog=bd_Automacao;" +
            "Integrated Security=true";

        public F_Caixa()
        {
            InitializeComponent();
        }


        // =========================================================
        // CARREGAMENTO DA TELA
        // =========================================================

        private void F_Caixa_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }


        // =========================================================
        // CARREGAR PRODUTOS
        // =========================================================

        private void CarregarProdutos()
        {
            try
                {
                    using (SqlConnection conn = new SqlConnection(strconn))
                    {
                        conn.Open();

                        string sql = @"
                  SELECT 
                      Código AS [Código do Produto],
                      Nome AS [Produto],
                      Quantidade,
                      FORMAT(Valor, 'C2', 'pt-BR') AS [Valor]
                  FROM tb_Produtos";

                        using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dgvProdutos.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Erro ao carregar os produtos:\n\n" + ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }



        // =========================================================
        // SELECIONAR PRODUTO
        // =========================================================

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutos.CurrentRow == null ||
                    dgvProdutos.CurrentRow.IsNewRow)
                {
                    MessageBox.Show(
                        "Selecione um produto primeiro.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Código
                id_Produto = Convert.ToInt32(
                    dgvProdutos.CurrentRow.Cells[0].Value);

                // Nome
                tbxNomeProduto.Text =
                    dgvProdutos.CurrentRow.Cells[1].Value.ToString();

                // Valor
                string valorTexto = dgvProdutos.CurrentRow.Cells[3].Value.ToString();

                if (!decimal.TryParse(
                        valorTexto,
                        NumberStyles.Currency,
                        CultureInfo.GetCultureInfo("pt-BR"),
                        out decimal valor))
                {
                    MessageBox.Show(
                        "Valor do produto inválido.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                tbxValor.Text = valor.ToString(
                    "C2",
                    CultureInfo.GetCultureInfo("pt-BR"));

                // Limpa o valor total anterior
                tbxValorTotal.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao selecionar o produto:\n\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================================
        // PESQUISAR PRODUTO
        // =========================================================

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string pesquisa = tbxCodigoProduto.Text.Trim();

                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    conn.Open();

                    string sql = @"
                        SELECT 
                            Código AS [Código do Produto],
                            Nome AS [Produto],
                            Quantidade,
                            Valor
                        FROM tb_Produtos
                        WHERE CONVERT(VARCHAR(20), Código) LIKE @Pesquisa";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Pesquisa",
                            "%" + pesquisa + "%");

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dgvProdutos.DataSource = dt;
                        }
                    }
                }

                if (dgvProdutos.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Nenhum produto encontrado.",
                        "Pesquisa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao pesquisar produto:\n\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================================
        // ADICIONAR PRODUTO AO CARRINHO
        // =========================================================

        private void btnSomar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Verifica se existe produto selecionado
                if (dgvProdutos.CurrentRow == null ||
                    dgvProdutos.CurrentRow.IsNewRow)
                {
                    MessageBox.Show(
                        "Selecione um produto primeiro.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Verifica se existe código válido
                if (id_Produto <= 0)
                {
                    MessageBox.Show(
                        "Selecione um produto válido.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Verifica quantidade
                if (!int.TryParse(
                        tbxQuantidade.Text,
                        out int quantidade) ||
                    quantidade <= 0)
                {
                    MessageBox.Show(
                        "Digite uma quantidade válida.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    tbxQuantidade.Focus();
                    return;
                }

                // Verifica o valor do produto
                if (!decimal.TryParse(
                        tbxValor.Text,
                        NumberStyles.Currency,
                        CultureInfo.GetCultureInfo("pt-BR"),
                        out decimal valorUnitario))
                {
                    MessageBox.Show(
                        "Valor do produto inválido.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                // Verifica se há estoque suficiente
                int estoqueDisponivel = Convert.ToInt32(
                    dgvProdutos.CurrentRow.Cells[2].Value);

                if (quantidade > estoqueDisponivel)
                {
                    MessageBox.Show(
                        $"Estoque insuficiente.\n\n" +
                        $"Disponível: {estoqueDisponivel}\n" +
                        $"Solicitado: {quantidade}",
                        "Estoque insuficiente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
             
            
        


        // Calcula o valor total daquele produto
        decimal valorTotalProduto =
                    valorUnitario * quantidade;

                // Adiciona uma nova linha ao carrinho
                int linha = dgvCarrinho.Rows.Add();

                // Código
                dgvCarrinho.Rows[linha].Cells[0].Value =
                    id_Produto;

                // Nome
                dgvCarrinho.Rows[linha].Cells[1].Value =
                    tbxNomeProduto.Text;

                // Quantidade
                dgvCarrinho.Rows[linha].Cells[2].Value =
                    quantidade;

                // Valor unitário
                dgvCarrinho.Rows[linha].Cells[3].Value =
                    valorUnitario.ToString("C2");

                // Valor total do produto
                dgvCarrinho.Rows[linha].Cells[4].Value =
                    valorTotalProduto.ToString("C2");
                
                // Limpa quantidade para o próximo produto
                tbxQuantidade.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao adicionar produto ao carrinho:\n\n" +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================================
        // CALCULAR TOTAL DA COMPRA
        // =========================================================

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            try
            {
                decimal somaTotalGeral = 0;

                foreach (DataGridViewRow linha in dgvCarrinho.Rows)
                {
                    if (linha.IsNewRow)
                        continue;

                    object valorCelula =
                        linha.Cells[4].Value;

                    if (valorCelula == null ||
                        valorCelula == DBNull.Value)
                    {
                        continue;
                    }

                    string valorTexto =
                        valorCelula.ToString()
                        .Replace("R$", "")
                        .Trim();

                    if (decimal.TryParse(
                            valorTexto,
                            NumberStyles.Any,
                            CultureInfo.GetCultureInfo("pt-BR"),
                            out decimal valor))
                    {
                        somaTotalGeral += valor;
                    }
                }

                tbxValorTotal.Text =
                    somaTotalGeral.ToString(
                        "C2",
                        CultureInfo.GetCultureInfo("pt-BR"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao calcular o total:\n\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================================
        // FINALIZAR VENDA
        // =========================================================

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se existem produtos no carrinho
                bool possuiProdutos = false;

                foreach (DataGridViewRow linha in dgvCarrinho.Rows)
                {
                    if (!linha.IsNewRow)
                    {
                        possuiProdutos = true;
                        break;
                    }
                }

                if (!possuiProdutos)
                {
                    MessageBox.Show(
                        "Não há produtos no carrinho.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Calcula o total novamente antes de finalizar
                decimal totalVenda = 0;

                foreach (DataGridViewRow linha in dgvCarrinho.Rows)
                {
                    if (linha.IsNewRow)
                        continue;

                    string valorTexto =
                        linha.Cells[4].Value?.ToString()
                        ?.Replace("R$", "")
                        .Trim();

                    if (decimal.TryParse(
                            valorTexto,
                            NumberStyles.Any,
                            CultureInfo.GetCultureInfo("pt-BR"),
                            out decimal valor))
                    {
                        totalVenda += valor;
                    }
                }

                if (totalVenda <= 0)
                {
                    MessageBox.Show(
                        "O valor total da venda é inválido.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Atualiza o campo do total
                tbxValorTotal.Text =
                    totalVenda.ToString(
                        "C2",
                        CultureInfo.GetCultureInfo("pt-BR"));

                // Abre a tela de pagamento
                F_FinalizarVenda telaFinalizar =
                    new F_FinalizarVenda();

                telaFinalizar.ShowDialog();

                // Só altera o estoque se o pagamento foi concluído
                if (telaFinalizar.DialogResult != DialogResult.OK)
                    return;


                // =================================================
                // ATUALIZA ESTOQUE
                // =================================================

                using (SqlConnection conn =
                       new SqlConnection(strconn))
                {
                    conn.Open();

                    // Inicia uma transação.
                    // Se algum produto apresentar problema,
                    // nenhuma alteração será aplicada.
                    using (SqlTransaction transaction =
                           conn.BeginTransaction())
                    {
                        try
                        {
                            foreach (DataGridViewRow linha
                                     in dgvCarrinho.Rows)
                            {
                                if (linha.IsNewRow)
                                    continue;

                                // Código do produto
                                if (!int.TryParse(
                                        linha.Cells[0].Value?.ToString(),
                                        out int codigoProduto))
                                {
                                    throw new Exception(
                                        "O código de um dos produtos " +
                                        "do carrinho é inválido.");
                                }

                                // Quantidade vendida
                                if (!int.TryParse(
                                        linha.Cells[2].Value?.ToString(),
                                        out int quantidadeVendida) ||
                                    quantidadeVendida <= 0)
                                {
                                    throw new Exception(
                                        $"A quantidade do produto " +
                                        $"código {codigoProduto} é inválida.");
                                }

                                // Atualiza o estoque
                                string sql = @"
                                    UPDATE tb_Produtos
                                    SET Quantidade =
                                        Quantidade - @Quantidade
                                    WHERE Código = @Codigo
                                    AND Quantidade >= @Quantidade";

                                using (SqlCommand cmd =
                                       new SqlCommand(
                                           sql,
                                           conn,
                                           transaction))
                                {
                                    cmd.Parameters.Add(
                                        "@Quantidade",
                                        SqlDbType.Int).Value =
                                        quantidadeVendida;

                                    cmd.Parameters.Add(
                                        "@Codigo",
                                        SqlDbType.Int).Value =
                                        codigoProduto;

                                    int linhasAfetadas =
                                        cmd.ExecuteNonQuery();

                                    // Se não alterou nenhuma linha,
                                    // não existe estoque suficiente
                                    // ou o produto não existe.
                                    if (linhasAfetadas == 0)
                                    {
                                        throw new Exception(
                                            $"Não foi possível atualizar " +
                                            $"o estoque do produto código " +
                                            $"{codigoProduto}.\n\n" +
                                            "Verifique se o produto existe " +
                                            "e se há quantidade suficiente " +
                                            "em estoque.");
                                    }
                                }
                            }

                            // Confirma todas as alterações
                            transaction.Commit();
                        }
                        catch
                        {
                            // Desfaz todas as alterações caso
                            // algum produto apresente problema.
                            transaction.Rollback();

                            throw;
                        }
                    }
                }


                // =================================================
                // LIMPAR A VENDA
                // =================================================

                dgvCarrinho.Rows.Clear();

                tbxValorTotal.Clear();
                tbxQuantidade.Clear();
                tbxNomeProduto.Clear();
                tbxValor.Clear();

                id_Produto = 0;

                // Recarrega os produtos com o estoque atualizado
                CarregarProdutos();

                MessageBox.Show(
                    "Venda finalizada e estoque atualizado com sucesso!",
                    "Venda concluída",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocorreu um erro ao finalizar a venda:\n\n" +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================================
        // EVENTOS ANTIGOS DO DESIGNER
        // =========================================================
        // Mantidos para evitar erros caso estejam vinculados
        // aos eventos no arquivo F_Caixa.Designer.cs.

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void dgvCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        

    }
}
}