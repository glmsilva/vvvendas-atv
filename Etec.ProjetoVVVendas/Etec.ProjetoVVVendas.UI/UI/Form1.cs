using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Etec.ProjetoVVVendas.UI
{
    public partial class Login_UI : Form
    {

        string Funcao;
        public Login_UI()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            DTO.Cliente cliente = new DTO.Cliente();

            MySqlConnection conexao = new MySqlConnection();
            int i = 0;
            try
            {

                string con = "server=localhost;User id=root;password='';database=db_vendas";
                conexao.ConnectionString = con;
                conexao.Open();
                MySqlCommand cmd = conexao.CreateCommand();
                string query = "select * from tb_login where login = '" + txtLogin.Text + "' and senha ='" + txtSenha.Text + "' and funcao = '"+ Funcao +"'";


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    MessageBox.Show("Você digitou um Login ou Senha invalido");
                }
                else if(Funcao == "Gerente")
                {

                    Dashboard painelGerente = new Dashboard();
                    this.Hide();
                    painelGerente.Show();

                }
                else
                {

                    UI.DashboardFunc painel = new UI.DashboardFunc();
                    this.Hide();
                    painel.Show();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {
            UI.CadastroLogin cadastroLogin = new UI.CadastroLogin();
            cadastroLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void rdoGerente_CheckedChanged(object sender, EventArgs e)
        {
            Funcao = "Gerente";
        }

        private void rdoFunc_CheckedChanged(object sender, EventArgs e)
        {
            Funcao = "Funcionário";
        }
    }
}
