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
    public partial class InformeProductosFaltantes : Form
    {
        public InformeProductosFaltantes()
        {
            InitializeComponent();
        }

        private void InformeProductosFaltantes_Load(object sender, EventArgs e)
        {
            this.informeProdFaltantes.RefreshReport();
        }

        private void loadInformeProdFaltantes(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            string sql = @"SELECT idProducto, nombreProducto, descripcionProducto, stockMinimo, cantidadStock, (stockMinimo - cantidadStock) AS idCategoria 
FROM productos WHERE (stockMinimo - cantidadStock) > 0;";
            ayudante.cargarReporte(sql, "DataSet1", informeProdFaltantes);
        }
    }
}
