
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using MySql.Data.MySqlClient;

namespace POO_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Conexión exitosa a la base de datos");
                conexion.CerrarConexion(conn);
            }

            else
            {
                Console.WriteLine("No se pudo establecer la conexión");
            }

            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
