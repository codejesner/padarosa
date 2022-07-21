namespace Padarosa.Formularios
{
    partial class MenuUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastros = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtSenhaCad = new System.Windows.Forms.TextBox();
            this.txtEmailCad = new System.Windows.Forms.TextBox();
            this.txtNomeCad = new System.Windows.Forms.TextBox();
            this.lblSenhaCad = new System.Windows.Forms.Label();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.grbAtualizar = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtSenhaAtt = new System.Windows.Forms.TextBox();
            this.txtEmailAtt = new System.Windows.Forms.TextBox();
            this.txtNomeAtt = new System.Windows.Forms.TextBox();
            this.lblSenhaAtt = new System.Windows.Forms.Label();
            this.lblEmailAtt = new System.Windows.Forms.Label();
            this.lblNomeAtt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastros.SuspendLayout();
            this.grbAtualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(409, 12);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(563, 346);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // grbCadastros
            // 
            this.grbCadastros.Controls.Add(this.btnCadastrar);
            this.grbCadastros.Controls.Add(this.txtSenhaCad);
            this.grbCadastros.Controls.Add(this.txtEmailCad);
            this.grbCadastros.Controls.Add(this.txtNomeCad);
            this.grbCadastros.Controls.Add(this.lblSenhaCad);
            this.grbCadastros.Controls.Add(this.lblEmailCad);
            this.grbCadastros.Controls.Add(this.lblNomeCad);
            this.grbCadastros.Location = new System.Drawing.Point(12, 48);
            this.grbCadastros.Name = "grbCadastros";
            this.grbCadastros.Size = new System.Drawing.Size(380, 152);
            this.grbCadastros.TabIndex = 1;
            this.grbCadastros.TabStop = false;
            this.grbCadastros.Text = "Cadastros";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(96, 98);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtSenhaCad
            // 
            this.txtSenhaCad.Location = new System.Drawing.Point(96, 72);
            this.txtSenhaCad.Name = "txtSenhaCad";
            this.txtSenhaCad.Size = new System.Drawing.Size(219, 20);
            this.txtSenhaCad.TabIndex = 5;
            // 
            // txtEmailCad
            // 
            this.txtEmailCad.Location = new System.Drawing.Point(96, 46);
            this.txtEmailCad.Name = "txtEmailCad";
            this.txtEmailCad.Size = new System.Drawing.Size(219, 20);
            this.txtEmailCad.TabIndex = 4;
            // 
            // txtNomeCad
            // 
            this.txtNomeCad.Location = new System.Drawing.Point(96, 20);
            this.txtNomeCad.Name = "txtNomeCad";
            this.txtNomeCad.Size = new System.Drawing.Size(219, 20);
            this.txtNomeCad.TabIndex = 3;
            // 
            // lblSenhaCad
            // 
            this.lblSenhaCad.AutoSize = true;
            this.lblSenhaCad.Location = new System.Drawing.Point(6, 72);
            this.lblSenhaCad.Name = "lblSenhaCad";
            this.lblSenhaCad.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaCad.TabIndex = 2;
            this.lblSenhaCad.Text = "Senha";
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.Location = new System.Drawing.Point(6, 48);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(32, 13);
            this.lblEmailCad.TabIndex = 1;
            this.lblEmailCad.Text = "Email";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Location = new System.Drawing.Point(6, 24);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(82, 13);
            this.lblNomeCad.TabIndex = 0;
            this.lblNomeCad.Text = "Nome Completo";
            // 
            // grbAtualizar
            // 
            this.grbAtualizar.Controls.Add(this.btnAtualizar);
            this.grbAtualizar.Controls.Add(this.txtSenhaAtt);
            this.grbAtualizar.Controls.Add(this.txtEmailAtt);
            this.grbAtualizar.Controls.Add(this.txtNomeAtt);
            this.grbAtualizar.Controls.Add(this.lblSenhaAtt);
            this.grbAtualizar.Controls.Add(this.lblEmailAtt);
            this.grbAtualizar.Controls.Add(this.lblNomeAtt);
            this.grbAtualizar.Location = new System.Drawing.Point(12, 206);
            this.grbAtualizar.Name = "grbAtualizar";
            this.grbAtualizar.Size = new System.Drawing.Size(380, 152);
            this.grbAtualizar.TabIndex = 7;
            this.grbAtualizar.TabStop = false;
            this.grbAtualizar.Text = "Atualizar";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(96, 98);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtSenhaAtt
            // 
            this.txtSenhaAtt.Location = new System.Drawing.Point(96, 72);
            this.txtSenhaAtt.Name = "txtSenhaAtt";
            this.txtSenhaAtt.Size = new System.Drawing.Size(219, 20);
            this.txtSenhaAtt.TabIndex = 5;
            // 
            // txtEmailAtt
            // 
            this.txtEmailAtt.Location = new System.Drawing.Point(96, 46);
            this.txtEmailAtt.Name = "txtEmailAtt";
            this.txtEmailAtt.Size = new System.Drawing.Size(219, 20);
            this.txtEmailAtt.TabIndex = 4;
            // 
            // txtNomeAtt
            // 
            this.txtNomeAtt.Location = new System.Drawing.Point(96, 20);
            this.txtNomeAtt.Name = "txtNomeAtt";
            this.txtNomeAtt.Size = new System.Drawing.Size(219, 20);
            this.txtNomeAtt.TabIndex = 3;
            // 
            // lblSenhaAtt
            // 
            this.lblSenhaAtt.AutoSize = true;
            this.lblSenhaAtt.Location = new System.Drawing.Point(6, 72);
            this.lblSenhaAtt.Name = "lblSenhaAtt";
            this.lblSenhaAtt.Size = new System.Drawing.Size(67, 13);
            this.lblSenhaAtt.TabIndex = 2;
            this.lblSenhaAtt.Text = "Nova Senha";
            // 
            // lblEmailAtt
            // 
            this.lblEmailAtt.AutoSize = true;
            this.lblEmailAtt.Location = new System.Drawing.Point(6, 48);
            this.lblEmailAtt.Name = "lblEmailAtt";
            this.lblEmailAtt.Size = new System.Drawing.Size(32, 13);
            this.lblEmailAtt.TabIndex = 1;
            this.lblEmailAtt.Text = "Email";
            // 
            // lblNomeAtt
            // 
            this.lblNomeAtt.AutoSize = true;
            this.lblNomeAtt.Location = new System.Drawing.Point(6, 24);
            this.lblNomeAtt.Name = "lblNomeAtt";
            this.lblNomeAtt.Size = new System.Drawing.Size(82, 13);
            this.lblNomeAtt.TabIndex = 0;
            this.lblNomeAtt.Text = "Nome Completo";
            // 
            // MenuUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 392);
            this.Controls.Add(this.grbAtualizar);
            this.Controls.Add(this.grbCadastros);
            this.Controls.Add(this.dgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Usuarios";
            this.Load += new System.EventHandler(this.MenuUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastros.ResumeLayout(false);
            this.grbCadastros.PerformLayout();
            this.grbAtualizar.ResumeLayout(false);
            this.grbAtualizar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastros;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtSenhaCad;
        private System.Windows.Forms.TextBox txtEmailCad;
        private System.Windows.Forms.TextBox txtNomeCad;
        private System.Windows.Forms.Label lblSenhaCad;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.GroupBox grbAtualizar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtSenhaAtt;
        private System.Windows.Forms.TextBox txtEmailAtt;
        private System.Windows.Forms.TextBox txtNomeAtt;
        private System.Windows.Forms.Label lblSenhaAtt;
        private System.Windows.Forms.Label lblEmailAtt;
        private System.Windows.Forms.Label lblNomeAtt;
    }
}