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
        private int _idSelecionado;
        public MenuUsuarios(Usuario u)
        {
            InitializeComponent();
            _u = u;
            // Carregar dados para o DataGridView
            AtualizarDGV();

         }

        private void AtualizarDGV()
        {
            dgvUsuarios.DataSource = Banco.UsuarioDAO.ListarTudo();
        }
        private void MenuUsuarios_Load(object sender, EventArgs e)
        {

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var u = new Usuario();
            var valida = txtNomeCad.Text.Length > 5 && txtSenhaCad.Text.Length >= 6 && txtEmailCad.Text.Length >= 6;

            if (valida)
            {
                u.NomeCompleto = txtNomeCad.Text;
                u.Email = txtEmailCad.Text;
                u.Senha = txtSenhaCad.Text;
                // Chamar o cadastrar
                if (Banco.UsuarioDAO.Cadastrar(u))
                {
                    MessageBox.Show("Cadastrado com sucesso!");
                    txtNomeCad.Clear();
                    txtSenhaCad.Clear();
                    txtEmailCad.Clear();
                    // Atulizar o DataGridView
                    AtualizarDGV();
                }
                else
                {
                    MessageBox.Show("Houve um erro no cadastro. Verifique as informações");
                }
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas.");
            }
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grbAtualizar.Enabled = true;
            // Descobrir o numero da linha da célula clicada.
            int numeroLinha = dgvUsuarios.CurrentCell.RowIndex;
            // Guardar toda a linha e um objeto DataRow
            var linha = dgvUsuarios.Rows[numeroLinha];
            // Atribuindo os valores da celulas para os textbox
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());
            txtNomeAtt.Text = linha.Cells[1].Value.ToString();
            txtEmailAtt.Text = linha.Cells[2].Value.ToString();
            lblExcluir.ForeColor = Color.Red;
            lblExcluir.Text = $"{linha.Cells[0].Value} - {linha.Cells[1].Value} - {linha.Cells[2].Value}";


        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var u = new Usuario();
            u.NomeCompleto = txtNomeAtt.Text;
            u.Email = txtEmailAtt.Text;
            u.Senha = txtSenhaAtt.Text;
            u.Id = _idSelecionado;

            // Chamar o Modificar
            if(Banco.UsuarioDAO.Modificar(u)) { 
                MessageBox.Show("Usuario modificado com sucesso");
                // Limpar os campos
                txtNomeAtt.Clear();
                txtEmailAtt.Clear();
                txtSenhaAtt.Clear();
                AtualizarDGV();
                grbAtualizar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Verifique as informações.");
            }
        }
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var r  = MessageBox.Show("Deseja realmente apagar?", "Atenção", MessageBoxButtons.YesNo);
            if(r == DialogResult.Yes)
            {
                if (Banco.UsuarioDAO.RemoverPorId(_idSelecionado))
                {
                    MessageBox.Show("Usuario removido com sucesso!");
                    AtualizarDGV();
                    lblExcluir.Text = "";
                    txtNomeAtt.Clear();
                    txtEmailAtt.Clear();
                    txtSenhaAtt.Clear();
                    grbAtualizar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Selecione o usuario para remover");
                }
            }
        }
    }
}
