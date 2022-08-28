using LibreriaApollo.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaApollo.Interfaces.Estadisticas
{
    public partial class estadisticaAntiguedadEmpleados : Form
    {
        public estadisticaAntiguedadEmpleados()
        {
            InitializeComponent();
        }

        private void estadisticaAntiguedadEmpleados_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            string sql = @"SELECT e.nombre , e.sigueTrabajando FROM empleados e;";
            ayudante.cargarReporte(sql, "DataSet1", reportViewer1);
        }
    }
}
