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
    public partial class frmPresProductos : Form
    {
        public bool Borrado { get; set; }
        public frmPresProductos()
        {
            //Cargar componentes
            InitializeComponent();

            //Autoajustar tabla al tamaño de los registros y establecer tipo de letra y tamaño
            this.dgvProductos.DefaultCellStyle.Font = new Font("Microsoft YaHei", 14);
            this.dgvProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 14);
            cargarTabla();
        }

        //Dar formato a la tabla de presentacion de registros
        private void cargarTabla()
        {
            dgvProductos.DataSource=new DAOProducto().ObtenerTodos();
            dgvProductos.Columns["Id"].HeaderText="Id";
            dgvProductos.Columns["Id"].Visible= false;
            dgvProductos.Columns["CodigoBarras"].HeaderText="Código de Barras";
            dgvProductos.Columns["Descripcion"].HeaderText="Descripción";
            dgvProductos.Columns["PrecioCompra"].HeaderText="Precio Compra";
            dgvProductos.Columns["PrecioVenta"].HeaderText="Precio Venta";
            dgvProductos.Columns["PrecioOferta"].HeaderText="Precio Oferta";
            dgvProductos.Columns["Cantidad"].HeaderText="Stock";
            dgvProductos.Columns["CantidadComprada"].Visible= false;
            dgvProductos.Columns["TotalCompra"].Visible= false;
            dgvProductos.Columns["Activo"].Visible= false;
            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //Realizar el tipo de busqueda seleccionada por el usuario
            if (rdbCodigo.Checked)
            {
                if (txtBuscar.Text.Equals(""))
                {
                    dgvProductos.DataSource=new DAOProducto().ObtenerTodos();
                }
                else
                {
                    dgvProductos.DataSource=new DAOProducto().buscarPorCodigo(txtBuscar.Text.Trim());
                }
            }else if (rdbNombre.Checked)
            {
                if (txtBuscar.Text.Equals(""))
                {
                    dgvProductos.DataSource=new DAOProducto().ObtenerTodos();
                }
                else
                {
                    dgvProductos.DataSource=new DAOProducto().buscarPorDescripcion(txtBuscar.Text.Trim());
                }
            }else
            {
                //Mostrar error de manera visual
                erpError.SetError(txtBuscar, "Selecciona el modo de búsqueda");
                txtBuscar.Text="";
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Verificar que haya algun registro seleccionado
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un producto a eliminar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                //Solicitar confirmacion
                if (MessageBox.Show("¿Está seguro de eliminar el producto '" +
                    dgvProductos.SelectedRows[0].Cells[2].Value.ToString() + "'?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    try
                    {
                        //Ejecutar borrado logico
                        int seleccion = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[0].Value.ToString());
                        if (new DAOProducto().borradoLógico(seleccion))
                        {
                            Borrado=true;
                            MessageBox.Show("Producto eliminado correctamente", "Eliminado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //Actualizar tabla
            cargarTabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Abrir pantalla de insercion de registros
            frmProducto producto = new frmProducto();
            producto.ShowDialog();
            //Al cerrar la pantalla volver a actualizar la tabla
            if (producto.Guardado==true)
            {
                cargarTabla();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count>0)
            {
                //Tomar el id del registro a editar
                int id = int.Parse(dgvProductos.SelectedRows[0].Cells["Id"].Value.ToString());

                //Abrir pantalla de edicion con los datos cargados
                frmProducto producto = new frmProducto(id);
                producto.ShowDialog();
                if (producto.Guardado==true)
                {
                    //Actualizar la tabla
                    cargarTabla();
                }
            }
            else
            {
                //Mostrar mensaje de error
                MessageBox.Show("Selecciona el registro a editar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            //Abrir pantalla de recuperacion de registros
            frmProductosInactivos frm = new frmProductosInactivos();
            frm.ShowDialog();
            if (frm.Guardado)
            {
                //Actualizar la tabla
                cargarTabla();
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
    }
}
