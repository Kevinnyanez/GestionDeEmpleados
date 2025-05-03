namespace WindowsFormsApp1
{
    partial class EliminarEmpleado
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
            this.lblQueEmpleadoEliminar = new System.Windows.Forms.Label();
            this.textBoxEmpleadoAEliminar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminaTrabajador = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQueEmpleadoEliminar
            // 
            this.lblQueEmpleadoEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblQueEmpleadoEliminar.AutoSize = true;
            this.lblQueEmpleadoEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueEmpleadoEliminar.Location = new System.Drawing.Point(257, 121);
            this.lblQueEmpleadoEliminar.Name = "lblQueEmpleadoEliminar";
            this.lblQueEmpleadoEliminar.Size = new System.Drawing.Size(289, 28);
            this.lblQueEmpleadoEliminar.TabIndex = 0;
            this.lblQueEmpleadoEliminar.Text = "¿Que empleado desea eliminar?";
            // 
            // textBoxEmpleadoAEliminar
            // 
            this.textBoxEmpleadoAEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxEmpleadoAEliminar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmpleadoAEliminar.Location = new System.Drawing.Point(296, 152);
            this.textBoxEmpleadoAEliminar.Name = "textBoxEmpleadoAEliminar";
            this.textBoxEmpleadoAEliminar.Size = new System.Drawing.Size(210, 30);
            this.textBoxEmpleadoAEliminar.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblQueEmpleadoEliminar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxEmpleadoAEliminar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminaTrabajador, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(260, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(803, 448);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnEliminaTrabajador
            // 
            this.btnEliminaTrabajador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminaTrabajador.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaTrabajador.Location = new System.Drawing.Point(357, 301);
            this.btnEliminaTrabajador.Name = "btnEliminaTrabajador";
            this.btnEliminaTrabajador.Size = new System.Drawing.Size(88, 30);
            this.btnEliminaTrabajador.TabIndex = 2;
            this.btnEliminaTrabajador.Text = "Eliminar";
            this.btnEliminaTrabajador.UseVisualStyleBackColor = true;
            this.btnEliminaTrabajador.Click += new System.EventHandler(this.btnEliminaTrabajador_Click);
            // 
            // EliminarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EliminarEmpleado";
            this.Size = new System.Drawing.Size(1395, 638);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQueEmpleadoEliminar;
        private System.Windows.Forms.TextBox textBoxEmpleadoAEliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEliminaTrabajador;
    }
}
