using BACKEND;
using BACKEND.Modelos;
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

namespace Productos
{
    public partial class frmEmpleado : Form
    {
        public bool Guardado { get; set; }

        private int IdEmpleado;
        public frmEmpleado(int id, int idusuario, bool editar) : this(editar)
        {
            IdEmpleado = id;
            //Cargar los datos del usuario
            try
            {
                Empleado objUsuario = new DAOEmpleado().ObtenerUno(id);
                txtNombre.Text = objUsuario.Nombre;
                txtDireccion.Text = objUsuario.Direccion;
                txtTelefono.Text = objUsuario.Telefono;
                cboPuesto.SelectedItem = objUsuario.Puesto;
                txtUsuario.Text = objUsuario.Usuario;
                chkConservar.Visible= true;
                txtContrasenia.Visible=true;
            }
            catch (Exception ex)
            {
                //Mostrar mensaje de error
                MessageBox.Show(ex.Message);
                //Cerrar ventana
                this.Close();
            }

            //Habilitar o deshabilitar componentes dependiendo de la seleccion del usuario
            if (chkConservar.Checked)
            {
                txtContrasenia.Enabled=false;
            }
            else
            {
                txtContrasenia.Enabled=true;
            }
            if (txtNombre.Text.Equals(""))
            {
                chkConservar.Visible=false;
            }
            else
            {
                chkConservar.Visible=true;
            }
            if (editar==true)
            {
                if (id==idusuario)
                {
                    txtContrasenia.Enabled=true;
                    txtAntigua.Enabled=true;
                    btnVerAntigua.Enabled=true;
                    btnOcultarAntigua.Enabled=true;
                    btnVer.Enabled=true;
                    btnOcultar.Enabled=true;
                }
                else
                {
                    txtContrasenia.Enabled=false;
                    txtAntigua.Enabled=false;
                    btnOcultarAntigua.Enabled=false;
                    btnVerAntigua.Enabled=false;
                    btnVer.Enabled=false;
                    btnOcultar.Enabled=false;
                }
            }
            else
            {
                txtAntigua.Enabled=false;
                btnVerAntigua.Enabled=false;
                btnOcultarAntigua.Enabled=false;
            }

        }
        public frmEmpleado(bool editar)
        {
            //Cargar componentes
            InitializeComponent();
            List<Empleado> lista = new DAOEmpleado().ObtenerTodos();
            Empleado objFicticio = new Empleado();
            objFicticio.Id = 0;
            lista.Add(objFicticio);
            cboPuesto.SelectedItem = "Empleado";

            if (txtNombre.Text.Equals(""))
            {
                chkConservar.Visible=false;
            }
            else
            {
                chkConservar.Visible=true;
            }
            if (editar==true)
            {
                txtAntigua.Enabled=true;
                btnVerAntigua.Enabled=false;
                btnOcultarAntigua.Enabled=false;
            }
            else
            {
                txtAntigua.Enabled=false;
                btnVerAntigua.Enabled=false;
                btnOcultarAntigua.Enabled=false;
                txtAntigua.Visible=false;
                btnVerAntigua.Visible=false;
                btnOcultarAntigua.Visible=false;
                lblAntigua.Visible= false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Cerrar ventana
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //Validar datos ingresados por el usuario
            if (txtNombre.Text.Trim().Length<=60 && txtNombre.Text.Trim().Length>0)
            {
                ptbNombre.Visible=true;
            }
            else
            {
                ptbNombre.Visible=false;
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            //Validar datos ingresados por el usuario
            if (txtDireccion.Text.Trim().Length<=60 && txtDireccion.Text.Trim().Length>0)
            {
                ptbDireccion.Visible=true;
            }
            else
            {
                ptbDireccion.Visible=false;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            //Validar datos ingresados por el usuario
            if (txtTelefono.Text.Trim().Length==10 && Regex.IsMatch(txtTelefono.Text.Trim(), "^[1-9]{1}[0-9]{9}$"))
            {
                ptbTelefono.Visible=true;
            }
            else
            {
                ptbTelefono.Visible=false;
            }
        }

        private void cboPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Validar datos ingresados por el usuario
            if (cboPuesto.SelectedItem.Equals(""))
            {
                ptbPuesto.Visible=false;
            }
            else
            {
                ptbPuesto.Visible=true;
            }
        }

        private void chkConservar_CheckedChanged(object sender, EventArgs e)
        {
            //Habilitar o deshabilitar la edicion con contraseña
            if (chkConservar.Checked)
            {
                txtContrasenia.Enabled=false;
                ptbContrasenia.Visible=true;
                txtAntigua.Enabled=false;
                btnOcultarAntigua.Enabled=false;
                btnOcultar.Enabled=false;
                btnVer.Enabled=false;
                btnVerAntigua.Enabled=false;
            }
            else
            {
                txtContrasenia.Enabled=true;
                txtAntigua.Enabled=true;
                ptbContrasenia.Visible=false;
                btnOcultarAntigua.Enabled=false;
                btnOcultar.Enabled=false;
                btnVer.Enabled=false;
                btnVerAntigua.Enabled=false;

            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            //Validar datos ingresados por el usuario
            if (txtUsuario.Text.Trim().Length<=20 && txtUsuario.Text.Trim().Length>0)
            {
                ptbUsuario.Visible=true;
            }
            else
            {
                ptbUsuario.Visible=false;
            }
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            //Validar datos ingresados por el usuario
            if (txtContrasenia.Text.Trim().Length<=20 && txtContrasenia.Text.Trim().Length>0)
            {
                ptbContrasenia.Visible=true;
            }
            else
            {
                ptbContrasenia.Visible=false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Verificar que todas las validaciones fueron exitosas
            if (ptbNombre.Visible==true && ptbDireccion.Visible==true 
                && ptbTelefono.Visible==true && ptbPuesto.Visible==true && ptbUsuario.Visible==true
                && ptbContrasenia.Visible==true)
            {
                try
                {
                    bool resultado = false;
                    //Agregar empleado
                    if (IdEmpleado == 0)
                    {
                        //Crear objeto empleado con los datos necesarios para su creacion
                        Empleado objUsuario = new Empleado();
                        objUsuario.Nombre=txtNombre.Text.Trim(' ');
                        objUsuario.Direccion= txtDireccion.Text.Trim(' ');
                        objUsuario.Telefono= txtTelefono.Text.Trim(' ');
                        objUsuario.Puesto= objUsuario.Puesto= (String)cboPuesto.SelectedItem;
                        objUsuario.Usuario=txtUsuario.Text.Trim(' ');
                        objUsuario.Password=txtContrasenia.Text.Trim(' ');
                        int idGenerado = new DAOEmpleado().agregar(objUsuario);
                        resultado = (idGenerado > 0);
                    }
                    else
                    {
                        //Modificar el usuario sin contraseña
                        if (chkConservar.Checked)
                        {
                            Empleado objUsuario = new Empleado();
                            objUsuario.Id = IdEmpleado;
                            objUsuario.Nombre=txtNombre.Text.Trim(' ');
                            objUsuario.Direccion= txtDireccion.Text.Trim(' ');
                            objUsuario.Telefono= txtTelefono.Text.Trim(' ');
                            objUsuario.Puesto= objUsuario.Puesto= (String)cboPuesto.SelectedItem;
                            objUsuario.Usuario=txtUsuario.Text.Trim(' ');
                            objUsuario.Password=txtContrasenia.Text.Trim(' ');
                            resultado = new DAOEmpleado().editar(objUsuario);
                        }
                        else
                        {
                            //Modificar el usuario con contraseña
                            Empleado objUsuario = new Empleado();
                            objUsuario.Id = IdEmpleado;
                            objUsuario.Nombre=txtNombre.Text.Trim(' ');
                            objUsuario.Direccion= txtDireccion.Text.Trim(' ');
                            objUsuario.Telefono= txtTelefono.Text.Trim(' ');
                            objUsuario.Puesto= objUsuario.Puesto= (String)cboPuesto.SelectedItem;
                            objUsuario.Usuario=txtUsuario.Text.Trim(' ');
                            objUsuario.NuevaPassword=txtContrasenia.Text.Trim(' ');
                            objUsuario.Password=txtAntigua.Text.Trim(' ');
                            resultado = new DAOEmpleado().editarConContrasenia(objUsuario);
                        }
                    }

                    //Mostrar mensaje de exito
                    if (resultado)
                    {
                        Guardado = true;
                        MessageBox.Show("Empleado almacenado correctamente", "Guardado", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        //Mostrar mensaje de error
                        MessageBox.Show("Se ha encontrado un error al almacenar, " +
                            "verifique su contraseñaa actual", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    //Mostrar mensaje de error
                    MessageBox.Show(this, ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //Mostrar mensaje de error
                MessageBox.Show("Datos incompletos o inválidos " +
                    "\nPosiciona el cursor sobre las cajas de texto para obtener más información ",
                    "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            //Alternar posicion de los botones
            btnOcultar.BringToFront();
            txtContrasenia.UseSystemPasswordChar=false;
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            //Alternar posicion de los botones
            btnVer.BringToFront();
            txtContrasenia.UseSystemPasswordChar=true;
        }

        private void btnVerAntigua_Click(object sender, EventArgs e)
        {
            //Alternar posicion de los botones
            btnOcultarAntigua.BringToFront();
            txtAntigua.UseSystemPasswordChar=false;
        }

        private void btnOcultarAntigua_Click(object sender, EventArgs e)
        {
            //Alternar posicion de los botones
            btnVerAntigua.BringToFront();
            txtAntigua.UseSystemPasswordChar=true;
        }
    }
}
