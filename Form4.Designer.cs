namespace Control_Inventario
{
    partial class FormUsuarios
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
            panel1 = new Panel();
            label20 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            iBtnBuscar = new FontAwesome.Sharp.IconButton();
            rbtnUsuario = new RadioButton();
            rbtnId = new RadioButton();
            label2 = new Label();
            rbtnNombre = new RadioButton();
            txtBuscarUsuario = new TextBox();
            label3 = new Label();
            dtgvEncontrados = new DataGridView();
            panel4 = new Panel();
            iButtonSalir = new FontAwesome.Sharp.IconButton();
            btnCrearUsuario = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            label1 = new Label();
            panel2 = new Panel();
            txtCorreo = new TextBox();
            label21 = new Label();
            txtTelefono = new TextBox();
            label15 = new Label();
            txtDireccion = new TextBox();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            label18 = new Label();
            panel8 = new Panel();
            cmbRol = new ComboBox();
            label22 = new Label();
            txtConfirmarContrasena = new TextBox();
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            label19 = new Label();
            label17 = new Label();
            label16 = new Label();
            label13 = new Label();
            label10 = new Label();
            panel7 = new Panel();
            txtSegundoApellido = new TextBox();
            txtPrimerApellido = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label6 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            txtNumeroDoc = new TextBox();
            label7 = new Label();
            rbtnPasaporte = new RadioButton();
            label8 = new Label();
            rbtnTipoCC = new RadioButton();
            rbtnTipoCEx = new RadioButton();
            panel6 = new Panel();
            txtSegundoNombre = new TextBox();
            txtPrimerNombre = new TextBox();
            label9 = new Label();
            label5 = new Label();
            btnGuardarCambios = new Button();
            btnEliminarRegistro = new Button();
            label14 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvEncontrados).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(label20);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dtgvEncontrados);
            panel1.Enabled = false;
            panel1.Location = new Point(28, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 213);
            panel1.TabIndex = 4;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(38, 119);
            label20.Name = "label20";
            label20.Size = new Size(84, 14);
            label20.TabIndex = 11;
            label20.Text = "Encontrados";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.LavenderBlush;
            iconPictureBox1.BackgroundImageLayout = ImageLayout.Center;
            iconPictureBox1.Cursor = Cursors.Hand;
            iconPictureBox1.ForeColor = Color.FromArgb(64, 64, 64);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            iconPictureBox1.IconColor = Color.FromArgb(64, 64, 64);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox1.IconSize = 39;
            iconPictureBox1.Location = new Point(920, 94);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(43, 39);
            iconPictureBox1.TabIndex = 13;
            iconPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(iBtnBuscar);
            panel3.Controls.Add(rbtnUsuario);
            panel3.Controls.Add(rbtnId);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(rbtnNombre);
            panel3.Controls.Add(txtBuscarUsuario);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(31, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(444, 75);
            panel3.TabIndex = 5;
            // 
            // iBtnBuscar
            // 
            iBtnBuscar.BackColor = Color.FromArgb(64, 64, 64);
            iBtnBuscar.Cursor = Cursors.Hand;
            iBtnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iBtnBuscar.IconColor = Color.White;
            iBtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iBtnBuscar.IconSize = 30;
            iBtnBuscar.Location = new Point(374, 12);
            iBtnBuscar.Name = "iBtnBuscar";
            iBtnBuscar.Size = new Size(51, 45);
            iBtnBuscar.TabIndex = 10;
            iBtnBuscar.UseVisualStyleBackColor = false;
            iBtnBuscar.Click += iBtnBuscar_Click;
            // 
            // rbtnUsuario
            // 
            rbtnUsuario.AutoSize = true;
            rbtnUsuario.Location = new Point(298, 41);
            rbtnUsuario.Name = "rbtnUsuario";
            rbtnUsuario.Size = new Size(70, 18);
            rbtnUsuario.TabIndex = 9;
            rbtnUsuario.TabStop = true;
            rbtnUsuario.Text = "Usuario";
            rbtnUsuario.UseVisualStyleBackColor = true;
            // 
            // rbtnId
            // 
            rbtnId.AutoSize = true;
            rbtnId.Location = new Point(128, 41);
            rbtnId.Name = "rbtnId";
            rbtnId.Size = new Size(38, 18);
            rbtnId.TabIndex = 7;
            rbtnId.TabStop = true;
            rbtnId.Text = "Id";
            rbtnId.UseVisualStyleBackColor = true;
            rbtnId.Click += rbtnId_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 11);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 4;
            label2.Text = "Usuario";
            // 
            // rbtnNombre
            // 
            rbtnNombre.AutoSize = true;
            rbtnNombre.Location = new Point(194, 41);
            rbtnNombre.Name = "rbtnNombre";
            rbtnNombre.Size = new Size(78, 18);
            rbtnNombre.TabIndex = 8;
            rbtnNombre.TabStop = true;
            rbtnNombre.Text = "Nombres";
            rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBuscarUsuario.Location = new Point(85, 7);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.Size = new Size(271, 23);
            txtBuscarUsuario.TabIndex = 6;
            txtBuscarUsuario.KeyPress += txtBuscarUsuario_KeyPress;
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
            // dtgvEncontrados
            // 
            dtgvEncontrados.BackgroundColor = Color.LavenderBlush;
            dtgvEncontrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvEncontrados.Location = new Point(31, 126);
            dtgvEncontrados.Name = "dtgvEncontrados";
            dtgvEncontrados.ReadOnly = true;
            dtgvEncontrados.RowTemplate.Height = 25;
            dtgvEncontrados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvEncontrados.Size = new Size(444, 84);
            dtgvEncontrados.TabIndex = 11;
            dtgvEncontrados.CellClick += dtgvEncontrados_CellClick;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(iButtonSalir);
            panel4.Controls.Add(btnCrearUsuario);
            panel4.Controls.Add(btnEliminar);
            panel4.Controls.Add(btnActualizar);
            panel4.Location = new Point(571, 110);
            panel4.Name = "panel4";
            panel4.Size = new Size(441, 78);
            panel4.TabIndex = 0;
            // 
            // iButtonSalir
            // 
            iButtonSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iButtonSalir.BackColor = Color.FromArgb(64, 64, 64);
            iButtonSalir.Cursor = Cursors.Hand;
            iButtonSalir.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iButtonSalir.ForeColor = Color.White;
            iButtonSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            iButtonSalir.IconColor = Color.White;
            iButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iButtonSalir.IconSize = 20;
            iButtonSalir.ImageAlign = ContentAlignment.BottomRight;
            iButtonSalir.Location = new Point(344, 18);
            iButtonSalir.Name = "iButtonSalir";
            iButtonSalir.RightToLeft = RightToLeft.Yes;
            iButtonSalir.Size = new Size(87, 32);
            iButtonSalir.TabIndex = 13;
            iButtonSalir.Text = "Salir";
            iButtonSalir.TextAlign = ContentAlignment.MiddleLeft;
            iButtonSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            iButtonSalir.UseVisualStyleBackColor = false;
            iButtonSalir.Click += iButtonSalir_Click;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.BackColor = Color.FromArgb(64, 64, 64);
            btnCrearUsuario.Cursor = Cursors.Hand;
            btnCrearUsuario.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearUsuario.ForeColor = Color.White;
            btnCrearUsuario.Location = new Point(6, 18);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.RightToLeft = RightToLeft.No;
            btnCrearUsuario.Size = new Size(100, 32);
            btnCrearUsuario.TabIndex = 1;
            btnCrearUsuario.Text = "Crear";
            btnCrearUsuario.UseVisualStyleBackColor = false;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(64, 64, 64);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(233, 18);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.RightToLeft = RightToLeft.No;
            btnEliminar.Size = new Size(100, 32);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(64, 64, 64);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(120, 18);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.RightToLeft = RightToLeft.No;
            btnActualizar.Size = new Size(100, 32);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(37, 19);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 3;
            label1.Text = "USUARIOS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LavenderBlush;
            panel2.Controls.Add(txtCorreo);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(txtDireccion);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnRegistrar);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(btnGuardarCambios);
            panel2.Controls.Add(btnEliminarRegistro);
            panel2.Enabled = false;
            panel2.Location = new Point(28, 253);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 340);
            panel2.TabIndex = 12;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCorreo.Location = new Point(118, 262);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(271, 23);
            txtCorreo.TabIndex = 23;
            txtCorreo.Leave += txtCorreo_Leave;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(31, 266);
            label21.Name = "label21";
            label21.Size = new Size(64, 19);
            label21.TabIndex = 26;
            label21.Text = "Correo";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTelefono.Location = new Point(118, 205);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(271, 23);
            txtTelefono.TabIndex = 22;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(31, 209);
            label15.Name = "label15";
            label15.Size = new Size(81, 19);
            label15.TabIndex = 24;
            label15.Text = "Telefono";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDireccion.Location = new Point(118, 150);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(271, 23);
            txtDireccion.TabIndex = 21;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(731, 293);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.RightToLeft = RightToLeft.No;
            btnLimpiar.Size = new Size(100, 32);
            btnLimpiar.TabIndex = 28;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(853, 293);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.RightToLeft = RightToLeft.No;
            btnRegistrar.Size = new Size(100, 32);
            btnRegistrar.TabIndex = 29;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(454, 142);
            label18.Name = "label18";
            label18.Size = new Size(113, 19);
            label18.TabIndex = 21;
            label18.Text = "Credenciales";
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(cmbRol);
            panel8.Controls.Add(label22);
            panel8.Controls.Add(txtConfirmarContrasena);
            panel8.Controls.Add(txtContrasena);
            panel8.Controls.Add(txtUsuario);
            panel8.Controls.Add(iconPictureBox7);
            panel8.Controls.Add(label19);
            panel8.Controls.Add(label17);
            panel8.Controls.Add(label16);
            panel8.Location = new Point(445, 153);
            panel8.Name = "panel8";
            panel8.Size = new Size(512, 134);
            panel8.TabIndex = 24;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.ItemHeight = 14;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Auxiliar" });
            cmbRol.Location = new Point(153, 98);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(271, 22);
            cmbRol.TabIndex = 28;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(8, 99);
            label22.Name = "label22";
            label22.Size = new Size(27, 16);
            label22.TabIndex = 30;
            label22.Text = "Rol";
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtConfirmarContrasena.Location = new Point(153, 69);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Size = new Size(271, 23);
            txtConfirmarContrasena.TabIndex = 27;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtContrasena.Location = new Point(153, 38);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(271, 23);
            txtContrasena.TabIndex = 26;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.Location = new Point(153, 7);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(271, 23);
            txtUsuario.TabIndex = 25;
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.BackColor = Color.LavenderBlush;
            iconPictureBox7.ForeColor = Color.Red;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.XmarksLines;
            iconPictureBox7.IconColor = Color.Red;
            iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox7.IconSize = 22;
            iconPictureBox7.Location = new Point(469, 69);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(29, 22);
            iconPictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox7.TabIndex = 15;
            iconPictureBox7.TabStop = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(8, 72);
            label19.Name = "label19";
            label19.Size = new Size(70, 16);
            label19.TabIndex = 8;
            label19.Text = "Confirmar";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(8, 42);
            label17.Name = "label17";
            label17.Size = new Size(82, 16);
            label17.TabIndex = 6;
            label17.Text = "Contraseña";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(8, 11);
            label16.Name = "label16";
            label16.Size = new Size(55, 16);
            label16.TabIndex = 4;
            label16.Text = "Usuario";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(31, 154);
            label13.Name = "label13";
            label13.Size = new Size(84, 19);
            label13.TabIndex = 16;
            label13.Text = "Direccion";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(454, 76);
            label10.Name = "label10";
            label10.Size = new Size(84, 19);
            label10.TabIndex = 14;
            label10.Text = "Apellidos";
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(txtSegundoApellido);
            panel7.Controls.Add(txtPrimerApellido);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(label12);
            panel7.Location = new Point(445, 89);
            panel7.Name = "panel7";
            panel7.Size = new Size(512, 43);
            panel7.TabIndex = 19;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSegundoApellido.Location = new Point(323, 7);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(182, 23);
            txtSegundoApellido.TabIndex = 21;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrimerApellido.Location = new Point(71, 8);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(182, 23);
            txtPrimerApellido.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(259, 10);
            label11.Name = "label11";
            label11.Size = new Size(63, 16);
            label11.TabIndex = 6;
            label11.Text = "Segundo";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(8, 11);
            label12.Name = "label12";
            label12.Size = new Size(57, 16);
            label12.TabIndex = 4;
            label12.Text = "Primero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(454, 13);
            label6.Name = "label6";
            label6.Size = new Size(81, 19);
            label6.TabIndex = 13;
            label6.Text = "Nombres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(42, 13);
            label4.Name = "label4";
            label4.Size = new Size(101, 19);
            label4.TabIndex = 11;
            label4.Text = "Documento";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(txtNumeroDoc);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(rbtnPasaporte);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(rbtnTipoCC);
            panel5.Controls.Add(rbtnTipoCEx);
            panel5.Location = new Point(31, 26);
            panel5.Name = "panel5";
            panel5.Size = new Size(391, 106);
            panel5.TabIndex = 13;
            // 
            // txtNumeroDoc
            // 
            txtNumeroDoc.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumeroDoc.Location = new Point(85, 22);
            txtNumeroDoc.MaxLength = 10;
            txtNumeroDoc.Name = "txtNumeroDoc";
            txtNumeroDoc.Size = new Size(271, 23);
            txtNumeroDoc.TabIndex = 4;
            txtNumeroDoc.KeyPress += txtNumeroDoc_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(11, 22);
            label7.Name = "label7";
            label7.Size = new Size(73, 19);
            label7.TabIndex = 11;
            label7.Text = "Numero";
            // 
            // rbtnPasaporte
            // 
            rbtnPasaporte.AutoSize = true;
            rbtnPasaporte.Location = new Point(297, 62);
            rbtnPasaporte.Name = "rbtnPasaporte";
            rbtnPasaporte.Size = new Size(87, 18);
            rbtnPasaporte.TabIndex = 16;
            rbtnPasaporte.TabStop = true;
            rbtnPasaporte.Text = "Pasaporte";
            rbtnPasaporte.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(8, 62);
            label8.Name = "label8";
            label8.Size = new Size(130, 16);
            label8.TabIndex = 6;
            label8.Text = "Tipo de Documento";
            // 
            // rbtnTipoCC
            // 
            rbtnTipoCC.AutoSize = true;
            rbtnTipoCC.Location = new Point(144, 62);
            rbtnTipoCC.Name = "rbtnTipoCC";
            rbtnTipoCC.Size = new Size(41, 18);
            rbtnTipoCC.TabIndex = 14;
            rbtnTipoCC.TabStop = true;
            rbtnTipoCC.Text = "CC";
            rbtnTipoCC.UseVisualStyleBackColor = true;
            // 
            // rbtnTipoCEx
            // 
            rbtnTipoCEx.AutoSize = true;
            rbtnTipoCEx.Location = new Point(207, 60);
            rbtnTipoCEx.Name = "rbtnTipoCEx";
            rbtnTipoCEx.Size = new Size(65, 18);
            rbtnTipoCEx.TabIndex = 15;
            rbtnTipoCEx.TabStop = true;
            rbtnTipoCEx.Text = "C. Ext.";
            rbtnTipoCEx.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(txtSegundoNombre);
            panel6.Controls.Add(txtPrimerNombre);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(445, 26);
            panel6.Name = "panel6";
            panel6.Size = new Size(512, 43);
            panel6.TabIndex = 17;
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSegundoNombre.Location = new Point(324, 7);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(182, 23);
            txtSegundoNombre.TabIndex = 19;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrimerNombre.Location = new Point(71, 7);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(182, 23);
            txtPrimerNombre.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(259, 10);
            label9.Name = "label9";
            label9.Size = new Size(63, 16);
            label9.TabIndex = 6;
            label9.Text = "Segundo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 11);
            label5.Name = "label5";
            label5.Size = new Size(57, 16);
            label5.TabIndex = 4;
            label5.Text = "Primero";
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.FromArgb(64, 64, 64);
            btnGuardarCambios.Cursor = Cursors.Hand;
            btnGuardarCambios.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarCambios.ForeColor = Color.White;
            btnGuardarCambios.Location = new Point(852, 287);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.RightToLeft = RightToLeft.No;
            btnGuardarCambios.Size = new Size(100, 44);
            btnGuardarCambios.TabIndex = 30;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // btnEliminarRegistro
            // 
            btnEliminarRegistro.BackColor = Color.Red;
            btnEliminarRegistro.Cursor = Cursors.Hand;
            btnEliminarRegistro.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarRegistro.ForeColor = Color.White;
            btnEliminarRegistro.Location = new Point(845, 287);
            btnEliminarRegistro.Name = "btnEliminarRegistro";
            btnEliminarRegistro.RightToLeft = RightToLeft.No;
            btnEliminarRegistro.Size = new Size(115, 44);
            btnEliminarRegistro.TabIndex = 31;
            btnEliminarRegistro.Text = "Eliminar Registro";
            btnEliminarRegistro.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEliminarRegistro.UseVisualStyleBackColor = false;
            btnEliminarRegistro.Click += btnEliminarRegistro_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(31, 222);
            label14.Name = "label14";
            label14.Size = new Size(69, 19);
            label14.TabIndex = 18;
            label14.Text = "Correo ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1037, 621);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "FormUsuarios";
            Text = "Control_Inventario [Usuarios]";
            Load += FormUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvEncontrados).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCrear;
        private Label label3;
        private TextBox txtBuscarUsuario;
        private Label label2;
        private Label label1;
        private Button btnActualizar;
        private Button btnEliminar;
        private Panel panel2;
        private RadioButton rbtnUsuario;
        private RadioButton rbtnId;
        private RadioButton rbtnNombre;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iBtnBuscar;
        private Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label6;
        private Label label4;
        private Panel panel5;
        private RadioButton rbtnCEX;
        private RadioButton rbtnTI;
        private Label lblNumero;
        private RadioButton rbtnCC;
        private TextBox txtIdUsuario;
        private Label label8;
        private Label label10;
        private Panel panel7;
        private TextBox txtSegundoApellidoUsuar;
        private Label label11;
        private Label label12;
        private TextBox txtPrimerApellidoUsuar;
        private Panel panel6;
        private TextBox txtsegundoNombreUsuar;
        private Label label9;
        private Label label5;
        private TextBox txtPrimerNombreUsuar;
        private Label label20;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private Label label18;
        private Panel panel8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private Label label19;
        private TextBox txtConfirmar;
        private Label label17;
        private TextBox txtContrseña;
        private Label label16;
        private TextBox txtNombreUsuario;
        private TextBox txttelefono;
        private Label lblTelefono;
        private TextBox txtcorreoUsuar;
        private Label label14;
        private TextBox txtDireccionUsuar;
        private Label label13;
        private RadioButton rbtnPass;
        private DataGridView dgvUsuario;
        private Button btnSalir;
        private DataGridView dtgvEncontrados;
        private Button btnCrearUsuario;
        private RadioButton rbtnPasaporte;
        private RadioButton rbtnTipoCC;
        private RadioButton rbtnTipoCEx;
        private TextBox txtCorreo;
        private Label label21;
        private TextBox txtTelefono;
        private Label label15;
        private TextBox txtDireccion;
        private TextBox txtConfirmarContrasena;
        private TextBox txtContrasena;
        private TextBox txtSegundoApellido;
        private TextBox txtPrimerApellido;
        private TextBox txtNumeroDoc;
        private Label label7;
        private TextBox txtSegundoNombre;
        private TextBox txtPrimerNombre;
        private ComboBox cmbRol;
        private Label label22;
        private TextBox txtUsuario;
        private ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton iButtonSalir;
        private Button btnGuardarCambios;
        private Button btnEliminarRegistro;
    }
}