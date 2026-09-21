namespace AutomocaoComercial
{
    partial class F_TelaAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastrarFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastrarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.msPagamento = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblAdm = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCadastrar,
            this.msPagamento});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msCadastrar
            // 
            this.msCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCadastrarFuncionario,
            this.msCadastrarProduto});
            this.msCadastrar.Name = "msCadastrar";
            this.msCadastrar.Size = new System.Drawing.Size(69, 20);
            this.msCadastrar.Text = "Cadastrar";
            // 
            // msCadastrarFuncionario
            // 
            this.msCadastrarFuncionario.Name = "msCadastrarFuncionario";
            this.msCadastrarFuncionario.Size = new System.Drawing.Size(190, 22);
            this.msCadastrarFuncionario.Text = "Cadastrar Funcionário";
            this.msCadastrarFuncionario.Click += new System.EventHandler(this.msCadastrarFuncionario_Click);
            // 
            // msCadastrarProduto
            // 
            this.msCadastrarProduto.Name = "msCadastrarProduto";
            this.msCadastrarProduto.Size = new System.Drawing.Size(190, 22);
            this.msCadastrarProduto.Text = "Cadastrar Produto";
            this.msCadastrarProduto.Click += new System.EventHandler(this.msCadastrarProduto_Click);
            // 
            // msPagamento
            // 
            this.msPagamento.Name = "msPagamento";
            this.msPagamento.Size = new System.Drawing.Size(128, 20);
            this.msPagamento.Text = "Folha de pagamento";
            this.msPagamento.Click += new System.EventHandler(this.folhaDePagamentpoToolStripMenuItem_Click);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(6, 28);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.RowHeadersVisible = false;
            this.dgvFuncionarios.Size = new System.Drawing.Size(395, 368);
            this.dgvFuncionarios.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvFuncionarios);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 427);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionários";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvProdutos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(471, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 427);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(6, 28);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.Size = new System.Drawing.Size(410, 368);
            this.dgvProdutos.TabIndex = 2;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // lblAdm
            // 
            this.lblAdm.AutoSize = true;
            this.lblAdm.BackColor = System.Drawing.Color.Transparent;
            this.lblAdm.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdm.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdm.Location = new System.Drawing.Point(5, 29);
            this.lblAdm.Name = "lblAdm";
            this.lblAdm.Size = new System.Drawing.Size(278, 45);
            this.lblAdm.TabIndex = 0;
            this.lblAdm.Text = "Administrativo";
            // 
            // F_TelaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutomocaoComercial.Properties.Resources.adc3dc76deedd5b27ab4d49d265a72ca;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 532);
            this.Controls.Add(this.lblAdm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_TelaAdmin";
            this.Text = "F_TelaAdmin";
            this.Load += new System.EventHandler(this.F_TelaAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msCadastrar;
        private System.Windows.Forms.ToolStripMenuItem msCadastrarFuncionario;
        private System.Windows.Forms.ToolStripMenuItem msCadastrarProduto;
        private System.Windows.Forms.ToolStripMenuItem msPagamento;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblAdm;
    }
}