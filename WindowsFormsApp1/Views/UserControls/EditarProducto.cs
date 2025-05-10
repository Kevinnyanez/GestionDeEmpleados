using GestionDeEmpleadosProductos.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GestionDeEmpleadosProductos.Controllers.CategoriaController;

namespace WindowsFormsApp1
{
    public partial class EditarProducto : UserControl
    {
        public EditarProducto()
        {
            
            InitializeComponent();
            LlenarComboBoxCategorias();
            LlenarComboBoxSubCategorias();
            LlenarComboBoxProductos();
        }

        public void LlenarComboBoxCategorias()
        {
            List<KeyValuePair<int, string>> categorias = CategoriaController.ObtenerCategorias();

            comboBoxCategorias.DisplayMember = "Value";  // Muestra el nombre de la categoría
            comboBoxCategorias.ValueMember = "Key";      // Guarda el ID internamente

            foreach (var categoria in categorias)
            {
                comboBoxCategorias.Items.Add(categoria);
            }
        }

        public void LlenarComboBoxSubCategorias()
        {
            List<KeyValuePair<int, string>> subCategorias = SubCategoriaController.ObtenerSubCategorias();

            comboBoxSubCategorias.DisplayMember = "Value";  // Muestra el nombre de la subcategoría
            comboBoxSubCategorias.ValueMember = "Key";      // Guarda el ID internamentee

            foreach (var subCategoria in subCategorias)
            {
                comboBoxSubCategorias.Items.Add(subCategoria);
            }
        }

        public void LlenarComboBoxProductos()
        {
            List<KeyValuePair<int, string>> productos = ProductoController.ObtenerProductos();
            comboBoxSeleccionDeProducto.DataSource = productos;
            comboBoxSeleccionDeProducto.DisplayMember = "Value";  // Muestra el nombre de la subcategoría
            comboBoxSeleccionDeProducto.ValueMember = "Key";      // Guarda el ID internamentee
           
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {

            (int count, string menssage) = ProductoController.EditarProducto(Convert.ToInt32(comboBoxSeleccionDeProducto.SelectedValue), txtboxNombreProducto.Text, txtboxDescripcion.Text, decimal.Parse(txtboxPrecio.Text), int.Parse(txtboxStock.Text), Convert.ToInt32(comboBoxCategorias.SelectedValue), Convert.ToInt32(comboBoxSubCategorias.SelectedValue));

            if (count > 0)
            {
                MessageBox.Show(menssage, $"{count} Datos cambiados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(menssage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
