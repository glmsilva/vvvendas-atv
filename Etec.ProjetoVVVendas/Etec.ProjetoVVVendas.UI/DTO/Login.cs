using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec.ProjetoVVVendas.UI
{
    public class Login

    {
        string _login;
        string _senha;
        string _funcao;

        public string login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
            }
        }
        public string senha {


            get
            {
                return _senha;
            }
            set
            {
                _senha = value;
            }

        }

        public string funcao {

            get
            {
                return _funcao;
            }
            set
            {
                _funcao = value;
            }

        }

    }
}
