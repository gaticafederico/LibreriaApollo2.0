using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaApollo.BD;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace LibreriaApollo.Controladores
{
    class controladorProductos
    {
        public DataTable mostrarTodosProductos(string filtroNombre, int filtroCategoria)
        {
            Conexion conexion = new Conexion();
            try
            {
                DataTable resultados = new DataTable();
                if(filtroCategoria != 0)
                {
                    resultados = conexion.consultar(@"SELECT productos.idProducto, productos.nombreProducto, productos.descripcionProducto, productos.cantidadStock, productos.precioUnitario, productos.stockMinimo, productos.idCategoria FROM productos WHERE productos.nombreProducto LIKE '" + filtroNombre + "%' AND productos.idCategoria='" +filtroCategoria+ "'");
                } else
                {
                    resultados = conexion.consultar(@"SELECT productos.idProducto, productos.nombreProducto, productos.descripcionProducto, productos.cantidadStock, productos.precioUnitario, productos.stockMinimo, productos.idCategoria FROM productos WHERE productos.nombreProducto LIKE '" + filtroNombre + "%'");
                }
                
                return resultados;
            }
            catch
            {
                return new DataTable();
            }
        }

        public bool agregarProducto(string nombreProducto, string descripcionProducto, string cantidadStock, string precioUnitario, string stockMinimo, int idCategoria)
        {
            try
            {
                string precioUnitarioArreglado = precioUnitario.Replace(',', '.');
                Conexion conexion = new Conexion();
                int _cantidadStock = Int32.Parse(cantidadStock);
                int _stockMinimo = Int32.Parse(stockMinimo);
                conexion.consultar(@"INSERT INTO productos (nombreProducto, descripcionProducto, cantidadStock, precioUnitario, stockMinimo, idCategoria) VALUES ('" + nombreProducto + "', '" + descripcionProducto + "', '" + _cantidadStock + "', CAST('" + precioUnitarioArreglado + "' AS float), '" + _stockMinimo + "', '" + idCategoria + "')");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepcion: " + ex.Message);
                return false;
            }
        }

        public bool modificarProducto(int idProducto, string nombreProducto, string descripcionProducto, string cantidadStock, string precioUnitario, string stockMinimo, int idCategoria)
        {
            try
            {
                string precioUnitarioArreglado = precioUnitario.Replace(',', '.');
                Conexion conexion = new Conexion();
                int _cantidadStock = Int32.Parse(cantidadStock);
                int _stockMinimo = Int32.Parse(stockMinimo);
                conexion.consultar(@"UPDATE productos SET nombreProducto = '" + nombreProducto + "', descripcionProducto = '" + descripcionProducto + 
                    "', cantidadStock = '" + _cantidadStock + "', precioUnitario = CAST('" + precioUnitarioArreglado + "' AS FLOAT), stockMinimo = '" + _stockMinimo + "', idCategoria = '" + idCategoria + "' WHERE idProducto = '" + idProducto + "'");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepcion: " + ex.Message);
                return false;
            }
        }

        public bool borrarProducto(int idProducto)
        {
            try
            {
                Conexion conexion = new Conexion();
                DataTable tieneVentas = conexion.consultar(@"SELECT * FROM detalleVentas WHERE idProducto = '" + idProducto + "';");
                if(tieneVentas.Rows.Count == 0)
                {
                    conexion.consultar(@"DELETE FROM productos WHERE idProducto = '" + idProducto + "'");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepcion: " + ex.Message);
                return false;
            }
        }
    }
}
