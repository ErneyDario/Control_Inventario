namespace Control_Inventario
{
    partial class FormVentas
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
            panel3 = new Panel();
            iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            rbtnDescripcion = new RadioButton();
            rbtnCodigo = new RadioButton();
            label2 = new Label();
            rbtnNombre = new RadioButton();
            txtBuscar = new TextBox();
            label3 = new Label();
            label20 = new Label();
            panel1 = new Panel();
            txtDescripcion = new TextBox();
            btnLimpiarCampos = new Button();
            btnAgregar = new Button();
            txtTotal = new TextBox();
            label6 = new Label();
            txtCantidad = new TextBox();
            label5 = new Label();
            txtValor = new TextBox();
            label4 = new Label();
            txtexistencias = new TextBox();
            txtArticulo = new TextBox();
            txtcodigo = new TextBox();
            label1 = new Label();
            label19 = new Label();
            label17 = new Label();
            label16 = new Label();
            Registrar = new Button();
            Eliminar = new Button();
            btnSalir = new Button();
            dataGridView1 = new DataGridView();
            dgvVentas = new DataGridView();
            panel2 = new Panel();
            txtNombreCliente = new TextBox();
            label7 = new Label();
            txtIdCliente = new TextBox();
            btnVentaDia = new Button();
            dgvEncontrados = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            label8 = new Label();
            txtTotalVenta = new TextBox();
            txtRecibido = new TextBox();
            label9 = new Label();
            txtCambio = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtFactura = new TextBox();
            dataGridView2 = new DataGridView();
            btnLimpiarTodo = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEncontrados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(iconButtonBuscar);
            panel3.Controls.Add(rbtnDescripcion);
            panel3.Controls.Add(rbtnCodigo);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(rbtnNombre);
            panel3.Controls.Add(txtBuscar);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(444, 75);
            panel3.TabIndex = 12;
            // 
            // iconButtonBuscar
            // 
            iconButtonBuscar.BackColor = Color.FromArgb(64, 64, 64);
            iconButtonBuscar.Cursor = Cursors.Hand;
            iconButtonBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButtonBuscar.IconColor = Color.White;
            iconButtonBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonBuscar.IconSize = 30;
            iconButtonBuscar.Location = new Point(374, 12);
            iconButtonBuscar.Name = "iconButtonBuscar";
            iconButtonBuscar.Size = new Size(51, 45);
            iconButtonBuscar.TabIndex = 10;
            iconButtonBuscar.UseVisualStyleBackColor = false;
            iconButtonBuscar.Click += iconButtonBuscar_Click;
            // 
            // rbtnDescripcion
            // 
            rbtnDescripcion.AutoSize = true;
            rbtnDescripcion.Location = new Point(281, 41);
            rbtnDescripcion.Name = "rbtnDescripcion";
            rbtnDescripcion.Size = new Size(87, 19);
            rbtnDescripcion.TabIndex = 9;
            rbtnDescripcion.TabStop = true;
            rbtnDescripcion.Text = "Descripción";
            rbtnDescripcion.UseVisualStyleBackColor = true;
            // 
            // rbtnCodigo
            // 
            rbtnCodigo.AutoSize = true;
            rbtnCodigo.Location = new Point(128, 41);
            rbtnCodigo.Name = "rbtnCodigo";
            rbtnCodigo.Size = new Size(64, 19);
            rbtnCodigo.TabIndex = 8;
            rbtnCodigo.TabStop = true;
            rbtnCodigo.Text = "Codigo";
            rbtnCodigo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 11);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 4;
            label2.Text = "Articulo";
            // 
            // rbtnNombre
            // 
            rbtnNombre.AutoSize = true;
            rbtnNombre.Location = new Point(206, 41);
            rbtnNombre.Name = "rbtnNombre";
            rbtnNombre.Size = new Size(69, 19);
            rbtnNombre.TabIndex = 7;
            rbtnNombre.TabStop = true;
            rbtnNombre.Text = "Nombre";
            rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBuscar.Location = new Point(85, 7);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(271, 23);
            txtBuscar.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 39);
            label3.Name = "label3";
            label3.Size = new Size(101, 19);
            label3.TabIndex = 6;
            label3.Text = "Buscar por:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(20, 86);
            label20.Name = "label20";
            label20.Size = new Size(84, 14);
            label20.TabIndex = 14;
            label20.Text = "Encontrados";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(btnLimpiarCampos);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtValor);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtexistencias);
            panel1.Controls.Add(txtArticulo);
            panel1.Controls.Add(txtcodigo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Location = new Point(12, 282);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 233);
            panel1.TabIndex = 16;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.LavenderBlush;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(116, 75);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(311, 23);
            txtDescripcion.TabIndex = 29;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = Color.FromArgb(64, 64, 64);
            btnLimpiarCampos.Cursor = Cursors.Hand;
            btnLimpiarCampos.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiarCampos.ForeColor = Color.White;
            btnLimpiarCampos.Location = new Point(211, 197);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.RightToLeft = RightToLeft.No;
            btnLimpiarCampos.Size = new Size(100, 32);
            btnLimpiarCampos.TabIndex = 28;
            btnLimpiarCampos.Text = "Limpiar";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(64, 64, 64);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(327, 197);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.RightToLeft = RightToLeft.No;
            btnAgregar.Size = new Size(100, 32);
            btnAgregar.TabIndex = 27;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.LavenderBlush;
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(331, 160);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(96, 23);
            txtTotal.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(272, 167);
            label6.Name = "label6";
            label6.Size = new Size(39, 16);
            label6.TabIndex = 25;
            label6.Text = "Total";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.White;
            txtCantidad.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCantidad.Location = new Point(331, 124);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(96, 23);
            txtCantidad.TabIndex = 24;
            txtCantidad.Leave += txtCantidad_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(247, 131);
            label5.Name = "label5";
            label5.Size = new Size(64, 16);
            label5.TabIndex = 23;
            label5.Text = "Cantidad";
            // 
            // txtValor
            // 
            txtValor.BackColor = Color.LavenderBlush;
            txtValor.BorderStyle = BorderStyle.FixedSingle;
            txtValor.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtValor.Location = new Point(116, 124);
            txtValor.Name = "txtValor";
            txtValor.ReadOnly = true;
            txtValor.Size = new Size(91, 23);
            txtValor.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(310, 10);
            label4.Name = "label4";
            label4.Size = new Size(78, 16);
            label4.TabIndex = 20;
            label4.Text = "Existencias";
            // 
            // txtexistencias
            // 
            txtexistencias.BackColor = Color.LavenderBlush;
            txtexistencias.BorderStyle = BorderStyle.FixedSingle;
            txtexistencias.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtexistencias.Location = new Point(394, 8);
            txtexistencias.Name = "txtexistencias";
            txtexistencias.ReadOnly = true;
            txtexistencias.Size = new Size(33, 23);
            txtexistencias.TabIndex = 19;
            // 
            // txtArticulo
            // 
            txtArticulo.BackColor = Color.LavenderBlush;
            txtArticulo.BorderStyle = BorderStyle.FixedSingle;
            txtArticulo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtArticulo.Location = new Point(116, 41);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.ReadOnly = true;
            txtArticulo.Size = new Size(311, 23);
            txtArticulo.TabIndex = 18;
            // 
            // txtcodigo
            // 
            txtcodigo.BackColor = Color.LavenderBlush;
            txtcodigo.BorderStyle = BorderStyle.FixedSingle;
            txtcodigo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtcodigo.Location = new Point(116, 8);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.ReadOnly = true;
            txtcodigo.Size = new Size(180, 23);
            txtcodigo.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 10);
            label1.Name = "label1";
            label1.Size = new Size(50, 16);
            label1.TabIndex = 16;
            label1.Text = "Codigo";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(57, 131);
            label19.Name = "label19";
            label19.Size = new Size(41, 16);
            label19.TabIndex = 14;
            label19.Text = "Valor";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(17, 82);
            label17.Name = "label17";
            label17.Size = new Size(81, 16);
            label17.TabIndex = 12;
            label17.Text = "Descripción";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(40, 48);
            label16.Name = "label16";
            label16.Size = new Size(58, 16);
            label16.TabIndex = 10;
            label16.Text = "Articulo";
            // 
            // Registrar
            // 
            Registrar.BackColor = Color.FromArgb(64, 64, 64);
            Registrar.Cursor = Cursors.Hand;
            Registrar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Registrar.ForeColor = Color.White;
            Registrar.Location = new Point(797, 521);
            Registrar.Name = "Registrar";
            Registrar.RightToLeft = RightToLeft.No;
            Registrar.Size = new Size(100, 32);
            Registrar.TabIndex = 29;
            Registrar.Text = "Registrar";
            Registrar.UseVisualStyleBackColor = false;
            Registrar.Click += Registrar_Click;
            // 
            // Eliminar
            // 
            Eliminar.BackColor = Color.FromArgb(64, 64, 64);
            Eliminar.Cursor = Cursors.Hand;
            Eliminar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Eliminar.ForeColor = Color.White;
            Eliminar.Location = new Point(691, 521);
            Eliminar.Name = "Eliminar";
            Eliminar.RightToLeft = RightToLeft.No;
            Eliminar.Size = new Size(100, 32);
            Eliminar.TabIndex = 30;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = false;
            Eliminar.Click += Eliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(64, 64, 64);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(12, 543);
            btnSalir.Name = "btnSalir";
            btnSalir.RightToLeft = RightToLeft.No;
            btnSalir.Size = new Size(100, 32);
            btnSalir.TabIndex = 32;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(506, 594);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(69, 8);
            dataGridView1.TabIndex = 33;
            // 
            // dgvVentas
            // 
            dgvVentas.BackgroundColor = Color.LavenderBlush;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.GridColor = Color.LavenderBlush;
            dgvVentas.Location = new Point(475, 55);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowTemplate.Height = 25;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(422, 375);
            dgvVentas.TabIndex = 34;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txtNombreCliente);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtIdCliente);
            panel2.Location = new Point(12, 206);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 70);
            panel2.TabIndex = 13;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.BackColor = Color.LavenderBlush;
            txtNombreCliente.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombreCliente.Location = new Point(114, 36);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.ReadOnly = true;
            txtNombreCliente.Size = new Size(299, 23);
            txtNombreCliente.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(24, 9);
            label7.Name = "label7";
            label7.Size = new Size(72, 16);
            label7.TabIndex = 4;
            label7.Text = "Id_Cliente";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdCliente.Location = new Point(114, 6);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(299, 23);
            txtIdCliente.TabIndex = 5;
            txtIdCliente.Leave += txtIdCliente_Leave;
            // 
            // btnVentaDia
            // 
            btnVentaDia.BackColor = Color.FromArgb(64, 64, 64);
            btnVentaDia.Cursor = Cursors.Hand;
            btnVentaDia.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentaDia.ForeColor = Color.White;
            btnVentaDia.Location = new Point(142, 543);
            btnVentaDia.Name = "btnVentaDia";
            btnVentaDia.RightToLeft = RightToLeft.No;
            btnVentaDia.Size = new Size(100, 32);
            btnVentaDia.TabIndex = 33;
            btnVentaDia.Text = "Venta Dia";
            btnVentaDia.UseVisualStyleBackColor = false;
            btnVentaDia.Click += btnVentaDia_Click;
            // 
            // dgvEncontrados
            // 
            dgvEncontrados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEncontrados.BackgroundColor = Color.LavenderBlush;
            dgvEncontrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEncontrados.Location = new Point(12, 93);
            dgvEncontrados.Name = "dgvEncontrados";
            dgvEncontrados.ReadOnly = true;
            dgvEncontrados.RowTemplate.Height = 25;
            dgvEncontrados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEncontrados.Size = new Size(444, 107);
            dgvEncontrados.TabIndex = 35;
            dgvEncontrados.CellContentClick += dgvEncontrados_CellContentClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(475, 452);
            label8.Name = "label8";
            label8.Size = new Size(39, 16);
            label8.TabIndex = 7;
            label8.Text = "Total";
            // 
            // txtTotalVenta
            // 
            txtTotalVenta.BackColor = Color.LavenderBlush;
            txtTotalVenta.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalVenta.Location = new Point(518, 449);
            txtTotalVenta.Name = "txtTotalVenta";
            txtTotalVenta.ReadOnly = true;
            txtTotalVenta.Size = new Size(161, 23);
            txtTotalVenta.TabIndex = 7;
            // 
            // txtRecibido
            // 
            txtRecibido.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtRecibido.Location = new Point(753, 450);
            txtRecibido.Name = "txtRecibido";
            txtRecibido.Size = new Size(144, 23);
            txtRecibido.TabIndex = 36;
            txtRecibido.Leave += txtRecibido_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(693, 453);
            label9.Name = "label9";
            label9.Size = new Size(61, 16);
            label9.TabIndex = 37;
            label9.Text = "Recibido";
            // 
            // txtCambio
            // 
            txtCambio.BackColor = Color.LavenderBlush;
            txtCambio.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCambio.Location = new Point(753, 480);
            txtCambio.Name = "txtCambio";
            txtCambio.ReadOnly = true;
            txtCambio.Size = new Size(144, 23);
            txtCambio.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(696, 483);
            label10.Name = "label10";
            label10.Size = new Size(53, 16);
            label10.TabIndex = 39;
            label10.Text = "Cambio";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(718, 28);
            label11.Name = "label11";
            label11.Size = new Size(70, 19);
            label11.TabIndex = 11;
            label11.Text = "Factura";
            // 
            // txtFactura
            // 
            txtFactura.BackColor = Color.LavenderBlush;
            txtFactura.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtFactura.Location = new Point(789, 26);
            txtFactura.Name = "txtFactura";
            txtFactura.ReadOnly = true;
            txtFactura.Size = new Size(108, 23);
            txtFactura.TabIndex = 11;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.LavenderBlush;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(475, 331);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(422, 83);
            dataGridView2.TabIndex = 40;
            // 
            // btnLimpiarTodo
            // 
            btnLimpiarTodo.BackColor = Color.FromArgb(64, 64, 64);
            btnLimpiarTodo.Cursor = Cursors.Hand;
            btnLimpiarTodo.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiarTodo.ForeColor = Color.White;
            btnLimpiarTodo.Location = new Point(579, 521);
            btnLimpiarTodo.Name = "btnLimpiarTodo";
            btnLimpiarTodo.RightToLeft = RightToLeft.No;
            btnLimpiarTodo.Size = new Size(100, 32);
            btnLimpiarTodo.TabIndex = 30;
            btnLimpiarTodo.Text = "Limpiar";
            btnLimpiarTodo.UseVisualStyleBackColor = false;
            btnLimpiarTodo.Click += btnLimpiarTodo_Click;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(909, 587);
            Controls.Add(btnLimpiarTodo);
            Controls.Add(txtFactura);
            Controls.Add(label11);
            Controls.Add(txtCambio);
            Controls.Add(label10);
            Controls.Add(txtRecibido);
            Controls.Add(label9);
            Controls.Add(txtTotalVenta);
            Controls.Add(label8);
            Controls.Add(label20);
            Controls.Add(dgvEncontrados);
            Controls.Add(dgvVentas);
            Controls.Add(dataGridView1);
            Controls.Add(btnVentaDia);
            Controls.Add(panel2);
            Controls.Add(btnSalir);
            Controls.Add(Eliminar);
            Controls.Add(Registrar);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(dataGridView2);
            Name = "FormVentas";
            Text = "Control de Inventario [Ventas]";
            Load += FormVentas_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEncontrados).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButtonBuscar;
        private RadioButton rbtnDescripcion;
        private RadioButton rbtnCodigo;
        private Label label2;
        private RadioButton rbtnNombre;
        private TextBox txtBuscar;
        private Label label3;
        private Label label20;
        private Panel panel1;
        private Label label4;
        private TextBox txtexistencias;
        private TextBox txtArticulo;
        private TextBox txtcodigo;
        private Label label1;
        private Label label19;
        private Label label17;
        private Label label16;
        private TextBox txtValor;
        private TextBox txtTotal;
        private Label label6;
        private TextBox txtCantidad;
        private Label label5;
        private Button btnLimpiarCampos;
        private Button btnAgregar;
        private Button Registrar;
        private Button Eliminar;
        private Button btnSalir;
        private DataGridView dataGridView1;
        private DataGridView dgvVentas;
        private Panel panel2;
        private Label label7;
        private Button btnVentaDia;
        private TextBox txtDescripcion;
        private DataGridView dgvEncontrados;
        private ErrorProvider errorProvider1;
        private TextBox txtNombreCliente;
        private TextBox txtIdCliente;
        private TextBox txtTotalVenta;
        private Label label8;
        private TextBox txtRecibido;
        private Label label9;
        private TextBox txtCambio;
        private Label label10;
        private TextBox txtFactura;
        private Label label11;
        private DataGridView dataGridView2;
        private Button btnLimpiarTodo;
    }
}