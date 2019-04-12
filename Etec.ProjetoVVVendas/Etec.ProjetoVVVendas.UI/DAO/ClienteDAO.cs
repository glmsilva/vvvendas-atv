using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etec.ProjetoVVVendas.UI.DTO;
using MySql.Data.MySqlClient;

namespace Etec.ProjetoVVVendas.UI.DAO
{
    public class ClienteDAO
    {
        string _conexaoMySql = String.Empty;
        MySqlConnection conection = null;


        public void insertCliente(Cliente cliente)
        {
            _conexaoMySql = "server=localhost;User id=root;password='';database=db_vendas";
            try
            {
                String sql = "INSERT INTO tb_cliente (nome,cpf,dsEndereco,email) VALUES (@nome,@cpf,@end,@email)";
                conection = new MySqlConnection(_conexaoMySql);
                MySqlCommand cmd = new MySqlCommand(sql, conection);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@cpf", cliente.CPF);
                cmd.Parameters.AddWithValue("@end", cliente.Endereco);
                cmd.Parameters.AddWithValue("@email", cliente.Email);
                
                

                conection.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso");
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conection.Close();
            }
        }
    }
}
