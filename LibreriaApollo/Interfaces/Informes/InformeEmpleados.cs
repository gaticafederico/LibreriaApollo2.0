using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaApollo.Helpers;

namespace LibreriaApollo.Interfaces.Informes
{
    public partial class InformeEmpleados : Form
    {
        public InformeEmpleados()
        {
            InitializeComponent();
        }

        private void InformeEmpleados_Load(object sender, EventArgs e)
        {
            this.informeEmplead.RefreshReport();
        }

        private void LoadInformeEmplead(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            string sql = @"SELECT e.idEmpleado, e.usuario, e.nombre, e.apellido, CONVERT(DATE, e.fechaNacimiento) as fechaNacimiento, CONVERT(DATE, e.fechaIngreso) as fechaIngreso, 'SI' as sigueTrabajando, p.nombrePerfil as idPerfil from empleados e join perfil p ON e.idPerfil = p.idPerfil WHERE sigueTrabajando = 1
            UNION
            SELECT e.idEmpleado, e.usuario, e.nombre, e.apellido, CONVERT(DATE, e.fechaNacimiento) as fechaNacimiento, CONVERT(DATE, e.fechaIngreso) as fechaIngreso, 'NO' as sigueTrabajando, p.nombrePerfil as idPerfil from empleados e join perfil p ON e.idPerfil = p.idPerfil WHERE sigueTrabajando = 0";
            ayudante.cargarReporte(sql, "DataSet1", informeEmplead);
        }
    }
}
