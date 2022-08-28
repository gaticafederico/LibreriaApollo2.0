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
    public partial class InformeClientesMayoristasMayor : Form
    {
        public InformeClientesMayoristasMayor()
        {
            InitializeComponent();
        }

        private void InformeClientesMayoristasMayor_Load(object sender, EventArgs e)
        {
            this.informeClientesMayMayor.RefreshReport();
        }

        private void LoadInformeClientesMayMayor(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            string sql = @"SELECT TOP 25 c.nroCliente, c.nombre, c.apellido, COUNT(v.idFactura) AS nroCalle, SUM(v.importeTotal) AS codPostal 
            FROM clientesMayoristas c JOIN ventas v ON v.nroCliente = c.nroCliente 
            GROUP BY c.nroCliente, c.nombre, c.apellido ORDER BY SUM(v.importeTotal) DESC;";
            ayudante.cargarReporte(sql, "DataSet1", informeClientesMayMayor);
        }
    }
}
