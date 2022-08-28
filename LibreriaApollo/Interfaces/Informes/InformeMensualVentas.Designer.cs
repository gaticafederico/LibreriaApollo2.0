namespace LibreriaApollo.Interfaces.Informes
{
    partial class InformeMensualVentas
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
            this.informeMensVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtMes = new System.Windows.Forms.MaskedTextBox();
            this.txtAnio = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // informeMensVentas
            // 
            this.informeMensVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informeMensVentas.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Informes.InformeMensualVentas.rdlc";
            this.informeMensVentas.Location = new System.Drawing.Point(2, 52);
            this.informeMensVentas.Name = "informeMensVentas";
            this.informeMensVentas.ServerReport.BearerToken = null;
            this.informeMensVentas.Size = new System.Drawing.Size(1261, 628);
            this.informeMensVentas.TabIndex = 2;
            // 
            // txtMes
            // 
            this.txtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMes.Location = new System.Drawing.Point(112, 14);
            this.txtMes.Margin = new System.Windows.Forms.Padding(2);
            this.txtMes.Mask = "99";
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(76, 26);
            this.txtMes.TabIndex = 64;
            this.txtMes.ValidatingType = typeof(int);
            // 
            // txtAnio
            // 
            this.txtAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAnio.Location = new System.Drawing.Point(255, 14);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnio.Mask = "9999";
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(76, 26);
            this.txtAnio.TabIndex = 65;
            this.txtAnio.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(208, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(64, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Mes:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.Location = new System.Drawing.Point(376, 7);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(149, 39);
            this.btnConsultar.TabIndex = 68;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.consultarVentasMensuales);
            // 
            // InformeMensualVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.informeMensVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InformeMensualVentas";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Ventas Mensuales";
            this.Load += new System.EventHandler(this.InformeMensualVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer informeMensVentas;
        private System.Windows.Forms.MaskedTextBox txtMes;
        private System.Windows.Forms.MaskedTextBox txtAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultar;
    }
}