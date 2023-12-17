using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{

    public class DProductos
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["CN"].ConnectionString);
        EProductos EP = new EProductos();

        public DataTable ProcesosAlmacenados(int proceso)
        {
            string Consuslta = "";
            if (proceso == 1)
            {
                Consuslta = "Ver_Productos";
            }
            if (proceso == 2)
            {
                Consuslta = "Ver_Proveedores";
            }
            if (proceso == 3)
            {
                Consuslta = "Ver_Categoria";
            }
            if (proceso == 4)
            {
                Consuslta = "Ver_Marca";
            }
            if (proceso == 5)
            {
                Consuslta = "Ver_Presentacion";
            }
            conexion.Open();
            SqlCommand cmd = new SqlCommand(Consuslta, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }
        public DataTable BuscraPorNombre(int busquedad)
        {
            string StringConsuslta = "", Nombre = "";

            if (busquedad == 1)
            {
                Nombre = EProductos.Instancia.Nombre;
                StringConsuslta = "SELECT P.Nombre AS Producto,P.PrecioCompra,P.PrecioVenta, C.Nombre AS Categoria,P.Cantidad,M.Nombre AS Marca,Pr.Nombre AS Presentacion,Pv.Nombre AS Proveedor " +
                "FROM Productos P " +
                "INNER JOIN Categoria C ON P.Categoria = C.ID " +
                "INNER JOIN Marca M ON P.Marca = M.ID " +
                "INNER JOIN Presentacion Pr ON P.Presentacion = Pr.ID " +
                "INNER JOIN Proveedores Pv ON P.Proveedores = Pv.ID WHERE P.Nombre = '" + Nombre + "';";
            }
            if (busquedad == 2)
            {
                Nombre = EProveedores.Instancia.Nombre;
                StringConsuslta = "SELECT ID, Nombre, Direccion, Telefono, Email, Contacto FROM Proveedores WHERE Nombre = '" + Nombre + "';";
            }
            if (busquedad == 3)
            {
                Nombre = ECategiria.Instancia.Nombre;
                StringConsuslta = "SELECT ID, Nombre, Descripcion FROM Categoria WHERE Nombre = '" + Nombre + "';";
            }
            if (busquedad == 3)
            {
                Nombre = ECategiria.Instancia.Nombre;
                StringConsuslta = "SELECT ID, Nombre, Descripcion FROM Categoria WHERE Nombre = '" + Nombre + "';";
            }
            if (busquedad == 4)
            {
                Nombre = EMarca.Instancia.Nombre;
                StringConsuslta = "SELECT ID, Nombre, PaisOrigen FROM Marca WHERE Nombre = '" + Nombre + "';";
            }
            if (busquedad == 5)
            {
                Nombre = EPresentacion.Instancia.Nombre;
                StringConsuslta = "SELECT ID, Nombre, UnidadesPorPaquete FROM Presentacion WHERE Nombre = '" + Nombre + "';";
            }
            conexion.Open();
            //string consulta = "SELECT ID, Nombre, Direccion, Telefono, Email, Contacto FROM Proveedores WHERE Nombre = '" + Nombre + "';";
            SqlDataAdapter sqlData = new SqlDataAdapter(StringConsuslta, conexion);
            DataTable dt = new DataTable();
            sqlData.Fill(dt);
            conexion.Close();
            return dt;
        }

        public void InsertarValores()
        {
            conexion.Open();
            String StringConsulta = "INSERT INTO Compras FechaCompra, Producto, PrecioVenta, Cantidad, Marca, Proveedor, Presentacion, Total " +"" +
                "VALUES (GETDATE(), "+ECompras.Instancia.Nombre+","+ECompras.Instancia.PrecioVenta+","+ECompras.Instancia.Cantidad+","+ECompras.Instancia.Marca+","+ECompras.Instancia.Proveedor+","+ECompras.Instancia.Presentacion+","+ECompras.Instancia.Total+");";
            SqlCommand cmdd = new SqlCommand(StringConsulta, conexion);
            cmdd.ExecuteNonQuery();
            conexion.Close();
        }

        public DataTable ValoresFaltantesCompra()
        {
            string  StringConsuslta = "SELECT P.ID AS ProductoID, M.ID AS MarcaID, Pv.ID AS ProveedorID, Pr.ID AS PresentacionID FROM Productos P INNER JOIN Marca M ON P.Marca = M.ID INNER JOIN Proveedores Pv ON P.Proveedores = Pv.ID INNER JOIN Presentacion Pr ON P.Presentacion = Pr.ID WHERE P.ID = '" + ECompras.Instancia.Id + "';";
            SqlDataAdapter sqlData = new SqlDataAdapter(StringConsuslta, conexion);
            DataTable dt = new DataTable();
            sqlData.Fill(dt);
            conexion.Close();
            return dt;
        }

    }
}
