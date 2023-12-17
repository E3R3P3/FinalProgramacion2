using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using System.Data.SqlClient;

namespace CapaPresentacion
{

    public partial class PanelProductos : Form
    {

        EProductos Ep = new EProductos();
        NProductos NP = new NProductos();

        public PanelProductos()
        {
            InitializeComponent();
        }

        private void LLamarTabla()
        {
            DataTable dt = NP.ObteneProductos();
            DGVNombreProductos.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Buscar Producto
            if (TxtNombreProductos.Text != null)
            {

                EProductos.Instancia.Nombre = TxtNombreProductos.Text;
                //MessageBox.Show(Ep.Nombre);
                DataTable dataTable = new DataTable();
                dataTable = NP.BuscatNombreProductos();
                DGVNombreProductos.DataSource = dataTable;
            }
            else
            {
                TxtNombreProductos.Text = "Introduce un nombre";
            }
            
        }

        private void PanelProductos_Load(object sender, EventArgs e)
        {
            LLamarTabla();
        }

        private void DGVCategoriaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cerrar();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LLamarTabla();
        }

        public void cerrar()
        {
            this.Close();
        }
    }
}
