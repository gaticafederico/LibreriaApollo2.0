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
    public partial class InformeClientesMayoristasMenor : Form
    {
        public InformeClientesMayoristasMenor()
        {
            InitializeComponent();
        }

        private void InformeClientesMayoristasMenor_Load(object sender, EventArgs e)
        {
            this.informeClientesMayMenor.RefreshReport();
        }

        private void LoadInformeClientesMayMenor(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            string sql = @"SELECT TOP 25 c.nroCliente, c.nombre, c.apellido, COUNT(v.idFactura) AS nroCalle, SUM(v.importeTotal) AS codPostal 
            FROM clientesMayoristas c JOIN ventas v ON v.nroCliente = c.nroCliente 
            GROUP BY c.nroCliente, c.nombre, c.apellido ORDER BY SUM(v.importeTotal);";
            ayudante.cargarReporte(sql, "DataSet1", informeClientesMayMenor);
        }
    }
}
