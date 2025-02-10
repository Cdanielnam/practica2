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
    public partial class Form7 : Form
    {
        public Form7()
        {

            InitializeComponent();
            comboBox1.Items.Add("Administrador");
            comboBox1.Items.Add("Usuario");
            comboBox1.Items.Add("Invitado");

        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            lbltitle.Text = "Inicio de sesión";
            iblseleccion.Text = "Seleccion de usuario";
            lblresult.Text = "Resultado";
            btniniciar.Text = "Iniciar sesión";

        }

        private void btniniciar_Click(object sender, EventArgs e)
        {

            string userType = comboBox1.SelectedItem.ToString();
            string message = "" ;

            switch (userType)
            {

                case "Administrador":
                    message = "Bienvenido,Administrador. Tienes acceso completo al sistema";
                    break;

                case "Usuario":
                    message = "Bienvenido, Usuario. Tiene acceso limitado.";
                    break;

                case "Invitado":
                    message = "Por favor, selecciona un tipo de usuario";
                    break;
                default:
                    message = "Por favor, selecciona un tipo de usuario.";
                    break;

            }
            textBox1.Text = message;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            

        }
    }
}
