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
    public class DAOCliente
    {
        public List<Cliente> ObtenerTodos()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * from Clientes WHERE Activo=true OR Activo=1;");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Cliente> lista = new List<Cliente>();
                    Cliente objCliente = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objCliente = new Cliente();
                        objCliente.Id = Convert.ToInt32(fila["Id"]);
                        objCliente.Nombre = fila["Nombre"].ToString();
                        objCliente.Direccion = fila["Direccion"].ToString();
                        objCliente.Colonia = fila["Colonia"].ToString();
                        objCliente.Municipio = fila["Municipio"].ToString();
                        objCliente.Estado = fila["Estado"].ToString();
                        objCliente.CP = fila["CodigoPostal"].ToString();
                        objCliente.Telefono = fila["Telefono"].ToString();

                        lista.Add(objCliente);
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
                throw new Exception("No se pudo obtener la información de los clientes");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public Cliente ObtenerUno(int id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Clientes
                        WHERE Id=@Id");

                    comando.Parameters.AddWithValue("@Id", id);
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);

                    Cliente objCliente = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        objCliente = new Cliente();
                        objCliente.Id = Convert.ToInt32(fila["Id"]);
                        objCliente.Nombre = fila["Nombre"].ToString();
                        objCliente.Direccion = fila["Direccion"].ToString();
                        objCliente.Colonia = fila["Colonia"].ToString();
                        objCliente.Municipio = fila["Municipio"].ToString();
                        objCliente.Estado = fila["Estado"].ToString();
                        objCliente.CP = fila["CodigoPostal"].ToString();
                        objCliente.Telefono = fila["Telefono"].ToString();
                    }

                    return objCliente;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información del cliente");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public List<Cliente> buscar(string cadena)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Clientes
                        WHERE Nombre LIKE @Cadena;");

                    comando.Parameters.AddWithValue("@Cadena", "%"+cadena+"%");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    List<Cliente> lista = new List<Cliente>();
                    adapter.Fill(resultado);

                    Cliente objCliente = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objCliente = new Cliente();
                        objCliente.Id = Convert.ToInt32(fila["Id"]);
                        objCliente.Nombre = fila["Nombre"].ToString();
                        objCliente.Direccion = fila["Direccion"].ToString();
                        objCliente.Colonia = fila["Colonia"].ToString();
                        objCliente.Municipio = fila["Municipio"].ToString();
                        objCliente.Estado = fila["Estado"].ToString();
                        objCliente.CP = fila["CodigoPostal"].ToString();
                        objCliente.Telefono = fila["Telefono"].ToString();

                        lista.Add(objCliente);
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
                throw new Exception("No se pudo obtener la información del cliente");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public int agregar(Cliente cliente)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"INSERT INTO Clientes(Nombre, Direccion, Colonia, Municipio, Estado, CodigoPostal, Telefono, Activo)
                        VALUES(@Nombre, @Direccion, @Colonia, @Municipio, @Estado, @CodigoPostal, @Telefono, true);");

                    comando.Parameters.AddWithValue("@id", cliente.Id);
                    comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    comando.Parameters.AddWithValue("@Colonia", cliente.Colonia);
                    comando.Parameters.AddWithValue("@Municipio", cliente.Municipio);
                    comando.Parameters.AddWithValue("@Estado", cliente.Estado);
                    comando.Parameters.AddWithValue("@CodigoPostal", cliente.CP);
                    comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    comando.Parameters.AddWithValue("@Activo", cliente.Activo);
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    int filasAgregadas = comando.ExecuteNonQuery();

                    return filasAgregadas;
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

        public bool editar(Cliente cliente)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"UPDATE Clientes
                            SET Nombre=@Nombre, 
                            Direccion=@Direccion,
                            Colonia=@Colonia,
                            Municipio=@Municipio,
                            Estado=@Estado,
                            CodigoPostal=@CodigoPostal,
                            Telefono=@Telefono
                            WHERE Id=@Id;");

                    comando.Parameters.AddWithValue("@Id", cliente.Id);
                    comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    comando.Parameters.AddWithValue("@Colonia", cliente.Colonia);
                    comando.Parameters.AddWithValue("@Municipio", cliente.Municipio);
                    comando.Parameters.AddWithValue("@Estado", cliente.Estado);
                    comando.Parameters.AddWithValue("@CodigoPostal", cliente.CP);
                    comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    comando.Parameters.AddWithValue("@Activo", cliente.Activo);

                    comando.Connection = Conexion.conexion;

                    int filasBorradas = comando.ExecuteNonQuery();

                    return (filasBorradas > 0);
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
                    throw new Exception("No se pudo realizar la modificación, fallo en llenado de llaves foráneas");
                }
                else
                {
                    throw new Exception("No se pudo realizar la modificación");
                }
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public bool eliminar(int id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"DELETE FROM Clientes 
                            WHERE Id=@id");

                    comando.Parameters.AddWithValue("@id", id);

                    comando.Connection = Conexion.conexion;

                    int filasBorradas = comando.ExecuteNonQuery();

                    return (filasBorradas > 0);
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number==1451)
                {
                    return borradoLógico(id);
                }
                else
                {
                    throw new Exception("Error al intentar eliminar el cliente");
                } 
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public bool borradoLógico(int id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"UPDATE Clientes
                            SET Activo=false
                            WHERE Id=@id");

                    comando.Parameters.AddWithValue("@id", id);

                    comando.Connection = Conexion.conexion;

                    int filasBorradas = comando.ExecuteNonQuery();

                    return (filasBorradas > 0);
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al intentar eliminar el cliente.");
            }
            finally
            {
                Conexion.desconectar();
            }
        }
    }
}
