using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etec.ProjetoVVVendas.UI.DAO;
using Etec.ProjetoVVVendas.UI.BLL;
using Etec.ProjetoVVVendas.UI.DTO;

namespace Etec.ProjetoVVVendas.UI.UI
{
    public partial class OcorrenciaUI : UserControl
    {
        public OcorrenciaUI()
        {
            InitializeComponent();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {

            OcorrenciaDAO novaOcorrencia = new OcorrenciaDAO();
            ValidarNumerico validarId = new ValidarNumerico();
            if(validarId.ValidarNumeros(txtIdBusca.Text, txtIdBusca.Name))
            {
                int id = int.Parse(txtIdBusca.Text);
                dgvOcorrencia.DataSource = novaOcorrencia.retornaTabela(id);
            }
            else
            {
                MessageBox.Show("Por favor, digite apenas número", "Erro");
            }
            
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Ocorrencia novaOcorrencia = new Ocorrencia();
            ValidarNumerico validar = new ValidarNumerico();
            if(validar.ValidarNumeros(txtId.Text, txtId.Name))
            {
                novaOcorrencia.IdCliente = int.Parse(txtId.Text);
                novaOcorrencia.Data = DateTime.Parse(dtpData.Text);
                novaOcorrencia.Tipo = cboTipo.Text;
                novaOcorrencia.Descricao = rtbDesc.Text;

                OcorrenciaDAO cadastrar = new OcorrenciaDAO();
                cadastrar.InsertOcorrencia(novaOcorrencia);
            }
            else
            {
                MessageBox.Show("Por favor, digite apenas número", "Erro");
            }

            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            cboTipo.Text = "";
            rtbDesc.Text = "";
            dtpData.Text = "";
        }
    }
}
