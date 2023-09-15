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
    public partial class frmListaClientes : Form
    {
        public bool Borrado { get; set; }
        public frmListaClientes()
        {
            InitializeComponent();
            this.dgvClientes.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgvClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            cargarTabla();
        }

        private void cargarTabla()
        {
            dgvClientes.DataSource=new DAOCliente().ObtenerTodos();
            //dgvClientes.Columns["Id"].Visible=false;
            dgvClientes.Columns["Direccion"].HeaderText="Dirección";
            dgvClientes.Columns["Telefono"].HeaderText="Teléfono";
            dgvClientes.Columns["CP"].HeaderText="Código Postal";
            dgvClientes.Columns["Activo"].Visible= false;
            foreach (DataGridViewColumn columna in dgvClientes.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.ShowDialog();
            if (cliente.Guardado==true)
            {
                cargarTabla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un cliente a eliminar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de eliminar al cliente " + 
                    dgvClientes.SelectedRows[0].Cells[1].Value.ToString() + "?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    try
                    {
                        int seleccion = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value.ToString());
                        //bool elimino = new DAOCategoria().eliminar(seleccion);
                        if (new DAOCliente().eliminar(seleccion))
                        {
                            Borrado=true;
                            MessageBox.Show("Cliente eliminado correctamente", "Eliminado",
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
            if (dgvClientes.SelectedRows.Count>0)
            {
                int idCliente = int.Parse(dgvClientes.SelectedRows[0].Cells["Id"].Value.ToString());
                frmCliente cliente = new frmCliente(idCliente);
                cliente.ShowDialog();
                if (cliente.Guardado==true)
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
                dgvClientes.DataSource=new DAOCliente().ObtenerTodos();
            }
            else
            {
                dgvClientes.DataSource=new DAOCliente().buscar(txtBuscar.Text.Trim());
            }
        }
    }
}
