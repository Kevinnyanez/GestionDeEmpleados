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

namespace WindowsFormsApp1
{
    public partial class EliminarProducto : UserControl
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void btnBotonEliminarProducto_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show(
                 "¿Seguro que quiere eliminar?",
                       "Confirmación",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning
                   );

            if (resultado == DialogResult.Yes)
            {
                (int count, string message) = ProductoController.EliminarProducto(txtBoxProductoEliminar.Text);

                if (count > 0)
                {
                    MessageBox.Show(message, "ha sido eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eliminación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
