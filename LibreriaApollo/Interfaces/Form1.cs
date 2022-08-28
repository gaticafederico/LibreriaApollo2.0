using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaApollo.Interfaces;
using LibreriaApollo.Entidades;
using LibreriaApollo.Controladores;

namespace LibreriaApollo
{
    public partial class frmMain : Form
    {
        private Empleado empleadoLogeado;
  
        public frmMain(Empleado empleado)
        {
            controladorPrincipal controlador = new controladorPrincipal();

            this.empleadoLogeado = empleado;
            InitializeComponent();
            this.setGreetings(empleado.Nombre);
            this.setTipoPerfil(empleado.IdTipoPerfil);
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblVentas.Text = controlador.contarVentas();
            lblClientes.Text = controlador.contarClientesMayoristas();
            lblEmpleados.Text = controlador.contarEmpleados();
            lblProductos.Text = controlador.contarProductos();
        }

        private void onBtnExit(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Desea cerrar Apollo?", "Apollo", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void setGreetings(string username)
        {
            this.lblWelcome.Text = "Bienvenido, " + username;
        }

        public void setTipoPerfil(int tipoPerfil)
        {
            if(tipoPerfil != 1)
            {
                btnAbrirEmpleados.Visible = false;
                iconoEmpleado.Visible = false;
                btnInformes.Visible = false;
                iconoEstadisticas.Visible = false;
                iconoInformes.Visible = false;
                btnOpciones.Visible = false;
                iconoOpciones.Visible = false;
                btnMayoristas.Visible = false;
                iconoMayorista.Visible = false;
                btnEstadisticas.Visible = false;
            }
        }

        private void abrirVentas(object sender, EventArgs e)
        {
            new frmVentas(this.empleadoLogeado).ShowDialog();
        }

        private void abrirEmpleados(object sender, EventArgs e)
        {
            new frmEmpleado().ShowDialog();
        }

        private void abrirProductos(object sender, EventArgs e)
        {
            new frmProductos(this.empleadoLogeado).ShowDialog();
        }

        private void btnMayoristas_Click(object sender, EventArgs e)
        {
            new frmMayoristas().ShowDialog();
        }

        private void abrirInformes(object sender, EventArgs e)
        {
            new frmInformes().ShowDialog();
        }

        private void abrirEstadisticas(object sender, EventArgs e)
        {
            new frmEstadisticas().ShowDialog();
        }

        private void abrirOpciones(object sender, EventArgs e)
        {
            new frmOpciones().ShowDialog();
        }
    }
}
