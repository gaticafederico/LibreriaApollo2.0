using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaApollo.BD;

namespace LibreriaApollo.Entidades
{
    class ComboBox2 : ComboBox
    {
        Conexion bd = new Conexion();
        public string ppNombreTablaCargar { get; set; }
        public string ppPkTablaCargar { get; set; }
        public string ppDescriptorTablaCargar { get; set; }
        public bool ppValidar { get; set; }
        public string ppNombreTabla { get; set; }
        public string ppNombreCampo { get; set; }

        public void Cargar()
        {
            string sql = "SELECT * FROM " + this.ppNombreTablaCargar.Trim();
            this.DisplayMember = ppDescriptorTablaCargar;
            this.ValueMember = ppPkTablaCargar;
            this.DataSource = bd.consultar(sql);
        }

        public void CargarConcatenando()
        {
            string sql = "SELECT idEmpleado, ( nombre + ' ' + apellido) AS NombreApellido FROM empleados"; 
            DataTable resultados = bd.consultar(sql);
            this.DisplayMember = ppDescriptorTablaCargar;
            this.ValueMember = ppPkTablaCargar;
            this.DataSource = resultados;
        }
    }
}