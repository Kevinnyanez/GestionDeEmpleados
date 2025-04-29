namespace WindowsFormsApp1
{
    partial class RegistroDeEmpleados
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrarEmpleado = new System.Windows.Forms.Button();
            this.txtboxNacimiento = new System.Windows.Forms.TextBox();
            this.txtboxDni = new System.Windows.Forms.TextBox();
            this.txtboxGmail = new System.Windows.Forms.TextBox();
            this.txtboxCelular = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxDiasPersonales = new System.Windows.Forms.ComboBox();
            this.comboBoxLicenciaAsignada = new System.Windows.Forms.ComboBox();
            this.comboBoxVacaciones = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(364, 446);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 31);
            this.btnVolver.TabIndex = 35;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRegistrarEmpleado
            // 
            this.btnRegistrarEmpleado.Location = new System.Drawing.Point(484, 446);
            this.btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            this.btnRegistrarEmpleado.Size = new System.Drawing.Size(162, 31);
            this.btnRegistrarEmpleado.TabIndex = 34;
            this.btnRegistrarEmpleado.Text = "Registrar Empleado";
            this.btnRegistrarEmpleado.UseVisualStyleBackColor = true;
            // 
            // txtboxNacimiento
            // 
            this.txtboxNacimiento.Location = new System.Drawing.Point(442, 225);
            this.txtboxNacimiento.Name = "txtboxNacimiento";
            this.txtboxNacimiento.Size = new System.Drawing.Size(162, 22);
            this.txtboxNacimiento.TabIndex = 31;
            // 
            // txtboxDni
            // 
            this.txtboxDni.Location = new System.Drawing.Point(397, 190);
            this.txtboxDni.Name = "txtboxDni";
            this.txtboxDni.Size = new System.Drawing.Size(162, 22);
            this.txtboxDni.TabIndex = 30;
            // 
            // txtboxGmail
            // 
            this.txtboxGmail.Location = new System.Drawing.Point(409, 156);
            this.txtboxGmail.Name = "txtboxGmail";
            this.txtboxGmail.Size = new System.Drawing.Size(162, 22);
            this.txtboxGmail.TabIndex = 29;
            // 
            // txtboxCelular
            // 
            this.txtboxCelular.Location = new System.Drawing.Point(416, 119);
            this.txtboxCelular.Name = "txtboxCelular";
            this.txtboxCelular.Size = new System.Drawing.Size(162, 22);
            this.txtboxCelular.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Vacaciones Asignadas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Dias personales asignados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Gmail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Celular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre Completo";
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.Location = new System.Drawing.Point(484, 79);
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(162, 22);
            this.txtboxNombre.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(335, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 207);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxDiasPersonales);
            this.groupBox2.Controls.Add(this.comboBoxLicenciaAsignada);
            this.groupBox2.Controls.Add(this.comboBoxVacaciones);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(335, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 145);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Laborales";
            // 
            // comboBoxDiasPersonales
            // 
            this.comboBoxDiasPersonales.FormattingEnabled = true;
            this.comboBoxDiasPersonales.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxDiasPersonales.Location = new System.Drawing.Point(190, 21);
            this.comboBoxDiasPersonales.Name = "comboBoxDiasPersonales";
            this.comboBoxDiasPersonales.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDiasPersonales.TabIndex = 23;
            // 
            // comboBoxLicenciaAsignada
            // 
            this.comboBoxLicenciaAsignada.FormattingEnabled = true;
            this.comboBoxLicenciaAsignada.Items.AddRange(new object[] {
            "15",
            "20",
            "25",
            "30"});
            this.comboBoxLicenciaAsignada.Location = new System.Drawing.Point(149, 90);
            this.comboBoxLicenciaAsignada.Name = "comboBoxLicenciaAsignada";
            this.comboBoxLicenciaAsignada.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLicenciaAsignada.TabIndex = 22;
            // 
            // comboBoxVacaciones
            // 
            this.comboBoxVacaciones.FormattingEnabled = true;
            this.comboBoxVacaciones.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "30"});
            this.comboBoxVacaciones.Location = new System.Drawing.Point(176, 56);
            this.comboBoxVacaciones.Name = "comboBoxVacaciones";
            this.comboBoxVacaciones.Size = new System.Drawing.Size(121, 24);
            this.comboBoxVacaciones.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Licencias Asignadas";
            // 
            // RegistroDeEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRegistrarEmpleado);
            this.Controls.Add(this.txtboxNacimiento);
            this.Controls.Add(this.txtboxDni);
            this.Controls.Add(this.txtboxGmail);
            this.Controls.Add(this.txtboxCelular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxNombre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "RegistroDeEmpleados";
            this.Size = new System.Drawing.Size(1075, 516);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrarEmpleado;
        private System.Windows.Forms.TextBox txtboxNacimiento;
        private System.Windows.Forms.TextBox txtboxDni;
        private System.Windows.Forms.TextBox txtboxGmail;
        private System.Windows.Forms.TextBox txtboxCelular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxDiasPersonales;
        private System.Windows.Forms.ComboBox comboBoxLicenciaAsignada;
        private System.Windows.Forms.ComboBox comboBoxVacaciones;
        private System.Windows.Forms.Label label8;
    }
}
