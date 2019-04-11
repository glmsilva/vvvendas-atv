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
            cliente.CPF = mskCPF.Text;
            cliente.Endereco = rtbEndereco.Text;
            cliente.Email = txtEmail.Text;

            BLL.ClienteBLL cadastrar = new ClienteBLL();
            cadastrar.novoCliente(cliente);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.CNPJ = mkdCNPJ.Text;
            fornecedor.Nome = txtNmEmp.Text;
            fornecedor.Endereco = rtbEnd.Text;
            fornecedor.Tel = txtTel.Text;

            FornecedorBLL novoFornecedor = new FornecedorBLL();
            novoFornecedor.cadastrarFornecedor(fornecedor);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
            txtNome.Text = String.Empty; ;
            mskCPF.Text = String.Empty; ;
            rtbEndereco.Text = String.Empty; ;
            txtEmail.Text = String.Empty; ;


        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            mkdCNPJ.Text = String.Empty;
            txtNmEmp.Text = String.Empty;
            rtbEnd.Text = String.Empty;
            txtTel.Text = String.Empty;
        }
    }
}
