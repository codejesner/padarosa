﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length <= 3 && txtSenha.Text.Length <= 3)
            {
                lblMessage.Text = "Verifique as informações digitadas.";
                lblMessage.ForeColor = Color.Red;
            } 
            else
            {
                var u = new LibPadarosa.Usuario();
                u.Email = txtEmail.Text;
                u.Senha = txtSenha.Text;
                var resultado = Banco.UsuarioDAO.Logar(u);
                
                // Verificando se o banco retornou algum dado
                if (resultado.Rows.Count == 0)
                {
                    lblMessage.Text = "Credenciais inválidas.";
                    lblMessage.ForeColor = Color.Red;
                }
                else
                {
                    u.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                    u.Id = int.Parse(resultado.Rows[0]["id"].ToString());

                    // Abrindo outra janela.
                    var MenuPrincipal = new Formularios.MenuPrincipal(u);
                    Hide();
                    MenuPrincipal.ShowDialog();
                    // Ao sair da anterior, mostrar novamente
                    Show();
                    txtEmail.Clear();
                    txtSenha.Clear();
                }

            }
        }
    }
}
