namespace WindowsFormsApp1
{
    partial class CrearProductos
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
            this.lblDatosPersonales = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxNombreProducto = new System.Windows.Forms.TextBox();
            this.txtboxDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.comboBoxSubCategorias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxPrecio = new System.Windows.Forms.TextBox();
            this.txtboxStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCrearProducto = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblDatosPersonales, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtboxNombreProducto, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtboxDescripcion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxCategorias, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSubCategorias, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtboxPrecio, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtboxStock, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCrearProducto, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(970, 381);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // lblDatosPersonales
            // 
            this.lblDatosPersonales.AutoSize = true;
            this.lblDatosPersonales.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosPersonales.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDatosPersonales.Location = new System.Drawing.Point(3, 0);
            this.lblDatosPersonales.Name = "lblDatosPersonales";
            this.lblDatosPersonales.Size = new System.Drawing.Size(324, 38);
            this.lblDatosPersonales.TabIndex = 37;
            this.lblDatosPersonales.Text = "DATOS DEL PRODUCTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Descripción (Opcional)";
            // 
            // txtboxNombreProducto
            // 
            this.txtboxNombreProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtboxNombreProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxNombreProducto.Location = new System.Drawing.Point(333, 67);
            this.txtboxNombreProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxNombreProducto.Name = "txtboxNombreProducto";
            this.txtboxNombreProducto.Size = new System.Drawing.Size(219, 39);
            this.txtboxNombreProducto.TabIndex = 20;
            // 
            // txtboxDescripcion
            // 
            this.txtboxDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxDescripcion.Location = new System.Drawing.Point(333, 130);
            this.txtboxDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxDescripcion.Name = "txtboxDescripcion";
            this.txtboxDescripcion.Size = new System.Drawing.Size(219, 39);
            this.txtboxDescripcion.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(558, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 32);
            this.label6.TabIndex = 26;
            this.label6.Text = "Subcategoria";
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(747, 67);
            this.comboBoxCategorias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(220, 40);
            this.comboBoxCategorias.TabIndex = 22;
            // 
            // comboBoxSubCategorias
            // 
            this.comboBoxSubCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSubCategorias.FormattingEnabled = true;
            this.comboBoxSubCategorias.Location = new System.Drawing.Point(747, 130);
            this.comboBoxSubCategorias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSubCategorias.Name = "comboBoxSubCategorias";
            this.comboBoxSubCategorias.Size = new System.Drawing.Size(220, 40);
            this.comboBoxSubCategorias.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "Precio";
            // 
            // txtboxPrecio
            // 
            this.txtboxPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxPrecio.Location = new System.Drawing.Point(333, 193);
            this.txtboxPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxPrecio.Name = "txtboxPrecio";
            this.txtboxPrecio.Size = new System.Drawing.Size(219, 39);
            this.txtboxPrecio.TabIndex = 30;
            // 
            // txtboxStock
            // 
            this.txtboxStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxStock.Location = new System.Drawing.Point(333, 256);
            this.txtboxStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxStock.Name = "txtboxStock";
            this.txtboxStock.Size = new System.Drawing.Size(219, 39);
            this.txtboxStock.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "Stock";
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearProducto.Location = new System.Drawing.Point(3, 319);
            this.btnCrearProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(196, 44);
            this.btnCrearProducto.TabIndex = 34;
            this.btnCrearProducto.Text = "Crear Producto ";
            this.btnCrearProducto.UseVisualStyleBackColor = true;
            this.btnCrearProducto.Click += new System.EventHandler(this.btnCrearProducto_Click);
            // 
            // CrearProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CrearProductos";
            this.Size = new System.Drawing.Size(970, 381);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDatosPersonales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxNombreProducto;
        private System.Windows.Forms.TextBox txtboxDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.ComboBox comboBoxSubCategorias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxPrecio;
        private System.Windows.Forms.TextBox txtboxStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCrearProducto;
    }
}
