using Datos;
using Modelos;
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

namespace Categorias_Clientes
{
    public partial class frmCliente : Form
    {
        public bool Guardado { get; set; }
        public frmCliente()
        {
            InitializeComponent();
        }

        private int idCliente;
        public frmCliente(int id) : this()
        {
            idCliente = id;
            //Cargar el usuario de la BD
            try
            {
                Cliente objCliente = new DAOCliente().ObtenerUno(id);
                txtNombre.Text = objCliente.Nombre;
                txtDireccion.Text = objCliente.Direccion;
                txtColonia.Text = objCliente.Colonia;
                txtMunicipio.Text = objCliente.Municipio;
                txtEstado.Text = objCliente.Estado;
                txtCP.Text = objCliente.CP;
                txtTelefono.Text = objCliente.Telefono;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ptbNombre.Visible==true && ptbDireccion.Visible==true && ptbColonia.Visible==true
                && ptbMunicipio.Visible==true && ptbEstado.Visible==true && ptbCP.Visible==true
                && ptbTelefono.Visible==true)
            {
                try
                {
                    Cliente objCliente = new Cliente();
                    objCliente.Nombre = txtNombre.Text.Trim();
                    objCliente.Direccion = txtDireccion.Text.Trim();
                    objCliente.Colonia = txtColonia.Text.Trim();
                    objCliente.Municipio = txtMunicipio.Text.Trim();
                    objCliente.Estado = txtEstado.Text.Trim();
                    objCliente.CP = txtCP.Text.Trim();
                    objCliente.Telefono = txtTelefono.Text.Trim();
                    bool resultado = false;
                    //Agregar empleado
                    if (idCliente == 0)
                    {
                        int idGenerado = new DAOCliente().agregar(objCliente);
                        resultado = (idGenerado > 0);
                    }
                    else
                    {//Modificar el usuario
                        objCliente.Id = idCliente;
                        resultado = new DAOCliente().editar(objCliente);
                    }

                    if (resultado)
                    {
                        Guardado = true;
                        MessageBox.Show("Cliente almacenado correctamente", "Guardado", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Se ha encontrado un error al almacenar, verifique la información" +
                            " e inténtelo de nuevo más tarde", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error al guardar", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Datos incompletos o inválidos", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length<=40 && txtNombre.Text.Trim().Length>0)
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
            if (txtDireccion.Text.Trim().Length<=40 && txtDireccion.Text.Trim().Length>0)
            {
                ptbDireccion.Visible=true;
            }
            else
            {
                ptbDireccion.Visible=false;
            }
        }

        private void txtColonia_TextChanged(object sender, EventArgs e)
        {
            if (txtColonia.Text.Trim().Length<=40 && txtColonia.Text.Trim().Length>0)
            {
                ptbColonia.Visible=true;
            }
            else
            {
                ptbColonia.Visible=false;
            }
        }

        private void txtMunicipio_TextChanged(object sender, EventArgs e)
        {
            if (txtMunicipio.Text.Trim().Length<=40 && txtMunicipio.Text.Trim().Length>0)
            {
                ptbMunicipio.Visible=true;
            }
            else
            {
                ptbMunicipio.Visible=false;
            }
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            if (txtEstado.Text.Trim().Length<=30 && txtEstado.Text.Trim().Length>0)
            {
                ptbEstado.Visible=true;
            }
            else
            {
                ptbEstado.Visible=false;
            }
        }

        private void txtCP_TextChanged(object sender, EventArgs e)
        {
            if (txtCP.Text.Trim().Length==5 && Regex.IsMatch(txtCP.Text.Trim(), "^[1-9]{1}[0-9]{4}$"))
            {
                ptbCP.Visible=true;
            }
            else
            {
                ptbCP.Visible=false;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Trim().Length==10 && Regex.IsMatch(txtTelefono.Text.Trim(), "^[1-9]{1}[0-9]{9}$"))
            {
                ptbTelefono.Visible=true;
            }
            else
            {
                ptbTelefono.Visible=false;
            }
        }
    }
}
