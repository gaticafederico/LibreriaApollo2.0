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
using Microsoft.Reporting.WinForms;

namespace LibreriaApollo.Interfaces.Estadisticas
{
    public partial class estadisticaCantidadVentasMensuales : Form
    {
        public estadisticaCantidadVentasMensuales()
        {
            InitializeComponent();
        }

        private void estadisticaCantidadVentasMensuales_Load(object sender, EventArgs e)
        {
            this.estadCantidadVentasMensuales.RefreshReport();
        }

        private void estadCantidadVentasMensuales_Load(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            string sql = @"SELECT MONTH(ventas.fechaHora) as nroCliente, ventas.idFactura FROM ventas WHERE YEAR(ventas.fechaHora) = '" + DateTime.Now.Year.ToString() + "' ORDER BY MONTH(ventas.fechaHora);";
            ayudante.cargarReporte(sql, "DataSet1", estadCantidadVentasMensuales);
        }

        private void consultar(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            if (!ayudante.esAnioValido(Int32.Parse(txtAnio.Text)))
            {
                MessageBox.Show("Ingrese un año valido!");
                return;
            }
            string sql = @"SELECT MONTH(ventas.fechaHora) as nroCliente, ventas.idFactura FROM ventas WHERE YEAR(ventas.fechaHora) = '" + txtAnio.Text + "' ORDER BY MONTH(ventas.fechaHora);";
            ayudante.cargarReporte(sql, "DataSet1", estadCantidadVentasMensuales);
        }
    }
}
