using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    //Luis Pablo Leon Capitan DI22114
    //ExamenParcial2 V1.0
    //Fecha 07/05/24
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            //condicional que comprueba que las cajas de texto contangan escrito algo
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("No ha terminado de llenar la informacion");
            }
            else
            {
                MessageBox.Show("Tus datos han sido guardados :D");
            }// esto se hace de tarea todos los valores
            // deben de almacenarse en su
            // caja de memoria correspondiente
            // usando la clase hija que corresponda
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            //Limpieza de las cajas de texto
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();// se hace de tarea
            // debe de borrar las cajas de texto
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            //Cerrar programa
            Application.Exit();// se hace de tarea
            // debe de terminar la ejecucion de la interfaz
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void validar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
