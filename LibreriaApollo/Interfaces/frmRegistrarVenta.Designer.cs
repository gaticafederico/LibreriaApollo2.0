namespace LibreriaApollo.Interfaces
{
    partial class frmRegistrarVenta
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
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gridCarritos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminarProductoCarrito = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.cmbTipoPago = new LibreriaApollo.Entidades.ComboBox2();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClienteMayorista = new System.Windows.Forms.Label();
            this.comboTipoDocumento = new LibreriaApollo.Entidades.ComboBox2();
            this.comboCategorias = new LibreriaApollo.Entidades.ComboBox2();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarritos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombreProducto.Location = new System.Drawing.Point(172, 45);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(207, 26);
            this.txtNombreProducto.TabIndex = 8;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.OnTxtNombreProductoChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(17, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Filtrar productos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(2, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Productos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Carrito";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(83, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Categoria:";
            // 
            // gridCarritos
            // 
            this.gridCarritos.AllowUserToAddRows = false;
            this.gridCarritos.AllowUserToDeleteRows = false;
            this.gridCarritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarritos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.cantidad,
            this.dataGridViewTextBoxColumn4});
            this.gridCarritos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.gridCarritos.Location = new System.Drawing.Point(11, 45);
            this.gridCarritos.Name = "gridCarritos";
            this.gridCarritos.ReadOnly = true;
            this.gridCarritos.RowHeadersWidth = 51;
            this.gridCarritos.Size = new System.Drawing.Size(444, 218);
            this.gridCarritos.TabIndex = 17;
            this.gridCarritos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnGridCarritosClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnAgregarProducto.Enabled = false;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.Location = new System.Drawing.Point(464, 273);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(166, 41);
            this.btnAgregarProducto.TabIndex = 18;
            this.btnAgregarProducto.Text = "Agregar ";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(183, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Cantidad:";
            // 
            // btnEliminarProductoCarrito
            // 
            this.btnEliminarProductoCarrito.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarProductoCarrito.Enabled = false;
            this.btnEliminarProductoCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProductoCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProductoCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProductoCarrito.Location = new System.Drawing.Point(289, 268);
            this.btnEliminarProductoCarrito.Name = "btnEliminarProductoCarrito";
            this.btnEliminarProductoCarrito.Size = new System.Drawing.Size(166, 41);
            this.btnEliminarProductoCarrito.TabIndex = 21;
            this.btnEliminarProductoCarrito.Text = "Eliminar";
            this.btnEliminarProductoCarrito.UseVisualStyleBackColor = false;
            this.btnEliminarProductoCarrito.Click += new System.EventHandler(this.btnEliminarProductoCarrito_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.pictureBox3.BackgroundImage = global::LibreriaApollo.Properties.Resources.add_fill;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(469, 278);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox1.BackgroundImage = global::LibreriaApollo.Properties.Resources.close_fill1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(292, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LibreriaApollo.Properties.Resources.ApolloLogo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(867, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 75);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(285, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Total: $";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.Location = new System.Drawing.Point(342, 326);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(24, 26);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(396, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 26);
            this.label10.TabIndex = 28;
            this.label10.Text = "Cliente";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDocumento.Location = new System.Drawing.Point(564, 79);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(207, 26);
            this.txtDocumento.TabIndex = 27;
            this.txtDocumento.TextChanged += new System.EventHandler(this.OnTxtDocumentoChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(457, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Documento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(484, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.gridProductos);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnAgregarProducto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(22, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 363);
            this.panel1.TabIndex = 31;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCantidad.Location = new System.Drawing.Point(261, 280);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Mask = "99999";
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(76, 26);
            this.txtCantidad.TabIndex = 63;
            this.txtCantidad.ValidatingType = typeof(int);
            // 
            // gridProductos
            // 
            this.gridProductos.AllowUserToAddRows = false;
            this.gridProductos.AllowUserToDeleteRows = false;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.cantidadStock,
            this.precioUnitario,
            this.stockMinimo,
            this.idCategoria,
            this.descripcionProducto});
            this.gridProductos.Location = new System.Drawing.Point(7, 45);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            this.gridProductos.RowHeadersWidth = 51;
            this.gridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductos.Size = new System.Drawing.Size(623, 218);
            this.gridProductos.TabIndex = 62;
            this.gridProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnGridProductosClick);
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "ID";
            this.idProducto.MinimumWidth = 6;
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 30;
            // 
            // nombreProducto
            // 
            this.nombreProducto.DataPropertyName = "nombreProducto";
            this.nombreProducto.HeaderText = "Nombre";
            this.nombreProducto.MinimumWidth = 6;
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            this.nombreProducto.Width = 250;
            // 
            // cantidadStock
            // 
            this.cantidadStock.DataPropertyName = "cantidadStock";
            this.cantidadStock.HeaderText = "Stock";
            this.cantidadStock.MinimumWidth = 6;
            this.cantidadStock.Name = "cantidadStock";
            this.cantidadStock.ReadOnly = true;
            this.cantidadStock.Width = 125;
            // 
            // precioUnitario
            // 
            this.precioUnitario.DataPropertyName = "precioUnitario";
            this.precioUnitario.HeaderText = "Precio Unitario";
            this.precioUnitario.MinimumWidth = 6;
            this.precioUnitario.Name = "precioUnitario";
            this.precioUnitario.ReadOnly = true;
            this.precioUnitario.Width = 125;
            // 
            // stockMinimo
            // 
            this.stockMinimo.DataPropertyName = "stockMinimo";
            this.stockMinimo.HeaderText = "Stock Minimo";
            this.stockMinimo.MinimumWidth = 6;
            this.stockMinimo.Name = "stockMinimo";
            this.stockMinimo.ReadOnly = true;
            this.stockMinimo.Visible = false;
            this.stockMinimo.Width = 80;
            // 
            // idCategoria
            // 
            this.idCategoria.DataPropertyName = "idCategoria";
            this.idCategoria.HeaderText = "ID Categoria";
            this.idCategoria.MinimumWidth = 6;
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            this.idCategoria.Visible = false;
            this.idCategoria.Width = 125;
            // 
            // descripcionProducto
            // 
            this.descripcionProducto.DataPropertyName = "descripcionProducto";
            this.descripcionProducto.HeaderText = "Descripcion";
            this.descripcionProducto.MinimumWidth = 6;
            this.descripcionProducto.Name = "descripcionProducto";
            this.descripcionProducto.ReadOnly = true;
            this.descripcionProducto.Visible = false;
            this.descripcionProducto.Width = 350;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTipoPago);
            this.panel2.Controls.Add(this.cmbTipoPago);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnEliminarProductoCarrito);
            this.panel2.Controls.Add(this.gridCarritos);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(683, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 363);
            this.panel2.TabIndex = 32;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTipoPago.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTipoPago.Location = new System.Drawing.Point(8, 326);
            this.lblTipoPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(110, 20);
            this.lblTipoPago.TabIndex = 27;
            this.lblTipoPago.Text = "Tipo de Pago: ";
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(117, 323);
            this.cmbTipoPago.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.ppDescriptorTablaCargar = "nombreTipoPago";
            this.cmbTipoPago.ppNombreCampo = "nombreTipoPago";
            this.cmbTipoPago.ppNombreTabla = "tiposPagos";
            this.cmbTipoPago.ppNombreTablaCargar = "tiposPagos";
            this.cmbTipoPago.ppPkTablaCargar = "idTipoPago";
            this.cmbTipoPago.ppValidar = false;
            this.cmbTipoPago.Size = new System.Drawing.Size(135, 28);
            this.cmbTipoPago.TabIndex = 26;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(984, 543);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(166, 41);
            this.btnRegistrar.TabIndex = 36;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.onClickRegistrarVenta);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(422, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tipo Documento:";
            // 
            // lblClienteMayorista
            // 
            this.lblClienteMayorista.AutoSize = true;
            this.lblClienteMayorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClienteMayorista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClienteMayorista.Location = new System.Drawing.Point(566, 117);
            this.lblClienteMayorista.Name = "lblClienteMayorista";
            this.lblClienteMayorista.Size = new System.Drawing.Size(0, 20);
            this.lblClienteMayorista.TabIndex = 40;
            // 
            // comboTipoDocumento
            // 
            this.comboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboTipoDocumento.FormattingEnabled = true;
            this.comboTipoDocumento.Location = new System.Drawing.Point(564, 45);
            this.comboTipoDocumento.Name = "comboTipoDocumento";
            this.comboTipoDocumento.ppDescriptorTablaCargar = "nombreTipoDoc";
            this.comboTipoDocumento.ppNombreCampo = "nombreTipoDoc";
            this.comboTipoDocumento.ppNombreTabla = "tipoDocumento";
            this.comboTipoDocumento.ppNombreTablaCargar = "tipoDocumento";
            this.comboTipoDocumento.ppPkTablaCargar = "idTipoDoc";
            this.comboTipoDocumento.ppValidar = false;
            this.comboTipoDocumento.Size = new System.Drawing.Size(207, 28);
            this.comboTipoDocumento.TabIndex = 38;
            this.comboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.OnComboSelectedIndexChanged);
            // 
            // comboCategorias
            // 
            this.comboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboCategorias.FormattingEnabled = true;
            this.comboCategorias.Location = new System.Drawing.Point(172, 80);
            this.comboCategorias.Name = "comboCategorias";
            this.comboCategorias.ppDescriptorTablaCargar = "nombreCategoria";
            this.comboCategorias.ppNombreCampo = "nombreCategoria";
            this.comboCategorias.ppNombreTabla = "categoriasProductos";
            this.comboCategorias.ppNombreTablaCargar = "categoriasProductos";
            this.comboCategorias.ppPkTablaCargar = "idCategoria";
            this.comboCategorias.ppValidar = false;
            this.comboCategorias.Size = new System.Drawing.Size(207, 28);
            this.comboCategorias.TabIndex = 37;
            this.comboCategorias.SelectedIndexChanged += new System.EventHandler(this.onComboCategoriasChanged);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnLimpiarCampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(976, 117);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(174, 41);
            this.btnLimpiarCampos.TabIndex = 41;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // frmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1167, 601);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.lblClienteMayorista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboTipoDocumento);
            this.Controls.Add(this.comboCategorias);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRegistrarVenta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Libreria Apollo | Registrar Venta";
            this.Load += new System.EventHandler(this.onFrmLoad);
            ((System.ComponentModel.ISupportInitialize)(this.gridCarritos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gridCarritos;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminarProductoCarrito;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegistrar;
        private Entidades.ComboBox2 comboCategorias;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Entidades.ComboBox2 comboTipoDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClienteMayorista;
        private System.Windows.Forms.MaskedTextBox txtCantidad;
        private Entidades.ComboBox2 cmbTipoPago;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProducto;
    }
}