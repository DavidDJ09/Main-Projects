namespace Productos
{
    partial class frmEmpleado
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
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboPuesto = new System.Windows.Forms.ComboBox();
            this.ptbPuesto = new System.Windows.Forms.PictureBox();
            this.ptbUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbTelefono = new System.Windows.Forms.PictureBox();
            this.ptbDireccion = new System.Windows.Forms.PictureBox();
            this.ptbNombre = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.ptbContrasenia = new System.Windows.Forms.PictureBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.chkConservar = new System.Windows.Forms.CheckBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.btnVerAntigua = new System.Windows.Forms.Button();
            this.btnOcultarAntigua = new System.Windows.Forms.Button();
            this.ptbAntigua = new System.Windows.Forms.PictureBox();
            this.txtAntigua = new System.Windows.Forms.TextBox();
            this.lblAntigua = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbContrasenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAntigua)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(292, 285);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(165, 38);
            this.txtTelefono.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtTelefono, " 10 caractéres numéricos");
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(292, 226);
            this.txtDireccion.MaxLength = 60;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(327, 38);
            this.txtDireccion.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtDireccion, "Máximo 60 caractéres alfanuméricos");
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(292, 167);
            this.txtNombre.MaxLength = 60;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(327, 38);
            this.txtNombre.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtNombre, "Máximo 60 caractéres");
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 30);
            this.label5.TabIndex = 29;
            this.label5.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 30);
            this.label6.TabIndex = 27;
            this.label6.Text = "Teléfono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre Completo:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(292, 403);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(256, 38);
            this.txtUsuario.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtUsuario, "Máximo 20 caractéres alfanuméricos");
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 30);
            this.label7.TabIndex = 42;
            this.label7.Text = "Usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 30);
            this.label8.TabIndex = 45;
            this.label8.Text = "Puesto:";
            // 
            // cboPuesto
            // 
            this.cboPuesto.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPuesto.FormattingEnabled = true;
            this.cboPuesto.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cboPuesto.Location = new System.Drawing.Point(292, 343);
            this.cboPuesto.Name = "cboPuesto";
            this.cboPuesto.Size = new System.Drawing.Size(225, 38);
            this.cboPuesto.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cboPuesto, "Selecciona el puesto");
            this.cboPuesto.SelectedIndexChanged += new System.EventHandler(this.cboPuesto_SelectedIndexChanged);
            // 
            // ptbPuesto
            // 
            this.ptbPuesto.Image = global::Productos.Properties.Resources.cheque;
            this.ptbPuesto.Location = new System.Drawing.Point(523, 344);
            this.ptbPuesto.Name = "ptbPuesto";
            this.ptbPuesto.Size = new System.Drawing.Size(37, 35);
            this.ptbPuesto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPuesto.TabIndex = 47;
            this.ptbPuesto.TabStop = false;
            this.ptbPuesto.Visible = false;
            // 
            // ptbUsuario
            // 
            this.ptbUsuario.Image = global::Productos.Properties.Resources.cheque;
            this.ptbUsuario.Location = new System.Drawing.Point(554, 406);
            this.ptbUsuario.Name = "ptbUsuario";
            this.ptbUsuario.Size = new System.Drawing.Size(37, 35);
            this.ptbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbUsuario.TabIndex = 44;
            this.ptbUsuario.TabStop = false;
            this.ptbUsuario.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Productos.Properties.Resources.empleado_max;
            this.pictureBox1.Location = new System.Drawing.Point(267, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // ptbTelefono
            // 
            this.ptbTelefono.Image = global::Productos.Properties.Resources.cheque;
            this.ptbTelefono.Location = new System.Drawing.Point(463, 285);
            this.ptbTelefono.Name = "ptbTelefono";
            this.ptbTelefono.Size = new System.Drawing.Size(37, 35);
            this.ptbTelefono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTelefono.TabIndex = 40;
            this.ptbTelefono.TabStop = false;
            this.ptbTelefono.Visible = false;
            // 
            // ptbDireccion
            // 
            this.ptbDireccion.Image = global::Productos.Properties.Resources.cheque;
            this.ptbDireccion.Location = new System.Drawing.Point(625, 229);
            this.ptbDireccion.Name = "ptbDireccion";
            this.ptbDireccion.Size = new System.Drawing.Size(37, 35);
            this.ptbDireccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDireccion.TabIndex = 39;
            this.ptbDireccion.TabStop = false;
            this.ptbDireccion.Visible = false;
            // 
            // ptbNombre
            // 
            this.ptbNombre.Image = global::Productos.Properties.Resources.cheque;
            this.ptbNombre.Location = new System.Drawing.Point(625, 167);
            this.ptbNombre.Name = "ptbNombre";
            this.ptbNombre.Size = new System.Drawing.Size(37, 35);
            this.ptbNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbNombre.TabIndex = 35;
            this.ptbNombre.TabStop = false;
            this.ptbNombre.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Productos.Properties.Resources.boton_cerrar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(489, 610);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(173, 50);
            this.btnCancelar.TabIndex = 9;
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
            this.btnAceptar.Location = new System.Drawing.Point(35, 610);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(165, 50);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAceptar, "Confirmar");
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // ptbContrasenia
            // 
            this.ptbContrasenia.Image = global::Productos.Properties.Resources.cheque;
            this.ptbContrasenia.Location = new System.Drawing.Point(616, 488);
            this.ptbContrasenia.Name = "ptbContrasenia";
            this.ptbContrasenia.Size = new System.Drawing.Size(37, 35);
            this.ptbContrasenia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbContrasenia.TabIndex = 50;
            this.ptbContrasenia.TabStop = false;
            this.ptbContrasenia.Visible = false;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(292, 485);
            this.txtContrasenia.MaxLength = 20;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(256, 38);
            this.txtContrasenia.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtContrasenia, "Máximo 20 caractéres alfanuméricos");
            this.txtContrasenia.UseSystemPasswordChar = true;
            this.txtContrasenia.TextChanged += new System.EventHandler(this.txtContrasenia_TextChanged);
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(30, 489);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(145, 30);
            this.lblContrasenia.TabIndex = 49;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // chkConservar
            // 
            this.chkConservar.AutoSize = true;
            this.chkConservar.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConservar.Location = new System.Drawing.Point(292, 451);
            this.chkConservar.Name = "chkConservar";
            this.chkConservar.Size = new System.Drawing.Size(219, 28);
            this.chkConservar.TabIndex = 5;
            this.chkConservar.Text = "Conservar Contraseña";
            this.toolTip1.SetToolTip(this.chkConservar, "Al marcar conservarás tu contraseña, de lo contrario deberás especificar la nueva" +
        " en la caja de texto");
            this.chkConservar.UseVisualStyleBackColor = true;
            this.chkConservar.Visible = false;
            this.chkConservar.CheckedChanged += new System.EventHandler(this.chkConservar_CheckedChanged);
            // 
            // btnVer
            // 
            this.btnVer.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Image = global::Productos.Properties.Resources.visible;
            this.btnVer.Location = new System.Drawing.Point(554, 484);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(56, 39);
            this.btnVer.TabIndex = 52;
            this.btnVer.TabStop = false;
            this.toolTip1.SetToolTip(this.btnVer, "Ver contraseña");
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcultar.Image = global::Productos.Properties.Resources.oculto;
            this.btnOcultar.Location = new System.Drawing.Point(554, 485);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(56, 39);
            this.btnOcultar.TabIndex = 51;
            this.btnOcultar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnOcultar, "Ocultar contraseña");
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // btnVerAntigua
            // 
            this.btnVerAntigua.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAntigua.Image = global::Productos.Properties.Resources.visible;
            this.btnVerAntigua.Location = new System.Drawing.Point(554, 537);
            this.btnVerAntigua.Name = "btnVerAntigua";
            this.btnVerAntigua.Size = new System.Drawing.Size(56, 39);
            this.btnVerAntigua.TabIndex = 57;
            this.btnVerAntigua.TabStop = false;
            this.toolTip1.SetToolTip(this.btnVerAntigua, "Ver contraseña");
            this.btnVerAntigua.UseVisualStyleBackColor = true;
            this.btnVerAntigua.Click += new System.EventHandler(this.btnVerAntigua_Click);
            // 
            // btnOcultarAntigua
            // 
            this.btnOcultarAntigua.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcultarAntigua.Image = global::Productos.Properties.Resources.oculto;
            this.btnOcultarAntigua.Location = new System.Drawing.Point(554, 537);
            this.btnOcultarAntigua.Name = "btnOcultarAntigua";
            this.btnOcultarAntigua.Size = new System.Drawing.Size(56, 39);
            this.btnOcultarAntigua.TabIndex = 56;
            this.btnOcultarAntigua.TabStop = false;
            this.toolTip1.SetToolTip(this.btnOcultarAntigua, "Ocultar contraseña");
            this.btnOcultarAntigua.UseVisualStyleBackColor = true;
            this.btnOcultarAntigua.Click += new System.EventHandler(this.btnOcultarAntigua_Click);
            // 
            // ptbAntigua
            // 
            this.ptbAntigua.Image = global::Productos.Properties.Resources.cheque;
            this.ptbAntigua.Location = new System.Drawing.Point(616, 540);
            this.ptbAntigua.Name = "ptbAntigua";
            this.ptbAntigua.Size = new System.Drawing.Size(37, 35);
            this.ptbAntigua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAntigua.TabIndex = 55;
            this.ptbAntigua.TabStop = false;
            this.ptbAntigua.Visible = false;
            // 
            // txtAntigua
            // 
            this.txtAntigua.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAntigua.Location = new System.Drawing.Point(292, 537);
            this.txtAntigua.MaxLength = 20;
            this.txtAntigua.Name = "txtAntigua";
            this.txtAntigua.Size = new System.Drawing.Size(256, 38);
            this.txtAntigua.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtAntigua, "Máximo 20 caractéres alfanuméricos");
            this.txtAntigua.UseSystemPasswordChar = true;
            // 
            // lblAntigua
            // 
            this.lblAntigua.AutoSize = true;
            this.lblAntigua.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntigua.Location = new System.Drawing.Point(30, 541);
            this.lblAntigua.Name = "lblAntigua";
            this.lblAntigua.Size = new System.Drawing.Size(222, 30);
            this.lblAntigua.TabIndex = 54;
            this.lblAntigua.Text = "Contraseña Actual:";
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 672);
            this.Controls.Add(this.btnVerAntigua);
            this.Controls.Add(this.btnOcultarAntigua);
            this.Controls.Add(this.ptbAntigua);
            this.Controls.Add(this.txtAntigua);
            this.Controls.Add(this.lblAntigua);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.chkConservar);
            this.Controls.Add(this.ptbContrasenia);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.cboPuesto);
            this.Controls.Add(this.ptbPuesto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ptbUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ptbTelefono);
            this.Controls.Add(this.ptbDireccion);
            this.Controls.Add(this.ptbNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.ptbPuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbContrasenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAntigua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptbTelefono;
        private System.Windows.Forms.PictureBox ptbDireccion;
        private System.Windows.Forms.PictureBox ptbNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox ptbPuesto;
        private System.Windows.Forms.ComboBox cboPuesto;
        private System.Windows.Forms.PictureBox ptbContrasenia;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.CheckBox chkConservar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.Button btnVerAntigua;
        private System.Windows.Forms.Button btnOcultarAntigua;
        private System.Windows.Forms.PictureBox ptbAntigua;
        private System.Windows.Forms.TextBox txtAntigua;
        private System.Windows.Forms.Label lblAntigua;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}