using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec.ProjetoVVVendas.UI.DTO
{
    public class Cliente
    {
        int _id;
        string _cpf;
        string _nome;
        string _endereco;
        string _email;

        public int ID
        {

            get { return _id; }

            set { _id = value; }
        }

        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
