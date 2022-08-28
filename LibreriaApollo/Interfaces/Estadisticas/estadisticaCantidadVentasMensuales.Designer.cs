namespace LibreriaApollo.Interfaces.Estadisticas
{
    partial class estadisticaCantidadVentasMensuales
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
            this.estadCantidadVentasMensuales = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // estadCantidadVentasMensuales
            // 
            this.estadCantidadVentasMensuales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.estadCantidadVentasMensuales.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Estadisticas.estadisticaCantidadVentasMensuales.rdlc";
            this.estadCantidadVentasMensuales.Location = new System.Drawing.Point(0, 57);
            this.estadCantidadVentasMensuales.Name = "estadCantidadVentasMensuales";
            this.estadCantidadVentasMensuales.ServerReport.BearerToken = null;
            this.estadCantidadVentasMensuales.Size = new System.Drawing.Size(1264, 624);
            this.estadCantidadVentasMensuales.TabIndex = 0;
            this.estadCantidadVentasMensuales.Load += new System.EventHandler(this.estadCantidadVentasMensuales_Load);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.Location = new System.Drawing.Point(378, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(149, 39);
            this.btnConsultar.TabIndex = 71;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.consultar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(210, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Año:";
            // 
            // txtAnio
            // 
            this.txtAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAnio.Location = new System.Drawing.Point(257, 19);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnio.Mask = "9999";
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(76, 26);
            this.txtAnio.TabIndex = 69;
            this.txtAnio.ValidatingType = typeof(int);
            // 
            // estadisticaCantidadVentasMensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.estadCantidadVentasMensuales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "estadisticaCantidadVentasMensuales";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Cantidad Ventas Por Mes";
            this.Load += new System.EventHandler(this.estadisticaCantidadVentasMensuales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer estadCantidadVentasMensuales;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtAnio;
    }
}