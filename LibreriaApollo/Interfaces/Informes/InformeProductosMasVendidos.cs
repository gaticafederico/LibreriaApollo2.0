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
    public partial class InformeProductosMasVendidos : Form
    {
        public InformeProductosMasVendidos()
        {
            InitializeComponent();
        }

        private void loadInformeProdMasVendidos(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            string sql = @"SELECT TOP 20 p.idProducto, p.nombreProducto, p.descripcionProducto, SUM(d.cantidad) AS stockMinimo
            FROM productos p JOIN detalleVentas d ON p.idProducto = d.idProducto 
            GROUP BY p.idProducto, p.nombreProducto, p.descripcionProducto 
            ORDER BY SUM(d.cantidad) DESC;";
            ayudante.cargarReporte(sql, "fullDataSet", informeProdMasVendidos);
        }
    }
}
