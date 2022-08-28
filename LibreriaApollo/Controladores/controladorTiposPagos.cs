using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaApollo.BD;
using System.Data;

namespace LibreriaApollo.Controladores
{
    class controladorTiposPagos
    {
        public DataTable buscarTiposPagos()
        {
            Conexion conexion = new Conexion();
            try
            {
                DataTable resultados = conexion.consultar(@"SELECT * FROM tiposPagos");
                return resultados;
            }
            catch
            {
                return new DataTable();
            }
        }

        public bool agregarTipoPago(string nombreTipoPago)
        {
            Conexion conexion = new Conexion();
            try
            {
                conexion.consultar($"INSERT INTO tiposPagos(nombreTipoPago) VALUES('{nombreTipoPago}');");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool modificarTipoPago(string idTipoPago, string nuevoNombreTipoPago)
        {
            Conexion conexion = new Conexion();
            try
            {
                conexion.consultar($"UPDATE tiposPagos " +
                                    $"SET nombreTipoPago = '{nuevoNombreTipoPago}' " +
                                    $"WHERE idTipoPago = {idTipoPago};");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
