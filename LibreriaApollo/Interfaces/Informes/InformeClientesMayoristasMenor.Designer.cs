namespace LibreriaApollo.Interfaces.Informes
{
    partial class InformeClientesMayoristasMenor
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
            this.informeClientesMayMenor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // informeClientesMayMenor
            // 
            this.informeClientesMayMenor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informeClientesMayMenor.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Informes.InformeClientesMayoristasMenor.rdlc";
            this.informeClientesMayMenor.Location = new System.Drawing.Point(0, 0);
            this.informeClientesMayMenor.Name = "informeClientesMayMenor";
            this.informeClientesMayMenor.ServerReport.BearerToken = null;
            this.informeClientesMayMenor.Size = new System.Drawing.Size(1264, 681);
            this.informeClientesMayMenor.TabIndex = 0;
            this.informeClientesMayMenor.Load += new System.EventHandler(this.LoadInformeClientesMayMenor);
            // 
            // InformeClientesMayoristasMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.informeClientesMayMenor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InformeClientesMayoristasMenor";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Clientes Mayoristas (Menor a Mayor)";
            this.Load += new System.EventHandler(this.InformeClientesMayoristasMenor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer informeClientesMayMenor;
    }
}