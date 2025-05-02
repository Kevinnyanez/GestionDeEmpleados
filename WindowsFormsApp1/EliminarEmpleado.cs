using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EliminarEmpleado : UserControl
    {
        public EliminarEmpleado()
        {
            InitializeComponent();
        }

        private void btnEliminaTrabajador_Click(object sender, EventArgs e)
        {

            String Empleado = textBoxEmpleadoAEliminar.Text;
            // Verificar si el campo de texto está vacío
            if (string.IsNullOrEmpty(Empleado))
            {
                MessageBox.Show("El campo de texto no puede estar vacío.");
                return;
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
                return;
            }

            // Si el empleado existe, procedemos a eliminarlo
            string queryEliminar = "DELETE FROM Empleados WHERE NombreCompleto = @Empleado";
            SqlCommand commandEliminar = new SqlCommand(queryEliminar, connection);
            commandEliminar.Parameters.AddWithValue("@Empleado", Empleado);
            int rowsAffected = commandEliminar.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Empleado eliminado exitosamente.");
            }
            else
            {
                MessageBox.Show("Error al eliminar el empleado.");
            }
        }
    }
}
