using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec.ProjetoVVVendas.UI.DTO
{
    public class Produto
    {
        int _id;
        DateTime _data;
        string _descricao;
        byte[] _imgProd;
        int _quantidade;
        float _preco;
        float _valorTotal;
       

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public byte[] Imagem
        {
            get { return _imgProd; }
            set { _imgProd = value; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        public float Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }

        public float Total
        {
            get
            {
                return _valorTotal;
            }
            set
            {
                _valorTotal = value;
            }
        }

        
    }
}
