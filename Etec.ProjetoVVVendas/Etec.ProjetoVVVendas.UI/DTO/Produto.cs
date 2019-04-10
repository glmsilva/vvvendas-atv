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
        string _nome;
        string _descricao;
        string _imgProd;
        int _quantidade;
        float _preco;
       

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public string Imagem
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

        
    }
}
