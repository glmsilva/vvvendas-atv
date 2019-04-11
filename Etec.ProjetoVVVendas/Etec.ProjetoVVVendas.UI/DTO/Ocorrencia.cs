using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec.ProjetoVVVendas.UI.DTO
{
    public class Ocorrencia
    {
        int _idCliente;
        DateTime _data;
        string _tipo;
        string _desc;

        public int IdCliente
        {
            get
            {
                return _idCliente;
            }
            set
            {
                _idCliente = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        public string Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
            }
        }

        public string Descricao
        {
            get
            {
                return _desc;
            }
            set
            {
                _desc = value;
            }
        }
    }
}
