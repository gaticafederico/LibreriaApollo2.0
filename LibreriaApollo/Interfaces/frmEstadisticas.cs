using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaApollo.Interfaces.Estadisticas;

namespace LibreriaApollo.Interfaces
{
    public partial class frmEstadisticas : Form
    {
        public frmEstadisticas()
        {
            InitializeComponent();
        }

        private void abrirPromedioProductos(object sender, EventArgs e)
        {
            new estadisticaProductosPorCategoria().ShowDialog();
        }

        private void abrirProductosPorMes(object sender, EventArgs e)
        {
            new estadisticaCantidadVentasMensuales().ShowDialog();
        }

        private void abrirPromedioTipoPagoAnual(object sender, EventArgs e)
        {
            new estadisticaTiposPagosAnuales().ShowDialog();
        }

        private void abrirClientesPorLocalidades(object sender, EventArgs e)
        {
            new estadisticaClientesPorLocalidades().ShowDialog();
        }

        private void abrirVentasPorLocalidades(object sender, EventArgs e)
        {
            new estadisticaVentasPorLocalidades().ShowDialog();
        }

        private void abrirVentasPorEmpleados(object sender, EventArgs e)
        {
            new estadisticaVentasPorEmpleado().ShowDialog();
        }

        private void abrirGananciasMensuales(object sender, EventArgs e)
        {
            new estadisticaGananciasAnuales().ShowDialog();
        }

        private void abrirGananciasApiladas(object sender, EventArgs e)
        {
            new estadisticaGananciaApilada().ShowDialog();
        }

        private void btnProductosMasVendidos_Click(object sender, EventArgs e)
        {
            new estadisticaProductosMasVendidos().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new estadisticaAntiguedadEmpleados().ShowDialog();
        }
    }
}
