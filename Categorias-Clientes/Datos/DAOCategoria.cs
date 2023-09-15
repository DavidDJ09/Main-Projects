using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Datos
{
    public class DAOCategoria
    {
        public List<Categoria> ObtenerTodos()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(@"SELECT * from Categorias WHERE Activo=true OR Activo=1;");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Categoria> lista = new List<Categoria>();
                    Categoria objCategoria = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objCategoria = new Categoria();
                        objCategoria.Id = Convert.ToInt32(fila["Id"]);
                        objCategoria.Nombre = fila["Nombre"].ToString();
                        objCategoria.Descripcion = fila["Descripcion"].ToString();

                        lista.Add(objCategoria);
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
                throw new Exception("No se pudo obtener la información de las categorías");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public Categoria ObtenerUno(int id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Categorias
                        WHERE Id=@Id");

                    comando.Parameters.AddWithValue("@Id", id);
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);

                    Categoria objCategoria = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        objCategoria = new Categoria();
                        objCategoria.Id = Convert.ToInt32(fila["Id"]);
                        objCategoria.Nombre = fila["Nombre"].ToString();
                        objCategoria.Descripcion = fila["Descripcion"].ToString();
                    }

                    return objCategoria;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información de la categoría");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public List<Categoria> buscar(string cadena)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Categorias
                        WHERE Nombre LIKE @Cadena;");

                    comando.Parameters.AddWithValue("@Cadena", "%"+cadena+"%");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    List<Categoria> lista = new List<Categoria>();
                    adapter.Fill(resultado);

                    Categoria objCategoria = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objCategoria = new Categoria();
                        objCategoria.Id = Convert.ToInt32(fila["Id"]);
                        objCategoria.Nombre = fila["Nombre"].ToString();
                        objCategoria.Descripcion = fila["Descripcion"].ToString();

                        lista.Add(objCategoria);
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
                throw new Exception("No se pudo obtener la información de la categoría");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public int agregar(Categoria categoria)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"INSERT INTO Categorias(Nombre, Descripcion, Activo)
                        VALUES(@Nombre,@Descripcion,true);");

                    comando.Parameters.AddWithValue("@id", categoria.Id);
                    comando.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                    comando.Parameters.AddWithValue("@Activo", categoria.Activo);
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
                if (ex.Number == 1062) //Unique
                {
                    throw new Exception("No se pudo realizar el registro, el nombre de categoría ya se encuentra en uso");
                }
                else if (ex.Number == 1452) //Llave foránea
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

        public bool editar(Categoria categoria)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"UPDATE Categorias
                            SET Nombre=@Nombre, 
                            Descripcion=@Descripcion
                            WHERE Id=@Id");

                    comando.Parameters.AddWithValue("@Id", categoria.Id);
                    comando.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                    comando.Parameters.AddWithValue("@Activo", categoria.Activo);

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
                if (ex.Number == 1062) //Unique
                {
                    throw new Exception("No se pudo realizar la modificación, el nombre de categoría ya se encuentra en uso");
                }
                else if (ex.Number == 1452) //Llave foránea
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
                        @"DELETE FROM Categorias 
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
                    throw new Exception("Error al intentar eliminar la categoría");
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
                        @"UPDATE Categorias
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
                throw new Exception("Error al intentar eliminar la categoría.");
            }
            finally
            {
                Conexion.desconectar();
            }
        }
    }
}
