namespace Productos
{
    partial class frmProductosInactivos
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
            this.dgvProductosInactivos = new System.Windows.Forms.DataGridView();
            this.gboSeleccion = new System.Windows.Forms.GroupBox();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosInactivos)).BeginInit();
            this.gboSeleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductosInactivos
            // 
            this.dgvProductosInactivos.AllowUserToAddRows = false;
            this.dgvProductosInactivos.AllowUserToDeleteRows = false;
            this.dgvProductosInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductosInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosInactivos.Location = new System.Drawing.Point(11, 22);
            this.dgvProductosInactivos.Name = "dgvProductosInactivos";
            this.dgvProductosInactivos.ReadOnly = true;
            this.dgvProductosInactivos.RowHeadersWidth = 51;
            this.dgvProductosInactivos.RowTemplate.Height = 24;
            this.dgvProductosInactivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosInactivos.Size = new System.Drawing.Size(1176, 298);
            this.dgvProductosInactivos.TabIndex = 0;
            this.dgvProductosInactivos.TabStop = false;
            // 
            // gboSeleccion
            // 
            this.gboSeleccion.Controls.Add(this.rdbCodigo);
            this.gboSeleccion.Controls.Add(this.rdbNombre);
            this.gboSeleccion.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboSeleccion.Location = new System.Drawing.Point(15, 355);
            this.gboSeleccion.Name = "gboSeleccion";
            this.gboSeleccion.Size = new System.Drawing.Size(387, 61);
            this.gboSeleccion.TabIndex = 11;
            this.gboSeleccion.TabStop = false;
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(6, 21);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(102, 32);
            this.rdbCodigo.TabIndex = 3;
            this.rdbCodigo.Text = "Código";
            this.toolTip1.SetToolTip(this.rdbCodigo, "Aplicar filtro de búsqueda por código");
            this.rdbCodigo.UseVisualStyleBackColor = true;
            this.rdbCodigo.CheckedChanged += new System.EventHandler(this.rdbCodigo_CheckedChanged);
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(232, 23);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(149, 32);
            this.rdbNombre.TabIndex = 4;
            this.rdbNombre.Text = "Descripción";
            this.toolTip1.SetToolTip(this.rdbNombre, "Aplicar filtro de búsqueda por descripción");
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.rdbNombre_CheckedChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(15, 326);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(387, 35);
            this.txtBuscar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtBuscar, "Ingresar código o descripción a buscar");
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::Productos.Properties.Resources.reiniciar;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(1004, 342);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(183, 66);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.Image = global::Productos.Properties.Resources.deshacer;
            this.btnRecuperar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecuperar.Location = new System.Drawing.Point(753, 342);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(200, 66);
            this.btnRecuperar.TabIndex = 2;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // frmProductosInactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 428);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.gboSeleccion);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.dgvProductosInactivos);
            this.MaximumSize = new System.Drawing.Size(1217, 475);
            this.MinimumSize = new System.Drawing.Size(1217, 475);
            this.Name = "frmProductosInactivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos Inactivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosInactivos)).EndInit();
            this.gboSeleccion.ResumeLayout(false);
            this.gboSeleccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductosInactivos;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.GroupBox gboSeleccion;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}