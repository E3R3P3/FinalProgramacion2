using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Pproductos : Form
    {
        NProductos NP = new NProductos();

        public Pproductos()
        {
            InitializeComponent();
            ActualizarEstilo();
        }

        

        private void ActualizarEstilo()
        {
            PanelAlmacen.Visible = false;
            PanelCompras.Visible = false;
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ActualizarEstilo();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        private void AbrirPanel(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(childForm);
            PanelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnMarca_Click(object sender, EventArgs e)
        {
            AbrirPanel(new PanelMarcas());
            
        }

        private void BtnAlmacen_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelAlmacen);
        }

        private void PanelAlmacen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirPanel(new PanelComprar());
            //ActualizarEstilo();
        }

        private void panelLatera_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelIcono_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelCompras);
            
        }

        private void Pproductos_Load(object sender, EventArgs e)
        {
            ActualizarEstilo();
        }

        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            AbrirPanel(new PanelCategorias());
           // ActualizarEstilo();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            AbrirPanel(new PanelProductos());
            NP.ObteneProductos();

        }

        private void BtnPresentacion_Click(object sender, EventArgs e)
        {
            //ActualizarEstilo();
            AbrirPanel(new PanelPresentaciones());
        }

        private void BtnComprasFecha_Click(object sender, EventArgs e)
        {
            //ActualizarEstilo();
            AbrirPanel(new PanelComprasAnuales());
        }

        private void BtnaComprasMes_Click(object sender, EventArgs e)
        {
            AbrirPanel(new PanelComprasMensuales());
            //ActualizarEstilo();
        }

        private void BntProveedores_Click(object sender, EventArgs e)
        {
            AbrirPanel(new PanelProveedores());
            //ActualizarEstilo();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AbrirPanel(new PanelClientes());
            //ActualizarEstilo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CerrarPaneles()
        {
            PanelProveedores panelProveedores = new PanelProveedores();
            PanelProductos panelProductos = new PanelProductos();
            PanelPresentaciones panelPresentaciones = new PanelPresentaciones();
            PanelMarcas panelMarcas = new PanelMarcas();
            PanelComprasMensuales panelComprasMensuales = new PanelComprasMensuales();
            PanelComprasAnuales panelComprasAnuales = new PanelComprasAnuales();
            PanelComprar panelComprar = new PanelComprar();
            PanelClientes panelClientes = new PanelClientes();
            PanelCategorias panelCategorias = new PanelCategorias();
        }
    }
}
