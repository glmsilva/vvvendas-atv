using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etec.ProjetoVVVendas.UI.DTO;
using MySql.Data.MySqlClient;

namespace Etec.ProjetoVVVendas.UI.DAO
{
    public class OcorrenciaDAO
    {
        string _conexaoMySql = "";
        MySqlConnection con = null;

        public OcorrenciaDAO()
        {
            _conexaoMySql = "server=localhost;User id=root;password='';database=db_vendas";
        }

        public void InsertOcorrencia(Ocorrencia ocorrencia)
        {
            try
            {
                string sql = "Insert into tb_ocorrencia (id_cliente, data_oco, tipo, descricao) values (@id,@data,@tipo,@desc)";
                con = new MySqlConnection(_conexaoMySql);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", ocorrencia.IdCliente);
                cmd.Parameters.AddWithValue("data", ocorrencia.Data);
                cmd.Parameters.AddWithValue("@tipo", ocorrencia.Tipo);
                cmd.Parameters.AddWithValue("@desc", ocorrencia.Descricao);

                con.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Ocorrencia registrada");
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

        public DataTable retornaTabela(int campo) 
        {
            try
            {
                string sql = "select * from tb_ocorrencia where id_cliente = '" + campo + "'";
                con = new MySqlConnection(_conexaoMySql);
                con.Open();

                MySqlDataAdapter mda = new MySqlDataAdapter(sql, con);
                DataSet ds = new DataSet();

                mda.Fill(ds);
                con.Close();

                return ds.Tables[0];
                
            }
            catch(Exception erro)
            {
                throw erro;
            }
            

        } 
    }

}
