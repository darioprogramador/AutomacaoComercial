using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AutomocaoComercial
{
    public partial class F_Login : Form
    {
        private int tentativas = 0;

        private const int MAX_TENTATIVAS = 3;

        private readonly string strconn =
            "Data Source=SOB041982L4B1PC\\SQLEXPRESS01;" +
            "Initial Catalog=bd_Automacao;" +
            "Integrated Security=true";


        public F_Login()
        {
            InitializeComponent();
        }


        // =========================================================
        // CADASTRO DE FUNCIONÁRIO
        // =========================================================

        private void button2_Click(object sender, EventArgs e)
        {
            F_CadastroFuncionario janelaCadastro =
                new F_CadastroFuncionario();

            janelaCadastro.ShowDialog();
        }


        // =========================================================
        // BOTÃO ENTRAR
        // =========================================================

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = tbxUsuario.Text.Trim();
            string senha = tbxsenha.Text;
            string tipo = cbxTipo.Text.Trim();


            // -----------------------------------------------------
            // VALIDAÇÃO DOS CAMPOS
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show(
                    "Digite o usuário.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbxUsuario.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show(
                    "Digite a senha.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbxsenha.Focus();
                return;
            }


            if (tipo != "Colaborador" && tipo != "Admin")
            {
                MessageBox.Show(
                    "Selecione o tipo de usuário.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cbxTipo.Focus();
                return;
            }


            // -----------------------------------------------------
            // VERIFICA SE AINDA HÁ TENTATIVAS
            // -----------------------------------------------------

            if (tentativas >= MAX_TENTATIVAS)
            {
                MessageBox.Show(
                    "Número máximo de tentativas excedido.",
                    "Login bloqueado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }


            try
            {
                bool loginValido = VerificarLogin(
                    usuario,
                    senha,
                    tipo);


                // -------------------------------------------------
                // LOGIN CORRETO
                // -------------------------------------------------

                if (loginValido)
                {
                    // Zera as tentativas depois de um login correto
                    tentativas = 0;

                    AbrirTelaPrincipal(tipo);

                    return;
                }


                // -------------------------------------------------
                // LOGIN INCORRETO
                // -------------------------------------------------

                tentativas++;

                int restantes =
                    MAX_TENTATIVAS - tentativas;


                if (restantes > 0)
                {
                    MessageBox.Show(
                        $"Usuário ou senha inválido.\n\n" +
                        $"Tentativas restantes: {restantes}",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    tbxsenha.Clear();
                    tbxsenha.Focus();
                }
                else
                {
                    MessageBox.Show(
                        "Número máximo de tentativas excedido.",
                        "Login bloqueado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    btnEntrar.Enabled = false;
                    tbxUsuario.Enabled = false;
                    tbxsenha.Enabled = false;
                    cbxTipo.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocorreu um erro ao realizar o login:\n\n" +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =========================================================
        // VERIFICAR LOGIN NO BANCO
        // =========================================================

        private bool VerificarLogin(
            string usuario,
            string senha,
            string tipo)
        {
            string tabela;


            // Define qual tabela será consultada
            if (tipo == "Admin")
            {
                tabela = "tb_admin";
            }
            else
            {
                tabela = "tb_Funcionarios";
            }


            string sql = $@"
                SELECT 1
                FROM {tabela}
                WHERE Usuário = @Usuario
                AND Senha = @Senha";


            // Para tb_admin, caso o nome da coluna seja
            // "usuario" em vez de "Usuário", usamos outra consulta.
            if (tipo == "Admin")
            {
                sql = @"
                    SELECT 1
                    FROM tb_admin
                    WHERE usuario = @Usuario
                    AND senha = @Senha";
            }


            using (SqlConnection conn =
                   new SqlConnection(strconn))
            {
                conn.Open();


                using (SqlCommand comando =
                       new SqlCommand(sql, conn))
                {
                    comando.Parameters.Add(
                        "@Usuario",
                        SqlDbType.VarChar).Value =
                        usuario;

                    comando.Parameters.Add(
                        "@Senha",
                        SqlDbType.VarChar).Value =
                        senha;


                    object resultado =
                        comando.ExecuteScalar();


                    return resultado != null;
                }
            }
        }


        // =========================================================
        // ABRIR A TELA CORRESPONDENTE AO TIPO DE USUÁRIO
        // =========================================================

        private void AbrirTelaPrincipal(string tipo)
        {
            this.Hide();


            if (tipo == "Colaborador")
            {
                using (F_Caixa caixa = new F_Caixa())
                {
                    caixa.ShowDialog();
                }
            }
            else if (tipo == "Admin")
            {
                using (F_TelaAdmin telaAdmin =
                       new F_TelaAdmin())
                {
                    telaAdmin.ShowDialog();
                }
            }


            // Quando a tela principal fechar,
            // o login aparece novamente.
            this.Show();


            // Limpa os campos
            tbxUsuario.Clear();
            tbxsenha.Clear();
            cbxTipo.SelectedIndex = -1;

            tbxUsuario.Focus();
        }


        // =========================================================
        // MOSTRAR / OCULTAR SENHA
        // =========================================================

        private void chxExibir_CheckedChanged(
            object sender,
            EventArgs e)
        {
            if (chxExibir.Checked)
            {
                tbxsenha.PasswordChar = '\0';
            }
            else
            {
                tbxsenha.PasswordChar = '*';
            }
        }


        // =========================================================
        // EVENTO DO COMBOBOX
        // =========================================================

        private void comboBox1_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }

        private void F_Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 57, 24, 9);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}