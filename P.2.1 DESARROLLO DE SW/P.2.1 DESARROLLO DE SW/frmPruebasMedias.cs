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
using MathNet.Numerics;

namespace P._2._1_DESARROLLO_DE_SW
{
    public partial class frmPruebasMedias : Form
    {
        double[] num;
        public frmPruebasMedias(double[] numeros)
        {
            InitializeComponent();
            num=numeros;
        }

        private void txtNAceptacion_TextChanged(object sender, EventArgs e)
        {
            if (txtNAceptacion.Text.Trim().Length>0
                && Regex.IsMatch(txtNAceptacion.Text.Trim(), "^[1-9]{1,2}$")
                || Regex.IsMatch(txtNAceptacion.Text.Trim(), "^[1-9]{1}$")
                || Regex.IsMatch(txtNAceptacion.Text.Trim(), "^[1-9]{1}[0-9]{1}$"))
            {
                erpError.Clear();
                txtNAceptacion.BackColor=Color.LightGreen;
            }
            else
            {
                erpError.SetError(txtNAceptacion, "Ingrese un valor numérico de 1 a 99");
                txtNAceptacion.BackColor=Color.White;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNAceptacion.BackColor==Color.LightGreen)
            {
                realizarPrueba();
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNAceptacion_KeyUp(object sender, KeyEventArgs e)
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

            double a2 = 1-((1-(Convert.ToDouble(txtNAceptacion.Text)*0.01))/2);

            int n = num.Length-1;

            double z = MathNet.Numerics.Distributions.Normal.InvCDF(0, 1, a2);

            double li = 0.5-z*(1/Math.Sqrt(12*n));
            double ls = 0.5+z*(1/Math.Sqrt(12*n));

            lblA2.Text=a2+"";
            lblZ.Text= ""+Math.Round(z, 2);
            lblPromedio.Text=promedio.ToString();
            lblLI.Text=""+Math.Round(li, 4);
            lblLS.Text=""+Math.Round(ls, 4);
            lblN.Text=n+"";

            if (promedio>=li && promedio<=ls)
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
            frmDescripcionPruebasMV frm = new frmDescripcionPruebasMV(1, lblTitulo.Text);
            frm.ShowDialog();
        }
    }
}
