namespace LibreriaApollo.Interfaces
{
    partial class frmMayoristas
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
            this.btnDeseleccionar = new System.Windows.Forms.Button();
            this.txtFiltrarNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblABM = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtNroCalle = new System.Windows.Forms.MaskedTextBox();
            this.txtCodPostal = new System.Windows.Forms.MaskedTextBox();
            this.txtNroDocumento = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboDocumento = new LibreriaApollo.Entidades.ComboBox2();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gridMayoristas = new System.Windows.Forms.DataGridView();
            this.nroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumento2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtFiltrarNroDocumento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMayoristas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeseleccionar
            // 
            this.btnDeseleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnDeseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeseleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnDeseleccionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnDeseleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeseleccionar.Location = new System.Drawing.Point(757, 139);
            this.btnDeseleccionar.Name = "btnDeseleccionar";
            this.btnDeseleccionar.Size = new System.Drawing.Size(202, 37);
            this.btnDeseleccionar.TabIndex = 57;
            this.btnDeseleccionar.Text = "Deseleccionar";
            this.btnDeseleccionar.UseVisualStyleBackColor = false;
            this.btnDeseleccionar.Click += new System.EventHandler(this.btnDeseleccionar_Click);
            // 
            // txtFiltrarNombre
            // 
            this.txtFiltrarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFiltrarNombre.Location = new System.Drawing.Point(162, 63);
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
            this.label11.Location = new System.Drawing.Point(81, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(20, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 26);
            this.label10.TabIndex = 56;
            this.label10.Text = "Filtrar";
            // 
            // lblABM
            // 
            this.lblABM.AutoSize = true;
            this.lblABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblABM.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblABM.Location = new System.Drawing.Point(18, 367);
            this.lblABM.Name = "lblABM";
            this.lblABM.Size = new System.Drawing.Size(434, 26);
            this.lblABM.TabIndex = 66;
            this.lblABM.Text = "Estas creando un nuevo cliente mayorista...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtNroCalle);
            this.panel1.Controls.Add(this.txtCodPostal);
            this.panel1.Controls.Add(this.txtNroDocumento);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboDocumento);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtCalle);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 202);
            this.panel1.TabIndex = 65;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTelefono.Location = new System.Drawing.Point(492, 123);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono.Mask = "9999999999";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(207, 26);
            this.txtTelefono.TabIndex = 74;
            this.txtTelefono.ValidatingType = typeof(int);
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNroCalle.Location = new System.Drawing.Point(147, 118);
            this.txtNroCalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNroCalle.Mask = "99999";
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(76, 26);
            this.txtNroCalle.TabIndex = 73;
            this.txtNroCalle.ValidatingType = typeof(int);
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodPostal.Location = new System.Drawing.Point(147, 155);
            this.txtCodPostal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodPostal.Mask = "9999";
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(76, 26);
            this.txtCodPostal.TabIndex = 72;
            this.txtCodPostal.ValidatingType = typeof(int);
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNroDocumento.Location = new System.Drawing.Point(492, 47);
            this.txtNroDocumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNroDocumento.Mask = "99999999";
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(207, 26);
            this.txtNroDocumento.TabIndex = 70;
            this.txtNroDocumento.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(409, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Telefono:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(492, 82);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 26);
            this.txtEmail.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(433, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(374, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "N° Documento:";
            // 
            // comboDocumento
            // 
            this.comboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboDocumento.FormattingEnabled = true;
            this.comboDocumento.Location = new System.Drawing.Point(492, 12);
            this.comboDocumento.Name = "comboDocumento";
            this.comboDocumento.ppDescriptorTablaCargar = "nombreTipoDoc";
            this.comboDocumento.ppNombreCampo = "nombreTipoDoc";
            this.comboDocumento.ppNombreTabla = "tipoDocumento";
            this.comboDocumento.ppNombreTablaCargar = "tipoDocumento";
            this.comboDocumento.ppPkTablaCargar = "idTipoDoc";
            this.comboDocumento.ppValidar = false;
            this.comboDocumento.Size = new System.Drawing.Size(207, 28);
            this.comboDocumento.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(392, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 20);
            this.label13.TabIndex = 47;
            this.label13.Text = "Documento:";
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCalle.Location = new System.Drawing.Point(147, 82);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(207, 26);
            this.txtCalle.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(93, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Calle:";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtApellido.Location = new System.Drawing.Point(147, 47);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(207, 26);
            this.txtApellido.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(74, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Apellido:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(54, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Cod Postal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(72, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "N° Calle:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(147, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(207, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(74, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.pictureBox3.BackgroundImage = global::LibreriaApollo.Properties.Resources.save_fill;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(797, 608);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCambios.Location = new System.Drawing.Point(794, 604);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(166, 41);
            this.btnGuardarCambios.TabIndex = 59;
            this.btnGuardarCambios.Text = "Crear";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(19, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 26);
            this.label3.TabIndex = 63;
            this.label3.Text = "Mayoristas";
            // 
            // gridMayoristas
            // 
            this.gridMayoristas.AllowUserToAddRows = false;
            this.gridMayoristas.AllowUserToDeleteRows = false;
            this.gridMayoristas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMayoristas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroCliente,
            this.nombre,
            this.apellido,
            this.calle,
            this.nroCalle,
            this.codPostal,
            this.tipoDocumento,
            this.nroDocumento,
            this.email,
            this.telefono,
            this.tipoDocumento2});
            this.gridMayoristas.Location = new System.Drawing.Point(16, 182);
            this.gridMayoristas.MultiSelect = false;
            this.gridMayoristas.Name = "gridMayoristas";
            this.gridMayoristas.ReadOnly = true;
            this.gridMayoristas.RowHeadersWidth = 51;
            this.gridMayoristas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMayoristas.Size = new System.Drawing.Size(944, 179);
            this.gridMayoristas.TabIndex = 62;
            this.gridMayoristas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onGridMayoristasClick);
            // 
            // nroCliente
            // 
            this.nroCliente.DataPropertyName = "nroCliente";
            this.nroCliente.HeaderText = "N° Cliente";
            this.nroCliente.MinimumWidth = 6;
            this.nroCliente.Name = "nroCliente";
            this.nroCliente.ReadOnly = true;
            this.nroCliente.Width = 50;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 125;
            // 
            // calle
            // 
            this.calle.DataPropertyName = "calle";
            this.calle.HeaderText = "Calle";
            this.calle.MinimumWidth = 6;
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            this.calle.Width = 125;
            // 
            // nroCalle
            // 
            this.nroCalle.DataPropertyName = "nroCalle";
            this.nroCalle.HeaderText = "N° Calle";
            this.nroCalle.MinimumWidth = 6;
            this.nroCalle.Name = "nroCalle";
            this.nroCalle.ReadOnly = true;
            this.nroCalle.Width = 50;
            // 
            // codPostal
            // 
            this.codPostal.DataPropertyName = "codPostal";
            this.codPostal.HeaderText = "Codigo Postal";
            this.codPostal.MinimumWidth = 6;
            this.codPostal.Name = "codPostal";
            this.codPostal.ReadOnly = true;
            this.codPostal.Width = 125;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.DataPropertyName = "nombreTipoDoc";
            this.tipoDocumento.HeaderText = "Documento";
            this.tipoDocumento.MinimumWidth = 6;
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.ReadOnly = true;
            this.tipoDocumento.Width = 125;
            // 
            // nroDocumento
            // 
            this.nroDocumento.DataPropertyName = "nroDocumento";
            this.nroDocumento.HeaderText = "N° Documento";
            this.nroDocumento.MinimumWidth = 6;
            this.nroDocumento.Name = "nroDocumento";
            this.nroDocumento.ReadOnly = true;
            this.nroDocumento.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // tipoDocumento2
            // 
            this.tipoDocumento2.DataPropertyName = "tipoDocumento";
            this.tipoDocumento2.HeaderText = "Tipo Documento";
            this.tipoDocumento2.MinimumWidth = 6;
            this.tipoDocumento2.Name = "tipoDocumento2";
            this.tipoDocumento2.ReadOnly = true;
            this.tipoDocumento2.Visible = false;
            this.tipoDocumento2.Width = 125;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LibreriaApollo.Properties.Resources.ApolloLogo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(714, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 60);
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // txtFiltrarNroDocumento
            // 
            this.txtFiltrarNroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFiltrarNroDocumento.Location = new System.Drawing.Point(162, 98);
            this.txtFiltrarNroDocumento.Name = "txtFiltrarNroDocumento";
            this.txtFiltrarNroDocumento.Size = new System.Drawing.Size(207, 26);
            this.txtFiltrarNroDocumento.TabIndex = 67;
            this.txtFiltrarNroDocumento.TextChanged += new System.EventHandler(this.onTxtFiltrarNroDocumentoChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(33, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 20);
            this.label12.TabIndex = 68;
            this.label12.Text = "N° Documento:";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.Location = new System.Drawing.Point(649, 604);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(139, 41);
            this.btnEliminarProducto.TabIndex = 69;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmMayoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(975, 662);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.txtFiltrarNroDocumento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDeseleccionar);
            this.Controls.Add(this.txtFiltrarNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblABM);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridMayoristas);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMayoristas";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Mayoristas";
            this.Load += new System.EventHandler(this.onFrmLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMayoristas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeseleccionar;
        private System.Windows.Forms.TextBox txtFiltrarNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblABM;
        private System.Windows.Forms.Panel panel1;
        private Entidades.ComboBox2 comboDocumento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridMayoristas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtFiltrarNroDocumento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumento2;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.MaskedTextBox txtNroCalle;
        private System.Windows.Forms.MaskedTextBox txtCodPostal;
        private System.Windows.Forms.MaskedTextBox txtNroDocumento;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}