using System;
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
                lblMessage.Text = "Credenciais inválidas.";
                lblMessage.ForeColor = Color.Red;
            } 
            else
            {
                var u = new LibPadarosa.Usuario();
                u.Email = txtEmail.Text;
                u.Senha = txtSenha.Text;
                var resultado = LibPadarosa.Banco.UsuarioDAO.Logar(u);
            }
        }
    }
}
