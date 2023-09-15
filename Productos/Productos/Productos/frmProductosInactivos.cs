using BACKEND;
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
    public partial class frmProductosInactivos : Form
    {
        public bool Guardado { get; set; }
        public frmProductosInactivos()
        {
            //Cargar componentes
            InitializeComponent();

            //Autoajustar tabla al tamaño de los registros y establecer tipo de letra y tamaño
            this.dgvProductosInactivos.DefaultCellStyle.Font = new Font("Microsoft YaHei", 14);
            this.dgvProductosInactivos.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 14);
            cargarTabla();
        }

        //Dar formato a la tabla y actualizarla
        private void cargarTabla()
        {
            dgvProductosInactivos.DataSource=new DAOProducto().ObtenerInactivos();
            dgvProductosInactivos.Columns["Id"].HeaderText="Id";
            dgvProductosInactivos.Columns["Id"].Visible= false;
            dgvProductosInactivos.Columns["CodigoBarras"].HeaderText="Código de Barras";
            dgvProductosInactivos.Columns["Descripcion"].HeaderText="Descripción";
            dgvProductosInactivos.Columns["PrecioCompra"].HeaderText="Precio Compra";
            dgvProductosInactivos.Columns["PrecioVenta"].HeaderText="Precio Venta";
            dgvProductosInactivos.Columns["PrecioOferta"].HeaderText="Precio Oferta";
            dgvProductosInactivos.Columns["Cantidad"].HeaderText="Stock";
            dgvProductosInactivos.Columns["CantidadComprada"].Visible= false;
            dgvProductosInactivos.Columns["TotalCompra"].Visible= false;
            dgvProductosInactivos.Columns["Activo"].Visible= false;
            foreach (DataGridViewColumn columna in dgvProductosInactivos.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            //Verificar que haya algun registro seleccionado
            if (dgvProductosInactivos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un producto a activar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                //Solicitar confirmacion
                if (MessageBox.Show("¿Está seguro de activar el producto '" +
                    dgvProductosInactivos.SelectedRows[0].Cells[2].Value.ToString() + "'?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    try
                    {
                        //Revertir borrado logico
                        int seleccion = Convert.ToInt32(dgvProductosInactivos.SelectedRows[0].Cells[0].Value.ToString());
                        if (new DAOProducto().activar(seleccion))
                        {
                            //Mostrar mensaje de exito
                            MessageBox.Show("Producto activado correctamente", "Activado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Guardado= true;

                            //Actualizar la tabla
                            cargarTabla();
                        }
                    }
                    catch (Exception ex)
                    {
                        //Mostrar mensaje de error
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //Realizar el tipo de busqueda seleccionada por el usuario
            if (rdbCodigo.Checked)
            {
                if (txtBuscar.Text.Equals(""))
                {
                    dgvProductosInactivos.DataSource=new DAOProducto().ObtenerTodosInactivos();
                }
                else
                {
                    dgvProductosInactivos.DataSource=new DAOProducto().buscarPorCodigoInactivos(txtBuscar.Text.Trim());
                }
            }
            else if (rdbNombre.Checked)
            {
                if (txtBuscar.Text.Equals(""))
                {
                    dgvProductosInactivos.DataSource=new DAOProducto().ObtenerTodosInactivos();
                }
                else
                {
                    dgvProductosInactivos.DataSource=new DAOProducto().buscarPorDescripcionInactivos(txtBuscar.Text.Trim());
                }
            }
            else
            {
                //Mostrar error de manera visual
                erpError.SetError(txtBuscar, "Seleccione el modo de búsqueda");
                txtBuscar.Text="";
            }
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            //Limpiar error provider y caja de texto de busqueda
            erpError.Clear();
            txtBuscar.Text = string.Empty;
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            //Limpiar error provider y caja de texto de busqueda
            erpError.Clear();
            txtBuscar.Text = string.Empty;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Cerrar ventana
            this.Close();
        }
    }
}
