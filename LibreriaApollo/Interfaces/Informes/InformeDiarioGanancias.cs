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
    public partial class InformeDiarioGanancias : Form
    {
        public InformeDiarioGanancias()
        {
            InitializeComponent();
        }

        private void InformeDiarioGanancias_Load(object sender, EventArgs e)
        {
            this.informeDiarioGanan.RefreshReport();
        }

        private void consultar(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            if(!ayudante.esFechaValida(txtFecha.Text))
            {
                MessageBox.Show("Fecha invalida!");
                return;
            }
            string sql = @"SELECT idFactura, importeTotal, ROUND(importeTotal * 0.21, 2) as idEmpleado, 
            ROUND(importeTotal * 0.79, 2) as tipoPago FROM ventas WHERE CONVERT(DATE, fechaHora) = '" + ayudante.insertarFechaConFormato(txtFecha.Text) + "';";
            ayudante.cargarReporte(sql, "DataSet1", informeDiarioGanan);
        }

        private void loadInformeDiarioGanan(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            string sql = @"SELECT idFactura, importeTotal, ROUND(importeTotal * 0.21, 2) as idEmpleado, 
            ROUND(importeTotal * 0.79, 2) as tipoPago FROM ventas WHERE CONVERT(DATE, fechaHora) = '" + ayudante.insertarFechaConFormato(DateTime.Now.ToString("dd/MM/yyyy")) + "';";
            ayudante.cargarReporte(sql, "DataSet1", informeDiarioGanan);
        }
    }
}
