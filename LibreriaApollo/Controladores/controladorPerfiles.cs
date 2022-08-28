using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibreriaApollo.BD;
using LibreriaApollo.Entidades;

namespace LibreriaApollo.Controladores
{
    class controladorPerfiles
    {
        public DataTable buscarPerfiles()
        {
            Conexion conexion = new Conexion();
            try
            {
                DataTable resultados = conexion.consultar(@"SELECT nombrePerfil FROM perfil");
                return resultados;
            }
            catch
            {
                return new DataTable();
            }
        }
    }
}
