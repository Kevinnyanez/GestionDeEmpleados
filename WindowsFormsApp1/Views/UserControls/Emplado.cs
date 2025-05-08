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
                principal.lblNombreUsuario.Text = nombre; // Cambia el texto del label
                principal.Show();
                formulario.Hide(); // Oculta el formulario de inicio de sesión
                this.Hide();

                principal.CargarProductos(); // Carga los productos en el DataGridView
                principal.panelPrincipal.Controls.Remove(this); // Elimina el control actual
                principal.Text = "Gestión de productos - Bienvenido " + nombre; // Cambia el título del formulario
                admin.EsAdmin = false; // Cambia el estado de administrador
                MessageBox.Show("Inicio de sesión exitoso.");
                MessageBox.Show("Bienvenido " + nombre);
            }
            else
             {
                if(nombre.Contains("Por favor, complete todos los campos."))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                }
                if(nombre.Contains ("Error al conectar con la base de datos: "))
                {
                    MessageBox.Show(nombre);
                }
                if(nombre.Contains("No se encontró ningun empleado"))
                {
                    MessageBox.Show("No se encontró ningun empleado");
                }
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
