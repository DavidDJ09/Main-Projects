using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Categorias_Clientes
{
    public partial class frmCategoria : Form
    {
        public bool Guardado { get; set; }
        public frmCategoria()
        {
            InitializeComponent();
        }

        private int idCategoria;
        public frmCategoria(int id) : this()
        {
            idCategoria = id;
            //Cargar el usuario de la BD
            try
            {
                Categoria objCategoria = new DAOCategoria().ObtenerUno(id);
                txtNombre.Text = objCategoria.Nombre;
                txtDescripcion.Text = objCategoria.Descripcion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ptbNombre.Visible==true && ptbDescripcion.Visible==true)
            {
                try
                {
                    Categoria objCategoria = new Categoria();
                    objCategoria.Nombre = txtNombre.Text.Trim();
                    objCategoria.Descripcion = txtDescripcion.Text.Trim();
                    bool resultado = false;
                    //Agregar empleado
                    if (idCategoria == 0)
                    {
                        int idGenerado = new DAOCategoria().agregar(objCategoria);
                        resultado = (idGenerado > 0);
                    }
                    else
                    {//Modificar el usuario
                        objCategoria.Id = idCategoria;
                        resultado = new DAOCategoria().editar(objCategoria);
                    }

                    if (resultado)
                    {
                        Guardado = true;
                        MessageBox.Show("Categoría almacenada correctamente", "Guardado", MessageBoxButtons.OK,
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

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Trim().Length<=200 && txtDescripcion.Text.Trim().Length>0)
            {
                ptbDescripcion.Visible=true;
            }
            else
            {
                ptbDescripcion.Visible=false;
            }
        }
    }
}
