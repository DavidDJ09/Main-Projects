using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P._2._1_DESARROLLO_DE_SW
{
    public partial class frmProductosMedios : Form
    {
        public frmProductosMedios()
        {
            InitializeComponent();
            this.dgvDatos.DefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
            this.dgvDatos.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
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
                erpError.SetError(txtSemilla, "Ingrese un valor numérico positivo de más de 3 dígitos");
                txtSemilla.BackColor=Color.White;
            }
        }

        private void txtSemilla2_TextChanged(object sender, EventArgs e)
        {
            if (txtSemilla2.Text.Trim().Length>3 && txtSemilla2.Text.Trim().Length>0
                && Regex.IsMatch(txtSemilla2.Text.Trim(), "^[1-9]{1}[0-9]{3,10}$"))
            {
                erpError.Clear();
                txtSemilla2.BackColor=Color.LightGreen;
            }
            else
            {
                erpError.SetError(txtSemilla2, "Ingrese un valor numérico positivo de más de 3 dígitos");
                txtSemilla2.BackColor=Color.White;
            }
        }

        public double[] numeros;       //Este arreglo es el que enviaremos de regreso con los numeros
        public double[] producto;     //Este arreglo son los numeros generados al multiplicar
        public string[] completo;    //Arreglo con los numeros completos si les faltaba un 0
        public string[] central;    //Los numeros del centro
        public double[] semilla2;  //Almacena los multiplicadores

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtSemilla.BackColor==Color.LightGreen && nudCantidad.Value>0)
            {
                dgvDatos.Rows.Clear();
                Generar(4, Convert.ToDouble(nudCantidad.Value), Convert.ToDouble(txtSemilla.Text), Convert.ToDouble(txtSemilla2.Text));
                r(numeros, 4);
                habilitarPruebas();
            }
        }

        public void Generar(double digitosE, double total, double inicialE, double multiplicador)//aqui esta el metodo al que le enviamos los datos del post pasado
        {
            double totalnum = total;
            double digitos = digitosE;
            double inicial = inicialE;
            double multip = multiplicador;
            numeros = new double[int.Parse(totalnum.ToString()) + 1];
            producto = new double[int.Parse(totalnum.ToString())];
            completo = new string[int.Parse(totalnum.ToString())];
            central = new string[int.Parse(totalnum.ToString())];
            semilla2 = new double[int.Parse(totalnum.ToString()) + 1];

            string numero;
            semilla2[0]=multiplicador;


            for (int i = 1; i <= totalnum; i++)//aqui implementamos el metodo de multiplicador constante
            {
                if (i>=2)
                {
                    inicial = inicial*semilla2[i-2];
                }
                else
                {
                    inicial = inicial*semilla2[i-1];
                }
                
                multip=semilla2[i-1];
                producto[i-1] = inicial;

                double equilibrado = (inicial.ToString().Count()) - digitos; //asi sabremos si no faltan 0
                double eliminarlugares;
                double cantidad = inicial.ToString().Count();
                double faltantes = 8-inicial.ToString().Count();
                if (equilibrado % 2 == 0)
                {
                    numero = inicial.ToString();
                    eliminarlugares = equilibrado / 2;
                    completo[i - 1] = numero;
                }
                else
                {
                    numero= inicial.ToString();
                    numero = "0" + inicial.ToString();
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
                semilla2[i]=Convert.ToDouble(numcentro);
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
            xi[0]=txtSemilla.Text;

            string[] conCeros = new string[producto.Length];
            int j = 0;
            foreach (double numero in producto)
            {
                double cantidad = numero.ToString().Count();
                double faltantes = 8-cantidad;
                string ceros = numero.ToString();
                if (numero.ToString().Length % 2 != 0)
                {
                    ceros= numero.ToString();
                    ceros="0"+ceros;
                }
                conCeros[j]=ceros;
                j++;
            }
            impresion(xi, resultado, conCeros);
        }

        public void impresion(string[] xi, string[] ri, string[] ceros)
        {
            for (int i = 1; i < ri.Length; i++)
            {
                int rowEscribir = dgvDatos.Rows.Count;
                if (i<2)
                {
                    if (i==1)
                    {
                        dgvDatos.Rows.Add(i, xi[i-1], semilla2[i-1], producto[i - 1].ToString(), ceros[i-1], xi[i].ToString(), ri[i].ToString());
                    }
                    else
                    {
                        dgvDatos.Rows.Add(i, semilla2[i-1], xi[i-1], producto[i - 1].ToString(), ceros[i-1], xi[i].ToString(), ri[i].ToString());
                    }        
                }
                else
                {
                    dgvDatos.Rows.Add(i, semilla2[i-2], xi[i-1], producto[i - 1].ToString(), ceros[i-1], xi[i].ToString(), ri[i].ToString());
                }   
            }

            //Ajustar tamaño de celdas de acuerdo al tamaño del texto
            foreach (DataGridViewColumn columna in dgvDatos.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void habilitarPruebas()
        {
            btnPruebas.Visible=true;
            chkMedias.Visible=true;
            chkVarianza.Visible=true;
            chkUniformidad.Visible=true;
            rdbPruebas.Visible=true;
            dgvDatos.Visible= true;
            rdbPruebas.Enabled= true;
        }

        private void rdbPruebas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPruebas.Checked)
            {
                chkMedias.Enabled=true;
                chkUniformidad.Enabled=true;
                chkVarianza.Enabled=true;
                btnPruebas.Enabled=true;
            }
            else
            {
                chkMedias.Enabled=false;
                chkUniformidad.Enabled=false;
                chkVarianza.Enabled=false;
                btnPruebas.Enabled=false;
            }

        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            if (chkMedias.Checked)
            {
                frmPruebasMedias frm = new frmPruebasMedias(recopilar(numeros, 4));
                frm.ShowDialog();
            }
            if (chkVarianza.Checked)
            {
                frmPruebasVarianza frm = new frmPruebasVarianza(recopilar(numeros, 4));
                frm.ShowDialog();
            }
            if (chkUniformidad.Checked)
            {
                frmPruebaUniformidad frm = new frmPruebaUniformidad(recopilar(numeros, 4));
                frm.ShowDialog();
            }
            else
            {
                erpError.SetError(btnPruebas, "Seleccione almenos una tipo de prueba");
            }
        }

        public double[] recopilar(double[] numeros, int digitos)
        {
            string num;
            string x;
            string[] resultado = new string[numeros.Length];
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
                resultado[i]="0."+num;
                i++;
            }

            double[] numresul = new double[resultado.Length];
            int j = 0;
            foreach (string numero in resultado)
            {
                numresul[j]=Convert.ToDouble(numero);
                j++;
            }

            return numresul;
        }

        private void btnDescripcion_Click(object sender, EventArgs e)
        {
            frmDescripcion frm = new frmDescripcion(3, lblTitulo.Text);
            frm.ShowDialog();
        }
    }
}
