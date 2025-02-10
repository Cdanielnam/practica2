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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btncreartur_Click(object sender, EventArgs e)
        {
            lBturno.Items.Clear();
            cbasignarturno.Items.Clear();

            if (int.TryParse(txtcrearturno.Text, out int cantidad) && cantidad > 0)
            {
                if (comboBox1.SelectedItem != null)
                {
                    string tipoturno = comboBox1.SelectedItem.ToString();
                    for (int i = 1; i <= cantidad; i++)
                    {
                        string turno = "Turno" + comboBox1.Text + "#" + i;
                        lBturno.Items.Add(turno);
                        cbasignarturno.Items.Add(turno);


                    }

                }
                else
                {
                    MessageBox.Show("No ha seleccionado el tipo de tueno.");

                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido mayor a 0.");
            }
        }

        private void btnasignar_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem != null && !string.IsNullOrWhiteSpace(tbnombre.Text))
            {
                string turnoSleccionado = cbasignarturno.SelectedItem.ToString();
                string doctor = tbnombre.Text;

                lblmostrar.Text += $"{turnoSleccionado} -> {doctor}\n";
                cbasignarturno.Items.Remove(cbasignarturno.SelectedIndex);

            }
            else
            {
                MessageBox.Show("Seleccione un turno y escriba un nombre.");
            }

        }
    }
}
