
namespace ProjetoDotNet.WindowsForms.UI
{
    partial class lbl
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
            this.lblNomeDoFornecedor = new System.Windows.Forms.Label();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblNomeDoContato = new System.Windows.Forms.Label();
            this.txtNomeDoContato = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeDoFornecedor
            // 
            this.lblNomeDoFornecedor.AutoSize = true;
            this.lblNomeDoFornecedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomeDoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDoFornecedor.Location = new System.Drawing.Point(12, 19);
            this.lblNomeDoFornecedor.Name = "lblNomeDoFornecedor";
            this.lblNomeDoFornecedor.Size = new System.Drawing.Size(125, 13);
            this.lblNomeDoFornecedor.TabIndex = 0;
            this.lblNomeDoFornecedor.Text = "Nome do Fornecedor";
            this.lblNomeDoFornecedor.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(15, 35);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(299, 20);
            this.txtNomeFornecedor.TabIndex = 2;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(12, 71);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(61, 13);
            this.lblEndereco.TabIndex = 0;
            this.lblEndereco.Text = "Endereço";
            this.lblEndereco.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(15, 87);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(389, 20);
            this.txtEndereco.TabIndex = 2;
            // 
            // lblNomeDoContato
            // 
            this.lblNomeDoContato.AutoSize = true;
            this.lblNomeDoContato.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomeDoContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDoContato.Location = new System.Drawing.Point(12, 128);
            this.lblNomeDoContato.Name = "lblNomeDoContato";
            this.lblNomeDoContato.Size = new System.Drawing.Size(105, 13);
            this.lblNomeDoContato.TabIndex = 0;
            this.lblNomeDoContato.Text = "Nome do Contato";
            this.lblNomeDoContato.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomeDoContato
            // 
            this.txtNomeDoContato.Location = new System.Drawing.Point(15, 146);
            this.txtNomeDoContato.Name = "txtNomeDoContato";
            this.txtNomeDoContato.Size = new System.Drawing.Size(168, 20);
            this.txtNomeDoContato.TabIndex = 2;
            this.txtNomeDoContato.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(12, 185);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(57, 13);
            this.lblTelefone.TabIndex = 0;
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(15, 201);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(125, 20);
            this.txtTelefone.TabIndex = 2;
            this.txtTelefone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(12, 250);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(171, 66);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Location = new System.Drawing.Point(15, 345);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.Size = new System.Drawing.Size(656, 110);
            this.dgvFornecedores.TabIndex = 4;
            // 
            // lbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 562);
            this.Controls.Add(this.dgvFornecedores);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNomeDoContato);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNomeDoContato);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNomeDoFornecedor);
            this.Name = "lbl";
            this.Text = "Tela de Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeDoFornecedor;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblNomeDoContato;
        private System.Windows.Forms.TextBox txtNomeDoContato;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvFornecedores;
    }
}

