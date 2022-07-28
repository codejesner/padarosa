using LibPadarosa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa.Formularios
{
    public partial class MenuPrincipal : Form
    {
        // Objeto global
        private Usuario _u;

        public MenuPrincipal(Usuario u)
        {
            InitializeComponent();
            _u = u;
            lblMensagem.Text = $"Bem-vindo {_u.NomeCompleto}! Escolha uma opção abaixo:";
            // Ocultar o botão USUARIO de todos, exceto do admin
            if (u.Id != 1)
            {
                btnUsuarios.Visible = false;
            }
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {
            var MenuComandas = new MenuComandas(_u);
            MenuComandas.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            var MenuUsuarios = new MenuUsuarios(_u);
            MenuUsuarios.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            var MenuProdutos = new MenuProdutos(_u);
            MenuProdutos.ShowDialog();
        }
    }
}
