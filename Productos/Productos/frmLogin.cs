using BACKEND;
using BACKEND.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            //Cargar componentes
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Cerrar sistema
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            entrar();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            //Alternar posicon de los botones
            btnOcultar.BringToFront();
            txtPassword.UseSystemPasswordChar=false;
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            //Alternar posicon de los botones
            btnVer.BringToFront();
            txtPassword.UseSystemPasswordChar=true;
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            //Shortcut sobre la caja de texto contraseña
            if (e.KeyCode == Keys.Enter)
            {
                entrar();
            }
        }

        private void entrar()
        {
            //Validar usuario y contraseña proporcionados para iniciar sesion
            DAOEmpleado dao = new DAOEmpleado();
            Empleado usuario = dao.IniciarSesion(txtUsuario.Text, txtPassword.Text);
            if (usuario != null)
            {
                //Obtener el id del usuario que inicio sesion
                int idEmpleado = usuario.Id;

                //Abrir menu principal
                frmMenu menu = new frmMenu(idEmpleado);
                menu.ShowDialog();
                this.Hide();
            }
            else
            {
                //Mostrar mensaje de error
                MessageBox.Show("Usuario y/o Contraseña incorrectos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
