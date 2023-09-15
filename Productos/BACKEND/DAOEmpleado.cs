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
    public class DAOEmpleado
    {
        //Iniciar sesion por sentencia sql
        public Empleado IniciarSesion(String usuario, String password)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta select para verificar usuario y contraseña
                    MySqlCommand comando = new MySqlCommand("SELECT nombre Nombre," +
                            "puesto Puesto, Id FROM Empleados " +
                            "WHERE usuario=@Usuario AND contrasenia=sha2(@Password,256) AND activo=true;");

                    //Parámetros
                    comando.Parameters.AddWithValue("Usuario", usuario);
                    comando.Parameters.AddWithValue("Password", password);

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);

                    Empleado objUsuario = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    if (resultado.Rows.Count > 0)
                    {
                        objUsuario = new Empleado(
                            resultado.Rows[0]["Nombre"].ToString(),
                            usuario,
                            resultado.Rows[0]["Puesto"].ToString(),
                           Convert.ToInt32(resultado.Rows[0]["Id"])
                        );
                    }
                    return objUsuario;
                }
                else
                {
                    //Mostrar mensaje de error
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Obtener todos los registros de empleados con estado activo
        public List<Empleado> ObtenerTodos()
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta select para seleccionar todos los empleados con estado activo
                    MySqlCommand comando = new MySqlCommand(
                        @"select * from empleados e WHERE activo = true;");

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Empleado> lista = new List<Empleado>();
                    Empleado objUsuario = null;

                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    // Las filas se asignan a los atributos del objeto empleado
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objUsuario = new Empleado();
                        objUsuario.Id = Convert.ToInt32(fila["Id"]);
                        objUsuario.Nombre = fila["Nombre"].ToString();
                        objUsuario.Direccion = fila["Direccion"].ToString();
                        objUsuario.Telefono = fila["Telefono"].ToString();
                        objUsuario.Usuario = fila["Usuario"].ToString();
                        objUsuario.Password = fila["Contrasenia"].ToString();
                        objUsuario.Puesto = fila["Puesto"].ToString();
                        objUsuario.Activo = bool.Parse(fila["Activo"].ToString());
                        lista.Add(objUsuario);
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
                throw new Exception("No se pudo obtener la información de los empleados");
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Obtener un registro por medio de su id
        public Empleado ObtenerUno(int id)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta select para seleccionar el registro el cual su id
                    //coincida con el proporcionado
                    MySqlCommand comando = new MySqlCommand(
                        @"select * from empleados e WHERE e.id=@id;");

                    //Parametro
                    comando.Parameters.AddWithValue("@id", id);

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);

                    Empleado objUsuario = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    //Las filas se asignan a los atributos del objeto empleado
                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        objUsuario = new Empleado();
                        objUsuario.Id = Convert.ToInt32(fila["id"]);
                        objUsuario.Nombre = fila["Nombre"].ToString();
                        objUsuario.Direccion = fila["Direccion"].ToString();
                        objUsuario.Telefono = fila["Telefono"].ToString();
                        objUsuario.Usuario = fila["Usuario"].ToString();
                        objUsuario.Password = fila["Contrasenia"].ToString();
                        objUsuario.Puesto = fila["Puesto"].ToString();
                        objUsuario.Activo = bool.Parse(fila["Activo"].ToString());
                    }

                    return objUsuario;
                }
                //Mostrar mensajes de error
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información del usuario");
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Buscar un registro por medio de una cadena seleccionada
        public List<Empleado> buscar(string cadena)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta select para seleccionar el registro el cual su campo 'nombre'
                    //coincida con el texto proporcionado
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Empleados
                        WHERE Nombre LIKE @Cadena AND Activo=1;");

                    //Parametro
                    comando.Parameters.AddWithValue("@Cadena", "%"+cadena+"%");

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    List<Empleado> lista = new List<Empleado>();
                    adapter.Fill(resultado);

                    Empleado objUsuario = null;

                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    //Las filas se asignan a los atributos del objeto empleado
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objUsuario = new Empleado();
                        objUsuario.Id = Convert.ToInt32(fila["id"]);
                        objUsuario.Nombre = fila["Nombre"].ToString();
                        objUsuario.Direccion = fila["Direccion"].ToString();
                        objUsuario.Telefono = fila["Telefono"].ToString();
                        objUsuario.Usuario = fila["Usuario"].ToString();
                        objUsuario.Password = fila["Contrasenia"].ToString();
                        objUsuario.Puesto = fila["Puesto"].ToString();
                        objUsuario.Activo = bool.Parse(fila["Activo"].ToString());

                        lista.Add(objUsuario);
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

        //Hacer borrado logico poniendo la columna 'activo' (boolean) en false
        public bool borradoLogico(int id)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta update para cambiar el valor de la columna 'activo' a 0
                    MySqlCommand comando = new MySqlCommand(
                        @"UPDATE Empleados
                            SET Activo=0
                            WHERE id=@id;");

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
                    //Mostrar mensajes de error
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Editar registro en la base de datos sin contraseña
        public bool editar(Empleado usuario)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta update para cambiar el valor de las columnas
                    MySqlCommand comando = new MySqlCommand(
                        @"UPDATE Empleados
                            SET
                            nombre=@nombre,
                            direccion=@direccion,
                            telefono=@telefono,
                            usuario=@usuario,
                            puesto=@puesto
                            WHERE id=@id;");

                    //Parametros
                    comando.Parameters.AddWithValue("@id", usuario.Id);
                    comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@direccion", usuario.Direccion);
                    comando.Parameters.AddWithValue("@telefono", usuario.Telefono);
                    comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
                    comando.Parameters.AddWithValue("@puesto", usuario.Puesto);

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
                if (ex.Number == 1062) //Unique
                {
                    throw new Exception("No se pudo realizar la edición, el nombre de usuario ya se encuentra en uso");
                }
                else if (ex.Number == 1452) //Llave foránea
                {
                    throw new Exception("No se pudo realizar la edición por relaciones con otros registros");
                }
                else
                {
                    throw new Exception("No se pudo realizar la edición");
                }
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Editar registro en la base de datos con contraseña
        public bool editarConContrasenia(Empleado usuario)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta update para cambiar el valor de todas las columnas
                    MySqlCommand comando = new MySqlCommand(
                        @"UPDATE Empleados
                            SET
                            nombre=@nombre,
                            direccion=@direccion,
                            telefono=@telefono,
                            usuario=@usuario,
                            puesto=@puesto,
                            contrasenia=sha2(@nueva,256)
                            WHERE id=@id AND contrasenia=sha2(@contrasenia,256);");

                    //Parametros
                    comando.Parameters.AddWithValue("@id", usuario.Id);
                    comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@direccion", usuario.Direccion);
                    comando.Parameters.AddWithValue("@telefono", usuario.Telefono);
                    comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
                    comando.Parameters.AddWithValue("@puesto", usuario.Puesto);
                    comando.Parameters.AddWithValue("@contrasenia", usuario.Password);
                    comando.Parameters.AddWithValue("@nueva", usuario.NuevaPassword);

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
                if (ex.Number == 1062) //Unique
                {
                    throw new Exception("No se pudo realizar la edición, el nombre de usuario ya se encuentra en uso");
                }
                else if (ex.Number == 1452) //Llave foránea
                {
                    throw new Exception("No se pudo realizar la edición por relaciones con otros registros");
                }
                else
                {
                    throw new Exception("No se pudo realizar la edición");
                }
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Insertar registro en la tabla empleados
        public int agregar(Empleado usuario)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta insert para insertar el nuevo registro
                    MySqlCommand comando = new MySqlCommand(
                        @"INSERT INTO Empleados VALUES(
                                null,
                                @nombre,
                                @direccion,
                                @telefono,
                                @puesto,
                                @usuario,
                                sha2(@password, 256),
                                default);");

                    //Parametros
                    comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@direccion", usuario.Direccion);
                    comando.Parameters.AddWithValue("@telefono", usuario.Telefono);
                    comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
                    comando.Parameters.AddWithValue("@password", usuario.Password);
                    comando.Parameters.AddWithValue("@puesto", usuario.Puesto);

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
                if (ex.Number == 1062) //Unique
                {
                    throw new Exception("No se pudo realizar el registro, el nombre de usuario ya se encuentra en uso");
                }
                else if (ex.Number == 1452) //Llave foránea
                {
                    throw new Exception("No se pudo realizar el registro, el jefe no es válido");
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

        //Obtener todos los registros de empleados con estado inactivo
        public List<Empleado> ObtenerInactivos()
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta select para seleccionar todos los empleados con estado inactivos
                    MySqlCommand comando = new MySqlCommand(
                        @"select * from empleados e WHERE activo = false;");

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Empleado> lista = new List<Empleado>();
                    Empleado objUsuario = null;

                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    //Las filas se asignan a los atributos del objeto empleado
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objUsuario = new Empleado();
                        objUsuario.Id = Convert.ToInt32(fila["id"]);
                        objUsuario.Nombre = fila["Nombre"].ToString();
                        objUsuario.Direccion = fila["Direccion"].ToString();
                        objUsuario.Telefono = fila["Telefono"].ToString();
                        objUsuario.Usuario = fila["Usuario"].ToString();
                        objUsuario.Password = fila["Contrasenia"].ToString();
                        objUsuario.Puesto = fila["Puesto"].ToString();
                        objUsuario.Activo = bool.Parse(fila["Activo"].ToString());
                        lista.Add(objUsuario);
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
                throw new Exception("No se pudo obtener la información de los empleados");
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
                        @"UPDATE Empleados
                            SET Activo=1
                            WHERE id=@id;");

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
                    //Mostrar mensaje de error
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                //Mostrar mensaje de error
                throw new Exception("Error al intentar eliminar al usuario");
            }
            finally
            {
                //Cerrar conexion
                Conexion.desconectar();
            }
        }

        //Obtener todos los registros de empleados con estado inactivo
        public List<Empleado> buscarInactivos(string cadena)
        {
            try
            {
                //Abrir conexion
                if (Conexion.conectar())
                {
                    //Crear consulta select para seleccionar todos los empleados con estado inactivo
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Empleados
                        WHERE Nombre LIKE @Cadena AND Activo=0;");

                    //Parametro
                    comando.Parameters.AddWithValue("@Cadena", "%"+cadena+"%");

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    List<Empleado> lista = new List<Empleado>();
                    adapter.Fill(resultado);

                    Empleado objUsuario = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    //Las filas se asignan a los atributos del objeto empleado
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objUsuario = new Empleado();
                        objUsuario.Id = Convert.ToInt32(fila["id"]);
                        objUsuario.Nombre = fila["Nombre"].ToString();
                        objUsuario.Direccion = fila["Direccion"].ToString();
                        objUsuario.Telefono = fila["Telefono"].ToString();
                        objUsuario.Usuario = fila["Usuario"].ToString();
                        objUsuario.Password = fila["Contrasenia"].ToString();
                        objUsuario.Puesto = fila["Puesto"].ToString();
                        objUsuario.Activo = bool.Parse(fila["Activo"].ToString());

                        lista.Add(objUsuario);
                    }

                    return lista;
                }
                //Mostrar mensajes de error dependiendo del tipo de error
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
