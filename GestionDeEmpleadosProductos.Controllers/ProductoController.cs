using GestionDeEmpleadosProductosDatabase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GestionDeEmpleadosProductos.Controllers
{

        public class CategoriaController
        {

            // Método para obtener todas las categorías de la base de datos
            public static List<KeyValuePair<int, string>> ObtenerCategorias()
            {
                List<KeyValuePair<int, string>> categorias = new List<KeyValuePair<int, string>>();

                using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT CategoriaID, NombreCat FROM Categorias";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categorias.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                        }
                    }
                }

                return categorias;
            }

        public  class SubCategoriaController
        {
            public static List<KeyValuePair<int, string>> ObtenerSubCategorias()
            {
                List<KeyValuePair<int, string>> subCategorias = new List<KeyValuePair<int, string>>();

                using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT SubCatID, SubCatNombre FROM SubCategorias";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subCategorias.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                        }
                    }
                }

                return subCategorias;
            }
        }

    }
}

