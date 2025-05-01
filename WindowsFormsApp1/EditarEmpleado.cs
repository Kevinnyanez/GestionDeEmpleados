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

            string Empleado = textBoxEmpleadoModificar.Text;
            string DatoAModificar = comboBoxDatoPersonalModificar.Text;
            string NuevoDato = textBoxNuevoValor.Text;
            int DiasPersonalesAsignadoCambio = int.Parse(comboBoxDiasPersonalesAsignadosCambio.Text);
            int DiasPersonalesRestantesCambio = int.Parse(comboBoxDiasPersonalesRestantesCambio.Text);
            int VacacionesAsignadasCambio = int.Parse(comboBoxVacacionesAsignadasCambio.Text);
            int VacacionesRestantesCambio = int.Parse(comboBoxVacacionesRestantesCambio.Text);
            int LicenciaAsignadaCambio = int.Parse(comboBoxLicenciasAsignadasCambio.Text);
            int LicenciaRestanteCambio = int.Parse(comboBoxLicenciasRestantesCambio.Text);


            if (string.IsNullOrEmpty(Empleado))
            {
                MessageBox.Show("Por favor, seleccione un empleado.");
                return;
            }

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

            foreach (string datos in DatosPersonales)
            {
                if(datos == DatoAModificar)
                {
                    if (string.IsNullOrEmpty(NuevoDato))
                    {
                        MessageBox.Show("Por favor, ingrese un nuevo dato.");
                        return;
                    }
                    datos.Trim();
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
                    string query = "UPDATE Empleados SET " + datos + " = @NuevoDato WHERE NombreCompleto = @Empleado";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NuevoDato", NuevoDato);
                    command.Parameters.AddWithValue("@Empleado", Empleado);

                    // Ejecutamos el query
                    int columnasAfectadas = command.ExecuteNonQuery();

                    if (columnasAfectadas > 0)
                    {
                        MessageBox.Show("El dato se ha modificado correctamente.");
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
