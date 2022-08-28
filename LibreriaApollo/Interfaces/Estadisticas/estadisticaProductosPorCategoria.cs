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
    public partial class estadisticaProductosPorCategoria : Form
    {
        public estadisticaProductosPorCategoria()
        {
            InitializeComponent();
        }

        private void estadisticaProductosPorCategoria_Load(object sender, EventArgs e)
        {
            this.estadProductosPorCategoria.RefreshReport();
        }

        private void loadEstadProductosPorCategoria(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            string sql = @"SELECT p.idProducto, p.idCategoria, c.nombreCategoria as stockMinimo FROM productos p JOIN categoriasProductos c ON p.idCategoria = c.idCategoria;";
            ayudante.cargarReporte(sql, "DataSet1", estadProductosPorCategoria);
        }
    }
}
