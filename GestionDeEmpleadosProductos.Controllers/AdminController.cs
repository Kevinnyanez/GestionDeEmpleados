using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeempleadosProductos.Models;
using GestionDeEmpleadosProductosDatabase;


namespace GestionDeEmpleadosProductos.Controllers
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
               
                finally { connection.Close(); }

                
            }
        }

        
    }
}



