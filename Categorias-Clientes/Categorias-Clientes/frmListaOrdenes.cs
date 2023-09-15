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
    public partial class frmListaOrdenes : Form
    {
        public frmListaOrdenes()
        {
            InitializeComponent();
            this.dgvOrdenes.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgvOrdenes.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            cargarTabla();
        }

        private void cargarTabla()
        {
            dgvOrdenes.DataSource=new DAOOrden().ObtenerTodas();
            //dgvCategorias.Columns["Id"].Visible=false;
            dgvOrdenes.Columns["IdCliente"].HeaderText="Id Cliente";
            dgvOrdenes.Columns["IdEmpleado"].HeaderText="Id Empleado";
            dgvOrdenes.Columns["Fecha"].HeaderText="Fecha y Hora";
            dgvOrdenes.Columns["Activo"].Visible= false;
            foreach (DataGridViewColumn columna in dgvOrdenes.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
