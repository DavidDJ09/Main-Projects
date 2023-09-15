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
    public partial class frmEmpleadosInactivos : Form
    {
        public bool Guardado { get; set; }
        public frmEmpleadosInactivos()
        {
            //Cargar componentes
            InitializeComponent();

            //Autoajustar tabla al tamaño de los registros y establecer tipo de letra y tamaño
            this.dgvEmpleadosInactivos.DefaultCellStyle.Font = new Font("Microsoft YaHei", 14);
            this.dgvEmpleadosInactivos.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 14);
            cargarTabla();
        }

        //Dar formato a la tabla y actualizarla
        private void cargarTabla()
        {
            dgvEmpleadosInactivos.DataSource = new DAOEmpleado().ObtenerInactivos();
            dgvEmpleadosInactivos.Columns["Id"].Visible=false;
            dgvEmpleadosInactivos.Columns["Direccion"].HeaderText = "Dirección";
            dgvEmpleadosInactivos.Columns["Telefono"].HeaderText = "Teléfono";
            dgvEmpleadosInactivos.Columns["Usuario"].HeaderText = "Usuario";
            dgvEmpleadosInactivos.Columns["Password"].Visible = false;
            dgvEmpleadosInactivos.Columns["NuevaPassword"].Visible = false;
            dgvEmpleadosInactivos.Columns["Puesto"].HeaderText = "Puesto";
            dgvEmpleadosInactivos.Columns["Activo"].Visible = false;
            foreach (DataGridViewColumn columna in dgvEmpleadosInactivos.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Cerrar ventana
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //Realizar busqueda por medio de la cadena proporcionada y mostrar coincidencias en la tabla
            if (txtBuscar.Text.Equals(""))
            {
                dgvEmpleadosInactivos.DataSource=new DAOEmpleado().ObtenerInactivos();
            }
            else
            {
                dgvEmpleadosInactivos.DataSource=new DAOEmpleado().buscarInactivos(txtBuscar.Text.Trim());
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            //Verificar que haya algun registro seleccionado
            if (dgvEmpleadosInactivos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioe un empleado a activar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                //Solicitar confirmacion
                if (MessageBox.Show("¿Está seguro de activar al empleado '" +
                    dgvEmpleadosInactivos.SelectedRows[0].Cells[1].Value.ToString() + "'?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    try
                    {
                        //Revertir borrado logico
                        int seleccion = Convert.ToInt32(dgvEmpleadosInactivos.SelectedRows[0].Cells[0].Value.ToString());
                        if (new DAOEmpleado().activar(seleccion))
                        {
                            //Mostrar mensaje de exito
                            MessageBox.Show("Empleado activado correctamente", "Activado",
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
    }
}
