
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Final
{
    internal class Conexion
    {
        private readonly string cadenaConexion;

        public Conexion()
        {
            cadenaConexion = "Server=localhost;Port=3306;Database=sistema_entradas;User Id=root;Password=;";
        }

        public MySqlConnection getConexion()
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                return null;
            }
        }

        public void CerrarConexion(MySqlConnection conexion)
        {
            try
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}

