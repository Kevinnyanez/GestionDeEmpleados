namespace WindowsFormsApp1
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSoyEmpleado = new System.Windows.Forms.Button();
            this.panelRegistroTrabajador = new System.Windows.Forms.Panel();
            this.tableLayoutPanelLoginAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMostrarContraseña = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelRegistroTrabajador.SuspendLayout();
            this.tableLayoutPanelLoginAdmin.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(3, 48);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(274, 27);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(3, 138);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(274, 27);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(92, 182);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(95, 35);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(371, 340);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(3, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 34);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSoyEmpleado
            // 
            this.btnSoyEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSoyEmpleado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoyEmpleado.Location = new System.Drawing.Point(103, 3);
            this.btnSoyEmpleado.Name = "btnSoyEmpleado";
            this.btnSoyEmpleado.Size = new System.Drawing.Size(169, 34);
            this.btnSoyEmpleado.TabIndex = 7;
            this.btnSoyEmpleado.Text = "Soy Empleado";
            this.btnSoyEmpleado.UseVisualStyleBackColor = true;
            this.btnSoyEmpleado.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelRegistroTrabajador
            // 
            this.panelRegistroTrabajador.Controls.Add(this.flowLayoutPanel1);
            this.panelRegistroTrabajador.Controls.Add(this.tableLayoutPanel1);
            this.panelRegistroTrabajador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistroTrabajador.Location = new System.Drawing.Point(0, 0);
            this.panelRegistroTrabajador.Name = "panelRegistroTrabajador";
            this.panelRegistroTrabajador.Size = new System.Drawing.Size(960, 517);
            this.panelRegistroTrabajador.TabIndex = 8;
            // 
            // tableLayoutPanelLoginAdmin
            // 
            this.tableLayoutPanelLoginAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanelLoginAdmin.ColumnCount = 2;
            this.tableLayoutPanelLoginAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelLoginAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelLoginAdmin.Controls.Add(this.btnMostrarContraseña, 1, 3);
            this.tableLayoutPanelLoginAdmin.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelLoginAdmin.Controls.Add(this.txtUsuario, 0, 1);
            this.tableLayoutPanelLoginAdmin.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanelLoginAdmin.Controls.Add(this.txtContraseña, 0, 3);
            this.tableLayoutPanelLoginAdmin.Controls.Add(this.btnIniciarSesion, 0, 4);
            this.tableLayoutPanelLoginAdmin.Location = new System.Drawing.Point(324, 158);
            this.tableLayoutPanelLoginAdmin.Name = "tableLayoutPanelLoginAdmin";
            this.tableLayoutPanelLoginAdmin.RowCount = 5;
            this.tableLayoutPanelLoginAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelLoginAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelLoginAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelLoginAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.5F));
            this.tableLayoutPanelLoginAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.5F));
            this.tableLayoutPanelLoginAdmin.Size = new System.Drawing.Size(312, 228);
            this.tableLayoutPanelLoginAdmin.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSalir);
            this.flowLayoutPanel1.Controls.Add(this.btnSoyEmpleado);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 468);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(960, 49);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnMostrarContraseña
            // 
            this.btnMostrarContraseña.FlatAppearance.BorderSize = 0;
            this.btnMostrarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarContraseña.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMostrarContraseña.Location = new System.Drawing.Point(283, 138);
            this.btnMostrarContraseña.Name = "btnMostrarContraseña";
            this.btnMostrarContraseña.Size = new System.Drawing.Size(26, 32);
            this.btnMostrarContraseña.TabIndex = 4;
            this.btnMostrarContraseña.Text = "👁️";
            this.btnMostrarContraseña.UseVisualStyleBackColor = true;
            this.btnMostrarContraseña.Click += new System.EventHandler(this.btnMostrarContraseña_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(78, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(804, 155);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "SISTEMA DE GESTIÓN DE EMPLEADOS Y PRODUCTOS";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelLoginAdmin, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(960, 517);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 517);
            this.Controls.Add(this.panelRegistroTrabajador);
            this.Controls.Add(this.lblMensaje);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.panelRegistroTrabajador.ResumeLayout(false);
            this.tableLayoutPanelLoginAdmin.ResumeLayout(false);
            this.tableLayoutPanelLoginAdmin.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSoyEmpleado;
        public System.Windows.Forms.Panel panelRegistroTrabajador;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLoginAdmin;
        private System.Windows.Forms.Button btnMostrarContraseña;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

