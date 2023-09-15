using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
           
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="usuario" || txtUsuario.Text=="admin"
                && txtContrasena.Text=="123")
            {
                Program.usuario=txtUsuario.Text;
                new frmMenu().Show();
                this.Hide();
            }
            else
            {
                errorProvider1.SetError(txtUsuario,"Usuario y/o Contraseña Incorrectos");
                errorProvider1.SetError(txtContrasena, "Usuario y/o Contraseña Incorrectos");
                //MessageBox.Show(this, "Usuario y/o Contraseña incorrectos",
                    //"Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
