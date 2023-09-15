using BACKEND.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACKEND
{
    public class DAOVenta
    {
        //Obtener todos los registros de ventas con estado activo
        public List<Producto> ObtenerActivos()
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta select para seleccionar todas las ventas con estado activo
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Productos 
                        WHERE Activo=true and cantidad>0;");

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Producto> lista = new List<Producto>();
                    Producto objProducto = null;

                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    // Las filas se asignan a los atributos del objeto venta
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objProducto = new Producto();
                        objProducto.Id = Convert.ToInt32(fila["Id"]);
                        objProducto.CodigoBarras = fila["CodigoBarras"].ToString();
                        objProducto.Descripcion = fila["Descripcion"].ToString();
                        objProducto.PrecioCompra = Convert.ToDouble(fila["PrecioCompra"]);
                        objProducto.PrecioVenta = Convert.ToDouble(fila["PrecioVenta"]);
                        objProducto.PrecioOferta = Convert.ToDouble(fila["PrecioOferta"]);
                        objProducto.Cantidad = Convert.ToInt32(fila["Cantidad"]);

                        lista.Add(objProducto);
                    }

                    return lista;
                }
                else
                {
                    //Mostrar mensaje de error
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                //Mostrar mensaje de error
                throw new Exception("No se pudo obtener la información de las ordenes");
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Crear un registro de venta con n registros de detalles
        //(n=cantidad de productos diferentes vendidos)
        public int agregarDetalle(Venta orden, List<Producto> lista)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Iniciar una transacción
                    Conexion.transaccion = Conexion.conexion.BeginTransaction();

                    //Comando sql para insertar registro de venta y obtener su id
                    MySqlCommand agregarOrden = new MySqlCommand();
                    agregarOrden.Connection = Conexion.conexion;
                    agregarOrden.CommandText =
                        @"
                        INSERT INTO Ventas(idEmpleado, Fecha, Iva, Subtotal, Total, Activo)
                        VALUES(@idEmpleado,@Fecha,@Iva,@Subtotal,@Total,true);
                        SELECT last_insert_id();";

                    //Parametros
                    agregarOrden.Parameters.AddWithValue("@idEmpleado", orden.IdEmpleado);
                    agregarOrden.Parameters.AddWithValue("@Fecha", orden.Fecha);
                    agregarOrden.Parameters.AddWithValue("@Iva", orden.Iva);
                    agregarOrden.Parameters.AddWithValue("@Subtotal", orden.Subtotal);
                    agregarOrden.Parameters.AddWithValue("@Total", orden.Total);
                    agregarOrden.Parameters.AddWithValue("@Activo", orden.Activo);

                    //Obtener el id del registro creado
                    int ultimoId = Convert.ToInt32(agregarOrden.ExecuteScalar());

                    //Comando sql para insertar registros de detalle de venta
                    //y actualizar el campo cantidad (restando la cantidad vendida)
                    MySqlCommand agregarDetalle = new MySqlCommand();
                    agregarDetalle.Connection = Conexion.conexion;
                    agregarDetalle.CommandText =
                        @"INSERT INTO DetallesVentas(idVenta,idproducto,precioventa,cantidad,activo)
                        VALUES(@idVenta,@idProducto,@PrecioVenta,@cantidad,true);
                    UPDATE productos set cantidad=cantidad-@cantidad where id=@idproducto;";

                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    // Las filas se asignan a los atributos del objeto venta
                    foreach (Producto producto in lista)
                    {
                        agregarDetalle.Parameters.Clear();
                        agregarDetalle.Parameters.AddWithValue("@idVenta", ultimoId);
                        agregarDetalle.Parameters.AddWithValue("@idProducto", producto.Id);
                        agregarDetalle.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                        agregarDetalle.Parameters.AddWithValue("@cantidad", producto.CantidadComprada);
                        agregarDetalle.ExecuteNonQuery();
                    }

                    //Comando para verificar que no haya registros de cantidad en negativo
                    MySqlCommand checar = new MySqlCommand();
                    checar.Connection = Conexion.conexion;
                    checar.CommandText =
                        @"update productos set cantidad=0 where cantidad<0";
                    int check = checar.ExecuteNonQuery();
                    if (check > 0)
                    {
                        //Si se encuentra un error toda la transaccion sera cancelada
                        ultimoId = 0;
                        Conexion.transaccion.Rollback();
                    }
                    //Si no hay errores la transaccion se hara
                    else Conexion.transaccion.Commit();

                    return ultimoId;
                }
                else
                {
                    //Mostrar mensaje de error
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                //Mostrar mensajes de error dependiendo del tipo de error
                if (ex.Number == 1452) //Llave foránea
                {
                    throw new Exception("No se pudo realizar el registro, fallo en llenado de llaves foráneas");
                }
                else
                {
                    throw new Exception("No se pudo realizar el registro" +ex.Message);
                }
                Conexion.transaccion.Rollback();
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Buscar un registro por medio de la columna 'fecha'
        public List<Venta> BuscarPorFecha(DateTime inicio, DateTime fin)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta select para seleccionar todos los registros 
                    //cuyos su campo 'fecha' coincida con el rango de fechas proporcionado
                    MySqlCommand comando = new MySqlCommand(
                      @"select v.*, e.nombre as Empleado from ventas v
                        join empleados e on e.id=v.idempleado
                        where v.fecha between @Inicio and @Fin and v.activo=1;");

                    //Parametros
                    comando.Parameters.AddWithValue("@Inicio", inicio);
                    comando.Parameters.AddWithValue("@Fin", fin);

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Venta> lista = new List<Venta>();
                    Venta objOrden = null;

                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    //Las filas se asignan a los atributos del objeto venta
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objOrden = new Venta()
                        {
                            Id = Convert.ToInt32(fila["Id"]),
                            IdEmpleado = Convert.ToInt32(fila["IdEmpleado"]),
                            Fecha= (DateTime)fila["Fecha"],
                            Iva = Convert.ToDouble(fila["Iva"]),
                            Subtotal = Convert.ToDouble(fila["Subtotal"]),
                            Total = Convert.ToDouble(fila["Total"]),
                            Empleado = fila["Empleado"].ToString()
                        };
                        lista.Add(objOrden);
                    }

                    return lista;
                }
                else
                {
                    //Mostrar mensaje de error
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                //Mostrar mensaje de error
                throw new Exception("No se pudo obtener la información de las ordenes");
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Buscar un registro por medio de la columna 'fecha' y su seccion 'day'
        public List<Venta> BuscarPorDia(int dia)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta select para seleccionar todos los registros 
                    //cuyos su campo 'day' en la columna 'fecha' coincida con el numero proporcionado
                    MySqlCommand comando = new MySqlCommand(
                      @"select v.*, e.nombre as Empleado from ventas v
                        join empleados e on e.id=v.idempleado
                        where day(v.fecha) = @Dia and v.activo=1;");

                    comando.Parameters.AddWithValue("@Dia", dia);

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Venta> lista = new List<Venta>();
                    Venta objOrden = null;

                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    //Las filas se asignan a los atributos del objeto venta
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objOrden = new Venta()
                        {
                            Id = Convert.ToInt32(fila["Id"]),
                            IdEmpleado = Convert.ToInt32(fila["IdEmpleado"]),
                            Fecha= (DateTime)fila["Fecha"],
                            Iva = Convert.ToDouble(fila["Iva"]),
                            Subtotal = Convert.ToDouble(fila["Subtotal"]),
                            Total = Convert.ToDouble(fila["Total"]),
                            Empleado = fila["Empleado"].ToString()
                        };
                        lista.Add(objOrden);
                    }

                    return lista;
                }
                else
                {
                    //Mostrar mensaje de error
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                //Mostrar mensaje de error
                throw new Exception("No se pudo obtener la información de las ordenes");
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }
    }
}
