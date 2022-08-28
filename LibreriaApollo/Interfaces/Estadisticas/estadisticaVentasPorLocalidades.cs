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
    public partial class estadisticaVentasPorLocalidades : Form
    {
        public estadisticaVentasPorLocalidades()
        {
            InitializeComponent();
        }

        private void estadisticaVentasPorLocalidades_Load(object sender, EventArgs e)
        {
            this.estadVentasPorLocalidades.RefreshReport();
        }

        private void loadEstadVentasPorLocalidades(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            string sql = @"SELECT v.idFactura, l.nombre AS nroCliente FROM ventas v 
            JOIN clientesMayoristas c ON v.nroCliente = c.nroCliente 
            JOIN localidades l ON l.codPostal = c.codPostal;";
            ayudante.cargarReporte(sql, "DataSet1", estadVentasPorLocalidades);
        }
    }
}
