using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etec.ProjetoVVVendas.UI.BLL
{
    class ValidarNumerico
    {
        public ValidarNumerico()
        {

        }

        public bool ValidarNumeros(string campoValidar, string nomeCampo)
        {
            try
            {
                int numero;
                numero = int.Parse(campoValidar);
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("O campo " + nomeCampo + " está inválido", "Etec");
                return false;

            }
        }

        public bool ValidarDecimal(string campoValidar, string nomeCampo)
        {
            try
            {
                float numero;
                numero = float.Parse(campoValidar);
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("O campo " + nomeCampo + " está inválido", "Etec");
                return false;

            }
        }
    }
}
