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
using System.Text.RegularExpressions;

namespace LibreriaApollo.Interfaces
{
    public partial class frmProductos : Form
    {
        controladorProductos controlador = new controladorProductos();
        private Empleado empleadoLogeado;
        private int productoSeleccionado = -1;

        public frmProductos(Empleado empleado)
        {
            InitializeComponent();
            comboCategorias.Cargar();
            comboAgregarCategoria.Cargar();
            comboCategorias.SelectedIndex = -1;
            this.mostrarProductos();
            this.empleadoLogeado = empleado;

            if(this.empleadoLogeado.IdTipoPerfil == 3)
            {
                btnGuardarCambios.Visible = false;
                iconAgregar.Visible = false;
            }
        }

        private void btnDeseleccionarCategorias_Click(object sender, EventArgs e)
        {
            comboCategorias.SelectedIndex = -1;
        }

        private void mostrarProductos()
        {
            gridProductos.DataSource = controlador.mostrarTodosProductos(txtFiltrarNombre.Text, comboCategorias.SelectedIndex + 1);
        }

        private void onTxtFiltrarNombreChanged(object sender, EventArgs e)
        {
            this.mostrarProductos();
        }

        private void onComboCategoriasChanged(object sender, EventArgs e)
        {
            this.mostrarProductos();
        }

        private void btnDeseleccionarProducto_Click(object sender, EventArgs e)
        {
            gridProductos.ClearSelection();
            lblABM.Text = "Estas agregando un producto...";
            btnGuardarCambios.Text = "Agregar";
            this.limpiarCampos();
            btnEliminarProducto.Visible = false;
        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtStock.Text = "";
            txtPrecioUnitario.Text = "";
            txtStockMinimo.Text = "";
            comboAgregarCategoria.SelectedIndex = 0;
            this.productoSeleccionado = -1;
            errorProvider.Clear();
        }
        private void OnGridProductosClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = gridProductos.Rows[e.RowIndex];
            this.productoSeleccionado = Int32.Parse(filaSeleccionada.Cells[0].Value.ToString());
            txtNombre.Text = filaSeleccionada.Cells[1].Value.ToString();
            txtDescripcion.Text = filaSeleccionada.Cells[2].Value.ToString();
            txtStock.Text = filaSeleccionada.Cells[3].Value.ToString();
            txtPrecioUnitario.Text = filaSeleccionada.Cells[4].Value.ToString();
            txtStockMinimo.Text = filaSeleccionada.Cells[5].Value.ToString();
            comboAgregarCategoria.SelectedIndex = Int32.Parse(filaSeleccionada.Cells[6].Value.ToString()) - 1;
            btnGuardarCambios.Text = "Guardar";
            if (this.empleadoLogeado.IdTipoPerfil == 3)
            {
                lblABM.Text = "Estas consultado el producto " + txtNombre.Text;
            }
            else
            {
                lblABM.Text = "Estas modificando el producto " + txtNombre.Text;
                btnEliminarProducto.Visible = true;
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (!this.validarCampos())
            {
                return;
            }
            if (this.productoSeleccionado == -1)
            {
                // Crear
                bool resultado = controlador.agregarProducto(txtNombre.Text, txtDescripcion.Text, txtStock.Text, txtPrecioUnitario.Text, txtStockMinimo.Text, comboAgregarCategoria.SelectedIndex + 1);
                if(resultado)
                {
                    MessageBox.Show("Se ha guardado el producto " + txtNombre.Text);
                } else
                {
                    MessageBox.Show("Hubo un error creando el producto");
                }
            } else
            {
                //Modificar
                bool resultado = controlador.modificarProducto(this.productoSeleccionado, txtNombre.Text, txtDescripcion.Text, txtStock.Text, txtPrecioUnitario.Text, txtStockMinimo.Text, comboAgregarCategoria.SelectedIndex + 1);
                if (resultado)
                {
                    MessageBox.Show("Se ha modificado el producto " + txtNombre.Text);
                }
                else
                {
                    MessageBox.Show("Hubo un error modificando el producto");
                }
            }
            this.mostrarProductos();
            this.limpiarCampos();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Realmente desea eliminar el producto?", "Apollo", MessageBoxButtons.YesNo);
            if(confirmacion == DialogResult.Yes)
            {
                // Borrar
                bool resultado = controlador.borrarProducto(this.productoSeleccionado);
                if (resultado)
                {
                    MessageBox.Show("Se ha borrado el producto");
                    this.mostrarProductos();
                }
                else
                {
                    MessageBox.Show("No es posible borrar un producto ya vendido");
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
            if (!validarTextoNoVacio(txtDescripcion.Text))
            {
                errorProvider.SetError(txtDescripcion, "El campo descripcion no puede estar vacio");
                return false;
            }
            if (!validarTextoNoVacio(txtStock.Text))
            {
                errorProvider.SetError(txtStock, "El campo stock no puede estar vacio");
                return false;
            }
            if (!validarTextoNoVacio(txtPrecioUnitario.Text))
            {
                errorProvider.SetError(txtPrecioUnitario, "El campo precio unitario no puede estar vacio");

                return false;
            }
            if (!validarTextoNoVacio(txtStockMinimo.Text))
            {
                errorProvider.SetError(txtStockMinimo, "El campo stock minimo no puede estar vacio");
                return false;
            }
            
            Regex regex = new Regex(@"^[0-9]{1,6}(,[0-9]{1,2}){0,1}$");
            
            if (!regex.IsMatch(txtPrecioUnitario.Text)|| !validarTextoNoVacio (txtPrecioUnitario.Text))
            {
                errorProvider.SetError(txtPrecioUnitario, "El campo precio unitario no puede estar vacio");
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
