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
    public partial class estadisticaTiposPagosAnuales : Form
    {
        public estadisticaTiposPagosAnuales()
        {
            InitializeComponent();
        }

        private void estadisticaTiposPagosAnuales_Load(object sender, EventArgs e)
        {
            this.estadTiposPagosAnuales.RefreshReport();
        }

        private void loadEstadTiposPagosAnuales(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            string sql = @"SELECT v.idFactura, t.nombreTipoPago as nroCliente FROM ventas v JOIN tiposPagos t ON v.tipoPago = t.idTipoPago 
            WHERE YEAR(v.fechaHora) = '" + DateTime.Now.Year.ToString() +"';";
            ayudante.cargarReporte(sql, "DataSet1", estadTiposPagosAnuales);
        }

        private void consultar(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            if (txtAnio.Text.Length == 0 || !ayudante.esAnioValido(Int32.Parse(txtAnio.Text)))
            {
                MessageBox.Show("Ingrese un año valido!");
                return;
            }
            string sql = @"SELECT v.idFactura, t.nombreTipoPago as nroCliente FROM ventas v JOIN tiposPagos t ON v.tipoPago = t.idTipoPago 
            WHERE YEAR(v.fechaHora) = '" + txtAnio.Text + "'";
            if(txtMes.Text.Length > 0 && ayudante.esMesValido(Int32.Parse(txtMes.Text)))
            {
                sql += " AND MONTH(v.fechaHora) = '" + txtMes.Text + "';";
            }
            ayudante.cargarReporte(sql, "DataSet1", estadTiposPagosAnuales);
        }
    }
}
