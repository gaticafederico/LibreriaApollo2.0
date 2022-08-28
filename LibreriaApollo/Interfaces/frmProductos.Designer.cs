namespace LibreriaApollo.Interfaces
{
    partial class frmProductos
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFiltrarNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDeseleccionarCategorias = new System.Windows.Forms.Button();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeseleccionarProducto = new System.Windows.Forms.Button();
            this.lblABM = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStockMinimo = new System.Windows.Forms.MaskedTextBox();
            this.txtStock = new System.Windows.Forms.MaskedTextBox();
            this.comboAgregarCategoria = new LibreriaApollo.Entidades.ComboBox2();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconAgregar = new System.Windows.Forms.PictureBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.comboCategorias = new LibreriaApollo.Entidades.ComboBox2();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LibreriaApollo.Properties.Resources.ApolloLogo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(842, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 75);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(68, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 20);
            this.label12.TabIndex = 58;
            this.label12.Text = "Categorias:";
            // 
            // txtFiltrarNombre
            // 
            this.txtFiltrarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFiltrarNombre.Location = new System.Drawing.Point(165, 74);
            this.txtFiltrarNombre.Name = "txtFiltrarNombre";
            this.txtFiltrarNombre.Size = new System.Drawing.Size(207, 26);
            this.txtFiltrarNombre.TabIndex = 55;
            this.txtFiltrarNombre.TextChanged += new System.EventHandler(this.onTxtFiltrarNombreChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(85, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 57;
            this.label11.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(18, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 26);
            this.label10.TabIndex = 56;
            this.label10.Text = "Filtrar";
            // 
            // btnDeseleccionarCategorias
            // 
            this.btnDeseleccionarCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnDeseleccionarCategorias.BackgroundImage = global::LibreriaApollo.Properties.Resources.close_fill;
            this.btnDeseleccionarCategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeseleccionarCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeseleccionarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.btnDeseleccionarCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnDeseleccionarCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeseleccionarCategorias.Location = new System.Drawing.Point(378, 109);
            this.btnDeseleccionarCategorias.Name = "btnDeseleccionarCategorias";
            this.btnDeseleccionarCategorias.Size = new System.Drawing.Size(30, 30);
            this.btnDeseleccionarCategorias.TabIndex = 60;
            this.btnDeseleccionarCategorias.UseVisualStyleBackColor = false;
            this.btnDeseleccionarCategorias.Click += new System.EventHandler(this.btnDeseleccionarCategorias_Click);
            // 
            // gridProductos
            // 
            this.gridProductos.AllowUserToAddRows = false;
            this.gridProductos.AllowUserToDeleteRows = false;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.descripcionProducto,
            this.cantidadStock,
            this.precioUnitario,
            this.stockMinimo,
            this.idCategoria});
            this.gridProductos.Location = new System.Drawing.Point(19, 170);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            this.gridProductos.RowHeadersWidth = 51;
            this.gridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductos.Size = new System.Drawing.Size(1111, 181);
            this.gridProductos.TabIndex = 61;
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
            this.nombreProducto.Width = 350;
            // 
            // descripcionProducto
            // 
            this.descripcionProducto.DataPropertyName = "descripcionProducto";
            this.descripcionProducto.HeaderText = "Descripcion";
            this.descripcionProducto.MinimumWidth = 6;
            this.descripcionProducto.Name = "descripcionProducto";
            this.descripcionProducto.ReadOnly = true;
            this.descripcionProducto.Width = 350;
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
            this.stockMinimo.Width = 80;
            // 
            // idCategoria
            // 
            this.idCategoria.DataPropertyName = "idCategoria";
            this.idCategoria.HeaderText = "ID Categoria";
            this.idCategoria.MinimumWidth = 6;
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            this.idCategoria.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(16, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 62;
            this.label3.Text = "Productos";
            // 
            // btnDeseleccionarProducto
            // 
            this.btnDeseleccionarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnDeseleccionarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeseleccionarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeseleccionarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnDeseleccionarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeseleccionarProducto.Location = new System.Drawing.Point(928, 127);
            this.btnDeseleccionarProducto.Name = "btnDeseleccionarProducto";
            this.btnDeseleccionarProducto.Size = new System.Drawing.Size(202, 37);
            this.btnDeseleccionarProducto.TabIndex = 63;
            this.btnDeseleccionarProducto.Text = "Deseleccionar";
            this.btnDeseleccionarProducto.UseVisualStyleBackColor = false;
            this.btnDeseleccionarProducto.Click += new System.EventHandler(this.btnDeseleccionarProducto_Click);
            // 
            // lblABM
            // 
            this.lblABM.AutoSize = true;
            this.lblABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblABM.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblABM.Location = new System.Drawing.Point(18, 360);
            this.lblABM.Name = "lblABM";
            this.lblABM.Size = new System.Drawing.Size(314, 26);
            this.lblABM.TabIndex = 67;
            this.lblABM.Text = "Estas agregando un producto...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtStockMinimo);
            this.panel1.Controls.Add(this.txtStock);
            this.panel1.Controls.Add(this.comboAgregarCategoria);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPrecioUnitario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 156);
            this.panel1.TabIndex = 66;
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStockMinimo.Location = new System.Drawing.Point(743, 83);
            this.txtStockMinimo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStockMinimo.Mask = "99999";
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(76, 26);
            this.txtStockMinimo.TabIndex = 71;
            this.txtStockMinimo.ValidatingType = typeof(int);
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStock.Location = new System.Drawing.Point(743, 13);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStock.Mask = "99999";
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(76, 26);
            this.txtStock.TabIndex = 70;
            this.txtStock.ValidatingType = typeof(int);
            // 
            // comboAgregarCategoria
            // 
            this.comboAgregarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboAgregarCategoria.FormattingEnabled = true;
            this.comboAgregarCategoria.Location = new System.Drawing.Point(743, 118);
            this.comboAgregarCategoria.Name = "comboAgregarCategoria";
            this.comboAgregarCategoria.ppDescriptorTablaCargar = "nombreCategoria";
            this.comboAgregarCategoria.ppNombreCampo = "nombreCategoria";
            this.comboAgregarCategoria.ppNombreTabla = "categoriasProductos";
            this.comboAgregarCategoria.ppNombreTablaCargar = "categoriasProductos";
            this.comboAgregarCategoria.ppPkTablaCargar = "idCategoria";
            this.comboAgregarCategoria.ppValidar = false;
            this.comboAgregarCategoria.Size = new System.Drawing.Size(207, 28);
            this.comboAgregarCategoria.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(658, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Categoria:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(684, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Stock:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescripcion.Location = new System.Drawing.Point(148, 48);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(451, 99);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(44, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Descripcion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(633, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Stock Minimo:";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrecioUnitario.Location = new System.Drawing.Point(743, 48);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(207, 26);
            this.txtPrecioUnitario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(627, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Precio Unitario:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(148, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(451, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(69, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre:";
            // 
            // iconAgregar
            // 
            this.iconAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.iconAgregar.BackgroundImage = global::LibreriaApollo.Properties.Resources.save_fill;
            this.iconAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconAgregar.Location = new System.Drawing.Point(967, 552);
            this.iconAgregar.Name = "iconAgregar";
            this.iconAgregar.Size = new System.Drawing.Size(30, 30);
            this.iconAgregar.TabIndex = 65;
            this.iconAgregar.TabStop = false;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCambios.Location = new System.Drawing.Point(964, 548);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(166, 41);
            this.btnGuardarCambios.TabIndex = 64;
            this.btnGuardarCambios.Text = "Agregar";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // comboCategorias
            // 
            this.comboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboCategorias.FormattingEnabled = true;
            this.comboCategorias.Location = new System.Drawing.Point(165, 109);
            this.comboCategorias.Name = "comboCategorias";
            this.comboCategorias.ppDescriptorTablaCargar = "nombreCategoria";
            this.comboCategorias.ppNombreCampo = "nombreCategoria";
            this.comboCategorias.ppNombreTabla = "categoriasProductos";
            this.comboCategorias.ppNombreTablaCargar = "categoriasProductos";
            this.comboCategorias.ppPkTablaCargar = "idCategoria";
            this.comboCategorias.ppValidar = false;
            this.comboCategorias.Size = new System.Drawing.Size(207, 28);
            this.comboCategorias.TabIndex = 59;
            this.comboCategorias.SelectedIndexChanged += new System.EventHandler(this.onComboCategoriasChanged);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.Location = new System.Drawing.Point(819, 548);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(139, 41);
            this.btnEliminarProducto.TabIndex = 68;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Visible = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1142, 601);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.lblABM);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconAgregar);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnDeseleccionarProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.btnDeseleccionarCategorias);
            this.Controls.Add(this.comboCategorias);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtFiltrarNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProductos";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Productos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFiltrarNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Entidades.ComboBox2 comboCategorias;
        private System.Windows.Forms.Button btnDeseleccionarCategorias;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeseleccionarProducto;
        private System.Windows.Forms.Label lblABM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox iconAgregar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private Entidades.ComboBox2 comboAgregarCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MaskedTextBox txtStock;
        private System.Windows.Forms.MaskedTextBox txtStockMinimo;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
    }
}