namespace Productos
{
    partial class frmProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioOferta = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbCantidad = new System.Windows.Forms.PictureBox();
            this.ptbPrecioOferta = new System.Windows.Forms.PictureBox();
            this.ptbPrecioVenta = new System.Windows.Forms.PictureBox();
            this.ptbPrecioCompra = new System.Windows.Forms.PictureBox();
            this.ptbDescripcion = new System.Windows.Forms.PictureBox();
            this.ptbCodigo = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkGranel = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPrecioOferta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Barras:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio Compra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio Venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Oferta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 30);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cantidad:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(280, 167);
            this.txtCodigo.MaxLength = 13;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(197, 38);
            this.txtCodigo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtCodigo, "13 caractéres numéricos");
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(280, 222);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(311, 38);
            this.txtDescripcion.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtDescripcion, "Máximo 60 caractéres alfanuméricos");
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.Location = new System.Drawing.Point(280, 279);
            this.txtPrecioCompra.MaxLength = 8;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(123, 38);
            this.txtPrecioCompra.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtPrecioCompra, "Número entero o decimal con dós digitos después del punto");
            this.txtPrecioCompra.TextChanged += new System.EventHandler(this.txtPrecioCompra_TextChanged);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(280, 337);
            this.txtPrecioVenta.MaxLength = 8;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(123, 38);
            this.txtPrecioVenta.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtPrecioVenta, "Número entero o decimal con dós digitos después del punto");
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
            // 
            // txtPrecioOferta
            // 
            this.txtPrecioOferta.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioOferta.Location = new System.Drawing.Point(280, 398);
            this.txtPrecioOferta.MaxLength = 8;
            this.txtPrecioOferta.Name = "txtPrecioOferta";
            this.txtPrecioOferta.Size = new System.Drawing.Size(123, 38);
            this.txtPrecioOferta.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtPrecioOferta, "Número entero o decimal con dós digitos después del punto");
            this.txtPrecioOferta.TextChanged += new System.EventHandler(this.txtPrecioOferta_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(280, 457);
            this.txtCantidad.MaxLength = 8;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(123, 38);
            this.txtCantidad.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtCantidad, "Número entero o decimal con dós digitos después del punto");
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Productos.Properties.Resources.bolsa_de_la_compra_max;
            this.pictureBox1.Location = new System.Drawing.Point(246, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // ptbCantidad
            // 
            this.ptbCantidad.Image = global::Productos.Properties.Resources.cheque;
            this.ptbCantidad.Location = new System.Drawing.Point(409, 457);
            this.ptbCantidad.Name = "ptbCantidad";
            this.ptbCantidad.Size = new System.Drawing.Size(37, 35);
            this.ptbCantidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCantidad.TabIndex = 19;
            this.ptbCantidad.TabStop = false;
            this.ptbCantidad.Visible = false;
            // 
            // ptbPrecioOferta
            // 
            this.ptbPrecioOferta.Image = global::Productos.Properties.Resources.cheque;
            this.ptbPrecioOferta.Location = new System.Drawing.Point(409, 398);
            this.ptbPrecioOferta.Name = "ptbPrecioOferta";
            this.ptbPrecioOferta.Size = new System.Drawing.Size(37, 35);
            this.ptbPrecioOferta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPrecioOferta.TabIndex = 18;
            this.ptbPrecioOferta.TabStop = false;
            this.ptbPrecioOferta.Visible = false;
            // 
            // ptbPrecioVenta
            // 
            this.ptbPrecioVenta.Image = global::Productos.Properties.Resources.cheque;
            this.ptbPrecioVenta.Location = new System.Drawing.Point(409, 337);
            this.ptbPrecioVenta.Name = "ptbPrecioVenta";
            this.ptbPrecioVenta.Size = new System.Drawing.Size(37, 35);
            this.ptbPrecioVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPrecioVenta.TabIndex = 17;
            this.ptbPrecioVenta.TabStop = false;
            this.ptbPrecioVenta.Visible = false;
            // 
            // ptbPrecioCompra
            // 
            this.ptbPrecioCompra.Image = global::Productos.Properties.Resources.cheque;
            this.ptbPrecioCompra.Location = new System.Drawing.Point(409, 279);
            this.ptbPrecioCompra.Name = "ptbPrecioCompra";
            this.ptbPrecioCompra.Size = new System.Drawing.Size(37, 35);
            this.ptbPrecioCompra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPrecioCompra.TabIndex = 16;
            this.ptbPrecioCompra.TabStop = false;
            this.ptbPrecioCompra.Visible = false;
            // 
            // ptbDescripcion
            // 
            this.ptbDescripcion.Image = global::Productos.Properties.Resources.cheque;
            this.ptbDescripcion.Location = new System.Drawing.Point(595, 222);
            this.ptbDescripcion.Name = "ptbDescripcion";
            this.ptbDescripcion.Size = new System.Drawing.Size(37, 35);
            this.ptbDescripcion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDescripcion.TabIndex = 15;
            this.ptbDescripcion.TabStop = false;
            this.ptbDescripcion.Visible = false;
            // 
            // ptbCodigo
            // 
            this.ptbCodigo.Image = global::Productos.Properties.Resources.cheque;
            this.ptbCodigo.Location = new System.Drawing.Point(483, 167);
            this.ptbCodigo.Name = "ptbCodigo";
            this.ptbCodigo.Size = new System.Drawing.Size(37, 35);
            this.ptbCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCodigo.TabIndex = 14;
            this.ptbCodigo.TabStop = false;
            this.ptbCodigo.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Productos.Properties.Resources.boton_cerrar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(457, 528);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(173, 50);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnCancelar, "Regresar al menú");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = global::Productos.Properties.Resources.casilla_de_verificacion;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(32, 528);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(165, 50);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAceptar, "Confirmar");
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chkGranel
            // 
            this.chkGranel.AutoSize = true;
            this.chkGranel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGranel.Location = new System.Drawing.Point(461, 456);
            this.chkGranel.Name = "chkGranel";
            this.chkGranel.Size = new System.Drawing.Size(130, 34);
            this.chkGranel.TabIndex = 6;
            this.chkGranel.TabStop = false;
            this.chkGranel.Text = "A Granel";
            this.toolTip1.SetToolTip(this.chkGranel, "Al marcar la casilla indicará que el producto puede ser vendido a granel");
            this.chkGranel.UseVisualStyleBackColor = true;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 603);
            this.Controls.Add(this.chkGranel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ptbCantidad);
            this.Controls.Add(this.ptbPrecioOferta);
            this.Controls.Add(this.ptbPrecioVenta);
            this.Controls.Add(this.ptbPrecioCompra);
            this.Controls.Add(this.ptbDescripcion);
            this.Controls.Add(this.ptbCodigo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecioOferta);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(660, 650);
            this.MinimumSize = new System.Drawing.Size(660, 650);
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPrecioOferta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioOferta;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox ptbCodigo;
        private System.Windows.Forms.PictureBox ptbDescripcion;
        private System.Windows.Forms.PictureBox ptbPrecioCompra;
        private System.Windows.Forms.PictureBox ptbPrecioVenta;
        private System.Windows.Forms.PictureBox ptbPrecioOferta;
        private System.Windows.Forms.PictureBox ptbCantidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkGranel;
    }
}