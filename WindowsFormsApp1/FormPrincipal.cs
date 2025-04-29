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
    public partial class FormPrincipal: Form
    {
        private List<Control> controlesOriginales = new List<Control>();
        public FormPrincipal()
        {
            InitializeComponent();

           
        }

        //LÓGICA DEL DATAGRIDVIEW
        private void Form2_Load(object sender, EventArgs e)
        {
            // Llamamos a una función que llena la tabla
            CargarEmpleados();
            panelContenido.Visible = false; // Oculta el panel de contenido al inicio

            foreach (Control control in panelPrincipal.Controls)
            {
                controlesOriginales.Add(control);
            }
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

        //BOTÓN DE SALIDA DE LA APLIACIÓN
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //LÓGICA DEL BOTÓN REGISTRAR EMPLEADO
        private void button1_Click(object sender, EventArgs e)
        {

            CargarUserControl(new RegistroDeEmpleados());
        }

        //LOGICA PARA CONTROL USER
        private void CargarUserControl(UserControl nuevoControl)
        {

            dataGridViewEmpleados.Visible = false;
            panelPrincipal.Visible = false; 
            // Limpia el contenido actual del Panel
            panelPrincipal.Controls.Clear();
            panelContenido.Visible = true;
            // Ajusta el nuevo control al tamaño del Panel
            nuevoControl.Dock = DockStyle.Fill;

            // Agrega el UserControl al Panel
            panelContenido.Controls.Add(nuevoControl);
        }

        //LÓGICA PARA RESTAURAR LOS BOTONES
        public void RestaurarControles()
        {
            panelPrincipal.Controls.Clear(); // Limpia por si hay residuos

            foreach (Control control in controlesOriginales)
            {
                panelPrincipal.Controls.Add(control);
            }
        }

    }
}
