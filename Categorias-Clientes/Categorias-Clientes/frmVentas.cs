using Datos;
using Modelos;
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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
            cboProductos.DataSource=new DAOOrden().ObtenerActivos();
            cboProductos.DisplayMember="Descripcion";
            cboProductos.ValueMember="IdProductos";

            //cboClientes.DataSource=new DAOCliente().ObtenerTodos();
            //cboClientes.DisplayMember="Nombre";
            //cboClientes.ValueMember="Id";

            lblFecha.Text=DateTime.Now.ToString().Substring(0,10);

            dgvProductos.AutoGenerateColumns=false;
            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        List<Producto> productosCompra = new List<Producto>();
        double subtotal;
        double iva;
        double total;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            subtotal=0;
            total = 0;
            iva = 0;
            Producto objProducto = (Producto)cboProductos.SelectedItem;
            
            if (objProducto.Cantidad == 0)
            {
                objProducto.Cantidad = (int)nudCantidad.Value;
                productosCompra.Add(objProducto);  
            }
            else
            {
                objProducto.Cantidad += (int)nudCantidad.Value; 
            }
            actualizar();
        }

        private void actualizar()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productosCompra;
            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            foreach (Producto producto in productosCompra)
            {
                subtotal+=Math.Round(producto.PrecioVenta*producto.Cantidad, 2);
            }
            iva=Math.Round(subtotal*0.16, 2);
            total=Math.Round(subtotal+iva, 2);
            lblSubtotal.Text=subtotal.ToString();
            lblIVA.Text=iva.ToString();
            lblTotal.Text=total.ToString();
            nudCantidad.Value=1;
        }

        private void restar()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productosCompra;
            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            foreach (Producto producto in productosCompra)
            {
                subtotal=Math.Round(producto.PrecioVenta*producto.Cantidad, 2);
            }
            iva=Math.Round(subtotal*0.16, 2);
            total=Math.Round(subtotal+iva, 2);
            lblSubtotal.Text=subtotal.ToString();
            lblIVA.Text=iva.ToString();
            lblTotal.Text=total.ToString();
            nudCantidad.Value=1;
        }

        private void reiniciarCompra()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productosCompra;
            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            foreach (Producto producto in productosCompra)
            {
                subtotal=Math.Round(producto.PrecioVenta*producto.Cantidad, 2);
            }
            subtotal=0;
            iva=0;
            total=0;
            lblSubtotal.Text=subtotal.ToString();
            lblIVA.Text=iva.ToString();
            lblTotal.Text=total.ToString();
            nudCantidad.Value=1;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text.Equals("0"))
            {
                MessageBox.Show(this, "Agregue almenos un producto para completar su compra", "Error al guardar", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }
            if (lblCliente.Text.Equals("Sin Seleccionar"))
            {
                MessageBox.Show(this, "Seleccione el cliente que realizara la compra", "Falta Cliente", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    Orden objOrden = new Orden();
                    objOrden.IdEmpleado = 1; //Falta id Empleado
                    objOrden.IdCliente = idcliente;
                    objOrden.Fecha = DateTime.Now;
                    objOrden.Iva = Convert.ToDouble(lblIVA.Text.Trim());
                    objOrden.Subtotal = Convert.ToDouble(lblSubtotal.Text.Trim());
                    objOrden.Total = Convert.ToDouble(lblTotal.Text.Trim());

                    bool resultado = false;
                    //Agregar orden
                    if (objOrden.Total>0)
                    {
                        int idGenerado = new DAOOrden().agregarDetalle(objOrden, productosCompra);
                        resultado = (idGenerado > 0);
                    }

                    if (resultado)
                    {
                        //Guardado = true;
                        MessageBox.Show("Orden almacenada correctamente", "Guardado", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        foreach (Producto producto in productosCompra)
                        {
                            producto.Cantidad=0;
                        }
                        productosCompra.Clear();
                        reiniciarCompra();
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Se ha encontrado un error al almacenar, verifique la información" +
                            " e inténtelo de nuevo más tarde", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Agregue almenos un producto para completar su compra", "Error al guardar", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }  
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count>0)
            {
                subtotal=0;
                total = 0;
                iva = 0;
                int fila = dgvProductos.CurrentRow.Index;
                productosCompra[fila].Cantidad=0;
                productosCompra.RemoveAt(fila);
                restar();
            }
            else
            {
                MessageBox.Show("Selecciona un producto a eliminar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }  
        }

        int idcliente=0;
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmSeleccionarCliente frm = new frmSeleccionarCliente();
            frm.ShowDialog();
            lblCliente.Text= frm.NombreClienteSeleccionado.Trim();
            idcliente=frm.IdClienteSeleccionado;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
