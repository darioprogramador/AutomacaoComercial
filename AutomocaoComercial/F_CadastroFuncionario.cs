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
    public partial class F_CadastroFuncionario : Form
    {
        public F_CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tbxNome.Text;
            string endereco = tbxEndereco.Text;
            string email = tbxEmail.Text;
            string cargo = cbxCargo.Text;
            double salario = Convert.ToDouble(tbxSalario.Text);
            string usuario = tbxUsuario.Text;
            string senha = tbxSenha.Text;

            //Cálculo do desconto
            double desconto = desconto = salario * 0.11;
            double SalarioLiquido = salario - desconto;

            string strconn = "Data Source=SOB041982L4B1PC\\SQLEXPRESS01; " + "Initial Catalog = bd_Automacao; Integrated Security = true";

            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string sql = "INSERT INTO [dbo].[tb_Funcionarios] " + "(Nome, Endereço, Email, Cargo, Salário, Desconto, SalarioLiquido, Usuário, Senha) " +
                "VALUES (@Nome, @Endereço, @Email, @Cargo, @Salário, @Desconto, @SalarioLiquido, @Usuário, @Senha)";

            SqlCommand comando = new SqlCommand(sql, conn);

            comando.Parameters.Add(new SqlParameter("@Nome", nome));
            comando.Parameters.Add(new SqlParameter("@Endereço", endereco));
            comando.Parameters.Add(new SqlParameter("@Email", email));
            comando.Parameters.Add(new SqlParameter("@Cargo", cargo));
            comando.Parameters.Add(new SqlParameter("@Salário", salario));
            comando.Parameters.Add(new SqlParameter("@Desconto", desconto));
            comando.Parameters.Add(new SqlParameter("@SalarioLiquido", SalarioLiquido));
            comando.Parameters.Add(new SqlParameter("@Usuário", usuario));
            comando.Parameters.Add(new SqlParameter("@Senha", senha));

            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show($"Cadastro {nome} realizado com sucesso!");
                conn.Close();
            }
        
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void F_CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
