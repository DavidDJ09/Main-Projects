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
    public class DAOProducto
    {
        public List<Producto> ObtenerTodos()
        {
            try
            {
                if (Conexion.conectar())
                {
                    //Simulación de que el nombre de usuario es el firstname del usuario y  
                    //city es el password
                    MySqlCommand comando = new MySqlCommand(
                        @" SELECT Idproductos,Codigo,Descripcion,VentaPorUnidad,VentaAGranel,VentaporPaquete, 
                            PrecioCosto,PrecioVenta,Categoria
                            FROM Productos");

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
                        objProducto = new Producto();
                        objProducto.IdProductos = Convert.ToInt32(fila["Idproductos"]);
                        objProducto.CodigoBarras = Convert.ToInt32(fila["Codigo"]);
                        objProducto.Descripcion = fila["Descripcion"].ToString();
                        objProducto.VentaPorUnidad = Convert.ToBoolean(fila["VentaPorUnidad"]);
                        objProducto.VentaAGranel = Convert.ToBoolean(fila["VentaAGranel"]);
                        objProducto.VentaPorPaquete = Convert.ToBoolean(fila["VentaPorPaquete"]);
                        objProducto.PrecioCosto = Convert.ToInt32(fila["PrecioCosto"]);
                        objProducto.Ganancia = Convert.ToInt32(fila["Ganancia"]);
                        objProducto.PrecioVenta = Convert.ToInt32(fila["PrecioVenta"]);
                        objProducto.Categorias = Convert.ToInt32(fila["Categoria"]);

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

        public Producto ObtenerUno(int id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Productos
                        WHERE IdProductos=@Id");

                    comando.Parameters.AddWithValue("@Id", id);
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);

                    Producto objProducto = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        objProducto = new Producto();
                        objProducto.IdProductos = Convert.ToInt32(fila["Idproductos"]);
                        objProducto.CodigoBarras = Convert.ToInt32(fila["Codigo"]);
                        objProducto.Descripcion = fila["Descripcion"].ToString();
                        objProducto.VentaPorUnidad = Convert.ToBoolean(fila["VentaPorUnidad"]);
                        objProducto.VentaAGranel = Convert.ToBoolean(fila["VentaAGranel"]);
                        objProducto.VentaPorPaquete = Convert.ToBoolean(fila["VentaPorPaquete"]);
                        objProducto.PrecioCosto = Convert.ToInt32(fila["PrecioCosto"]);
                        objProducto.Ganancia = Convert.ToInt32(fila["Ganancia"]);
                        objProducto.PrecioVenta = Convert.ToInt32(fila["PrecioVenta"]);
                        objProducto.Categorias = Convert.ToInt32(fila["Categoria"]);
                    }

                    return objProducto;
                }
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
                Conexion.desconectar();
            }
        }
    }
}
