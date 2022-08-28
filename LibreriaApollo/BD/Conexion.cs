using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LibreriaApollo.BD
{
    class Conexion
    {   public enum estado_BE { correcto, error }
        public enum tipo_conexion { simple, transaccion }

        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbTransaction transaccion; 
        estado_BE control_transaccion = estado_BE.correcto; 
        tipo_conexion analisis_tipo_conexion = tipo_conexion.simple;

        string cadena_conexion = "Provider=SQLNCLI11;Data Source=LAPTOP-2GCAJ5FQ\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=apollo2";
        private void conectar()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = cadena_conexion;
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                if (analisis_tipo_conexion == tipo_conexion.transaccion)
                {
                    transaccion = conexion.BeginTransaction(IsolationLevel.ReadCommitted);
                    cmd.Transaction = transaccion;
                }
            }
        }

        public DataTable consultar(string sql)
        {
            this.conectar();
            DataTable tabla = new DataTable();
            cmd.CommandText = sql;
            tabla.Load(cmd.ExecuteReader());
            this.desconectar();
            return tabla;
        }
        private void desconectar()
        {
            if (analisis_tipo_conexion == tipo_conexion.simple)
            { 
                conexion.Close(); 
            } 
        }
 
        public void iniciar_transaccion()
        { 
          analisis_tipo_conexion = tipo_conexion.transaccion; 
          control_transaccion = estado_BE.correcto; 
        }
        public void cerrar_transaccion() 
        { 
            if (analisis_tipo_conexion == tipo_conexion.simple) 
            { 
                MessageBox.Show("Está intentado cerrar una transacción que no abrio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop); 
                return; 
            } 
            if (control_transaccion == estado_BE.correcto) 
            { 
                transaccion.Commit(); 
            }
            else
            { 
                transaccion.Rollback(); 
            } 
            analisis_tipo_conexion = tipo_conexion.simple; 
            desconectar();
        }
        public estado_BE ejecutarTransaccion(string sql) 
        { 
            this.conectar(); this.cmd.CommandText = sql;
            try
            { 
                this.cmd.ExecuteNonQuery();
            } 
            catch (Exception e) 
            { 
                control_transaccion = estado_BE.error;
                MessageBox.Show("Error con la Base de Datos" + "\n" + "En el comando:" + "\n" + sql + "\n" + "El mensaje es:" + "\n" + e.Message); 
            }
            desconectar(); 
            return control_transaccion; 
        }
    }
}
