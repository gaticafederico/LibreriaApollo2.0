namespace LibreriaApollo.Interfaces.Informes
{
    partial class InformeClientesMayoristasMayor
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
            this.informeClientesMayMayor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // informeClientesMayMayor
            // 
            this.informeClientesMayMayor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informeClientesMayMayor.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Informes.InformeClientesMayoristasMayor.rdlc";
            this.informeClientesMayMayor.Location = new System.Drawing.Point(0, 0);
            this.informeClientesMayMayor.Name = "informeClientesMayMayor";
            this.informeClientesMayMayor.ServerReport.BearerToken = null;
            this.informeClientesMayMayor.Size = new System.Drawing.Size(1264, 681);
            this.informeClientesMayMayor.TabIndex = 0;
            this.informeClientesMayMayor.Load += new System.EventHandler(this.LoadInformeClientesMayMayor);
            // 
            // InformeClientesMayoristasMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.informeClientesMayMayor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InformeClientesMayoristasMayor";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Clientes Mayoristas (Mayor a Menor)";
            this.Load += new System.EventHandler(this.InformeClientesMayoristasMayor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer informeClientesMayMayor;
    }
}