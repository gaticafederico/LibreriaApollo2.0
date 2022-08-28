using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaApollo.Entidades
{
    public class Empleado
    {
        private string usuario, password, nombre, apellido, fechaNac, fechaIng;
        private int idTipoPerfil;
        private int idEmpleado;
        private bool sigueTrabajando;

        public int getIdEmpleado()
        {
            return this.idEmpleado;
        }
        public int IDEmpleado
        {
            get => idEmpleado;
            set => idEmpleado = value;
        }

        public bool EnTrabajo
        {
            get => sigueTrabajando;
            set => sigueTrabajando = value;
        }
        public string Usuario
        {
            get => usuario;
            set => usuario = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Apellido
        {
            get => apellido;
            set => apellido = value; 
        }

        public string FechaNac
        {
            get => fechaNac;
            set => fechaNac = value;
        }

        public string FechaIng
        {
            get => fechaIng;
            set => fechaIng = value;
        }

        public int IdTipoPerfil
        {
            get => idTipoPerfil;
            set => idTipoPerfil = value;
        }

        public Empleado(int idEmpleado)
        {
            this.idEmpleado = idEmpleado;
        }
        public Empleado(int idEmpleado, string usuario, string password, string nombre, string apellido, string fechaNac, string fechaIng, bool sigueTrabajando, int idTipoPerfil)
        {
            this.idEmpleado = idEmpleado;
            this.usuario = usuario;
            this.password = password;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.fechaIng = fechaIng;
            this.sigueTrabajando = sigueTrabajando;
            this.idTipoPerfil = idTipoPerfil;
        }
    }
}
