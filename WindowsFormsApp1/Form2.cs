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
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Llamamos a una función que llena la tabla
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Empleados";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    System.Data.DataTable table = new System.Data.DataTable();
                    adapter.Fill(table);

                    dataGridViewEmpleados.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistroEmpleados formRegistroEmpleados = new FormRegistroEmpleados();
            formRegistroEmpleados.Show();
            this.Hide();
        }
    }
}
