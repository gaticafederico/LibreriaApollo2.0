namespace LibreriaApollo.Interfaces.Informes
{
    partial class InformeListadoProductos
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
            this.components = new System.ComponentModel.Container();
            this.informeListadoProd = new Microsoft.Reporting.WinForms.ReportViewer();
            this.apollo2DataSet = new LibreriaApollo.apollo2DataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new LibreriaApollo.apollo2DataSetTableAdapters.productosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.apollo2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // informeListadoProd
            // 
            this.informeListadoProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informeListadoProd.LocalReport.ReportEmbeddedResource = "LibreriaApollo.Interfaces.Informes.InformeListadoProductos.rdlc";
            this.informeListadoProd.Location = new System.Drawing.Point(0, 0);
            this.informeListadoProd.Name = "informeListadoProd";
            this.informeListadoProd.ServerReport.BearerToken = null;
            this.informeListadoProd.Size = new System.Drawing.Size(1264, 681);
            this.informeListadoProd.TabIndex = 0;
            this.informeListadoProd.Load += new System.EventHandler(this.loadInformeListadoProd);
            // 
            // apollo2DataSet
            // 
            this.apollo2DataSet.DataSetName = "apollo2DataSet";
            this.apollo2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.apollo2DataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // InformeListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.informeListadoProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InformeListadoProductos";
            this.ShowIcon = false;
            this.Text = "Libreria Apollo | Productos";
            ((System.ComponentModel.ISupportInitialize)(this.apollo2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer informeListadoProd;
        private apollo2DataSet apollo2DataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private apollo2DataSetTableAdapters.productosTableAdapter productosTableAdapter;
    }
}