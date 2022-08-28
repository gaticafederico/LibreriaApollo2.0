using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibreriaApollo.BD;
using System.Globalization;
using LibreriaApollo.Entidades;
using System.Windows.Forms;

namespace LibreriaApollo.Controladores
{
    class controladorRegistrarVenta
    {
        public void registrarVenta(string nroCliente, string importeTotal, string idEmpleado, string tipoPago, DetalleVenta[] detalles)
        {
            DateTime horaActual = DateTime.Now;
            Conexion conexion = new Conexion();
            conexion.iniciar_transaccion();
            string importeTotalArreglado = importeTotal.Replace(',', '.');
            if (nroCliente != "-1")
            {
                conexion.ejecutarTransaccion(@"INSERT INTO ventas (fechaHora, nroCliente, importeTotal, idEmpleado, tipoPago) 
                values (CAST('" + horaActual.ToString(new CultureInfo("en-US")) + "' AS DATETIME), '" 
                + nroCliente + "', '" + importeTotalArreglado + "', '" + idEmpleado + "', '" + tipoPago + "')");
            }
            else
            {
                conexion.ejecutarTransaccion(@"INSERT INTO ventas (fechaHora, nroCliente, importeTotal, idEmpleado, tipoPago) 
                VALUES (CAST('" + horaActual.ToString(new CultureInfo("en-US")) + "' AS DATETIME), NULL , '" + importeTotalArreglado + "', '" + idEmpleado + "', '" + tipoPago + "')");
            }
            
            DataTable resultados = conexion.consultar(@"SELECT TOP 1 idFactura FROM ventas ORDER BY idFactura DESC");
            int contador = 1;
            foreach ( DetalleVenta detalle in detalles)
            {
                string precioUnitarioArreglado = detalle.getPrecioUnitario().ToString().Replace(',', '.');
                conexion.ejecutarTransaccion(@"INSERT INTO detalleVentas (idDetalleVenta, idFactura, idProducto, precioUnitario, cantidad) 
                VALUES ('" + contador + "', '" + resultados.Rows[0]["idFactura"] + "', '" + detalle.getIdProducto() + "', '" + precioUnitarioArreglado + "', '" + detalle.getCantidadProducto() + "' )");

                DataTable stockAnteriorProducto = conexion.consultar(@"SELECT cantidadStock FROM productos WHERE idProducto = '" + detalle.getIdProducto() + "'");
                Object filaConsulta = stockAnteriorProducto.Rows[0][0];
                int stockActualProducto = Int32.Parse(filaConsulta.ToString()) - detalle.getCantidadProducto();
                conexion.ejecutarTransaccion(@"UPDATE productos SET cantidadStock = " + stockActualProducto + " WHERE idProducto = '" + detalle.getIdProducto() + "'");
                contador += 1;
            }   
            conexion.cerrar_transaccion();
        }
       
    }
}
