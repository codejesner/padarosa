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
    public partial class MenuUsuarios : Form
    {
        private Usuario _u;
        public MenuUsuarios(Usuario u)
        {
            InitializeComponent();
            _u = u;
         }

        private void MenuUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
