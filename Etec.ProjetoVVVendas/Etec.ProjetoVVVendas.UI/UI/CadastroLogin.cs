using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etec.ProjetoVVVendas.UI.DAO;
using Etec.ProjetoVVVendas.UI.BLL;

using Etec.ProjetoVVVendas.UI.DTO;

namespace Etec.ProjetoVVVendas.UI.UI
{
    public partial class CadastroLogin : Form
    {

        string Funcao;
        public CadastroLogin()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            BLL.LoginBLL cadastroLogin = new BLL.LoginBLL();
            Login novoLogin = new Login();
            novoLogin.login = txtLogin.Text;
            novoLogin.senha = txtSenha.Text;
            novoLogin.funcao = Funcao;

            cadastroLogin.cadastrarLogin(novoLogin);
        }

        private void CadastroLogin_Load(object sender, EventArgs e)
        {

        }

        private void rdoFunc_CheckedChanged(object sender, EventArgs e)
        {
            Funcao = "Funcionário";
        }

        private void rdoGer_CheckedChanged(object sender, EventArgs e)
        {
            Funcao = "Gerente";
        }
    }
}
