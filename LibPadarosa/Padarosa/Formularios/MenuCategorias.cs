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
    public partial class MenuCategorias : Form
    {
        LibPadarosa.Categoria c = new LibPadarosa.Categoria();
        private int _idSelecionado;
        public MenuCategorias()
        {
            InitializeComponent();
            AtualizarDGV();
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void AtualizarDGV()
        {
            dgvCategorias.DataSource = Banco.CategoriaDAO.NomeCategorias();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numeroLinha = dgvCategorias.CurrentCell.RowIndex;
            var linha = dgvCategorias.Rows[numeroLinha];
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());
            txtNomeCategAtt.Text = linha.Cells[1].Value.ToString();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNomeCategAtt.Text.Length >= 3)
            {
                c.Id = _idSelecionado;
                c.Nome = txtNomeCategAtt.Text;

                if (Banco.CategoriaDAO.Modificar(c))
                {
                    MessageBox.Show("Categoria alterada com sucesso!");
                    txtNomeCategAtt.Clear();
                    AtualizarDGV();

                }

            }
            else
            {
                MessageBox.Show("Insira um valor válido.");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeCateg.Text.Length >= 3)
            {
                c.Nome = txtNomeCateg.Text;
                if (Banco.CategoriaDAO.Cadastrar(c))
                {
                    MessageBox.Show("Categoria cadastrada com sucesso!");
                    AtualizarDGV();
                    txtNomeCateg.Clear();
                }
                else
                {
                    MessageBox.Show("Erro ao tentar cadastrar.");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente.");
            }
        }
    }
}
