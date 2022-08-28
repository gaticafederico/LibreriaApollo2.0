using LibreriaApollo.Controladores;
using LibreriaApollo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaApollo.Interfaces
{
    public partial class frmRegistrarVenta : Form
    {
        controladorProductos controlador = new controladorProductos();
        controladorMayoristas controladorMayoristas = new controladorMayoristas();

        private int productoSeleccionado = -1;
        private int productoCarritoSeleccionado = -1;
        private float productoPrecio = 0;
        private string productoNombre = "";
        private int stockProductoSeleccionado = 0;
        private int indiceSeleccionado = -1;
        private int indiceCarritoSeleccionado = -1;
        private string nroCliente = "-1";
        private Empleado empleadologueado;

        public frmRegistrarVenta(Empleado empleado)
        {

            InitializeComponent();
            comboCategorias.Cargar();
            comboTipoDocumento.Cargar();
            this.comboCategorias.SelectedIndex = -1;
            this.comboTipoDocumento.SelectedIndex = 0;
            this.empleadologueado = empleado;
        }

        private void onFrmLoad(object sender, EventArgs e)
        {
            this.mostrarProductos();
            cmbTipoPago.Cargar();
        }

        private void mostrarProductos()
        {
            gridProductos.DataSource = controlador.mostrarTodosProductos(txtNombreProducto.Text, comboCategorias.SelectedIndex + 1);
        }

        private void OnTxtNombreProductoChanged(object sender, EventArgs e)
        {
            this.mostrarProductos();
        }

        private void onComboCategoriasChanged(object sender, EventArgs e)
        {
            this.mostrarProductos();
        }

        private void OnGridProductosClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = gridProductos.Rows[e.RowIndex];
            productoSeleccionado = Int32.Parse(filaSeleccionada.Cells[0].Value.ToString());
            productoNombre = filaSeleccionada.Cells[1].Value.ToString();
            productoPrecio = float.Parse(filaSeleccionada.Cells[4].Value.ToString());
            txtCantidad.Enabled = true;
            btnAgregarProducto.Enabled = true;
            stockProductoSeleccionado = Int32.Parse(filaSeleccionada.Cells[3].Value.ToString());
            indiceSeleccionado = e.RowIndex;
            txtCantidad.Focus();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Length == 0 || txtCantidad.Text == "0")
            {
                MessageBox.Show("Debe ingresar cantidad.");
                return;
            }
            if (Int32.Parse(txtCantidad.Text) > stockProductoSeleccionado)
            {
               
                DialogResult confirmacion = MessageBox.Show("Cantidad de stock insuficiente. \n Desea ingresar " + stockProductoSeleccionado + "?", "Apollo", MessageBoxButtons.YesNo);
                if (confirmacion == DialogResult.Yes)
                {
                    txtCantidad.Text = stockProductoSeleccionado.ToString();
                }
                else
                {
                    return;
                }
               
            }
            //bool enCarrito = false;
            //foreach (DataGridViewRow fila in gridCarritos.Rows)
            //{
             //   if (fila.Cells[1].Value.ToString() == productoNombre)
               // {
                 //   enCarrito = true;
                   // fila.Cells[2].Value = Int32.Parse(fila.Cells[2].Value.ToString()) + Int32.Parse(txtCantidad.Text);
                    //fila.Cells[4].Value = Int32.Parse(fila.Cells[4].Value.ToString()) + Int32.Parse(txtCantidad.Text);
                //}
            //}
            DataGridViewRow filaAgregar = new DataGridViewRow();
            DataGridViewTextBoxCell nombre = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell idProducto = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell cantidad = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell subTotal = new DataGridViewTextBoxCell();

            gridProductos.Rows[indiceSeleccionado].Cells[3].Value = (stockProductoSeleccionado - Int32.Parse(txtCantidad.Text)).ToString();
            stockProductoSeleccionado -= Int32.Parse(txtCantidad.Text);
            nombre.Value = productoNombre;
            idProducto.Value = productoSeleccionado;
            cantidad.Value = Int32.Parse(txtCantidad.Text.ToString());
            subTotal.Value = productoPrecio * float.Parse(txtCantidad.Text.ToString());

            filaAgregar.Cells.Add(idProducto);
            filaAgregar.Cells.Add(nombre);
            filaAgregar.Cells.Add(cantidad);
            filaAgregar.Cells.Add(subTotal);

            gridCarritos.Rows.Add(filaAgregar);

            this.actualizarTotal();
            habilitarBotonRegistrarVenta();
        }

        private void actualizarTotal()
        {
            float sumaTotal = 0;
            foreach (DataGridViewRow detalleProducto in gridCarritos.Rows)
            {
                sumaTotal += float.Parse(detalleProducto.Cells[3].Value.ToString());
            }
            lblTotal.Text =  sumaTotal.ToString();
        }

        private void btnEliminarProductoCarrito_Click(object sender, EventArgs e)
        {
           if(this.productoCarritoSeleccionado != -1)
            {
                int cantidadAgregar = Int32.Parse(gridCarritos.Rows[indiceCarritoSeleccionado].Cells[2].Value.ToString());
                string nombreProductoSeleccionado = gridCarritos.Rows[indiceCarritoSeleccionado].Cells[1].Value.ToString();
                foreach (DataGridViewRow fila in gridProductos.Rows)
                {
                    if (fila.Cells[1].Value.ToString() == nombreProductoSeleccionado)
                    {
                        fila.Cells[3].Value = Int32.Parse(fila.Cells[3].Value.ToString()) + cantidadAgregar;
                        
                    }
                }
                gridCarritos.Rows.RemoveAt(this.productoCarritoSeleccionado);
                this.productoCarritoSeleccionado = -1;
                btnEliminarProductoCarrito.Enabled = false;
                this.actualizarTotal();
                
            }
            habilitarBotonRegistrarVenta();
        }

        private void OnGridCarritosClick(object sender, DataGridViewCellEventArgs e)
        {
            this.productoCarritoSeleccionado = e.RowIndex;
            btnEliminarProductoCarrito.Enabled = true;
            indiceCarritoSeleccionado = e.RowIndex;
        }

        private void BuscarClienteMayorista()
        {
            if(txtDocumento.Text != "")
            {
                DataTable resultados = controladorMayoristas.buscarMayorista((comboTipoDocumento.SelectedIndex + 1).ToString(), txtDocumento.Text);
                if (resultados.Rows.Count > 0)
                {
                    DataRow primerClienteFiltrado = resultados.Rows[0];
                    lblClienteMayorista.Text = primerClienteFiltrado[0].ToString();
                    this.nroCliente = primerClienteFiltrado[1].ToString();
                } else
                {
                    lblClienteMayorista.Text = "";
                }
            }
        }

        private void OnTxtDocumentoChanged(object sender, EventArgs e)
        {
            this.BuscarClienteMayorista();
        }

        private void OnComboSelectedIndexChanged(object sender, EventArgs e)
        {
            this.BuscarClienteMayorista();
        }

        private void onClickRegistrarVenta(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea registrar la venta?", "Apollo", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                DetalleVenta[] detalles = new DetalleVenta[gridCarritos.Rows.Count];
                int indice = 0;
                foreach ( DataGridViewRow fila in gridCarritos.Rows)
                {
                    int idProducto = Int32.Parse(fila.Cells[0].Value.ToString());
                    int cantidad = Int32.Parse(fila.Cells[2].Value.ToString());
                    float precio = float.Parse(fila.Cells[3].Value.ToString());
                    DetalleVenta detalle = new DetalleVenta(idProducto, cantidad, precio);
                    detalles[indice] = detalle;
                    indice++;
                }
                controladorRegistrarVenta controlador = new controladorRegistrarVenta();
                controlador.registrarVenta(nroCliente.ToString(),(lblTotal.Text), empleadologueado.getIdEmpleado().ToString(), (cmbTipoPago.SelectedIndex + 1).ToString(), detalles);
            
                limpiarCampos();
                MessageBox.Show("Se ha registrado la venta con exito.");
            }
            
        }

        private void habilitarBotonRegistrarVenta()
        {
            if (gridCarritos.Rows.Count == 0)
            {
                btnRegistrar.Enabled = false;
                return;
            }
            else
            {
                btnRegistrar.Enabled = true;
                return;
            }
        }

        private void limpiarCampos()
        {
            gridCarritos.Rows.Clear();
            habilitarBotonRegistrarVenta();
            lblTotal.Text = "0";
            nroCliente = "-1";
            txtDocumento.Text = "";
            txtNombreProducto.Text = "";
            txtCantidad.Text = "1";
            comboCategorias.SelectedIndex = -1;
            cmbTipoPago.SelectedIndex = 0;
            comboTipoDocumento.SelectedIndex = 0;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
