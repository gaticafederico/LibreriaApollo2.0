namespace LibreriaApollo.Interfaces.Informes
{
    partial class InformeProductosMasVendidos
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
            this.informeProdMasVendidos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // informeProdMasVendidos
            // 
            this.informeProdMasVendidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informeProdMasVendidos.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Informes.InformeProductosMasVendidos.rdlc";
            this.informeProdMasVendidos.Location = new System.Drawing.Point(0, 0);
            this.informeProdMasVendidos.Name = "informeProdMasVendidos";
            this.informeProdMasVendidos.ServerReport.BearerToken = null;
            this.informeProdMasVendidos.Size = new System.Drawing.Size(1264, 681);
            this.informeProdMasVendidos.TabIndex = 0;
            this.informeProdMasVendidos.Load += new System.EventHandler(this.loadInformeProdMasVendidos);
            // 
            // InformeProductosMasVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.informeProdMasVendidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InformeProductosMasVendidos";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Productos Mas Vendidos";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer informeProdMasVendidos;
    }
}