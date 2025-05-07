using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using GestionDeEmpleados.Models;
using GestionDeEmpleados.Database;
using System.Windows.Form;

namespace GestionDeEmpleados.Controllers
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
                MessageBox.Show("Por favor, complete todos los campos.");
                return (count, "");
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
                        MessageBox.Show("Inicio de sesión exitoso.");
                        MessageBox.Show("Bienvenido " + nombre);
                        return (count, nombre);
                    }
                    
                }
                // Si hay un error, mostrar mensaje
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                    return (count, "");
                }
                finally { connection.Close(); }
            }
            return (count, ""); // Retorna 0 si no se encontró el empleado
        }



        //Método Para registrar empleados
        //Recibe los datos del empleado y devuelve la cantidad de filas afectadas
        //Si se registró correctamente, devuelve 1, si no, devuelve 0
        //El método recibe los datos del empleado y los guarda en la base de datos
        //El método devuelve la cantidad de filas afectadas
        public static int RegistrarEmpleado(string nombre, string celular, string gmail, string dni, string fechaCumple, string diasPersonales, string vacaciones, string licencia, string contraseña)
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
                MessageBox.Show("Por favor complete todos los campos.");
                return (rowaffected);
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

                    return rowaffected;
                }
                // Si hay un error, mostrar mensaje
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                    return rowaffected;
                }
                finally { connection.Close(); }
            }
        }

        //Método para editar los datos personales de un empleado
        //Recibe el nombre del empleado, el nuevo dato y el dato a modificar
        //Devuelve la cantidad de filas afectadas
        //Si se modificó correctamente, devuelve 1, si no, devuelve 0
        public static int EditarDatosPersonalesEmpleados(string empleado, string nuevoDato, string datoAModificar)
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
                MessageBox.Show("Por favor, seleccione un empleado.");
                return count;
            }
            if (string.IsNullOrEmpty(NuevoDato))
            {
                MessageBox.Show("Por favor, ingrese un nuevo dato.");
                return count;
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
                            MessageBox.Show("El empleado no existe.");
                            return count;
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
                        MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                        return count;
                    }
                    finally { connection.Close(); }


                }

            }
            return count;

        }

        //Método para editar los datos laborales de un empleado
        //Recibe el nombre del empleado, los días personales asignados, los días personales restantes,
        //las vacaciones asignadas, las vacaciones usadas, las licencias asignadas y las licencias usadas
        //Devuelve la cantidad de filas afectadas
        //Si se modificó correctamente, devuelve filas afectadas, si no, devuelve 0
        public static int EditarDatosLaboralesEmpleados(string empleado, int diasPersonalesAsignados, int diasPersonalesRestantes, int vacacionesAsignadas, int vacacionesUsadas, int licenciasAsignadas, int licenciasUsadas)
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
                            MessageBox.Show("El empleado no existe.");
                            return count;
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
            return columnasAfectadas;
            }

        public static int EliminarEmpleado(string Empleado)
        {
            int rowsAffected = 0;
            // Verificar si el campo de texto está vacío
            if (string.IsNullOrEmpty(Empleado))
            {
                MessageBox.Show("El campo de texto no puede estar vacío.");
                return rowsAffected;
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
                MessageBox.Show("El empleado no existe.");
                return rowsAffected;
            }

            DialogResult resultado = MessageBox.Show(
            "¿Seguro que quiere eliminar?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                // Si el empleado existe, procedemos a eliminarlo
                string queryEliminar = "DELETE FROM Empleados WHERE NombreCompleto = @Empleado";
                SqlCommand commandEliminar = new SqlCommand(queryEliminar, connection);
                commandEliminar.Parameters.AddWithValue("@Empleado", Empleado);
                rowsAffected = commandEliminar.ExecuteNonQuery();
                return rowsAffected;


            }
            else
            {
                MessageBox.Show("Operación cancelada.");
                return rowsAffected;
            }
        }
        }
    }

    

    

