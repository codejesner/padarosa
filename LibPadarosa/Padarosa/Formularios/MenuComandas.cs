using System;
using LibPadarosa;
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
    public partial class MenuComandas : Form
    {
        // objetos globais
        private Usuario _u;
        public MenuComandas(Usuario u)
        {
            InitializeComponent();
            _u = u;
            AtualizarDgv();
        }

        // Atualizar o DGV:
        private void AtualizarDgv()
        {
            dgvProdutos.DataSource = Banco.ProdutoDAO.ListarTudo();
        }


        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // Verificar se os campos estão vazios:
            if (txtComanda.Text.Length > 0 && txtProduto.Text.Length > 0)
            {
                int idProduto = int.Parse(txtProduto.Text);
                // Buscar o nome do produto:
                var r = Banco.ProdutoDAO.BuscarNomePorID(idProduto);
                txtProdutoLan.Text = r.Rows[0]["nome"].ToString();

                // Desativar o grbLançamento:
                grbInformacoes.Enabled = false;
                // Ativar o grbInfos:
                grbLancamento.Enabled = true;
            }
            else
            {
                MessageBox.Show("Os campos não podem estar vazios!");
            }
        }


        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Descobrir o número da linha da célula clicada:
            int numeroLinha = dgvProdutos.CurrentCell.RowIndex;
            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvProdutos.Rows[numeroLinha];

            txtProduto.Text = linha.Cells[0].Value.ToString();
        }

       
    }
}
