using LibreriaApollo.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaApollo.Controladores
{
    class controladorDetalleVenta
    {
        public DataTable buscarDetalleVentasPorIDVenta(string idVenta)
        {
            Conexion conexion = new Conexion();
            return conexion.consultar(@"SELECT d.idDetalleVenta, p.idProducto, p.nombreProducto, d.cantidad, 
            d.precioUnitario FROM detalleVentas d JOIN productos p ON d.idProducto = p.idProducto WHERE d.idFactura = " + idVenta);
        }

        public DataTable completarLabels (string idVenta)
        {
            Conexion conexion = new Conexion();
            return conexion.consultar(@"SELECT CONVERT(DATE, v.fechaHora) AS fecha, (c.nombre + ' ' + c.apellido) as 
            clienteNombreApellido, (e.nombre + ' ' + e.apellido) as empleadoNombreApellido, t.nombreTipoPago, v.importeTotal 
            FROM ventas v LEFT JOIN clientesMayoristas c ON v.nroCliente = c.nroCliente
            JOIN empleados e ON v.idEmpleado = e.idEmpleado
            JOIN tiposPagos t ON v.tipoPago = t.idTipoPago WHERE v.idFactura = " + idVenta + ";");
        }
    }
}
