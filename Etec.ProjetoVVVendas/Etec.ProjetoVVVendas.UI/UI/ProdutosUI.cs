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

            byte[] imageBt = null;
            FileStream fstream = new FileStream(txtImg.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);
            //botao cadastrar
            Produto produto = new Produto();
            ValidarNumerico validar = new ValidarNumerico();
            if (validar.ValidarNumeros(txtId.Text, txtId.Name))
            
                produto.ID = int.Parse(txtId.Text);

            
            if (validar.ValidarNumeros(txtQtd.Text, txtQtd.Name))
            
                produto.Quantidade = int.Parse(txtQtd.Text);



            if (validar.ValidarDecimal(txtValor.Text, txtValor.Name))
                produto.Preco = float.Parse(txtValor.Text);

            produto.Descricao = rtbDesc.Text;
            produto.Data = DateTime.Parse(dtpData.Text);
            produto.Imagem = imageBt;

            ProdutoBLL cadastrarProd = new ProdutoBLL();
            cadastrarProd.NovoProdutoEntrada(produto);
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
    }
}
