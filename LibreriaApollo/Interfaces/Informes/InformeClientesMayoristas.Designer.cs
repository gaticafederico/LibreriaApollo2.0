namespace LibreriaApollo.Interfaces.Informes
{
    partial class InformeClientesMayoristas
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
            this.informeClientesMay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // informeClientesMay
            // 
            this.informeClientesMay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informeClientesMay.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Informes.InformeClientesMayoristas.rdlc";
            this.informeClientesMay.Location = new System.Drawing.Point(0, 0);
            this.informeClientesMay.Name = "informeClientesMay";
            this.informeClientesMay.ServerReport.BearerToken = null;
            this.informeClientesMay.Size = new System.Drawing.Size(1264, 681);
            this.informeClientesMay.TabIndex = 0;
            this.informeClientesMay.Load += new System.EventHandler(this.LoadInformeClientesMay);
            // 
            // InformeClientesMayoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.informeClientesMay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InformeClientesMayoristas";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Clientes Mayoristas";
            this.Load += new System.EventHandler(this.InformeClientesMayoristas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer informeClientesMay;
    }
}