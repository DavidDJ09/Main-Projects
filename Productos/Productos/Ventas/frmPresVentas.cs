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
    public partial class frmPresVentas : Form
    {
        public frmPresVentas()
        {
            //Cargar componentes
            InitializeComponent();

            //Autoajustar tabla al tamaño de los registros y establecer tipo de letra y tamaño
            this.dgvOrdenes.DefaultCellStyle.Font = new Font("Microsoft YaHei", 14);
            this.dgvOrdenes.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 14);
        }

        private void rdbDia_CheckedChanged(object sender, EventArgs e)
        {
            //Habilitar y deshabilitar componentes
            dtpPrincipal.Enabled = true;
            dtpSecundario.Enabled= false;
            dgvOrdenes.DataSource=null;
            lblDel.Visible= true;
            lblHastaEl.Visible= false;

            BuscarPorDia(dtpPrincipal.Value.Day);
        }

        private void rdbRango_CheckedChanged(object sender, EventArgs e)
        {
            //Habilitar y deshabilitar componentes
            dtpSecundario.Enabled= true;
            dtpPrincipal.Enabled = true;
            dgvOrdenes.DataSource=null;
            lblDel.Visible= true;
            lblHastaEl.Visible= true;
        }

        private void dtpPrincipal_ValueChanged(object sender, EventArgs e)
        {
            //Buscar dependiendo de la seleccion del usuario
            if (rdbDia.Checked)
            {
                BuscarPorDia(dtpPrincipal.Value.Day);
            }
            else
            {
                BuscarPorRango(dtpPrincipal.Value, dtpSecundario.Value);
            }
        }

        private void dtpSecundario_ValueChanged(object sender, EventArgs e)
        {
            //Buscar por rango de fechas
            if (rdbRango.Checked)
            {
                BuscarPorRango(dtpPrincipal.Value,dtpSecundario.Value);
            }
        }

        private void BuscarPorRango(DateTime inicio, DateTime fin)
        {
            try
            {
                //Dar formato a la presentacion de resultados
                dgvOrdenes.DataSource= new DAOVenta().BuscarPorFecha
                (inicio, fin);
                dgvOrdenes.Columns["Id"].Visible=false;
                dgvOrdenes.Columns["Activo"].Visible=false;
                dgvOrdenes.Columns["IdEmpleado"].Visible=false;
                dgvOrdenes.Columns["Empleado"].HeaderText="Empleado";

                //Autoajustar tabla
                foreach (DataGridViewColumn columna in dgvOrdenes.Columns)
                {
                    columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                //Mostrar mensaje de error
                MessageBox.Show("Formato de fechas incorrecto", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BuscarPorDia(int dia)
        {
            try
            {
                //Dar formato a la presentacion de resultados
                dgvOrdenes.DataSource= new DAOVenta().BuscarPorDia
                (dia);
                dgvOrdenes.Columns["Id"].Visible=false;
                dgvOrdenes.Columns["Activo"].Visible=false;
                dgvOrdenes.Columns["IdEmpleado"].Visible=false;
                dgvOrdenes.Columns["Empleado"].HeaderText="Empleado";

                //Autoajustar tabla
                foreach (DataGridViewColumn columna in dgvOrdenes.Columns)
                {
                    columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                //Mostrar mensaje de error
                MessageBox.Show("Formato de fechas incorrecto", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
