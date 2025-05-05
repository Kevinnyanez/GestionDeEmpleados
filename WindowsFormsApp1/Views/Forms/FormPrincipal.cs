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
using WindowsFormsApp1.Models;


namespace WindowsFormsApp1
{
    public partial class FormPrincipal: Form 
    {
        public Admin admin { get; set; }
        // LISTA DE CONTROLOES DE LA PANTALLA PRINCIPAL
        private List<Control> controlesOriginales = new List<Control>();
        public FormPrincipal(Admin admin)
        {
            InitializeComponent();
           this.admin = admin;
           btnVolverMenuPrincipal.Visible = false;
           panelDataGridView.Visible = true; // Muestra el panel del DataGridView
        }

        //LÓGICA PARA RESTAURAR LOS BOTONES
        public void RestaurarControles()
        {
            panelPrincipal.Controls.Clear(); // Limpia por si hay residuos

            foreach (Control control in controlesOriginales)
            {
                panelPrincipal.Controls.Add(control);
            }
        }

        //LÓGICA DEL DATAGRIDVIEW
        private void Form2_Load(object sender, EventArgs e)
        {

            // Inicializamos el panel de contenido
            panelContenido.Visible = false; // Oculta el panel de contenido al inicio

            // Guardamos los controles originales del panel principal
            foreach (Control control in panelPrincipal.Controls)
            {
                controlesOriginales.Add(control);
            }
        }

        //LÓGICA PARA CARGAR LOS EMPLEADOS EN EL DATAGRIDVIEW
        public void CargarEmpleados()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Empleados";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    System.Data.DataTable table = new System.Data.DataTable();
                    adapter.Fill(table);

                    dataGridViewEmpleados.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
            
        }

        //LÓGICA PARA CARGAR LOS PRODUCTOS EN EL DATAGRIDVIEW
        public void CargarProductos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM VistaProductos";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    System.Data.DataTable table = new System.Data.DataTable();
                    adapter.Fill(table);
                    dataGridViewEmpleados.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        //BOTÓN DE SALIDA DE LA APLIACIÓN
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //LÓGICA DEL BOTÓN REGISTRAR EMPLEADO Y CREAR PRODUCTO
        private void button1_Click(object sender, EventArgs e)
        {
            if(admin.EsAdmin == true) { 
            btnEditar.Enabled = false;
            CargarUserControl(new RegistroDeEmpleados());
            btnVolverMenuPrincipal.Visible = true;
            btnEliminar.Enabled = false;
            }
            else
            {
                btnEditar.Enabled = false;
                CargarUserControl(new CrearProductos());
                btnVolverMenuPrincipal.Visible = true;
                btnEliminar.Enabled = false;
            }

        }

        //LÓGICA DEL BOTÓN EDITAR EMPLEADO Y EDITAR PRODUCTO
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (admin.EsAdmin == true)
            {
                CargarUserControl(new EditarEmpleado());
                btnVolverMenuPrincipal.Visible = true;
                btnRegistrarEmpleado.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                CargarUserControl(new EditarProducto());
                btnVolverMenuPrincipal.Visible = true;
                btnRegistrarEmpleado.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        //LÓGICA DEL BOTÓN ELIMINAR EMPLEADO Y ELIMINAR PRODUCTO
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (admin.EsAdmin == true)
            {
                CargarUserControl(new EliminarEmpleado());
                btnVolverMenuPrincipal.Visible = true;
                btnRegistrarEmpleado.Enabled = false;
                btnEditar.Enabled = false;
            }
            else
            {
                CargarUserControl(new EliminarProducto());
                btnVolverMenuPrincipal.Visible = true;
                btnRegistrarEmpleado.Enabled = false;
                btnEditar.Enabled = false;
            }
        }

        //LOGICA PARA CONTROL USER
        private void CargarUserControl(UserControl nuevoControl)
        {

           
            panelContenido.Visible = true;
            nuevoControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
         

            // Agrega el UserControl al Panel
            panelContenido.Controls.Add(nuevoControl);
        }


        private void lblBuscarPorNombre_Click(object sender, EventArgs e)
        {

        }

       private void EliminarUsersControls()
        {
            // Elimina todos los controles del panel de contenido
            foreach (Control control in panelContenido.Controls)
            {
                panelContenido.Controls.Remove(control);
            }
        }

        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            if (admin.EsAdmin == true) { 
            // Método para eliminar los controles del panel de contenido 
            EliminarUsersControls();
            //Hacer no visible al panelContenido
            panelContenido.Visible = false;
            //Hago Invisible el botón volver
            btnVolverMenuPrincipal.Visible = false;
            //Volvermos a cargar el DataGridView
            CargarEmpleados();
            // Volvemos a activar los botones de edición
            btnEditar.Enabled = true;
            btnRegistrarEmpleado.Enabled = true;
            btnEliminar.Enabled = true;
            }
            else {
                // Método para eliminar los controles del panel de contenido 
                EliminarUsersControls();
                //Hacer no visible al panelContenido
                panelContenido.Visible = false;
                //Hago Invisible el botón volver
                btnVolverMenuPrincipal.Visible = false;
                //Volvermos a cargar el DataGridView
                CargarProductos();
                // Volvemos a activar los botones de edición
                btnEditar.Enabled = true;
                btnRegistrarEmpleado.Enabled = true;
                btnEliminar.Enabled = true;
            }

        }


  

    }
}
