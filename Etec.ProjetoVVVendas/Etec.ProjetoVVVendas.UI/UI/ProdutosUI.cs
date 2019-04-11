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
using Etec.ProjetoVVVendas.UI.DTO;
using Etec.ProjetoVVVendas.UI.BLL;
using System.IO;

namespace Etec.ProjetoVVVendas.UI.UI
{
    public partial class ProdutosUI : UserControl
    {
        public ProdutosUI()
        {
            InitializeComponent();
        }

        MySqlConnection conexao = null;
        string _conexaoMySql = "";

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] imageBt = null;
                FileStream fstream = new FileStream(txtImg.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBt = br.ReadBytes((int)fstream.Length);
                //botao cadastrar
                Produto produto = new Produto();
                ValidarNumerico validar = new ValidarNumerico();
                if (validar.ValidarNumeros(txtId.Text, txtId.Name))

                    produto.ID = int.Parse(txtId.Text);



                if (validar.ValidarDecimal(txtValor.Text, txtValor.Name))
                    produto.Preco = float.Parse(txtValor.Text);
                produto.Quantidade = int.Parse(mkdQTD.Text);
                produto.Descricao = rtbDesc.Text;
                produto.Data = DateTime.Parse(dtpData.Text);
                produto.Imagem = imageBt;

                ProdutoBLL cadastrarProd = new ProdutoBLL();
                cadastrarProd.NovoProdutoEntrada(produto);
                
            }
            catch(Exception erro)
            {
                MessageBox.Show("Selecione uma imagem");
            }
            


        }

        private void btnEscolheImg_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dlg = new OpenFileDialog();
            openFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            openFileDialog1.Title = "Selecione a imagem.";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string nmFoto = openFileDialog1.FileName.ToString();
                    txtImg.Text = nmFoto;

                    pictureBox1.ImageLocation = nmFoto;
                }
            }catch(Exception erro)
            {
                MessageBox.Show("Erro:" + erro);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            ProdutoBLL prod = new ProdutoBLL();
            ValidarNumerico validaId = new ValidarNumerico();

            if(validaId.ValidarNumeros(txtIdProd.Text,"Campo ID") && validaId.ValidarDecimal(txtPreco.Text,"Campo Preço"))
            {
                int id = int.Parse(txtIdProd.Text);
                int qtd = int.Parse(mkdQt.Text);
                float valor = float.Parse(txtPreco.Text);
                float tot = float.Parse(lblValor.Text);

                produto.ID = id;
                produto.Preco = valor;
                produto.Quantidade = qtd;
                produto.Total = tot;
                produto.Data = DateTime.Parse(dtpSaida.Text);

                prod.NovoProdutoSaida(produto);
                
            }
            
            
        }

        public float preco;
        public int qtde;
        public float total;

        private void txtQt_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtQt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void mkdQt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mkdQt_TextChanged(object sender, EventArgs e)
        {
            ValidarNumerico validarCampo = new ValidarNumerico();


            if (txtPreco.Text != "" && mkdQt.Text != "")
            {
                if (validarCampo.ValidarDecimal(txtPreco.Text, txtPreco.Name))
                {
                    preco = float.Parse(txtPreco.Text);
                    qtde = int.Parse(mkdQt.Text);
                    total = qtde * preco;
                    string x = (qtde * preco).ToString();

                    lblValor.Text = x;


                }
                else
                {
                    MessageBox.Show("Digite apenas números", "Erro");
                }
            }
            
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtImg.Text = "";
            txtValor.Text = "";
            mkdQTD.Text = "";
            dtpData.Text = "";
            rtbDesc.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdProd.Text = "";
            txtPreco.Text = "";
            lblValor.Text = "0,00";
            mkdQt.Text = "";
            dtpSaida.Text = "";
        }
    }
}
