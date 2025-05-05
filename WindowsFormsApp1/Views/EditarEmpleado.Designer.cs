namespace WindowsFormsApp1
{
    partial class EditarEmpleado
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
            this.lblEleccionEmpleado = new System.Windows.Forms.Label();
            this.textBoxEmpleadoModificar = new System.Windows.Forms.TextBox();
            this.lblColumnaModificar = new System.Windows.Forms.Label();
            this.lblNuevoValor = new System.Windows.Forms.Label();
            this.textBoxNuevoValor = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.comboBoxDatoPersonalModificar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDiasPersonalesAsignadosCambio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxVacacionesAsignadasCambio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDiasPersonalesRestantesCambio = new System.Windows.Forms.ComboBox();
            this.comboBoxVacacionesRestantesCambio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxLicenciasAsignadasCambio = new System.Windows.Forms.ComboBox();
            this.comboBoxLicenciasRestantesCambio = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEleccionEmpleado
            // 
            this.lblEleccionEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblEleccionEmpleado.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblEleccionEmpleado, 2);
            this.lblEleccionEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEleccionEmpleado.Location = new System.Drawing.Point(346, 14);
            this.lblEleccionEmpleado.Name = "lblEleccionEmpleado";
            this.lblEleccionEmpleado.Size = new System.Drawing.Size(204, 28);
            this.lblEleccionEmpleado.TabIndex = 0;
            this.lblEleccionEmpleado.Text = "Empleado a Modificar";
            // 
            // textBoxEmpleadoModificar
            // 
            this.textBoxEmpleadoModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxEmpleadoModificar, 2);
            this.textBoxEmpleadoModificar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmpleadoModificar.Location = new System.Drawing.Point(346, 45);
            this.textBoxEmpleadoModificar.Name = "textBoxEmpleadoModificar";
            this.textBoxEmpleadoModificar.Size = new System.Drawing.Size(205, 30);
            this.textBoxEmpleadoModificar.TabIndex = 1;
            // 
            // lblColumnaModificar
            // 
            this.lblColumnaModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblColumnaModificar.AutoSize = true;
            this.lblColumnaModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnaModificar.Location = new System.Drawing.Point(105, 98);
            this.lblColumnaModificar.Name = "lblColumnaModificar";
            this.lblColumnaModificar.Size = new System.Drawing.Size(238, 28);
            this.lblColumnaModificar.TabIndex = 2;
            this.lblColumnaModificar.Text = "Dato personal a modificar";
            // 
            // lblNuevoValor
            // 
            this.lblNuevoValor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNuevoValor.AutoSize = true;
            this.lblNuevoValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoValor.Location = new System.Drawing.Point(612, 98);
            this.lblNuevoValor.Name = "lblNuevoValor";
            this.lblNuevoValor.Size = new System.Drawing.Size(120, 28);
            this.lblNuevoValor.TabIndex = 4;
            this.lblNuevoValor.Text = "Nuevo Valor";
            // 
            // textBoxNuevoValor
            // 
            this.textBoxNuevoValor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNuevoValor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNuevoValor.Location = new System.Drawing.Point(582, 129);
            this.textBoxNuevoValor.Name = "textBoxNuevoValor";
            this.textBoxNuevoValor.Size = new System.Drawing.Size(181, 30);
            this.textBoxNuevoValor.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxEmpleadoModificar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEditar, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblNuevoValor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblColumnaModificar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNuevoValor, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxDatoPersonalModificar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEleccionEmpleado, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxDiasPersonalesAsignadosCambio, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxVacacionesAsignadasCambio, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxDiasPersonalesRestantesCambio, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxVacacionesRestantesCambio, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxLicenciasAsignadasCambio, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxLicenciasRestantesCambio, 1, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(170, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(897, 463);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnEditar, 2);
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(3, 423);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(891, 37);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // comboBoxDatoPersonalModificar
            // 
            this.comboBoxDatoPersonalModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxDatoPersonalModificar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDatoPersonalModificar.FormattingEnabled = true;
            this.comboBoxDatoPersonalModificar.Items.AddRange(new object[] {
            "Nombre Completo",
            "Numero Celular",
            "Gmail",
            "DNI",
            "Cumpleaños"});
            this.comboBoxDatoPersonalModificar.Location = new System.Drawing.Point(126, 129);
            this.comboBoxDatoPersonalModificar.Name = "comboBoxDatoPersonalModificar";
            this.comboBoxDatoPersonalModificar.Size = new System.Drawing.Size(196, 31);
            this.comboBoxDatoPersonalModificar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Días Personales Asignados";
            // 
            // comboBoxDiasPersonalesAsignadosCambio
            // 
            this.comboBoxDiasPersonalesAsignadosCambio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxDiasPersonalesAsignadosCambio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDiasPersonalesAsignadosCambio.FormattingEnabled = true;
            this.comboBoxDiasPersonalesAsignadosCambio.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBoxDiasPersonalesAsignadosCambio.Location = new System.Drawing.Point(126, 213);
            this.comboBoxDiasPersonalesAsignadosCambio.Name = "comboBoxDiasPersonalesAsignadosCambio";
            this.comboBoxDiasPersonalesAsignadosCambio.Size = new System.Drawing.Size(196, 31);
            this.comboBoxDiasPersonalesAsignadosCambio.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(556, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Días Personales Restantes";
            // 
            // comboBoxVacacionesAsignadasCambio
            // 
            this.comboBoxVacacionesAsignadasCambio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxVacacionesAsignadasCambio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVacacionesAsignadasCambio.FormattingEnabled = true;
            this.comboBoxVacacionesAsignadasCambio.Items.AddRange(new object[] {
            "0",
            "10",
            "15",
            "20",
            "30"});
            this.comboBoxVacacionesAsignadasCambio.Location = new System.Drawing.Point(126, 297);
            this.comboBoxVacacionesAsignadasCambio.Name = "comboBoxVacacionesAsignadasCambio";
            this.comboBoxVacacionesAsignadasCambio.Size = new System.Drawing.Size(196, 31);
            this.comboBoxVacacionesAsignadasCambio.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Vacaciones Asignadas";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Vacaciones Restantes";
            // 
            // comboBoxDiasPersonalesRestantesCambio
            // 
            this.comboBoxDiasPersonalesRestantesCambio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxDiasPersonalesRestantesCambio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDiasPersonalesRestantesCambio.FormattingEnabled = true;
            this.comboBoxDiasPersonalesRestantesCambio.Items.AddRange(new object[] {
            "0",
            "3",
            "2",
            "1"});
            this.comboBoxDiasPersonalesRestantesCambio.Location = new System.Drawing.Point(574, 213);
            this.comboBoxDiasPersonalesRestantesCambio.Name = "comboBoxDiasPersonalesRestantesCambio";
            this.comboBoxDiasPersonalesRestantesCambio.Size = new System.Drawing.Size(196, 31);
            this.comboBoxDiasPersonalesRestantesCambio.TabIndex = 15;
            // 
            // comboBoxVacacionesRestantesCambio
            // 
            this.comboBoxVacacionesRestantesCambio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxVacacionesRestantesCambio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVacacionesRestantesCambio.FormattingEnabled = true;
            this.comboBoxVacacionesRestantesCambio.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.comboBoxVacacionesRestantesCambio.Location = new System.Drawing.Point(574, 297);
            this.comboBoxVacacionesRestantesCambio.Name = "comboBoxVacacionesRestantesCambio";
            this.comboBoxVacacionesRestantesCambio.Size = new System.Drawing.Size(196, 31);
            this.comboBoxVacacionesRestantesCambio.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Licencias Asignadas";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(585, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Licencias Restantes";
            // 
            // comboBoxLicenciasAsignadasCambio
            // 
            this.comboBoxLicenciasAsignadasCambio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxLicenciasAsignadasCambio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLicenciasAsignadasCambio.FormattingEnabled = true;
            this.comboBoxLicenciasAsignadasCambio.Items.AddRange(new object[] {
            "0",
            "15",
            "20",
            "25",
            "30"});
            this.comboBoxLicenciasAsignadasCambio.Location = new System.Drawing.Point(126, 381);
            this.comboBoxLicenciasAsignadasCambio.Name = "comboBoxLicenciasAsignadasCambio";
            this.comboBoxLicenciasAsignadasCambio.Size = new System.Drawing.Size(196, 31);
            this.comboBoxLicenciasAsignadasCambio.TabIndex = 21;
            // 
            // comboBoxLicenciasRestantesCambio
            // 
            this.comboBoxLicenciasRestantesCambio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxLicenciasRestantesCambio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLicenciasRestantesCambio.FormattingEnabled = true;
            this.comboBoxLicenciasRestantesCambio.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.comboBoxLicenciasRestantesCambio.Location = new System.Drawing.Point(574, 381);
            this.comboBoxLicenciasRestantesCambio.Name = "comboBoxLicenciasRestantesCambio";
            this.comboBoxLicenciasRestantesCambio.Size = new System.Drawing.Size(196, 31);
            this.comboBoxLicenciasRestantesCambio.TabIndex = 22;
            // 
            // EditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditarEmpleado";
            this.Size = new System.Drawing.Size(1189, 564);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEleccionEmpleado;
        private System.Windows.Forms.TextBox textBoxEmpleadoModificar;
        private System.Windows.Forms.Label lblColumnaModificar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxNuevoValor;
        private System.Windows.Forms.Label lblNuevoValor;
        private System.Windows.Forms.ComboBox comboBoxDatoPersonalModificar;
        private System.Windows.Forms.ComboBox comboBoxDiasPersonalesRestantesCambio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDiasPersonalesAsignadosCambio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxVacacionesAsignadasCambio;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxVacacionesRestantesCambio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxLicenciasAsignadasCambio;
        private System.Windows.Forms.ComboBox comboBoxLicenciasRestantesCambio;
    }
}
