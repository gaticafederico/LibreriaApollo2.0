namespace LibreriaApollo.Interfaces
{
    partial class frmEstadisticas
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
            this.label10 = new System.Windows.Forms.Label();
            this.btnPromedioProductos = new System.Windows.Forms.Button();
            this.btnProductosPorMes = new System.Windows.Forms.Button();
            this.btnPromedioTipoPagoAnual = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClientesPorLocalidades = new System.Windows.Forms.Button();
            this.btnVentasPorLocalidades = new System.Windows.Forms.Button();
            this.btnVentasPorEmpleados = new System.Windows.Forms.Button();
            this.btnGananciasMensuales = new System.Windows.Forms.Button();
            this.btnGananciasApiladas = new System.Windows.Forms.Button();
            this.btnProductosMasVendidos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(24, 146);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(255, 51);
            this.label10.TabIndex = 21;
            this.label10.Text = "Estadisticas";
            // 
            // btnPromedioProductos
            // 
            this.btnPromedioProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnPromedioProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromedioProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromedioProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromedioProductos.Location = new System.Drawing.Point(34, 219);
            this.btnPromedioProductos.Margin = new System.Windows.Forms.Padding(6);
            this.btnPromedioProductos.Name = "btnPromedioProductos";
            this.btnPromedioProductos.Size = new System.Drawing.Size(790, 92);
            this.btnPromedioProductos.TabIndex = 22;
            this.btnPromedioProductos.Text = "Porcentaje de Productos Por Categoria";
            this.btnPromedioProductos.UseVisualStyleBackColor = false;
            this.btnPromedioProductos.Click += new System.EventHandler(this.abrirPromedioProductos);
            // 
            // btnProductosPorMes
            // 
            this.btnProductosPorMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnProductosPorMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosPorMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosPorMes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductosPorMes.Location = new System.Drawing.Point(34, 340);
            this.btnProductosPorMes.Margin = new System.Windows.Forms.Padding(6);
            this.btnProductosPorMes.Name = "btnProductosPorMes";
            this.btnProductosPorMes.Size = new System.Drawing.Size(790, 92);
            this.btnProductosPorMes.TabIndex = 23;
            this.btnProductosPorMes.Text = "Cantidad de Ventas Mensuales";
            this.btnProductosPorMes.UseVisualStyleBackColor = false;
            this.btnProductosPorMes.Click += new System.EventHandler(this.abrirProductosPorMes);
            // 
            // btnPromedioTipoPagoAnual
            // 
            this.btnPromedioTipoPagoAnual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnPromedioTipoPagoAnual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromedioTipoPagoAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromedioTipoPagoAnual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromedioTipoPagoAnual.Location = new System.Drawing.Point(34, 463);
            this.btnPromedioTipoPagoAnual.Margin = new System.Windows.Forms.Padding(6);
            this.btnPromedioTipoPagoAnual.Name = "btnPromedioTipoPagoAnual";
            this.btnPromedioTipoPagoAnual.Size = new System.Drawing.Size(790, 92);
            this.btnPromedioTipoPagoAnual.TabIndex = 24;
            this.btnPromedioTipoPagoAnual.Text = "Porcentaje de Ventas por Tipo de Pago";
            this.btnPromedioTipoPagoAnual.UseVisualStyleBackColor = false;
            this.btnPromedioTipoPagoAnual.Click += new System.EventHandler(this.abrirPromedioTipoPagoAnual);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LibreriaApollo.Properties.Resources.ApolloLogo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(890, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(738, 173);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnClientesPorLocalidades
            // 
            this.btnClientesPorLocalidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnClientesPorLocalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientesPorLocalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientesPorLocalidades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientesPorLocalidades.Location = new System.Drawing.Point(34, 588);
            this.btnClientesPorLocalidades.Margin = new System.Windows.Forms.Padding(6);
            this.btnClientesPorLocalidades.Name = "btnClientesPorLocalidades";
            this.btnClientesPorLocalidades.Size = new System.Drawing.Size(790, 92);
            this.btnClientesPorLocalidades.TabIndex = 25;
            this.btnClientesPorLocalidades.Text = "Porcentaje de Clientes por Localidades";
            this.btnClientesPorLocalidades.UseVisualStyleBackColor = false;
            this.btnClientesPorLocalidades.Click += new System.EventHandler(this.abrirClientesPorLocalidades);
            // 
            // btnVentasPorLocalidades
            // 
            this.btnVentasPorLocalidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnVentasPorLocalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasPorLocalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasPorLocalidades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasPorLocalidades.Location = new System.Drawing.Point(856, 219);
            this.btnVentasPorLocalidades.Margin = new System.Windows.Forms.Padding(6);
            this.btnVentasPorLocalidades.Name = "btnVentasPorLocalidades";
            this.btnVentasPorLocalidades.Size = new System.Drawing.Size(790, 92);
            this.btnVentasPorLocalidades.TabIndex = 26;
            this.btnVentasPorLocalidades.Text = "Porcentaje de Ventas por Localidades";
            this.btnVentasPorLocalidades.UseVisualStyleBackColor = false;
            this.btnVentasPorLocalidades.Click += new System.EventHandler(this.abrirVentasPorLocalidades);
            // 
            // btnVentasPorEmpleados
            // 
            this.btnVentasPorEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnVentasPorEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasPorEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasPorEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasPorEmpleados.Location = new System.Drawing.Point(856, 340);
            this.btnVentasPorEmpleados.Margin = new System.Windows.Forms.Padding(6);
            this.btnVentasPorEmpleados.Name = "btnVentasPorEmpleados";
            this.btnVentasPorEmpleados.Size = new System.Drawing.Size(790, 92);
            this.btnVentasPorEmpleados.TabIndex = 27;
            this.btnVentasPorEmpleados.Text = "Cantidad de Ventas por Empleados";
            this.btnVentasPorEmpleados.UseVisualStyleBackColor = false;
            this.btnVentasPorEmpleados.Click += new System.EventHandler(this.abrirVentasPorEmpleados);
            // 
            // btnGananciasMensuales
            // 
            this.btnGananciasMensuales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnGananciasMensuales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGananciasMensuales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGananciasMensuales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGananciasMensuales.Location = new System.Drawing.Point(856, 463);
            this.btnGananciasMensuales.Margin = new System.Windows.Forms.Padding(6);
            this.btnGananciasMensuales.Name = "btnGananciasMensuales";
            this.btnGananciasMensuales.Size = new System.Drawing.Size(790, 92);
            this.btnGananciasMensuales.TabIndex = 28;
            this.btnGananciasMensuales.Text = "Ganancias Mensuales por Año";
            this.btnGananciasMensuales.UseVisualStyleBackColor = false;
            this.btnGananciasMensuales.Click += new System.EventHandler(this.abrirGananciasMensuales);
            // 
            // btnGananciasApiladas
            // 
            this.btnGananciasApiladas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnGananciasApiladas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGananciasApiladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGananciasApiladas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGananciasApiladas.Location = new System.Drawing.Point(856, 588);
            this.btnGananciasApiladas.Margin = new System.Windows.Forms.Padding(6);
            this.btnGananciasApiladas.Name = "btnGananciasApiladas";
            this.btnGananciasApiladas.Size = new System.Drawing.Size(790, 92);
            this.btnGananciasApiladas.TabIndex = 29;
            this.btnGananciasApiladas.Text = "Ventas Mensuales por Tipo Pago";
            this.btnGananciasApiladas.UseVisualStyleBackColor = false;
            this.btnGananciasApiladas.Click += new System.EventHandler(this.abrirGananciasApiladas);
            // 
            // btnProductosMasVendidos
            // 
            this.btnProductosMasVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.btnProductosMasVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosMasVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosMasVendidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductosMasVendidos.Location = new System.Drawing.Point(33, 722);
            this.btnProductosMasVendidos.Margin = new System.Windows.Forms.Padding(6);
            this.btnProductosMasVendidos.Name = "btnProductosMasVendidos";
            this.btnProductosMasVendidos.Size = new System.Drawing.Size(790, 92);
            this.btnProductosMasVendidos.TabIndex = 30;
            this.btnProductosMasVendidos.Text = "Cantidad de Productos mas Vendidos";
            this.btnProductosMasVendidos.UseVisualStyleBackColor = false;
            this.btnProductosMasVendidos.Click += new System.EventHandler(this.btnProductosMasVendidos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(856, 722);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(790, 92);
            this.button1.TabIndex = 31;
            this.button1.Text = "Porcentaje de Empleados Activos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1678, 910);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProductosMasVendidos);
            this.Controls.Add(this.btnGananciasApiladas);
            this.Controls.Add(this.btnGananciasMensuales);
            this.Controls.Add(this.btnVentasPorEmpleados);
            this.Controls.Add(this.btnVentasPorLocalidades);
            this.Controls.Add(this.btnClientesPorLocalidades);
            this.Controls.Add(this.btnPromedioTipoPagoAnual);
            this.Controls.Add(this.btnProductosPorMes);
            this.Controls.Add(this.btnPromedioProductos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmEstadisticas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Libreria Apollo | Estadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPromedioProductos;
        private System.Windows.Forms.Button btnProductosPorMes;
        private System.Windows.Forms.Button btnPromedioTipoPagoAnual;
        private System.Windows.Forms.Button btnClientesPorLocalidades;
        private System.Windows.Forms.Button btnVentasPorLocalidades;
        private System.Windows.Forms.Button btnVentasPorEmpleados;
        private System.Windows.Forms.Button btnGananciasMensuales;
        private System.Windows.Forms.Button btnGananciasApiladas;
        private System.Windows.Forms.Button btnProductosMasVendidos;
        private System.Windows.Forms.Button button1;
    }
}