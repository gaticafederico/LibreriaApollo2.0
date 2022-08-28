using LibreriaApollo.Controladores;
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
    public partial class frmMayoristas : Form
    {
        controladorMayoristas controlador = new controladorMayoristas();

        int mayoristaSeleccionadoID = -1;

        public frmMayoristas()
        {
            InitializeComponent();
        }

        private void onFrmLoad(object sender, EventArgs e)
        {
            this.mostrarClientes();
            comboDocumento.Cargar();
            btnEliminarProducto.Visible = false;
        }

        private void mostrarClientes()
        {
            gridMayoristas.DataSource = controlador.mostrarTodosClientes(txtFiltrarNombre.Text, txtFiltrarNroDocumento.Text);
        }

        private void onTxtFiltrarNombreChanged(object sender, EventArgs e)
        {
            this.mostrarClientes();
        }

        private void onTxtFiltrarNroDocumentoChanged(object sender, EventArgs e)
        {
            this.mostrarClientes();
        }

        private void btnDeseleccionar_Click(object sender, EventArgs e)
        {
            this.limpiarCampos();
            btnEliminarProducto.Visible = false;
        }

        private void onGridMayoristasClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = gridMayoristas.Rows[e.RowIndex];
            txtNombre.Text = filaSeleccionada.Cells[1].Value.ToString();
            txtApellido.Text = filaSeleccionada.Cells[2].Value.ToString();
            txtCalle.Text = filaSeleccionada.Cells[3].Value.ToString();
            txtNroCalle.Text = filaSeleccionada.Cells[4].Value.ToString();
            txtCodPostal.Text = filaSeleccionada.Cells[5].Value.ToString();
            comboDocumento.SelectedIndex = Int32.Parse(filaSeleccionada.Cells[10].Value.ToString()) - 1;
            txtNroDocumento.Text = filaSeleccionada.Cells[7].Value.ToString();
            txtEmail.Text = filaSeleccionada.Cells[8].Value.ToString();
            txtTelefono.Text = filaSeleccionada.Cells[9].Value.ToString();
            lblABM.Text = "Estas editando el cliente " + txtNombre.Text;
            btnGuardarCambios.Text = "Guardar";
            mayoristaSeleccionadoID = Int32.Parse(filaSeleccionada.Cells[0].Value.ToString());
            btnEliminarProducto.Visible = true;
        }

        private bool validarCamposNoVacios()
        {
            if(txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0 || txtCalle.Text.Length == 0 || txtNroCalle.Text.Length == 0 || txtCodPostal.Text.Length == 0 || comboDocumento.SelectedIndex == -1 || txtNroDocumento.Text.Length == 0 || txtEmail.Text.Length == 0 || txtTelefono.Text.Length == 0 )
            {
                return false;
            }
            return true;
        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCalle.Text = "";
            txtNroCalle.Text = "";
            txtCodPostal.Text = "";
            comboDocumento.SelectedIndex = 0;
            txtNroDocumento.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            btnGuardarCambios.Text = "Crear";
            lblABM.Text = "Estas creando un nuevo cliente mayorista...";
            gridMayoristas.ClearSelection();
            this.mayoristaSeleccionadoID = -1;
            errorProvider.Clear();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (!this.validarCampos())
            {
                return;
            }
            if (mayoristaSeleccionadoID == -1)
            {
                // Crear
                if (this.validarCamposNoVacios() == false)
                {
                    MessageBox.Show("Debe ingresar todos los valores");
                }
                else
                {
                    bool existeMayorista = controlador.buscarMayorista(txtNombre.Text);
                    if (!existeMayorista)
                    {
                        bool tuvoExito = controlador.crearMayorista(txtNombre.Text, txtApellido.Text, txtCalle.Text, txtNroCalle.Text, txtCodPostal.Text, comboDocumento.SelectedIndex + 1, txtNroDocumento.Text, txtEmail.Text, txtTelefono.Text);
                        this.mostrarClientes();
                        if (tuvoExito)
                        {
                            MessageBox.Show("Se ha creado el cliente mayorista " + txtNombre.Text);
                            this.limpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe el cliente mayorista " + txtNombre.Text);
                    }
                }
            }
            else
            {
                // Modificar
                bool tuvoExito = controlador.modificarMayorista(mayoristaSeleccionadoID, txtNombre.Text, txtApellido.Text, txtCalle.Text, txtNroCalle.Text, txtCodPostal.Text, comboDocumento.SelectedIndex + 1, txtNroDocumento.Text, txtEmail.Text, txtTelefono.Text);
                this.mostrarClientes();
                if (tuvoExito)
                {
                    MessageBox.Show("Se ha modificado el cliente mayorista " + txtNombre.Text);
                    this.limpiarCampos();
                    
                }
                else
                {
                    MessageBox.Show("Hubo un error");
                }
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Realmente desea eliminar el cliente mayorista?", "Apollo", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                // Borrar
                bool resultado = controlador.borrarMayorista(mayoristaSeleccionadoID);
                if (resultado)
                {
                    MessageBox.Show("Se ha borrado el cliente mayorista");
                    this.mostrarClientes();
                }
                else
                {
                    MessageBox.Show("Hubo un error borrando el cliente mayorista");
                }
            }
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
            if (!validarTextoNoVacio(txtCalle.Text))
            {
                errorProvider.SetError(txtCalle, "El campo calle no puede estar vacio");
                return false;
            }
            if (!validarTextoNoVacio(txtNroCalle.Text))
            {
                errorProvider.SetError(txtNroCalle, "El campo numero de calle no puede estar vacio");
                return false;
            }
            if (!validarTextoNoVacio(txtCodPostal.Text))
            {
                errorProvider.SetError(txtCodPostal, "El campo codigo postal no puede estar vacio");
                return false;
            }
            if (!validarTextoNoVacio(txtNroDocumento.Text))
            {
                errorProvider.SetError(txtNroDocumento, "El campo numero de documento no puede estar vacio");
                return false;
            }
            if (!validarTextoNoVacio(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "El campo email no puede estar vacio");
                return false;
            }
            if (!validarTextoNoVacio(txtTelefono.Text))
            {
                errorProvider.SetError(txtTelefono, "El campo telefono no puede estar vacio");
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
