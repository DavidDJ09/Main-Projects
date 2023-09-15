namespace Prueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.kitBotonesDatos1 = new KitBotones.KitBotonesDatos();
            this.SuspendLayout();
            // 
            // kitBotonesDatos1
            // 
            this.kitBotonesDatos1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kitBotonesDatos1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitBotonesDatos1.Funcion = KitBotones.KitBotonesDatos.SelectorFuncion.Básica;
            this.kitBotonesDatos1.Letra = KitBotones.KitBotonesDatos.SelectorTipoDeLetra.Mayúscula;
            this.kitBotonesDatos1.Location = new System.Drawing.Point(36, 21);
            this.kitBotonesDatos1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitBotonesDatos1.MaximumSize = new System.Drawing.Size(273, 258);
            this.kitBotonesDatos1.MinimumSize = new System.Drawing.Size(273, 258);
            this.kitBotonesDatos1.Modalidad = KitBotones.KitBotonesDatos.selectorModalidad.Vertical;
            this.kitBotonesDatos1.Name = "kitBotonesDatos1";
            this.kitBotonesDatos1.Size = new System.Drawing.Size(273, 258);
            this.kitBotonesDatos1.TabIndex = 0;
            this.kitBotonesDatos1.Tema = KitBotones.KitBotonesDatos.selectorTemas.Frío;
            this.kitBotonesDatos1.Agregar_Click += new System.EventHandler<KitBotones.KitBotonesEventArgs>(this.kitBotonesDatos1_Agregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 390);
            this.Controls.Add(this.kitBotonesDatos1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private KitBotones.KitBotonesDatos kitBotonesDatos1;
    }
}

