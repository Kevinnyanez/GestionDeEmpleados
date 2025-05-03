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
    public partial class CrearProductos : UserControl
    {
        public KeyValuePair<int, string> CategoriaSeleccionada { get; private set; }
        public CrearProductos()
        {
            InitializeComponent();
            CargarCategorias();
            CargarSubCategorias();
        }

        private void CargarCategorias()
        {
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                string query = "SELECT CategoriaID, NombreCat FROM CategoriaProd";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Agrega los nombres al ComboBox, pero guarda el ID en el ValueMember
                    comboBoxCategorias.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                }

                reader.Close();
            }

            // Ajustar cómo se muestran los datos en el ComboBox
            comboBoxCategorias.DisplayMember = "Value";  // Muestra el nombre de la categoría
            comboBoxCategorias.ValueMember = "Key";      // Guarda el ID de la categoría internamente
        }
        private void CargarSubCategorias()
        {
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                string query = "SELECT SubCatID, SubCatNombre FROM SubCategoria";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Agrega los nombres al ComboBox, pero guarda el ID en el ValueMember
                    comboBoxSubCategorias.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                }
                reader.Close();
            }
            // Ajustar cómo se muestran los datos en el ComboBox
            comboBoxSubCategorias.DisplayMember = "Value";  // Muestra el nombre de la categoría
            comboBoxSubCategorias.ValueMember = "Key";      // Guarda el ID de la categoría internamente
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
