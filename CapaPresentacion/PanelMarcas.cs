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
    public partial class PanelMarcas : Form
    {
        EProductos Ep = new EProductos();
        NProductos Np = new NProductos();
        public PanelMarcas()
        {
            InitializeComponent();
        }

        private void PanelMarcas_Load(object sender, EventArgs e)
        {
            //LLenar Tabla
            LLamarTabla();
        }
        private void LLamarTabla()
        {
            DataTable dt = Np.ObtenerMarcas();
            DGVNombreMarca.DataSource = dt;
        }

        private void BtnBuscarNombreMarca_Click(object sender, EventArgs e)
        {
            if (TxtNombreMarcas.Text != null)
            {

                EMarca.Instancia.Nombre = TxtNombreMarcas.Text;
                //MessageBox.Show(Ep.Nombre);
                DataTable dataTable = new DataTable();
                dataTable = Np.BuscarMarcaiaNombre();
                DGVNombreMarca.DataSource = dataTable;
            }
            else
            {
                TxtNombreMarcas.Text = "Introduce un nombre";
            }
        }
    }
}
