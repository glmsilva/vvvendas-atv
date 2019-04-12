using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec.ProjetoVVVendas.UI.DTO
{
    public class Fornecedor
    {
        string _nome;
        string _cnpj;
        string _endereco;
        string _tel;

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string CNPJ
        {
            get
            {
                return _cnpj;
            }
            set
            {
                _nome = value;
            }

        }

        public string Endereco
        {
            get
            {
                return _endereco;
            }
            set
            {
                _endereco = value;
            }
        }

        public string Tel
        {
            get
            {
                return _tel;
            }
            set
            {
                _tel = value;
            }
        }
    }
}
