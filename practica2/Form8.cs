using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practica2
{
    public partial class Form8 : Form
    {
        private int numeroAleatorio;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            numeroAleatorio = rnd.Next(1, 101);
        }

        private void Comprobar(int numeroUsuario)
        {
            if (numeroUsuario < numeroAleatorio)
            {
                label1.Text = "Demasiado bajo";
            }
            else if (numeroUsuario > numeroAleatorio)
            {
                label1.Text = "Demasiado alto";
            }
            else
            {
                label1.Text = "¡Correcto!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numeroUsuario))
            {
                Comprobar(numeroUsuario);
            }
            else
            {
                label1.Text = "Por favor, ingresa un número válido.";

            }
        }
    }
}


