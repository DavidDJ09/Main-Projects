using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadradosMedios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dgvDatos.DefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
            this.dgvDatos.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
        }

        public double[] numeros; // Este arreglo es el que enviaremos de regreso con los numeros
        public double[] cuadrado; //Este arreglo son los numeros generados al cuadrado
        public string[] completo;  //Arreglo con los numeros completos si les faltaba un 0
        public string[] central;   //los numeros del numcentro

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtSemilla.BackColor==Color.LightGreen && nudCantidad.Value>0)
            {
                dgvDatos.Rows.Clear();
                Generar(4, Convert.ToDouble(nudCantidad.Value), Convert.ToDouble(txtSemilla.Text));
                r(numeros, 4);
            }
        }

        public void Generar(double digitosE, double total, double inicialE)//aqui esta el metodo al que le enviamos los datos del post pasado
        {

            double totalnum = total;
            double digitos = digitosE;
            double inicial = inicialE;
            numeros = new double[int.Parse(totalnum.ToString()) + 1];
            cuadrado = new double[int.Parse(totalnum.ToString())];
            completo = new string[int.Parse(totalnum.ToString())];
            central = new string[int.Parse(totalnum.ToString())];

            string numero;
            //numeros[0] = inicial;


            for (int i = 1; i <= totalnum; i++)//aqui implementamos el metodo de cuadrado medio
            {
                inicial = Math.Pow(inicial, 2);
                cuadrado[i - 1] = inicial;

                double equilibrado = (inicial.ToString().Count()) - digitos; //asi sabremos si no faltan 0
                double eliminarlugares;
                double cantidad= inicial.ToString().Count();
                double faltantes = 8-inicial.ToString().Count();
                if (cantidad>=8)
                {
                    numero = inicial.ToString();
                    eliminarlugares = equilibrado / 2;
                    completo[i - 1] = numero;

                }
                else
                {
                    numero= inicial.ToString();
                    for (int j = 0; j < faltantes; j++)
                    {
                        numero="0"+numero;
                    }
                    //numero = "0" + inicial.ToString();
                    eliminarlugares = (equilibrado + 1) / 2;
                    completo[i - 1] = numero;
                }

                string numcentro = "X"; //esta cadena ocupara los lugares que no necesitamos
                for (int h = 0; h < numero.Count(); h++)
                {

                    if (h < eliminarlugares)
                    {
                        numcentro = numcentro + "X";
                    }
                    else
                        if (h >= (eliminarlugares + digitos))
                    {
                        numcentro = numcentro + "X";
                    }
                    else
                        numcentro = numcentro + numero[h].ToString();

                }
                numcentro=numcentro.Replace("X", ""); //aqui cambiamos las X por lugares vacios
                central[i - 1] = numcentro;
                numeros[i] = double.Parse(numcentro);//aqui se van guardando los numeros aleatorios
                inicial = double.Parse(numcentro);
            }
        }

        public void r(double[] numeros, int digitos)
        {
            string num;
            string x;
            string[] resultado = new string[numeros.Length];
            string[] xi = new string[numeros.Length];
            int i = 0;
            foreach (double numero in numeros)
            {
                x= num= numero.ToString();
                if (num.Length<digitos)
                {
                    while (num.Length<digitos)
                    {
                        num="0"+num;
                    }
                }
                xi[i]=num;
                resultado[i]="0."+num;
                i++;
            }

            string[] conCeros= new string[cuadrado.Length];
            int j=0;
            foreach (double numero in cuadrado)
            {
                double cantidad = numero.ToString().Count();
                double faltantes = 8-cantidad;
                string ceros=numero.ToString();
                if (cantidad<8)
                {
                    ceros= numero.ToString();
                    for (int k = 0; k < faltantes; k++)
                    {
                        ceros="0"+ceros;
                    }
                }
                else
                {
                    double equilibrado = numero.ToString().Count() - 4;
                    if (equilibrado%2!=0)
                    {
                        ceros="0"+ceros;
                    }
                }
                conCeros[j]=ceros;
                j++;
            }
            impresion(xi, resultado,conCeros);
        }

        public void impresion(string[] xi, string[] ri, string[] ceros)
        {
            for (int i = 1; i < ri.Length; i++)
            {
                int rowEscribir = dgvDatos.Rows.Count;

                dgvDatos.Rows.Add(i,Math.Sqrt(cuadrado[i - 1]), cuadrado[i - 1].ToString(), ceros[i-1], xi[i].ToString(), ri[i].ToString());
            }

            //Ajustar tamaño de celdas de acuerdo al tamaño del texto
            foreach (DataGridViewColumn columna in dgvDatos.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void txtSemilla_TextChanged(object sender, EventArgs e)
        {
            if (txtSemilla.Text.Trim().Length>3 && txtSemilla.Text.Trim().Length>0
                && Regex.IsMatch(txtSemilla.Text.Trim(), "^[1-9]{1}[0-9]{3,10}$"))
            {
                erpError.Clear();
                txtSemilla.BackColor=Color.LightGreen;
            }
            else
            {
                erpError.SetError(txtSemilla, "Ingrese un valor numérico de más de 3 dígitos");
                txtSemilla.BackColor=Color.White;
            }
        }
    }
}
