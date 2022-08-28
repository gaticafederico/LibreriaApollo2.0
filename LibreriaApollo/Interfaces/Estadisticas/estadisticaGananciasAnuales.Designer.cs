namespace LibreriaApollo.Interfaces.Estadisticas
{
    partial class estadisticaGananciasAnuales
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.MaskedTextBox();
            this.estadGananciasAnuales = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.Location = new System.Drawing.Point(393, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(149, 39);
            this.btnConsultar.TabIndex = 77;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.consultar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(225, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "Año:";
            // 
            // txtAnio
            // 
            this.txtAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAnio.Location = new System.Drawing.Point(272, 19);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnio.Mask = "9999";
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(43, 26);
            this.txtAnio.TabIndex = 75;
            this.txtAnio.ValidatingType = typeof(int);
            // 
            // estadGananciasAnuales
            // 
            this.estadGananciasAnuales.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Estadisticas.estadisticaGananciasAnuales.rdlc";
            this.estadGananciasAnuales.Location = new System.Drawing.Point(-1, 57);
            this.estadGananciasAnuales.Name = "estadGananciasAnuales";
            this.estadGananciasAnuales.ServerReport.BearerToken = null;
            this.estadGananciasAnuales.Size = new System.Drawing.Size(1266, 625);
            this.estadGananciasAnuales.TabIndex = 78;
            // 
            // estadisticaGananciasAnuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.estadGananciasAnuales);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "estadisticaGananciasAnuales";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Ganancias por Mes";
            this.Load += new System.EventHandler(this.estadisticaGananciasAnuales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtAnio;
        private Microsoft.Reporting.WinForms.ReportViewer estadGananciasAnuales;
    }
}