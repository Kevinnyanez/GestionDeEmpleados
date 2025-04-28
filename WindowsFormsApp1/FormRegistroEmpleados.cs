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
    public partial class FormRegistroEmpleados : Form
    {
        public FormRegistroEmpleados()
        {
            InitializeComponent();

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtboxDni, "Ingrese su DNI");
            toolTip.SetToolTip(txtboxNombre, "Ingrese su nombre");
            toolTip.SetToolTip(txtboxCelular, "Ingrese su celular");
            toolTip.SetToolTip(txtboxGmail, "Ingrese su Gmail");
            toolTip.SetToolTip(txtboxNacimiento, "Ingrese su fecha de nacimiento");
            toolTip.SetToolTip(comboBoxDiasPersonales, "Ingrese sus días personales");
            toolTip.SetToolTip(comboBoxVacaciones, "Seleccione sus vacaciones asignadas");
            toolTip.SetToolTip(comboBoxLicenciaAsignada, "Seleccione su licencia asignada");
            toolTip.SetToolTip(btnRegistrarEmpleado, "Registrar empleado");
        }



        private void FormRegistroEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
           

            string Nombre = txtboxNombre.Text;
            string Celular = txtboxCelular.Text;
            string Gmail = txtboxGmail.Text;
            String DNI = txtboxDni.Text;
            DateTime Nacimiento = DateTime.Parse(txtboxNacimiento.Text);
            int DiasPersonales = int.Parse(comboBoxVacaciones.Text);
            int VacacionesAsignadas =  int.Parse(comboBoxVacaciones.Text);

            
            txtboxNombre.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
