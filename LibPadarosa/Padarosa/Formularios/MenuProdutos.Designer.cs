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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbAtt = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.cmbProdAtt = new System.Windows.Forms.ComboBox();
            this.txtPrecoAtt = new System.Windows.Forms.TextBox();
            this.txtNomeAtt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnExcluirProd = new System.Windows.Forms.Button();
            this.grbCadProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbAtt.SuspendLayout();
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
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(64, 77);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(227, 21);
            this.cmbCategoria.TabIndex = 5;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(64, 51);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(228, 20);
            this.txtPreco.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(228, 20);
            this.txtNome.TabIndex = 3;
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
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(23, 55);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço";
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
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(371, 49);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(381, 344);
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // grbAtt
            // 
            this.grbAtt.Controls.Add(this.btnAtualizar);
            this.grbAtt.Controls.Add(this.cmbProdAtt);
            this.grbAtt.Controls.Add(this.txtPrecoAtt);
            this.grbAtt.Controls.Add(this.txtNomeAtt);
            this.grbAtt.Controls.Add(this.label1);
            this.grbAtt.Controls.Add(this.label2);
            this.grbAtt.Controls.Add(this.label3);
            this.grbAtt.Location = new System.Drawing.Point(12, 216);
            this.grbAtt.Name = "grbAtt";
            this.grbAtt.Size = new System.Drawing.Size(338, 161);
            this.grbAtt.TabIndex = 7;
            this.grbAtt.TabStop = false;
            this.grbAtt.Text = "Atualizar Produtos";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(64, 105);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(120, 23);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.Text = "Atualizar Produto";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // cmbProdAtt
            // 
            this.cmbProdAtt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdAtt.FormattingEnabled = true;
            this.cmbProdAtt.Location = new System.Drawing.Point(64, 77);
            this.cmbProdAtt.Name = "cmbProdAtt";
            this.cmbProdAtt.Size = new System.Drawing.Size(227, 21);
            this.cmbProdAtt.TabIndex = 5;
            // 
            // txtPrecoAtt
            // 
            this.txtPrecoAtt.Location = new System.Drawing.Point(64, 51);
            this.txtPrecoAtt.Name = "txtPrecoAtt";
            this.txtPrecoAtt.Size = new System.Drawing.Size(228, 20);
            this.txtPrecoAtt.TabIndex = 4;
            // 
            // txtNomeAtt
            // 
            this.txtNomeAtt.Location = new System.Drawing.Point(64, 25);
            this.txtNomeAtt.Name = "txtNomeAtt";
            this.txtNomeAtt.Size = new System.Drawing.Size(228, 20);
            this.txtNomeAtt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome";
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(561, 400);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(191, 38);
            this.btnCategorias.TabIndex = 8;
            this.btnCategorias.Text = "Adicionar Categoria";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnExcluirProd
            // 
            this.btnExcluirProd.Location = new System.Drawing.Point(371, 399);
            this.btnExcluirProd.Name = "btnExcluirProd";
            this.btnExcluirProd.Size = new System.Drawing.Size(184, 38);
            this.btnExcluirProd.TabIndex = 9;
            this.btnExcluirProd.Text = "Excluir Produto";
            this.btnExcluirProd.UseVisualStyleBackColor = true;
            this.btnExcluirProd.Click += new System.EventHandler(this.btnExcluirProd_Click);
            // 
            // MenuProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.btnExcluirProd);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.grbAtt);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.grbCadProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuProdutos";
            this.grbCadProduto.ResumeLayout(false);
            this.grbCadProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbAtt.ResumeLayout(false);
            this.grbAtt.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbAtt;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ComboBox cmbProdAtt;
        private System.Windows.Forms.TextBox txtPrecoAtt;
        private System.Windows.Forms.TextBox txtNomeAtt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnExcluirProd;
    }
}