namespace LibreriaApollo.Interfaces
{
    partial class frmDetalleVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gridDetalleVentas = new System.Windows.Forms.DataGridView();
            this.idDetalleVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblNomApeCliente = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.lblNomApeEmpleado = new System.Windows.Forms.Label();
            this.lblTipoPago = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LibreriaApollo.Properties.Resources.ApolloLogo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(376, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 75);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // gridDetalleVentas
            // 
            this.gridDetalleVentas.AllowUserToAddRows = false;
            this.gridDetalleVentas.AllowUserToDeleteRows = false;
            this.gridDetalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalleVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalleVenta,
            this.idProducto,
            this.nombreProducto,
            this.cantidad,
            this.precioUnitario});
            this.gridDetalleVentas.Location = new System.Drawing.Point(66, 136);
            this.gridDetalleVentas.Name = "gridDetalleVentas";
            this.gridDetalleVentas.ReadOnly = true;
            this.gridDetalleVentas.Size = new System.Drawing.Size(545, 281);
            this.gridDetalleVentas.TabIndex = 9;
            // 
            // idDetalleVenta
            // 
            this.idDetalleVenta.DataPropertyName = "idDetalleVenta";
            this.idDetalleVenta.HeaderText = "Nro Item";
            this.idDetalleVenta.Name = "idDetalleVenta";
            this.idDetalleVenta.ReadOnly = true;
            this.idDetalleVenta.Width = 50;
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "ID";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 50;
            // 
            // nombreProducto
            // 
            this.nombreProducto.DataPropertyName = "nombreProducto";
            this.nombreProducto.HeaderText = "Nombre Producto";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            this.nombreProducto.Width = 200;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precioUnitario
            // 
            this.precioUnitario.DataPropertyName = "precioUnitario";
            this.precioUnitario.HeaderText = "Precio Unitario";
            this.precioUnitario.Name = "precioUnitario";
            this.precioUnitario.ReadOnly = true;
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFechaHora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFechaHora.Location = new System.Drawing.Point(13, 12);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(58, 20);
            this.lblFechaHora.TabIndex = 39;
            this.lblFechaHora.Text = "Fecha:";
            // 
            // lblNomApeCliente
            // 
            this.lblNomApeCliente.AutoSize = true;
            this.lblNomApeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomApeCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomApeCliente.Location = new System.Drawing.Point(13, 40);
            this.lblNomApeCliente.Name = "lblNomApeCliente";
            this.lblNomApeCliente.Size = new System.Drawing.Size(62, 20);
            this.lblNomApeCliente.TabIndex = 40;
            this.lblNomApeCliente.Text = "Cliente:";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrecioTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrecioTotal.Location = new System.Drawing.Point(419, 430);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(96, 20);
            this.lblPrecioTotal.TabIndex = 41;
            this.lblPrecioTotal.Text = "Precio Total:";
            // 
            // lblNomApeEmpleado
            // 
            this.lblNomApeEmpleado.AutoSize = true;
            this.lblNomApeEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomApeEmpleado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomApeEmpleado.Location = new System.Drawing.Point(13, 69);
            this.lblNomApeEmpleado.Name = "lblNomApeEmpleado";
            this.lblNomApeEmpleado.Size = new System.Drawing.Size(85, 20);
            this.lblNomApeEmpleado.TabIndex = 42;
            this.lblNomApeEmpleado.Text = "Empleado:";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTipoPago.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTipoPago.Location = new System.Drawing.Point(13, 99);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(84, 20);
            this.lblTipoPago.TabIndex = 43;
            this.lblTipoPago.Text = "Tipo Pago:";
            // 
            // frmDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(676, 468);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.lblNomApeEmpleado);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.lblNomApeCliente);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.gridDetalleVentas);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDetalleVenta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Libreria Apollo | Detalle Venta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView gridDetalleVentas;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblNomApeCliente;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label lblNomApeEmpleado;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
    }
}