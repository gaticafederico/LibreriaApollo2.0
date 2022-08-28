using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using LibreriaApollo.BD;
using LibreriaApollo.Entidades;

namespace LibreriaApollo.Controladores
{
    class controladorEmpleados
    {
        public Empleado validarEmpleado(string usernameEnviado, string passwordEnviado)
        {
            Conexion conexion = new Conexion();
            try
            {
                DataTable resultados = conexion.consultar(@"SELECT idEmpleado, usuario, contrasenia, nombre, apellido, fechaNacimiento, fechaIngreso, sigueTrabajando, idPerfil FROM empleados WHERE usuario='" + usernameEnviado + "' AND contrasenia='" + passwordEnviado + "' AND sigueTrabajando='1'");
                DataRow fila = resultados.Rows[0];
                if (resultados.Rows.Count > 0)
                {
                    int idEmpleado = Int32.Parse(fila[0].ToString());
                    string usuario = fila[1].ToString();
                    string password = fila[2].ToString();
                    string nombre = fila[3].ToString();
                    string apellido = fila[4].ToString();
                    string fechaNacimiento = fila[5].ToString();
                    string fechaIngreso = fila[6].ToString();
                    bool sigueTrabajando = Convert.ToBoolean(fila[7].ToString());
                    int idPerfil = Int32.Parse(fila[8].ToString());
                    return new Empleado(idEmpleado,usuario,password,nombre,apellido,fechaNacimiento,fechaIngreso,sigueTrabajando,idPerfil);
                }
                return new Empleado(-1);
            } catch
            {
                return new Empleado(-1);
            }
        }

        public DataTable mostrarTodosEmpleados(string filtroNombre, string filtroEstado)
        {
            Conexion conexion = new Conexion();
            try
            {
                DataTable resultados = new DataTable();
                if(filtroEstado == "Todos")
                {
                    resultados = conexion.consultar(@"SELECT empleados.idEmpleado, empleados.usuario, empleados.nombre, empleados.apellido, empleados.fechaNacimiento, empleados.fechaIngreso, empleados.sigueTrabajando, empleados.idPerfil, perfil.nombrePerfil FROM empleados JOIN perfil ON empleados.idPerfil = perfil.idPerfil WHERE nombre LIKE '" + filtroNombre + "%'");
                }
                else if(filtroEstado == "Activos")
                {
                    resultados = conexion.consultar(@"SELECT empleados.idEmpleado, empleados.usuario, empleados.nombre, empleados.apellido, empleados.fechaNacimiento, empleados.fechaIngreso, empleados.sigueTrabajando, empleados.idPerfil, perfil.nombrePerfil FROM empleados JOIN perfil ON empleados.idPerfil = perfil.idPerfil WHERE nombre LIKE '" + filtroNombre + "%' AND sigueTrabajando=1");
                }
                else if(filtroEstado == "Inactivos")
                {
                    resultados = conexion.consultar(@"SELECT empleados.idEmpleado, empleados.usuario, empleados.nombre, empleados.apellido, empleados.fechaNacimiento, empleados.fechaIngreso, empleados.sigueTrabajando, empleados.idPerfil, perfil.nombrePerfil FROM empleados JOIN perfil ON empleados.idPerfil = perfil.idPerfil WHERE nombre LIKE '" + filtroNombre + "%' AND sigueTrabajando=0");
                }  
                return resultados;
            } catch
            {
                return new DataTable();
            }
        }

        public bool buscarEmpleado(string usuario)
        {
            try
            {
                Conexion conexion = new Conexion();
                DataTable resultados = conexion.consultar(@"SELECT * FROM empleados WHERE usuario LIKE '" + usuario + "'");
                if(resultados.Rows.Count > 0)
                {
                    return true;
                }
                return false;
            } catch(Exception ex)
            {
                MessageBox.Show("Hubo un err:" + ex.Message);
                return true;
            }
        }
        public bool modificarSinCambiar(int idEmpleado, string usuario, string nombre, string apellido, string fechaNacimiento, string fechaIngreso, bool sigueTrabajando, int idPerfil)
           {
            string fechaNacModificada = this.modificarFecha(fechaNacimiento);
            string fechaIngModificada = this.modificarFecha(fechaIngreso);
            try
            {
                Conexion conexion = new Conexion();
                conexion.consultar(@"UPDATE empleados SET usuario = '" + usuario + "', " +
                    "nombre = '" + nombre + "', apellido = '" + apellido + "', fechaNacimiento = CAST('" + fechaNacModificada + "' AS DATETIME), fechaIngreso = CAST('" + fechaIngModificada + "' AS DATETIME), sigueTrabajando = '" + sigueTrabajando +
                    "', idPerfil = '" + idPerfil + "' WHERE idEmpleado = '" + idEmpleado + "'");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un err:" + ex.Message);
                return false;
            }
            
        }

        public bool modificarConCambiar(int idEmpleado, string usuario, string password, string nombre, string apellido, string fechaNacimiento, string fechaIngreso, bool sigueTrabajando, int idPerfil)
        {
            string fechaNacModificada = this.modificarFecha(fechaNacimiento);
            string fechaIngModificada = this.modificarFecha(fechaIngreso);
            try
            {
                Conexion conexion = new Conexion();
                conexion.consultar(@"UPDATE empleados SET usuario = '" + usuario + "', contrasenia='" + password + "', " +
                    "nombre = '" + nombre + "', apellido = '" + apellido + "', fechaNacimiento = CAST('" + fechaNacModificada + "' AS DATETIME), fechaIngreso = CAST('" + fechaIngModificada + "' AS DATETIME), sigueTrabajando = '" + sigueTrabajando +
                    "', idPerfil = '" + idPerfil + "' WHERE idEmpleado = '" + idEmpleado + "'");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un err:" + ex.Message);
                return false;
            }
            
        }
        public bool crearEmpleado(string usuario, string password, string nombre, string apellido, string fechaNacimiento, string fechaIngreso, bool sigueTrabajando, int idPerfil)
        {
            try
            {
                Conexion conexion = new Conexion();
                conexion.consultar(@"INSERT INTO empleados (usuario, contrasenia, nombre, apellido, fechaNacimiento, fechaIngreso, sigueTrabajando, idPerfil) VALUES ('" + usuario + "', '" + password + "', '" + nombre + "', '" + apellido + "', '" + fechaNacimiento + "', '" + fechaIngreso + "', '" + sigueTrabajando + "', '" + idPerfil + "')");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un err:" + ex.Message);
                return false;
            }
            
        }
        
        private string modificarFecha (string fecha)
        {
            String[] array = fecha.Split('/');

            return array[1] + "/" + array[0] + "/" + array[2];
        }
    }

}
