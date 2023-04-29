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
            btnCrearUsuario = new Button();
            button3 = new Button();
            button2 = new Button();
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
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
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
            label14 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvEncontrados).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
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
            panel1.TabIndex = 0;
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
            panel3.TabIndex = 11;
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
            rbtnId.TabIndex = 8;
            rbtnId.TabStop = true;
            rbtnId.Text = "Id";
            rbtnId.UseVisualStyleBackColor = true;
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
            rbtnNombre.TabIndex = 7;
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
            txtBuscarUsuario.TabIndex = 5;
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
            dtgvEncontrados.RowTemplate.Height = 25;
            dtgvEncontrados.Size = new Size(444, 84);
            dtgvEncontrados.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(btnCrearUsuario);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Location = new Point(616, 110);
            panel4.Name = "panel4";
            panel4.Size = new Size(396, 78);
            panel4.TabIndex = 12;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.BackColor = Color.FromArgb(64, 64, 64);
            btnCrearUsuario.Cursor = Cursors.Hand;
            btnCrearUsuario.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearUsuario.ForeColor = Color.White;
            btnCrearUsuario.Location = new Point(22, 18);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.RightToLeft = RightToLeft.No;
            btnCrearUsuario.Size = new Size(100, 32);
            btnCrearUsuario.TabIndex = 3;
            btnCrearUsuario.Text = "Crear";
            btnCrearUsuario.UseVisualStyleBackColor = false;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(275, 18);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(100, 32);
            button3.TabIndex = 2;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(147, 18);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(100, 32);
            button2.TabIndex = 1;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = false;
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
            panel2.Enabled = false;
            panel2.Location = new Point(28, 253);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 340);
            panel2.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCorreo.Location = new Point(118, 262);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(271, 23);
            txtCorreo.TabIndex = 25;
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
            txtTelefono.TabIndex = 23;
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
            txtDireccion.TabIndex = 14;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(738, 293);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.RightToLeft = RightToLeft.No;
            btnLimpiar.Size = new Size(100, 32);
            btnLimpiar.TabIndex = 22;
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
            btnRegistrar.TabIndex = 3;
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
            panel8.Controls.Add(iconPictureBox6);
            panel8.Controls.Add(iconPictureBox5);
            panel8.Controls.Add(iconPictureBox4);
            panel8.Controls.Add(iconPictureBox3);
            panel8.Controls.Add(iconPictureBox2);
            panel8.Controls.Add(label19);
            panel8.Controls.Add(label17);
            panel8.Controls.Add(label16);
            panel8.Location = new Point(445, 153);
            panel8.Name = "panel8";
            panel8.Size = new Size(512, 134);
            panel8.TabIndex = 13;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador del Sistema", "Administrador", "Auxiliar" });
            cmbRol.Location = new Point(153, 98);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(271, 22);
            cmbRol.TabIndex = 31;
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
            txtConfirmarContrasena.TabIndex = 29;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtContrasena.Location = new Point(153, 38);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(271, 23);
            txtContrasena.TabIndex = 28;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.Location = new Point(153, 7);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(271, 23);
            txtUsuario.TabIndex = 27;
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.BackColor = Color.LavenderBlush;
            iconPictureBox7.ForeColor = Color.Red;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.XmarksLines;
            iconPictureBox7.IconColor = Color.Red;
            iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox7.IconSize = 22;
            iconPictureBox7.Location = new Point(472, 69);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(29, 22);
            iconPictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox7.TabIndex = 15;
            iconPictureBox7.TabStop = false;
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.LavenderBlush;
            iconPictureBox6.ForeColor = Color.Red;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.XmarksLines;
            iconPictureBox6.IconColor = Color.Red;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox6.IconSize = 22;
            iconPictureBox6.Location = new Point(472, 39);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(29, 22);
            iconPictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox6.TabIndex = 14;
            iconPictureBox6.TabStop = false;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.LavenderBlush;
            iconPictureBox5.ForeColor = Color.Red;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconPictureBox5.IconColor = Color.Red;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox5.IconSize = 22;
            iconPictureBox5.Location = new Point(472, 8);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(29, 22);
            iconPictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox5.TabIndex = 13;
            iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.LavenderBlush;
            iconPictureBox4.ForeColor = Color.Lime;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Check;
            iconPictureBox4.IconColor = Color.Lime;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox4.IconSize = 22;
            iconPictureBox4.Location = new Point(430, 69);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(29, 22);
            iconPictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox4.TabIndex = 12;
            iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.LavenderBlush;
            iconPictureBox3.ForeColor = Color.Lime;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Check;
            iconPictureBox3.IconColor = Color.Lime;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox3.IconSize = 22;
            iconPictureBox3.Location = new Point(430, 39);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(29, 22);
            iconPictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox3.TabIndex = 11;
            iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.LavenderBlush;
            iconPictureBox2.ForeColor = Color.Lime;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Check;
            iconPictureBox2.IconColor = Color.Lime;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox2.IconSize = 22;
            iconPictureBox2.Location = new Point(430, 8);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(29, 22);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox2.TabIndex = 10;
            iconPictureBox2.TabStop = false;
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
            panel7.TabIndex = 15;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSegundoApellido.Location = new Point(323, 7);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(182, 23);
            txtSegundoApellido.TabIndex = 30;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrimerApellido.Location = new Point(71, 8);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(182, 23);
            txtPrimerApellido.TabIndex = 29;
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
            panel5.TabIndex = 12;
            // 
            // txtNumeroDoc
            // 
            txtNumeroDoc.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumeroDoc.Location = new Point(85, 22);
            txtNumeroDoc.Name = "txtNumeroDoc";
            txtNumeroDoc.Size = new Size(271, 23);
            txtNumeroDoc.TabIndex = 11;
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
            rbtnPasaporte.TabIndex = 13;
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
            rbtnTipoCC.TabIndex = 12;
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
            rbtnTipoCEx.TabIndex = 11;
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
            panel6.TabIndex = 13;
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSegundoNombre.Location = new Point(324, 7);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(182, 23);
            txtSegundoNombre.TabIndex = 28;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrimerNombre.Location = new Point(71, 7);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(182, 23);
            txtPrimerNombre.TabIndex = 27;
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
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private Button button2;
        private Button button3;
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
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
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
        private TextBox txtUsuario;
        private TextBox txtSegundoApellido;
        private TextBox txtPrimerApellido;
        private TextBox txtNumeroDoc;
        private Label label7;
        private TextBox txtSegundoNombre;
        private TextBox txtPrimerNombre;
        private ComboBox cmbRol;
        private Label label22;
    }
}