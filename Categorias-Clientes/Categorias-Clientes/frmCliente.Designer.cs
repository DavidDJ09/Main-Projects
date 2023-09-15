namespace Categorias_Clientes
{
    partial class frmCliente
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ptbTelefono = new System.Windows.Forms.PictureBox();
            this.ptbCP = new System.Windows.Forms.PictureBox();
            this.ptbEstado = new System.Windows.Forms.PictureBox();
            this.ptbMunicipio = new System.Windows.Forms.PictureBox();
            this.ptbColonia = new System.Windows.Forms.PictureBox();
            this.ptbDireccion = new System.Windows.Forms.PictureBox();
            this.ptbNombre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMunicipio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColonia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(38, 581);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(360, 37);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(38, 534);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(360, 37);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(38, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(360, 28);
            this.txtNombre.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtNombre, "Máximo 40 caractéres");
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(38, 126);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(360, 28);
            this.txtDireccion.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtDireccion, "Máximo 40 caractéres");
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dirección:";
            // 
            // txtColonia
            // 
            this.txtColonia.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColonia.Location = new System.Drawing.Point(38, 198);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(360, 28);
            this.txtColonia.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtColonia, "Máximo 40 caractéres");
            this.txtColonia.TextChanged += new System.EventHandler(this.txtColonia_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Colonia:";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipio.Location = new System.Drawing.Point(38, 271);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(360, 28);
            this.txtMunicipio.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtMunicipio, "Máximo 40 caractéres");
            this.txtMunicipio.TextChanged += new System.EventHandler(this.txtMunicipio_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Municipio:";
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(38, 346);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(360, 28);
            this.txtEstado.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtEstado, "Máximo 30 caractéres");
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Estado:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(38, 490);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(360, 28);
            this.txtTelefono.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtTelefono, "x");
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Teléfono:";
            // 
            // txtCP
            // 
            this.txtCP.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCP.Location = new System.Drawing.Point(38, 415);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(360, 28);
            this.txtCP.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtCP, "5 caractéres numéricos");
            this.txtCP.TextChanged += new System.EventHandler(this.txtCP_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Código Postal:";
            // 
            // ptbTelefono
            // 
            this.ptbTelefono.Image = global::Categorias_Clientes.Properties.Resources.cheque;
            this.ptbTelefono.Location = new System.Drawing.Point(404, 490);
            this.ptbTelefono.Name = "ptbTelefono";
            this.ptbTelefono.Size = new System.Drawing.Size(29, 28);
            this.ptbTelefono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTelefono.TabIndex = 28;
            this.ptbTelefono.TabStop = false;
            this.ptbTelefono.Visible = false;
            // 
            // ptbCP
            // 
            this.ptbCP.Image = global::Categorias_Clientes.Properties.Resources.cheque;
            this.ptbCP.Location = new System.Drawing.Point(404, 415);
            this.ptbCP.Name = "ptbCP";
            this.ptbCP.Size = new System.Drawing.Size(29, 28);
            this.ptbCP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCP.TabIndex = 27;
            this.ptbCP.TabStop = false;
            this.ptbCP.Visible = false;
            // 
            // ptbEstado
            // 
            this.ptbEstado.Image = global::Categorias_Clientes.Properties.Resources.cheque;
            this.ptbEstado.Location = new System.Drawing.Point(404, 346);
            this.ptbEstado.Name = "ptbEstado";
            this.ptbEstado.Size = new System.Drawing.Size(29, 28);
            this.ptbEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbEstado.TabIndex = 26;
            this.ptbEstado.TabStop = false;
            this.ptbEstado.Visible = false;
            // 
            // ptbMunicipio
            // 
            this.ptbMunicipio.Image = global::Categorias_Clientes.Properties.Resources.cheque;
            this.ptbMunicipio.Location = new System.Drawing.Point(404, 271);
            this.ptbMunicipio.Name = "ptbMunicipio";
            this.ptbMunicipio.Size = new System.Drawing.Size(29, 28);
            this.ptbMunicipio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMunicipio.TabIndex = 25;
            this.ptbMunicipio.TabStop = false;
            this.ptbMunicipio.Visible = false;
            // 
            // ptbColonia
            // 
            this.ptbColonia.Image = global::Categorias_Clientes.Properties.Resources.cheque;
            this.ptbColonia.Location = new System.Drawing.Point(404, 198);
            this.ptbColonia.Name = "ptbColonia";
            this.ptbColonia.Size = new System.Drawing.Size(29, 28);
            this.ptbColonia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbColonia.TabIndex = 24;
            this.ptbColonia.TabStop = false;
            this.ptbColonia.Visible = false;
            // 
            // ptbDireccion
            // 
            this.ptbDireccion.Image = global::Categorias_Clientes.Properties.Resources.cheque;
            this.ptbDireccion.Location = new System.Drawing.Point(404, 126);
            this.ptbDireccion.Name = "ptbDireccion";
            this.ptbDireccion.Size = new System.Drawing.Size(29, 28);
            this.ptbDireccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDireccion.TabIndex = 23;
            this.ptbDireccion.TabStop = false;
            this.ptbDireccion.Visible = false;
            // 
            // ptbNombre
            // 
            this.ptbNombre.Image = global::Categorias_Clientes.Properties.Resources.cheque;
            this.ptbNombre.Location = new System.Drawing.Point(404, 56);
            this.ptbNombre.Name = "ptbNombre";
            this.ptbNombre.Size = new System.Drawing.Size(29, 28);
            this.ptbNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbNombre.TabIndex = 22;
            this.ptbNombre.TabStop = false;
            this.ptbNombre.Visible = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 630);
            this.Controls.Add(this.ptbTelefono);
            this.Controls.Add(this.ptbCP);
            this.Controls.Add(this.ptbEstado);
            this.Controls.Add(this.ptbMunicipio);
            this.Controls.Add(this.ptbColonia);
            this.Controls.Add(this.ptbDireccion);
            this.Controls.Add(this.ptbNombre);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMunicipio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColonia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox ptbNombre;
        private System.Windows.Forms.PictureBox ptbDireccion;
        private System.Windows.Forms.PictureBox ptbColonia;
        private System.Windows.Forms.PictureBox ptbMunicipio;
        private System.Windows.Forms.PictureBox ptbEstado;
        private System.Windows.Forms.PictureBox ptbCP;
        private System.Windows.Forms.PictureBox ptbTelefono;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}