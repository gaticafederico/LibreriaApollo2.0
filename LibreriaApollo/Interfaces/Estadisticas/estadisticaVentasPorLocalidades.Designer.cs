namespace LibreriaApollo.Interfaces.Estadisticas
{
    partial class estadisticaVentasPorLocalidades
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
            this.estadVentasPorLocalidades = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // estadVentasPorLocalidades
            // 
            this.estadVentasPorLocalidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.estadVentasPorLocalidades.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Estadisticas.estadisticaVentasPorLocalidades.rdlc";
            this.estadVentasPorLocalidades.Location = new System.Drawing.Point(0, 0);
            this.estadVentasPorLocalidades.Name = "estadVentasPorLocalidades";
            this.estadVentasPorLocalidades.ServerReport.BearerToken = null;
            this.estadVentasPorLocalidades.Size = new System.Drawing.Size(1264, 681);
            this.estadVentasPorLocalidades.TabIndex = 0;
            this.estadVentasPorLocalidades.Load += new System.EventHandler(this.loadEstadVentasPorLocalidades);
            // 
            // estadisticaVentasPorLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.estadVentasPorLocalidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "estadisticaVentasPorLocalidades";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Porcentaje Ventas por Localidades";
            this.Load += new System.EventHandler(this.estadisticaVentasPorLocalidades_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer estadVentasPorLocalidades;
    }
}