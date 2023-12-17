using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EProductos
    {
        private static EProductos instancia;
        public string Id { get; set; }
        public string Nombre { get; set; }
        public float PrecioCompra { get; set; }
        public float PrecioVenta { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
        public string Marca { get; set; }
        public string Presentacion { get; set; }

        public EProductos() { }

        public static EProductos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new EProductos();
                }
                return instancia;
            }
        }

    }
    public class EProveedores
    {
        private static EProveedores instancia;
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Contacto { get; set; }

        public EProveedores() { }

        public static EProveedores Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new EProveedores();
                }
                return instancia;
            }
        }
    }
    public class ECategiria
    {
        private static ECategiria instancia;
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ECategiria() { }

        public static ECategiria Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ECategiria();
                }
                return instancia;
            }
        }
    }
    public class EMarca
    {
        private static EMarca instancia;
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string PaisOrigen { get; set; }

        public EMarca() { }

        public static EMarca Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new EMarca();
                }
                return instancia;
            }
        }
    }
    public class EPresentacion
    {
        private static EPresentacion instancia;
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int UnidadesPorPaquete { get; set; }

        public EPresentacion() { }

        public static EPresentacion Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new EPresentacion();
                }
                return instancia;
            }
        }
    }

    public class ECompras
    {
        private static ECompras instancia;
        public string Id { get; set; }
        public string Fecha { get; set; }
        public string Nombre { get; set; }
        public string PrecioVenta { get; set; }
        public string Cantidad { get; set; }
        public string Marca { get; set; }
        public string Proveedor { get; set; }
        public string Presentacion { get; set; }
        public String Total { get; set; }

        public ECompras() { }

        public static ECompras Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ECompras();
                }
                return instancia;
            }
        }
    }

}
