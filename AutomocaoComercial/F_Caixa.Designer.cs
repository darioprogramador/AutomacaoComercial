namespace AutomocaoComercial
{
    partial class F_Caixa
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCodigoProduto = new System.Windows.Forms.TextBox();
            this.tbxNomeProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxValorTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.btnCalcularTotal = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "COD. DO PRODUTO";
            // 
            // tbxCodigoProduto
            // 
            this.tbxCodigoProduto.Location = new System.Drawing.Point(12, 28);
            this.tbxCodigoProduto.Name = "tbxCodigoProduto";
            this.tbxCodigoProduto.Size = new System.Drawing.Size(199, 20);
            this.tbxCodigoProduto.TabIndex = 1;
            // 
            // tbxNomeProduto
            // 
            this.tbxNomeProduto.Location = new System.Drawing.Point(512, 160);
            this.tbxNomeProduto.Name = "tbxNomeProduto";
            this.tbxNomeProduto.Size = new System.Drawing.Size(90, 20);
            this.tbxNomeProduto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(497, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = " PRODUTO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.Location = new System.Drawing.Point(512, 98);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(90, 20);
            this.tbxQuantidade.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(491, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "QUANTIDADE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(512, 222);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(90, 20);
            this.tbxValor.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(498, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "VALOR R$";
            // 
            // tbxValorTotal
            // 
            this.tbxValorTotal.Location = new System.Drawing.Point(512, 288);
            this.tbxValorTotal.Name = "tbxValorTotal";
            this.tbxValorTotal.Size = new System.Drawing.Size(90, 20);
            this.tbxValorTotal.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(508, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "TOTAL R$";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 52);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.Size = new System.Drawing.Size(460, 155);
            this.dgvProdutos.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(217, 28);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(84, 22);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(75, 224);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(126, 26);
            this.btnSelecionar.TabIndex = 4;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colProduto,
            this.QTD,
            this.colValor,
            this.Total});
            this.dgvCarrinho.Location = new System.Drawing.Point(12, 256);
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.RowHeadersVisible = false;
            this.dgvCarrinho.Size = new System.Drawing.Size(460, 145);
            this.dgvCarrinho.TabIndex = 10;
            this.dgvCarrinho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrinho_CellContentClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // colProduto
            // 
            this.colProduto.HeaderText = "Produto";
            this.colProduto.Name = "colProduto";
            // 
            // QTD
            // 
            this.QTD.HeaderText = "Quantidade";
            this.QTD.Name = "QTD";
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(269, 411);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(131, 28);
            this.btnFinalizarVenda.TabIndex = 12;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = false;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // btnCalcularTotal
            // 
            this.btnCalcularTotal.BackColor = System.Drawing.Color.Red;
            this.btnCalcularTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularTotal.ForeColor = System.Drawing.Color.White;
            this.btnCalcularTotal.Location = new System.Drawing.Point(75, 411);
            this.btnCalcularTotal.Name = "btnCalcularTotal";
            this.btnCalcularTotal.Size = new System.Drawing.Size(126, 28);
            this.btnCalcularTotal.TabIndex = 11;
            this.btnCalcularTotal.Text = "Calcular";
            this.btnCalcularTotal.UseVisualStyleBackColor = false;
            this.btnCalcularTotal.Click += new System.EventHandler(this.btnCalcularTotal_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(287, 224);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(126, 26);
            this.btnSomar.TabIndex = 5;
            this.btnSomar.Text = "Adicionar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click_1);
            // 
            // F_Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutomocaoComercial.Properties.Resources.adc3dc76deedd5b27ab4d49d265a72ca;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 451);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnCalcularTotal);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.dgvCarrinho);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.tbxValorTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxNomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCodigoProduto);
            this.Controls.Add(this.label1);
            this.Name = "F_Caixa";
            this.Text = "F_Caixa";
            this.Load += new System.EventHandler(this.F_Caixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCodigoProduto;
        private System.Windows.Forms.TextBox tbxNomeProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxValorTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Button btnCalcularTotal;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}