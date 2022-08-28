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

namespace LibreriaApollo.Interfaces.Informes
{
    public partial class InformeProductosMenosVendidos : Form
    {
        public InformeProductosMenosVendidos()
        {
            InitializeComponent();
        }

        private void InformeProductosMenosVendidos_Load(object sender, EventArgs e)
        {
            this.informeProdMenosVendidos.RefreshReport();
        }

        private void loadInformeProdMenosVendidos(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            string sql = @"SELECT TOP 20 p.idProducto, p.nombreProducto, p.descripcionProducto, SUM(d.cantidad) AS stockMinimo
            FROM productos p JOIN detalleVentas d ON p.idProducto = d.idProducto 
            GROUP BY p.idProducto, p.nombreProducto, p.descripcionProducto 
            ORDER BY SUM(d.cantidad) ASC;";
            ayudante.cargarReporte(sql, "DataSet1", informeProdMenosVendidos);
        }
    }
}
