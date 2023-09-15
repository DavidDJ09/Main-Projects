using BACKEND;
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
    public partial class frmProducto : Form
    {
        public bool Guardado { get; set; }

        private int idProducto;
        public frmProducto(int id) : this()
        {
            idProducto = id;
            //Cargar los datos del producto
            try
            {
                Producto objProducto = new DAOProducto().ObtenerUno(id);
                txtCodigo.Text = objProducto.CodigoBarras.ToString();
                txtCodigo.Enabled=false;
                txtDescripcion.Text = objProducto.Descripcion.ToString();
                txtCantidad.Text = objProducto.Cantidad.ToString();
                txtPrecioCompra.Text = objProducto.PrecioCompra.ToString();
                txtPrecioVenta.Text = objProducto.PrecioVenta.ToString();
                txtPrecioOferta.Text = objProducto.PrecioOferta.ToString();
                if (objProducto.Granel)
                {
                    chkGranel.Checked=true;
                }
                else
                {
                    chkGranel.Checked=false;
                }
            }
            catch (Exception ex)
            {
                //Mostrar mensaje de error
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
        public frmProducto()
        {
            //Cargar componentes
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Verificar que todas las validaciones fueron exitosas
            if (ptbDescripcion.Visible==true && ptbCantidad.Visible==true && ptbCodigo.Visible==true
                && ptbPrecioCompra.Visible==true && ptbPrecioVenta.Visible==true && ptbPrecioOferta.Visible==true)
            {
                try
                {
                    //Crear objeto producto con los datos necesarios para su creacion
                    Producto objProducto = new Producto();
                    objProducto.Descripcion = txtDescripcion.Text.Trim();
                    objProducto.CodigoBarras = txtCodigo.Text.Trim();
                    objProducto.PrecioCompra = Convert.ToDouble(txtPrecioCompra.Text.Trim());
                    objProducto.PrecioVenta = Convert.ToDouble(txtPrecioVenta.Text.Trim());
                    objProducto.PrecioOferta = Convert.ToDouble(txtPrecioOferta.Text.Trim());
                    objProducto.Cantidad = Convert.ToDouble(txtCantidad.Text.Trim());
                    if (chkGranel.Checked)
                    {
                        objProducto.Granel = true;
                    }
                    else
                    {
                        objProducto.Granel = false;
                    }
                    bool resultado = false;
                    //Agregar producto
                    if (idProducto == 0)
                    {
                        int idGenerado = new DAOProducto().agregar(objProducto);
                        resultado = (idGenerado > 0);
                    }
                    else
                    {
                        //Modificar el registro
                        objProducto.Id = idProducto;
                        resultado = new DAOProducto().editar(objProducto);
                    }

                    //Mostrar mensaje de exito
                    if (resultado)
                    {
                        Guardado = true;
                        MessageBox.Show("Producto almacenado correctamente", "Guardado", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        //Cerrar pantalla
                        this.Close();
                    }
                    else
                    {
                        //Mostrar mensaje de error
                        MessageBox.Show("Se ha encontrado un error al almacenar, verifique la información" +
                            " e inténtelo de nuevo más tarde", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
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
                MessageBox.Show("Datos incompletos o inválidos, coloque el cursor sobre las cajas de texto " +
                    "para obtener más información", "Error", MessageBoxButtons.OK
                   , MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Cerrar la pantalla
            this.Close();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            //Validar datos ingresados por el usuario
            if (txtCodigo.Text.Trim().Length==13 && txtCodigo.Text.Trim().Length>0
                && Regex.IsMatch(txtCodigo.Text.Trim(), "^[0-9]{13}$"))
            {
                ptbCodigo.Visible=true;
            }
            else
            {
                ptbCodigo.Visible=false;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            //Validar datos ingresados por el usuario
            if (txtDescripcion.Text.Trim().Length<=50 && txtDescripcion.Text.Trim().Length>0)
            {
                ptbDescripcion.Visible=true;
            }
            else
            {
                ptbDescripcion.Visible=false;
            }
        }

        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {
            //Validar datos ingresados por el usuario
            if (txtPrecioCompra.Text.Trim().Length<=13 && Regex.IsMatch(txtPrecioCompra.Text.Trim(),
                "^[1-9]{1}[0-9]{1,9}((.)[0-9]{1,2})?$")
                || Regex.IsMatch(txtPrecioCompra.Text.Trim(), "^[1-9]{1}$" ) 
                || Regex.IsMatch(txtPrecioCompra.Text.Trim(), "^[1-9]{1}((.)[0-9]{1,2})?$"))
            {
                ptbPrecioCompra.Visible=true;
            }
            else
            {
                ptbPrecioCompra.Visible=false;
            }
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            //Validar datos ingresados por el usuario
            if (txtPrecioVenta.Text.Trim().Length<=13 && Regex.IsMatch(txtPrecioVenta.Text.Trim(),
                "^[1-9]{1}[0-9]{1,9}((.)[0-9]{1,2})?$")
                || Regex.IsMatch(txtPrecioVenta.Text.Trim(), "^[1-9]{1}$") 
                || Regex.IsMatch(txtPrecioVenta.Text.Trim(), "^[1-9]{1}((.)[0-9]{1,2})?$"))
            {
                ptbPrecioVenta.Visible=true;
            }
            else
            {
                ptbPrecioVenta.Visible=false;
            }
        }

        private void txtPrecioOferta_TextChanged(object sender, EventArgs e)
        {
            //Validar datos ingresados por el usuario
            if (txtPrecioOferta.Text.Trim().Length<=13 && Regex.IsMatch(txtPrecioOferta.Text.Trim(),
                "^[1-9]{1}[0-9]{1,9}((.)[0-9]{1,2})?$")
                || Regex.IsMatch(txtPrecioOferta.Text.Trim(), "^[1-9]{1}$") 
                || Regex.IsMatch(txtPrecioOferta.Text.Trim(), "^[1-9]{1}((.)[0-9]{1,2})?$"))
            {
                ptbPrecioOferta.Visible=true;
            }
            else
            {
                ptbPrecioOferta.Visible=false;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            //Validar datos ingresados por el usuario
            if (txtCantidad.Text.Trim().Length<=13 && Regex.IsMatch(txtCantidad.Text.Trim(),
                "^[1-9]{1}[0-9]{1,9}((.)[0-9]{1,2})?$")
                || Regex.IsMatch(txtCantidad.Text.Trim(), "^[1-9]{1}$") 
                || Regex.IsMatch(txtCantidad.Text.Trim(), "^[1-9]{1}((.)[0-9]{1,2})?$"))
            {
                ptbCantidad.Visible=true;
            }
            else
            {
                ptbCantidad.Visible=false;
            }
        }
    }
}
