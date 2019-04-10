using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Etec.ProjetoVVVendas.UI.DAO
{
    public class LoginDAO
    {
        string _conexaoMySQL = "server=localhost;User id=root;password='';database=db_vendas";
        public void insertLogin(Login login)
        {
            MySqlConnection conexao = null;
            try
            {

                String sql = "INSERT INTO tb_login (login, senha, funcao) VALUES (@login,@senha,@funcao)";
                conexao = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@login", login.login);
                cmd.Parameters.AddWithValue("@senha", login.senha);
                cmd.Parameters.AddWithValue("@funcao", login.funcao);
               
                conexao.Open();
                cmd.ExecuteNonQuery();


            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
