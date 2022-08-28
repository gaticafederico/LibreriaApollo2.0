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
    public partial class estadisticaVentasPorEmpleado : Form
    {
        List<string> empleados = new List<string>();

        public estadisticaVentasPorEmpleado()
        {
            InitializeComponent();
            cmbEmpleados.Cargar();
            lblEmpleados.Text = "";
        }

        private void estadisticaVentasPorEmpleado_Load(object sender, EventArgs e)
        {
            this.estadVentasPorEmpleado.RefreshReport();
        }

        private void agregarEmpleado(object sender, EventArgs e)
        {
            if(empleados.Exists(nombreUsuario => nombreUsuario == cmbEmpleados.GetItemText(cmbEmpleados.SelectedItem)))
            {
                MessageBox.Show("Estas intentando agregar un empleado existente");
                return;
            }
            empleados.Add(cmbEmpleados.GetItemText(cmbEmpleados.SelectedItem));
            lblEmpleados.Text += cmbEmpleados.GetItemText(cmbEmpleados.SelectedItem) + ", ";
        }

        private void limpiarCampos(object sender, EventArgs e)
        {
            empleados.Clear();
            lblEmpleados.Text = "";
            txtAnio.Text = "";
            txtMes.Text = "";
            estadVentasPorEmpleado.Reset();
        }

        private void consultar(object sender, EventArgs e)
        {
            if(empleados.Count == 0)
            {
                MessageBox.Show("Debes agregar empleados!");
                return;
            }

            string listaEmpleados = "";
            for (int i = 0; i<empleados.Count; i++)
            {
                if(i == empleados.Count - 1)
                {
                    listaEmpleados += "'" + empleados[i] + "'";
                } else
                {
                    listaEmpleados += "'" + empleados[i] + "',";
                }
            }

            helpers ayudante = new helpers();
            string sql = @"SELECT e.idEmpleado, e.usuario FROM empleados e JOIN ventas v ON v.idEmpleado = e.idEmpleado
            WHERE e.nombre IN(" + listaEmpleados + ")";

            if (txtMes.Text.Length == 0 && txtAnio.Text.Length == 0)
            {
                sql += " AND MONTH(v.fechaHora) = " + DateTime.Now.Month.ToString() + " AND YEAR(v.fechaHora) = " + DateTime.Now.Year.ToString() + ";";
            } 
            else if(txtMes.Text.Length > 0 && txtAnio.Text.Length == 0)
            {
                MessageBox.Show("Debes introducir un año");
                return;
            }
            else if(txtMes.Text.Length == 0 && txtAnio.Text.Length > 0)
            {
                if(!ayudante.esAnioValido(Int32.Parse(txtAnio.Text)))
                {
                    MessageBox.Show("El año o el mes son invalidos");
                    return;
                }
                sql += "AND YEAR(v.fechaHora) = " + txtAnio.Text + ";";
            }
            else
            {
                if(!ayudante.esAnioValido(Int32.Parse(txtAnio.Text)) || !ayudante.esMesValido(Int32.Parse(txtMes.Text)))
                {
                    MessageBox.Show("El año o el mes son invalidos");
                    return;
                }
                sql += " AND MONTH(v.fechaHora) = " + txtMes.Text + " AND YEAR(v.fechaHora) = " + txtAnio.Text + ";";
            }
            ayudante.cargarReporte(sql, "DataSet1", estadVentasPorEmpleado);
        }
    }
}
