using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACKEND
{
    public class Conexion
    {
        //Variables que almacenan datos para abrir conexion sql
        public static MySqlConnection conexion;
        public static MySqlTransaction transaccion;
        static string usuario = "prueba";
        static string password = "123";
        static string bd = "puntoVenta";
        static string servidor = "localhost";
        static string puerto = "3306";

        //Abrir conexion a base de datos
        public static bool conectar()
        {
            try
            {
                //Crear conexion
                conexion = new MySqlConnection("Database=" + bd + ";Data Source=" + servidor +
                    ";Port=" + puerto + ";User Id=" + usuario + ";Password=" + password);
                //Abrir conexion
                conexion.Open();
                //Retornar resultado
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Cerrar conexion a base de datos
        public static void desconectar()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception)
            { }
        }
    }
}
