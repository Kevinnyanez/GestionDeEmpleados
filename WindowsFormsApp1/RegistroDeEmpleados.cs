using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class RegistroDeEmpleados : UserControl
    {
        
        private Panel panelPrincipal;
        private DataGridView dataGridViewEmpleados;
        private Button btnSalir;


        public RegistroDeEmpleados()
        {
            InitializeComponent();

           

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtboxDni, "Ej: 41.254.123");
            toolTip.SetToolTip(txtboxNombre, "Ej: Ana María Díaz");
            toolTip.SetToolTip(txtboxCelular, "2923365417");
            toolTip.SetToolTip(txtboxGmail, "example@gmail.com");
            toolTip.SetToolTip(txtboxNacimiento, "1999/11/30");
            toolTip.SetToolTip(comboBoxDiasPersonales, "Ingrese sus días personales");
            toolTip.SetToolTip(comboBoxVacaciones, "Seleccione sus vacaciones asignadas");
            toolTip.SetToolTip(comboBoxLicenciaAsignada, "Seleccione su licencia asignada");
            toolTip.SetToolTip(btnRegistrarEmpleado, "Registrar empleado");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormPrincipal formularioPrincipal = (FormPrincipal)this.ParentForm;

            formularioPrincipal.panelContenido.Controls.Remove(this);
            formularioPrincipal.panelPrincipal.Visible = true;
            formularioPrincipal.dataGridViewEmpleados.Visible = true;
            formularioPrincipal.panelContenido.Visible = false;
            formularioPrincipal.RestaurarControles();
            formularioPrincipal.CargarEmpleados();


        }

        private void btnRegistrarEmpleado_Click_1(object sender, EventArgs e)
        {
            // Enfocar en el txt de nombre
            txtboxNombre.Focus();

            //Llenamos las variables con los valores introducidos por el usuario
            string Nombre = txtboxNombre.Text.ToLower();
            string Celular = txtboxCelular.Text.ToLower();
            string Gmail = txtboxGmail.Text.ToLower();
            String DNI = txtboxDni.Text;
            String Nacimiento = txtboxNacimiento.Text;
            int DiasPersonales = int.Parse(comboBoxDiasPersonales.Text);
            int VacacionesAsignadas = int.Parse(comboBoxVacaciones.Text);
            int LicenciasAsignadas = int.Parse(comboBoxLicenciaAsignada.Text);
            string Contraseña = txtBoxContraseña.Text; // Contraseña por defecto

            //Validamos que los campos no estén vacíos
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Celular) || string.IsNullOrEmpty(Gmail) || string.IsNullOrEmpty(DNI) || string.IsNullOrEmpty(Nacimiento) || string.IsNullOrEmpty(Contraseña))
            {
                MessageBox.Show("Todos los campos deben estar llenos.");
                return;
            }
            //Validamos que el DNI tenga 8 dígitos
            if (DNI.Length != 10)
            {
                MessageBox.Show("El DNI debe tener 10 dígitos.");
                return;
            }
            
            
            try
            {
                // Conectamos a la base de datos
                SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
                connection.Open();

                // Armamos el query
                string query = "INSERT INTO Empleados (NombreCompleto, NumeroCelular, Gmail, DNI, FechaCumple, DiasPersonalesAsignados, VacacionesAsignadas, LicenciasAsignadas, Contraseña) " +
                "VALUES (@NombreCompleto, @NumeroCelular, @Gmail, @DNI, @FechaCumple, @DiasPersonalesAsignados, @VacacionesAsignadas, @LicenciasAsignadas, @Contraseña)";

                // Ejecutamos el query
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreCompleto", Nombre);
                command.Parameters.AddWithValue("@NumeroCelular", Celular);
                command.Parameters.AddWithValue("@Gmail", Gmail);
                command.Parameters.AddWithValue("@DNI", DNI);
                command.Parameters.AddWithValue("@FechaCumple", Nacimiento);
                command.Parameters.AddWithValue("@DiasPersonalesAsignados", DiasPersonales);
                command.Parameters.AddWithValue("@VacacionesAsignadas", VacacionesAsignadas);
                command.Parameters.AddWithValue("@LicenciasAsignadas", LicenciasAsignadas);
                command.Parameters.AddWithValue("@Contraseña", Contraseña); // Contraseña por defecto
                int rowaffected = command.ExecuteNonQuery();

                // Verificamos si se registró el empleado
                if (rowaffected == 0)
                {
                    MessageBox.Show("No se pudo registrar el empleado.");
                }
                else
                {
                    MessageBox.Show("Empleado registrado correctamente.");
                    txtboxNombre.Clear();
                    txtboxCelular.Clear();
                    txtboxGmail.Clear();
                    txtboxDni.Clear();
                    txtboxNacimiento.Clear();
                    txtBoxContraseña.Clear();
                    comboBoxDiasPersonales.SelectedIndex = -1;
                    comboBoxVacaciones.SelectedIndex = -1;
                    comboBoxLicenciaAsignada.SelectedIndex = -1;
                }

                // Cerramos la conexión
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de SQL: {ex.Message}");

            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
