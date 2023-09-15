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
    public partial class frmPruebasVarianza : Form
    {
        double[] num;
        public frmPruebasVarianza(double[] numeros)
        {
            InitializeComponent();
            num=numeros;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNConfianza.BackColor==Color.LightGreen)
            {
                realizarPrueba();
            }
        }

        private void txtAlfa_TextChanged(object sender, EventArgs e)
        {
            if (txtNConfianza.Text.Trim().Length>0
                && Regex.IsMatch(txtNConfianza.Text.Trim(), "^[1-9]{1,2}$")
                || Regex.IsMatch(txtNConfianza.Text.Trim(), "^[1-9]{1}$")
                || Regex.IsMatch(txtNConfianza.Text.Trim(), "^[1-9]{1}[0-9]{1}$"))
            {
                erpError.Clear();
                txtNConfianza.BackColor=Color.LightGreen;
            }
            else
            {
                erpError.SetError(txtNConfianza, "Ingrese un valor numérico de 1 a 99");
                txtNConfianza.BackColor=Color.White;
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAlfa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }

        private void realizarPrueba()
        {
            double suma = 0;
            for (int i = 0; i < num.Length; i++)
            {
                suma=suma+num[i];
            }
            double promedio = Math.Round(suma/ (num.Length-1), 4);

            double[] cuadrado = new double[num.Length];
            for (int i = 1; i < num.Length; i++)
            {
                cuadrado[i]=Math.Pow(num[i]-promedio, 2);
            }

            double suma2 = 0;
            for (int i = 0; i < num.Length; i++)
            {
                suma2=suma2+cuadrado[i];
            }
            double varianza = Math.Round(suma2/ (num.Length-2), 4);

            double gLibertad = num.Length-2;
            double alfa = 1-(Convert.ToDouble(txtNConfianza.Text)*0.01);
            double a2 = alfa/2;
            double a = 1-a2;
            double chicuad = MathNet.Numerics.Distributions.ChiSquared.InvCDF(gLibertad, a);
            double ls = chicuad/(12*gLibertad);
            double chicuad2 = MathNet.Numerics.Distributions.ChiSquared.InvCDF(gLibertad, a2);
            double li = chicuad2/(12*gLibertad);

            lblVarianza.Text=Math.Round(varianza, 4).ToString();
            lblGLibertad.Text=gLibertad.ToString();
            lblX2.Text= Math.Round(chicuad2, 4).ToString();
            lblLS.Text= Math.Round(ls, 4).ToString();
            lblX2LS.Text= Math.Round(chicuad, 4).ToString();
            lblLI.Text= Math.Round(li, 4).ToString();

            if (varianza>=li && varianza<=ls)
            {
                lblH0.BackColor=Color.LightGreen;
                lblH1.BackColor=Color.LightSalmon;

            }
            else
            {
                lblH0.BackColor=Color.LightSalmon;
                lblH1.BackColor=Color.LightGreen;
            }
        }

        private void btnDescripcion_Click(object sender, EventArgs e)
        {
            frmDescripcionPruebasMV frm = new frmDescripcionPruebasMV(2, lblTitulo.Text);
            frm.ShowDialog();
        }
    }
}
