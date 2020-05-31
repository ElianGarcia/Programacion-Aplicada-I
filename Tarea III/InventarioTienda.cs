using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_III.Tarea_III
{
    public partial class InventarioTienda : Form
    {
        public InventarioTienda()
        {
            InitializeComponent();
            CantArtVendidos = 0;
            PrecioArtVendidos = 0;
            GastosConsegArt = 0;
            ImpuestoArt = 0;
        }

        private float CantArtVendidos;
        private float PrecioArtVendidos;
        private float GastosConsegArt;
        private float ImpuestoArt;

        public InventarioTienda(float cantArtVendidos, float precioArtVendidos, float gastosConsegArt, float impuestoArt)
        {
            CantArtVendidos = cantArtVendidos;
            PrecioArtVendidos = precioArtVendidos;
            GastosConsegArt = gastosConsegArt;
            ImpuestoArt = impuestoArt;
        }

        public float GetCantArtVendidos()
        {
            return CantArtVendidos;
        }
        public void SetCantArtVendidos(float cantArtVendidos)
        {
            this.CantArtVendidos = cantArtVendidos;
        }

        public float GetPrecioArtVendidos()
        {
            return PrecioArtVendidos;
        }
        public void SetPrecioArtVendidos(float precioArtVendidos)
        {
            this.PrecioArtVendidos = precioArtVendidos;
        }

        public float GetGastosConsegArt()
        {
            return GastosConsegArt;
        }
        public void SetGastosConsegArt(float gastosConsegArt)
        {
            this.GastosConsegArt = gastosConsegArt;
        }

        public float GetImpuestoArt()
        {
            return ImpuestoArt;
        }
        public void SetImpuestoArt(float impuestoArt)
        {
            this.ImpuestoArt = impuestoArt;
        }

        public float Inventario()
        {
            float ganancias = 0;
            ganancias = (CantArtVendidos * PrecioArtVendidos) - (GastosConsegArt + ImpuestoArt);
            return ganancias;
        }

        private void BtGuardar_Click(object sender, System.EventArgs e)
        {
            int cantidad = Convert.ToInt32(tbCantidad.Text);
            float impuesto = Convert.ToSingle(tbImpuesto.Text);
            float gastos = Convert.ToSingle(tbGastos.Text);
            float precio = Convert.ToSingle(tbPrecio.Text);

            InventarioTienda inventarioTienda = new InventarioTienda(cantidad, precio, gastos, impuesto);
        }
    }
}
