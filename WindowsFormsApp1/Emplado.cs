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
    public partial class Emplado : UserControl
    {
        public Emplado()
        {
            InitializeComponent();
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

            string Contraseña = txtBoxContraseñaEmpleado.Text; // Contraseña por defecto
            string Gmail = txtBoxGmail.Text.ToLower();

            if (string.IsNullOrEmpty(Contraseña) || string.IsNullOrEmpty(Gmail))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            

            FormPrincipal formularioPrincipal = new FormPrincipal();
            formularioPrincipal.Show();
            formularioLogin.Hide();

        }
    }
}
