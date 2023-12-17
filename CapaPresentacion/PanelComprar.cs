using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class PanelComprar : Form
    {
        EProductos Ep = new EProductos();
        NProductos NP = new NProductos();
        public PanelComprar()
        {
            InitializeComponent();
        }

        private void PanelComprar_Load(object sender, EventArgs e)
        {
            LLamarTabla();
        }

        private void LLamarTabla()
        {
            DataTable dt = NP.ObteneProductos();
            DGVProductosComprar.DataSource = dt;
        }

        private void SetearCompra()
        {
            ECompras.Instancia.Nombre = DGVProductosComprar.SelectedCells[0].Value.ToString();
            ECompras.Instancia.PrecioVenta = DGVProductosComprar.SelectedCells[3].Value.ToString();
            ECompras.Instancia.Cantidad = CantidadComprar.Value.ToString();
            ECompras.Instancia.Marca = EMarca.Instancia.Id;
            ECompras.Instancia.Proveedor = EProveedores.Instancia.Id;
            ECompras.Instancia.Presentacion = EPresentacion.Instancia.Id;
            ECompras.Instancia.Total = TxtTotal.Text;
        }

        private void BtnBuscarNombreProductos_Click(object sender, EventArgs e)
        {
            //Buscar Categoria
            if (TxtNombreProductosComprar.Text != null)
            {

                EProductos.Instancia.Nombre = TxtNombreProductosComprar.Text;
                //MessageBox.Show(Ep.Nombre);
                DataTable dataTable = new DataTable();
                dataTable = NP.BuscatNombreProductos();
                DGVProductosComprar.DataSource = dataTable;
            }
            else
            {
                TxtNombreProductosComprar.Text = "Introduce un nombre";
            }
        }
        private void CalcularPrecio()
        {
            int cantidad = ((int)CantidadComprar.Value);
            float preciounidad = Convert.ToSingle(DGVProductosComprar.SelectedCells[2].Value.ToString());
            Console.WriteLine("Este es el precio Por unidad: "+preciounidad);
            TxtTotal.Text = (cantidad*preciounidad)+"$";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            //Comprar
            NP.valoresFaltantes();

        }

        private void LbPresentacionComprar_Click(object sender, EventArgs e)
        {

        }

        private void DGVProductosComprar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVProductosComprar_Click(object sender, EventArgs e)
        {
            CalcularPrecio();
            TxtNombreComprar.Text = DGVProductosComprar.SelectedCells[1].Value.ToString();
            TxtCostoUnidad.Text = DGVProductosComprar.SelectedCells[3].Value.ToString();
            TxtProveedorComprar.Text = DGVProductosComprar.SelectedCells[8].Value.ToString();
            TxtMarcaComprar.Text = DGVProductosComprar.SelectedCells[6].Value.ToString();
            TxtPresentacionComprar.Text = DGVProductosComprar.SelectedCells[7].Value.ToString();
        }

        private void LbMarcaComprar_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombreComprar_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCostoUnidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtProveedorComprar_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMarcaComprar_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPresentacionComprar_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void CantidadComprar_Click(object sender, EventArgs e)
        {
            CalcularPrecio();
        }
    }
}
