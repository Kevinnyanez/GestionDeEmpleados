using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class EditarEmpleado : UserControl
    {
        public EditarEmpleado()
        {
            InitializeComponent();
        }




        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxEmpleadoModificar.Text) || string.IsNullOrEmpty(textBoxNuevoValor.Text) || comboBoxDatoPersonalModificar.SelectedItem == null)
            {
                MessageBox.Show("Datos Personales no seleccionados");
            }
            else
            {
                int columnasAfectadas = EmpleadoController.EditarDatosPersonalesEmpleados(textBoxEmpleadoModificar.Text, textBoxNuevoValor.Text, comboBoxDatoPersonalModificar.Text);

                if (columnasAfectadas > 0)
                {
                    MessageBox.Show("El dato se ha modificado correctamente.");
                    textBoxNuevoValor.Clear(); // Limpiar el campo de texto
                    textBoxNuevoValor.Focus(); // Enfocar el campo de texto
                                               // Aquí puedes agregar código para actualizar el DataGridView o realizar otras acciones necesarias

                    FormPrincipal form = (FormPrincipal)this.ParentForm;
                    form.CargarEmpleados(); // Llamar al método para cargar los empleados nuevamente
                   

                }
                else
                {
                    MessageBox.Show("No se pudo modificar el dato.");
                }
            }
            
            int diasAsignados, diasRestantes, vacacionesAsignadas, vacacionesUsadas, licenciasAsignadas, licenciasUsadas;
            
            // Intentar convertir cada campo, si falla, asignar 0 por defecto
            int.TryParse(comboBoxDiasPersonalesAsignadosCambio.Text, out diasAsignados);
            int.TryParse(comboBoxDiasPersonalesRestantesCambio.Text, out diasRestantes);
            int.TryParse(comboBoxVacacionesAsignadasCambio.Text, out vacacionesAsignadas);
            int.TryParse(comboBoxVacacionesRestantesCambio.Text, out vacacionesUsadas);
            int.TryParse(comboBoxLicenciasAsignadasCambio.Text, out licenciasAsignadas);
            int.TryParse(comboBoxLicenciasRestantesCambio.Text, out licenciasUsadas);
            List<int> valores = new List<int>
            {
                diasAsignados, diasRestantes, vacacionesAsignadas, vacacionesUsadas, licenciasAsignadas, licenciasUsadas
             };

            if (valores.All(v => v == 0))
            {
                MessageBox.Show("Datos Laborales no seleccionados");
                return;
            }
            else
            {

                int columnasAfectadasLaboral = EmpleadoController.EditarDatosLaboralesEmpleados(textBoxEmpleadoModificar.Text, diasAsignados, diasRestantes, vacacionesAsignadas, vacacionesUsadas, licenciasAsignadas, licenciasUsadas);

                if (columnasAfectadasLaboral > 0)
                {
                    MessageBox.Show($"Se han modificado {columnasAfectadasLaboral} filas.");
                    
                    textBoxNuevoValor.Clear(); // Limpiar el campo de texto
                    textBoxNuevoValor.Focus(); // Enfocar el campo de texto
                                               // Aquí puedes agregar código para actualizar el DataGridView o realizar otras acciones necesarias
                    FormPrincipal form = (FormPrincipal)this.ParentForm;
                    form.CargarEmpleados(); // Llamar al método para cargar los empleados nuevamente
                    return;
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el dato.");
                }
            }

        }
    }
}
