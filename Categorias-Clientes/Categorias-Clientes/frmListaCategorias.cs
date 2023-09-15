using Datos;
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
    public partial class frmListaCategorias : Form
    {
        public bool Borrado { get; set; }
        public frmListaCategorias()
        {
            InitializeComponent();
            this.dgvCategorias.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgvCategorias.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            cargarTabla();
        }

        private void cargarTabla()
        {
            dgvCategorias.DataSource=new DAOCategoria().ObtenerTodos();
            //dgvCategorias.Columns["Id"].Visible=false;
            dgvCategorias.Columns["Descripcion"].HeaderText="Descripción";
            dgvCategorias.Columns["Activo"].Visible= false;
            foreach (DataGridViewColumn columna in dgvCategorias.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCategoria categoria = new frmCategoria();
            categoria.ShowDialog();
            if (categoria.Guardado==true)
            {
                cargarTabla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una categoría a eliminar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de eliminar la categoría " + 
                    dgvCategorias.SelectedRows[0].Cells[1].Value.ToString() + "?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    try
                    {
                        int seleccion = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells[0].Value.ToString());
                        if (new DAOCategoria().eliminar(seleccion))
                        {
                            Borrado=true;
                            MessageBox.Show("Categoría eliminada correctamente", "Eliminado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }  
            }
            cargarTabla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count>0)
            {
                int idCategoria = int.Parse(dgvCategorias.SelectedRows[0].Cells["Id"].Value.ToString());
                frmCategoria categoria = new frmCategoria(idCategoria);
                categoria.ShowDialog();
                if (categoria.Guardado==true)
                {
                    //Actualizar la lista
                    cargarTabla();
                }
            }
            else
            {
                MessageBox.Show("Selecciona el registro a editar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                dgvCategorias.DataSource=new DAOCategoria().ObtenerTodos();
            }
            else
            {
                dgvCategorias.DataSource=new DAOCategoria().buscar(txtBuscar.Text.Trim());
            }
        }
    }
}
