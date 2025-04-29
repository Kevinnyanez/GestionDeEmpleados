using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    // Clase que contiene la lógica de conexión a la base de datos
    public static class DatabaseHelper
    {
       public static string ConnectionString = "Server=MARIANOY\\SQLEXPRESS;Database=Gestion_De_Empleados;Integrated Security=True;";

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
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseHelper.ConectarBD();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
