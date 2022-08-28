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
    public partial class estadisticaProductosMasVendidos : Form
    {
        public estadisticaProductosMasVendidos()
        {
            InitializeComponent();
        }

        private void estadisticaProductosMasVendidos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            string sql = @"SELECT v.idProducto , p.nombreProducto FROM detalleVentas v JOIN productos p ON v.idProducto = p.idProducto;";
            ayudante.cargarReporte(sql, "DataSet1", reportViewer1);
        }
    }
}
