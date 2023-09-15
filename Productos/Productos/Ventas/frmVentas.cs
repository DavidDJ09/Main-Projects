using BACKEND;
using BACKEND.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Productos
{
    public partial class frmVentas : Form
    {
        int ide;
        public frmVentas(int idEmpleado)
        {
            //Cargar componentes
            InitializeComponent();
            cboProductos.DataSource=new DAOVenta().ObtenerActivos();
            cboProductos.DisplayMember="Descripcion";
            cboProductos.ValueMember="Id";

            //Obtener usuario que inicio sesion
            ide=idEmpleado;
            lblEmpleado.Text= new DAOEmpleado().ObtenerUno(idEmpleado).Nombre;

            //Obtener fecha actual y mostrarla
            lblFecha.Text=DateTime.Now.ToString().Substring(0, 10);

            //Autoajustar tabla al tamaño de los registros y establecer tipo de letra y tamaño
            dgvProductos.AutoGenerateColumns=false;
            this.dgvProductos.DefaultCellStyle.Font = new Font("Microsoft YaHei", 14);
            this.dgvProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 14);
            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            //Mantener foco en la caja de texto de codigo de barras
            txtCodigo.Focus();
            
            //Empezar sin seleccion alguna
            cboProductos.SelectedItem=null;
        }

        //Variables de control de venta
        List<Producto> productosCompra = new List<Producto>();
        double subtotal;
        double iva;
        double total;

        //Agregar producto escaneado a la tabla de venta
        private void agregar(Producto objProducto)
        {
            if (nudCantidad.Value>=1)
            {
                subtotal = 0;
                total = 0;
                iva = 0;

                try
                {
                    //Si el producto no esta en la tabla agregarlo, sino solo sumar a la cantidad comprada
                    if (objProducto.CantidadComprada == 0)
                    {
                        if (objProducto.Granel)
                        {
                            objProducto.CantidadComprada=Math.Round(Convert.ToDouble(nudCantidad.Value), 2);
                        }
                        else
                        {
                            objProducto.CantidadComprada=Math.Round(Convert.ToInt32(nudCantidad.Value)+0.0, 0);
                        }
                        productosCompra.Add(objProducto);
                    }
                    else
                    {
                        if (objProducto.Granel)
                        {
                            objProducto.CantidadComprada+=Math.Round(Convert.ToDouble(nudCantidad.Value), 2);
                        }
                        else
                        {
                            objProducto.CantidadComprada+=Math.Round(Convert.ToInt32(nudCantidad.Value)+0.0, 0);
                        }
                        //productosCompra.Add(objProducto);
                    }
                    //Actualizar tabla y mantener foco en la caja de codigo de barras
                    actualizar();
                    txtCodigo.Focus();
                }
                catch (Exception ex)
                {
                    //Mostrar mensaje de error
                    MessageBox.Show(this, "Seleccione el producto que desea agregar en la caja de texto",
                        "Error al agregar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }  
        }

        //Reflejar cada movimiento en la tabla de venta
        private void actualizar()
        {
            subtotal = 0;
            total = 0;
            iva = 0;

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productosCompra;

            //Autoajustar y actualizar tabla
            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            foreach (Producto producto in productosCompra)
            {
                subtotal+=Math.Round(producto.PrecioVenta*producto.CantidadComprada, 2);
            }

            //Actualizar variables de control
            iva=Math.Round(subtotal*0.16, 2);
            total=Math.Round(subtotal+iva, 2);
            lblSubtotal.Text=Math.Round(subtotal, 2).ToString();
            lblIVA.Text=iva.ToString();
            lblTotal.Text=total.ToString();
        }

        //Restar cantidad de producto a la venta
        private void restar()
        {          
            foreach (Producto producto in productosCompra)
            {
                subtotal+=Math.Round(producto.PrecioVenta*producto.CantidadComprada, 2);
            }
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productosCompra;

            //Autoajustar y actualizar tabla
            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            //Actualizar variables de control
            iva=Math.Round(subtotal*0.16, 2);
            total=Math.Round(subtotal+iva, 2);
            lblSubtotal.Text=Math.Round(subtotal, 2).ToString();
            lblIVA.Text=iva.ToString();
            lblTotal.Text=total.ToString();
            nudCantidad.Text="1";
        }

        //Reestablecer todos los componentes a sus valores iniciales
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
                subtotal=Math.Round(producto.PrecioVenta*producto.CantidadComprada, 2);
            }
            subtotal=0;
            iva=0;
            total=0;
            lblSubtotal.Text=subtotal.ToString();
            lblIVA.Text=iva.ToString();
            lblTotal.Text=total.ToString();
            nudCantidad.Text="1";
            txtCodigo.Focus();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            //Verificar que haya almenos un producto en la venta
            if (lblTotal.Text.Equals("0"))
            {
                //Mostrar mensaje de error
                MessageBox.Show(this, "Agregue almenos un producto para completar la compra", 
                    "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                //Obtner los datos necesario para registrar la venta
                Venta objOrden = new Venta();
                objOrden.IdEmpleado = ide;
                objOrden.Fecha = DateTime.Now;
                objOrden.Iva = Convert.ToDouble(lblIVA.Text.Trim());
                objOrden.Subtotal = Convert.ToDouble(lblSubtotal.Text.Trim());
                objOrden.Total = Convert.ToDouble(lblTotal.Text.Trim());

                bool resultado = false;
                //Agregar orden
                if (objOrden.Total>0)
                {
                    int idGenerado = new DAOVenta().agregarDetalle(objOrden, productosCompra);
                    resultado = (idGenerado > 0);
                }

                //Mostrar mensaje de exito
                if (resultado)
                {
                    MessageBox.Show("Orden almacenada correctamente", "Guardado", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    foreach (Producto producto in productosCompra)
                    {
                        producto.CantidadComprada=0;
                    }
                    productosCompra.Clear();
                    reiniciarCompra();
                }
                //Mostrar mensajes de error
                else
                {
                    MessageBox.Show("Se ha encontrado un error al almacenar, uno o más productos sin stock suficiente", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Agregue almenos un producto para completar su compra" + ex.ToString(), "Error al guardar", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Verificar que se haya seleeccionado el producto a borrar
            if (dgvProductos.SelectedRows.Count>0)
            {
                //Restar cantidad indicada
                subtotal = 0;
                total = 0;
                iva = 0;

                int fila = dgvProductos.CurrentRow.Index;
                double menos= Math.Round(productosCompra[fila].CantidadComprada-Convert.ToDouble(nudCantidad.Value), 2);

                if (new DAOProducto().ObtenerUno(int.Parse(dgvProductos.SelectedRows[0].Cells["Id"].Value.ToString())).Granel)
                {
                    menos = Math.Round(productosCompra[fila].CantidadComprada-Convert.ToDouble(nudCantidad.Value), 2);
                }
                else
                {
                    menos = Math.Round(productosCompra[fila].CantidadComprada-Convert.ToInt32(nudCantidad.Value), 0);
                }
                
                //Eliminar o restar cantidad dependiendo de la cantidad a borrar
                if (menos==0)
                {
                    productosCompra[fila].CantidadComprada=0;
                    productosCompra.RemoveAt(fila);
                }
                else if (menos>0)
                {
                    productosCompra[fila].CantidadComprada=menos;
                    
                }
                restar();
                //Mantener foco en la caja de codigo de barras
                txtCodigo.Focus();
            }
            else
            {
                //Mostrar mensaje de error
                MessageBox.Show("Selecciona un producto a eliminar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            //Habilitar uso del lector de codigo de barras (hardware)
            if (e.KeyCode == Keys.Enter)
            {
                //Buscar producto leido con el lector
                Producto p = new DAOProducto().BuscarCodigo(txtCodigo.Text);
                if (p != null)
                {
                    foreach (Producto p1 in cboProductos.Items)
                    {
                        if (p1.Id == p.Id)
                        {
                            p = p1;
                            break;
                        }

                    }

                    //Agregar producto a la venta
                    agregarPorCodigo(p);
                    txtCodigo.Text="";
                    
                    nudCantidad.Text="1";
                }
                //Mostrar mensaje de error
                else MessageBox.Show("Producto no registrado", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //Agregar productos a la venta por medio del lector
        private void agregarPorCodigo(Producto objProducto)
        {
            if (nudCantidad.Value>=1)
            {
                subtotal = 0;
                total = 0;
                iva = 0;

                if (objProducto.CantidadComprada == 0)
                {
                    if (objProducto.Granel)
                    {
                        double c = Convert.ToDouble(nudCantidad.Value.ToString());
                        objProducto.CantidadComprada=c;
                    }
                    else
                    {
                        objProducto.CantidadComprada=Convert.ToInt32(nudCantidad.Value);
                    }
                    productosCompra.Add(objProducto);
                }
                else
                {
                    if (objProducto.Granel)
                    {
                        double c = Math.Round(Convert.ToDouble(nudCantidad.Value.ToString()), 2);
                        objProducto.CantidadComprada=c;
                    }
                    else
                    {
                        objProducto.CantidadComprada+=Math.Round(Convert.ToInt32(nudCantidad.Value)+0.0, 0);
                    }
                }
                //Actualizar tabla y mantener foco en la caja de codigo de barras
                actualizar();
                txtCodigo.Focus();
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar productos de forma manual
            Producto objProducto = (Producto)cboProductos.SelectedItem;
            if (objProducto!=null)
            {
                agregar(objProducto);
                cboProductos.SelectedItem=null;
                nudCantidad.Text="1";
            }
            //Mostrar mensaje de error
            else MessageBox.Show("Debe seleccionar un producto", "Seleccionar", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

        }

        private void dgvProductos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                if (dgvProductos.SelectedRows.Count>0)
                {
                    Producto p = new DAOProducto().ObtenerUno(int.Parse(dgvProductos.SelectedRows[0].Cells["Id"].Value.ToString()));
                    if (p != null)
                    {
                        foreach (Producto p1 in cboProductos.Items)
                        {
                            if (p1.Id == p.Id)
                            {
                                p = p1;
                                break;
                            }

                        }
                        p.PrecioVenta=p.PrecioOferta;
                        actualizar();
                    }
                }
            }
        }


    }
}
