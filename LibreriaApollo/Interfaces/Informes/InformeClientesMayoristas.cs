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
    public partial class InformeClientesMayoristas : Form
    {
        public InformeClientesMayoristas()
        {
            InitializeComponent();
        }

        private void InformeClientesMayoristas_Load(object sender, EventArgs e)
        {
            this.informeClientesMay.RefreshReport();
        }

        private void LoadInformeClientesMay(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            string sql = @"SELECT c.nroCliente, c.nombre, c.apellido, c.calle, c.nroCalle, c.codPostal, t.nombreTipoDoc as tipoDocumento, c.nroDocumento, c.email, c.telefono 
            FROM clientesMayoristas c JOIN tipoDocumento t ON c.tipoDocumento = t.idTipoDoc;";
            ayudante.cargarReporte(sql, "DataSet1", informeClientesMay);
        }
    }
}
