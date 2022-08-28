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
    public partial class estadisticaGananciaApilada : Form
    {
        public estadisticaGananciaApilada()
        {
            InitializeComponent();
        }

        private void estadisticaGananciaApilada_Load(object sender, EventArgs e)
        {
            this.estadGananciaApilada.RefreshReport();
        }

        private void loadEstadGananciaApilada(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();
            string sql = @"SELECT * FROM estadisticaVentasApiladas ORDER BY mes;";
            ayudante.cargarReporte(sql, "vistaVentaApilada", estadGananciaApilada);
        }
    }
}
