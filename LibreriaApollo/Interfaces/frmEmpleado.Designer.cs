namespace LibreriaApollo.Interfaces
{
    partial class frmEmpleado
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
            this.gridEmpleados = new System.Windows.Forms.DataGridView();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividad = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFechaNac = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaIng = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboPerfiles = new LibreriaApollo.Entidades.ComboBox2();
            this.label13 = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioGuardarInactivo = new System.Windows.Forms.RadioButton();
            this.radioGuardarActivo = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblABM = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFiltrarUsuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.radioInactivos = new System.Windows.Forms.RadioButton();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.radioActivos = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeseleccionar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEmpleados
            // 
            this.gridEmpleados.AllowUserToAddRows = false;
            this.gridEmpleados.AllowUserToDeleteRows = false;
            this.gridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleado,
            this.usuario,
            this.nombre,
            this.apellido,
            this.fechaNacimiento,
            this.fechaIngreso,
            this.actividad});
            this.gridEmpleados.Location = new System.Drawing.Point(12, 183);
            this.gridEmpleados.MultiSelect = false;
            this.gridEmpleados.Name = "gridEmpleados";
            this.gridEmpleados.ReadOnly = true;
            this.gridEmpleados.RowHeadersWidth = 51;
            this.gridEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmpleados.Size = new System.Drawing.Size(696, 179);
            this.gridEmpleados.TabIndex = 4;
            this.gridEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onGridEmpleadosClick);
            // 
            // idEmpleado
            // 
            this.idEmpleado.DataPropertyName = "idEmpleado";
            this.idEmpleado.HeaderText = "ID";
            this.idEmpleado.MinimumWidth = 6;
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            this.idEmpleado.Width = 125;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "Usuario";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 125;
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
            // fechaNacimiento
            // 
            this.fechaNacimiento.DataPropertyName = "fechaNacimiento";
            this.fechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.fechaNacimiento.MinimumWidth = 6;
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            this.fechaNacimiento.Width = 125;
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.DataPropertyName = "fechaIngreso";
            this.fechaIngreso.HeaderText = "Fecha Ingreso";
            this.fechaIngreso.MinimumWidth = 6;
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.ReadOnly = true;
            this.fechaIngreso.Width = 125;
            // 
            // actividad
            // 
            this.actividad.DataPropertyName = "sigueTrabajando";
            this.actividad.HeaderText = "Actividad";
            this.actividad.MinimumWidth = 6;
            this.actividad.Name = "actividad";
            this.actividad.ReadOnly = true;
            this.actividad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.actividad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.actividad.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(10, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Empleados";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCambios.Location = new System.Drawing.Point(542, 621);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(166, 41);
            this.btnGuardarCambios.TabIndex = 1;
            this.btnGuardarCambios.Text = "Crear";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.onGuardarCambios);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(105, 118);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(207, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(24, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsuario.Location = new System.Drawing.Point(105, 13);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(207, 26);
            this.txtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(351, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Fecha Ingreso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(322, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fecha Nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(410, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Activo:";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtApellido.Location = new System.Drawing.Point(105, 153);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(207, 26);
            this.txtApellido.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(26, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Apellido:";
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFechaNac.Location = new System.Drawing.Point(475, 45);
            this.txtFechaNac.Mask = "00/00/0000";
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(93, 26);
            this.txtFechaNac.TabIndex = 5;
            this.txtFechaNac.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaIng
            // 
            this.txtFechaIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFechaIng.Location = new System.Drawing.Point(474, 81);
            this.txtFechaIng.Mask = "00/00/0000";
            this.txtFechaIng.Name = "txtFechaIng";
            this.txtFechaIng.Size = new System.Drawing.Size(94, 26);
            this.txtFechaIng.TabIndex = 6;
            this.txtFechaIng.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboPerfiles);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtConfirmar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtFechaIng);
            this.panel1.Controls.Add(this.txtFechaNac);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 218);
            this.panel1.TabIndex = 40;
            // 
            // comboPerfiles
            // 
            this.comboPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPerfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboPerfiles.FormattingEnabled = true;
            this.comboPerfiles.Location = new System.Drawing.Point(474, 118);
            this.comboPerfiles.Name = "comboPerfiles";
            this.comboPerfiles.ppDescriptorTablaCargar = "nombrePerfil";
            this.comboPerfiles.ppNombreCampo = "nombrePerfil";
            this.comboPerfiles.ppNombreTabla = "perfil";
            this.comboPerfiles.ppNombreTablaCargar = "perfil";
            this.comboPerfiles.ppPkTablaCargar = "idPerfil";
            this.comboPerfiles.ppValidar = false;
            this.comboPerfiles.Size = new System.Drawing.Size(207, 28);
            this.comboPerfiles.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(417, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 47;
            this.label13.Text = "Perfil:";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtConfirmar.Location = new System.Drawing.Point(105, 83);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.Size = new System.Drawing.Size(207, 26);
            this.txtConfirmar.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(11, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Confirmar:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(105, 48);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(207, 26);
            this.txtPassword.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(0, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Contraseña:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioGuardarInactivo);
            this.panel2.Controls.Add(this.radioGuardarActivo);
            this.panel2.Location = new System.Drawing.Point(474, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 29);
            this.panel2.TabIndex = 42;
            // 
            // radioGuardarInactivo
            // 
            this.radioGuardarInactivo.AutoSize = true;
            this.radioGuardarInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioGuardarInactivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioGuardarInactivo.Location = new System.Drawing.Point(47, 1);
            this.radioGuardarInactivo.Name = "radioGuardarInactivo";
            this.radioGuardarInactivo.Size = new System.Drawing.Size(47, 24);
            this.radioGuardarInactivo.TabIndex = 1;
            this.radioGuardarInactivo.Text = "No";
            this.radioGuardarInactivo.UseVisualStyleBackColor = true;
            // 
            // radioGuardarActivo
            // 
            this.radioGuardarActivo.AutoSize = true;
            this.radioGuardarActivo.Checked = true;
            this.radioGuardarActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioGuardarActivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioGuardarActivo.Location = new System.Drawing.Point(7, 1);
            this.radioGuardarActivo.Name = "radioGuardarActivo";
            this.radioGuardarActivo.Size = new System.Drawing.Size(41, 24);
            this.radioGuardarActivo.TabIndex = 0;
            this.radioGuardarActivo.TabStop = true;
            this.radioGuardarActivo.Text = "Si";
            this.radioGuardarActivo.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.pictureBox3.BackgroundImage = global::LibreriaApollo.Properties.Resources.save_fill;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(545, 625);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LibreriaApollo.Properties.Resources.ApolloLogo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(461, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 60);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblABM
            // 
            this.lblABM.AutoSize = true;
            this.lblABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblABM.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblABM.Location = new System.Drawing.Point(11, 371);
            this.lblABM.Name = "lblABM";
            this.lblABM.Size = new System.Drawing.Size(341, 26);
            this.lblABM.TabIndex = 41;
            this.lblABM.Text = "Estas creando un nuevo usuario...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(12, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "Filtrar";
            // 
            // txtFiltrarUsuario
            // 
            this.txtFiltrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFiltrarUsuario.Location = new System.Drawing.Point(155, 60);
            this.txtFiltrarUsuario.Name = "txtFiltrarUsuario";
            this.txtFiltrarUsuario.Size = new System.Drawing.Size(207, 26);
            this.txtFiltrarUsuario.TabIndex = 0;
            this.txtFiltrarUsuario.TextChanged += new System.EventHandler(this.OnTxtFiltarNombre);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(72, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nombre:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(83, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Estado:";
            // 
            // radioInactivos
            // 
            this.radioInactivos.AutoSize = true;
            this.radioInactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioInactivos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioInactivos.Location = new System.Drawing.Point(161, 8);
            this.radioInactivos.Name = "radioInactivos";
            this.radioInactivos.Size = new System.Drawing.Size(90, 24);
            this.radioInactivos.TabIndex = 2;
            this.radioInactivos.Text = "Inactivos";
            this.radioInactivos.UseVisualStyleBackColor = true;
            this.radioInactivos.CheckedChanged += new System.EventHandler(this.onRadioInactivoChanged);
            // 
            // radioTodos
            // 
            this.radioTodos.AutoSize = true;
            this.radioTodos.Checked = true;
            this.radioTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioTodos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioTodos.Location = new System.Drawing.Point(4, 8);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(71, 24);
            this.radioTodos.TabIndex = 0;
            this.radioTodos.TabStop = true;
            this.radioTodos.Text = "Todos";
            this.radioTodos.UseVisualStyleBackColor = true;
            this.radioTodos.CheckedChanged += new System.EventHandler(this.onRadioEstadoChanged);
            // 
            // radioActivos
            // 
            this.radioActivos.AutoSize = true;
            this.radioActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioActivos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioActivos.Location = new System.Drawing.Point(80, 8);
            this.radioActivos.Name = "radioActivos";
            this.radioActivos.Size = new System.Drawing.Size(78, 24);
            this.radioActivos.TabIndex = 1;
            this.radioActivos.Text = "Activos";
            this.radioActivos.UseVisualStyleBackColor = true;
            this.radioActivos.CheckedChanged += new System.EventHandler(this.onRadioActivoChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioTodos);
            this.panel3.Controls.Add(this.radioInactivos);
            this.panel3.Controls.Add(this.radioActivos);
            this.panel3.Location = new System.Drawing.Point(155, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 40);
            this.panel3.TabIndex = 54;
            // 
            // btnDeseleccionar
            // 
            this.btnDeseleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnDeseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeseleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnDeseleccionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnDeseleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeseleccionar.Location = new System.Drawing.Point(504, 140);
            this.btnDeseleccionar.Name = "btnDeseleccionar";
            this.btnDeseleccionar.Size = new System.Drawing.Size(202, 37);
            this.btnDeseleccionar.TabIndex = 1;
            this.btnDeseleccionar.Text = "Deseleccionar";
            this.btnDeseleccionar.UseVisualStyleBackColor = false;
            this.btnDeseleccionar.Click += new System.EventHandler(this.onDeseleccionar);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(723, 668);
            this.Controls.Add(this.btnDeseleccionar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtFiltrarUsuario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblABM);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridEmpleados);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEmpleado";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Empleados";
            this.Load += new System.EventHandler(this.onFrmLoad);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView gridEmpleados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtFechaNac;
        private System.Windows.Forms.MaskedTextBox txtFechaIng;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioGuardarInactivo;
        private System.Windows.Forms.RadioButton radioGuardarActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngreso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn actividad;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblABM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFiltrarUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioInactivos;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.RadioButton radioActivos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeseleccionar;
        private System.Windows.Forms.Label label13;
        private Entidades.ComboBox2 comboPerfiles;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}