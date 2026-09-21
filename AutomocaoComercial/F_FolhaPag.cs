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

namespace AutomocaoComercial
{
    public partial class F_FolhaPag : Form
    {
        public F_FolhaPag()
        {
            InitializeComponent();
        }

        private void F_FolhaPag_Load(object sender, EventArgs e)
        {
            try
            {
                string strconn = "Data Source=SOB041982L4B1PC\\SQLEXPRESS01; " +
                    "Initial Catalog = bd_Automacao; Integrated Security = true";

                SqlConnection conn = new SqlConnection(strconn);
                conn.Open();

                string sql = "SELECT Nome, Cargo, Salário, Desconto, SalarioLiquido AS 'Salário Líquido' FROM [dbo].[tb_Funcionarios]";

                //executa o comando SQL e recebe os dados
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //Instancia um DataTable que servirá de intermediário
                DataTable dt = new DataTable();
                //Preenche o dt com os dados presentes no da
                da.Fill(dt);
                //Preencher o dataGridView com os dados do dt
                dgvFuncionarios.DataSource = dt;
                dgvFuncionarios.Columns[2].DefaultCellStyle.Format = "C2";
                dgvFuncionarios.Columns[3].DefaultCellStyle.Format = "C2";
                dgvFuncionarios.Columns[4].DefaultCellStyle.Format = "C2";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
