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
    public partial class frmOpciones : Form
    {
        private int codigoPostalSeleccionado = -1;
        private int tipoPagoSeleccionado = -1;
        private int catProductoSeleccionado = -1;
        private string nombreLocalidadSeleccionado = "";
        private string nombreTipoPagoSeleccionado = "";
        private string nombreCatProductoSeleccionado = "";
        private string descripcionCatProductoSeleccionado = "";
       
        public frmOpciones()
        {
            InitializeComponent();
        }
        private void actualizarLocalidades()
        {
            dataLocalidades.DataSource = new controladorLocalidades().buscarLocalidades();
        }

        private void actualizarTipoPago()
        {
            dataTiposPago.DataSource = new controladorTiposPagos().buscarTiposPagos();
        }

        private void actualizarTipoDocumento()
        {
            dataTipoDocumento.DataSource = new controladorTiposDocumento().buscarTiposDocumento();
        }

        private void actualizarCategoriaProducto()
        {
            dataCatProducto.DataSource = new controladorCategoriasProducto().buscarCategoriasProducto();
        }

        private void onFrmOpcionesLoad(object sender, EventArgs e)
        {
            actualizarLocalidades();
            actualizarTipoPago();
            actualizarTipoDocumento();
            actualizarCategoriaProducto();
        }

        private void deseleccionarLocalidades(object sender, EventArgs e)
        {
            dataLocalidades.ClearSelection();
            lblLocalidades.Text = "Estas agregando una localidad...";
            btnAgregarLocalidad.Text = "Agregar";
            txtLocalidadCodPostal.Text = "";
            txtLocalidadNombre.Text = "";
            codigoPostalSeleccionado = -1;
            nombreLocalidadSeleccionado = "";
        }

        private void onGridLocalidadesClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            string indiceCodPostal = dataLocalidades.Rows[indice].Cells[0].Value.ToString();
            string indiceLocalidad = dataLocalidades.Rows[indice].Cells[1].Value.ToString();

            lblLocalidades.Text = $"Estas editando la localidad {indiceLocalidad}";
            btnAgregarLocalidad.Text = "Modificar";
            txtLocalidadCodPostal.Text = indiceCodPostal;
            txtLocalidadNombre.Text = indiceLocalidad;

            codigoPostalSeleccionado = Int32.Parse(indiceCodPostal);
            nombreLocalidadSeleccionado = indiceLocalidad;
        }
        private void onGridTiposPagoClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            
            string indiceIDTipoPago = dataTiposPago.Rows[indice].Cells[0].Value.ToString();
            string indiceNombreTipoPago = dataTiposPago.Rows[indice].Cells[1].Value.ToString();

            lblTipoPago.Text = $"Estas modificando el tipo de pago {indiceNombreTipoPago}";
            btnAgregarTipoPago.Text = "Modificar";
            txtTipoPagoNombre.Text = indiceNombreTipoPago;

            tipoPagoSeleccionado = Int32.Parse(indiceIDTipoPago);
            nombreTipoPagoSeleccionado = indiceNombreTipoPago;
        }

        private void onGridCatProductoClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            string indiceIDCatProducto = dataCatProducto.Rows[indice].Cells[0].Value.ToString();
            string indiceNombreCatProducto = dataCatProducto.Rows[indice].Cells[1].Value.ToString();
            string indiceNombreDescProducto = dataCatProducto.Rows[indice].Cells[2].Value.ToString();

            lblCatProducto.Text = $"Estas modificando la categoria {indiceNombreCatProducto}";
            btnAgregarCatProducto.Text = "Modificar";
            txtCatProductoNombre.Text = indiceNombreCatProducto;
            txtCatProductoDesc.Text = indiceNombreDescProducto;

            catProductoSeleccionado = Int32.Parse(indiceIDCatProducto);
            nombreCatProductoSeleccionado = indiceNombreCatProducto;
            descripcionCatProductoSeleccionado = indiceNombreDescProducto;
        }

        private void agregarLocalidad(object sender, EventArgs e)
        {
            controladorLocalidades controlador = new controladorLocalidades();
            if(codigoPostalSeleccionado == -1)
            {
                //Agregar Localidad
                if(txtLocalidadCodPostal.Text == "" || txtLocalidadNombre.Text == "")
                {
                    MessageBox.Show("El codigo postal o el nombre es invalido");
                    return;
                }
                bool resultado = controlador.agregarLocalidad(txtLocalidadCodPostal.Text, txtLocalidadNombre.Text);
                if(!resultado)
                {
                    MessageBox.Show("Hubo un error agregando la localidad");
                    return;
                }
                MessageBox.Show($"La localidad {txtLocalidadNombre.Text} se ha agregado exitosamente", "Localidad Agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                //Modificar Localidad
                if(txtLocalidadCodPostal.Text == codigoPostalSeleccionado.ToString() && txtLocalidadNombre.Text == nombreLocalidadSeleccionado)
                {
                    MessageBox.Show("No hubo cambios, por lo tanto no se modifico ninguna localidad");
                    return;
                }
                bool resultado = controlador.modificarLocalidad(codigoPostalSeleccionado.ToString(), txtLocalidadCodPostal.Text, txtLocalidadNombre.Text);
                if(!resultado)
                {
                    MessageBox.Show("Hubo un error modificando la localidad");
                    return;
                }
                MessageBox.Show("La localidad se ha modificado exitosamente", "Localidad Modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            actualizarLocalidades();
            deseleccionarLocalidades(null, null);
        }

        private void deseleccionarTipoPago(object sender, EventArgs e)
        {
            dataTiposPago.ClearSelection();
            lblTipoPago.Text = "Estas agregando un tipo de pago...";
            btnAgregarTipoPago.Text = "Agregar";
            txtTipoPagoNombre.Text = "";
            tipoPagoSeleccionado = -1;
            nombreTipoPagoSeleccionado = "";
        }

        private void deseleccionarCatProducto(object sender, EventArgs e)
        {
            dataCatProducto.ClearSelection();
            lblCatProducto.Text = "Estas agregando una categoria de producto...";
            btnAgregarCatProducto.Text = "Agregar";
            txtCatProductoNombre.Text = "";
            txtCatProductoDesc.Text = "";
            catProductoSeleccionado = -1;
            nombreCatProductoSeleccionado = "";
            descripcionCatProductoSeleccionado = "";
        }

        private void agregarTipoPago(object sender, EventArgs e)
        {
            controladorTiposPagos controlador = new controladorTiposPagos();
            if(tipoPagoSeleccionado == -1)
            {
                //Agregar Tipo Pago
                if(txtTipoPagoNombre.Text == "")
                {
                    MessageBox.Show("El nombre del tipo de pago es invalido");
                    return;
                }
                bool resultado = controlador.agregarTipoPago(txtTipoPagoNombre.Text);
                if (!resultado)
                {
                    MessageBox.Show("Hubo un error agregando el tipo de pago");
                    return;
                }
                MessageBox.Show($"El tipo de pago {txtTipoPagoNombre.Text} se ha agregado exitosamente", "Tipo de pago agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                //Modificar Tipo Pago
                if(txtTipoPagoNombre.Text == nombreTipoPagoSeleccionado)
                {
                    MessageBox.Show("No hubo cambios, por lo tanto no se modifico ninguna localidad");
                    return;
                }
                bool resultado = controlador.modificarTipoPago(tipoPagoSeleccionado.ToString(), txtTipoPagoNombre.Text);
                if (!resultado)
                {
                    MessageBox.Show("Hubo un error modificando el tipo de pago");
                    return;
                }
                MessageBox.Show($"El tipo de pago {txtTipoPagoNombre.Text} se ha modificado exitosamente", "Tipo de pago modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            actualizarTipoPago();
            deseleccionarTipoPago(null, null);
        }

        private void agregarCatProducto(object sender, EventArgs e)
        {
            controladorCategoriasProducto controlador = new controladorCategoriasProducto();
            if(catProductoSeleccionado == -1)
            {
                //Agregar categoria de producto
                if(txtCatProductoNombre.Text == "" || txtCatProductoDesc.Text == "")
                {
                    MessageBox.Show("El nombre de la categoria de producto o la descripcion es invalida");
                    return;
                }
                bool resultado = controlador.agregarCategoriaProducto(txtCatProductoNombre.Text, txtCatProductoDesc.Text);
                if(!resultado)
                {
                    MessageBox.Show("Hubo un error agregando la categoria de producto");
                }
                MessageBox.Show($"La categoria de producto {txtCatProductoNombre.Text} se ha agregado exitosamente", "Categoria de producto agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                //Modificar categoria de producto
                if(txtCatProductoNombre.Text == nombreCatProductoSeleccionado && txtCatProductoDesc.Text == descripcionCatProductoSeleccionado)
                {
                    MessageBox.Show("No hubo cambios, por lo tanto no se modifico ninguna categoria");
                    return;
                }
                bool resultado = controlador.modificarCategoriaProducto(catProductoSeleccionado.ToString(), txtCatProductoNombre.Text, txtCatProductoDesc.Text);
                if(!resultado)
                {
                    MessageBox.Show("Hubo un error modificando el tipo de pago");
                    return;
                }
                MessageBox.Show($"La categoria de producto {txtCatProductoNombre.Text} se ha modificado exitosamente", "Categoria de producto modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            actualizarCategoriaProducto();
            deseleccionarCatProducto(null, null);
        }

        
    }
}
