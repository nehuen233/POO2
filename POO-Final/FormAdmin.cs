using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace POO_Final
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnAgregarEspectaculo_Click(object sender, EventArgs e)
        {
           conexionBD conexion = new conexionBD();

         try
            {
                conexion.AbrirConexion();
                string query = "INSERT INTO espectaculos (nombre, capacidad_total, precio_base, foto) VALUES (@nombre, @capacidad_total, @precio_base, @foto)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.conexion);
                cmd.Parameters.AddWithValue("@n", txtNombreEsp.Text);
                cmd.Parameters.AddWithValue("@c", int.Parse(txtCapacidad.Text));
                cmd.Parameters.AddWithValue("@p", double.Parse(txtPrecio.Text));
                cmd.Parameters.AddWithValue("@f", txtFoto.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error  " + ex.Message);
            }

            finally
            {
                conexion.Cerrar();
            }

        }
    }
}
