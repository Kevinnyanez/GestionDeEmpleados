using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLogin: Form
    {
     
        public FormLogin()
        {
            InitializeComponent();
            panelRegistroTrabajador.Visible = false; // Oculta el panel de registro al inicio
        }


        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Tomamos los valores que ingresó la jefa
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            // Verificamos que no estén vacíos
            if (usuario == "" || contraseña == "")
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.");
                return;
            }

            // Conectamos a la base de datos
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Admins WHERE NombreUsuario = @Usuario AND Contraseña = @Contraseña";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                    int count = (int)cmd.ExecuteScalar(); // Devuelve un número

                    if (count > 0)
                    {
                        MessageBox.Show("Inicio de sesión exitoso.");
                        FormPrincipal principal = new FormPrincipal();
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar conectar a la base de datos: " + ex.Message);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CargarUserControl(new Emplado());
        }


        private void CargarUserControl(UserControl nuevoControl)
        {
            panelRegistroTrabajador.Visible = true; // Muestra el panel de registro
            panelRegistroTrabajador.Controls.Clear();
            nuevoControl.Dock = DockStyle.Fill;
            panelRegistroTrabajador.Controls.Add(nuevoControl);

        }
    }
}
