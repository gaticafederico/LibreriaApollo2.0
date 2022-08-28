namespace LibreriaApollo.Interfaces
{
    partial class frmConsultarVentas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridVentas = new System.Windows.Forms.DataGridView();
            this.idFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.maskFechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.cmbTipoPago = new LibreriaApollo.Entidades.ComboBox2();
            this.cmbNomApe = new LibreriaApollo.Entidades.ComboBox2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LibreriaApollo.Properties.Resources.ApolloLogo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(540, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 75);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(28, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 26);
            this.label3.TabIndex = 40;
            this.label3.Text = "Filtrar Ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(52, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Empleado:";
            // 
            // gridVentas
            // 
            this.gridVentas.AllowUserToAddRows = false;
            this.gridVentas.AllowUserToDeleteRows = false;
            this.gridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFactura,
            this.fechaHora,
            this.empleado,
            this.cliente,
            this.nombreTipoPago,
            this.importeTotal});
            this.gridVentas.Location = new System.Drawing.Point(33, 248);
            this.gridVentas.Margin = new System.Windows.Forms.Padding(2);
            this.gridVentas.Name = "gridVentas";
            this.gridVentas.ReadOnly = true;
            this.gridVentas.RowHeadersWidth = 51;
            this.gridVentas.RowTemplate.Height = 24;
            this.gridVentas.Size = new System.Drawing.Size(719, 293);
            this.gridVentas.TabIndex = 42;
            this.gridVentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnGridVentasDobleClick);
            // 
            // idFactura
            // 
            this.idFactura.DataPropertyName = "idFactura";
            this.idFactura.HeaderText = "ID";
            this.idFactura.MinimumWidth = 6;
            this.idFactura.Name = "idFactura";
            this.idFactura.ReadOnly = true;
            this.idFactura.Width = 40;
            // 
            // fechaHora
            // 
            this.fechaHora.DataPropertyName = "fechaHora";
            this.fechaHora.HeaderText = "Fecha hora";
            this.fechaHora.MinimumWidth = 6;
            this.fechaHora.Name = "fechaHora";
            this.fechaHora.ReadOnly = true;
            this.fechaHora.Width = 125;
            // 
            // empleado
            // 
            this.empleado.DataPropertyName = "empleado";
            this.empleado.HeaderText = "Empleado";
            this.empleado.MinimumWidth = 6;
            this.empleado.Name = "empleado";
            this.empleado.ReadOnly = true;
            this.empleado.Width = 125;
            // 
            // cliente
            // 
            this.cliente.DataPropertyName = "cliente";
            this.cliente.HeaderText = "Cliente";
            this.cliente.MinimumWidth = 6;
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 125;
            // 
            // nombreTipoPago
            // 
            this.nombreTipoPago.DataPropertyName = "nombreTipoPago";
            this.nombreTipoPago.HeaderText = "Tipo pago";
            this.nombreTipoPago.MinimumWidth = 6;
            this.nombreTipoPago.Name = "nombreTipoPago";
            this.nombreTipoPago.ReadOnly = true;
            this.nombreTipoPago.Width = 125;
            // 
            // importeTotal
            // 
            this.importeTotal.DataPropertyName = "importeTotal";
            this.importeTotal.HeaderText = "Importe Total";
            this.importeTotal.MinimumWidth = 6;
            this.importeTotal.Name = "importeTotal";
            this.importeTotal.ReadOnly = true;
            this.importeTotal.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Fecha Desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(31, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Fecha Hasta: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(51, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Tipo Pago:";
            // 
            // maskFechaDesde
            // 
            this.maskFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskFechaDesde.Location = new System.Drawing.Point(141, 79);
            this.maskFechaDesde.Mask = "00/00/0000";
            this.maskFechaDesde.Name = "maskFechaDesde";
            this.maskFechaDesde.Size = new System.Drawing.Size(94, 26);
            this.maskFechaDesde.TabIndex = 49;
            this.maskFechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // maskFechaHasta
            // 
            this.maskFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskFechaHasta.Location = new System.Drawing.Point(141, 112);
            this.maskFechaHasta.Mask = "00/00/0000";
            this.maskFechaHasta.Name = "maskFechaHasta";
            this.maskFechaHasta.Size = new System.Drawing.Size(94, 26);
            this.maskFechaHasta.TabIndex = 50;
            this.maskFechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.pictureBox3.BackgroundImage = global::LibreriaApollo.Properties.Resources.search_line;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(375, 193);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(372, 189);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(166, 41);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.onBtnBuscarClick);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(227, 189);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(139, 41);
            this.btnLimpiarFiltros.TabIndex = 69;
            this.btnLimpiarFiltros.Text = "Limpiar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.onBtnLimpiarFiltros);
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(141, 146);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.ppDescriptorTablaCargar = "nombreTipoPago";
            this.cmbTipoPago.ppNombreCampo = "nombreTipoPago";
            this.cmbTipoPago.ppNombreTabla = "tiposPagos";
            this.cmbTipoPago.ppNombreTablaCargar = "tiposPagos";
            this.cmbTipoPago.ppPkTablaCargar = "idTipoPago";
            this.cmbTipoPago.ppValidar = false;
            this.cmbTipoPago.Size = new System.Drawing.Size(192, 28);
            this.cmbTipoPago.TabIndex = 48;
            // 
            // cmbNomApe
            // 
            this.cmbNomApe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbNomApe.FormattingEnabled = true;
            this.cmbNomApe.Location = new System.Drawing.Point(141, 43);
            this.cmbNomApe.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNomApe.Name = "cmbNomApe";
            this.cmbNomApe.ppDescriptorTablaCargar = "NombreApellido";
            this.cmbNomApe.ppNombreCampo = "NombreApellido";
            this.cmbNomApe.ppNombreTabla = "empleados";
            this.cmbNomApe.ppNombreTablaCargar = "empleados";
            this.cmbNomApe.ppPkTablaCargar = "idEmpleado";
            this.cmbNomApe.ppValidar = false;
            this.cmbNomApe.Size = new System.Drawing.Size(192, 28);
            this.cmbNomApe.TabIndex = 41;
            // 
            // frmConsultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(838, 550);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.maskFechaHasta);
            this.Controls.Add(this.maskFechaDesde);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridVentas);
            this.Controls.Add(this.cmbNomApe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmConsultarVentas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Libreria Apollo | Consultar Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Entidades.ComboBox2 cmbNomApe;
        private System.Windows.Forms.DataGridView gridVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Entidades.ComboBox2 cmbTipoPago;
        private System.Windows.Forms.MaskedTextBox maskFechaDesde;
        private System.Windows.Forms.MaskedTextBox maskFechaHasta;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiarFiltros;
    }
}