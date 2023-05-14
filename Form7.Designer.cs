namespace Control_Inventario
{
    partial class FormClientes
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
            iconButtonBuscarClientes = new FontAwesome.Sharp.IconButton();
            rbtnBuscarId = new RadioButton();
            label2 = new Label();
            rbtnBuscarNombre = new RadioButton();
            txtBuscarClientes = new TextBox();
            label3 = new Label();
            label20 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            btnCrearClientes = new Button();
            btnEliminarClientes = new Button();
            btnActualizarClientes = new Button();
            iconPictureSalir = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            txtTelefono = new TextBox();
            label15 = new Label();
            txtCorreo = new TextBox();
            label14 = new Label();
            txtDireccion = new TextBox();
            label13 = new Label();
            label10 = new Label();
            panel7 = new Panel();
            txtSegundoApellido = new TextBox();
            label11 = new Label();
            label12 = new Label();
            txtPrimerApellido = new TextBox();
            label6 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            rbtnPass = new RadioButton();
            rbtnCEx = new RadioButton();
            rbtnTi = new RadioButton();
            label7 = new Label();
            rbtnCC = new RadioButton();
            txtNumeroDoc = new TextBox();
            label8 = new Label();
            panel6 = new Panel();
            txtSegundoNombre = new TextBox();
            label9 = new Label();
            label5 = new Label();
            txtPrimerNombre = new TextBox();
            btnLimpiar = new Button();
            btnRegistar = new Button();
            dtgvEncontrados = new DataGridView();
            panel1 = new Panel();
            btnGuardarCambios = new Button();
            btnEliminarRegistro = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureSalir).BeginInit();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvEncontrados).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(iconButtonBuscarClientes);
            panel3.Controls.Add(rbtnBuscarId);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(rbtnBuscarNombre);
            panel3.Controls.Add(txtBuscarClientes);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(5, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(427, 75);
            panel3.TabIndex = 4;
            // 
            // iconButtonBuscarClientes
            // 
            iconButtonBuscarClientes.BackColor = Color.FromArgb(64, 64, 64);
            iconButtonBuscarClientes.Cursor = Cursors.Hand;
            iconButtonBuscarClientes.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButtonBuscarClientes.IconColor = Color.White;
            iconButtonBuscarClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonBuscarClientes.IconSize = 30;
            iconButtonBuscarClientes.Location = new Point(364, 11);
            iconButtonBuscarClientes.Name = "iconButtonBuscarClientes";
            iconButtonBuscarClientes.Size = new Size(51, 45);
            iconButtonBuscarClientes.TabIndex = 8;
            iconButtonBuscarClientes.UseVisualStyleBackColor = false;
            iconButtonBuscarClientes.Click += iconButtonBuscarClientes_Click;
            // 
            // rbtnBuscarId
            // 
            rbtnBuscarId.AutoSize = true;
            rbtnBuscarId.Location = new Point(133, 41);
            rbtnBuscarId.Name = "rbtnBuscarId";
            rbtnBuscarId.Size = new Size(35, 19);
            rbtnBuscarId.TabIndex = 6;
            rbtnBuscarId.TabStop = true;
            rbtnBuscarId.Text = "Id";
            rbtnBuscarId.UseVisualStyleBackColor = true;
            rbtnBuscarId.Click += rbtnBuscarId_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 9);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 4;
            label2.Text = "Cliente";
            // 
            // rbtnBuscarNombre
            // 
            rbtnBuscarNombre.AutoSize = true;
            rbtnBuscarNombre.Location = new Point(246, 41);
            rbtnBuscarNombre.Name = "rbtnBuscarNombre";
            rbtnBuscarNombre.Size = new Size(74, 19);
            rbtnBuscarNombre.TabIndex = 7;
            rbtnBuscarNombre.TabStop = true;
            rbtnBuscarNombre.Text = "Nombres";
            rbtnBuscarNombre.UseVisualStyleBackColor = true;
            // 
            // txtBuscarClientes
            // 
            txtBuscarClientes.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBuscarClientes.Location = new Point(85, 7);
            txtBuscarClientes.Name = "txtBuscarClientes";
            txtBuscarClientes.Size = new Size(271, 23);
            txtBuscarClientes.TabIndex = 5;
            txtBuscarClientes.KeyPress += txtBuscarClientes_KeyPress;
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
            label20.Location = new Point(14, 83);
            label20.Name = "label20";
            label20.Size = new Size(84, 14);
            label20.TabIndex = 14;
            label20.Text = "Encontrados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(470, 68);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 15;
            label1.Text = "CLIENTES";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(btnCrearClientes);
            panel4.Controls.Add(btnEliminarClientes);
            panel4.Controls.Add(btnActualizarClientes);
            panel4.Location = new Point(450, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(396, 78);
            panel4.TabIndex = 0;
            // 
            // btnCrearClientes
            // 
            btnCrearClientes.BackColor = Color.FromArgb(64, 64, 64);
            btnCrearClientes.Cursor = Cursors.Hand;
            btnCrearClientes.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearClientes.ForeColor = Color.White;
            btnCrearClientes.Location = new Point(16, 18);
            btnCrearClientes.Name = "btnCrearClientes";
            btnCrearClientes.RightToLeft = RightToLeft.No;
            btnCrearClientes.Size = new Size(100, 32);
            btnCrearClientes.TabIndex = 1;
            btnCrearClientes.Text = "Crear";
            btnCrearClientes.UseVisualStyleBackColor = false;
            btnCrearClientes.Click += btnCrearClientes_Click;
            // 
            // btnEliminarClientes
            // 
            btnEliminarClientes.BackColor = Color.FromArgb(64, 64, 64);
            btnEliminarClientes.Cursor = Cursors.Hand;
            btnEliminarClientes.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarClientes.ForeColor = Color.White;
            btnEliminarClientes.Location = new Point(275, 18);
            btnEliminarClientes.Name = "btnEliminarClientes";
            btnEliminarClientes.RightToLeft = RightToLeft.No;
            btnEliminarClientes.Size = new Size(100, 32);
            btnEliminarClientes.TabIndex = 3;
            btnEliminarClientes.Text = "Eliminar";
            btnEliminarClientes.UseVisualStyleBackColor = false;
            btnEliminarClientes.Click += btnEliminarClientes_Click;
            // 
            // btnActualizarClientes
            // 
            btnActualizarClientes.BackColor = Color.FromArgb(64, 64, 64);
            btnActualizarClientes.Cursor = Cursors.Hand;
            btnActualizarClientes.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizarClientes.ForeColor = Color.White;
            btnActualizarClientes.Location = new Point(147, 18);
            btnActualizarClientes.Name = "btnActualizarClientes";
            btnActualizarClientes.RightToLeft = RightToLeft.No;
            btnActualizarClientes.Size = new Size(100, 32);
            btnActualizarClientes.TabIndex = 2;
            btnActualizarClientes.Text = "Actualizar";
            btnActualizarClientes.UseVisualStyleBackColor = false;
            btnActualizarClientes.Click += btnActualizarClientes_Click;
            // 
            // iconPictureSalir
            // 
            iconPictureSalir.BackColor = Color.LavenderBlush;
            iconPictureSalir.BackgroundImageLayout = ImageLayout.Center;
            iconPictureSalir.Cursor = Cursors.Hand;
            iconPictureSalir.ForeColor = Color.FromArgb(64, 64, 64);
            iconPictureSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            iconPictureSalir.IconColor = Color.FromArgb(64, 64, 64);
            iconPictureSalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureSalir.IconSize = 39;
            iconPictureSalir.Location = new Point(858, 99);
            iconPictureSalir.Name = "iconPictureSalir";
            iconPictureSalir.Size = new Size(43, 39);
            iconPictureSalir.TabIndex = 17;
            iconPictureSalir.TabStop = false;
            iconPictureSalir.Click += iconPictureSalir_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LavenderBlush;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(txtCorreo);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(txtDireccion);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Enabled = false;
            panel2.Location = new Point(12, 207);
            panel2.Name = "panel2";
            panel2.Size = new Size(889, 268);
            panel2.TabIndex = 10;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 64, 64);
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(737, 266);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(100, 32);
            button5.TabIndex = 22;
            button5.Text = "Limpiar";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(853, 266);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(100, 32);
            button4.TabIndex = 3;
            button4.Text = "Aceptar";
            button4.UseVisualStyleBackColor = false;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTelefono.Location = new Point(101, 182);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(271, 23);
            txtTelefono.TabIndex = 24;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(14, 182);
            label15.Name = "label15";
            label15.Size = new Size(81, 19);
            label15.TabIndex = 20;
            label15.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCorreo.Location = new Point(101, 222);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(271, 23);
            txtCorreo.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(14, 222);
            label14.Name = "label14";
            label14.Size = new Size(69, 19);
            label14.TabIndex = 18;
            label14.Text = "Correo ";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDireccion.Location = new Point(101, 142);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(271, 23);
            txtDireccion.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(14, 142);
            label13.Name = "label13";
            label13.Size = new Size(84, 19);
            label13.TabIndex = 16;
            label13.Text = "Direccion";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(422, 145);
            label10.Name = "label10";
            label10.Size = new Size(84, 19);
            label10.TabIndex = 14;
            label10.Text = "Apellidos";
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(txtSegundoApellido);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(txtPrimerApellido);
            panel7.Location = new Point(413, 158);
            panel7.Name = "panel7";
            panel7.Size = new Size(462, 69);
            panel7.TabIndex = 20;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSegundoApellido.Location = new Point(85, 36);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(359, 23);
            txtSegundoApellido.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(8, 39);
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
            // txtPrimerApellido
            // 
            txtPrimerApellido.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrimerApellido.Location = new Point(85, 7);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(359, 23);
            txtPrimerApellido.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(422, 13);
            label6.Name = "label6";
            label6.Size = new Size(81, 19);
            label6.TabIndex = 13;
            label6.Text = "Nombres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 13);
            label4.Name = "label4";
            label4.Size = new Size(101, 19);
            label4.TabIndex = 11;
            label4.Text = "Documento";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(rbtnPass);
            panel5.Controls.Add(rbtnCEx);
            panel5.Controls.Add(rbtnTi);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(rbtnCC);
            panel5.Controls.Add(txtNumeroDoc);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(14, 26);
            panel5.Name = "panel5";
            panel5.Size = new Size(391, 106);
            panel5.TabIndex = 11;
            // 
            // rbtnPass
            // 
            rbtnPass.AutoSize = true;
            rbtnPass.Location = new Point(323, 62);
            rbtnPass.Name = "rbtnPass";
            rbtnPass.Size = new Size(48, 19);
            rbtnPass.TabIndex = 16;
            rbtnPass.TabStop = true;
            rbtnPass.Text = "Pass";
            rbtnPass.UseVisualStyleBackColor = true;
            // 
            // rbtnCEx
            // 
            rbtnCEx.AutoSize = true;
            rbtnCEx.Location = new Point(258, 62);
            rbtnCEx.Name = "rbtnCEx";
            rbtnCEx.Size = new Size(51, 19);
            rbtnCEx.TabIndex = 15;
            rbtnCEx.TabStop = true;
            rbtnCEx.Text = "C.Ex.";
            rbtnCEx.UseVisualStyleBackColor = true;
            // 
            // rbtnTi
            // 
            rbtnTi.AutoSize = true;
            rbtnTi.Location = new Point(144, 61);
            rbtnTi.Name = "rbtnTi";
            rbtnTi.Size = new Size(37, 19);
            rbtnTi.TabIndex = 13;
            rbtnTi.TabStop = true;
            rbtnTi.Text = "T.I";
            rbtnTi.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(8, 32);
            label7.Name = "label7";
            label7.Size = new Size(56, 16);
            label7.TabIndex = 4;
            label7.Text = "Numero";
            // 
            // rbtnCC
            // 
            rbtnCC.AutoSize = true;
            rbtnCC.Location = new Point(200, 61);
            rbtnCC.Name = "rbtnCC";
            rbtnCC.Size = new Size(47, 19);
            rbtnCC.TabIndex = 14;
            rbtnCC.TabStop = true;
            rbtnCC.Text = "C.C.";
            rbtnCC.UseVisualStyleBackColor = true;
            // 
            // txtNumeroDoc
            // 
            txtNumeroDoc.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumeroDoc.Location = new Point(85, 28);
            txtNumeroDoc.MaxLength = 10;
            txtNumeroDoc.Name = "txtNumeroDoc";
            txtNumeroDoc.Size = new Size(271, 23);
            txtNumeroDoc.TabIndex = 12;
            txtNumeroDoc.KeyPress += txtNumeroDoc_KeyPress;
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
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(txtSegundoNombre);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(txtPrimerNombre);
            panel6.Location = new Point(413, 26);
            panel6.Name = "panel6";
            panel6.Size = new Size(462, 71);
            panel6.TabIndex = 17;
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSegundoNombre.Location = new Point(85, 36);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(359, 23);
            txtSegundoNombre.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(8, 39);
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
            // txtPrimerNombre
            // 
            txtPrimerNombre.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrimerNombre.Location = new Point(85, 7);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(359, 23);
            txtPrimerNombre.TabIndex = 18;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(685, 491);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.RightToLeft = RightToLeft.No;
            btnLimpiar.Size = new Size(100, 32);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnRegistar
            // 
            btnRegistar.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistar.Cursor = Cursors.Hand;
            btnRegistar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistar.ForeColor = Color.White;
            btnRegistar.Location = new Point(801, 491);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.RightToLeft = RightToLeft.No;
            btnRegistar.Size = new Size(100, 32);
            btnRegistar.TabIndex = 23;
            btnRegistar.Text = "Aceptar";
            btnRegistar.UseVisualStyleBackColor = false;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // dtgvEncontrados
            // 
            dtgvEncontrados.BackgroundColor = Color.LavenderBlush;
            dtgvEncontrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvEncontrados.Location = new Point(5, 92);
            dtgvEncontrados.Name = "dtgvEncontrados";
            dtgvEncontrados.RowTemplate.Height = 25;
            dtgvEncontrados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvEncontrados.Size = new Size(427, 86);
            dtgvEncontrados.TabIndex = 9;
            dtgvEncontrados.CellContentClick += dtgvEncontrados_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(dtgvEncontrados);
            panel1.Enabled = false;
            panel1.Location = new Point(9, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 184);
            panel1.TabIndex = 4;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.FromArgb(64, 64, 64);
            btnGuardarCambios.Cursor = Cursors.Hand;
            btnGuardarCambios.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarCambios.ForeColor = Color.White;
            btnGuardarCambios.Location = new Point(801, 485);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.RightToLeft = RightToLeft.No;
            btnGuardarCambios.Size = new Size(100, 44);
            btnGuardarCambios.TabIndex = 24;
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
            btnEliminarRegistro.Location = new Point(791, 485);
            btnEliminarRegistro.Name = "btnEliminarRegistro";
            btnEliminarRegistro.RightToLeft = RightToLeft.No;
            btnEliminarRegistro.Size = new Size(115, 44);
            btnEliminarRegistro.TabIndex = 25;
            btnEliminarRegistro.Text = "Eliminar Registro";
            btnEliminarRegistro.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEliminarRegistro.UseVisualStyleBackColor = false;
            btnEliminarRegistro.Click += btnEliminarRegistro_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(909, 581);
            Controls.Add(panel1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistar);
            Controls.Add(panel2);
            Controls.Add(iconPictureSalir);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(btnGuardarCambios);
            Controls.Add(btnEliminarRegistro);
            Name = "FormClientes";
            Text = "Control_Inventario [Clientes]";
            Load += FormClientes_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureSalir).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvEncontrados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButtonBuscarClientes;
        private RadioButton rbtnBuscarId;
        private Label label2;
        private RadioButton rbtnBuscarNombre;
        private TextBox txtBuscarClientes;
        private Label label3;
        private Label label20;
        private Label label1;
        private Panel panel4;
        private Button btnCrearClientes;
        private Button btnEliminarClientes;
        private Button btnActualizarClientes;
        private FontAwesome.Sharp.IconPictureBox iconPictureSalir;
        private Panel panel2;
        private Button button5;
        private Button button4;
        private TextBox txtTelefono;
        private Label label15;
        private TextBox txtCorreo;
        private Label label14;
        private TextBox txtDireccion;
        private Label label13;
        private Label label10;
        private Panel panel7;
        private TextBox txtSegundoApellido;
        private Label label11;
        private Label label12;
        private TextBox txtPrimerApellido;
        private Label label6;
        private Label label4;
        private Panel panel5;
        private RadioButton rbtnPass;
        private RadioButton rbtnCEx;
        private RadioButton rbtnTi;
        private Label label7;
        private RadioButton rbtnCC;
        private TextBox txtNumeroDoc;
        private Label label8;
        private Panel panel6;
        private TextBox txtSegundoNombre;
        private Label label9;
        private Label label5;
        private TextBox txtPrimerNombre;
        private Button btnLimpiar;
        private Button btnRegistar;
        private DataGridView dtgvEncontrados;
        private Panel panel1;
        private Button btnGuardarCambios;
        private Button btnEliminarRegistro;
        private ErrorProvider errorProvider1;
    }
}