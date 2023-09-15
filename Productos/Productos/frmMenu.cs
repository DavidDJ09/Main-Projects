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
    public partial class frmMenu : Form
    {
        int id;
        public frmMenu(int idEmpleado)
        {
            //Cargar componentes
            InitializeComponent();

            //Ocultar componentes innecesarios al ingresar
            lblTitulo.Parent = ptbBanner;
            lblTitulo.BackColor = Color.Transparent;
            ptbLogo.Parent = ptbBanner;
            ptbLogo.BackColor = Color.Transparent;
            ptbEmpleados.Visible= false;
            ptbProductos.Visible= false;
            ptbRegistros.Visible= false;
            ptbVentas.Visible= false;

            //Obtener usuario que inicio sesion
            id=idEmpleado;
            Empleado user = new DAOEmpleado().ObtenerUno(id);

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            //Abrir pantalla de presentacion de registros de productos
            //y adaptar el menu
            panel1.Controls.Clear();
            frmPresProductos frm = new frmPresProductos();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Parent=panel1;
            frm.Show();
            ptbEmpleados.Visible= false;
            ptbProductos.Visible= true;
            ptbRegistros.Visible= false;
            ptbVentas.Visible= false;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            //Abrir pantalla de presentacion de registros de empleados
            //y adaptar el menu
            panel1.Controls.Clear();
            frmPresEmpleados frm = new frmPresEmpleados(id);
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Parent=panel1;
            frm.Show();
            ptbEmpleados.Visible= true;
            ptbProductos.Visible= false;
            ptbRegistros.Visible= false;
            ptbVentas.Visible= false;
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            //Abrir pantalla de ventas y adaptar el menu
            panel1.Controls.Clear();
            frmVentas frm = new frmVentas(id);
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Parent=panel1;
            frm.Show();
            ptbEmpleados.Visible= false;
            ptbProductos.Visible= false;
            ptbRegistros.Visible= false;
            ptbVentas.Visible= true;
        }

        private void btnRegistrosVentas_Click(object sender, EventArgs e)
        {
            //Abrir pantalla de presentacion de registros de ventas
            //y adaptar el menu
            panel1.Controls.Clear();
            frmPresVentas frm = new frmPresVentas();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Parent=panel1;
            frm.Show();
            ptbEmpleados.Visible= false;
            ptbProductos.Visible= false;
            ptbRegistros.Visible= true;
            ptbVentas.Visible= false;
        }
    }
}
