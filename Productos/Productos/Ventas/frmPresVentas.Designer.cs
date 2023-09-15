namespace Productos
{
    partial class frmPresVentas
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
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.dtpPrincipal = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbRango = new System.Windows.Forms.RadioButton();
            this.rdbDia = new System.Windows.Forms.RadioButton();
            this.dtpSecundario = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblDel = new System.Windows.Forms.Label();
            this.lblHastaEl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.AllowUserToAddRows = false;
            this.dgvOrdenes.AllowUserToDeleteRows = false;
            this.dgvOrdenes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Location = new System.Drawing.Point(91, 51);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.ReadOnly = true;
            this.dgvOrdenes.RowHeadersWidth = 51;
            this.dgvOrdenes.RowTemplate.Height = 24;
            this.dgvOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenes.Size = new System.Drawing.Size(1035, 298);
            this.dgvOrdenes.TabIndex = 1;
            this.dgvOrdenes.TabStop = false;
            // 
            // dtpPrincipal
            // 
            this.dtpPrincipal.Enabled = false;
            this.dtpPrincipal.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPrincipal.Location = new System.Drawing.Point(667, 369);
            this.dtpPrincipal.Name = "dtpPrincipal";
            this.dtpPrincipal.Size = new System.Drawing.Size(459, 38);
            this.dtpPrincipal.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dtpPrincipal, "Seleccionar día");
            this.dtpPrincipal.ValueChanged += new System.EventHandler(this.dtpPrincipal_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbRango);
            this.groupBox1.Controls.Add(this.rdbDia);
            this.groupBox1.Location = new System.Drawing.Point(91, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 108);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rdbRango
            // 
            this.rdbRango.AutoSize = true;
            this.rdbRango.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRango.Location = new System.Drawing.Point(16, 58);
            this.rdbRango.Name = "rdbRango";
            this.rdbRango.Size = new System.Drawing.Size(106, 34);
            this.rdbRango.TabIndex = 1;
            this.rdbRango.TabStop = true;
            this.rdbRango.Text = "Rango";
            this.toolTip1.SetToolTip(this.rdbRango, "Filtro por rango de fechas");
            this.rdbRango.UseVisualStyleBackColor = true;
            this.rdbRango.CheckedChanged += new System.EventHandler(this.rdbRango_CheckedChanged);
            // 
            // rdbDia
            // 
            this.rdbDia.AutoSize = true;
            this.rdbDia.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDia.Location = new System.Drawing.Point(16, 18);
            this.rdbDia.Name = "rdbDia";
            this.rdbDia.Size = new System.Drawing.Size(71, 34);
            this.rdbDia.TabIndex = 0;
            this.rdbDia.TabStop = true;
            this.rdbDia.Text = "Día";
            this.toolTip1.SetToolTip(this.rdbDia, "Filtro por día");
            this.rdbDia.UseVisualStyleBackColor = true;
            this.rdbDia.CheckedChanged += new System.EventHandler(this.rdbDia_CheckedChanged);
            // 
            // dtpSecundario
            // 
            this.dtpSecundario.Enabled = false;
            this.dtpSecundario.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSecundario.Location = new System.Drawing.Point(667, 425);
            this.dtpSecundario.Name = "dtpSecundario";
            this.dtpSecundario.Size = new System.Drawing.Size(459, 38);
            this.dtpSecundario.TabIndex = 3;
            this.toolTip1.SetToolTip(this.dtpSecundario, "Seleccionar día");
            this.dtpSecundario.ValueChanged += new System.EventHandler(this.dtpSecundario_ValueChanged);
            // 
            // lblDel
            // 
            this.lblDel.AutoSize = true;
            this.lblDel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDel.Location = new System.Drawing.Point(545, 377);
            this.lblDel.Name = "lblDel";
            this.lblDel.Size = new System.Drawing.Size(56, 30);
            this.lblDel.TabIndex = 7;
            this.lblDel.Text = "Del:";
            // 
            // lblHastaEl
            // 
            this.lblHastaEl.AutoSize = true;
            this.lblHastaEl.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaEl.Location = new System.Drawing.Point(545, 431);
            this.lblHastaEl.Name = "lblHastaEl";
            this.lblHastaEl.Size = new System.Drawing.Size(116, 30);
            this.lblHastaEl.TabIndex = 8;
            this.lblHastaEl.Text = "Hasta el: ";
            this.lblHastaEl.Visible = false;
            // 
            // frmPresVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 475);
            this.Controls.Add(this.lblHastaEl);
            this.Controls.Add(this.lblDel);
            this.Controls.Add(this.dtpSecundario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpPrincipal);
            this.Controls.Add(this.dgvOrdenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1217, 475);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1217, 475);
            this.Name = "frmPresVentas";
            this.Text = "Registros Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.DateTimePicker dtpPrincipal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbRango;
        private System.Windows.Forms.RadioButton rdbDia;
        private System.Windows.Forms.DateTimePicker dtpSecundario;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDel;
        private System.Windows.Forms.Label lblHastaEl;
    }
}