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
    public partial class MenuProdutos : Form
    {

        private Produto _p = new Produto();
        private int _id;

        public MenuProdutos(Usuario u)
        {
            
            _id = u.Id;
            InitializeComponent();
            var data = new List<string>();

            DataTable dt = Banco.CategoriaDAO.NomeCategorias();
            foreach (DataRow dr in dt.Rows)
            {
                string nome = $"{dr["id"]} - {dr["nome"]}";
                data.Add(nome);

            }
            cmbCategoria.DataSource = data;
            dgvProdutos.DataSource = Banco.ProdutoDAO.ListarTudo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length >= 3 && txtPreco.Text.Length > 0)
            {
                _p.Nome = txtNome.Text;
                _p.Preco = double.Parse(txtPreco.Text);
                
                _p.IdCategoria = int.Parse(cmbCategoria.Text.Split(' ')[0].ToString());
                _p.IdRespCadastro = _id;

                if (Banco.ProdutoDAO.Cadastrar(_p))
                {
                    MessageBox.Show("Cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("else");
                }
            }
            else
            {
                MessageBox.Show("Verifique as informações.");
            }

            

           



        }

    }
}
