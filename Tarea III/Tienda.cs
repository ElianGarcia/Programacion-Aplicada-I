using System;
using System.Text;
using System.Windows.Forms;

namespace Tarea_III.Tarea_III
{
    public partial class Tienda : Form
    {
        public Tienda()
        {
            InitializeComponent();
        }

        public struct ProductosTienda
        {
            int IdProducto;
            string NombreProducto;
            float Precio;
            int CantDisponible;

            public ProductosTienda(int id, string nombreP, float precio, int CantD)
            {
                IdProducto = id;
                NombreProducto = nombreP;
                Precio = precio;
                CantDisponible = CantD;
            }
        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDnumericUpDown.Value);
            string nombre = tbNombreProducto.Text;
            float precio = Convert.ToSingle(tbPrecio.Text);
            int cant = Convert.ToInt32(tbCantidad.Text);

            ProductosTienda pt = new ProductosTienda(id, nombre, precio, cant);
        }
    }
}