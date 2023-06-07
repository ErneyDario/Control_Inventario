namespace Control_Inventario
{
    partial class FormInventario
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
            components = new System.ComponentModel.Container();
            btnIngresarInventario = new Button();
            iconPictureBoxSalir = new FontAwesome.Sharp.IconPictureBox();
            panel1 = new Panel();
            txtValorVenta = new TextBox();
            label10 = new Label();
            txtdescripcion = new TextBox();
            txtvalor = new TextBox();
            label8 = new Label();
            txtExistencias = new TextBox();
            txtArticulo = new TextBox();
            txtcodigo = new TextBox();
            label9 = new Label();
            label19 = new Label();
            label17 = new Label();
            label16 = new Label();
            btnLimpiar = new Button();
            btnAgregarEntrada = new Button();
            panel2 = new Panel();
            txtNombreProveedor = new TextBox();
            txtIdProveedor = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtFactura = new TextBox();
            btnEditarInventario = new Button();
            btnEliminarInventario = new Button();
            btnRegistrar = new Button();
            btnLimpirForm = new Button();
            btnGestionArticulos = new Button();
            errorProvider1 = new ErrorProvider(components);
            dtgvEntradas = new DataGridView();
            panel4 = new Panel();
            btnGuardarCambios = new Button();
            btnEliminarRegistro = new Button();
            label3 = new Label();
            iBtnBuscar = new FontAwesome.Sharp.IconButton();
            cmbTipoBusqueda = new ComboBox();
            txtBuscar = new TextBox();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)iconPictureBoxSalir).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvEntradas).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnIngresarInventario
            // 
            btnIngresarInventario.BackColor = Color.FromArgb(64, 64, 64);
            btnIngresarInventario.Cursor = Cursors.Hand;
            btnIngresarInventario.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresarInventario.ForeColor = Color.White;
            btnIngresarInventario.Location = new Point(533, 62);
            btnIngresarInventario.Name = "btnIngresarInventario";
            btnIngresarInventario.RightToLeft = RightToLeft.No;
            btnIngresarInventario.Size = new Size(100, 40);
            btnIngresarInventario.TabIndex = 21;
            btnIngresarInventario.Text = "Ingresar Inventario";
            btnIngresarInventario.UseVisualStyleBackColor = false;
            btnIngresarInventario.Click += btnIngresarInventario_Click;
            // 
            // iconPictureBoxSalir
            // 
            iconPictureBoxSalir.BackColor = Color.LavenderBlush;
            iconPictureBoxSalir.BackgroundImageLayout = ImageLayout.Center;
            iconPictureBoxSalir.Cursor = Cursors.Hand;
            iconPictureBoxSalir.ForeColor = Color.FromArgb(64, 64, 64);
            iconPictureBoxSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            iconPictureBoxSalir.IconColor = Color.FromArgb(64, 64, 64);
            iconPictureBoxSalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBoxSalir.IconSize = 38;
            iconPictureBoxSalir.Location = new Point(858, 62);
            iconPictureBoxSalir.Name = "iconPictureBoxSalir";
            iconPictureBoxSalir.Size = new Size(38, 40);
            iconPictureBoxSalir.TabIndex = 33;
            iconPictureBoxSalir.TabStop = false;
            iconPictureBoxSalir.Click += iconPictureBoxSalir_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtValorVenta);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtdescripcion);
            panel1.Controls.Add(txtvalor);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtExistencias);
            panel1.Controls.Add(txtArticulo);
            panel1.Controls.Add(txtcodigo);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Location = new Point(5, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 153);
            panel1.TabIndex = 4;
            // 
            // txtValorVenta
            // 
            txtValorVenta.BackColor = SystemColors.Window;
            txtValorVenta.BorderStyle = BorderStyle.FixedSingle;
            txtValorVenta.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtValorVenta.Location = new Point(296, 93);
            txtValorVenta.Name = "txtValorVenta";
            txtValorVenta.Size = new Size(91, 23);
            txtValorVenta.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(198, 98);
            label10.Name = "label10";
            label10.Size = new Size(84, 16);
            label10.TabIndex = 30;
            label10.Text = "Valor Venta";
            // 
            // txtdescripcion
            // 
            txtdescripcion.BackColor = SystemColors.Window;
            txtdescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtdescripcion.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtdescripcion.Location = new Point(101, 63);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.ReadOnly = true;
            txtdescripcion.Size = new Size(287, 23);
            txtdescripcion.TabIndex = 7;
            // 
            // txtvalor
            // 
            txtvalor.BackColor = SystemColors.Window;
            txtvalor.BorderStyle = BorderStyle.FixedSingle;
            txtvalor.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtvalor.Location = new Point(101, 93);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(91, 23);
            txtvalor.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(5, 127);
            label8.Name = "label8";
            label8.Size = new Size(64, 16);
            label8.TabIndex = 20;
            label8.Text = "Cantidad";
            // 
            // txtExistencias
            // 
            txtExistencias.BackColor = SystemColors.Window;
            txtExistencias.BorderStyle = BorderStyle.FixedSingle;
            txtExistencias.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtExistencias.Location = new Point(101, 122);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(91, 23);
            txtExistencias.TabIndex = 10;
            // 
            // txtArticulo
            // 
            txtArticulo.BackColor = SystemColors.Window;
            txtArticulo.BorderStyle = BorderStyle.FixedSingle;
            txtArticulo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtArticulo.Location = new Point(101, 35);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.ReadOnly = true;
            txtArticulo.Size = new Size(287, 23);
            txtArticulo.TabIndex = 6;
            // 
            // txtcodigo
            // 
            txtcodigo.BackColor = SystemColors.Window;
            txtcodigo.BorderStyle = BorderStyle.FixedSingle;
            txtcodigo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtcodigo.Location = new Point(101, 8);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(162, 23);
            txtcodigo.TabIndex = 5;
            txtcodigo.KeyPress += txtcodigo_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(33, 10);
            label9.Name = "label9";
            label9.Size = new Size(50, 16);
            label9.TabIndex = 16;
            label9.Text = "Codigo";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(3, 98);
            label19.Name = "label19";
            label19.Size = new Size(94, 16);
            label19.TabIndex = 14;
            label19.Text = "Valor Compra";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(2, 69);
            label17.Name = "label17";
            label17.Size = new Size(81, 16);
            label17.TabIndex = 12;
            label17.Text = "Descripción";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(25, 41);
            label16.Name = "label16";
            label16.Size = new Size(58, 16);
            label16.TabIndex = 10;
            label16.Text = "Articulo";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(207, 233);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.RightToLeft = RightToLeft.No;
            btnLimpiar.Size = new Size(100, 32);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregarEntrada
            // 
            btnAgregarEntrada.BackColor = Color.FromArgb(64, 64, 64);
            btnAgregarEntrada.Cursor = Cursors.Hand;
            btnAgregarEntrada.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarEntrada.ForeColor = Color.White;
            btnAgregarEntrada.Location = new Point(313, 233);
            btnAgregarEntrada.Name = "btnAgregarEntrada";
            btnAgregarEntrada.RightToLeft = RightToLeft.No;
            btnAgregarEntrada.Size = new Size(100, 32);
            btnAgregarEntrada.TabIndex = 11;
            btnAgregarEntrada.Text = "Agregar";
            btnAgregarEntrada.UseVisualStyleBackColor = false;
            btnAgregarEntrada.Click += btnAgregarEntrada_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txtNombreProveedor);
            panel2.Controls.Add(txtIdProveedor);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtFactura);
            panel2.Location = new Point(4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 65);
            panel2.TabIndex = 0;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.BackColor = Color.LavenderBlush;
            txtNombreProveedor.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombreProveedor.Location = new Point(64, 35);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.ReadOnly = true;
            txtNombreProveedor.Size = new Size(322, 23);
            txtNombreProveedor.TabIndex = 3;
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdProveedor.Location = new Point(272, 4);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(114, 23);
            txtIdProveedor.TabIndex = 2;
            txtIdProveedor.KeyPress += txtIdProveedor_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(175, 7);
            label6.Name = "label6";
            label6.Size = new Size(92, 16);
            label6.TabIndex = 6;
            label6.Text = "Id Proveedor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(2, 7);
            label7.Name = "label7";
            label7.Size = new Size(56, 16);
            label7.TabIndex = 4;
            label7.Text = "Factura";
            // 
            // txtFactura
            // 
            txtFactura.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtFactura.Location = new Point(64, 4);
            txtFactura.Name = "txtFactura";
            txtFactura.Size = new Size(99, 23);
            txtFactura.TabIndex = 1;
            // 
            // btnEditarInventario
            // 
            btnEditarInventario.BackColor = Color.FromArgb(64, 64, 64);
            btnEditarInventario.Cursor = Cursors.Hand;
            btnEditarInventario.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarInventario.ForeColor = Color.White;
            btnEditarInventario.Location = new Point(639, 62);
            btnEditarInventario.Name = "btnEditarInventario";
            btnEditarInventario.RightToLeft = RightToLeft.No;
            btnEditarInventario.Size = new Size(100, 40);
            btnEditarInventario.TabIndex = 22;
            btnEditarInventario.Text = "Editar Inventario";
            btnEditarInventario.UseVisualStyleBackColor = false;
            btnEditarInventario.Click += btnEditarInventario_Click;
            // 
            // btnEliminarInventario
            // 
            btnEliminarInventario.BackColor = Color.FromArgb(64, 64, 64);
            btnEliminarInventario.Cursor = Cursors.Hand;
            btnEliminarInventario.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarInventario.ForeColor = Color.White;
            btnEliminarInventario.Location = new Point(746, 62);
            btnEliminarInventario.Name = "btnEliminarInventario";
            btnEliminarInventario.RightToLeft = RightToLeft.No;
            btnEliminarInventario.Size = new Size(100, 40);
            btnEliminarInventario.TabIndex = 23;
            btnEliminarInventario.Text = "Eliminar Inventario";
            btnEliminarInventario.UseVisualStyleBackColor = false;
            btnEliminarInventario.Click += btnEliminarInventario_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(796, 547);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.RightToLeft = RightToLeft.No;
            btnRegistrar.Size = new Size(100, 34);
            btnRegistrar.TabIndex = 20;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Visible = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpirForm
            // 
            btnLimpirForm.BackColor = Color.FromArgb(64, 64, 64);
            btnLimpirForm.Cursor = Cursors.Hand;
            btnLimpirForm.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpirForm.ForeColor = Color.White;
            btnLimpirForm.Location = new Point(676, 547);
            btnLimpirForm.Name = "btnLimpirForm";
            btnLimpirForm.RightToLeft = RightToLeft.No;
            btnLimpirForm.Size = new Size(100, 34);
            btnLimpirForm.TabIndex = 19;
            btnLimpirForm.Text = "Limpiar";
            btnLimpirForm.UseVisualStyleBackColor = false;
            btnLimpirForm.Click += btnLimpirForm_Click;
            // 
            // btnGestionArticulos
            // 
            btnGestionArticulos.BackColor = Color.FromArgb(64, 64, 64);
            btnGestionArticulos.Cursor = Cursors.Hand;
            btnGestionArticulos.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestionArticulos.ForeColor = Color.White;
            btnGestionArticulos.Location = new Point(427, 62);
            btnGestionArticulos.Name = "btnGestionArticulos";
            btnGestionArticulos.RightToLeft = RightToLeft.No;
            btnGestionArticulos.Size = new Size(100, 40);
            btnGestionArticulos.TabIndex = 34;
            btnGestionArticulos.Text = "Gestionar Articulos";
            btnGestionArticulos.UseVisualStyleBackColor = false;
            btnGestionArticulos.Click += btnGestionArticulos_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dtgvEntradas
            // 
            dtgvEntradas.BackgroundColor = Color.LavenderBlush;
            dtgvEntradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvEntradas.Location = new Point(3, 278);
            dtgvEntradas.Name = "dtgvEntradas";
            dtgvEntradas.RowTemplate.Height = 25;
            dtgvEntradas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvEntradas.Size = new Size(893, 257);
            dtgvEntradas.TabIndex = 35;
            dtgvEntradas.CellContentClick += dtgvEntradas_CellContentClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(btnAgregarEntrada);
            panel4.Controls.Add(btnLimpiar);
            panel4.Enabled = false;
            panel4.Location = new Point(5, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(413, 271);
            panel4.TabIndex = 36;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.FromArgb(64, 64, 64);
            btnGuardarCambios.Cursor = Cursors.Hand;
            btnGuardarCambios.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarCambios.ForeColor = Color.White;
            btnGuardarCambios.Location = new Point(795, 541);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.RightToLeft = RightToLeft.No;
            btnGuardarCambios.Size = new Size(114, 47);
            btnGuardarCambios.TabIndex = 37;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Visible = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // btnEliminarRegistro
            // 
            btnEliminarRegistro.BackColor = Color.Red;
            btnEliminarRegistro.Cursor = Cursors.Hand;
            btnEliminarRegistro.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarRegistro.ForeColor = Color.White;
            btnEliminarRegistro.Location = new Point(788, 541);
            btnEliminarRegistro.Name = "btnEliminarRegistro";
            btnEliminarRegistro.RightToLeft = RightToLeft.No;
            btnEliminarRegistro.Size = new Size(114, 47);
            btnEliminarRegistro.TabIndex = 38;
            btnEliminarRegistro.Text = "Eliminar Registros";
            btnEliminarRegistro.UseVisualStyleBackColor = false;
            btnEliminarRegistro.Visible = false;
            btnEliminarRegistro.Click += btnEliminarRegistro_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 24);
            label3.Name = "label3";
            label3.Size = new Size(76, 14);
            label3.TabIndex = 6;
            label3.Text = "Buscar por:";
            // 
            // iBtnBuscar
            // 
            iBtnBuscar.BackColor = Color.FromArgb(64, 64, 64);
            iBtnBuscar.Cursor = Cursors.Hand;
            iBtnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iBtnBuscar.IconColor = Color.White;
            iBtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iBtnBuscar.IconSize = 30;
            iBtnBuscar.Location = new Point(363, 37);
            iBtnBuscar.Name = "iBtnBuscar";
            iBtnBuscar.Size = new Size(52, 43);
            iBtnBuscar.TabIndex = 10;
            iBtnBuscar.UseVisualStyleBackColor = false;
            iBtnBuscar.Click += iBtnBuscar_Click;
            // 
            // cmbTipoBusqueda
            // 
            cmbTipoBusqueda.FormattingEnabled = true;
            cmbTipoBusqueda.Items.AddRange(new object[] { "Articulo", "Factura", "Proveedor" });
            cmbTipoBusqueda.Location = new Point(85, 21);
            cmbTipoBusqueda.Name = "cmbTipoBusqueda";
            cmbTipoBusqueda.Size = new Size(254, 23);
            cmbTipoBusqueda.TabIndex = 13;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.Window;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBuscar.Location = new Point(85, 55);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(254, 23);
            txtBuscar.TabIndex = 31;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(txtBuscar);
            panel3.Controls.Add(cmbTipoBusqueda);
            panel3.Controls.Add(iBtnBuscar);
            panel3.Controls.Add(label3);
            panel3.Enabled = false;
            panel3.Location = new Point(424, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(474, 97);
            panel3.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LavenderBlush;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 443);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(893, 92);
            dataGridView1.TabIndex = 39;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(910, 593);
            Controls.Add(dtgvEntradas);
            Controls.Add(panel4);
            Controls.Add(btnGestionArticulos);
            Controls.Add(btnLimpirForm);
            Controls.Add(btnEliminarInventario);
            Controls.Add(btnEditarInventario);
            Controls.Add(iconPictureBoxSalir);
            Controls.Add(panel3);
            Controls.Add(btnIngresarInventario);
            Controls.Add(btnRegistrar);
            Controls.Add(btnGuardarCambios);
            Controls.Add(btnEliminarRegistro);
            Controls.Add(dataGridView1);
            Name = "FormInventario";
            Text = "Control_Inventario [Inventario]";
            Load += FormInventario_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBoxSalir).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvEntradas).EndInit();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIngresarInventario;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSalir;
        private Panel panel1;
        private TextBox txtdescripcion;
        private Button btnLimpiar;
        private Button btnAgregarEntrada;
        private TextBox txtvalor;
        private Label label8;
        private TextBox txtExistencias;
        private TextBox txtArticulo;
        private TextBox txtcodigo;
        private Label label9;
        private Label label19;
        private Label label17;
        private Label label16;
        private TextBox txtValorVenta;
        private Label label10;
        private Panel panel2;
        private TextBox txtNombreProveedor;
        private TextBox txtIdProveedor;
        private Label label6;
        private Label label7;
        private TextBox txtFactura;
        private Button btnEditarInventario;
        private Button btnEliminarInventario;
        private Button btnRegistrar;
        private Button btnLimpirForm;
        private Button btnGestionArticulos;
        private ErrorProvider errorProvider1;
        private DataGridView dtgvEntradas;
        private Panel panel4;
        private Button btnGuardarCambios;
        private Button btnEliminarRegistro;
        private Panel panel3;
        private TextBox txtBuscar;
        private ComboBox cmbTipoBusqueda;
        private FontAwesome.Sharp.IconButton iBtnBuscar;
        private Label label3;
        private DataGridView dataGridView1;
    }
}