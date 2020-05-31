using System;
using System.Windows.Forms;

namespace Tarea_III.Tarea_III
{
    public partial class PersonayMascota : Form
    {
        public PersonayMascota()
        {
            InitializeComponent();
        }

        public struct Mascota
        {
            public string NombreMascota;
            string TipoMascota;
            int EdadMascota;

            public Mascota(string nombreM, string tipoM, int edadM)
            {
                NombreMascota = nombreM;
                TipoMascota = tipoM;
                EdadMascota = edadM;
            }
        }

        public struct Persona
        {
            string Nombre;
            int Edad;
            string Genero;
            Mascota mascota;

            public Persona(string nombre, int edad, string genero, string nombreM, string tipoM, int edadM)
            {
                Nombre = nombre;
                Edad = edad;
                Genero = genero;

                //Hacemos una instancia de Mascota para poder asignar sus valores recibidos al constructor de Persona
                mascota = new Mascota(nombreM, tipoM, edadM);
            }
        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            string nombrePersona = tbNombre.Text;
            int edadPersona = Convert.ToInt32(tbEdad.Text);
            string sexo = cbSexo.SelectedItem.ToString();
            string nombreMascota = tbNombreM.Text;
            string raza = tbRaza.Text;
            int edadMascota = Convert.ToInt32(tbEdadM.Text);

            Persona p = new Persona(nombrePersona, edadPersona, sexo, nombreMascota, raza, edadMascota);
        }
    }
}
