using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPadarosa.Banco
{
    public static class UsuarioDAO
    {

        // Logar
        public static DataTable Logar(Usuario u)
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "SELECT * FROM usuarios WHERE email = @email AND senha = @senha";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            // Subsituir o @termo pela variavel vinda por parâmetro
            cmd.Parameters.AddWithValue("@email", u.Email);
            cmd.Parameters.AddWithValue("@senha", u.Senha);

            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        // Cadastrar
        public static bool Cadastrar(Usuario u)
        {
            string comando = "INSERT INTO usuarios(nome_completo, email, senha) VALUES (@nome, @email, @senha)";
            
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", u.NomeCompleto);
            cmd.Parameters.AddWithValue("@email", u.Email);
            cmd.Parameters.AddWithValue("@senha", u.Senha);

            cmd.Prepare();
            if (cmd.ExecuteNonQuery() == 0)
            {
                conexaoBD.Desconectar(con);
                return false;
            }
            else
            {
                conexaoBD.Desconectar(con);
                return true;
            }
        }

    }
}
