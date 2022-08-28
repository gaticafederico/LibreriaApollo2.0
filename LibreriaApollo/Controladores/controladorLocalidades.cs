using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaApollo.BD;
using System.Data;

namespace LibreriaApollo.Controladores
{
    class controladorLocalidades
    {
        public DataTable buscarLocalidades()
        {
            Conexion conexion = new Conexion();
            try
            {
                DataTable resultados = conexion.consultar(@"SELECT * FROM localidades");
                return resultados;
            }
            catch
            {
                return new DataTable();
            }
        }

        public bool agregarLocalidad(string codPostal, string nombre)
        {
            Conexion conexion = new Conexion();
            try
            {
                conexion.consultar($"INSERT INTO localidades(codPostal, nombre) VALUES({codPostal}, '{nombre}');");
                return true;
            } 
            catch
            {
                return false;
            }
        }

        public bool modificarLocalidad(string codPostal, string nuevoCodPostal, string nombre)
        {
            Conexion conexion = new Conexion();
            try
            {
                conexion.consultar($"UPDATE localidades " +
                                    $"SET codPostal = {nuevoCodPostal}, nombre = '{nombre}' " +
                                    $"WHERE codPostal = {codPostal};");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
