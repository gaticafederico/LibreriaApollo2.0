using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaApollo.BD;
using Microsoft.Reporting.WinForms;
using LibreriaApollo.Helpers;

namespace LibreriaApollo.Interfaces.Informes
{
    public partial class InformeListadoProductos : Form
    {
        public InformeListadoProductos()
        {
            InitializeComponent();
        }

        private void loadInformeListadoProd(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            string sql = @"SELECT idProducto, nombreProducto, descripcionProducto, cantidadStock, ('$' + CONVERT(VARCHAR, precioUnitario)) as precioUnitario, stockMinimo, idCategoria FROM productos;";
            ayudante.cargarReporte(sql, "datosProductos", informeListadoProd);
        }
    }
}
