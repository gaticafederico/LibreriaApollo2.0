using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaApollo.BD;
using System.Data;

namespace LibreriaApollo.Controladores
{
    class controladorTiposDocumento
    {
        public DataTable buscarTiposDocumento()
        {
            Conexion conexion = new Conexion();
            try
            {
                DataTable resultados = conexion.consultar(@"SELECT * FROM tipoDocumento");
                return resultados;
            }
            catch
            {
                return new DataTable();
            }
        }
    }
}
