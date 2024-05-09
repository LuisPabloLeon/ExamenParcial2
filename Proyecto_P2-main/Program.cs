using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    class Persona //clase padre
    {
        protected string NombreCompleto;
        protected string FechaN;
        protected int Edad;
        protected int DNI_Matricula;
        protected string Carrera_Puesto;

        public string nombrecompleto //Caja de memoria
        {
            get { return NombreCompleto; }
            set { NombreCompleto = value; }
        }
        public string fechan //caja de memoria
        {
            get { return FechaN; }
            set { FechaN = value; }
        }
        public int edad //caja de memoria
        {
            get { return Edad; }
            set { Edad = value; }
        }
        public int dni_matricula //caja de memoria
        {
            get { return DNI_Matricula; }
            set { DNI_Matricula = value; }
        }
        public string carrera_Puesto //Caja de memoria
        {
            get { return Carrera_Puesto; }
            set { Carrera_Puesto = value; }
        }
        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
        //aqui va el constructor para cargar datos en las cajas de memoria
        //nombre, edad, fecha de nacimiento(es un tipo cadena!!!!! string)
    }

    class Alumno :Persona //clase hija alumno
    {
        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
    }
    class Empleado : Persona //clase hija
    {
        protected int Sueldo;
        public int sueldo//caja de memoria
        {
            get { return Sueldo; }
            set { Sueldo = value; }
        }
        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
    }

    class Docente : Persona //clase Hija
    {
        protected int Sueldo;
        public int sueldo//caja de memoria
        {
            get { return Sueldo; }
            set { Sueldo = value; }
        }
        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
