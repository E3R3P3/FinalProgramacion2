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
    public partial class PanelComprasMensuales : Form
    {
        EProductos Ep = new EProductos();
        NProductos NP = new NProductos();
        public PanelComprasMensuales()
        {
            InitializeComponent();
        }

        private void CByear2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
