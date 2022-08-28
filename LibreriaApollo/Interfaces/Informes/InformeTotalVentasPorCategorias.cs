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
    public partial class InformeTotalVentasPorCategorias : Form
    {
        public InformeTotalVentasPorCategorias()
        {
            InitializeComponent();
        }

        private void InformeTotalVentasPorCategorias_Load(object sender, EventArgs e)
        {
            this.InformeTotalVentasPorCat.RefreshReport();
        }

        private void LoadInformeTotalVentasPorCat(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            string sql = @"SELECT c.nombreCategoria AS idDetalleVenta, SUM(d.cantidad) AS idFactura, COUNT(v.idFactura) AS idProducto, SUM(v.importeTotal) AS precioUnitario
            FROM categoriasProductos c JOIN productos p ON c.idCategoria = p.idCategoria 
            JOIN detalleVentas d ON d.idProducto = p.idProducto
            JOIN ventas v ON v.idFactura = d.idFactura
            GROUP BY c.nombreCategoria;";
            ayudante.cargarReporte(sql, "DataSet1", InformeTotalVentasPorCat);
        }
    }
}
