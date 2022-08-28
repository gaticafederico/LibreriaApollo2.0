using LibreriaApollo.Controladores;
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

namespace LibreriaApollo.Interfaces
{
    public partial class frmConsultarVentas : Form
    {
        helpers ayudante = new helpers();
        controladorConsultarVenta controlador = new controladorConsultarVenta();
        public frmConsultarVentas()
        {
            InitializeComponent();
            cmbTipoPago.Cargar();
            cmbNomApe.CargarConcatenando();
            cmbNomApe.SelectedIndex = -1;
            cmbTipoPago.SelectedIndex = -1;
            this.buscarVentas("", "", "", 0);
        }
        private void buscarVentas(string nomApellido, string fechaDesde, string fechaHasta, int tipoPago)
        {
            gridVentas.DataSource = controlador.buscarVentas(nomApellido, fechaDesde, fechaHasta, tipoPago);
        }

        private void onBtnBuscarClick(object sender, EventArgs e)
        {
            this.buscarVentas(cmbNomApe.GetItemText(cmbNomApe.SelectedItem), ayudante.insertarFechaConFormato(maskFechaDesde.Text), ayudante.insertarFechaConFormato(maskFechaHasta.Text), cmbTipoPago.SelectedIndex + 1);
        }

        private void onBtnLimpiarFiltros(object sender, EventArgs e)
        {
            cmbNomApe.SelectedIndex = -1;
            cmbTipoPago.SelectedIndex = -1;
            maskFechaDesde.Text = "";
            maskFechaHasta.Text = "";
            this.buscarVentas("", "", "", 0);
        }

        private void OnGridVentasDobleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = gridVentas.Rows[e.RowIndex];
            frmDetalleVenta ventaSeleccionada = new frmDetalleVenta(filaSeleccionada.Cells[0].Value.ToString());
            ventaSeleccionada.ShowDialog();
        }
    }
}
