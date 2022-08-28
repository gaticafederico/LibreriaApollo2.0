namespace LibreriaApollo.Interfaces.Informes
{
    partial class InformeProductosFaltantes
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
            this.informeProdFaltantes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // informeProdFaltantes
            // 
            this.informeProdFaltantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informeProdFaltantes.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Informes.InformeProductosFaltantes.rdlc";
            this.informeProdFaltantes.Location = new System.Drawing.Point(0, 0);
            this.informeProdFaltantes.Name = "informeProdFaltantes";
            this.informeProdFaltantes.ServerReport.BearerToken = null;
            this.informeProdFaltantes.Size = new System.Drawing.Size(1264, 681);
            this.informeProdFaltantes.TabIndex = 0;
            this.informeProdFaltantes.Load += new System.EventHandler(this.loadInformeProdFaltantes);
            // 
            // InformeProductosFaltantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.informeProdFaltantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InformeProductosFaltantes";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Productos Faltantes";
            this.Load += new System.EventHandler(this.InformeProductosFaltantes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer informeProdFaltantes;
    }
}