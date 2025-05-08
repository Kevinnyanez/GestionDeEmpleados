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

            (int rowsAffected, string mensaje) = EmpleadoController.EliminarEmpleado(textBoxEmpleadoAEliminar.Text);

            if (rowsAffected > 0)
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Seguro que quiere eliminar?",
                        "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );
                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Empleado eliminado exitosamente.");
                    textBoxEmpleadoAEliminar.Clear(); // Limpiar el campo de texto
                    textBoxEmpleadoAEliminar.Focus(); // Enfocar el campo de texto
                                                      // Aquí puedes agregar código para actualizar el DataGridView o realizar otras acciones necesarias
                    FormPrincipal form = (FormPrincipal)this.ParentForm;
                    form.CargarEmpleados(); // Llamar al método para cargar los empleados nuevamente
                }
                else
                {
                    MessageBox.Show("Eliminación cancelada.");
                }
                }
            else
            {
                MessageBox.Show("Error al eliminar el empleado.");
                if(mensaje.StartsWith("El campo de texto no puede estar vacío."))
                {
                    MessageBox.Show(mensaje);
                }
                if(mensaje.StartsWith("El empleado no existe."))
                {
                    MessageBox.Show(mensaje);
                }
            }


        }
    }
}
