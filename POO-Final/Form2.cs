
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POO_Final
{
    public partial class Form2 : Form
    {
        private Conexion mConexion;

        public Form2()
        {
            InitializeComponent();
            mConexion = new Conexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = mConexion.getConexion();

                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show(" Conexión exitosa a la base de datos.");
                    mConexion.CerrarConexion(conn);
                }

                else
                {
                    MessageBox.Show(" No se pudo abrir la conexión.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

