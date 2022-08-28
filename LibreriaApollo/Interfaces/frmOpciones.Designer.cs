namespace LibreriaApollo.Interfaces
{
    partial class frmOpciones
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
            this.dataLocalidades = new System.Windows.Forms.DataGridView();
            this.codPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTiposPago = new System.Windows.Forms.DataGridView();
            this.idTipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCatProducto = new System.Windows.Forms.DataGridView();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Localidades = new System.Windows.Forms.TabPage();
            this.txtLocalidadCodPostal = new System.Windows.Forms.MaskedTextBox();
            this.btnDeseleccionarLocalidades = new System.Windows.Forms.Button();
            this.txtLocalidadNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLocalidades = new System.Windows.Forms.Label();
            this.btnAgregarLocalidad = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tiposDePago = new System.Windows.Forms.TabPage();
            this.btnDeseleccionarTipoPago = new System.Windows.Forms.Button();
            this.txtTipoPagoNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.btnAgregarTipoPago = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.categoriasDeProducto = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tiposDeDocumento = new System.Windows.Forms.TabPage();
            this.dataTipoDocumento = new System.Windows.Forms.DataGridView();
            this.idTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeseleccionarCatProducto = new System.Windows.Forms.Button();
            this.txtCatProductoNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCatProducto = new System.Windows.Forms.Label();
            this.btnAgregarCatProducto = new System.Windows.Forms.Button();
            this.txtCatProductoDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLocalidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTiposPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCatProducto)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Localidades.SuspendLayout();
            this.tiposDePago.SuspendLayout();
            this.categoriasDeProducto.SuspendLayout();
            this.tiposDeDocumento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTipoDocumento)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LibreriaApollo.Properties.Resources.ApolloLogo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(687, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(369, 90);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // dataLocalidades
            // 
            this.dataLocalidades.AllowUserToAddRows = false;
            this.dataLocalidades.AllowUserToDeleteRows = false;
            this.dataLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLocalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codPostal,
            this.nombre});
            this.dataLocalidades.Location = new System.Drawing.Point(15, 41);
            this.dataLocalidades.Name = "dataLocalidades";
            this.dataLocalidades.ReadOnly = true;
            this.dataLocalidades.Size = new System.Drawing.Size(487, 344);
            this.dataLocalidades.TabIndex = 0;
            this.dataLocalidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onGridLocalidadesClick);
            // 
            // codPostal
            // 
            this.codPostal.DataPropertyName = "codPostal";
            this.codPostal.HeaderText = "Codigo Postal";
            this.codPostal.Name = "codPostal";
            this.codPostal.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // dataTiposPago
            // 
            this.dataTiposPago.AllowUserToAddRows = false;
            this.dataTiposPago.AllowUserToDeleteRows = false;
            this.dataTiposPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTiposPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoPago,
            this.nombreTipoPago});
            this.dataTiposPago.Location = new System.Drawing.Point(15, 41);
            this.dataTiposPago.Name = "dataTiposPago";
            this.dataTiposPago.ReadOnly = true;
            this.dataTiposPago.Size = new System.Drawing.Size(487, 344);
            this.dataTiposPago.TabIndex = 1;
            this.dataTiposPago.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onGridTiposPagoClick);
            // 
            // idTipoPago
            // 
            this.idTipoPago.DataPropertyName = "idTipoPago";
            this.idTipoPago.HeaderText = "ID Tipo Pago";
            this.idTipoPago.Name = "idTipoPago";
            this.idTipoPago.ReadOnly = true;
            // 
            // nombreTipoPago
            // 
            this.nombreTipoPago.DataPropertyName = "nombreTipoPago";
            this.nombreTipoPago.HeaderText = "Nombre";
            this.nombreTipoPago.Name = "nombreTipoPago";
            this.nombreTipoPago.ReadOnly = true;
            // 
            // dataCatProducto
            // 
            this.dataCatProducto.AllowUserToAddRows = false;
            this.dataCatProducto.AllowUserToDeleteRows = false;
            this.dataCatProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCatProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoria,
            this.nombreCategoria,
            this.descripcionCategoria});
            this.dataCatProducto.Location = new System.Drawing.Point(15, 41);
            this.dataCatProducto.Name = "dataCatProducto";
            this.dataCatProducto.ReadOnly = true;
            this.dataCatProducto.Size = new System.Drawing.Size(487, 344);
            this.dataCatProducto.TabIndex = 29;
            this.dataCatProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onGridCatProductoClick);
            // 
            // idCategoria
            // 
            this.idCategoria.DataPropertyName = "idCategoria";
            this.idCategoria.HeaderText = "ID Categoria";
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            // 
            // nombreCategoria
            // 
            this.nombreCategoria.DataPropertyName = "nombreCategoria";
            this.nombreCategoria.HeaderText = "Nombre";
            this.nombreCategoria.Name = "nombreCategoria";
            this.nombreCategoria.ReadOnly = true;
            // 
            // descripcionCategoria
            // 
            this.descripcionCategoria.DataPropertyName = "descripcionCategoria";
            this.descripcionCategoria.HeaderText = "Descripcion";
            this.descripcionCategoria.Name = "descripcionCategoria";
            this.descripcionCategoria.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Localidades);
            this.tabControl1.Controls.Add(this.tiposDePago);
            this.tabControl1.Controls.Add(this.categoriasDeProducto);
            this.tabControl1.Controls.Add(this.tiposDeDocumento);
            this.tabControl1.Location = new System.Drawing.Point(12, 109);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1044, 474);
            this.tabControl1.TabIndex = 29;
            // 
            // Localidades
            // 
            this.Localidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Localidades.Controls.Add(this.txtLocalidadCodPostal);
            this.Localidades.Controls.Add(this.btnDeseleccionarLocalidades);
            this.Localidades.Controls.Add(this.txtLocalidadNombre);
            this.Localidades.Controls.Add(this.label6);
            this.Localidades.Controls.Add(this.label5);
            this.Localidades.Controls.Add(this.lblLocalidades);
            this.Localidades.Controls.Add(this.btnAgregarLocalidad);
            this.Localidades.Controls.Add(this.dataLocalidades);
            this.Localidades.Controls.Add(this.label10);
            this.Localidades.Location = new System.Drawing.Point(4, 22);
            this.Localidades.Name = "Localidades";
            this.Localidades.Padding = new System.Windows.Forms.Padding(3);
            this.Localidades.Size = new System.Drawing.Size(1036, 448);
            this.Localidades.TabIndex = 0;
            this.Localidades.Text = "Localidades";
            // 
            // txtLocalidadCodPostal
            // 
            this.txtLocalidadCodPostal.Font = new System.Drawing.Font("Open Sans", 12F);
            this.txtLocalidadCodPostal.Location = new System.Drawing.Point(524, 81);
            this.txtLocalidadCodPostal.Mask = "9999";
            this.txtLocalidadCodPostal.Name = "txtLocalidadCodPostal";
            this.txtLocalidadCodPostal.Size = new System.Drawing.Size(69, 29);
            this.txtLocalidadCodPostal.TabIndex = 38;
            this.txtLocalidadCodPostal.ValidatingType = typeof(int);
            // 
            // btnDeseleccionarLocalidades
            // 
            this.btnDeseleccionarLocalidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnDeseleccionarLocalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeseleccionarLocalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnDeseleccionarLocalidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnDeseleccionarLocalidades.Location = new System.Drawing.Point(15, 391);
            this.btnDeseleccionarLocalidades.Name = "btnDeseleccionarLocalidades";
            this.btnDeseleccionarLocalidades.Size = new System.Drawing.Size(487, 39);
            this.btnDeseleccionarLocalidades.TabIndex = 37;
            this.btnDeseleccionarLocalidades.Text = "Deseleccionar";
            this.btnDeseleccionarLocalidades.UseVisualStyleBackColor = false;
            this.btnDeseleccionarLocalidades.Click += new System.EventHandler(this.deseleccionarLocalidades);
            // 
            // txtLocalidadNombre
            // 
            this.txtLocalidadNombre.Font = new System.Drawing.Font("Open Sans", 12F);
            this.txtLocalidadNombre.Location = new System.Drawing.Point(524, 149);
            this.txtLocalidadNombre.Name = "txtLocalidadNombre";
            this.txtLocalidadNombre.Size = new System.Drawing.Size(317, 29);
            this.txtLocalidadNombre.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(520, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(520, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Codigo Postal";
            // 
            // lblLocalidades
            // 
            this.lblLocalidades.AutoSize = true;
            this.lblLocalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblLocalidades.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLocalidades.Location = new System.Drawing.Point(513, 12);
            this.lblLocalidades.Name = "lblLocalidades";
            this.lblLocalidades.Size = new System.Drawing.Size(328, 26);
            this.lblLocalidades.TabIndex = 32;
            this.lblLocalidades.Text = "Estas agregando una localidad...";
            // 
            // btnAgregarLocalidad
            // 
            this.btnAgregarLocalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnAgregarLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnAgregarLocalidad.Location = new System.Drawing.Point(518, 391);
            this.btnAgregarLocalidad.Name = "btnAgregarLocalidad";
            this.btnAgregarLocalidad.Size = new System.Drawing.Size(512, 39);
            this.btnAgregarLocalidad.TabIndex = 31;
            this.btnAgregarLocalidad.Text = "Agregar";
            this.btnAgregarLocalidad.UseVisualStyleBackColor = false;
            this.btnAgregarLocalidad.Click += new System.EventHandler(this.agregarLocalidad);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(10, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 26);
            this.label10.TabIndex = 30;
            this.label10.Text = "Localidades";
            // 
            // tiposDePago
            // 
            this.tiposDePago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tiposDePago.Controls.Add(this.btnDeseleccionarTipoPago);
            this.tiposDePago.Controls.Add(this.txtTipoPagoNombre);
            this.tiposDePago.Controls.Add(this.label4);
            this.tiposDePago.Controls.Add(this.lblTipoPago);
            this.tiposDePago.Controls.Add(this.btnAgregarTipoPago);
            this.tiposDePago.Controls.Add(this.label1);
            this.tiposDePago.Controls.Add(this.dataTiposPago);
            this.tiposDePago.Location = new System.Drawing.Point(4, 22);
            this.tiposDePago.Name = "tiposDePago";
            this.tiposDePago.Padding = new System.Windows.Forms.Padding(3);
            this.tiposDePago.Size = new System.Drawing.Size(1036, 448);
            this.tiposDePago.TabIndex = 1;
            this.tiposDePago.Text = "Tipos de Pago";
            // 
            // btnDeseleccionarTipoPago
            // 
            this.btnDeseleccionarTipoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnDeseleccionarTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeseleccionarTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnDeseleccionarTipoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnDeseleccionarTipoPago.Location = new System.Drawing.Point(16, 394);
            this.btnDeseleccionarTipoPago.Name = "btnDeseleccionarTipoPago";
            this.btnDeseleccionarTipoPago.Size = new System.Drawing.Size(487, 39);
            this.btnDeseleccionarTipoPago.TabIndex = 44;
            this.btnDeseleccionarTipoPago.Text = "Deseleccionar";
            this.btnDeseleccionarTipoPago.UseVisualStyleBackColor = false;
            this.btnDeseleccionarTipoPago.Click += new System.EventHandler(this.deseleccionarTipoPago);
            // 
            // txtTipoPagoNombre
            // 
            this.txtTipoPagoNombre.Font = new System.Drawing.Font("Open Sans", 12F);
            this.txtTipoPagoNombre.Location = new System.Drawing.Point(519, 91);
            this.txtTipoPagoNombre.Name = "txtTipoPagoNombre";
            this.txtTipoPagoNombre.Size = new System.Drawing.Size(317, 29);
            this.txtTipoPagoNombre.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(515, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 42;
            this.label4.Text = "Nombre";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTipoPago.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipoPago.Location = new System.Drawing.Point(514, 15);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(349, 26);
            this.lblTipoPago.TabIndex = 40;
            this.lblTipoPago.Text = "Estas agregando un tipo de pago...";
            // 
            // btnAgregarTipoPago
            // 
            this.btnAgregarTipoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnAgregarTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnAgregarTipoPago.Location = new System.Drawing.Point(519, 394);
            this.btnAgregarTipoPago.Name = "btnAgregarTipoPago";
            this.btnAgregarTipoPago.Size = new System.Drawing.Size(512, 39);
            this.btnAgregarTipoPago.TabIndex = 39;
            this.btnAgregarTipoPago.Text = "Agregar";
            this.btnAgregarTipoPago.UseVisualStyleBackColor = false;
            this.btnAgregarTipoPago.Click += new System.EventHandler(this.agregarTipoPago);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tipos de Pago";
            // 
            // categoriasDeProducto
            // 
            this.categoriasDeProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.categoriasDeProducto.Controls.Add(this.txtCatProductoDesc);
            this.categoriasDeProducto.Controls.Add(this.label8);
            this.categoriasDeProducto.Controls.Add(this.btnDeseleccionarCatProducto);
            this.categoriasDeProducto.Controls.Add(this.txtCatProductoNombre);
            this.categoriasDeProducto.Controls.Add(this.label7);
            this.categoriasDeProducto.Controls.Add(this.lblCatProducto);
            this.categoriasDeProducto.Controls.Add(this.btnAgregarCatProducto);
            this.categoriasDeProducto.Controls.Add(this.dataCatProducto);
            this.categoriasDeProducto.Controls.Add(this.label2);
            this.categoriasDeProducto.Location = new System.Drawing.Point(4, 22);
            this.categoriasDeProducto.Name = "categoriasDeProducto";
            this.categoriasDeProducto.Size = new System.Drawing.Size(1036, 448);
            this.categoriasDeProducto.TabIndex = 2;
            this.categoriasDeProducto.Text = "Categorias de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "Categorias de Producto";
            // 
            // tiposDeDocumento
            // 
            this.tiposDeDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tiposDeDocumento.Controls.Add(this.dataTipoDocumento);
            this.tiposDeDocumento.Controls.Add(this.label3);
            this.tiposDeDocumento.Location = new System.Drawing.Point(4, 22);
            this.tiposDeDocumento.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tiposDeDocumento.Name = "tiposDeDocumento";
            this.tiposDeDocumento.Size = new System.Drawing.Size(1036, 448);
            this.tiposDeDocumento.TabIndex = 3;
            this.tiposDeDocumento.Text = "Tipos de Documento";
            // 
            // dataTipoDocumento
            // 
            this.dataTipoDocumento.AllowUserToAddRows = false;
            this.dataTipoDocumento.AllowUserToDeleteRows = false;
            this.dataTipoDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTipoDocumento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoDoc,
            this.nombreTipoDoc});
            this.dataTipoDocumento.Location = new System.Drawing.Point(15, 41);
            this.dataTipoDocumento.Name = "dataTipoDocumento";
            this.dataTipoDocumento.ReadOnly = true;
            this.dataTipoDocumento.Size = new System.Drawing.Size(487, 344);
            this.dataTipoDocumento.TabIndex = 29;
            // 
            // idTipoDoc
            // 
            this.idTipoDoc.DataPropertyName = "idTipoDoc";
            this.idTipoDoc.HeaderText = "ID Tipo Documento";
            this.idTipoDoc.Name = "idTipoDoc";
            this.idTipoDoc.ReadOnly = true;
            this.idTipoDoc.Width = 150;
            // 
            // nombreTipoDoc
            // 
            this.nombreTipoDoc.DataPropertyName = "nombreTipoDoc";
            this.nombreTipoDoc.HeaderText = "Nombre";
            this.nombreTipoDoc.Name = "nombreTipoDoc";
            this.nombreTipoDoc.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(10, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tipos de Documento";
            // 
            // btnDeseleccionarCatProducto
            // 
            this.btnDeseleccionarCatProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnDeseleccionarCatProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeseleccionarCatProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnDeseleccionarCatProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnDeseleccionarCatProducto.Location = new System.Drawing.Point(16, 394);
            this.btnDeseleccionarCatProducto.Name = "btnDeseleccionarCatProducto";
            this.btnDeseleccionarCatProducto.Size = new System.Drawing.Size(487, 39);
            this.btnDeseleccionarCatProducto.TabIndex = 49;
            this.btnDeseleccionarCatProducto.Text = "Deseleccionar";
            this.btnDeseleccionarCatProducto.UseVisualStyleBackColor = false;
            this.btnDeseleccionarCatProducto.Click += new System.EventHandler(this.deseleccionarCatProducto);
            // 
            // txtCatProductoNombre
            // 
            this.txtCatProductoNombre.Font = new System.Drawing.Font("Open Sans", 12F);
            this.txtCatProductoNombre.Location = new System.Drawing.Point(519, 91);
            this.txtCatProductoNombre.Name = "txtCatProductoNombre";
            this.txtCatProductoNombre.Size = new System.Drawing.Size(317, 29);
            this.txtCatProductoNombre.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(515, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 47;
            this.label7.Text = "Nombre";
            // 
            // lblCatProducto
            // 
            this.lblCatProducto.AutoSize = true;
            this.lblCatProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCatProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCatProducto.Location = new System.Drawing.Point(514, 15);
            this.lblCatProducto.Name = "lblCatProducto";
            this.lblCatProducto.Size = new System.Drawing.Size(451, 26);
            this.lblCatProducto.TabIndex = 46;
            this.lblCatProducto.Text = "Estas agregando una categoria de producto...";
            // 
            // btnAgregarCatProducto
            // 
            this.btnAgregarCatProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnAgregarCatProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCatProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnAgregarCatProducto.Location = new System.Drawing.Point(519, 394);
            this.btnAgregarCatProducto.Name = "btnAgregarCatProducto";
            this.btnAgregarCatProducto.Size = new System.Drawing.Size(512, 39);
            this.btnAgregarCatProducto.TabIndex = 45;
            this.btnAgregarCatProducto.Text = "Agregar";
            this.btnAgregarCatProducto.UseVisualStyleBackColor = false;
            this.btnAgregarCatProducto.Click += new System.EventHandler(this.agregarCatProducto);
            // 
            // txtCatProductoDesc
            // 
            this.txtCatProductoDesc.Font = new System.Drawing.Font("Open Sans", 12F);
            this.txtCatProductoDesc.Location = new System.Drawing.Point(519, 165);
            this.txtCatProductoDesc.Name = "txtCatProductoDesc";
            this.txtCatProductoDesc.Size = new System.Drawing.Size(317, 29);
            this.txtCatProductoDesc.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(515, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 22);
            this.label8.TabIndex = 50;
            this.label8.Text = "Descripcion";
            // 
            // frmOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1068, 606);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmOpciones";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libreria Apollo | Opciones";
            this.Load += new System.EventHandler(this.onFrmOpcionesLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLocalidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTiposPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCatProducto)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Localidades.ResumeLayout(false);
            this.Localidades.PerformLayout();
            this.tiposDePago.ResumeLayout(false);
            this.tiposDePago.PerformLayout();
            this.categoriasDeProducto.ResumeLayout(false);
            this.categoriasDeProducto.PerformLayout();
            this.tiposDeDocumento.ResumeLayout(false);
            this.tiposDeDocumento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTipoDocumento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataLocalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridView dataTiposPago;
        private System.Windows.Forms.DataGridView dataCatProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCategoria;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Localidades;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tiposDePago;
        private System.Windows.Forms.TabPage categoriasDeProducto;
        private System.Windows.Forms.TabPage tiposDeDocumento;
        private System.Windows.Forms.DataGridView dataTipoDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoDoc;
        private System.Windows.Forms.Button btnAgregarLocalidad;
        private System.Windows.Forms.Label lblLocalidades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocalidadNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeseleccionarLocalidades;
        private System.Windows.Forms.MaskedTextBox txtLocalidadCodPostal;
        private System.Windows.Forms.Button btnDeseleccionarTipoPago;
        private System.Windows.Forms.TextBox txtTipoPagoNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Button btnAgregarTipoPago;
        private System.Windows.Forms.Button btnDeseleccionarCatProducto;
        private System.Windows.Forms.TextBox txtCatProductoNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCatProducto;
        private System.Windows.Forms.Button btnAgregarCatProducto;
        private System.Windows.Forms.TextBox txtCatProductoDesc;
        private System.Windows.Forms.Label label8;
    }
}