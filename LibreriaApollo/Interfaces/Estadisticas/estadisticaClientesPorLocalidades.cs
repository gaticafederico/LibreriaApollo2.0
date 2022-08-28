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

namespace LibreriaApollo.Interfaces.Estadisticas
{
    public partial class estadisticaClientesPorLocalidades : Form
    {
        public estadisticaClientesPorLocalidades()
        {
            InitializeComponent();
        }

        private void estadisticaClientesPorLocalidades_Load(object sender, EventArgs e)
        {
            this.estadClientesPorLocalidades.RefreshReport();
        }

        private void loadEstadClientesPorLocalidades(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            string sql = @"SELECT c.nroCliente, l.nombre as nombre  FROM clientesMayoristas c JOIN localidades l ON c.codPostal = l.codPostal;";
            ayudante.cargarReporte(sql, "DataSet1", estadClientesPorLocalidades);
        }
    }
}
