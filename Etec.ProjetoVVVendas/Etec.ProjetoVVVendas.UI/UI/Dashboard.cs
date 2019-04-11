using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etec.ProjetoVVVendas.UI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            ocorrenciaUI1.Hide();
            cadastro1.Hide();
            relatorioUI1.Hide();
            produtosUI1.Show();
            pnlLateral.Top = btnProduto.Top;
            pnlLateral.Height = btnProduto.Height;
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            pnlLateral.Top = btnVendas.Top;
            pnlLateral.Height = btnVendas.Height;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            ocorrenciaUI1.Hide();
            produtosUI1.Hide();
            relatorioUI1.Hide();
            pnlLateral.Top = btnCadastro.Top;
            pnlLateral.Height = btnCadastro.Height;
            cadastro1.Show();
        }

        private void btnOcorrencia_Click(object sender, EventArgs e)
        {
            
            cadastro1.Hide();
            produtosUI1.Hide();
            relatorioUI1.Hide();
            pnlLateral.Top = btnOcorrencia.Top;
            pnlLateral.Height = btnOcorrencia.Height;
            ocorrenciaUI1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_UI telaLogin = new Login_UI();
            telaLogin.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlLateral.Height = button4.Height;
            pnlLateral.Top = button4.Top;
            cadastro1.Hide();
            produtosUI1.Hide();
            ocorrenciaUI1.Hide();
            relatorioUI1.Show();
        }
    }
}
