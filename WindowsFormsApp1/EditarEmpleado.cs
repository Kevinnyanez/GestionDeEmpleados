using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditarEmpleado : UserControl
    {
        public EditarEmpleado()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            var DatosPersonales = new List<string>
            {
                "Nombre Completo",
                "Numero Celular",
                "Gmail",
                "DNI",
                "Cumpleaños"
            };

            var DatosLaborales = new List<ComboBox>
            {
                comboBoxDiasPersonalesAsignadosCambio,
                comboBoxDiasPersonalesRestantesCambio,
                comboBoxVacacionesAsignadasCambio,
                comboBoxVacacionesRestantesCambio,
                comboBoxLicenciasAsignadasCambio,
                comboBoxLicenciasRestantesCambio

            };

            string Empleado = textBoxEmpleadoModificar.Text;
            
            String DatoAModificar = comboBoxDatoPersonalModificar.Text;
            
            string NuevoDato = textBoxNuevoValor.Text;
            foreach (var comboBox in DatosLaborales)
            {
                if (comboBox != null && !string.IsNullOrWhiteSpace(comboBox.Text))
                {
                    int valor = int.Parse(comboBox.Text);
                    comboBox.SelectedItem = valor; // Si el valor está en la lista, se asigna
                }
            }




            /*
            int DiasPersonalesAsignadoCambio = int.Parse(comboBoxDiasPersonalesAsignadosCambio.Text);
            int DiasPersonalesRestantesCambio = int.Parse(comboBoxDiasPersonalesRestantesCambio.Text);
            int VacacionesAsignadasCambio = int.Parse(comboBoxVacacionesAsignadasCambio.Text);
            int VacacionesRestantesCambio = int.Parse(comboBoxVacacionesRestantesCambio.Text);
            int LicenciaAsignadaCambio = int.Parse(comboBoxLicenciasAsignadasCambio.Text);
            int LicenciaRestanteCambio = int.Parse(comboBoxLicenciasRestantesCambio.Text); 
            */

            // Validar que el campo nombre de empleado no esté vacío
            if (string.IsNullOrEmpty(Empleado))
            {
                MessageBox.Show("Por favor, seleccione un empleado.");
                return;
            }

            // Validar que el campo dato a modificar no esté vacío
            var condiciones = new List<bool>
            {
                string.IsNullOrWhiteSpace(DatoAModificar),
                string.IsNullOrWhiteSpace(NuevoDato),
                string.IsNullOrWhiteSpace(comboBoxDiasPersonalesAsignadosCambio.Text),
                string.IsNullOrWhiteSpace(comboBoxDiasPersonalesRestantesCambio.Text),
                string.IsNullOrWhiteSpace(comboBoxVacacionesAsignadasCambio.Text),
                string.IsNullOrWhiteSpace(comboBoxVacacionesRestantesCambio.Text),
                string.IsNullOrWhiteSpace(comboBoxLicenciasAsignadasCambio.Text),
                string.IsNullOrWhiteSpace(comboBoxLicenciasRestantesCambio.Text)

            };

            // Validar que el campo no esté vacío
            if (condiciones.All(c => c))
            {
                MessageBox.Show("Por favor, realice aunque sea un cambio");
                return;
            }

            //Comienza la modificación de datos personales si es que se agregó uno
            foreach (string datos in DatosPersonales)
            {
                
                if (datos == DatoAModificar)
                {
                    if (string.IsNullOrEmpty(NuevoDato))
                    {
                        MessageBox.Show("Por favor, ingrese un nuevo dato.");
                        return;
                    }
                    string dato = datos.Replace(" ", "");
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
                        return;
                    }

                    var columnaAModificar = dato;
                    // Armamos el query
                    string query = "UPDATE Empleados SET [" + columnaAModificar + "] = @NuevoDato WHERE NombreCompleto = @Empleado";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NuevoDato", NuevoDato);
                    command.Parameters.AddWithValue("@Empleado", Empleado);

                    // Ejecutamos el query
                    int columnasAfectadas = command.ExecuteNonQuery();

                    if (columnasAfectadas > 0)
                    {
                        MessageBox.Show("El dato se ha modificado correctamente.");
                        textBoxNuevoValor.Clear(); // Limpiar el campo de texto
                        textBoxNuevoValor.Focus(); // Enfocar el campo de texto
                        // Aquí puedes agregar código para actualizar el DataGridView o realizar otras acciones necesarias
                        
                        FormPrincipal form = (FormPrincipal)this.ParentForm;
                        form.CargarEmpleados(); // Llamar al método para cargar los empleados nuevamente

                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el dato.");
                    }

                }
            }

            if (string.IsNullOrEmpty(comboBoxDiasPersonalesAsignadosCambio.Text) &&
                string.IsNullOrEmpty(comboBoxDiasPersonalesRestantesCambio.Text) &&
                string.IsNullOrEmpty(comboBoxVacacionesAsignadasCambio.Text) &&
                string.IsNullOrEmpty(comboBoxVacacionesRestantesCambio.Text) &&
                string.IsNullOrEmpty(comboBoxLicenciasAsignadasCambio.Text) &&
                string.IsNullOrEmpty(comboBoxLicenciasRestantesCambio.Text))
                
            {
                return;
            }

            else
            {
                foreach (ComboBox datos in DatosLaborales)
                {
                    if (datos != null && datos.SelectedItem != null)
                    {
                        int ValorParaCambiar = int.Parse(datos.SelectedItem.ToString());
                        ComboBox ColumnaACambiar = datos;

                        // Crear un diccionario para mapear los ComboBox con sus valores correspondientes
                        Dictionary<ComboBox, string> columnas = new Dictionary<ComboBox, string>
                    {
                        { comboBoxDiasPersonalesAsignadosCambio, "DiasPersonalesAsignados" },
                        { comboBoxDiasPersonalesRestantesCambio, "DiasPersonalesRestantes" },
                        { comboBoxVacacionesAsignadasCambio, "VacacionesAsignadas" },
                        { comboBoxVacacionesRestantesCambio, "VacacionesUsadas" },
                        { comboBoxLicenciasAsignadasCambio, "LicenciasAsignadas" },
                        { comboBoxLicenciasRestantesCambio, "LicenciasUsadas" }
                     };

                        // Intentar obtener el valor usando el ComboBox seleccionado
                        string ColumnaElegida = columnas.ContainsKey(datos) ? columnas[datos] : "";



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
                            return;
                        }

                        // Armamos el query
                        string query = " UPDATE Empleados SET " + ColumnaElegida + " = @ValorParaCambiar WHERE NombreCompleto = @Empleado ";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ValorParaCambiar", ValorParaCambiar);
                        command.Parameters.AddWithValue("@Empleado", Empleado);

                        // Ejecutamos el query
                        int columnasAfectadas = command.ExecuteNonQuery();
                        if (columnasAfectadas > 0)
                        {
                            MessageBox.Show("El dato se ha modificado correctamente.");
                            textBoxNuevoValor.Clear(); // Limpiar el campo de texto
                            textBoxNuevoValor.Focus(); // Enfocar el campo de texto
                            // Aquí puedes agregar código para actualizar el DataGridView o realizar otras acciones necesarias
                            FormPrincipal form = (FormPrincipal)this.ParentForm;
                            form.CargarEmpleados(); // Llamar al método para cargar los empleados nuevamente
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar el dato.");
                        }
                    }
                }
            }
        }
    }
}
