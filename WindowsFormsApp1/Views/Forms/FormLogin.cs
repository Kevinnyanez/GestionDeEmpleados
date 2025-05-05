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
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class FormLogin: Form
    {
        private List<Control> controlesOriginales = new List<Control>();
        
        public FormLogin()
        {
            InitializeComponent();

            foreach (Control control in panelRegistroTrabajador.Controls)
            {
                controlesOriginales.Add(control);
            }
        }

        public void RestaurarControles()
        {
            panelRegistroTrabajador.Controls.Clear(); // Limpia por si hay residuos

            foreach (Control control in controlesOriginales)
            {
                panelRegistroTrabajador.Controls.Add(control);
            }
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            // Tomamos los valores que ingresó la jefa
            admin.Contraseña = txtContraseña.Text;
            admin.NombreUsuario = txtUsuario.Text;

            // Verificamos que no estén vacíos
            if (admin.NombreUsuario == "" || admin.Contraseña == "")
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.");
                return;
            }

        int count = AdminController.IniciarSesion(admin);

            if (count > 0)
            {

                MessageBox.Show("Inicio de sesión exitoso.");
                FormPrincipal principal = new FormPrincipal(admin);
                principal.Show();
                this.Hide();
                principal.CargarEmpleados(); // Carga los empleados en el DataGridView
                principal.panelPrincipal.Controls.Remove(this); // Elimina el control actual
                admin.EsAdmin = true; // Cambia el estado de administrador


            }
            else
            {
              MessageBox.Show("Usuario o contraseña incorrectos.");
            }
                
               

        }
        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CargarUserControl(new Emplado());
        }


        private void CargarUserControl(UserControl nuevoControl)
        {
            
            panelRegistroTrabajador.Controls.Clear();
            nuevoControl.Dock = DockStyle.Fill;
            panelRegistroTrabajador.Controls.Add(nuevoControl);

        }
    }
}
