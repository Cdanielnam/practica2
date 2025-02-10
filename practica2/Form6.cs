using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        double TasaI;

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {


        }

        private void rdbInteres3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInteres3.Checked == true)
            {
                textTasaInterEX.Enabled = true;
                textTasaInterEX.Focus();


            }
            else
            {
                textTasaInterEX.Text = "0";
                textTasaInterEX.Enabled = false;
            }
        }

        private void rdbInteres1_Click(object sender, EventArgs e)
        {
            TasaI = 0.12;
        }

        private void rdbInteres2_Click(object sender, EventArgs e)
        {
            TasaI = 0.23;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAnalisis_Click(object sender, EventArgs e)


        {


            string NomEmpre;
            double MontoInic = 0, MontoFin = 0;
            int Tiempo;

            NomEmpre = txtEmpresa.Text;
            NomEmpre = NomEmpre.Trim();

            if (NomEmpre.Length == 0)
            {
                MessageBox.Show("Debe indicar Nombre de la empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMonto.Focus();
                return;
            }
            if (!(IsNumeric(txtMonto.Text)))
            {
                MessageBox.Show("Valor Monto incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonto.Focus();
                return;

            }
            else
            {
                MontoInic = Convert.ToDouble(txtMonto.Text);
                if (!(MontoInic > 0))
                {
                    MessageBox.Show("Valor Monto no puede ser negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMonto.Focus();
                    return;
                }
            }


            Tiempo = Convert.ToInt32(txtTiempo.Text);

            textTasaInterEX.Text = textTasaInterEX.Text.Trim();
            if (rdbInteres3.Checked == true)
            {
                if (textTasaInterEX.Text.Length > 0)
                {
                    if (!(IsNumeric(textTasaInterEX.Text) == true))
                    {
                        MessageBox.Show("Tasa interes incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textTasaInterEX.Text = "0";
                        textTasaInterEX.Focus();
                        return;

                    }
                    else
                    {
                        TasaI = Convert.ToDouble(textTasaInterEX.Text) / 100;
                    }
                }

                else
                {
                    MessageBox.Show("Aun no ha indicado una tasa interes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTiempo.Focus();
                    return;
                }
            }
           if (instResul.Items.Count < 2)
            {
                MontoFin = (1 + TasaI);
                MontoFin = MontoInic * (Math.Pow(Convert.ToDouble(MontoFin), Tiempo));
                TasaI *= 100;

                instResul.Items.Clear();
                instResul.Items.Add("Empresa:" + txtEmpresa.Text);
                instResul.Items.Add("Monto: $" + MontoInic + ", Tasa anual: " + TasaI);
                instResul.Items.Add("Monto a pagar: $" + MontoFin);
            }
            else {
                MessageBox.Show("Ellol");
                return;
            
            }
            


        }

        



    }
}
