using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAOOrden
    {
        public List<Producto> ObtenerActivos()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Productos 
                        WHERE Activo=true OR Activo=1;");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Producto> lista = new List<Producto>();
                    Producto objProducto = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objProducto = new Producto()
                        {
                            IdProductos = Convert.ToInt32(fila["Id"]),
                            Descripcion = fila["Descripcion"].ToString(),
                            CodigoBarras= Convert.ToInt32(fila["Codigo"]),
                            VentaPorUnidad = Convert.ToBoolean(fila["VentaPorUnidad"]),
                            VentaAGranel = Convert.ToBoolean(fila["VentaAGranel"]),
                            VentaPorPaquete = Convert.ToBoolean(fila["VentaPorPaquete"]),
                            PrecioVenta = Convert.ToDouble(fila["PrecioVenta"]),
                            PrecioCosto = Convert.ToDouble(fila["PrecioCosto"]),
                            Ganancia = Convert.ToInt32(fila["Ganancia"]),
                            Categorias = Convert.ToInt32(fila["IdCategoria"])
                        };
                        lista.Add(objProducto);
                    }

                    return lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información de las ordenes");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public List<Orden> ObtenerTodas()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Ventas 
                        WHERE Activo=true OR Activo=1;");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Orden> lista = new List<Orden>();
                    Orden objOrden = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objOrden = new Orden()
                        {
                            IdCliente = Convert.ToInt32(fila["IdCliente"]),
                            IdEmpleado = Convert.ToInt32(fila["IdEmpleado"]),
                            Fecha= (DateTime)fila["Fecha"],
                            Iva = Convert.ToDouble(fila["Iva"]),
                            Subtotal = Convert.ToDouble(fila["Sutotal"]),
                            Total = Convert.ToDouble(fila["Total"]),
                            Activo = Convert.ToBoolean(fila["Activo"])
                        };
                        lista.Add(objOrden);
                    }

                    return lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información de las ordenes");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public List<Detalle> ObtenerDetalles()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Detalles_Venta 
                        WHERE Activo=true OR Activo=1;");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Detalle> lista = new List<Detalle>();
                    Detalle objDetalle = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objDetalle = new Detalle()
                        {
                            IdOrden = Convert.ToInt32(fila["IdOrden"]),
                            IdProducto = Convert.ToInt32(fila["IdProducto"]),
                            PrecioUnitario= Convert.ToDouble(fila["PrecioUnitario"]),
                            Cantidad  = Convert.ToDouble(fila["Cantidad"]),
                            Activo = Convert.ToBoolean(fila["Activo"])
                        };
                        lista.Add(objDetalle);
                    }

                    return lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información de las ordenes");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public int agregarDetalle(Orden orden, List<Producto> lista)
        {
            try
            {
                if (Conexion.conectar())
                {
                    //Iniciar una transacción
                    Conexion.transaccion = Conexion.conexion.BeginTransaction();

                    MySqlCommand agregarOrden = new MySqlCommand();
                    agregarOrden.Connection = Conexion.conexion;
                    agregarOrden.CommandText =
                        @"INSERT INTO Ventas(idCliente, idEmpleado, Fecha, Iva, Sutotal, Total, Activo)
                        VALUES(@idCliente,@idEmpleado,@Fecha,@Iva,@Subtotal,@Total,true);
                        SELECT last_insert_id();";

                    agregarOrden.Parameters.AddWithValue("@idCliente", orden.IdCliente);
                    agregarOrden.Parameters.AddWithValue("@idEmpleado", orden.IdEmpleado);
                    agregarOrden.Parameters.AddWithValue("@Fecha", orden.Fecha);
                    agregarOrden.Parameters.AddWithValue("@Iva", orden.Iva);
                    agregarOrden.Parameters.AddWithValue("@Subtotal", orden.Subtotal);
                    agregarOrden.Parameters.AddWithValue("@Total", orden.Total);
                    agregarOrden.Parameters.AddWithValue("@Activo", orden.Activo);

                    int ultimoId = Convert.ToInt32(agregarOrden.ExecuteScalar());

                    MySqlCommand agregarDetalle = new MySqlCommand();
                    agregarDetalle.Connection = Conexion.conexion;
                    agregarDetalle.CommandText =
                        @"INSERT INTO Detalles_Venta
                        VALUES(@idOrden,@idProducto,@precioUnitario,@cantidad,true);";

                    foreach (Producto producto in lista)
                    {
                        agregarDetalle.Parameters.Clear();
                        agregarDetalle.Parameters.AddWithValue("@idOrden", ultimoId);
                        agregarDetalle.Parameters.AddWithValue("@idProducto", producto.IdProductos);
                        agregarDetalle.Parameters.AddWithValue("@precioUnitario", producto.PrecioVenta);
                        agregarDetalle.Parameters.AddWithValue("@cantidad", producto.Cantidad);
                        agregarDetalle.ExecuteNonQuery();
                    }

                    Conexion.transaccion.Commit();

                    return ultimoId;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1452) //Llave foránea
                {
                    throw new Exception("No se pudo realizar el registro, fallo en llenado de llaves foráneas");
                }
                else
                {
                    throw new Exception("No se pudo realizar el registro");
                }
            }
            finally
            {
                Conexion.desconectar();
            }
        }
    }
}
