namespace P._2._1_DESARROLLO_DE_SW
{
    partial class frmPruebasVarianza
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
            this.txtNConfianza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGLibertad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lblLS = new System.Windows.Forms.Label();
            this.lblLI = new System.Windows.Forms.Label();
            this.lblVarianza = new System.Windows.Forms.Label();
            this.lblX2LS = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblH0 = new System.Windows.Forms.Label();
            this.lblH1 = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnDescripcion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNConfianza
            // 
            this.txtNConfianza.BackColor = System.Drawing.Color.LightGreen;
            this.txtNConfianza.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNConfianza.Location = new System.Drawing.Point(207, 136);
            this.txtNConfianza.Name = "txtNConfianza";
            this.txtNConfianza.Size = new System.Drawing.Size(97, 31);
            this.txtNConfianza.TabIndex = 0;
            this.txtNConfianza.Text = "95";
            this.txtNConfianza.TextChanged += new System.EventHandler(this.txtAlfa_TextChanged);
            this.txtNConfianza.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAlfa_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nivel de confianza:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(262, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 24);
            this.label7.TabIndex = 60;
            this.label7.Text = "LS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 24);
            this.label9.TabIndex = 59;
            this.label9.Text = "LI:";
            // 
            // lblGLibertad
            // 
            this.lblGLibertad.AutoSize = true;
            this.lblGLibertad.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGLibertad.Location = new System.Drawing.Point(203, 233);
            this.lblGLibertad.Name = "lblGLibertad";
            this.lblGLibertad.Size = new System.Drawing.Size(0, 25);
            this.lblGLibertad.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 24);
            this.label6.TabIndex = 57;
            this.label6.Text = "Grados de libertad:";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX2.Location = new System.Drawing.Point(80, 279);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(0, 25);
            this.lblX2.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 53;
            this.label4.Text = "X^2:";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.Location = new System.Drawing.Point(10, 189);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(88, 24);
            this.lbl9.TabIndex = 52;
            this.lbl9.Text = "Varianza:";
            // 
            // lblLS
            // 
            this.lblLS.AutoSize = true;
            this.lblLS.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLS.Location = new System.Drawing.Point(329, 314);
            this.lblLS.Name = "lblLS";
            this.lblLS.Size = new System.Drawing.Size(0, 25);
            this.lblLS.TabIndex = 63;
            // 
            // lblLI
            // 
            this.lblLI.AutoSize = true;
            this.lblLI.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLI.Location = new System.Drawing.Point(80, 315);
            this.lblLI.Name = "lblLI";
            this.lblLI.Size = new System.Drawing.Size(0, 25);
            this.lblLI.TabIndex = 62;
            // 
            // lblVarianza
            // 
            this.lblVarianza.AutoSize = true;
            this.lblVarianza.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarianza.Location = new System.Drawing.Point(123, 188);
            this.lblVarianza.Name = "lblVarianza";
            this.lblVarianza.Size = new System.Drawing.Size(0, 25);
            this.lblVarianza.TabIndex = 61;
            // 
            // lblX2LS
            // 
            this.lblX2LS.AutoSize = true;
            this.lblX2LS.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX2LS.Location = new System.Drawing.Point(329, 279);
            this.lblX2LS.Name = "lblX2LS";
            this.lblX2LS.Size = new System.Drawing.Size(0, 25);
            this.lblX2LS.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(262, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 24);
            this.label10.TabIndex = 64;
            this.label10.Text = "X^2:";
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(113, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(244, 27);
            this.lblTitulo.TabIndex = 69;
            this.lblTitulo.Text = "PRUEBA DE VARIANZA";
            // 
            // lblH0
            // 
            this.lblH0.AutoSize = true;
            this.lblH0.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH0.Location = new System.Drawing.Point(9, 368);
            this.lblH0.Name = "lblH0";
            this.lblH0.Size = new System.Drawing.Size(100, 25);
            this.lblH0.TabIndex = 72;
            this.lblH0.Text = "H0:σ=1/2";
            // 
            // lblH1
            // 
            this.lblH1.AutoSize = true;
            this.lblH1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH1.Location = new System.Drawing.Point(123, 368);
            this.lblH1.Name = "lblH1";
            this.lblH1.Size = new System.Drawing.Size(114, 25);
            this.lblH1.TabIndex = 73;
            this.lblH1.Text = "H1:σ<>1/2";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Image = global::P._2._1_DESARROLLO_DE_SW.Properties.Resources.flecha_derecha;
            this.btnContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinuar.Location = new System.Drawing.Point(287, 355);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(185, 50);
            this.btnContinuar.TabIndex = 68;
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
            this.btnOK.Location = new System.Drawing.Point(375, 128);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(97, 47);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnDescripcion
            // 
            this.btnDescripcion.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescripcion.Image = global::P._2._1_DESARROLLO_DE_SW.Properties.Resources.informacion;
            this.btnDescripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescripcion.Location = new System.Drawing.Point(139, 57);
            this.btnDescripcion.Name = "btnDescripcion";
            this.btnDescripcion.Size = new System.Drawing.Size(207, 51);
            this.btnDescripcion.TabIndex = 78;
            this.btnDescripcion.Text = "Descripción";
            this.btnDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescripcion.UseVisualStyleBackColor = true;
            this.btnDescripcion.Click += new System.EventHandler(this.btnDescripcion_Click);
            // 
            // frmPruebasVarianza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 423);
            this.Controls.Add(this.btnDescripcion);
            this.Controls.Add(this.lblH1);
            this.Controls.Add(this.lblH0);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.lblX2LS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblLS);
            this.Controls.Add(this.lblLI);
            this.Controls.Add(this.lblVarianza);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblGLibertad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNConfianza);
            this.Controls.Add(this.label2);
            this.Name = "frmPruebasVarianza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba De Varianza";
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtNConfianza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGLibertad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lblLS;
        private System.Windows.Forms.Label lblLI;
        private System.Windows.Forms.Label lblVarianza;
        private System.Windows.Forms.Label lblX2LS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblH1;
        private System.Windows.Forms.Label lblH0;
        private System.Windows.Forms.Button btnDescripcion;
    }
}