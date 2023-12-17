using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NProductos
    {

        DProductos Dp = new DProductos();
        EProductos Ep = new EProductos();

        public DataTable ObteneProductos()
        {
            return Dp.ProcesosAlmacenados(1);
        }
        public DataTable ObtenerProveedores()
        {
            return Dp.ProcesosAlmacenados(2);
        }
        public DataTable ObtenerCategrias()
        {
            return Dp.ProcesosAlmacenados(3);
        }
        public DataTable ObtenerMarcas()
        {
            return Dp.ProcesosAlmacenados(4);
        }
        public DataTable ObtenerPresentaciones()
        {
            return Dp.ProcesosAlmacenados(5);
        }

        /////////////////////////////////////////
        public DataTable BuscatNombreProductos()
        {
            //Console.WriteLine("Nombre en NProductos: "+EProductos.Instancia.Nombre);
            return Dp.BuscraPorNombre(1);
        }
        public DataTable BuscarProveedorNombre()
        {
            return Dp.BuscraPorNombre(2);
        }
        public DataTable BuscarCategoriaNombre()
        {
            return Dp.BuscraPorNombre(3);
        }
        public DataTable BuscarMarcaiaNombre()
        {
            return Dp.BuscraPorNombre(4);
        }
        public DataTable BuscarPresentacionNombre()
        {
            return Dp.BuscraPorNombre(5);
        }

        /////////////////////////////////////////////////
        
       public void InsertarCompra()
        {
            ECompras.Instancia.Nombre = "";
        }

        public void valoresFaltantes()
        {
            DataTable dt = new DataTable();
            dt = Dp.ValoresFaltantesCompra();
            string a = dt.Rows[1][1].ToString();
            Console.WriteLine("Valor es :"+a);
            
        }

    }

    


}
