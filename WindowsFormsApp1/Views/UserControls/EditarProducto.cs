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
    }
}
