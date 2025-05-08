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


  
        private void btnVolver_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
