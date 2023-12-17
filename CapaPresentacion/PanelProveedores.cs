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
    public partial class PanelProveedores : Form
    {
        EProductos Ep = new EProductos();
        NProductos Np = new NProductos();
        public PanelProveedores()
        {
            InitializeComponent();
        }

        public void LLamarTabla()
        {
            DataTable dt = Np.ObtenerProveedores();
            DGVProveedores.DataSource = dt;
        }
        public void cerrar()
        {
            this.Close();
        }

        private void BtnBuscarProveedores_Click(object sender, EventArgs e)
        {
            //Buscar Proveedor
            if (TxtNombreProveedores.Text != null)
            {

                EProveedores.Instancia.Nombre = TxtNombreProveedores.Text;
                //MessageBox.Show(Ep.Nombre);
                DataTable dataTable = new DataTable();
                dataTable = Np.BuscarProveedorNombre();
                DGVProveedores.DataSource = dataTable;
            }
            else
            {
                TxtNombreProveedores.Text = "Introduce un nombre";
            }
        }

        private void PanelProveedores_Load(object sender, EventArgs e)
        {
            LLamarTabla();
        }

        private void LbProveedores_Click(object sender, EventArgs e)
        {
            LLamarTabla();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
    }
}
