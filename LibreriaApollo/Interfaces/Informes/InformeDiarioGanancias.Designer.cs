namespace LibreriaApollo.Interfaces.Informes
{
    partial class InformeDiarioGanancias
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
            this.informeDiarioGanan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // informeDiarioGanan
            // 
            this.informeDiarioGanan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informeDiarioGanan.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Informes.InformeDiarioGanancias.rdlc";
            this.informeDiarioGanan.Location = new System.Drawing.Point(0, 70);
            this.informeDiarioGanan.Name = "informeDiarioGanan";
            this.informeDiarioGanan.ServerReport.BearerToken = null;
            this.informeDiarioGanan.Size = new System.Drawing.Size(1264, 611);
            this.informeDiarioGanan.TabIndex = 0;
            this.informeDiarioGanan.Load += new System.EventHandler(this.loadInformeDiarioGanan);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.Location = new System.Drawing.Point(249, 14);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(149, 37);
            this.btnConsultar.TabIndex = 71;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.consultar);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(63, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFecha.Location = new System.Drawing.Point(128, 20);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(87, 26);
            this.txtFecha.TabIndex = 69;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // InformeDiarioGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.informeDiarioGanan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InformeDiarioGanancias";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Ganancias Diarias";
            this.Load += new System.EventHandler(this.InformeDiarioGanancias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer informeDiarioGanan;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtFecha;
    }
}