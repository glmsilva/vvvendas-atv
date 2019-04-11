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
    public class RelatorioDAO
    {
        string _conexaoMySql = "";
        MySqlConnection conexao = null;

        public RelatorioDAO()
        {
            _conexaoMySql = "server=localhost;User id=root;password='';database=db_vendas";
            
        }

        public DataTable returnEstoque()
        {
            _conexaoMySql = "server=localhost;User id=root;password='';database=db_vendas";
            conexao = new MySqlConnection(_conexaoMySql);
           
                conexao.Open();
                string sql = "Select * from tb_estoque";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                mda.Fill(ds);

                conexao.Close();

                return ds.Tables[0];
        }

        public DataTable returnEstoqueID(int id)
        {
            _conexaoMySql = "server=localhost;User id=root;password='';database=db_vendas";
            conexao = new MySqlConnection(_conexaoMySql);
           
             conexao.Open();
             string sql = "Select * from tb_estoque where id_produto = @id";
           
             MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);   
             MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
             DataSet ds = new DataSet();

             mda.Fill(ds);

             conexao.Close();

             return ds.Tables[0];
        }

        public DataTable returnEntrada()
        {
            _conexaoMySql = "server=localhost;User id=root;password='';database=db_vendas";
            conexao = new MySqlConnection(_conexaoMySql);

            conexao.Open();
            string sql = "Select * from tb_entrada_produto";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);

            MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            mda.Fill(ds);

            conexao.Close();

            return ds.Tables[0];
        }

        public DataTable returnEntradaID(int id)
        {
            _conexaoMySql = "server=localhost;User id=root;password='';database=db_vendas";
            conexao = new MySqlConnection(_conexaoMySql);

            conexao.Open();
            string sql = "Select * from tb_entrada_produto where id_produto = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            mda.Fill(ds);

            conexao.Close();

            return ds.Tables[0];
        }

        public DataTable returnSaida()
        {
            _conexaoMySql = "server=localhost;User id=root;password='';database=db_vendas";
            conexao = new MySqlConnection(_conexaoMySql);

            conexao.Open();
            string sql = "Select * from tb_saida_produto";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);

            MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            mda.Fill(ds);

            conexao.Close();

            return ds.Tables[0];
        }

        public DataTable returnSaidaID(int id)
        {
            _conexaoMySql = "server=localhost;User id=root;password='';database=db_vendas";
            conexao = new MySqlConnection(_conexaoMySql);

            conexao.Open();
            string sql = "Select * from tb_saida_produto where id_produto = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            mda.Fill(ds);

            conexao.Close();

            return ds.Tables[0];
        }
    }
}
