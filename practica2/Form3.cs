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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void division_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num) && double.TryParse(textBox2.Text, out double num2))
            {
                double divition = num2 / num;
                resultado.Text = ("El resultado de la division es = " + divition);


            }

        }

        private void suma_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num) && double.TryParse(textBox2.Text, out double num2))
            {
                double suma = num2 + num;
                resultado.Text = ("El resultado de la suma es = " + suma);


            }

        }

        private void resta_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num) && double.TryParse(textBox2.Text, out double num2))
            {
                double resta = num2 - num;
                resultado.Text = ("El resultado de la resta es = " + resta);


            }
        }

        private void multiplicación_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num) && double.TryParse(textBox2.Text, out double num2))
            {
                double multi = num * num2;
                resultado.Text = ("El resultado de la multi es = " + multi);


            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                resultado.Text = ("Ingrese un número valido");

            }
        }
    }
}
