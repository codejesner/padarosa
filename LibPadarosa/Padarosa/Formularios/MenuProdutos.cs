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
        private int _idSelecionado;
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
            cmbCategoria.DataSource = DateTableToArray();
            cmbProdAtt.DataSource = DateTableToArray();
            AtualizarDgv();
        }

        private void AtualizarDgv()
        {
            dgvProdutos.DataSource = Banco.ProdutoDAO.ListarTudo();
        }
        private List<string> DateTableToArray()
        {
            var data = new List<string>();

            DataTable dt = Banco.CategoriaDAO.NomeCategorias();
            foreach (DataRow dr in dt.Rows)
            {
                string nome = $"{dr["id"]} - {dr["nome"]}";
                data.Add(nome);

            }
            return data;
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
                    txtNome.Clear();
                    txtPreco.Clear();
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Erro ao tentar cadastrar");
                }
            }
            else
            {
                MessageBox.Show("Verifique as informações.");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            _p.Nome = txtNomeAtt.Text;
            _p.Preco = double.Parse(txtPrecoAtt.Text);
            _p.IdCategoria = int.Parse(cmbProdAtt.Text.Split(' ')[0].ToString());
            _p.IdRespCadastro = _id;

            // Chamar o Modificar
            if (Banco.ProdutoDAO.Modificar(_p))
            {
                MessageBox.Show("Usuario modificado com sucesso");
                txtNomeAtt.Clear();
                txtPrecoAtt.Clear();
                AtualizarDgv();
            }
            else
            {
                MessageBox.Show("Verifique as informações.");
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Descobrir o numero da linha da célula clicada.
            int numeroLinha = dgvProdutos.CurrentCell.RowIndex;
            // Guardar toda a linha e um objeto DataRow
            var linha = dgvProdutos.Rows[numeroLinha];
            // Atribuindo os valores da celulas para os textbox
            _p.Id = int.Parse(linha.Cells[0].Value.ToString());
            txtNomeAtt.Text = linha.Cells[1].Value.ToString();
            txtPrecoAtt.Text = linha.Cells[2].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            var MenuCategorias = new MenuCategorias();
            MenuCategorias.ShowDialog();
        }

        private void btnExcluirProd_Click(object sender, EventArgs e)
        {
            if (Banco.ProdutoDAO.Remover(_idSelecionado))
            {
                MessageBox.Show("Produto removido com sucesso!");
                AtualizarDgv();
            }
            else
            {
                MessageBox.Show("Selecione o produto para remover");
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
