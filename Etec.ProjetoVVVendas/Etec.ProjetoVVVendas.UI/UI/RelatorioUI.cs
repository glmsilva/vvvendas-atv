using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Etec.ProjetoVVVendas.UI.DAO;
using Etec.ProjetoVVVendas.UI.BLL;

namespace Etec.ProjetoVVVendas.UI.UI
{
    public partial class RelatorioUI : UserControl
    {
        public RelatorioUI()
        {
            InitializeComponent();
        }

        string _conexaoMySql = "";
        MySqlConnection conexao = null;

        private void btnAtt_Click(object sender, EventArgs e)
        {
            try
            {
                RelatorioDAO estoque = new RelatorioDAO();
                dgvEstoque.DataSource = estoque.returnEstoque();
            }
            catch
            {

            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ValidarNumerico validar = new ValidarNumerico();

            if(validar.ValidarNumeros(mkdidEstoque.Text, mkdidEstoque.Name))
            {
                int id = int.Parse(mkdidEstoque.Text);
                try
                {
                    RelatorioDAO estoque = new RelatorioDAO();
                    dgvEstoque.DataSource = estoque.returnEstoqueID(id);
                }catch(Exception erro)
                {
                    MessageBox.Show("Não foi possível conectar com banco de dados");
                }


            }
            
        }

        private void btnAttEntr_Click(object sender, EventArgs e)
        {
            try
            {
                RelatorioDAO entrada = new RelatorioDAO();
                dgvEntrada.DataSource = entrada.returnEntrada();
;            }
            catch(Exception erro)
            {
                MessageBox.Show("Não foi possível conectar com banco de dados");
            }
        }

        private void btnConsultaEntrada_Click(object sender, EventArgs e)
        {
            ValidarNumerico validar = new ValidarNumerico();
            try
            {
                if (validar.ValidarNumeros(mkdEntrada.Text, "Id Produto"))
                {
                    int id = int.Parse(mkdEntrada.Text);
                    RelatorioDAO entrada = new RelatorioDAO();
                    dgvEntrada.DataSource = entrada.returnEntradaID(id);
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Não foi possível conectar com banco de dados");
            }
            
        }

        private void btnAttSai_Click(object sender, EventArgs e)
        {
            try
            {
                RelatorioDAO saida = new RelatorioDAO();
                dgvSaida.DataSource = saida.returnSaida();
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível conectar com banco de dados");
            }
        }

        private void btnConsultaVenda_Click(object sender, EventArgs e)
        {
            ValidarNumerico validar = new ValidarNumerico();
            try
            {
                if (validar.ValidarNumeros(mkdVenda.Text, "Id Produto"))
                {
                    int id = int.Parse(mkdVenda.Text);
                    RelatorioDAO saida = new RelatorioDAO();
                    dgvSaida.DataSource = saida.returnSaidaID(id);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível conectar com banco de dados");
            }
        }
    }
}
