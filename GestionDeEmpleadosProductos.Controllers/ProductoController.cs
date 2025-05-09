using GestionDeempleadosProductos.Models;
using GestionDeEmpleadosProductosDatabase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
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
            public static (int,string) crear_producto (string nombreproducto, string descripcion, decimal precio, int stock, int categoria, int subcategoria)
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    int rowaffected = 0;
                    
                    try
                    {
                        string query = "Insert into Productos (NombreProducto, Descripcion, Precio, Stock, Categorias, SubCategorias)" +
                            "VALUES (@NombreCompleto, @Descripcion, @Precio, @Stock, @Categoria, @SubCategoria)";
                        connection.Open();


                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@NombreProducto", nombreproducto);
                        command.Parameters.AddWithValue("@Descripcion", descripcion);
                        command.Parameters.AddWithValue("@Precio", precio);
                        command.Parameters.AddWithValue("@Stock", stock);
                        command.Parameters.AddWithValue("@Categoria", categoria);
                        command.Parameters.AddWithValue("@SubCategoria", subcategoria);

                        rowaffected = command.ExecuteNonQuery();
                        string message = $"El producto {nombreproducto} ha sido creado ";
                        return (rowaffected, message);





                    }
                    catch (Exception ex) 
                    {
                        return (rowaffected, ex.Message);
                    }
                    }
                }
            }
        }

    }


