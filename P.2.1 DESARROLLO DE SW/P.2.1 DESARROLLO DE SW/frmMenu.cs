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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCuadradosMedios_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.BackgroundImage=null;
            frmCuadradosMedios frm = new frmCuadradosMedios();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Parent=panel1;
            frm.Show();
        }

        private void btnProductosMedios_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.BackgroundImage=null;
            frmProductosMedios frm = new frmProductosMedios();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Parent=panel1;
            frm.Show();
        }

        private void btnMultConstante_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.BackgroundImage=null;
            frmMulConstante frm = new frmMulConstante();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Parent=panel1;
            frm.Show();
        }
    }
}
