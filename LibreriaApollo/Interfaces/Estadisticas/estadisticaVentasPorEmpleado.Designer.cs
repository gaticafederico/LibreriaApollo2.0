namespace LibreriaApollo.Interfaces.Estadisticas
{
    partial class estadisticaVentasPorEmpleado
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
            this.estadVentasPorEmpleado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.cmbEmpleados = new LibreriaApollo.Entidades.ComboBox2();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // estadVentasPorEmpleado
            // 
            this.estadVentasPorEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.estadVentasPorEmpleado.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Estadisticas.estadisticaVentasPorEmpleado.rdlc";
            this.estadVentasPorEmpleado.Location = new System.Drawing.Point(0, 96);
            this.estadVentasPorEmpleado.Name = "estadVentasPorEmpleado";
            this.estadVentasPorEmpleado.ServerReport.BearerToken = null;
            this.estadVentasPorEmpleado.Size = new System.Drawing.Size(1265, 587);
            this.estadVentasPorEmpleado.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.Location = new System.Drawing.Point(662, 8);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(186, 39);
            this.btnConsultar.TabIndex = 78;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.consultar);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(455, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Mes:";
            // 
            // txtMes
            // 
            this.txtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMes.Location = new System.Drawing.Point(502, 15);
            this.txtMes.Margin = new System.Windows.Forms.Padding(2);
            this.txtMes.Mask = "99";
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(26, 26);
            this.txtMes.TabIndex = 81;
            this.txtMes.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(554, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "Año:";
            // 
            // txtAnio
            // 
            this.txtAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAnio.Location = new System.Drawing.Point(601, 15);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnio.Mask = "9999";
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(44, 26);
            this.txtAnio.TabIndex = 79;
            this.txtAnio.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(25, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "Empleado:";
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(308, 15);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(30, 30);
            this.btnAgregarEmpleado.TabIndex = 85;
            this.btnAgregarEmpleado.Text = "+";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = false;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.agregarEmpleado);
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmpleados.Location = new System.Drawing.Point(232, 59);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(103, 20);
            this.lblEmpleados.TabIndex = 86;
            this.lblEmpleados.Text = "Empleados,";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarCampos.Location = new System.Drawing.Point(866, 8);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(186, 39);
            this.btnLimpiarCampos.TabIndex = 87;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.limpiarCampos);
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(114, 15);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.ppDescriptorTablaCargar = "nombre";
            this.cmbEmpleados.ppNombreCampo = "nombre";
            this.cmbEmpleados.ppNombreTabla = "empleados";
            this.cmbEmpleados.ppNombreTablaCargar = "empleados";
            this.cmbEmpleados.ppPkTablaCargar = "idEmpleado";
            this.cmbEmpleados.ppValidar = false;
            this.cmbEmpleados.Size = new System.Drawing.Size(187, 28);
            this.cmbEmpleados.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(25, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 20);
            this.label4.TabIndex = 88;
            this.label4.Text = "Empleados Seleccionados:";
            // 
            // estadisticaVentasPorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.estadVentasPorEmpleado);
            this.Name = "estadisticaVentasPorEmpleado";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Cantidad Ventas Por Empleado";
            this.Load += new System.EventHandler(this.estadisticaVentasPorEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer estadVentasPorEmpleado;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtAnio;
        private System.Windows.Forms.Label label3;
        private Entidades.ComboBox2 cmbEmpleados;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Label label4;
    }
}