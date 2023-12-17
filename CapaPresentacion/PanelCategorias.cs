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
    public partial class PanelCategorias : Form
    {
        EProductos Ep = new EProductos();
        NProductos Np = new NProductos();
        public PanelCategorias()
        {
            InitializeComponent();
        }

        private void PanelCategorias_Load(object sender, EventArgs e)
        {
            //LLenar Tabla
            LLamarTabla();
        }
        private void LLamarTabla()
        {
            DataTable dt = Np.ObtenerCategrias();
            DGVCategoriaNombre.DataSource = dt;
        }

        private void BtnBuscarCategoriaProductos_Click(object sender, EventArgs e)
        {
            if (TxtNombreCategoria.Text != null)
            {

                ECategiria.Instancia.Nombre = TxtNombreCategoria.Text;
                //MessageBox.Show(Ep.Nombre);
                DataTable dataTable = new DataTable();
                dataTable = Np.BuscarCategoriaNombre();
                DGVCategoriaNombre.DataSource = dataTable;
            }
            else
            {
                TxtNombreCategoria.Text = "Introduce un nombre";
            }
        }
    }
}
