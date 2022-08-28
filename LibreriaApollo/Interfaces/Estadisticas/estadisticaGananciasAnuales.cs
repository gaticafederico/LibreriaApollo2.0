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
    public partial class estadisticaGananciasAnuales : Form
    {
        public estadisticaGananciasAnuales()
        {
            InitializeComponent();
        }

        private void estadisticaGananciasAnuales_Load(object sender, EventArgs e)
        {
            this.estadGananciasAnuales.RefreshReport();
        }

        private void consultar(object sender, EventArgs e)
        {
            helpers ayudante = new helpers();

            if(txtAnio.Text.Length == 0 || !ayudante.esAnioValido(Int32.Parse(txtAnio.Text)))
            {
                MessageBox.Show("El año es invalido!");
                return;
            }
            string sql = @"SELECT * FROM estadisticaGananciaAnual WHERE anio = " + txtAnio.Text + " OR anio IS NULL;";
            ayudante.cargarReporte(sql, "dsGananciaMensual", estadGananciasAnuales);
        }
    }
}
