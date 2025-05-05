using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Controllers;


namespace WindowsFormsApp1
{
    public partial class RegistroDeEmpleados : UserControl
    {
        

        public RegistroDeEmpleados()
        {
            InitializeComponent();

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtboxDni, "Ej: 41.254.123");
            toolTip.SetToolTip(txtboxNombre, "Ej: Ana María Díaz");
            toolTip.SetToolTip(txtboxCelular, "Ej; 2923365417");
            toolTip.SetToolTip(txtboxGmail, "example@gmail.com");
            toolTip.SetToolTip(txtboxNacimiento, "1999/11/30");
            toolTip.SetToolTip(comboBoxDiasPersonales, "Ingrese sus días personales");
            toolTip.SetToolTip(comboBoxVacaciones, "Seleccione sus vacaciones asignadas");
            toolTip.SetToolTip(comboBoxLicenciaAsignada, "Seleccione su licencia asignada");
            toolTip.SetToolTip(btnRegistrarEmpleado, "Registrar empleado");
        }



        private void btnRegistrarEmpleado_Click_1(object sender, EventArgs e)
        {
            // Enfocar en el txt de nombre
            txtboxNombre.Focus();

            //Llamamos al método estatico RegistrarEmpleado de la clase EmpleadoController 
            //y le pasamos los datos del empleado que ingreso el usuario
            //El método devuelve la cantidad de filas afectadas
            //Si se registró correctamente, devuelve 1, si no, devuelve 0
            int rowaffected = EmpleadoController.RegistrarEmpleado(txtboxNombre.Text, txtboxCelular.Text, txtboxGmail.Text, txtboxGmail.Text, txtboxNacimiento.Text, comboBoxDiasPersonales.Text, comboBoxVacaciones.Text, comboBoxLicenciaAsignada.Text, txtBoxContraseña.Text);
            
            // Verificamos si se registró el empleado
            if (rowaffected == 0)
             {
                    MessageBox.Show("No se pudo registrar el empleado.");
             }
            else
             {
                    MessageBox.Show("Empleado registrado correctamente.");
                    txtboxNombre.Clear();
                    txtboxCelular.Clear();
                    txtboxGmail.Clear();
                    txtboxDni.Clear();
                    txtboxNacimiento.Clear();
                    txtBoxContraseña.Clear();
                    comboBoxDiasPersonales.SelectedIndex = -1;
                    comboBoxVacaciones.SelectedIndex = -1;
                    comboBoxLicenciaAsignada.SelectedIndex = -1;
             }

        }

        
    }
}
