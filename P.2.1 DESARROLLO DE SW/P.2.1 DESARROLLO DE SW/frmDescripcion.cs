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
    public partial class frmDescripcion : Form
    {
        int seleccion;
        string texto;
        public frmDescripcion(int numero, string titulo)
        {
            InitializeComponent();
            seleccion = numero;
            texto = titulo;
            mostrarDescripcion(seleccion,texto);
        }

        private void mostrarDescripcion(int seleccion, string titulo)
        {
            if (seleccion==1)
            {
                lblTitulo.Text = titulo;
                lblDescripcion.Text="Pasos para generar números con el algoritmo" +
                    " de cuadrados medios:\r\n\r\n1.- Seleccionar una semilla (X0)" +
                    " con D dígitos (D>3).\r\n\r\n2.- Sea X0 = resultado de elevar X0" +
                    " al cuadrado; sea X1 = los 4 dígitos del centro, y sea ri =0. 4 dígitos" +
                    " del centro.\r\n\r\n3.- Sea Yi = resultado de elevar Xi al cuadrado;" +
                    " sea Xi+1 = los 4 dígitos del centro, y sea ri =0. D dígitos \r\n\r\n del centro para" +
                    " toda i=1, 2, 3,…, n.\r\n\r\n4.- Repetir el paso 3 hasta obtener los n números" +
                    " ri deseados.\r\n\r\n Si no es posible obtener los D dígitos del centro" +
                    " del número Yi, agregar ceros a la izquierda del número Yi.";
            }
            else if (seleccion==2)
            {
                lblTitulo.Text = titulo;
                lblDescripcion.Text="Pasos para generar números con el algoritmo" +
                    " de multiplicador constante:\r\n\r\n1.- Seleccionar una semilla (X0) con D" +
                    " dígitos (D > 3). \r\n\r\n 2.- Seleccionar una constante (a) con D dígitos" +
                    " (D > 3). \r\n\r\n3.- Sea Y0 = a * X0 ; sea X1 = los 4 dígitos del centro" +
                    " y sea r1 = 0.4 dígitos del centro. \r\n\r\n4.- Sea Yi = a * Xi ; sea Xi+1 =" +
                    " los 4 dígitos del centro y sea ri+1 = 0.4 dígitos del centro para toda" +
                    " i = 1, 2, 3,...,n . \r\n\r\n5.- Repetir el paso 4 hasta obtener los n" +
                    " números ir deseados. \r\n\r\nSi no es posible obtener los 4 dígitos" +
                    " del centro del número Yi, agregar ceros a la izquierda del número Yi.";
            }
            else if (seleccion==3)
            {
                lblTitulo.Text = titulo;
                lblDescripcion.Text="Pasos para generar números con el algoritmo de productos" +
                    " medios:\r\n\r\n1.- Seleccionar una semilla (X0) con D dígitos (D>3)." +
                    "\r\n\r\n2.- Seleccionar una semilla (X1) con D dígitos (D>3).\r\n\r\n" +
                    "3.- Sea Y0 = X0 * X1; sea X2 = los 4 dígitos del centro, y sea ri = 0." +
                    " 4 dígitos del centro.\r\n\r\n4.- Sea Yi = X1 * Xi+1; sea Xi+2 = los 4" +
                    " dígitos del centro, y sea ri+1 = 0. 4 dígitos del centro para toda" +
                    " i= 1, 2, 3,…, n.\r\n\r\n5.- Repetir el paso 4 hasta obtener los n números" +
                    " ri deseados.\r\n\r\nSi no es posible obtener los 4 dígitos del" +
                    " centro del número Yi, agregue ceros a la izquierda del numero Yi.";
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
