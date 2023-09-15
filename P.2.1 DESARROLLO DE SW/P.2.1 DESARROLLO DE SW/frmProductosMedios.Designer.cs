namespace P._2._1_DESARROLLO_DE_SW
{
    partial class frmProductosMedios
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSemilla2 = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cerosIzquierda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.rdbPruebas = new System.Windows.Forms.RadioButton();
            this.chkMedias = new System.Windows.Forms.CheckBox();
            this.chkUniformidad = new System.Windows.Forms.CheckBox();
            this.chkVarianza = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnDescripcion = new System.Windows.Forms.Button();
            this.btnPruebas = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Semilla 2:";
            // 
            // txtSemilla2
            // 
            this.txtSemilla2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemilla2.Location = new System.Drawing.Point(411, 157);
            this.txtSemilla2.Name = "txtSemilla2";
            this.txtSemilla2.Size = new System.Drawing.Size(100, 31);
            this.txtSemilla2.TabIndex = 2;
            this.txtSemilla2.TextChanged += new System.EventHandler(this.txtSemilla2_TextChanged);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n,
            this.X0,
            this.X1,
            this.resul,
            this.cerosIzquierda,
            this.Xi,
            this.ri});
            this.dgvDatos.Location = new System.Drawing.Point(25, 259);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(679, 358);
            this.dgvDatos.TabIndex = 27;
            this.dgvDatos.TabStop = false;
            this.dgvDatos.Visible = false;
            // 
            // n
            // 
            this.n.HeaderText = "n";
            this.n.MinimumWidth = 6;
            this.n.Name = "n";
            this.n.ReadOnly = true;
            this.n.Width = 30;
            // 
            // X0
            // 
            this.X0.HeaderText = "X0";
            this.X0.MinimumWidth = 6;
            this.X0.Name = "X0";
            this.X0.ReadOnly = true;
            this.X0.Width = 40;
            // 
            // X1
            // 
            this.X1.HeaderText = "X1";
            this.X1.MinimumWidth = 6;
            this.X1.Name = "X1";
            this.X1.ReadOnly = true;
            this.X1.Width = 40;
            // 
            // resul
            // 
            this.resul.HeaderText = "X0*X1";
            this.resul.MinimumWidth = 6;
            this.resul.Name = "resul";
            this.resul.ReadOnly = true;
            this.resul.Width = 80;
            // 
            // cerosIzquierda
            // 
            this.cerosIzquierda.HeaderText = "Ceros Izquierda";
            this.cerosIzquierda.MinimumWidth = 6;
            this.cerosIzquierda.Name = "cerosIzquierda";
            this.cerosIzquierda.ReadOnly = true;
            this.cerosIzquierda.Width = 120;
            // 
            // Xi
            // 
            this.Xi.HeaderText = "Xi";
            this.Xi.MinimumWidth = 6;
            this.Xi.Name = "Xi";
            this.Xi.ReadOnly = true;
            this.Xi.Width = 40;
            // 
            // ri
            // 
            this.ri.HeaderText = "ri";
            this.ri.MinimumWidth = 6;
            this.ri.Name = "ri";
            this.ri.ReadOnly = true;
            this.ri.Width = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Semilla 1:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(141, 212);
            this.nudCantidad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(64, 31);
            this.nudCantidad.TabIndex = 3;
            // 
            // txtSemilla
            // 
            this.txtSemilla.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemilla.Location = new System.Drawing.Point(141, 157);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(100, 31);
            this.txtSemilla.TabIndex = 1;
            this.txtSemilla.TextChanged += new System.EventHandler(this.txtSemilla_TextChanged);
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // rdbPruebas
            // 
            this.rdbPruebas.AutoSize = true;
            this.rdbPruebas.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPruebas.Location = new System.Drawing.Point(56, 623);
            this.rdbPruebas.Name = "rdbPruebas";
            this.rdbPruebas.Size = new System.Drawing.Size(163, 27);
            this.rdbPruebas.TabIndex = 30;
            this.rdbPruebas.Text = "Realizar Pruebas";
            this.rdbPruebas.UseVisualStyleBackColor = true;
            this.rdbPruebas.Visible = false;
            this.rdbPruebas.CheckedChanged += new System.EventHandler(this.rdbPruebas_CheckedChanged);
            // 
            // chkMedias
            // 
            this.chkMedias.AutoSize = true;
            this.chkMedias.Enabled = false;
            this.chkMedias.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMedias.Location = new System.Drawing.Point(25, 669);
            this.chkMedias.Name = "chkMedias";
            this.chkMedias.Size = new System.Drawing.Size(84, 27);
            this.chkMedias.TabIndex = 31;
            this.chkMedias.TabStop = false;
            this.chkMedias.Text = "Media";
            this.chkMedias.UseVisualStyleBackColor = true;
            this.chkMedias.Visible = false;
            // 
            // chkUniformidad
            // 
            this.chkUniformidad.AutoSize = true;
            this.chkUniformidad.Enabled = false;
            this.chkUniformidad.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUniformidad.Location = new System.Drawing.Point(69, 703);
            this.chkUniformidad.Name = "chkUniformidad";
            this.chkUniformidad.Size = new System.Drawing.Size(135, 27);
            this.chkUniformidad.TabIndex = 32;
            this.chkUniformidad.TabStop = false;
            this.chkUniformidad.Text = "Uniformidad";
            this.chkUniformidad.UseVisualStyleBackColor = true;
            this.chkUniformidad.Visible = false;
            // 
            // chkVarianza
            // 
            this.chkVarianza.AutoSize = true;
            this.chkVarianza.Enabled = false;
            this.chkVarianza.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVarianza.Location = new System.Drawing.Point(176, 670);
            this.chkVarianza.Name = "chkVarianza";
            this.chkVarianza.Size = new System.Drawing.Size(100, 27);
            this.chkVarianza.TabIndex = 33;
            this.chkVarianza.TabStop = false;
            this.chkVarianza.Text = "Varianza";
            this.chkVarianza.UseVisualStyleBackColor = true;
            this.chkVarianza.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(157, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(397, 27);
            this.lblTitulo.TabIndex = 70;
            this.lblTitulo.Text = "ALGORITMO DE PRODUCTOS MEDIOS";
            // 
            // btnDescripcion
            // 
            this.btnDescripcion.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescripcion.Image = global::P._2._1_DESARROLLO_DE_SW.Properties.Resources.informacion;
            this.btnDescripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescripcion.Location = new System.Drawing.Point(255, 76);
            this.btnDescripcion.Name = "btnDescripcion";
            this.btnDescripcion.Size = new System.Drawing.Size(207, 51);
            this.btnDescripcion.TabIndex = 0;
            this.btnDescripcion.Text = "Descripción";
            this.btnDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescripcion.UseVisualStyleBackColor = true;
            this.btnDescripcion.Click += new System.EventHandler(this.btnDescripcion_Click);
            // 
            // btnPruebas
            // 
            this.btnPruebas.Enabled = false;
            this.btnPruebas.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPruebas.Image = global::P._2._1_DESARROLLO_DE_SW.Properties.Resources.verificado;
            this.btnPruebas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPruebas.Location = new System.Drawing.Point(497, 655);
            this.btnPruebas.Name = "btnPruebas";
            this.btnPruebas.Size = new System.Drawing.Size(207, 54);
            this.btnPruebas.TabIndex = 5;
            this.btnPruebas.Text = "Hacer Pruebas";
            this.btnPruebas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPruebas.UseVisualStyleBackColor = true;
            this.btnPruebas.Visible = false;
            this.btnPruebas.Click += new System.EventHandler(this.btnPruebas_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Image = global::P._2._1_DESARROLLO_DE_SW.Properties.Resources.engranajes;
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Location = new System.Drawing.Point(561, 175);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(143, 51);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmProductosMedios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 739);
            this.Controls.Add(this.btnDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnPruebas);
            this.Controls.Add(this.chkVarianza);
            this.Controls.Add(this.chkUniformidad);
            this.Controls.Add(this.chkMedias);
            this.Controls.Add(this.rdbPruebas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSemilla2);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.txtSemilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductosMedios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductosMedios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSemilla2;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
        private System.Windows.Forms.DataGridViewTextBoxColumn X0;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn resul;
        private System.Windows.Forms.DataGridViewTextBoxColumn cerosIzquierda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ri;
        private System.Windows.Forms.CheckBox chkVarianza;
        private System.Windows.Forms.CheckBox chkUniformidad;
        private System.Windows.Forms.CheckBox chkMedias;
        private System.Windows.Forms.RadioButton rdbPruebas;
        private System.Windows.Forms.Button btnPruebas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnDescripcion;
    }
}