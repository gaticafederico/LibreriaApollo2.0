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
using LibreriaApollo.Helpers;

namespace LibreriaApollo.Interfaces
{
    public partial class frmEmpleado : Form
    {
        helpers ayudante = new helpers();
        controladorEmpleados controlador = new controladorEmpleados();

        int usuarioSeleccionadoID = -1;
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void onFrmLoad(object sender, EventArgs e)
        {
            this.mostrarEmpleados();
            comboPerfiles.Cargar();
        }

        private void onGridEmpleadosClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = gridEmpleados.Rows[e.RowIndex];
            usuarioSeleccionadoID = Int32.Parse(filaSeleccionada.Cells[0].Value.ToString());
            txtUsuario.Text = filaSeleccionada.Cells[1].Value.ToString();
            txtNombre.Text = filaSeleccionada.Cells[2].Value.ToString();
            txtApellido.Text = filaSeleccionada.Cells[3].Value.ToString();
            txtFechaNac.Text = this.traerFechaConFormato(filaSeleccionada.Cells[4].Value.ToString());
            txtFechaIng.Text = this.traerFechaConFormato(filaSeleccionada.Cells[5].Value.ToString());
            comboPerfiles.SelectedIndex = Int32.Parse(filaSeleccionada.Cells[7].Value.ToString()) - 1;
            if (this.stringToBool(filaSeleccionada.Cells[6].Value.ToString()))
            {
                radioGuardarActivo.Checked = true;
            }
            else
            {
                radioGuardarInactivo.Checked = true;
            }
            lblABM.Text = "Estas editando el usuario: " + txtUsuario.Text;
            btnGuardarCambios.Text = "Guardar";
        }

        private bool stringToBool(string cadena)
        {
            return cadena == "True";
        }
        private string insertarFechaConFormato(string fecha)
        {
            return ayudante.insertarFechaConFormato(fecha);
        }

        private string traerFechaConFormato(string fecha)
        {
            return ayudante.traerFechaConFormato(fecha);
        }

        private void OnTxtFiltarNombre(object sender, EventArgs e)
        {
            this.mostrarEmpleados();
        }

        private void onRadioEstadoChanged(object sender, EventArgs e)
        {
            this.mostrarEmpleados();
        }

        private void onRadioActivoChanged(object sender, EventArgs e)
        {
            this.mostrarEmpleados();
        }
        private void onRadioInactivoChanged(object sender, EventArgs e)
        {
            this.mostrarEmpleados();
        }
        private void mostrarEmpleados()
        {
            string filtro = "";
            if (radioTodos.Checked == true)
            {
                filtro = "Todos";
            }
            else if (radioActivos.Checked == true)
            {
                filtro = "Activos";
            }
            else if (radioInactivos.Checked == true)
            {
                filtro = "Inactivos";
            }
            gridEmpleados.DataSource = controlador.mostrarTodosEmpleados(txtFiltrarUsuario.Text, filtro);
        }

        private void onGuardarCambios(object sender, EventArgs e)
        {
            if (!this.validarCampos())
            {
                return;
            }
            if (usuarioSeleccionadoID == -1)
            {
                // Crear
                if (txtPassword.Text.Length == 0 || txtPassword.Text != txtConfirmar.Text)
                {
                    MessageBox.Show("Debes ingresar una contraseña / Las contraseñas no coinciden");
                }
                else
                {
                    if (this.validarCamposNoVacios() == false)
                    {
                        MessageBox.Show("Debe ingresar todos los valores");
                    }
                    else
                    {
                        bool existeEmpleado = controlador.buscarEmpleado(txtUsuario.Text);
                        if (!existeEmpleado)
                        {
                            bool tuvoExito = controlador.crearEmpleado(txtUsuario.Text, txtPassword.Text, txtNombre.Text, txtApellido.Text, this.insertarFechaConFormato(txtFechaNac.Text), this.insertarFechaConFormato(txtFechaIng.Text), radioGuardarActivo.Checked, comboPerfiles.SelectedIndex + 1);
                            this.mostrarEmpleados();
                            if (tuvoExito)
                            {
                                MessageBox.Show("Se ha creado el usuario " + txtUsuario.Text);
                                this.limpiarCampos();
                            }
                            else
                            {
                                MessageBox.Show("Hubo un error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ya existe el usuario " + txtUsuario.Text);
                        }
                    }
                }
            } else
            {
                if (txtPassword.Text.Length == 0 && txtConfirmar.Text.Length == 0)
                {
                    // Modificar sin cambiar la contraseña
                    bool tuvoExito = controlador.modificarSinCambiar(usuarioSeleccionadoID, txtUsuario.Text, txtNombre.Text, txtApellido.Text, txtFechaNac.Text, txtFechaIng.Text, radioGuardarActivo.Checked, comboPerfiles.SelectedIndex + 1);
                    this.mostrarEmpleados();
                    if (tuvoExito)
                    {
                        MessageBox.Show("Se ha modificado el usuario " + txtUsuario.Text);
                        this.limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error");
                    }
                } else
                {
                    // Modificar cambiando la contraseña
                    if (txtPassword.Text == txtConfirmar.Text)
                    {
                        bool tuvoExito = controlador.modificarConCambiar(usuarioSeleccionadoID, txtUsuario.Text, txtPassword.Text, txtNombre.Text, txtApellido.Text, txtFechaNac.Text, txtFechaIng.Text, radioGuardarActivo.Checked, comboPerfiles.SelectedIndex + 1);
                        this.mostrarEmpleados();
                        if (tuvoExito)
                        {
                            MessageBox.Show("Se ha modificado el usuario " + txtUsuario.Text);
                            this.limpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas deben ser iguales");
                    }
                }
            }
        }

        private void onDeseleccionar(object sender, EventArgs e)
        {
            usuarioSeleccionadoID = -1;
            gridEmpleados.ClearSelection();
            this.limpiarCampos();
        }

        private bool validarCamposNoVacios()
        {
            if (txtUsuario.Text.Length == 0 || txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0 || txtFechaNac.Text.Length == 0 || txtFechaIng.Text.Length == 0)
            {

                return false;
            }
            return true;
        }
        private void limpiarCampos()
        {
            lblABM.Text = "Estas creando un nuevo usuario...";
            btnGuardarCambios.Text = "Crear";
            txtUsuario.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtFechaNac.Text = "";
            txtFechaIng.Text = "";
            txtPassword.Text = "";
            txtConfirmar.Text = "";
            radioGuardarActivo.Checked = true;
            radioGuardarInactivo.Checked = false;
            errorProvider.Clear();
        }

        private bool validarCampos()
        {
            if (!validarTextoNoVacio(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El campo nombre no puede estar vacio");
                return false;
            }
            if (!validarTextoNoVacio(txtApellido.Text))
            {
                errorProvider.SetError(txtApellido, "El campo apellido no puede estar vacio");
                return false;
            }
            if (!validarTextoNoVacio(txtUsuario.Text))
            {
                errorProvider.SetError(txtUsuario, "El campo usuario no puede estar vacio");
                return false;
            }
            if (!validarTextoNoVacio(txtFechaNac.Text))
            {
                errorProvider.SetError(txtFechaNac, "El campo fecha de nacimiento no puede estar vacio");
                return false;
            }
            if (!validarTextoNoVacio(txtFechaIng.Text))
            {
                errorProvider.SetError(txtFechaIng, "El campo fecha de ingreso no puede estar vacio");
                return false;
            }
            return true;
        }

        private bool validarTextoNoVacio(string texto)
        {
            if (texto.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}