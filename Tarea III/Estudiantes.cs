using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_III.Tarea_III
{
    public partial class Estudiantes : Form
    {
        private string NombreCompleto;
        private int Edad;
        private string Genero;
        private string Direccion;
        private string Grado;
        private string NoTelefonoPadres;

        public Estudiantes()
        {
            InitializeComponent();
            NombreCompleto = string.Empty;
            Edad = 0;
            Direccion = string.Empty;
            Grado = string.Empty;
            NoTelefonoPadres = string.Empty;
        }

        public Estudiantes(string nombreCompleto, int edad, string genero, string direccion, string grado, string noTel)
        {
            this.NombreCompleto = nombreCompleto;
            this.Edad = edad;
            this.Genero = genero;
            this.Direccion = direccion;
            this.Grado = grado;
            this.NoTelefonoPadres = noTel;
        }
        
        public string GetNombreCompleto()
        {
            return NombreCompleto;
        }
        public void SetNombreCompleto(string nombreCompleto)
        {
            this.NombreCompleto = nombreCompleto;
        }

        public int GetEdad()
        {
            return Edad;
        }
        public void SetEdad(int edad)
        {
            this.Edad = edad;
        }

        public string GetGenero()
        {
            return Genero;
        }

        public void SetGenero(string genero)
        {
            this.Genero = genero;
        }

        public string GetDireccion()
        {
            return Direccion;
        }

        public void SetDireccion(string direccion)
        {
            this.Direccion = direccion;
        }

        public string GetGrado()
        {
            return Grado;
        }

        public void SetGrado(string grado)
        {
            this.Grado = grado;
        }

        public string GetNoTelefonoPadres()
        {
            return NoTelefonoPadres;
        }

        public void SetNoTelefonoPadres(string noTel)
        {
            this.NoTelefonoPadres = noTel;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            int edad = Convert.ToInt32(tbEdad.Text);
            string telefono = tbTelefono.Text;
            string direccion = tbDireccion.Text;
            string grado = tbGrado.Text;

            string sexo = tbGenero.Text;

            Estudiantes estudiantes = new Estudiantes(nombre, edad, sexo, direccion, grado, telefono);
        }
    }
}
