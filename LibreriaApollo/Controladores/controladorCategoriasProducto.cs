using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaApollo.BD;
using System.Data;

namespace LibreriaApollo.Controladores
{
    class controladorCategoriasProducto
    {
        public DataTable buscarCategoriasProducto()
        {
            Conexion conexion = new Conexion();
            try
            {
                DataTable resultados = conexion.consultar(@"SELECT * FROM categoriasProductos");
                return resultados;
            }
            catch
            {
                return new DataTable();
            }
        }

        public bool agregarCategoriaProducto(string nombreCategoria, string descripcionCategoria)
        {
            Conexion conexion = new Conexion();
            try
            {
                conexion.consultar($"INSERT INTO categoriasProductos(nombreCategoria, descripcionCategoria) VALUES('{nombreCategoria}', '{descripcionCategoria}');");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool modificarCategoriaProducto(string idCategoria, string nuevoNombreCategoria, string nuevoDescripcionCategoria)
        {
            Conexion conexion = new Conexion();
            try
            {
                conexion.consultar($"UPDATE categoriasProductos " +
                                    $"SET nombreCategoria = '{nuevoNombreCategoria}', descripcionCategoria = '{nuevoDescripcionCategoria}' " +
                                    $"WHERE idCategoria = {idCategoria};");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
