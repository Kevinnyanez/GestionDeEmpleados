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
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Models;



namespace WindowsFormsApp1
{
    
    public partial class Emplado : UserControl
    {
        private int contador = 0;
        public Emplado()
        {
            InitializeComponent();
            
            TextBox txtBoxContraseñaEmpleado = new TextBox();
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormLogin formularioLogin = (FormLogin)this.ParentForm;

            formularioLogin.panelRegistroTrabajador.Controls.Remove(this); 
            formularioLogin.RestaurarControles(); // Restaura los controles originales
        }

        private void btnIngresarEmpleado_Click(object sender, EventArgs e)
        {
            FormLogin formularioLogin = (FormLogin)this.ParentForm;

            (int count,string nombre)  = EmpleadoController.inicioSesionEmpleado(txtBoxContraseñaEmpleado.Text, txtBoxGmail.Text);

            if (count > 0)
             {
    
                Admin admin = new Admin();

               

                FormLogin formulario = (FormLogin)this.ParentForm;
                FormPrincipal principal = new FormPrincipal(admin);

                principal.Show();
                formulario.Hide(); // Oculta el formulario de inicio de sesión
                this.Hide();

                principal.CargarProductos(); // Carga los productos en el DataGridView
                principal.panelPrincipal.Controls.Remove(this); // Elimina el control actual
                principal.Text = "Gestión de productos - Bienvenido " + nombre; // Cambia el título del formulario
                admin.EsAdmin = false; // Cambia el estado de administrador
             }
            else
             {
                MessageBox.Show("Usuario o contraseña incorrectos.");
             }
                
         }

            


        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            
            contador += 1;


            if (contador % 2 == 0)
            {
                txtBoxContraseñaEmpleado.UseSystemPasswordChar = true;
            }
            else
            {
                txtBoxContraseñaEmpleado.UseSystemPasswordChar = false;
            }
            
        }
    }
}
