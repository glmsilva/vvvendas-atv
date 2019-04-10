using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.ProjetoVVVendas.UI.DTO;
using Etec.ProjetoVVVendas.UI.DAO;

namespace Etec.ProjetoVVVendas.UI.BLL
{
    public class ClienteBLL
    {
        public ClienteBLL()
        {

        }

        public void novoCliente(Cliente cli)
        {
            DAO.ClienteDAO cliente = new ClienteDAO();
            cliente.insertCliente(cli);
        }
    }
}
