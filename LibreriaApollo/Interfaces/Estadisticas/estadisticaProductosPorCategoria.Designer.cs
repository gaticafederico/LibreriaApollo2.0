namespace LibreriaApollo.Interfaces.Estadisticas
{
    partial class estadisticaProductosPorCategoria
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
            this.estadProductosPorCategoria = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // estadProductosPorCategoria
            // 
            this.estadProductosPorCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.estadProductosPorCategoria.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Estadisticas.estadisticaProductosPorCategoria.rdlc";
            this.estadProductosPorCategoria.Location = new System.Drawing.Point(0, 0);
            this.estadProductosPorCategoria.Name = "estadProductosPorCategoria";
            this.estadProductosPorCategoria.ServerReport.BearerToken = null;
            this.estadProductosPorCategoria.Size = new System.Drawing.Size(1264, 681);
            this.estadProductosPorCategoria.TabIndex = 0;
            this.estadProductosPorCategoria.Load += new System.EventHandler(this.loadEstadProductosPorCategoria);
            // 
            // estadisticaProductosPorCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.estadProductosPorCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "estadisticaProductosPorCategoria";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Porcentaje Productos por Categoria";
            this.Load += new System.EventHandler(this.estadisticaProductosPorCategoria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer estadProductosPorCategoria;
    }
}