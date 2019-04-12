using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Etec.ProjetoVVVendas.UI.BLL
{
    public class LoginBLL
    {

        public void cadastrarLogin(Login novoLogin)
        {
            try
            {
                DAO.LoginDAO login = new DAO.LoginDAO();
                login.insertLogin(novoLogin);
                
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }
    }
}
