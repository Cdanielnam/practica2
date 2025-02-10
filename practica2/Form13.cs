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
    public partial class Form13 : Form
    {
        string[] nombres = { "Juan", "Ana", "pedro", "maria", "Luis" };
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buscarnombre = textBox1.Text;

            bool encontrado = nombres.Contains(buscarnombre);
            if (encontrado)
            {
                Truco ($"{buscarnombre} se encuentra en el trabajo");


            }
            else
            {
                Truco($"{buscarnombre} no se encuentra en el arreglo");
            }

        }

        private void Truco(string mensaje)
        {
            textBox1.Text = mensaje;
            label1 .Visible = true;
        }
    }
}
