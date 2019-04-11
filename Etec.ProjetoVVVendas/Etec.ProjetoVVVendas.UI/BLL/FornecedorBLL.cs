using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etec.ProjetoVVVendas.UI.DAO;
using Etec.ProjetoVVVendas.UI.DTO;

namespace Etec.ProjetoVVVendas.UI.BLL
{
    public class FornecedorBLL
    {
        public FornecedorBLL()
        {

        }

        public void cadastrarFornecedor(Fornecedor forn)
        {
            try
            {
                FornecedorDAO cadastrar = new FornecedorDAO();
                cadastrar.insertFornecedor(forn);
            }
            catch(Exception erro)
            {
                MessageBox.Show("Não foi possível realizar o cadastro. Erro:" + erro, "Erro");
            }
        }
    }
}
