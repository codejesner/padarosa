namespace Padarosa.Formularios
{
    partial class MenuProdutos
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
            this.grbCadProduto = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbCadProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCadProduto
            // 
            this.grbCadProduto.Controls.Add(this.btnCadastrar);
            this.grbCadProduto.Controls.Add(this.cmbCategoria);
            this.grbCadProduto.Controls.Add(this.txtPreco);
            this.grbCadProduto.Controls.Add(this.txtNome);
            this.grbCadProduto.Controls.Add(this.lblCategoria);
            this.grbCadProduto.Controls.Add(this.lblPreco);
            this.grbCadProduto.Controls.Add(this.lblNome);
            this.grbCadProduto.Location = new System.Drawing.Point(13, 49);
            this.grbCadProduto.Name = "grbCadProduto";
            this.grbCadProduto.Size = new System.Drawing.Size(338, 161);
            this.grbCadProduto.TabIndex = 0;
            this.grbCadProduto.TabStop = false;
            this.grbCadProduto.Text = "Cadastrar Produtos";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(23, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(23, 55);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(6, 80);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(228, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(64, 51);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(228, 20);
            this.txtPreco.TabIndex = 4;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(64, 77);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(227, 21);
            this.cmbCategoria.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(64, 105);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(120, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(371, 49);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(381, 389);
            this.dgvProdutos.TabIndex = 1;
            // 
            // MenuProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.grbCadProduto);
            this.Name = "MenuProdutos";
            this.Text = "MenuProdutos";
            this.grbCadProduto.ResumeLayout(false);
            this.grbCadProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCadProduto;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvProdutos;
    }
}