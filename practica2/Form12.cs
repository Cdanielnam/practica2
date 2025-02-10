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
    public partial class Form12 : Form
    {
        int[] numeros = new int[10];
        public Form12()
        {
            InitializeComponent();
        }
            
          
        

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 0)
                {
                    numeros[i] = int.Parse(textBox1.Text);
                    break;
                }


            }
            listBox1.Items.Clear();

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] != 0)
                {
                    listBox1.Items.Add(numeros[i]);
                }
            }

        }
    }
}
