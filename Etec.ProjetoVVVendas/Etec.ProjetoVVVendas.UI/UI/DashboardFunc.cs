using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etec.ProjetoVVVendas.UI.UI
{
    public partial class DashboardFunc : Form
    {
        public DashboardFunc()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            pnlLateral.Top = btnCadastro.Top;
            pnlLateral.Height = btnCadastro.Height;
            cadastro1.Show();
            produtosUI1.Hide();
            ocorrenciaUI1.Hide();
            estoqueFuncionario1.Hide();

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            pnlLateral.Top = btnProduto.Top;
            pnlLateral.Height = btnProduto.Height;
            cadastro1.Hide();
            produtosUI1.Show();
            ocorrenciaUI1.Hide();
            estoqueFuncionario1.Hide();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            pnlLateral.Top = btnRelatorio.Top;
            pnlLateral.Height = btnRelatorio.Height;
            cadastro1.Hide();
            produtosUI1.Hide();
            ocorrenciaUI1.Hide();
            estoqueFuncionario1.Show();
        }

        private void btnOcorrencia_Click(object sender, EventArgs e)
        {
            pnlLateral.Top = btnOcorrencia.Top;
            pnlLateral.Height = btnOcorrencia.Height;
            cadastro1.Hide();
            produtosUI1.Hide();
            ocorrenciaUI1.Show();
            estoqueFuncionario1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
