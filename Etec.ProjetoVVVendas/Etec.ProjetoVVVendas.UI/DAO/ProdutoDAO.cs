using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.ProjetoVVVendas.UI.DTO;
using MySql.Data.MySqlClient;

namespace Etec.ProjetoVVVendas.UI.DAO
{
    class ProdutoDAO
    {
        String _conexaoMysql = String.Empty;

        MySqlConnection conection = null;

        public ProdutoDAO()
        {
            _conexaoMysql = "server=localhost;user id=root;password='';database=db_vendas";

        }

        public List<Produto> selectListProdutos()
        {
            try
            {
                using (conection = new MySqlConnection(_conexaoMysql))
                {
                    using (MySqlCommand command = new MySqlCommand("Select * from Estoque", conection))
                    {
                        conection.Open();
                        List<Produto> listaProdutos = new List<Produto>();
                        command.Connection = conection;
                        using (MySqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Produto produto = new Produto();
                                produto.ID = (int)dr["id"];
                               // produto.Nome = (String)dr["Nome"];
                                produto.Preco = (float)(dr["Preco"]);
                                listaProdutos.Add(produto);
                            }
                        }
                        return listaProdutos;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar estoque " + ex.Message);
            }
        }

     /*   public Produto SelectProdutoByID(int id)
        {
            try
            {
                string query = "SELECT * FROM PRODUTOS where id = @id";
                conection = new MySqlConnection(_conexaoMysql);
                {
                    
                    MySqlCommand comando = new MySqlCommand(query, conection);

                    comando.Parameters.AddWithValue("@id", id);
                    conection.Open();

                    MySqlDataReader dr;

                    Produto produto = new Produto();

                    dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    while (dr.Read())
                    {

                        //produto.ID = Convert.ToInt32(dr["id"]);
                        produto.ID = (int)(dr["id"]);

                        produto.Nome = dr["Nome"].ToString();

                        produto.Preco = (float)(dr["Preco"]);
                    }
                    return produto;
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        */
        public DataTable SelectProduto()
        {
            try
            {
                string sql = "SELECT * FROM produto";
                conection = new MySqlConnection(_conexaoMysql);
                MySqlCommand comando = new MySqlCommand(sql, conection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = comando;
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public void insertEntrada(Produto produto)
        {
            try
            {
                String sql = "INSERT INTO tb_entrada_produto (id_produto,qtde,valor_unitario, data_entrada, foto, descricao) VALUES (@id,@qtde,@valor,@data,@foto,@desc)";
                conection = new MySqlConnection(_conexaoMysql);
                MySqlCommand cmd = new MySqlCommand(sql, conection);
                cmd.Parameters.AddWithValue("@id", produto.ID);
                cmd.Parameters.AddWithValue("@qtde", produto.Quantidade);
                cmd.Parameters.AddWithValue("@valor", produto.Preco);
                cmd.Parameters.AddWithValue("@data", produto.Data);
                cmd.Parameters.AddWithValue("@foto", produto.Imagem);
                cmd.Parameters.AddWithValue("@desc", produto.Descricao);

                conection.Open();
                cmd.ExecuteNonQuery();
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

        public void insertSaida(Produto produto)
        {
            try
            {
                string query = "Insert into tb_saida_produto(id_produto, qtde, data_saida, valor_unitario,valor_total) values (@id,@qtde, @data, @valor,@total)";
                conection = new MySqlConnection(_conexaoMysql);

                MySqlCommand cmd = new MySqlCommand(query, conection);
                
                cmd.Parameters.AddWithValue("@id", produto.ID);
                cmd.Parameters.AddWithValue("@qtde", produto.Quantidade);
                cmd.Parameters.AddWithValue("@data", produto.Data);
                cmd.Parameters.AddWithValue("@valor", produto.Preco);
                cmd.Parameters.AddWithValue("@total", produto.Total);

                conection.Open();
                cmd.ExecuteNonQuery();

            }catch(Exception erro)
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
