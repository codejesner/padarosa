namespace Padarosa.Formularios
{
    partial class MenuCategorias
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
            this.grbAtt = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtNomeCategAtt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.grbCadProduto = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNomeCateg = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.grbAtt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.grbCadProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAtt
            // 
            this.grbAtt.Controls.Add(this.btnAtualizar);
            this.grbAtt.Controls.Add(this.txtNomeCategAtt);
            this.grbAtt.Controls.Add(this.label3);
            this.grbAtt.Location = new System.Drawing.Point(447, 57);
            this.grbAtt.Name = "grbAtt";
            this.grbAtt.Size = new System.Drawing.Size(323, 91);
            this.grbAtt.TabIndex = 10;
            this.grbAtt.TabStop = false;
            this.grbAtt.Text = "Atualizar Categoria";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(64, 51);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(120, 23);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.Text = "Atualizar Produto";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtNomeCategAtt
            // 
            this.txtNomeCategAtt.Location = new System.Drawing.Point(64, 25);
            this.txtNomeCategAtt.Name = "txtNomeCategAtt";
            this.txtNomeCategAtt.Size = new System.Drawing.Size(228, 20);
            this.txtNomeCategAtt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AllowUserToResizeColumns = false;
            this.dgvCategorias.AllowUserToResizeRows = false;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(12, 171);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.Size = new System.Drawing.Size(758, 287);
            this.dgvCategorias.TabIndex = 9;
            this.dgvCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellClick);
            // 
            // grbCadProduto
            // 
            this.grbCadProduto.Controls.Add(this.btnCadastrar);
            this.grbCadProduto.Controls.Add(this.txtNomeCateg);
            this.grbCadProduto.Controls.Add(this.lblNome);
            this.grbCadProduto.Location = new System.Drawing.Point(12, 49);
            this.grbCadProduto.Name = "grbCadProduto";
            this.grbCadProduto.Size = new System.Drawing.Size(338, 99);
            this.grbCadProduto.TabIndex = 8;
            this.grbCadProduto.TabStop = false;
            this.grbCadProduto.Text = "Cadastrar Produtos";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(64, 51);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(120, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNomeCateg
            // 
            this.txtNomeCateg.Location = new System.Drawing.Point(64, 25);
            this.txtNomeCateg.Name = "txtNomeCateg";
            this.txtNomeCateg.Size = new System.Drawing.Size(228, 20);
            this.txtNomeCateg.TabIndex = 3;
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
            // MenuCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 470);
            this.Controls.Add(this.grbAtt);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.grbCadProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuCategorias";
            this.grbAtt.ResumeLayout(false);
            this.grbAtt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.grbCadProduto.ResumeLayout(false);
            this.grbCadProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAtt;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtNomeCategAtt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.GroupBox grbCadProduto;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNomeCateg;
        private System.Windows.Forms.Label lblNome;
    }
}