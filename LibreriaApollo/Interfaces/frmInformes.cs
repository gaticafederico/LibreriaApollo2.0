using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaApollo.Interfaces.Informes;

namespace LibreriaApollo.Interfaces
{
    public partial class frmInformes : Form
    {
        public frmInformes()
        {
            InitializeComponent();
        }

        private void abrirListadoProductos(object sender, EventArgs e)
        {
            new InformeListadoProductos().ShowDialog();
        }

        private void abrirProductosMasVendidos(object sender, EventArgs e)
        {
            new InformeProductosMasVendidos().ShowDialog();
        }

        private void abrirProductosMenosVendidos(object sender, EventArgs e)
        {
            new InformeProductosMenosVendidos().ShowDialog();
        }

        private void abrirProductosFaltantes(object sender, EventArgs e)
        {
            new InformeProductosFaltantes().ShowDialog();
        }

        private void abrirVentasMensuales(object sender, EventArgs e)
        {
            new InformeMensualVentas().ShowDialog();
        }

        private void abrirGananciasDiarias(object sender, EventArgs e)
        {
            new InformeDiarioGanancias().ShowDialog();
        }

        private void abrirEmpleados(object sender, EventArgs e)
        {
            new InformeEmpleados().ShowDialog();
        }

        private void abrirClientesMayoristas(object sender, EventArgs e)
        {
            new InformeClientesMayoristas().ShowDialog();
        }

        private void abrirClientesMenosVentas(object sender, EventArgs e)
        {
            new InformeClientesMayoristasMenor().ShowDialog();
        }

        private void abrirClientesMasVentas(object sender, EventArgs e)
        {
            new InformeClientesMayoristasMayor().ShowDialog();
        }

        private void abrirRecaudacionPorCat(object sender, EventArgs e)
        {
            new InformeTotalVentasPorCategorias().ShowDialog();
        }
    }
}
