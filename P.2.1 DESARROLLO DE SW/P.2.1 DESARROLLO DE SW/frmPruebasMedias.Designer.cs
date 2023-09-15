namespace P._2._1_DESARROLLO_DE_SW
{
    partial class frmPruebasMedias
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
            this.label2 = new System.Windows.Forms.Label();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNAceptacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblA2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLS = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLI = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblH1 = new System.Windows.Forms.Label();
            this.lblH0 = new System.Windows.Forms.Label();
            this.btnDescripcion = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nivel de confianza:";
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // txtNAceptacion
            // 
            this.txtNAceptacion.BackColor = System.Drawing.Color.LightGreen;
            this.txtNAceptacion.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNAceptacion.Location = new System.Drawing.Point(225, 139);
            this.txtNAceptacion.Name = "txtNAceptacion";
            this.txtNAceptacion.Size = new System.Drawing.Size(97, 31);
            this.txtNAceptacion.TabIndex = 19;
            this.txtNAceptacion.Text = "95";
            this.txtNAceptacion.TextChanged += new System.EventHandler(this.txtNAceptacion_TextChanged);
            this.txtNAceptacion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNAceptacion_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Media:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(107, 191);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(0, 25);
            this.lblPromedio.TabIndex = 42;
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZ.Location = new System.Drawing.Point(71, 237);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(0, 25);
            this.lblZ.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 24);
            this.label4.TabIndex = 43;
            this.label4.Text = "Z:";
            // 
            // lblA2
            // 
            this.lblA2.AutoSize = true;
            this.lblA2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA2.Location = new System.Drawing.Point(344, 191);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(0, 24);
            this.lblA2.TabIndex = 46;
            this.lblA2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "a/2:";
            this.label5.Visible = false;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(71, 279);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(0, 25);
            this.lblN.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 24);
            this.label6.TabIndex = 47;
            this.label6.Text = "n:";
            // 
            // lblLS
            // 
            this.lblLS.AutoSize = true;
            this.lblLS.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLS.Location = new System.Drawing.Point(327, 279);
            this.lblLS.Name = "lblLS";
            this.lblLS.Size = new System.Drawing.Size(0, 25);
            this.lblLS.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(252, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 24);
            this.label7.TabIndex = 51;
            this.label7.Text = "LS:";
            // 
            // lblLI
            // 
            this.lblLI.AutoSize = true;
            this.lblLI.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLI.Location = new System.Drawing.Point(327, 237);
            this.lblLI.Name = "lblLI";
            this.lblLI.Size = new System.Drawing.Size(0, 25);
            this.lblLI.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(252, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 24);
            this.label9.TabIndex = 49;
            this.label9.Text = "LI:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(137, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(204, 27);
            this.lblTitulo.TabIndex = 69;
            this.lblTitulo.Text = "PRUEBA DE MEDIA";
            // 
            // lblH1
            // 
            this.lblH1.AutoSize = true;
            this.lblH1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH1.Location = new System.Drawing.Point(140, 335);
            this.lblH1.Name = "lblH1";
            this.lblH1.Size = new System.Drawing.Size(110, 25);
            this.lblH1.TabIndex = 75;
            this.lblH1.Text = "H1:μ<>0.5";
            // 
            // lblH0
            // 
            this.lblH0.AutoSize = true;
            this.lblH0.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH0.Location = new System.Drawing.Point(11, 335);
            this.lblH0.Name = "lblH0";
            this.lblH0.Size = new System.Drawing.Size(96, 25);
            this.lblH0.TabIndex = 74;
            this.lblH0.Text = "H0:μ=0.5";
            // 
            // btnDescripcion
            // 
            this.btnDescripcion.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescripcion.Image = global::P._2._1_DESARROLLO_DE_SW.Properties.Resources.informacion;
            this.btnDescripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescripcion.Location = new System.Drawing.Point(142, 58);
            this.btnDescripcion.Name = "btnDescripcion";
            this.btnDescripcion.Size = new System.Drawing.Size(207, 51);
            this.btnDescripcion.TabIndex = 77;
            this.btnDescripcion.Text = "Descripción";
            this.btnDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescripcion.UseVisualStyleBackColor = true;
            this.btnDescripcion.Click += new System.EventHandler(this.btnDescripcion_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Image = global::P._2._1_DESARROLLO_DE_SW.Properties.Resources.flecha_derecha;
            this.btnContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinuar.Location = new System.Drawing.Point(292, 322);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(185, 50);
            this.btnContinuar.TabIndex = 53;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Image = global::P._2._1_DESARROLLO_DE_SW.Properties.Resources.ok;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(375, 131);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(97, 47);
            this.btnOK.TabIndex = 40;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmPruebasMedias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 387);
            this.Controls.Add(this.btnDescripcion);
            this.Controls.Add(this.lblH1);
            this.Controls.Add(this.lblH0);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.lblLS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblLI);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblA2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNAceptacion);
            this.Controls.Add(this.label2);
            this.Name = "frmPruebasMedias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba de Media";
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.TextBox txtNAceptacion;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblA2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblH1;
        private System.Windows.Forms.Label lblH0;
        private System.Windows.Forms.Button btnDescripcion;
    }
}