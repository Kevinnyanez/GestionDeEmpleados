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
using GestionDeEmpleadosProductosDatabase;


namespace WindowsFormsApp1
{
    public partial class FormPrincipal: Form 
    {
        // PROPIEDADES
        public Admin admin { get; set; }
        public string nombre { get; set; }
        // LISTA DE CONTROLOES DE LA PANTALLA PRINCIPAL
        private List<Control> controlesOriginales = new List<Control>();

        //LÓGICA DEL CONSTRUCTOR
        public FormPrincipal(Admin admin,string nombre)
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

        //LÓGICA PARA EL BUSCADOR
        private void txtboxBuscador_TextChanged(object sender, EventArgs e)
        {
            string nombreBuscado = txtboxBuscador.Text;
            if (admin.EsAdmin == true)
            {
                (dataGridViewEmpleados.DataSource as DataTable).DefaultView.RowFilter =
                $"NombreCompleto LIKE '%{txtboxBuscador.Text}%'";

            }
            else
            {
                string filtro = txtboxBuscador.Text;
                (dataGridViewEmpleados.DataSource as DataTable).DefaultView.RowFilter =
                    $"NombreProducto LIKE '%{filtro}%' OR NombreCategoria LIKE '%{filtro}%' OR NombreSubCategoria LIKE '%{filtro}%'";

            }
        }

        //LÓGICA DEL CARGAR FORMULARIO
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
            RegistroDeEmpleados registroDeEmpleados = new RegistroDeEmpleados();
            registroDeEmpleados.Dock = DockStyle.Fill;
            registroDeEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            CargarUserControl(registroDeEmpleados);
            btnVolverMenuPrincipal.Visible = true;
            btnEliminar.Enabled = false;
            


                //CONFIGURACIÓN DE LAS ETIQUETAS
                lblBienvenido.Dock = DockStyle.Fill;
                lblNombreUsuario.Dock = DockStyle.Fill;
                lblQueDeseaHacer.Dock = DockStyle.Fill;
                lblBienvenido.TextAlign = ContentAlignment.MiddleCenter;
                lblNombreUsuario.TextAlign = ContentAlignment.MiddleCenter;
                lblQueDeseaHacer.TextAlign = ContentAlignment.MiddleCenter;
                
                //INSTRUCCIONES
                lblBienvenido.Text = "Recomendaciones";
                lblNombreUsuario.Text = "1) Los campos de datos laborales pueden quedar sin seleccionar\n" +
                          "2) Los que no seleccione tomarán valores por default\n";
                          

