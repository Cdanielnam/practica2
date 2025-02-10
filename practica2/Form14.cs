using System;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form14 : Form
    {
        string[] paises = {
    "Honduras", "México", "Bolivia", "Venezuela", "Uruguay",
    "Paraguay", "Chile", "Argentina", "Colombia", "Ecuador",
    "Panamá", "Cuba", "Costa Rica", "El Salvador", "Perú",
    "Nicaragua", "Haití", "Guatemala", "República Dominicana", "Brasil"
};


        public Form14()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Array.Sort(paises);

           
            listBox1.Items.Clear();

            
            for (int i = 0; i < paises.Length; i++)
            {
                listBox1.Items.Add(paises[i]);
            }

            
            Console.WriteLine("Países ordenados alfabéticamente");
        }
    }
}