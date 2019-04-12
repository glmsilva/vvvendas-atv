using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etec.ProjetoVVVendas.UI.BLL;
using Etec.ProjetoVVVendas.UI.DAO;

namespace Etec.ProjetoVVVendas.UI.UI
{
    public partial class EstoqueFuncionario : UserControl
    {
        public EstoqueFuncionario()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ValidarNumerico validar = new ValidarNumerico();

            if (validar.ValidarNumeros(mkdidEstoque.Text, mkdidEstoque.Name))
            {
                int id = int.Parse(mkdidEstoque.Text);
                try
                {
                    RelatorioDAO estoque = new RelatorioDAO();
                    dgvEstoque.DataSource = estoque.returnEstoqueID(id);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi possível conectar com banco de dados");
                }


            }
            
        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            try
            {
                RelatorioDAO estoque = new RelatorioDAO();
                dgvEstoque.DataSource = estoque.returnEstoque();
            }
            catch
            {
                MessageBox.Show("Erro ao conectar ao banco de dados");
            }
        }
    }
}
