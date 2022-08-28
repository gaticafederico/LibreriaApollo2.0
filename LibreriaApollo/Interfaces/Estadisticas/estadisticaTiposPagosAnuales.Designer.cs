namespace LibreriaApollo.Interfaces.Estadisticas
{
    partial class estadisticaTiposPagosAnuales
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
            this.estadTiposPagosAnuales = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // estadTiposPagosAnuales
            // 
            this.estadTiposPagosAnuales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.estadTiposPagosAnuales.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Estadisticas.estadisticaTiposPagosAnuales.rdlc";
            this.estadTiposPagosAnuales.Location = new System.Drawing.Point(0, 54);
            this.estadTiposPagosAnuales.Name = "estadTiposPagosAnuales";
            this.estadTiposPagosAnuales.ServerReport.BearerToken = null;
            this.estadTiposPagosAnuales.Size = new System.Drawing.Size(1265, 628);
            this.estadTiposPagosAnuales.TabIndex = 0;
            this.estadTiposPagosAnuales.Load += new System.EventHandler(this.loadEstadTiposPagosAnuales);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.Location = new System.Drawing.Point(369, 9);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(149, 39);
            this.btnConsultar.TabIndex = 74;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.consultar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(201, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Año:";
            // 
            // txtAnio
            // 
            this.txtAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAnio.Location = new System.Drawing.Point(248, 16);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnio.Mask = "9999";
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(43, 26);
            this.txtAnio.TabIndex = 72;
            this.txtAnio.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(57, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 76;
            this.label2.Text = "Mes:";
            // 
            // txtMes
            // 
            this.txtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMes.Location = new System.Drawing.Point(104, 16);
            this.txtMes.Margin = new System.Windows.Forms.Padding(2);
            this.txtMes.Mask = "99";
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(25, 26);
            this.txtMes.TabIndex = 75;
            this.txtMes.ValidatingType = typeof(int);
            // 
            // estadisticaTiposPagosAnuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.estadTiposPagosAnuales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "estadisticaTiposPagosAnuales";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Porcentaje Tipo Pago por Mes";
            this.Load += new System.EventHandler(this.estadisticaTiposPagosAnuales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer estadTiposPagosAnuales;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtAnio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtMes;
    }
}