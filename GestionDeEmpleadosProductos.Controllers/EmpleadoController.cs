using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GestionDeempleadosProductos.Models;
using GestionDeEmpleadosProductosDatabase;

namespace GestionDeEmpleadosProductos.Controllers
{
    public static class EmpleadoController
    {
        //Método para iniciar sesión
        //Recibe la cantidad de registros que hay en la base de datos y cumplen con la condición
        //Si el empleado existe, devuelve 1, si no, devuelve 0
        public static (int, string) inicioSesionEmpleado(string contraseña, string gmail)
        {
            Empleados empleado = new Empleados();
            int count = 0;


            empleado.Contraseña = contraseña; // Contraseña por defecto
            empleado.Gmail = gmail;

            if (string.IsNullOrEmpty(empleado.Contraseña) || string.IsNullOrEmpty(empleado.Gmail))
            {
                
                return (count, "Por favor, complete todos los campos.");
            }

            using (SqlConnection connection = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    // Verificamos si el empleado existe
                    string queryVerificar = "SELECT COUNT(*) FROM Empleados WHERE Contraseña = @Contraseña AND Gmail = @Gmail";
                    SqlCommand commandVerificar = new SqlCommand(queryVerificar, connection);
                    commandVerificar.Parameters.AddWithValue("@Contraseña", empleado.Contraseña);
                    commandVerificar.Parameters.AddWithValue("@Gmail", empleado.Gmail);

                    count = (int)commandVerificar.ExecuteScalar();
                    
                    string queryNombre = "SELECT NombreCompleto FROM Empleados WHERE Contraseña = @Contraseña AND Gmail = @Gmail";
                    SqlCommand commandNombre = new SqlCommand(queryNombre, connection);
                    commandNombre.Parameters.AddWithValue("@Contraseña", empleado.Contraseña);
                    commandNombre.Parameters.AddWithValue("@Gmail", empleado.Gmail);
                    SqlDataReader reader = commandNombre.ExecuteReader();
                    if (reader.Read())
                    {

                        string nombre = reader["NombreCompleto"].ToString();
                        return (count, nombre);
                    }
                    
                }
                // Si hay un error, mostrar mensaje
                catch (Exception ex)
                {
                    
                    return (count, "Error al conectar con la base de datos: " + ex.Message );
                }
                finally { connection.Close(); }
            }
            return (count, "No se encontró ningun empleado"); // Retorna 0 si no se encontró el empleado
        }



