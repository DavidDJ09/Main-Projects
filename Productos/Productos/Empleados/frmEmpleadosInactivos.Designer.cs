namespace Productos
{
    partial class frmEmpleadosInactivos
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.dgvEmpleadosInactivos = new System.Windows.Forms.DataGridView();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosInactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::Productos.Properties.Resources.reiniciar;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(1004, 337);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(183, 66);
            this.btnRegresar.TabIndex = 13;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(12, 353);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(387, 35);
            this.txtBuscar.TabIndex = 15;
            this.toolTip1.SetToolTip(this.txtBuscar, "Ingrese el nombre a buscar");
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.Image = global::Productos.Properties.Resources.deshacer;
            this.btnRecuperar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecuperar.Location = new System.Drawing.Point(753, 337);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(200, 66);
            this.btnRecuperar.TabIndex = 14;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // dgvEmpleadosInactivos
            // 
            this.dgvEmpleadosInactivos.AllowUserToAddRows = false;
            this.dgvEmpleadosInactivos.AllowUserToDeleteRows = false;
            this.dgvEmpleadosInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleadosInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadosInactivos.Location = new System.Drawing.Point(11, 17);
            this.dgvEmpleadosInactivos.Name = "dgvEmpleadosInactivos";
            this.dgvEmpleadosInactivos.ReadOnly = true;
            this.dgvEmpleadosInactivos.RowHeadersWidth = 51;
            this.dgvEmpleadosInactivos.RowTemplate.Height = 24;
            this.dgvEmpleadosInactivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleadosInactivos.Size = new System.Drawing.Size(1176, 298);
            this.dgvEmpleadosInactivos.TabIndex = 12;
            this.dgvEmpleadosInactivos.TabStop = false;
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // frmEmpleadosInactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 428);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.dgvEmpleadosInactivos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1217, 475);
            this.MinimumSize = new System.Drawing.Size(1217, 475);
            this.Name = "frmEmpleadosInactivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados Inactivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosInactivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.DataGridView dgvEmpleadosInactivos;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}