                lblQueDeseaHacer.Text = "3) Los datos personales y de usuarios deben ingresarse sí o sí\n" +
                          "4) Al terminar los datos, verifique y seleccione el botón registrar.";
            }
            else
            {
                btnEditar.Enabled = false;
                CargarUserControl(new CrearProductos());
                btnVolverMenuPrincipal.Visible = true;
                btnEliminar.Enabled = false;

                //CONFIGURACIÓN DE LAS ETIQUETAS
                lblBienvenido.Dock = DockStyle.Fill;
                lblNombreUsuario.Dock = DockStyle.Fill;
                lblQueDeseaHacer.Dock = DockStyle.Fill;
                lblBienvenido.TextAlign = ContentAlignment.MiddleCenter;
                lblNombreUsuario.TextAlign = ContentAlignment.MiddleCenter;
                lblQueDeseaHacer.TextAlign = ContentAlignment.MiddleCenter;

                //INSTRUCCIONES
                lblBienvenido.Text = "Recomendaciones";
                lblNombreUsuario.Text = "1) Todos los datos son obligatorios excepto la descripción\n" +
                          "2) Si desea escribir una descripción le recomendamos que sea concisa\n";


                lblQueDeseaHacer.Text = "3) El precio permite tener desimales\n" +
                          "4) El stock permite numero entero";
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

                
                //CONFIGURACIÓN DE LAS ETIQUETAS
                lblBienvenido.Dock = DockStyle.Fill;
                lblNombreUsuario.Dock = DockStyle.Fill;
                lblQueDeseaHacer.Dock = DockStyle.Fill;
                lblBienvenido.TextAlign = ContentAlignment.MiddleCenter;
                lblNombreUsuario.TextAlign = ContentAlignment.MiddleCenter;
                lblQueDeseaHacer.TextAlign = ContentAlignment.MiddleCenter;

                //INSTRUCCIONES
                lblBienvenido.Text = "Recomendaciones";
                lblNombreUsuario.Text = "1) Trate de escribir el nombre del empleado de forma precisa para evitar errores\n" +
                          "2) Si se edita nombre de empleado, no podrá editar otro dato en un mismo edit. \n";


                lblQueDeseaHacer.Text = "3) Una vez cambiado el nombre actualice la casilla Empleado a modificar para cambiar otros datos\n" +
                          "4)Puede editar varios datos laborales a la vez, y tambien editar uno personal.";
            }
            else
            {
                CargarUserControl(new EditarProducto());
                btnVolverMenuPrincipal.Visible = true;
                btnRegistrarEmpleado.Enabled = false;
                btnEliminar.Enabled = false;

                //CONFIGURACIÓN DE LAS ETIQUETAS
                lblBienvenido.Dock = DockStyle.Fill;
                lblNombreUsuario.Dock = DockStyle.Fill;
                lblQueDeseaHacer.Dock = DockStyle.Fill;
                lblBienvenido.TextAlign = ContentAlignment.MiddleCenter;
                lblNombreUsuario.TextAlign = ContentAlignment.MiddleCenter;
                lblQueDeseaHacer.TextAlign = ContentAlignment.MiddleCenter;

                //INSTRUCCIONES
                lblBienvenido.Text = "Recomendaciones";
                lblNombreUsuario.Text = "1) No es necesario cambiar todos los datos de un producto (deje en blanco lo que no vaya a cambiar).\n" +
                          "2) Si quiere cambiar el nombre y editar datos del producto, haz uno a la vez. \n";


                lblQueDeseaHacer.Text = "3) Puede cambiar varios datos a la vez (Exceptuando el caso de cambio de nombre). \n" +
                          "4)Verifique datos antes de hacer cambios para evitar cambios inecesarios.";
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

                //CONFIGURACIÓN DE LAS ETIQUETAS
                lblBienvenido.Dock = DockStyle.Fill;
                lblNombreUsuario.Dock = DockStyle.Fill;
                lblQueDeseaHacer.Dock = DockStyle.Fill;
                lblBienvenido.TextAlign = ContentAlignment.MiddleCenter;
                lblNombreUsuario.TextAlign = ContentAlignment.MiddleCenter;
                lblQueDeseaHacer.TextAlign = ContentAlignment.MiddleCenter;

                //INSTRUCCIONES
                lblBienvenido.Text = "Recomendaciones";
                lblNombreUsuario.Text = "1) Sea preciso con el nombre del empleado para evitar errores de productos con nombre similares.\n" +
                          "2) Verifique el dato introducido antes de seleccionar el botón de eliminar. \n";


                lblQueDeseaHacer.Text = "3) PRECACUCIÓN: Una vez eliminado no se podrá volver hacia atras. \n";
            }
            else
            {
                CargarUserControl(new EliminarProducto());
                btnVolverMenuPrincipal.Visible = true;
                btnRegistrarEmpleado.Enabled = false;
                btnEditar.Enabled = false;

                //CONFIGURACIÓN DE LAS ETIQUETAS
                lblBienvenido.Dock = DockStyle.Fill;
                lblNombreUsuario.Dock = DockStyle.Fill;
                lblQueDeseaHacer.Dock = DockStyle.Fill;
                lblBienvenido.TextAlign = ContentAlignment.MiddleCenter;
                lblNombreUsuario.TextAlign = ContentAlignment.MiddleCenter;
                lblQueDeseaHacer.TextAlign = ContentAlignment.MiddleCenter;

                //INSTRUCCIONES
                lblBienvenido.Text = "Recomendaciones";
                lblNombreUsuario.Text = "1) Sea preciso con el nombre del producto para evitar errores de productos con nombre similares.\n" +
                          "2) Verifique el dato introducido antes de seleccionar el botón de eliminar. \n";


                lblQueDeseaHacer.Text = "3) PRECACUCIÓN: Una vez eliminado no se podrá volver hacia atras. \n";
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

                // Mostrar etiquetas
                lblBienvenido.Text = "Benvenido/a";
                lblNombreUsuario.Text = admin.NombreUsuario;
                lblQueDeseaHacer.Text = "¿Que desea hacer?";
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

                // Mostrar etiquetas
                lblBienvenido.Text = "Benvenido/a";
                lblNombreUsuario.Text = nombre;
                lblQueDeseaHacer.Text = "¿Que desea hacer?";
            }

        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
