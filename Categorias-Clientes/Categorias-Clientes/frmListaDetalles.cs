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
    public partial class frmListaDetalles : Form
    {
        public frmListaDetalles()
        {
            InitializeComponent();
            this.dgvDetalles.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgvDetalles.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            cargarTabla();
        }

        private void cargarTabla()
        {
            dgvDetalles.DataSource = new DAOOrden().ObtenerDetalles();
            //dgvCategorias.Columns["Id"].Visible=false;
            dgvDetalles.Columns["IdOrden"].HeaderText="Id Orden";
            dgvDetalles.Columns["IdProducto"].HeaderText="Id Producto";
            dgvDetalles.Columns["PrecioUnitario"].HeaderText="Precio Unitario";
            dgvDetalles.Columns["Activo"].Visible= false;
            foreach (DataGridViewColumn columna in dgvDetalles.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
