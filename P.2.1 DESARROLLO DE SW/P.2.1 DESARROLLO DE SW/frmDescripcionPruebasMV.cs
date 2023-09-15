using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P._2._1_DESARROLLO_DE_SW
{
    public partial class frmDescripcionPruebasMV : Form
    {
        int seleccion;
        string texto;
        public frmDescripcionPruebasMV(int numero, string titulo)
        {
            InitializeComponent();
            seleccion = numero;
            texto = titulo;
            mostrarDescripcion(seleccion, texto);
        }

        private void mostrarDescripcion(int seleccion, string titulo)
        {
            if (seleccion==1)
            {
                lblTitulo.Text = titulo;
                lblDescripcion.Text="Se evalúa en si la media esta entre el LI y el LS" +
                    " (basados en el nivel de\r\nconfianza proporcionado)." +
                    "\r\n\r\nDe estarlo se aceptará la hipótesis nula (H0), de " +
                    "lo contrario se aceptará\r\nla hipótesis alternativa (H1). " +
                    "La hipótesis aceptada será subrayada de \r\ncolor verde.";
            }
            else if (seleccion==2)
            {
                lblTitulo.Text = titulo;
                lblDescripcion.Text="Se evalúa en si la varianza esta entre el LI y el LS" +
                    " (basados en el nivel de\r\nconfianza proporcionado).\r\n\r\n" +
                    "De estarlo se aceptará la hipótesis nula (H0), delo contrario se" +
                    " aceptará\r\nla hipótesis alternativa(H1). La hipótesis aceptada será" +
                    " subrayada de \r\ncolor verde.";
            }
            else if (seleccion==3)
            {
                lblTitulo.Text = titulo;
                lblDescripcion.Text="Se evalúa si la distribución de los datos es uniforme," +
                    " para ello se definen \r\nm intervalos (m = raíz cuadrada de la cantidad" +
                    " de datos a evaluar) y se\r\ndetermina cuantos números están entre cada " +
                    "intervalo para así conocer\r\nel valor de chi cuadrada de la distribución." +
                    "\r\n\r\nposteriormente esta se compara contra el valor de chi cuadrada de la" +
                    " \r\ntabla (basado en el nivel de confianza proporcionado). Si la primera\r\n" +
                    "chi cuadrada es menor a la segunda significa que la distribución es\r\nuniforme.";
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
