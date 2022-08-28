namespace LibreriaApollo.Interfaces.Informes
{
    partial class InformeTotalVentasPorCategorias
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
            this.InformeTotalVentasPorCat = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // InformeTotalVentasPorCat
            // 
            this.InformeTotalVentasPorCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformeTotalVentasPorCat.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Informes.InformeTotalVentasPorCategorias.rdlc";
            this.InformeTotalVentasPorCat.Location = new System.Drawing.Point(0, 0);
            this.InformeTotalVentasPorCat.Name = "InformeTotalVentasPorCat";
            this.InformeTotalVentasPorCat.ServerReport.BearerToken = null;
            this.InformeTotalVentasPorCat.Size = new System.Drawing.Size(1264, 681);
            this.InformeTotalVentasPorCat.TabIndex = 0;
            this.InformeTotalVentasPorCat.Load += new System.EventHandler(this.LoadInformeTotalVentasPorCat);
            // 
            // InformeTotalVentasPorCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.InformeTotalVentasPorCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InformeTotalVentasPorCategorias";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Ventas por Categoria";
            this.Load += new System.EventHandler(this.InformeTotalVentasPorCategorias_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer InformeTotalVentasPorCat;
    }
}