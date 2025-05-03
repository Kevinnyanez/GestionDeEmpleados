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
    
    public partial class Emplado : UserControl
    {
        private int contador = 0;
        public Emplado()
        {
            InitializeComponent();
            
            TextBox txtBoxContraseñaEmpleado = new TextBox();
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormLogin formularioLogin = (FormLogin)this.ParentForm;

            formularioLogin.panelRegistroTrabajador.Controls.Remove(this); 
            formularioLogin.RestaurarControles(); // Restaura los controles originales
        }

        private void btnIngresarEmpleado_Click(object sender, EventArgs e)
        {
            FormLogin formularioLogin = (FormLogin)this.ParentForm;

            string Contraseña = txtBoxContraseñaEmpleado.Text; // Contraseña por defecto
            string Gmail = txtBoxGmail.Text;

            if (string.IsNullOrEmpty(Contraseña) || string.IsNullOrEmpty(Gmail))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Empleados WHERE Contraseña = @Contraseña AND Gmail = @Gmail";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Contraseña", Contraseña);
                    cmd.Parameters.AddWithValue("@Gmail", Gmail);

                    int count = (int)cmd.ExecuteScalar(); // Devuelve un número

                    if (count > 0)
                    {
                        MessageBox.Show("Inicio de sesión exitoso.");
                        FormLogin formulario = (FormLogin)this.ParentForm;
                        FormPrincipal principal = new FormPrincipal();
                        principal.Show();
                        formulario.Hide(); // Oculta el formulario de inicio de sesión
                        this.Hide();
                        principal.CargarProductos(); // Carga los empleados en el DataGridView
                        principal.panelPrincipal.Controls.Remove(this); // Elimina el control actual
                        principal.admin = false; // Cambia el estado de administrador
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar conectar a la base de datos: " + ex.Message);
                    return;
                }
            }

            


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            
            contador += 1;


            if (contador % 2 == 0)
            {
                txtBoxContraseñaEmpleado.UseSystemPasswordChar = true;
            }
            else
            {
                txtBoxContraseñaEmpleado.UseSystemPasswordChar = false;
            }
            
        }
    }
}
