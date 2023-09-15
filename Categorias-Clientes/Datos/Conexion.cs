using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        public static MySqlConnection conexion;
        public static MySqlTransaction transaccion;
        static string usuario = "prueba";
        static string password = "123";
        static string bd = "proyectodb";
        static string servidor = "localhost";
        static string puerto = "3306";

        public static bool conectar()
        {
            try
            {
                conexion = new MySqlConnection("Database=" + bd + ";Data Source=" + servidor +
                    ";Port=" + puerto + ";User Id=" + usuario + ";Password=" + password);
                conexion.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

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
