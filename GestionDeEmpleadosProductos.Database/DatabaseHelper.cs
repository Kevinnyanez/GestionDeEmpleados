using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GestionDeEmpleadosProductosDatabase
{
    // Clase que contiene la lógica de conexión a la base de datos
    public class DatabaseHelper
    {
<<<<<<< HEAD
        public static string ConnectionString = "Server=YANEZKEVIN\\SQLEXPRESS01;Database=Gestion_De_Empleados;Integrated Security=True;";
=======
        public static string ConnectionString = "Server=DESKTOP-67ATF2C\\SQLEXPRESS;Database=Gestion_De_Empleados;Integrated Security=True;";
>>>>>>> b86e4509051fc065eada116ee3abe4b53d360584

        public static string GetConnectionString()
        {
            return ConnectionString;
        }

        // Método para conectar a la base de datos
        public static void ConectarBD()
        {
            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();
                    Console.WriteLine("Conexión exitosa a la base de datos.");
                }
                catch (Exception ex)
                {
                    // Si hay un error, mostrar mensaje
                    Console.WriteLine("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }
    }
}
