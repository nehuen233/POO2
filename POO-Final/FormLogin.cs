
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace POO_Final
{

    public partial class FormLogin : Form
    {  
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();


            try
            {
                conexion.AbrirConexion();

                string query = "SELECT * FROM usuarios WHERE nombre = @nombre AND contraseña = @contraseña";
                MySqlCommand cmd = new MySqlCommand(query, conexion.conexion);
                cmd.Attributes.AddWithValue("@nombre", txtUsuario.Text);
                cmd.Attributes.AddWithValue("@contraseña", txtContrasena.Text);

                MySqlDataRead dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string rol = dr["rol"].ToString();
                    if (rol == "administrador")
                    {
                        MessageBox.Show("Bienvenido Administrador");
                        FormAdmin formAdmin = new FormAdmin();
                        formAdmin.Show();
                        this.Hide();
                    }
                    else if (rol == "vendedor")
                    {
                        MessageBox.Show("Bienvenido Vendedor");
                        FormVendedor formVendedor = new FormVendedor();
                        formVendedor.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
            }
        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
