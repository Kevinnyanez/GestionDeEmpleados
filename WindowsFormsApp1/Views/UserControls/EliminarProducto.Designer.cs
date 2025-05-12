namespace WindowsFormsApp1
{
    partial class EliminarProducto
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
            this.lblProductoAEliminar = new System.Windows.Forms.Label();
            this.btnBotonEliminarProducto = new System.Windows.Forms.Button();
            this.txtBoxProductoEliminar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblProductoAEliminar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBotonEliminarProducto, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxProductoEliminar, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.78398F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.28174F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8829F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8829F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.16848F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1132, 634);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblProductoAEliminar
            // 
            this.lblProductoAEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblProductoAEliminar.AutoSize = true;
            this.lblProductoAEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoAEliminar.Location = new System.Drawing.Point(424, 250);
            this.lblProductoAEliminar.Name = "lblProductoAEliminar";
            this.lblProductoAEliminar.Size = new System.Drawing.Size(283, 28);
            this.lblProductoAEliminar.TabIndex = 0;
            this.lblProductoAEliminar.Text = "¿Que producto desea eliminar?";
            // 
            // btnBotonEliminarProducto
            // 
            this.btnBotonEliminarProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBotonEliminarProducto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotonEliminarProducto.Location = new System.Drawing.Point(522, 356);
            this.btnBotonEliminarProducto.Name = "btnBotonEliminarProducto";
            this.btnBotonEliminarProducto.Size = new System.Drawing.Size(88, 30);
            this.btnBotonEliminarProducto.TabIndex = 2;
            this.btnBotonEliminarProducto.Text = "Eliminar";
            this.btnBotonEliminarProducto.UseVisualStyleBackColor = true;
            this.btnBotonEliminarProducto.Click += new System.EventHandler(this.btnBotonEliminarProducto_Click);
            // 
            // txtBoxProductoEliminar
            // 
            this.txtBoxProductoEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxProductoEliminar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProductoEliminar.Location = new System.Drawing.Point(461, 281);
            this.txtBoxProductoEliminar.Name = "txtBoxProductoEliminar";
            this.txtBoxProductoEliminar.Size = new System.Drawing.Size(210, 30);
            this.txtBoxProductoEliminar.TabIndex = 1;
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EliminarProducto";
            this.Size = new System.Drawing.Size(1132, 634);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblProductoAEliminar;
        private System.Windows.Forms.Button btnBotonEliminarProducto;
        private System.Windows.Forms.TextBox txtBoxProductoEliminar;
    }
}
