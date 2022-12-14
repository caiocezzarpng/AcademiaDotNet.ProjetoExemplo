namespace AcademiaDotNet.ProjetoExemplo.WindowsForms.UI
{
    partial class FFormularioInicial
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
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblNomeDoContato = new System.Windows.Forms.Label();
            this.txtNomeDoContato = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFornecedor.Location = new System.Drawing.Point(12, 30);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(154, 16);
            this.lblNomeFornecedor.TabIndex = 0;
            this.lblNomeFornecedor.Text = "Nome do Fornecedor";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(15, 60);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(388, 22);
            this.txtNomeFornecedor.TabIndex = 1;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(12, 114);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(74, 16);
            this.lblEndereco.TabIndex = 0;
            this.lblEndereco.Text = "Endereço";
            this.lblEndereco.Click += new System.EventHandler(this.lblEndereco_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 148);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(573, 22);
            this.txtEndereco.TabIndex = 1;
            this.txtEndereco.TextChanged += new System.EventHandler(this.textEndereco_TextChanged);
            // 
            // lblNomeDoContato
            // 
            this.lblNomeDoContato.AutoSize = true;
            this.lblNomeDoContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDoContato.Location = new System.Drawing.Point(12, 190);
            this.lblNomeDoContato.Name = "lblNomeDoContato";
            this.lblNomeDoContato.Size = new System.Drawing.Size(127, 16);
            this.lblNomeDoContato.TabIndex = 0;
            this.lblNomeDoContato.Text = "Nome do Contato";
            this.lblNomeDoContato.Click += new System.EventHandler(this.lblEndereco_Click);
            // 
            // txtNomeDoContato
            // 
            this.txtNomeDoContato.Location = new System.Drawing.Point(12, 220);
            this.txtNomeDoContato.Name = "txtNomeDoContato";
            this.txtNomeDoContato.Size = new System.Drawing.Size(391, 22);
            this.txtNomeDoContato.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(12, 269);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(69, 16);
            this.lblTelefone.TabIndex = 0;
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Click += new System.EventHandler(this.lblEndereco_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(12, 303);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(391, 22);
            this.txtTelefone.TabIndex = 1;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(683, 262);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(147, 63);
            this.btSalvar.TabIndex = 2;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Location = new System.Drawing.Point(14, 352);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.RowHeadersWidth = 51;
            this.dgvFornecedores.RowTemplate.Height = 24;
            this.dgvFornecedores.Size = new System.Drawing.Size(992, 307);
            this.dgvFornecedores.TabIndex = 3;
            // 
            // FFormularioInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 671);
            this.Controls.Add(this.dgvFornecedores);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNomeDoContato);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNomeDoContato);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNomeFornecedor);
            this.Name = "FFormularioInicial";
            this.Text = "Tela de cadastro de fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFornecedor;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblNomeDoContato;
        private System.Windows.Forms.TextBox txtNomeDoContato;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.DataGridView dgvFornecedores;
    }
}

