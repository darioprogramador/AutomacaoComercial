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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AutomocaoComercial
{
    public partial class F_CadastroProduto : Form
    {
        public F_CadastroProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string codigo = tbxCodigo.Text;
            string nome = tbxNome.Text;
            int quantidade = Convert.ToInt32(tbxQuantidade.Text);
            double valor = Convert.ToDouble(tbxValor.Text);


            string strconn = "Data Source=SOB041982L4B1PC\\SQLEXPRESS01; " + "Initial Catalog = bd_Automacao; Integrated Security = true";

            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string sql = "INSERT INTO [dbo].[tb_Produtos] " + "(Código, Nome, Quantidade, Valor) " +
                "VALUES (@Código, @Nome, @Quantidade, @Valor)";

            SqlCommand comando = new SqlCommand(sql, conn);

            comando.Parameters.Add(new SqlParameter("@Código", codigo));
            comando.Parameters.Add(new SqlParameter("@Nome", nome));
            comando.Parameters.Add(new SqlParameter("@Quantidade", quantidade));
            comando.Parameters.Add(new SqlParameter("@Valor", valor));

            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show($"Cadastro do produto {nome} realizado com sucesso!");
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DialogResult = DialogResult.OK;
            Close();
            
        }

        private void F_CadastroProduto_Load(object sender, EventArgs e)
        {
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
                dgvCadastroProduto.DataSource = dt;
                dgvCadastroProduto.Columns[3].DefaultCellStyle.Format = "C2";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
