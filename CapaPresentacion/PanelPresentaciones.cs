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
    public partial class PanelPresentaciones : Form
    {
        EProductos Ep = new EProductos();
        NProductos Np = new NProductos();
        public PanelPresentaciones()
        {
            InitializeComponent();
        }

        private void PanelPresentaciones_Load(object sender, EventArgs e)
        {
            //LLenar Tabla
            LLamarTabla();
        }
        private void LLamarTabla()
        {
            DataTable dt = Np.ObtenerPresentaciones();
            DGVNombrePresentacion.DataSource = dt;
        }

        private void BtnBuscarNombreProductos_Click(object sender, EventArgs e)
        {
            if (TxtNombrePresentacion.Text != null)
            {

                EPresentacion.Instancia.Nombre = TxtNombrePresentacion.Text;
                //MessageBox.Show(Ep.Nombre);
                DataTable dataTable = new DataTable();
                dataTable = Np.BuscarPresentacionNombre();
                DGVNombrePresentacion.DataSource = dataTable;
            }
            else
            {
                TxtNombrePresentacion.Text = "Introduce un nombre";
            }
        }
    }
}
