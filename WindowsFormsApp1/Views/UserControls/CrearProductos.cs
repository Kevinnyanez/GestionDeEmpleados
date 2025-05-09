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
using GestionDeEmpleadosProductos.Controllers;
using GestionDeempleadosProductos.Models;
using GestionDeEmpleadosProductos;
using static GestionDeEmpleadosProductos.Controllers.CategoriaController;
using System.Collections.Concurrent;

namespace WindowsFormsApp1
{
    public partial class CrearProductos : UserControl
    {
        public KeyValuePair<int, string> CategoriaSeleccionada { get; private set; }
        public CrearProductos()
        {
            InitializeComponent();
            LlenarComboBoxCategorias();
            LlenarComboBoxSubCategorias();
        }

        public void LlenarComboBoxCategorias()
        {
            List<KeyValuePair<int, string>> categorias = CategoriaController.ObtenerCategorias();

            comboBoxCategorias.DataSource = categorias;
            comboBoxCategorias.DisplayMember = "Value";  // Muestra el nombre de la categoría
            comboBoxCategorias.ValueMember = "Key";      // Guarda el ID internamente

           
        }

        public void LlenarComboBoxSubCategorias()
        {
            List<KeyValuePair<int, string>> subCategorias = SubCategoriaController.ObtenerSubCategorias();

            comboBoxSubCategorias.DataSource = subCategorias;
            comboBoxSubCategorias.DisplayMember = "Value";  // Muestra el nombre de la subcategoría
            comboBoxSubCategorias.ValueMember = "Key";      // Guarda el ID internamentee

           
        }


  
        private void btnVolver_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            decimal precio = decimal.Parse(txtboxPrecio.Text);
            int stock = int.Parse(txtboxStock.Text);
            int categoria = Convert.ToInt32(comboBoxCategorias.SelectedValue);
            int subcategoria = Convert.ToInt32(comboBoxSubCategorias.SelectedValue);

            (int count, string message) = SubCategoriaController.crear_producto(txtboxNombreProducto.Text, txtboxDescripcion.Text, precio, stock, categoria, subcategoria);
            if (count > 0)
            {
                MessageBox.Show(message);

            }
            else 
            { 
            MessageBox.Show(message, "Error");
            }

                
        }
    }
}
