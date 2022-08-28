using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaApollo.BD;
using System.Data;
using System.Windows.Forms;

namespace LibreriaApollo.Controladores
{
    class controladorMayoristas
    {
        public DataTable mostrarTodosClientes(string filtroNombre, string filtroNroDocumento)
        {
            Conexion conexion = new Conexion();
            try
            {
                DataTable resultados = new DataTable();
                resultados = conexion.consultar(@"SELECT clientesMayoristas.nroCliente, clientesMayoristas.nombre, clientesMayoristas.apellido, 
                            clientesMayoristas.calle, clientesMayoristas.nroCalle, clientesMayoristas.codPostal, tipoDocumento.nombreTipoDoc, 
                            clientesMayoristas.nroDocumento, clientesMayoristas.email, clientesMayoristas.telefono, clientesMayoristas.tipoDocumento FROM clientesMayoristas JOIN tipoDocumento 
                            ON clientesMayoristas.tipoDocumento = tipoDocumento.idTipoDoc 
                            WHERE nombre LIKE '" + filtroNombre + "%' AND nroDocumento LIKE '" + filtroNroDocumento + "%'");

                return resultados;
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }

        public bool buscarMayorista(string nombre)
        {
            try
            {
                Conexion conexion = new Conexion();
                DataTable resultados = conexion.consultar(@"SELECT * FROM clientesMayoristas WHERE nombre LIKE '" + nombre + "'");
                if (resultados.Rows.Count > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un err:" + ex.Message);
                return true;
            }
        }

        public DataTable buscarMayorista(string tipoDocumento, string nroDocumento)
        {
            try
            {
                Conexion conexion = new Conexion();
                DataTable resultados = conexion.consultar(@"SELECT nombre, nroCliente FROM clientesMayoristas WHERE tipoDocumento LIKE '" + tipoDocumento + "' AND nroDocumento LIKE'" + nroDocumento + "%'");
                if (resultados.Rows.Count > 0)
                {
                    return resultados;
                }
                return resultados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un err:" + ex.Message);
                return new DataTable();
            }
        }

        public bool crearMayorista(string nombre, string apellido, string calle, string nroCalle, string codPostal, int tipoDocumento, string nroDocumento, string email, string telefono)
        {
            try
            {
                Conexion conexion = new Conexion();
                conexion.consultar(@"INSERT INTO clientesMayoristas (nombre, apellido, calle, nroCalle, codPostal, tipoDocumento, nroDocumento, email, telefono)
VALUES ('" + nombre + "', '" + apellido + "', '" + calle + "', '" + nroCalle + "', '" + codPostal + "', '" + tipoDocumento + "', '" + nroDocumento + "', '" + email + "', '" + telefono + "')");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un err:" + ex.Message);
                return false;
            }
        }

        public bool modificarMayorista(int mayoristaID, string nombre, string apellido, string calle, string nroCalle, string codPostal, int tipoDocumento, string nroDocumento, string email, string telefono)
        {
            try
            {
                Conexion conexion = new Conexion();
                conexion.consultar(@"UPDATE clientesMayoristas SET nombre = '" + nombre + "', apellido = '" + apellido + "', calle = '" + calle + "', nroCalle = '" + nroCalle + "', codPostal = '" + codPostal +"', tipoDocumento = '" + tipoDocumento + "', nroDocumento = '" + nroDocumento + "', email = '" + email + "', telefono = '" + telefono + "' WHERE nroCliente LIKE " + mayoristaID);
                return true;
            } catch(Exception ex)
            {
                MessageBox.Show("Hubo un err:" + ex.Message);
                return false;
            }
        }

        public bool borrarMayorista(int mayoristaID)
        {
            try
            {
                Conexion conexion = new Conexion();
                conexion.consultar(@"DELETE FROM clientesMayoristas WHERE nroCliente = '" + mayoristaID + "'");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepcion: " + ex.Message);
                return false;
            }
        }
    }
}
