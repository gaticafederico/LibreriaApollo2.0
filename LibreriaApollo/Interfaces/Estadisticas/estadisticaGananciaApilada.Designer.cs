namespace LibreriaApollo.Interfaces.Estadisticas
{
    partial class estadisticaGananciaApilada
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
            this.estadGananciaApilada = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // estadGananciaApilada
            // 
            this.estadGananciaApilada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.estadGananciaApilada.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Estadisticas.estadisticaGananciaApilada.rdlc";
            this.estadGananciaApilada.Location = new System.Drawing.Point(0, 0);
            this.estadGananciaApilada.Name = "estadGananciaApilada";
            this.estadGananciaApilada.ServerReport.BearerToken = null;
            this.estadGananciaApilada.Size = new System.Drawing.Size(1264, 681);
            this.estadGananciaApilada.TabIndex = 0;
            this.estadGananciaApilada.Load += new System.EventHandler(this.loadEstadGananciaApilada);
            // 
            // estadisticaGananciaApilada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.estadGananciaApilada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "estadisticaGananciaApilada";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Cantidad de Ventas por Tipo de Pago";
            this.Load += new System.EventHandler(this.estadisticaGananciaApilada_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer estadGananciaApilada;
    }
}