        //Método Para registrar empleados
        //Recibe los datos del empleado y devuelve la cantidad de filas afectadas
        //Si se registró correctamente, devuelve 1, si no, devuelve 0
        //El método recibe los datos del empleado y los guarda en la base de datos
        //El método devuelve la cantidad de filas afectadas
        public static (int,string) RegistrarEmpleado(string nombre, string celular, string gmail, string dni, string fechaCumple, string diasPersonales, string vacaciones, string licencia, string contraseña)
        {
            Empleados empleado = new Empleados();
            int rowaffected = 0;

            empleado.NombreCompleto = nombre.ToLower();
            empleado.NumeroCelular = celular.ToLower();
            empleado.Gmail = gmail.ToLower();
            empleado.DNI = dni;
            empleado.FechaCumple = fechaCumple;
            empleado.DiasPersonalesAsignados = int.Parse(diasPersonales);
            empleado.VacacionesAsignadas = int.Parse(vacaciones);
            empleado.LicenciasAsignadas = int.Parse(licencia);
            empleado.Contraseña = contraseña; // Contraseña por defecto

            var campos = new object[]
            {
                empleado.NombreCompleto,
                empleado.NumeroCelular,
                empleado.Gmail,
                empleado.DNI,
                empleado.FechaCumple,
                empleado.DiasPersonalesAsignados,
                empleado.VacacionesAsignadas,
                empleado.LicenciasAsignadas,
                empleado.Contraseña
             };
            var camposInt = new int[]
            {
                empleado.DiasPersonalesAsignados,
                empleado.VacacionesAsignadas,
                empleado.LicenciasAsignadas
            };




            //Validamos los campos
            if (campos.Any(c => string.IsNullOrEmpty(c?.ToString())) || camposInt.Any(c => c <= 0))
            {
                string error = "Por favor complete todos los campos.";
                return (rowaffected, error);
            }


            using (SqlConnection connection = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {

                try
                {
                    // Armamos el query
                    string query = "INSERT INTO Empleados (NombreCompleto, NumeroCelular, Gmail, DNI, FechaCumple, DiasPersonalesAsignados, VacacionesAsignadas, LicenciasAsignadas, Contraseña) " +
                    "VALUES (@NombreCompleto, @NumeroCelular, @Gmail, @DNI, @FechaCumple, @DiasPersonalesAsignados, @VacacionesAsignadas, @LicenciasAsignadas, @Contraseña)";

                    // Creamos la conexión
                    connection.Open();

                    // Ejecutamos el query
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NombreCompleto", empleado.NombreCompleto);
                    command.Parameters.AddWithValue("@NumeroCelular", empleado.NumeroCelular);
                    command.Parameters.AddWithValue("@Gmail", empleado.Gmail);
                    command.Parameters.AddWithValue("@DNI", empleado.DNI);
                    command.Parameters.AddWithValue("@FechaCumple", empleado.FechaCumple);
                    command.Parameters.AddWithValue("@DiasPersonalesAsignados", empleado.DiasPersonalesAsignados);
                    command.Parameters.AddWithValue("@VacacionesAsignadas", empleado.VacacionesAsignadas);
                    command.Parameters.AddWithValue("@LicenciasAsignadas", empleado.LicenciasAsignadas);
                    command.Parameters.AddWithValue("@Contraseña", empleado.Contraseña); // Contraseña por defecto
                    rowaffected = command.ExecuteNonQuery();
                    string mensaje = $"Empleado {empleado.NombreCompleto} registrado correctamente.";
                    return (rowaffected, mensaje);
                }
                // Si hay un error, mostrar mensaje
                catch (Exception ex)
                {
                    string error = $"Error al conectar con la base de datos: {ex.Message} ";
                    return (rowaffected, error);
                }
                finally { connection.Close(); }
            }
        }

        //Método para editar los datos personales de un empleado
        //Recibe el nombre del empleado, el nuevo dato y el dato a modificar
        //Devuelve la cantidad de filas afectadas
        //Si se modificó correctamente, devuelve 1, si no, devuelve 0
        public static (int, string) EditarDatosPersonalesEmpleados(string empleado, string nuevoDato, string datoAModificar)
        {
            var DatosPersonales = new List<string>
            {
                "Nombre Completo",
                "Numero Celular",
                "Gmail",
                "DNI",
                "Cumpleaños"
            };

            int count = 0;
            string Empleado = empleado;
            string NuevoDato = nuevoDato;
            string DatoAModificar = datoAModificar;

            // Validar que el campo nombre de empleado no esté vacío
            if (string.IsNullOrEmpty(Empleado))
            {
                string error =  "Por favor, seleccione un empleado.";
                return (count,error);
            }
            if (string.IsNullOrEmpty(NuevoDato))
            {
                string error = "Por favor, ingrese un nuevo dato.";
                return (count, error);
            }
        

            foreach (string datos in DatosPersonales)
            {

                if (datos == DatoAModificar)
                {

                    string dato = datos.Replace(" ", "");

                    // Conectamos a la base de datos

                    SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
                    try {
                        connection.Open();

                        // Verificamos si el empleado existe
                        string queryVerificar = "SELECT COUNT(*) FROM Empleados WHERE NombreCompleto = @Empleado";
                        SqlCommand commandVerificar = new SqlCommand(queryVerificar, connection);
                        commandVerificar.Parameters.AddWithValue("@Empleado", Empleado);
                        count = (int)commandVerificar.ExecuteScalar();
                        if (count == 0)
                        {
                            string error = "El empleado no existe.";
                            return (count, error);
                        }
                        var columnaAModificar = dato;

                        string query = "UPDATE Empleados SET [" + columnaAModificar + "] = @NuevoDato WHERE NombreCompleto = @Empleado";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@NuevoDato", NuevoDato);
                        command.Parameters.AddWithValue("@Empleado", Empleado);

                        // Ejecutamos el query
                        count = command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        string error = $"Error al conectar con la base de datos: {ex.Message}";
                        return (count, error);
                    }
                    finally { connection.Close(); }


                }

            }
            return (count, "");

        }


        //Método para editar los datos laborales de un empleado
        //Recibe el nombre del empleado, los días personales asignados, los días personales restantes,
        //las vacaciones asignadas, las vacaciones usadas, las licencias asignadas y las licencias usadas
        //Devuelve la cantidad de filas afectadas
        //Si se modificó correctamente, devuelve filas afectadas, si no, devuelve 0
        public static (int,string) EditarDatosLaboralesEmpleados(string empleado, int diasPersonalesAsignados, int diasPersonalesRestantes, int vacacionesAsignadas, int vacacionesUsadas, int licenciasAsignadas, int licenciasUsadas)
        {

            int columnasAfectadas = 0;

            var DatosLaborales = new List<int>
            {
                diasPersonalesAsignados,
                diasPersonalesRestantes,
                vacacionesAsignadas,
                vacacionesUsadas,
                licenciasAsignadas,
                licenciasUsadas

            };
            
            foreach (int datosLaborales in DatosLaborales)
              {
                if (datosLaborales != 0)
                   {
                        
                     int ValorParaCambiar = datosLaborales;

                    List<KeyValuePair<int, string>> columnas = new List<KeyValuePair<int, string>>
                    {
                    new KeyValuePair<int, string>(diasPersonalesAsignados, "DiasPersonalesAsignados"),
                    new KeyValuePair<int, string>(diasPersonalesRestantes, "DiasPersonalesRestantes"),
                    new KeyValuePair<int, string>(vacacionesAsignadas, "VacacionesAsignadas"),
                    new KeyValuePair<int, string>(vacacionesUsadas, "VacacionesUsadas"),
                    new KeyValuePair<int, string>(licenciasAsignadas, "LicenciasAsignadas"),
                    new KeyValuePair<int, string>(licenciasUsadas, "LicenciasUsadas")
                    };

                    // Buscar todas las coincidencias con `datosLaborales`
                    var columnasElegidas = columnas.Where(c => c.Key == datosLaborales).Select(c => c.Value).ToList();

                    // Si hay coincidencias, obtener el primer valor o una lista completa
                    string ColumnaElegida = columnasElegidas.Any() ? columnasElegidas.First() : "";



                    // Conectamos a la base de datos
                    SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
                        connection.Open();

                        // Verificamos si el empleado existe
                        string queryVerificar = "SELECT COUNT(*) FROM Empleados WHERE NombreCompleto = @Empleado";
                        SqlCommand commandVerificar = new SqlCommand(queryVerificar, connection);
                        commandVerificar.Parameters.AddWithValue("@Empleado", empleado);
                        int count = (int)commandVerificar.ExecuteScalar();
                        if (count == 0)
                        {
                            string error = "El empleado no existe.";
                            return (count, error);
                        }

                        // Armamos el query
                        string query = " UPDATE Empleados SET " + ColumnaElegida + " = @ValorParaCambiar WHERE NombreCompleto = @Empleado ";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ValorParaCambiar", ValorParaCambiar);
                        command.Parameters.AddWithValue("@Empleado", empleado);

                    // Ejecutamos el query
                     columnasAfectadas += command.ExecuteNonQuery();
                    
                        
                    }
                }
            return (columnasAfectadas, "");
            }

        public static (int,string) EliminarEmpleado(string Empleado)
        {
            int rowsAffected = 0;
            // Verificar si el campo de texto está vacío
            if (string.IsNullOrEmpty(Empleado))
            {
                string error = "El campo de texto no puede estar vacío.";
                return (rowsAffected, error);
            }

            // Conectamos a la base de datos
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            connection.Open();

            // Verificamos si el empleado existe
            string queryVerificar = "SELECT COUNT(*) FROM Empleados WHERE NombreCompleto = @Empleado";
            SqlCommand commandVerificar = new SqlCommand(queryVerificar, connection);
            commandVerificar.Parameters.AddWithValue("@Empleado", Empleado);
            int count = (int)commandVerificar.ExecuteScalar();
            if (count == 0)
            {
                string error = "El empleado no existe.";
                return (rowsAffected,error);
            }

            /**/


            // Si el empleado existe, procedemos a eliminarlo
            string queryEliminar = "DELETE FROM Empleados WHERE NombreCompleto = @Empleado";
            SqlCommand commandEliminar = new SqlCommand(queryEliminar, connection);
            commandEliminar.Parameters.AddWithValue("@Empleado", Empleado);
            rowsAffected = commandEliminar.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                return (rowsAffected, "");
            }
            else
            {
                string error = "Operación cancelada.";
                return (rowsAffected, error);
            }
        }
        
    
    
    }
    }

    

    

