using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACKEND
{
    public class DAOProducto
    {
        //Obtener todos los registros de productos con estado activo
        public List<Producto> ObtenerTodos()
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta select para seleccionar todos los productos con estado activo
                    MySqlCommand comando = new MySqlCommand(
                        @" SELECT * FROM Productos WHERE activo=1;");

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Producto> lista = new List<Producto>();
                    Producto objProducto = null;

                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    // Las filas se asignan a los atributos del objeto producto
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
                        objProducto.Granel = Convert.ToBoolean((fila["AGranel"]));

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
                //Mostrar mensajes de error dependiendo del tipo de error
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
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Obtener todos los registros de productos con estado inactivo
        public List<Producto> ObtenerTodosInactivos()
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta select para seleccionar todos los productos con estado inactivos
                    MySqlCommand comando = new MySqlCommand(
                        @" SELECT * FROM Productos WHERE activo=0;");

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Producto> lista = new List<Producto>();
                    Producto objProducto = null;

                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    //Las filas se asignan a los atributos del objeto producto
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
                        objProducto.Granel = Convert.ToBoolean((fila["AGranel"]));

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
                //Mostrar mensajes de error dependiendo del tipo de error
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
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Obtener un registro por medio de su id
        public Producto ObtenerUno(int id)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta select para seleccionar el registro el cual su id
                    //coincida con el proporcionado
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Productos WHERE Id=@Id");

                    //Parametro
                    comando.Parameters.AddWithValue("@Id", id);

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    Producto objProducto = null;

                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    //Las filas se asignan a los atributos del objeto empleado
                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        objProducto = new Producto();
                        objProducto.Id = Convert.ToInt32(fila["Id"]);
                        objProducto.CodigoBarras = fila["CodigoBarras"].ToString();
                        objProducto.Descripcion = fila["Descripcion"].ToString();
                        objProducto.PrecioCompra = Convert.ToDouble(fila["PrecioCompra"]);
                        objProducto.PrecioVenta = Convert.ToDouble(fila["PrecioVenta"]);
                        objProducto.PrecioOferta = Convert.ToDouble(fila["PrecioOferta"]);
                        objProducto.Cantidad = Convert.ToInt32(fila["Cantidad"]);
                        objProducto.Granel = Convert.ToBoolean((fila["AGranel"]));
                    }

                    return objProducto;
                }
                //Mostrar mensajes de error
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información del producto");
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Buscar un registro por medio de la columna 'descripcion' con el uso de cadenas
        public List<Producto> buscarPorDescripcion(string cadena)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta select para seleccionar el registro el cual su campo 'descripcion'
                    //coincida con el texto proporcionado
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Productos
                        WHERE Descripcion LIKE @Cadena AND Activo=1;");

                    //Parametro
                    comando.Parameters.AddWithValue("@Cadena", "%"+cadena+"%");

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    List<Producto> lista = new List<Producto>();
                    adapter.Fill(resultado);

                    Producto objProducto = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    //Las filas se asignan a los atributos del objeto producto
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
                        objProducto.Granel = Convert.ToBoolean((fila["AGranel"]));

                        lista.Add(objProducto);
                    }

                    return lista;
                }
                //Mostrar mensajes de error
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información del producto");
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Buscar un registro por medio de la columna 'codigoBarras' con el uso de cadenas
        public List<Producto> buscarPorCodigo(string cadena)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta select para seleccionar el registro el cual su campo 'codigoBarras'
                    //coincida con el texto proporcionado
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Productos
                        WHERE CodigoBarras LIKE @Cadena AND Activo=1;");

                    //Parametro
                    comando.Parameters.AddWithValue("@Cadena", cadena+"%");

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    List<Producto> lista = new List<Producto>();
                    adapter.Fill(resultado);

                    Producto objProducto = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    //Las filas se asignan a los atributos del objeto producto
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
                        objProducto.Granel = Convert.ToBoolean((fila["AGranel"]));

                        lista.Add(objProducto);
                    }

                    return lista;
                }
                //Mostrar mensajes de error 
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información del producto");
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Buscar un registro inactivo por medio de la columna 'descripcion' con el uso de cadenas
        public List<Producto> buscarPorDescripcionInactivos(string cadena)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta select para seleccionar el registro inactivo el cual 
                    //su campo 'descripcion' coincida con el texto proporcionado
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Productos
                        WHERE Descripcion LIKE @Cadena AND Activo=0;");

                    //Parametro
                    comando.Parameters.AddWithValue("@Cadena", "%"+cadena+"%");

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    List<Producto> lista = new List<Producto>();
                    adapter.Fill(resultado);

                    Producto objProducto = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    //Las filas se asignan a los atributos del objeto producto
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
                //Mostrar mensajes de error
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información del producto");
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        public List<Producto> buscarPorCodigoInactivos(string cadena)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta select para seleccionar el registro inactivo el cual 
                    //su campo 'codigoBarras' coincida con el texto proporcionado
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Productos
                        WHERE CodigoBarras LIKE @Cadena AND Activo=0;");

                    //Parametro
                    comando.Parameters.AddWithValue("@Cadena", cadena+"%");

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    List<Producto> lista = new List<Producto>();
                    adapter.Fill(resultado);

                    Producto objProducto = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    //Las filas se asignan a los atributos del objeto producto
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
                        objProducto.Granel = Convert.ToBoolean((fila["AGranel"]));

                        lista.Add(objProducto);
                    }

                    return lista;
                }
                //Mostrar mensajes de error
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información del producto");
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Insertar registro en la tabla productos
        public int agregar(Producto producto)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta insert para insertar el nuevo registro
                    MySqlCommand comando = new MySqlCommand(
                        @"INSERT INTO Productos
                        VALUES(default, @CodigoBarras, @Descripcion, @PrecioCompra, @PrecioVenta, 
                                @PrecioOferta, @Catidad, default, @Granel);");

                    //Parametros
                    comando.Parameters.AddWithValue("@Id", producto.Id);
                    comando.Parameters.AddWithValue("@CodigoBarras", producto.CodigoBarras);
                    comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    comando.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);
                    comando.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                    comando.Parameters.AddWithValue("@PrecioOferta", producto.PrecioOferta);
                    comando.Parameters.AddWithValue("@Catidad", producto.Cantidad);
                    comando.Parameters.AddWithValue("@Granel", producto.Granel);
                    comando.Parameters.AddWithValue("@Activo", producto.Activo);

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Tomar el numero de filas agregadas y retornarlo
                    int filasAgregadas = comando.ExecuteNonQuery();

                    return filasAgregadas;
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
                else if (ex.Number == 1062) //Llave foránea
                {
                    throw new Exception("No se pudo realizar el registro," +
                        " hay un registro existente con el código de barras proporcionado");
                }
                else
                {
                    throw new Exception("No se pudo realizar el registro" + ex.Message);
                }
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Editar registro en la base de datos
        public bool editar(Producto producto)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta update para cambiar el valor de las columnas
                    MySqlCommand comando = new MySqlCommand(
                        @"UPDATE Productos
                            SET CodigoBarras=@CodigoBarras,
                            Descripcion=@Descripcion, 
                            PrecioCompra=@PrecioCompra,
                            PrecioVenta=@PrecioVenta,
                            PrecioOferta=@PrecioOferta,
                            Cantidad=@Catidad,
                            AGranel=@Granel
                            WHERE Id=@Id;");

                    //Parametros
                    comando.Parameters.AddWithValue("@Id", producto.Id);
                    comando.Parameters.AddWithValue("@CodigoBarras", producto.CodigoBarras);
                    comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    comando.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);
                    comando.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                    comando.Parameters.AddWithValue("@PrecioOferta", producto.PrecioOferta);
                    comando.Parameters.AddWithValue("@Catidad", producto.Cantidad);
                    comando.Parameters.AddWithValue("@Activo", producto.Activo);
                    comando.Parameters.AddWithValue("@Granel", producto.Granel);

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Tomar el numero de filas editadas y retornarlo
                    int filasEditadas = comando.ExecuteNonQuery();

                    return (filasEditadas > 0);
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
                    throw new Exception("No se pudo realizar la modificación, fallo en llenado de llaves foráneas");
                }
                else
                {
                    throw new Exception("No se pudo realizar la modificación");
                }
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Hacer borrado logico poniendo la columna 'activo' (boolean) en false
        public bool borradoLógico(int id)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta update para cambiar el valor de la columna 'activo' a 0
                    MySqlCommand comando = new MySqlCommand(
                        @"UPDATE Productos
                            SET Activo=0
                            WHERE Id=@id");

                    //Parametro
                    comando.Parameters.AddWithValue("@id", id);

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Tomar el numero de filas editadas y retornarlo
                    int filasEditadas = comando.ExecuteNonQuery();

                    return (filasEditadas > 0);
                }
                //Mostrar mensajes de error
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al intentar eliminar el productos.");
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Obtener todos los registros de productos con estado inactivo
        public List<Producto> ObtenerInactivos()
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta select para seleccionar todos los productos con estado inactivos
                    MySqlCommand comando = new MySqlCommand(
                        @" SELECT * FROM Productos p 
                            WHERE p.activo = 0
                            ORDER BY p.Id;");

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Producto> lista = new List<Producto>();
                    Producto objProducto = null;

                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    //Las filas se asignan a los atributos del objeto producto
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
                        objProducto.Granel = Convert.ToBoolean(fila["AGranel"]);

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
                //Mostrar mensajes de error dependiendo del tipo de error
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
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Revertir borrado logico poniendo la columna 'activo' (boolean) en true
        public bool activar(int id)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta update para cambiar el valor de la columna 'activo' a 1
                    MySqlCommand comando = new MySqlCommand(
                        @"UPDATE Productos
                            SET Activo=1
                            WHERE Id=@id");

                    //Parametro
                    comando.Parameters.AddWithValue("@id", id);

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Tomar el numero de filas editadas y retornarlo
                    int filasEditadas = comando.ExecuteNonQuery();

                    return (filasEditadas > 0);
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                //Mostrar mensaje de error
                throw new Exception("Error al intentar activar el producto");
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Buscar un registro por medio de la columna 'codigoBarras' con el uso de cadenas
        public Producto BuscarCodigo(string codigo)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta select para seleccionar el registro el cual su campo 'codigoBarras'
                    //coincida con el texto proporcionado
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Productos
                        WHERE codigoBarras=@codigo AND Activo=1;");

                    comando.Parameters.AddWithValue("@codigo", codigo);
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    Producto objProducto = null;

                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    //Las filas se asignan a los atributos del objeto producto
                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        objProducto = new Producto();
                        objProducto.Id = Convert.ToInt32(fila["Id"]);
                        objProducto.Descripcion = fila["Descripcion"].ToString();
                        objProducto.PrecioCompra = Convert.ToDouble(fila["PrecioCompra"]);
                        objProducto.PrecioVenta = Convert.ToDouble(fila["PrecioVenta"]);
                        objProducto.PrecioOferta = Convert.ToDouble(fila["PrecioOferta"]);
                        objProducto.Cantidad = Convert.ToDouble(fila["Cantidad"]);
                        objProducto.CodigoBarras = fila["CodigoBarras"].ToString();
                        objProducto.Granel = Convert.ToBoolean(fila["AGranel"]);
                        objProducto.CantidadComprada++;
                    }

                    return objProducto;
                }
                //Mostrar mensajes de error
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información del producto");
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }
    }
}
