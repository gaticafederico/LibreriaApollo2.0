namespace LibreriaApollo.Interfaces.Estadisticas
{
    partial class estadisticaClientesPorLocalidades
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
            this.estadClientesPorLocalidades = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // estadClientesPorLocalidades
            // 
            this.estadClientesPorLocalidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.estadClientesPorLocalidades.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Estadisticas.estadisticaClientesPorLocalidades.rdlc";
            this.estadClientesPorLocalidades.Location = new System.Drawing.Point(0, 0);
            this.estadClientesPorLocalidades.Name = "estadClientesPorLocalidades";
            this.estadClientesPorLocalidades.ServerReport.BearerToken = null;
            this.estadClientesPorLocalidades.Size = new System.Drawing.Size(1264, 681);
            this.estadClientesPorLocalidades.TabIndex = 0;
            this.estadClientesPorLocalidades.Load += new System.EventHandler(this.loadEstadClientesPorLocalidades);
            // 
            // estadisticaClientesPorLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.estadClientesPorLocalidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "estadisticaClientesPorLocalidades";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Porcentaje Clientes por Localidades";
            this.Load += new System.EventHandler(this.estadisticaClientesPorLocalidades_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer estadClientesPorLocalidades;
    }
}