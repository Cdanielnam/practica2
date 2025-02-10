using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            titulo.Text = "Conversión de Temperatura °C a F";
            Ingresotext.Text = "Ingrese la temperatuira en °C que desa convertir";
            resultado.Text = "";
            enviar.Text = "Convertir a F";


        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                resultado.Text = $"{celsius}°C es igual a {fahrenheit}°F";


            }
            else
            {
                resultado.Text = "Por favor, ingrese un número válido.";

            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
