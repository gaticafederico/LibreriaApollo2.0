namespace LibreriaApollo.Interfaces.Informes
{
    partial class InformeProductosMenosVendidos
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
            this.informeProdMenosVendidos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // informeProdMenosVendidos
            // 
            this.informeProdMenosVendidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informeProdMenosVendidos.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Informes.InformeProductosMenosVendidos.rdlc";
            this.informeProdMenosVendidos.Location = new System.Drawing.Point(0, 0);
            this.informeProdMenosVendidos.Name = "informeProdMenosVendidos";
            this.informeProdMenosVendidos.ServerReport.BearerToken = null;
            this.informeProdMenosVendidos.Size = new System.Drawing.Size(1264, 681);
            this.informeProdMenosVendidos.TabIndex = 0;
            this.informeProdMenosVendidos.Load += new System.EventHandler(this.loadInformeProdMenosVendidos);
            // 
            // InformeProductosMenosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.informeProdMenosVendidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InformeProductosMenosVendidos";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Productos Menos Vendidos";
            this.Load += new System.EventHandler(this.InformeProductosMenosVendidos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer informeProdMenosVendidos;
    }
}