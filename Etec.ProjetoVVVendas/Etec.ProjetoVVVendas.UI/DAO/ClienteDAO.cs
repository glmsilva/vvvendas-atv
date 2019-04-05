using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.ProjetoVVVendas.UI.DTO;
using MySql.Data.MySqlClient;

namespace Etec.ProjetoVVVendas.UI.DAO
{
    public class ClienteDAO
    {
        string _conexaoMySql = String.Empty;
        MySqlConnection conexao = null;
    }
}
