using System.Drawing;

namespace WindowsFormsApp1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBuscarPorNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegistrarEmpleado = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.flowLayoutPanelSalir = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVolverMenuPrincipal = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanelSalir.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.RowHeadersWidth = 51;
            this.dataGridViewEmpleados.RowTemplate.Height = 24;
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(1305, 305);
            this.dataGridViewEmpleados.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(3, 44);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(194, 35);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.LightGray;
            this.panelPrincipal.Controls.Add(this.flowLayoutPanel2);
            this.panelPrincipal.Controls.Add(this.flowLayoutPanel1);
            this.panelPrincipal.Controls.Add(this.flowLayoutPanelSalir);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(3, 3);
            this.panelPrincipal.Name = "panelPrincipal";
            this.tableLayoutPanel1.SetRowSpan(this.panelPrincipal, 2);
            this.panelPrincipal.Size = new System.Drawing.Size(212, 616);
            this.panelPrincipal.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblBuscarPorNombre);
            this.flowLayoutPanel2.Controls.Add(this.textBox1);
            this.flowLayoutPanel2.Controls.Add(this.btnBuscar);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 185);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(182, 100);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // lblBuscarPorNombre
            // 
            this.lblBuscarPorNombre.AutoSize = true;
            this.lblBuscarPorNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorNombre.Location = new System.Drawing.Point(3, 0);
            this.lblBuscarPorNombre.Name = "lblBuscarPorNombre";
            this.lblBuscarPorNombre.Size = new System.Drawing.Size(125, 17);
            this.lblBuscarPorNombre.TabIndex = 7;
            this.lblBuscarPorNombre.Text = "Buscar por nombre";
            this.lblBuscarPorNombre.Click += new System.EventHandler(this.lblBuscarPorNombre_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(3, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(168, 35);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnRegistrarEmpleado);
            this.flowLayoutPanel1.Controls.Add(this.btnEditar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 132);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // btnRegistrarEmpleado
            // 
            this.btnRegistrarEmpleado.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEmpleado.Location = new System.Drawing.Point(3, 3);
            this.btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            this.btnRegistrarEmpleado.Size = new System.Drawing.Size(191, 35);
            this.btnRegistrarEmpleado.TabIndex = 3;
            this.btnRegistrarEmpleado.Text = "Registrar";
            this.btnRegistrarEmpleado.UseVisualStyleBackColor = true;
            this.btnRegistrarEmpleado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(3, 44);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(191, 35);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(3, 85);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(191, 35);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // flowLayoutPanelSalir
            // 
            this.flowLayoutPanelSalir.Controls.Add(this.btnVolverMenuPrincipal);
            this.flowLayoutPanelSalir.Controls.Add(this.btnSalir);
            this.flowLayoutPanelSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelSalir.Location = new System.Drawing.Point(0, 516);
            this.flowLayoutPanelSalir.Name = "flowLayoutPanelSalir";
            this.flowLayoutPanelSalir.Size = new System.Drawing.Size(212, 100);
            this.flowLayoutPanelSalir.TabIndex = 5;
            // 
            // btnVolverMenuPrincipal
            // 
            this.btnVolverMenuPrincipal.Location = new System.Drawing.Point(3, 3);
            this.btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            this.btnVolverMenuPrincipal.Size = new System.Drawing.Size(191, 35);
            this.btnVolverMenuPrincipal.TabIndex = 10;
            this.btnVolverMenuPrincipal.Text = "Volver";
            this.btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnVolverMenuPrincipal.Click += new System.EventHandler(this.btnVolverMenuPrincipal_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(221, 314);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1305, 305);
            this.panelContenido.TabIndex = 5;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridViewEmpleados);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(221, 3);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(1305, 305);
            this.panelDataGridView.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.71429F));
            this.tableLayoutPanel1.Controls.Add(this.panelPrincipal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelContenido, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelDataGridView, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1529, 622);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 622);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormPrincipal";
            this.Text = "Gestión Empleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanelSalir.ResumeLayout(false);
            this.panelDataGridView.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridViewEmpleados;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Panel panelPrincipal;
        public System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSalir;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnRegistrarEmpleado;
        private System.Windows.Forms.Label lblBuscarPorNombre;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnVolverMenuPrincipal;
        public System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}