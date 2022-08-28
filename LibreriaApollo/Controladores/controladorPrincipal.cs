using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaApollo.BD;

namespace LibreriaApollo.Controladores
{
    class controladorPrincipal
    {
        public string contarTabla(string nombreTabla)
        {
            Conexion conexion = new Conexion();
            DataTable resultado = conexion.consultar("SELECT COUNT(*) FROM " + nombreTabla + ";");
            DataRow fila = resultado.Rows[0];
            return fila[0].ToString();
        }
        public string contarVentas()
        {
            return this.contarTabla("ventas");
        }

        public string contarProductos()
        {
            return this.contarTabla("productos");
        }

        public string contarEmpleados()
        {
            return this.contarTabla("empleados");
        }

        public string contarClientesMayoristas()
        {
            return this.contarTabla("clientesMayoristas");
        }
    }
}
