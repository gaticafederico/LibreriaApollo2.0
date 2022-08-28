using LibreriaApollo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaApollo.Interfaces
{
    public partial class frmVentas : Form
    {
        private Empleado empleadologueado;

        public frmVentas(Empleado empleado)
        {
            this.empleadologueado = empleado;
            InitializeComponent();     
        }

        private void abrirRegistroVenta(object sender, EventArgs e)
        {
            frmRegistrarVenta venta = new frmRegistrarVenta(empleadologueado);
            venta.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConsultarVentas consulta = new frmConsultarVentas();
            consulta.ShowDialog();
            this.Close();
        }
    }
}
