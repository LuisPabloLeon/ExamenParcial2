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
            if (radioalumno.Checked)
            {
                MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
                + "\nEdad: " + textBox3.Text + "\nMatricula: " + textBox4.Text + "\nCarrera: " + textBox5.Text);
            }
            else
            {
                if (radiodocente.Checked || radioempleado.Checked)
                {
                    MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
              + "\nEdad: " + textBox3.Text + "\nDNI: " + textBox4.Text + "\nPuesto: " + textBox5.Text + "\nSueldo: " + textBox6.Text);
                }
                else
                {
                    MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
               + "\nEdad: " + textBox3.Text);
                }
            }
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

        private void validar_Click(object sender, EventArgs e)
        {
            if (radioalumno.Checked)
            {

                string nom = textBox1.Text;
                string fech = textBox2.Text;
                int edad = Convert.ToInt32(textBox3.Text);
                int mat = Convert.ToInt32(textBox4.Text);
                string carrera = textBox5.Text;
                Alumno alumno = new Alumno(nom, edad, fech, carrera, mat);
            }
            else
            {
                if (radioempleado.Checked)
                {

                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                    int mat = Convert.ToInt32(textBox4.Text);
                    string puesto = textBox5.Text;
                    float sueldo = Convert.ToSingle(textBox6.Text);
                    Empleado empleado = new Empleado(nom, edad, fech, puesto, sueldo);
                }
                else if (radiodocente.Checked)
                {
                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                    int mat = Convert.ToInt32(textBox4.Text);
                    string puesto = textBox5.Text;
                    float sueldo = Convert.ToSingle(textBox6.Text);
                    Docente docente = new Docente(nom, edad, fech, puesto, sueldo);
                }
                else
                {
                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                }
            }
        }

        private void radioalumno_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "E:\\POO2\\Proyecto_P2-main\\Imagenes\\Alumno.jpg";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label6.Visible = false;
            textBox6.Visible = false;
            if (label4.Visible == false && textBox4.Visible == false && label5.Visible == false && textBox5.Visible == false) //comprobar que los label y textbox estem
                                                                                                                             //apagados o prendidos
            {
                label4.Visible = true;
                textBox4.Visible = true;
                label5.Visible = true;
                textBox5.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "E:\\POO2\\Proyecto_P2-main\\Imagenes\\Persona.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = false;
            textBox4.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;
            label6.Visible = false;
            textBox6.Visible = false;
        }

        private void radioempleado_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "E:\\POO2\\Proyecto_P2-main\\Imagenes\\Empleado.jpg";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;
            label6.Visible = true;
            textBox6.Visible = true;
        }

        private void radiodocente_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "E:\\POO2\\Proyecto_P2-main\\Imagenes\\Maestro.jpg";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;
            label6.Visible = true;
            textBox6.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string rutaImagen = "E:\\POO2\\Proyecto_P2-main\\Imagenes\\ImagenBienvenida.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            radioalumno.Checked = false;
            radioButton1.Checked = false;
            radiodocente.Checked = false;
            radioempleado.Checked = false;
        }
    }
}
