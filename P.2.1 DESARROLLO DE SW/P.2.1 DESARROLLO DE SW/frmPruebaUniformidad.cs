using MathNet.Numerics;
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
    public partial class frmPruebaUniformidad : Form
    {
        double[] num;
        public frmPruebaUniformidad(double[] numeros)
        {
            InitializeComponent();
            this.dgvDatos.DefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
            this.dgvDatos.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 10);
            num=numeros;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNConfianza.BackColor==Color.LightGreen)
            {
                realizarPrueba();
                dgvDatos.Visible= true;
            }
        }

        private void txtNConfianza_TextChanged(object sender, EventArgs e)
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

        private void txtNConfianza_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }

        private void realizarPrueba()
        {
            dgvDatos.Rows.Clear();
            int n = num.Length-1;
            double m = Convert.ToDouble(Math.Ceiling(Math.Sqrt(n)));
            double salto = 1/m;
            double inter = 0.0;
            int o = 0;
            double e = n/m;
            double x2 = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (num[j]>inter && num[j]<=inter+salto)
                    {
                        o++;
                    }
                }
                double div = Math.Pow(e-o, 2)/e;
                x2=x2+div;
                dgvDatos.Rows.Add(Math.Round(inter, 4), Math.Round(inter+salto, 4), o, Math.Round(e, 4), Math.Round(div, 4));

                //Ajustar tamaño de celdas de acuerdo al tamaño del texto
                foreach (DataGridViewColumn columna in dgvDatos.Columns)
                {
                    columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                inter=inter+salto;
                o=0;
            }

            double gLibertad = m-1;
            double a2 = Convert.ToDouble(txtNConfianza.Text)*0.01;
            double chicuad = MathNet.Numerics.Distributions.ChiSquared.InvCDF(gLibertad, a2);

            //Mostrar resultados
            lblX2.Text=Math.Round(x2, 4).ToString();
            lblTabla.Text=Math.Round(chicuad, 4).ToString();
            lblGLibertad.Text=Math.Round(gLibertad, 4).ToString();
            lblM.Text=m.ToString();
            lblN.Text=n.ToString();

            if (x2<chicuad)
            {
                lblUniforme.Text="SI";
                lblUniforme.ForeColor=Color.LimeGreen;
            }
            else
            {
                lblUniforme.Text="NO";
                lblUniforme.ForeColor=Color.Red;
            }
        }

        private void btnDescripcion_Click(object sender, EventArgs e)
        {
            frmDescripcionPruebasMV frm = new frmDescripcionPruebasMV(3, lblTitulo.Text);
            frm.ShowDialog();
        }
    }
}
