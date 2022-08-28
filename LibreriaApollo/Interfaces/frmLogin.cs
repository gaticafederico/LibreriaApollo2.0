using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaApollo.Controladores;
using LibreriaApollo.Entidades;

namespace LibreriaApollo
{
    public partial class frmLogin : Form
    {
        controladorEmpleados controlador = new controladorEmpleados();
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.logear();
        }

        private void logear()
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Ingresa un usuario");
                txtUsername.Focus();
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Ingresa una contraseña");
                txtPassword.Focus();
            }
            Empleado empleado = controlador.validarEmpleado(txtUsername.Text, txtPassword.Text);
            if (empleado.IDEmpleado > -1)
            {
                frmMain principal = new frmMain(empleado);
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario/contraseña invalido");
            }
        }
    }
}
