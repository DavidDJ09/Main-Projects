namespace Productos
{
    partial class frmMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ptbEmpleados = new System.Windows.Forms.PictureBox();
            this.ptbRegistros = new System.Windows.Forms.PictureBox();
            this.ptbVentas = new System.Windows.Forms.PictureBox();
            this.ptbProductos = new System.Windows.Forms.PictureBox();
            this.btnRegistrosVentas = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.ptbBanner = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(398, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 662);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(22, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(965, 106);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Abarrotes \"Don Perro\"";
            // 
            // ptbEmpleados
            // 
            this.ptbEmpleados.Image = global::Productos.Properties.Resources.empleado_max;
            this.ptbEmpleados.Location = new System.Drawing.Point(66, 467);
            this.ptbEmpleados.Name = "ptbEmpleados";
            this.ptbEmpleados.Size = new System.Drawing.Size(292, 269);
            this.ptbEmpleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbEmpleados.TabIndex = 10;
            this.ptbEmpleados.TabStop = false;
            // 
            // ptbRegistros
            // 
            this.ptbRegistros.Image = global::Productos.Properties.Resources.buscar_max1;
            this.ptbRegistros.Location = new System.Drawing.Point(66, 467);
            this.ptbRegistros.Name = "ptbRegistros";
            this.ptbRegistros.Size = new System.Drawing.Size(292, 269);
            this.ptbRegistros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbRegistros.TabIndex = 8;
            this.ptbRegistros.TabStop = false;
            // 
            // ptbVentas
            // 
            this.ptbVentas.Image = global::Productos.Properties.Resources.bolsa_de_la_compra_max;
            this.ptbVentas.Location = new System.Drawing.Point(66, 467);
            this.ptbVentas.Name = "ptbVentas";
            this.ptbVentas.Size = new System.Drawing.Size(292, 269);
            this.ptbVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbVentas.TabIndex = 7;
            this.ptbVentas.TabStop = false;
            // 
            // ptbProductos
            // 
            this.ptbProductos.Image = global::Productos.Properties.Resources.paquete_max;
            this.ptbProductos.Location = new System.Drawing.Point(66, 467);
            this.ptbProductos.Name = "ptbProductos";
            this.ptbProductos.Size = new System.Drawing.Size(292, 269);
            this.ptbProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProductos.TabIndex = 9;
            this.ptbProductos.TabStop = false;
            // 
            // btnRegistrosVentas
            // 
            this.btnRegistrosVentas.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrosVentas.Image = global::Productos.Properties.Resources.buscar;
            this.btnRegistrosVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrosVentas.Location = new System.Drawing.Point(225, 192);
            this.btnRegistrosVentas.Name = "btnRegistrosVentas";
            this.btnRegistrosVentas.Size = new System.Drawing.Size(212, 93);
            this.btnRegistrosVentas.TabIndex = 1;
            this.btnRegistrosVentas.Text = "Registros Ventas";
            this.btnRegistrosVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnRegistrosVentas, "Ver registros de ventas");
            this.btnRegistrosVentas.UseVisualStyleBackColor = true;
            this.btnRegistrosVentas.Click += new System.EventHandler(this.btnRegistrosVentas_Click);
            // 
            // ptbLogo
            // 
            this.ptbLogo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ptbLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptbLogo.Image = global::Productos.Properties.Resources.bulldog_frances_2;
            this.ptbLogo.Location = new System.Drawing.Point(1039, 12);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(159, 132);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 6;
            this.ptbLogo.TabStop = false;
            // 
            // btnVentas
            // 
            this.btnVentas.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Image = global::Productos.Properties.Resources.bolsa_de_la_compra;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(19, 192);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(200, 93);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnVentas, "Efectuar ventas");
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Image = global::Productos.Properties.Resources.empleado;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(683, 192);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(250, 93);
            this.btnEmpleados.TabIndex = 3;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEmpleados, "Ver y manipular registros de empleados");
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Image = global::Productos.Properties.Resources.paquete;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(443, 192);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(234, 93);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnProductos, "Ver y manipular registros de productos");
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // ptbBanner
            // 
            this.ptbBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbBanner.Image = global::Productos.Properties.Resources.istockphoto_1223000177_170667a;
            this.ptbBanner.Location = new System.Drawing.Point(-2, -1);
            this.ptbBanner.Name = "ptbBanner";
            this.ptbBanner.Size = new System.Drawing.Size(1209, 161);
            this.ptbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBanner.TabIndex = 4;
            this.ptbBanner.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 808);
            this.Controls.Add(this.ptbEmpleados);
            this.Controls.Add(this.ptbRegistros);
            this.Controls.Add(this.ptbVentas);
            this.Controls.Add(this.ptbProductos);
            this.Controls.Add(this.btnRegistrosVentas);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptbBanner);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ptbEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.PictureBox ptbBanner;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Button btnRegistrosVentas;
        private System.Windows.Forms.PictureBox ptbVentas;
        private System.Windows.Forms.PictureBox ptbRegistros;
        private System.Windows.Forms.PictureBox ptbProductos;
        private System.Windows.Forms.PictureBox ptbEmpleados;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}