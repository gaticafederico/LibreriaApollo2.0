using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaApollo.Controladores;

namespace LibreriaApollo.Interfaces
{
    public partial class frmDetalleVenta : Form
    {
        controladorDetalleVenta controlador = new controladorDetalleVenta();
        public frmDetalleVenta(string idVenta)
        {
            InitializeComponent();
            gridDetalleVentas.DataSource = controlador.buscarDetalleVentasPorIDVenta(idVenta);

            DataTable completar = controlador.completarLabels(idVenta);
            DataRow primeraFila = completar.Rows[0];

            String[] fechaHora = primeraFila[0].ToString().Split(' ');
            lblFechaHora.Text = "Fecha: " + fechaHora[0];
            lblNomApeCliente.Text = "Cliente: " + primeraFila[1].ToString();
            lblNomApeEmpleado.Text = "Empleado: " + primeraFila[2].ToString();
            lblTipoPago.Text = "Tipo Pago: " + primeraFila[3].ToString();
            lblPrecioTotal.Text = "Precio Total: " + primeraFila[4].ToString();
        }
    }
}
