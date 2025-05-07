using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Database;
using GestionDeEmpleados.Models;
using GestionDeEmpleados.Database;
using System.Windows.Forms;


namespace GestionDeEmpleados.Controllers
{
    public static class AdminController
    {

        public static int IniciarSesion(Admin Admin)
        {

            // Conectamos a la base de datos
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                int count = 0;

                try
                {
                    connection.Open();
                    // Verificamos si el usuario existe en la base de datos
                    string query = "SELECT COUNT(*) FROM Admins WHERE NombreUsuario = @Usuario AND Contraseña = @Contraseña";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Usuario", Admin.NombreUsuario);
                    cmd.Parameters.AddWithValue("@Contraseña", Admin.Contraseña);
                    count = (int)cmd.ExecuteScalar(); // Devuelve un número
                    return count;
                }
                catch (Exception ex) {
                    // Si hay un error, mostrar mensaje
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                    return count;

                }
                finally { connection.Close(); }

                
            }
        }

        
    }
}



