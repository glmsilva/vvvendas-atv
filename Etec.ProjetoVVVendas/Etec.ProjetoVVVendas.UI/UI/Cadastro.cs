using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etec.ProjetoVVVendas.UI.DTO;
using Etec.ProjetoVVVendas.UI.BLL;


namespace Etec.ProjetoVVVendas.UI.UI
{
    public partial class Cadastro : UserControl
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.CPF = txtCpf.Text;
            cliente.Endereco = rtbEndereco.Text;
            cliente.Email = txtEmail.Text;

            BLL.ClienteBLL cadastrar = new ClienteBLL();
            cadastrar.novoCliente(cliente);
        }
    }
}
