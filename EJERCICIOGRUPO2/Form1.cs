using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIOGRUPO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            string sexo = txtSexo.Text;

            if (sexo == "Femenino")
            {
                MessageBox.Show("Hola, según el dato ingresado eres una Mujer :)");

            }else if (sexo == "Masculino")
            {
                MessageBox.Show("Hola, según el dato ingresado eres un hombre :) ");

            }
            else
            {
                MessageBox.Show("Lo siento no reconozco el dato, por favor escriba su género");
            }

        }
    }
}
