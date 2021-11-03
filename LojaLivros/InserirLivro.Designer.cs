namespace LojaLivros
{
    partial class InserirLivro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelNomeIns = new System.Windows.Forms.Label();
            this.labelValorIns = new System.Windows.Forms.Label();
            this.labelEditoraIns = new System.Windows.Forms.Label();
            this.labelAnoIns = new System.Windows.Forms.Label();
            this.textBoxNomeIns = new System.Windows.Forms.TextBox();
            this.textBoxEditora = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxAnoIns = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(198, 68);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(276, 31);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Inserir Novo Livro";
            // 
            // labelNomeIns
            // 
            this.labelNomeIns.AutoSize = true;
            this.labelNomeIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeIns.Location = new System.Drawing.Point(99, 156);
            this.labelNomeIns.Name = "labelNomeIns";
            this.labelNomeIns.Size = new System.Drawing.Size(124, 18);
            this.labelNomeIns.TabIndex = 1;
            this.labelNomeIns.Text = "Nome do Livro:";
            // 
            // labelValorIns
            // 
            this.labelValorIns.AutoSize = true;
            this.labelValorIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorIns.Location = new System.Drawing.Point(171, 228);
            this.labelValorIns.Name = "labelValorIns";
            this.labelValorIns.Size = new System.Drawing.Size(52, 18);
            this.labelValorIns.TabIndex = 2;
            this.labelValorIns.Text = "Valor:";
            // 
            // labelEditoraIns
            // 
            this.labelEditoraIns.AutoSize = true;
            this.labelEditoraIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditoraIns.Location = new System.Drawing.Point(156, 192);
            this.labelEditoraIns.Name = "labelEditoraIns";
            this.labelEditoraIns.Size = new System.Drawing.Size(67, 18);
            this.labelEditoraIns.TabIndex = 3;
            this.labelEditoraIns.Text = "Editora:";
            // 
            // labelAnoIns
            // 
            this.labelAnoIns.AutoSize = true;
            this.labelAnoIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnoIns.Location = new System.Drawing.Point(70, 264);
            this.labelAnoIns.Name = "labelAnoIns";
            this.labelAnoIns.Size = new System.Drawing.Size(153, 18);
            this.labelAnoIns.TabIndex = 4;
            this.labelAnoIns.Text = "Ano de Publicação:";
            // 
            // textBoxNomeIns
            // 
            this.textBoxNomeIns.Location = new System.Drawing.Point(229, 154);
            this.textBoxNomeIns.Name = "textBoxNomeIns";
            this.textBoxNomeIns.Size = new System.Drawing.Size(284, 20);
            this.textBoxNomeIns.TabIndex = 5;
            // 
            // textBoxEditora
            // 
            this.textBoxEditora.Location = new System.Drawing.Point(229, 190);
            this.textBoxEditora.Name = "textBoxEditora";
            this.textBoxEditora.Size = new System.Drawing.Size(148, 20);
            this.textBoxEditora.TabIndex = 6;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(229, 226);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor.TabIndex = 7;
            // 
            // textBoxAnoIns
            // 
            this.textBoxAnoIns.Location = new System.Drawing.Point(229, 262);
            this.textBoxAnoIns.Name = "textBoxAnoIns";
            this.textBoxAnoIns.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnoIns.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(62, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 171);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAlterar.Location = new System.Drawing.Point(190, 330);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(96, 37);
            this.buttonAlterar.TabIndex = 10;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.BackColor = System.Drawing.Color.Red;
            this.buttonDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDeletar.Location = new System.Drawing.Point(330, 330);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(96, 37);
            this.buttonDeletar.TabIndex = 11;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = false;
            // 
            // InserirLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(645, 402);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.textBoxAnoIns);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.textBoxEditora);
            this.Controls.Add(this.textBoxNomeIns);
            this.Controls.Add(this.labelAnoIns);
            this.Controls.Add(this.labelEditoraIns);
            this.Controls.Add(this.labelValorIns);
            this.Controls.Add(this.labelNomeIns);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InserirLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNomeIns;
        private System.Windows.Forms.Label labelValorIns;
        private System.Windows.Forms.Label labelEditoraIns;
        private System.Windows.Forms.Label labelAnoIns;
        private System.Windows.Forms.TextBox textBoxNomeIns;
        private System.Windows.Forms.TextBox textBoxEditora;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxAnoIns;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonDeletar;
    }
}

