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
    public partial class frmPresEmpleados : Form
    {
        int idusuario;
        bool editar;
        public frmPresEmpleados(int id)
        {
            //Cargar componentes
            InitializeComponent();
            idusuario=id;

            //Autoajustar tabla al tamaño de los registros y establecer tipo de letra y tamaño
            this.dgvEmpleados.DefaultCellStyle.Font = new Font("Microsoft YaHei", 14);
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 14);
            cargarTabla();

            //Obtener el usuario que inicio sesion
            Empleado user = new DAOEmpleado().ObtenerUno(idusuario);

            //Aplicar permisos de usuario
            if (user.Puesto=="Empleado")
            {
                btnAgregar.Enabled=false;
                btnRecuperar.Enabled=false;
                btnEliminar.Enabled=false;
            }
        }

        //Dar formato a la tabla de presentacion de registros
        private void cargarTabla()
        {
            dgvEmpleados.DataSource = new DAOEmpleado().ObtenerTodos();
            dgvEmpleados.Columns["Id"].Visible=false;
            dgvEmpleados.Columns["Direccion"].HeaderText = "Dirección";
            dgvEmpleados.Columns["Telefono"].HeaderText = "Teléfono";
            dgvEmpleados.Columns["Usuario"].HeaderText = "Usuario";
            dgvEmpleados.Columns["Password"].Visible = false;
            dgvEmpleados.Columns["NuevaPassword"].Visible = false;
            dgvEmpleados.Columns["Puesto"].HeaderText = "Puesto";
            dgvEmpleados.Columns["Activo"].Visible = false;
            foreach (DataGridViewColumn columna in dgvEmpleados.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Abrir pantalla de insercion de registros
            editar=false;
            frmEmpleado frm = new frmEmpleado(editar);
            frm.ShowDialog();
            if (frm.Guardado)
            {
                //Actualizar la tabla
                cargarTabla();
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            //Abrir pantalla de recuperacion de registros
            frmEmpleadosInactivos frm = new frmEmpleadosInactivos();
            frm.ShowDialog();
            if (frm.Guardado)
            {
                //Actualizar la tabla
                cargarTabla();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Tomar el id del registro a editar
            int idEmpleado = int.Parse(dgvEmpleados.SelectedRows[0].Cells["Id"].Value.ToString());

            //Obtener datos del empleado seleccionado
            Empleado user = new DAOEmpleado().ObtenerUno(idusuario);

            //Abrir pantalla de edicion con los datos cargados
            if (idEmpleado==idusuario)
            {
                editar=true;
                if (dgvEmpleados.SelectedRows.Count > 0)
                {
                    frmEmpleado frm = new frmEmpleado(idEmpleado, idusuario, editar);
                    frm.ShowDialog();

                    if (frm.Guardado)
                    {
                        //Actualizar la tabla
                        cargarTabla();
                    }
                }
                //Mostrar mensajes de error
                else
                {
                    MessageBox.Show(this, "Se debe seleccionar un elemento de la tabla para editar",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Solo puede editar su propio registro", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Verificar que haya algun registro seleccionado
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado a eliminar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                //Solicitar confirmacion
                if (MessageBox.Show("¿Está seguro de eliminar al empleado '" +
                    dgvEmpleados.SelectedRows[0].Cells[1].Value.ToString() + "'?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    try
                    {
                        //Obtener id del empleado
                        int seleccion = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells[0].Value.ToString());
                        if (seleccion!=idusuario)
                        {
                            //Ejecutar borrado logico
                            if (new DAOEmpleado().borradoLogico(seleccion))
                            {
                                MessageBox.Show("Empleado eliminado correctamente", "Eliminado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        //Mostrar mensajes de error
                        else
                        {
                            MessageBox.Show("No se puede eliminar el usuario con sesión iniciada", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //Buscar por nombre de empleado y mostrar resultados en la tabla
            if (txtBuscar.Text.Equals(""))
            {
                dgvEmpleados.DataSource=new DAOEmpleado().ObtenerTodos();
            }
            else
            {
                dgvEmpleados.DataSource=new DAOEmpleado().buscar(txtBuscar.Text.Trim());
            }
        }
    }
}
