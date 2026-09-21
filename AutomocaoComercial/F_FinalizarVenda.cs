using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomocaoComercial
{
    public partial class F_FinalizarVenda : Form
    {
        public F_FinalizarVenda()
        {
            InitializeComponent();
        }

        private void F_FinalizarVenda_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, Color.White);
        }
    }
}
