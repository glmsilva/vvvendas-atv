using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Etec.ProjetoVVVendas.UI.DTO;
using System.Windows.Forms;

namespace Etec.ProjetoVVVendas.UI.DAO
{
    public class FornecedorDAO
    {

        string _conexaoMySql = "";
        MySqlConnection con = null;
        public FornecedorDAO()
        {
            _conexaoMySql = "server=localhost;User id=root;password='';database=db_vendas";
        }

        public void insertFornecedor(Fornecedor fornecedor)
        {
            try
            {


                string query = "Insert into tb_fornecedor (nome, cnpj, dsEndereco, tel) values (@nome, @cnpj, @end, @tel)";
                con = new MySqlConnection(_conexaoMySql);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nome", fornecedor.Nome);
                cmd.Parameters.AddWithValue("@cnpj", fornecedor.CNPJ);
                cmd.Parameters.AddWithValue("@end", fornecedor.Endereco);
                cmd.Parameters.AddWithValue("@tel", fornecedor.Tel);

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro efetuado com sucesso");

            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
