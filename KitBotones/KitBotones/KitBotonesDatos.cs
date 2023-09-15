using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace KitBotones
{
    public partial class KitBotonesDatos : UserControl
    {
        public KitBotonesDatos()
        {
            InitializeComponent();
        }

        [ReadOnly(true)]
        public override Color BackColor { get; set; }

        [ReadOnly(true)]
        public override Color ForeColor { get; set; }

        [ReadOnly(true)]
        public override Image BackgroundImage { get; set; }

        [ReadOnly(true)]
        public override Size MaximumSize { get; set; }

        [ReadOnly(true)]
        public override Size MinimumSize { get; set; }

        public enum selectorTemas
        {
            Predeterminado,
            Obscuro,
            Semáforo,
            Frío,
            Cálido,
        }

        private selectorTemas tema;

        /// <summary>
        /// Determina el aspecto de los botones
        /// </summary>
        [Description("Cambia el color de los botones y el color que se mustra al poner el mouse sobre estos."),
        Category("Personalización")]
        public selectorTemas Tema {
            get { return tema; }
            set {
                tema = value;
                switch (value) {
                    case selectorTemas.Predeterminado:
                        btnAgregar.BackColor=Color.White;
                        btnAgregar.ForeColor=Color.Black;
                        btnEditar.BackColor=Color.White;
                        btnEditar.ForeColor=Color.Black;
                        btnEliminar.BackColor=Color.White;
                        btnEliminar.ForeColor=Color.Black;
                        btnImprimir.BackColor=Color.White;
                        btnImprimir.ForeColor=Color.Black;
                        btnAgregar.FlatAppearance.BorderColor=Color.White;
                        btnEditar.FlatAppearance.BorderColor=Color.White;
                        btnEliminar.FlatAppearance.BorderColor=Color.White;
                        btnImprimir.FlatAppearance.BorderColor=Color.White;
                        break;
                    case selectorTemas.Obscuro:
                        btnAgregar.BackColor=Color.Yellow;
                        btnEditar.BackColor=Color.Yellow;
                        btnEliminar.BackColor=Color.Yellow;
                        btnImprimir.BackColor=Color.Yellow;
                        btnAgregar.FlatAppearance.BorderColor=Color.Yellow;
                        btnEditar.FlatAppearance.BorderColor=Color.Yellow;
                        btnEliminar.FlatAppearance.BorderColor=Color.Yellow;
                        btnImprimir.FlatAppearance.BorderColor=Color.Yellow;
                        break;
                    case selectorTemas.Cálido:
                        btnAgregar.BackColor=Color.LightSalmon;
                        btnAgregar.ForeColor=Color.Black;
                        btnEditar.BackColor=Color.LightSalmon;
                        btnEditar.ForeColor=Color.Black;
                        btnEliminar.BackColor=Color.LightSalmon;
                        btnEliminar.ForeColor=Color.Black;
                        btnImprimir.BackColor=Color.LightSalmon;
                        btnImprimir.ForeColor=Color.Black;
                        btnAgregar.FlatAppearance.BorderColor=Color.LightSalmon;
                        btnEditar.FlatAppearance.BorderColor=Color.LightSalmon;
                        btnEliminar.FlatAppearance.BorderColor=Color.LightSalmon;
                        btnImprimir.FlatAppearance.BorderColor=Color.LightSalmon;
                        break;
                    case selectorTemas.Frío:
                        btnAgregar.BackColor=Color.LightBlue;
                        btnAgregar.ForeColor=Color.Black;
                        btnEditar.BackColor=Color.LightBlue;
                        btnEditar.ForeColor=Color.Black;
                        btnEliminar.BackColor=Color.LightBlue;
                        btnEliminar.ForeColor=Color.Black;
                        btnImprimir.BackColor=Color.LightBlue;
                        btnImprimir.ForeColor=Color.Black;
                        btnAgregar.FlatAppearance.BorderColor=Color.LightBlue;
                        btnEditar.FlatAppearance.BorderColor=Color.LightBlue;
                        btnEliminar.FlatAppearance.BorderColor=Color.LightBlue;
                        btnImprimir.FlatAppearance.BorderColor=Color.LightBlue;
                        break;
                    case selectorTemas.Semáforo:
                        btnAgregar.BackColor=Color.Green;
                        btnAgregar.ForeColor=Color.White;
                        btnEditar.BackColor=Color.Yellow;
                        btnEditar.ForeColor=Color.Black;
                        btnEliminar.BackColor=Color.Red;
                        btnEliminar.ForeColor=Color.White;
                        btnImprimir.BackColor=Color.Black;
                        btnImprimir.ForeColor=Color.White;
                        btnAgregar.FlatAppearance.BorderColor=Color.Green;
                        btnEditar.FlatAppearance.BorderColor=Color.Yellow;
                        btnEliminar.FlatAppearance.BorderColor=Color.Red;
                        btnImprimir.FlatAppearance.BorderColor=Color.Black;
                        break;
                }
            }
        }

        public enum selectorModalidad
        {
            Vertical,
            Horizontal
        }

        private selectorModalidad modalidad;

        /// <summary>
        /// Determina la acomodo de los botones
        /// </summary>
        [Description("Cambia el acomódo o posicón de los botones."),
        Category("Personalización")]
        public selectorModalidad Modalidad {
            get { return modalidad; }
            set {
                modalidad = value;
                switch (value)
                {
                    case selectorModalidad.Horizontal:
                        btnAgregar.Location = new Point(3, 3);
                        btnEditar.Location = new Point(btnAgregar.Left+btnAgregar.Width+10, 3);
                        btnEliminar.Location = new Point(btnEditar.Left+btnEditar.Width+10, 3);
                        btnImprimir.Location = new Point(btnEliminar.Left+btnEliminar.Width+10, 3);
                        if (this.funcion==SelectorFuncion.Básica)
                        {
                            this.MaximumSize = new Size(btnImprimir.Width*4+(btnImprimir.Width/2)
                            +(btnImprimir.Width/4),
                             btnImprimir.Height+(btnImprimir.Height/2));
                            this.MinimumSize=this.MaximumSize;
                            this.Size=this.MaximumSize;
                        }
                        else
                        {
                            this.MaximumSize = new Size(btnImprimir.Width*5+(btnImprimir.Width/2)
                            +(btnImprimir.Width/4),
                             btnImprimir.Height+(btnImprimir.Height/2));
                            this.MinimumSize=this.MaximumSize;
                            this.Size=this.MaximumSize;
                        }
                        break;
                    case selectorModalidad.Vertical:
                        btnAgregar.Location = new Point(3, 3);
                        btnEditar.Location = new Point(3, btnAgregar.Top+btnAgregar.Height+10);
                        btnEliminar.Location = new Point(3, btnEditar.Top+btnEditar.Height+10);
                        btnImprimir.Location = new Point(3, btnEliminar.Top+btnEliminar.Height+10);
                        if (this.funcion==SelectorFuncion.Básica)
                        {
                            this.MaximumSize = new Size(btnAgregar.Width+(btnAgregar.Width/2),
                            btnImprimir.Top+(btnImprimir.Height)+(btnImprimir.Height/2));
                            this.MinimumSize=this.MaximumSize;
                            this.Size=this.MaximumSize;
                        }
                        else
                        {
                            this.MaximumSize = new Size(btnAgregar.Width+(btnAgregar.Width/2),
                            btnImprimir.Top+(btnImprimir.Height*2)+(btnImprimir.Height/2));
                            this.MinimumSize=this.MaximumSize;
                            this.Size=this.MaximumSize;
                        }
                        break;
                }
            }
        }

        public enum SelectorTipoDeLetra{
            TipoOración,
            Mayúscula
        }

        private SelectorTipoDeLetra letra;

        /// <summary>
        /// Asigna el tipo de letra mostrado en el texto de los botones (MAYÚSCULA o Tipo oración).
        /// </summary>
        [Description("Cambia el tipo de letra mostrado en el texto de los botones (MAYÚSCULA o Tipo oración)."),
        Category("Personalización")]
        public SelectorTipoDeLetra Letra { 
            get { return letra; }
            set { 
                letra = value;
                switch (value)
                {
                    case SelectorTipoDeLetra.TipoOración:
                        btnAgregar.Text="Agregar";
                        btnEditar.Text="Editar";
                        btnEliminar.Text="Eliminar";
                        btnImprimir.Text="Imprimir";
                        break;
                    case SelectorTipoDeLetra.Mayúscula:
                        btnAgregar.Text=btnAgregar.Text.ToUpper();
                        btnEditar.Text=btnEditar.Text.ToUpper();
                        btnEliminar.Text=btnEliminar.Text.ToUpper();
                        btnImprimir.Text=btnImprimir.Text.ToUpper();
                        break;
                }
            }
        }

        public enum SelectorFuncion
        {
            Extendida,
            Básica
        }

        private SelectorFuncion funcion;

        /// <summary>
        /// Determina la cantidad de botones mostrados
        /// </summary>
        [Description("Cambia la cantidad de botones mostrados (agregar, editar, eliminar) o " +
            "(agregar, editar, eliminar e imprimir)"),
        Category("Personalización")]
        public SelectorFuncion Funcion { 
            get { return funcion; }
            set { 
                funcion = value;
                switch (value)
                {
                    case SelectorFuncion.Básica:
                        btnImprimir.Visible=false;
                        if (this.modalidad==selectorModalidad.Horizontal)
                        {
                            this.MaximumSize = new Size(btnImprimir.Width*4+(btnImprimir.Width/2)
                            +(btnImprimir.Width/4),
                             btnImprimir.Height+(btnImprimir.Height/2));
                            this.MinimumSize=this.MaximumSize;
                            this.Size=this.MaximumSize;
                        }
                        else
                        {
                            this.MaximumSize = new Size(btnAgregar.Width+(btnAgregar.Width/2),
                            btnImprimir.Top+(btnImprimir.Height)+(btnImprimir.Height/2));
                            this.MinimumSize=this.MaximumSize;
                            this.Size=this.MaximumSize;
                        }
                        break;
                    case SelectorFuncion.Extendida:
                        btnImprimir.Visible=true;
                        if (this.modalidad==selectorModalidad.Horizontal)
                        {
                            this.MaximumSize = new Size(btnImprimir.Width*5+(btnImprimir.Width/2)
                            +(btnImprimir.Width/4),
                             btnImprimir.Height+(btnImprimir.Height/2));
                            this.MinimumSize=this.MaximumSize;
                            this.Size=this.MaximumSize;
                        }
                        else
                        {
                            this.MaximumSize = new Size(btnAgregar.Width+(btnAgregar.Width/2),
                            btnImprimir.Top+(btnImprimir.Height*2)+(btnImprimir.Height/2));
                            this.MinimumSize=this.MaximumSize;
                            this.Size=this.MaximumSize;
                        }
                        break;
                }
            } 
        }

        private void btnAgregar_MouseHover_1(object sender, EventArgs e)
        {
            if (Tema==selectorTemas.Predeterminado)
            {
                btnAgregar.BackColor=Color.DarkGray;
                btnAgregar.FlatAppearance.BorderColor=Color.DarkGray;
                btnAgregar.ForeColor=Color.White;
            }
            else if (Tema==selectorTemas.Obscuro)
            {
                btnAgregar.BackColor=Color.DodgerBlue;
                btnAgregar.FlatAppearance.BorderColor=Color.DodgerBlue;
                btnAgregar.ForeColor=Color.White;
            }
            else if (Tema==selectorTemas.Cálido)
            {
                btnAgregar.BackColor=Color.DarkRed;
                btnAgregar.FlatAppearance.BorderColor=Color.DarkRed;
                btnAgregar.ForeColor=Color.White;
            }
            else if (Tema==selectorTemas.Frío)
            {
                btnAgregar.BackColor=Color.CadetBlue;
                btnAgregar.FlatAppearance.BorderColor=Color.CadetBlue;
                btnAgregar.ForeColor=Color.White;
            }
            else if (Tema==selectorTemas.Semáforo)
            {
                btnAgregar.BackColor=Color.LightGreen;
                btnAgregar.FlatAppearance.BorderColor=Color.LightGreen;
                btnAgregar.ForeColor=Color.Black;
            }
        }

        private void btnEditar_MouseHover_1(object sender, EventArgs e)
        {
            if (Tema==selectorTemas.Predeterminado)
            {
                btnEditar.BackColor=Color.DarkGray;
                btnEditar.FlatAppearance.BorderColor=Color.DarkGray;
                btnEditar.ForeColor=Color.White;
            }
            else if (Tema==selectorTemas.Obscuro)
            {
                btnEditar.BackColor=Color.DodgerBlue;
                btnEditar.FlatAppearance.BorderColor=Color.DodgerBlue;
                btnEditar.ForeColor=Color.White;
            }
            else if (Tema==selectorTemas.Cálido)
            {
                btnEditar.BackColor=Color.DarkRed;
                btnEditar.FlatAppearance.BorderColor=Color.DarkRed;
                btnEditar.ForeColor=Color.White;
            }
            else if (Tema==selectorTemas.Frío)
            {
                btnEditar.BackColor=Color.CadetBlue;
                btnEditar.FlatAppearance.BorderColor=Color.CadetBlue;
                btnEditar.ForeColor=Color.White;
            }
            else if (Tema==selectorTemas.Semáforo)
            {
                btnEditar.BackColor=Color.Goldenrod;
                btnEditar.FlatAppearance.BorderColor=Color.Goldenrod;
                btnEditar.ForeColor=Color.Black;
            }
        }

        private void btnEliminar_MouseHover_1(object sender, EventArgs e)
        {
            if (Tema==selectorTemas.Predeterminado)
            {
                btnEliminar.BackColor=Color.DarkGray;
                btnEliminar.FlatAppearance.BorderColor=Color.DarkGray;
                btnEliminar.ForeColor=Color.White;
            }
            else if (Tema==selectorTemas.Obscuro)
            {
                btnEliminar.BackColor=Color.DodgerBlue;
                btnEliminar.FlatAppearance.BorderColor=Color.DodgerBlue;
                btnEliminar.ForeColor=Color.White;
            }
            else if (Tema==selectorTemas.Cálido)
            {
                btnEliminar.BackColor=Color.DarkRed;
                btnEliminar.FlatAppearance.BorderColor=Color.DarkRed;
                btnEliminar.ForeColor=Color.White;
            }
            else if (Tema==selectorTemas.Frío)
            {
                btnEliminar.BackColor=Color.CadetBlue;
                btnEliminar.FlatAppearance.BorderColor=Color.CadetBlue;
                btnEliminar.ForeColor=Color.White;
            }
            else if (Tema == selectorTemas.Semáforo)
            {
                btnEliminar.BackColor = Color.Brown;
                btnEliminar.FlatAppearance.BorderColor = Color.Brown;
                btnEliminar.ForeColor = Color.Black;
            }
        }

        private void btnImprimir_MouseHover_1(object sender, EventArgs e)
        {
            if (Tema==selectorTemas.Predeterminado)
            {
                btnImprimir.BackColor=Color.DarkGray;
                btnImprimir.FlatAppearance.BorderColor=Color.DarkGray;
                btnImprimir.ForeColor=Color.White;
            }
            else if (Tema==selectorTemas.Obscuro)
            {
                btnImprimir.BackColor=Color.DodgerBlue;
                btnImprimir.FlatAppearance.BorderColor=Color.DodgerBlue;
                btnImprimir.ForeColor=Color.White;
            }
            else if (Tema==selectorTemas.Cálido)
            {
                btnImprimir.BackColor=Color.DarkRed;
                btnImprimir.FlatAppearance.BorderColor=Color.DarkRed;
                btnImprimir.ForeColor=Color.White;
            }
            else if (Tema==selectorTemas.Frío)
            {
                btnImprimir.BackColor=Color.CadetBlue;
                btnImprimir.FlatAppearance.BorderColor=Color.CadetBlue;
                btnImprimir.ForeColor=Color.White;
            }
            else if (Tema == selectorTemas.Semáforo)
            {
                btnImprimir.BackColor = Color.DarkGray;
                btnImprimir.FlatAppearance.BorderColor = Color.DarkGray;
                btnImprimir.ForeColor = Color.Black;
            }
        }

        private void btnImprimir_MouseLeave_1(object sender, EventArgs e)
        {
            if (Tema==selectorTemas.Predeterminado)
            {
                btnImprimir.BackColor=Color.White;
                btnImprimir.FlatAppearance.BorderColor=Color.White;
                btnImprimir.ForeColor=Color.Black;
            }
            else if (Tema==selectorTemas.Obscuro)
            {
                btnImprimir.BackColor=Color.Yellow;
                btnImprimir.FlatAppearance.BorderColor=Color.Yellow;
                btnImprimir.ForeColor=Color.Black;
            }
            else if (Tema==selectorTemas.Cálido)
            {
                btnImprimir.BackColor=Color.LightSalmon;
                btnImprimir.FlatAppearance.BorderColor=Color.LightSalmon;
                btnImprimir.ForeColor=Color.Black;
            }
            else if (Tema==selectorTemas.Frío)
            {
                btnImprimir.BackColor=Color.LightBlue;
                btnImprimir.FlatAppearance.BorderColor=Color.LightBlue;
                btnImprimir.ForeColor=Color.Black;
            }
            else if (Tema == selectorTemas.Semáforo)
            {
                btnImprimir.BackColor = Color.Black;
                btnImprimir.FlatAppearance.BorderColor = Color.Black;
                btnImprimir.ForeColor = Color.White;
            }
        }

        private void btnEliminar_MouseLeave_1(object sender, EventArgs e)
        {
            if (Tema==selectorTemas.Predeterminado)
            {
                btnEliminar.BackColor=Color.White;
                btnEliminar.FlatAppearance.BorderColor=Color.White;
                btnEliminar.ForeColor=Color.Black;
            }
            else if (Tema==selectorTemas.Obscuro)
            {
                btnEliminar.BackColor=Color.Yellow;
                btnEliminar.FlatAppearance.BorderColor=Color.Yellow;
                btnEliminar.ForeColor=Color.Black;
            }
            else if (Tema==selectorTemas.Cálido)
            {
                btnEliminar.BackColor=Color.LightSalmon;
                btnEliminar.FlatAppearance.BorderColor=Color.LightSalmon;
                btnEliminar.ForeColor=Color.Black;
            }
            else if (Tema==selectorTemas.Frío)
            {
                btnEliminar.BackColor=Color.LightBlue;
                btnEliminar.FlatAppearance.BorderColor=Color.LightBlue;
                btnEliminar.ForeColor=Color.Black;
            }
            else if (Tema == selectorTemas.Semáforo)
            {
                btnEliminar.BackColor = Color.Red;
                btnEliminar.FlatAppearance.BorderColor = Color.Red;
                btnEliminar.ForeColor = Color.White;
            }
        }

        private void btnEditar_MouseLeave_1(object sender, EventArgs e)
        {
            if (Tema==selectorTemas.Predeterminado)
            {
                btnEditar.BackColor=Color.White;
                btnEditar.FlatAppearance.BorderColor=Color.White;
                btnEditar.ForeColor=Color.Black;
            }
            else if (Tema==selectorTemas.Obscuro)
            {
                btnEditar.BackColor=Color.Yellow;
                btnEditar.FlatAppearance.BorderColor=Color.Yellow;
                btnEditar.ForeColor=Color.Black;
            }
            else if (Tema==selectorTemas.Cálido)
            {
                btnEditar.BackColor=Color.LightSalmon;
                btnEditar.FlatAppearance.BorderColor=Color.LightSalmon;
                btnEditar.ForeColor=Color.Black;
            }
            else if (Tema==selectorTemas.Frío)
            {
                btnEditar.BackColor=Color.LightBlue;
                btnEditar.FlatAppearance.BorderColor=Color.LightBlue;
                btnEditar.ForeColor=Color.Black;
            }
            else if (Tema == selectorTemas.Semáforo)
            {
                btnEditar.BackColor = Color.Yellow;
                btnEditar.FlatAppearance.BorderColor = Color.Yellow;
                btnEditar.ForeColor = Color.Black;
            }
        }

        private void btnAgregar_MouseLeave_1(object sender, EventArgs e)
        {
            if (Tema==selectorTemas.Predeterminado)
            {
                btnAgregar.BackColor=Color.White;
                btnAgregar.FlatAppearance.BorderColor=Color.White;
                btnAgregar.ForeColor=Color.Black;
            }
            else if (Tema==selectorTemas.Obscuro)
            {
                btnAgregar.BackColor=Color.Yellow;
                btnAgregar.FlatAppearance.BorderColor=Color.Yellow;
                btnAgregar.ForeColor=Color.Black;
            }
            else if (Tema==selectorTemas.Cálido)
            {
                btnAgregar.BackColor=Color.LightSalmon;
                btnAgregar.FlatAppearance.BorderColor=Color.LightSalmon;
                btnAgregar.ForeColor=Color.Black;
            }
            else if (Tema==selectorTemas.Frío)
            {
                btnAgregar.BackColor=Color.LightBlue;
                btnAgregar.FlatAppearance.BorderColor=Color.LightBlue;
                btnAgregar.ForeColor=Color.Black;
            }
            else if (Tema == selectorTemas.Semáforo)
            {
                btnAgregar.BackColor = Color.Green;
                btnAgregar.FlatAppearance.BorderColor = Color.Green;
                btnAgregar.ForeColor = Color.White;
            }
        }

        private void KitBotonesDatos_FontChanged(object sender, EventArgs e)
        {
            btnAgregar.Font=this.Font;
            btnEditar.Font=this.Font;
            btnEliminar.Font=this.Font;
            btnImprimir.Font=this.Font;
            if (modalidad==selectorModalidad.Horizontal)
            {
                this.MaximumSize = new Size(btnImprimir.Width*5+(btnImprimir.Width/2)
                    +(btnImprimir.Width/4),
                    btnImprimir.Height+(btnImprimir.Height/2)+(btnImprimir.Height/2));
                this.MinimumSize=this.MaximumSize;
                this.Size=this.MaximumSize;
            }
            else
            {
                this.MaximumSize = new Size(btnAgregar.Width+(btnAgregar.Width/2),
                    btnImprimir.Top+(btnImprimir.Height*2));
                this.MinimumSize=this.MaximumSize;
                this.Size=this.MaximumSize;
            }
        }

        [Description("Tiene lugar cuando se da click en el botón agregar."),
        Category("Click´s")]
        public event EventHandler<KitBotonesEventArgs> Agregar_Click;
        [Description("Tiene lugar cuando se da click en el botón editar."),
        Category("Click´s")]
        public event EventHandler<KitBotonesEventArgs> Editar_Click;
        [Description("Tiene lugar cuando se da click en el botón eliminar."),
        Category("Click´s")]
        public event EventHandler<KitBotonesEventArgs> Eliminar_Click;
        [Description("Tiene lugar cuando se da click en el botón imprimir."),
        Category("Click´s")]
        public event EventHandler<KitBotonesEventArgs> Imprimir_Click;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar_Click?.Invoke(this, null);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar_Click?.Invoke(this, null);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar_Click?.Invoke(this, null);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir_Click?.Invoke(this, null);
        }
    }
}
