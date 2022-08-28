namespace LibreriaApollo.Interfaces.Informes
{
    partial class InformeEmpleados
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
            this.informeEmplead = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // informeEmplead
            // 
            this.informeEmplead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informeEmplead.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Informes.InformeEmpleados.rdlc";
            this.informeEmplead.Location = new System.Drawing.Point(0, 0);
            this.informeEmplead.Name = "informeEmplead";
            this.informeEmplead.ServerReport.BearerToken = null;
            this.informeEmplead.Size = new System.Drawing.Size(1264, 681);
            this.informeEmplead.TabIndex = 0;
            this.informeEmplead.Load += new System.EventHandler(this.LoadInformeEmplead);
            // 
            // InformeEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.informeEmplead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InformeEmpleados";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Empleados";
            this.Load += new System.EventHandler(this.InformeEmpleados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer informeEmplead;
    }
}