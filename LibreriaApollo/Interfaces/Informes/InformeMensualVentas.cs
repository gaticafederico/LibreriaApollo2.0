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
    public partial class InformeMensualVentas : Form
    {
        public InformeMensualVentas()
        {
            InitializeComponent();
        }

        private void InformeMensualVentas_Load(object sender, EventArgs e)
        {
            this.informeMensVentas.RefreshReport();
        }

        private void consultarVentasMensuales(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            if(!ayudante.esAnioValido(Int32.Parse(txtAnio.Text)) || !ayudante.esMesValido(Int32.Parse(txtMes.Text))) 
            {
                MessageBox.Show("Año o mes invalido!");
                return;
            }
            string sql = @"SELECT e.idEmpleado, e.nombre, e.apellido, SUM(d.cantidad) as usuario, 
            (SELECT COUNT(*) FROM detalleVentas de JOIN ventas ve ON de.idFactura = ve.idFactura WHERE idDetalleVenta = 1 AND e.idEmpleado = ve.idEmpleado AND MONTH(ve.fechaHora) = '" + txtMes.Text + @"' AND YEAR(ve.fechaHora) = '" + txtAnio.Text +
            @"') as contrasenia,
            (SELECT SUM(ventas.importeTotal) FROM ventas WHERE ventas.idEmpleado = e.idEmpleado AND MONTH(ventas.fechaHora) = '" + txtMes.Text + @"' AND YEAR(ventas.fechaHora) = '" + txtAnio.Text +
            @"') AS sigueTrabajando
            FROM empleados e JOIN ventas v ON e.idEmpleado = v.idEmpleado 
            JOIN detalleVentas d ON v.idFactura = d.idFactura
            WHERE MONTH(v.fechaHora) = '" + txtMes.Text + @"' AND YEAR(v.fechaHora) = '" + txtAnio.Text + 
            @"' GROUP BY e.idEmpleado, e.nombre, e.apellido";
            ayudante.cargarReporte(sql, "DataSet1", informeMensVentas);
        }
    }
}
