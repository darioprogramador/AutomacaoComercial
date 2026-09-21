using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AutomocaoComercial
{
    public partial class F_TelaAdmin : Form
    {
        public F_TelaAdmin()
        {
            InitializeComponent();
        }

        private void F_TelaAdmin_Load(object sender, EventArgs e)
        {   /*Tabela Funcionários */
            try
            {
                string strconn = "Data Source=SOB041982L4B1PC\\SQLEXPRESS01; " +
                    "Initial Catalog = bd_Automacao; Integrated Security = true";

                SqlConnection conn = new SqlConnection(strconn);
                conn.Open();

                string sql = "SELECT Nome, Endereço, Email, Cargo, Salário, Usuário, Senha FROM [dbo].[tb_Funcionarios]";

                //executa o comando SQL e recebe os dados
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //Instancia um DataTable que servirá de intermediário
                DataTable dt = new DataTable();
                //Preenche o dt com os dados presentes no da
                da.Fill(dt);
                //Preencher o dataGridView com os dados do dt
                dgvFuncionarios.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Tabela Produtos
            try
            {
                string strconn = "Data Source=SOB041982L4B1PC\\SQLEXPRESS01; " +
                    "Initial Catalog = bd_Automacao; Integrated Security = true";

                SqlConnection conn = new SqlConnection(strconn);
                conn.Open();

                string sql = "SELECT Código AS 'Código do Produto', Nome AS Produto, Quantidade, Valor FROM [dbo].[tb_Produtos]";

    
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProdutos.DataSource = dt;
                dgvProdutos.Columns[3].DefaultCellStyle.Format = "C2";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_CadastroProduto produto = new F_CadastroProduto();
            this.Hide(); // Esconde esta tela
            produto.ShowDialog();
            this.Show(); // Quando fechar Produtos, mostra esta tela novamente
        }

        private void btnFolhaPgn_Click(object sender, EventArgs e)
        {
            
        }

        private void folhaDePagamentpoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_FolhaPag folhapag = new F_FolhaPag();
            folhapag.ShowDialog();
            this.Show();
        }

        private void msCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_CadastroFuncionario janelacadastro = new F_CadastroFuncionario();
            if (janelacadastro.ShowDialog() == DialogResult.OK)
            {
                this.F_TelaAdmin_Load(sender, e);
            }
            this.Show();
        }

        private void msCadastrarProduto_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_CadastroProduto produto = new F_CadastroProduto();
            if(produto.ShowDialog() == DialogResult.OK)
            {
                this.F_TelaAdmin_Load(sender, e);
            }
            this.Show();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
