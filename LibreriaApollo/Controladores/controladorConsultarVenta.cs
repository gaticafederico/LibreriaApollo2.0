using LibreriaApollo.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaApollo.Controladores
{
    class controladorConsultarVenta
    {
        public DataTable buscarVentas(string nombreApellido, string fechaDesde, string fechaHasta, int tipoPago)
        {
            string sql = @"SELECT ventas.idFactura, ventas.fechaHora, (empleados.nombre + ' ' + empleados.apellido) AS empleado, (clientesMayoristas.nombre +
' ' + clientesMayoristas.apellido) AS cliente, tiposPagos.nombreTipoPago, ventas.importeTotal
FROM ventas JOIN tiposPagos ON ventas.tipoPago = tiposPagos.idTipoPago
JOIN empleados ON ventas.idEmpleado = empleados.idEmpleado
LEFT JOIN clientesMayoristas ON ventas.nroCliente = clientesMayoristas.nroCliente WHERE 1 = 1";
            if (nombreApellido != "")
            {
                sql += " AND (empleados.nombre + ' ' + empleados.apellido) = '" + nombreApellido + "'";
            }
            if(fechaDesde != "")
            {
                sql += " AND CONVERT(DATE, ventas.fechaHora) >= '" + fechaDesde + "'";
            }
            if(fechaHasta != "")
            {
                sql += " AND CONVERT(DATE, ventas.fechaHora) <= '" + fechaHasta + "'";
            }
            if(tipoPago > 0)
            {
                sql += " AND tiposPagos.idTipoPago = '" + tipoPago.ToString() + "'"; 
            }

            sql += ";";
            Conexion conexion = new Conexion();
            DataTable resultado = conexion.consultar(sql);
            return resultado;
        }
    }
}
