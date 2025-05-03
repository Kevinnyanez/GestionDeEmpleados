namespace WindowsFormsApp1
{
    partial class Emplado
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnIngresarEmpleado = new System.Windows.Forms.Button();
            this.lblGmail = new System.Windows.Forms.Label();
            this.txtBoxGmail = new System.Windows.Forms.TextBox();
            this.txtBoxContraseñaEmpleado = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.flowLayoutPanelBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblContraseña, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnIngresarEmpleado, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblGmail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxGmail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxContraseñaEmpleado, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(266, 136);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 233);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(134, 92);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(136, 29);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña";
            // 
            // btnIngresarEmpleado
            // 
            this.btnIngresarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarEmpleado.Location = new System.Drawing.Point(3, 187);
            this.btnIngresarEmpleado.Name = "btnIngresarEmpleado";
            this.btnIngresarEmpleado.Size = new System.Drawing.Size(109, 33);
            this.btnIngresarEmpleado.TabIndex = 2;
            this.btnIngresarEmpleado.Text = "Ingresar";
            this.btnIngresarEmpleado.UseVisualStyleBackColor = true;
            this.btnIngresarEmpleado.Click += new System.EventHandler(this.btnIngresarEmpleado_Click);
            // 
            // lblGmail
            // 
            this.lblGmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGmail.AutoSize = true;
            this.lblGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGmail.Location = new System.Drawing.Point(164, 0);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(76, 29);
            this.lblGmail.TabIndex = 0;
            this.lblGmail.Text = "Gmail";
            // 
            // txtBoxGmail
            // 
            this.txtBoxGmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxGmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtBoxGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGmail.Location = new System.Drawing.Point(3, 55);
            this.txtBoxGmail.Name = "txtBoxGmail";
            this.txtBoxGmail.Size = new System.Drawing.Size(399, 28);
            this.txtBoxGmail.TabIndex = 1;
            // 
            // txtBoxContraseñaEmpleado
            // 
            this.txtBoxContraseñaEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxContraseñaEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContraseñaEmpleado.Location = new System.Drawing.Point(3, 147);
            this.txtBoxContraseñaEmpleado.Name = "txtBoxContraseñaEmpleado";
            this.txtBoxContraseñaEmpleado.Size = new System.Drawing.Size(399, 27);
            this.txtBoxContraseñaEmpleado.TabIndex = 2;
            this.txtBoxContraseñaEmpleado.UseSystemPasswordChar = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(3, 3);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(121, 41);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // flowLayoutPanelBotones
            // 
            this.flowLayoutPanelBotones.Controls.Add(this.btnVolver);
            this.flowLayoutPanelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelBotones.Location = new System.Drawing.Point(0, 457);
            this.flowLayoutPanelBotones.Name = "flowLayoutPanelBotones";
            this.flowLayoutPanelBotones.Size = new System.Drawing.Size(985, 53);
            this.flowLayoutPanelBotones.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Emplado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanelBotones);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Emplado";
            this.Size = new System.Drawing.Size(985, 510);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblGmail;
        private System.Windows.Forms.TextBox txtBoxGmail;
        private System.Windows.Forms.TextBox txtBoxContraseñaEmpleado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBotones;
        private System.Windows.Forms.Button btnIngresarEmpleado;
        private System.Windows.Forms.Button button1;
    }
}
