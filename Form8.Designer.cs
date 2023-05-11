namespace Control_Inventario
{
    partial class FormProveedores
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
            panel3 = new Panel();
            iconButtonBuscarProveedor = new FontAwesome.Sharp.IconButton();
            rbtnBuscarId = new RadioButton();
            label2 = new Label();
            rbtnBuscarNombre = new RadioButton();
            txtBuscarProveedor = new TextBox();
            label3 = new Label();
            dtvEncontrados = new DataGridView();
            iconSalir = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            panel4 = new Panel();
            btnCrearProveedor = new Button();
            btnEliminarProveedor = new Button();
            btnActualizarProveedor = new Button();
            panel2 = new Panel();
            txtNombreProveedor = new TextBox();
            txtTelefonoProveedor = new TextBox();
            label15 = new Label();
            txtCorreoProveedor = new TextBox();
            label14 = new Label();
            txtDireccionProveedor = new TextBox();
            label13 = new Label();
            label6 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            rbtnNitProveedor = new RadioButton();
            label7 = new Label();
            rbtnCCProveedor = new RadioButton();
            txtIdProveedor = new TextBox();
            label8 = new Label();
            btnLimpiarCampos = new Button();
            btnRegistrar = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnGuardarCambiosProveedores = new Button();
            btnEliminarRegistroProveedores = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvEncontrados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconSalir).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(label20);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dtvEncontrados);
            panel1.Enabled = false;
            panel1.Location = new Point(2, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 199);
            panel1.TabIndex = 5;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(10, 79);
            label20.Name = "label20";
            label20.Size = new Size(84, 14);
            label20.TabIndex = 11;
            label20.Text = "Encontrados";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(iconButtonBuscarProveedor);
            panel3.Controls.Add(rbtnBuscarId);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(rbtnBuscarNombre);
            panel3.Controls.Add(txtBuscarProveedor);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(444, 75);
            panel3.TabIndex = 5;
            // 
            // iconButtonBuscarProveedor
            // 
            iconButtonBuscarProveedor.BackColor = Color.FromArgb(64, 64, 64);
            iconButtonBuscarProveedor.Cursor = Cursors.Hand;
            iconButtonBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButtonBuscarProveedor.IconColor = Color.White;
            iconButtonBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonBuscarProveedor.IconSize = 30;
            iconButtonBuscarProveedor.Location = new Point(384, 11);
            iconButtonBuscarProveedor.Name = "iconButtonBuscarProveedor";
            iconButtonBuscarProveedor.Size = new Size(51, 45);
            iconButtonBuscarProveedor.TabIndex = 8;
            iconButtonBuscarProveedor.UseVisualStyleBackColor = false;
            iconButtonBuscarProveedor.Click += iconButtonBuscarProveedor_Click;
            // 
            // rbtnBuscarId
            // 
            rbtnBuscarId.AutoSize = true;
            rbtnBuscarId.Location = new Point(157, 41);
            rbtnBuscarId.Name = "rbtnBuscarId";
            rbtnBuscarId.Size = new Size(35, 19);
            rbtnBuscarId.TabIndex = 7;
            rbtnBuscarId.TabStop = true;
            rbtnBuscarId.Text = "Id";
            rbtnBuscarId.UseVisualStyleBackColor = true;
            rbtnBuscarId.Click += rbtnBuscarId_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 11);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 4;
            label2.Text = "Proveedor";
            // 
            // rbtnBuscarNombre
            // 
            rbtnBuscarNombre.AutoSize = true;
            rbtnBuscarNombre.Location = new Point(259, 41);
            rbtnBuscarNombre.Name = "rbtnBuscarNombre";
            rbtnBuscarNombre.Size = new Size(69, 19);
            rbtnBuscarNombre.TabIndex = 8;
            rbtnBuscarNombre.TabStop = true;
            rbtnBuscarNombre.Text = "Nombre";
            rbtnBuscarNombre.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProveedor
            // 
            txtBuscarProveedor.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBuscarProveedor.Location = new Point(107, 11);
            txtBuscarProveedor.Name = "txtBuscarProveedor";
            txtBuscarProveedor.Size = new Size(271, 23);
            txtBuscarProveedor.TabIndex = 6;
            txtBuscarProveedor.KeyPress += txtBuscarProveedor_KeyPress;
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
            // dtvEncontrados
            // 
            dtvEncontrados.BackgroundColor = Color.LavenderBlush;
            dtvEncontrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvEncontrados.Location = new Point(3, 84);
            dtvEncontrados.Name = "dtvEncontrados";
            dtvEncontrados.RowTemplate.Height = 25;
            dtvEncontrados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvEncontrados.Size = new Size(444, 112);
            dtvEncontrados.TabIndex = 9;
            dtvEncontrados.CellClick += dtvEncontrados_CellClick;
            // 
            // iconSalir
            // 
            iconSalir.BackColor = Color.LavenderBlush;
            iconSalir.BackgroundImageLayout = ImageLayout.Center;
            iconSalir.Cursor = Cursors.Hand;
            iconSalir.ForeColor = Color.FromArgb(64, 64, 64);
            iconSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            iconSalir.IconColor = Color.FromArgb(64, 64, 64);
            iconSalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconSalir.IconSize = 39;
            iconSalir.Location = new Point(872, 114);
            iconSalir.Name = "iconSalir";
            iconSalir.Size = new Size(43, 39);
            iconSalir.TabIndex = 13;
            iconSalir.TabStop = false;
            iconSalir.Click += iconSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(502, 86);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 3;
            label1.Text = "PROVEEDOR";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(btnCrearProveedor);
            panel4.Controls.Add(btnEliminarProveedor);
            panel4.Controls.Add(btnActualizarProveedor);
            panel4.Location = new Point(492, 97);
            panel4.Name = "panel4";
            panel4.Size = new Size(374, 78);
            panel4.TabIndex = 0;
            // 
            // btnCrearProveedor
            // 
            btnCrearProveedor.BackColor = Color.FromArgb(64, 64, 64);
            btnCrearProveedor.Cursor = Cursors.Hand;
            btnCrearProveedor.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearProveedor.ForeColor = Color.White;
            btnCrearProveedor.Location = new Point(13, 18);
            btnCrearProveedor.Name = "btnCrearProveedor";
            btnCrearProveedor.RightToLeft = RightToLeft.No;
            btnCrearProveedor.Size = new Size(100, 32);
            btnCrearProveedor.TabIndex = 1;
            btnCrearProveedor.Text = "Crear";
            btnCrearProveedor.UseVisualStyleBackColor = false;
            btnCrearProveedor.Click += btnCrearProveedor_Click;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.BackColor = Color.FromArgb(64, 64, 64);
            btnEliminarProveedor.Cursor = Cursors.Hand;
            btnEliminarProveedor.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarProveedor.ForeColor = Color.White;
            btnEliminarProveedor.Location = new Point(257, 18);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.RightToLeft = RightToLeft.No;
            btnEliminarProveedor.Size = new Size(100, 32);
            btnEliminarProveedor.TabIndex = 3;
            btnEliminarProveedor.Text = "Eliminar";
            btnEliminarProveedor.UseVisualStyleBackColor = false;
            btnEliminarProveedor.Click += btnEliminarProveedor_Click;
            // 
            // btnActualizarProveedor
            // 
            btnActualizarProveedor.BackColor = Color.FromArgb(64, 64, 64);
            btnActualizarProveedor.Cursor = Cursors.Hand;
            btnActualizarProveedor.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizarProveedor.ForeColor = Color.White;
            btnActualizarProveedor.Location = new Point(133, 18);
            btnActualizarProveedor.Name = "btnActualizarProveedor";
            btnActualizarProveedor.RightToLeft = RightToLeft.No;
            btnActualizarProveedor.Size = new Size(100, 32);
            btnActualizarProveedor.TabIndex = 2;
            btnActualizarProveedor.Text = "Actualizar";
            btnActualizarProveedor.UseVisualStyleBackColor = false;
            btnActualizarProveedor.Click += btnActualizarProveedor_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LavenderBlush;
            panel2.Controls.Add(txtNombreProveedor);
            panel2.Controls.Add(txtTelefonoProveedor);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(txtCorreoProveedor);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(txtDireccionProveedor);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel5);
            panel2.Enabled = false;
            panel2.Location = new Point(2, 253);
            panel2.Name = "panel2";
            panel2.Size = new Size(904, 233);
            panel2.TabIndex = 10;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombreProveedor.Location = new Point(500, 47);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(376, 23);
            txtNombreProveedor.TabIndex = 15;
            // 
            // txtTelefonoProveedor
            // 
            txtTelefonoProveedor.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTelefonoProveedor.Location = new Point(500, 139);
            txtTelefonoProveedor.MaxLength = 10;
            txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            txtTelefonoProveedor.Size = new Size(376, 23);
            txtTelefonoProveedor.TabIndex = 17;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(413, 139);
            label15.Name = "label15";
            label15.Size = new Size(81, 19);
            label15.TabIndex = 20;
            label15.Text = "Telefono";
            // 
            // txtCorreoProveedor
            // 
            txtCorreoProveedor.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCorreoProveedor.Location = new Point(500, 184);
            txtCorreoProveedor.Name = "txtCorreoProveedor";
            txtCorreoProveedor.Size = new Size(376, 23);
            txtCorreoProveedor.TabIndex = 18;
            txtCorreoProveedor.Leave += txtCorreoProveedor_Leave;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(413, 184);
            label14.Name = "label14";
            label14.Size = new Size(69, 19);
            label14.TabIndex = 18;
            label14.Text = "Correo ";
            // 
            // txtDireccionProveedor
            // 
            txtDireccionProveedor.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDireccionProveedor.Location = new Point(500, 90);
            txtDireccionProveedor.Name = "txtDireccionProveedor";
            txtDireccionProveedor.Size = new Size(376, 23);
            txtDireccionProveedor.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(413, 90);
            label13.Name = "label13";
            label13.Size = new Size(84, 19);
            label13.TabIndex = 16;
            label13.Text = "Direccion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(413, 51);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 13;
            label6.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 60);
            label4.Name = "label4";
            label4.Size = new Size(26, 19);
            label4.TabIndex = 11;
            label4.Text = "Id";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(rbtnNitProveedor);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(rbtnCCProveedor);
            panel5.Controls.Add(txtIdProveedor);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(3, 71);
            panel5.Name = "panel5";
            panel5.Size = new Size(391, 106);
            panel5.TabIndex = 11;
            // 
            // rbtnNitProveedor
            // 
            rbtnNitProveedor.AutoSize = true;
            rbtnNitProveedor.Location = new Point(150, 61);
            rbtnNitProveedor.Name = "rbtnNitProveedor";
            rbtnNitProveedor.Size = new Size(43, 19);
            rbtnNitProveedor.TabIndex = 13;
            rbtnNitProveedor.TabStop = true;
            rbtnNitProveedor.Text = "NIT";
            rbtnNitProveedor.UseVisualStyleBackColor = true;
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
            // rbtnCCProveedor
            // 
            rbtnCCProveedor.AutoSize = true;
            rbtnCCProveedor.Location = new Point(274, 62);
            rbtnCCProveedor.Name = "rbtnCCProveedor";
            rbtnCCProveedor.Size = new Size(47, 19);
            rbtnCCProveedor.TabIndex = 14;
            rbtnCCProveedor.TabStop = true;
            rbtnCCProveedor.Text = "C.C.";
            rbtnCCProveedor.UseVisualStyleBackColor = true;
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdProveedor.Location = new Point(85, 28);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(271, 23);
            txtIdProveedor.TabIndex = 12;
            txtIdProveedor.KeyPress += txtIdProveedor_KeyPress;
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
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = Color.FromArgb(64, 64, 64);
            btnLimpiarCampos.Cursor = Cursors.Hand;
            btnLimpiarCampos.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiarCampos.ForeColor = Color.White;
            btnLimpiarCampos.Location = new Point(673, 492);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.RightToLeft = RightToLeft.No;
            btnLimpiarCampos.Size = new Size(100, 32);
            btnLimpiarCampos.TabIndex = 19;
            btnLimpiarCampos.Text = "Limpiar";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(799, 492);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.RightToLeft = RightToLeft.No;
            btnRegistrar.Size = new Size(100, 32);
            btnRegistrar.TabIndex = 20;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnGuardarCambiosProveedores
            // 
            btnGuardarCambiosProveedores.BackColor = Color.FromArgb(64, 64, 64);
            btnGuardarCambiosProveedores.Cursor = Cursors.Hand;
            btnGuardarCambiosProveedores.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarCambiosProveedores.ForeColor = Color.White;
            btnGuardarCambiosProveedores.Location = new Point(799, 486);
            btnGuardarCambiosProveedores.Name = "btnGuardarCambiosProveedores";
            btnGuardarCambiosProveedores.RightToLeft = RightToLeft.No;
            btnGuardarCambiosProveedores.Size = new Size(100, 44);
            btnGuardarCambiosProveedores.TabIndex = 31;
            btnGuardarCambiosProveedores.Text = "Guardar Cambios";
            btnGuardarCambiosProveedores.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardarCambiosProveedores.UseVisualStyleBackColor = false;
            btnGuardarCambiosProveedores.Click += btnGuardarCambiosProveedores_Click;
            // 
            // btnEliminarRegistroProveedores
            // 
            btnEliminarRegistroProveedores.BackColor = Color.Red;
            btnEliminarRegistroProveedores.Cursor = Cursors.Hand;
            btnEliminarRegistroProveedores.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarRegistroProveedores.ForeColor = Color.White;
            btnEliminarRegistroProveedores.Location = new Point(791, 486);
            btnEliminarRegistroProveedores.Name = "btnEliminarRegistroProveedores";
            btnEliminarRegistroProveedores.RightToLeft = RightToLeft.No;
            btnEliminarRegistroProveedores.Size = new Size(115, 44);
            btnEliminarRegistroProveedores.TabIndex = 32;
            btnEliminarRegistroProveedores.Text = "Eliminar Registro";
            btnEliminarRegistroProveedores.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEliminarRegistroProveedores.UseVisualStyleBackColor = false;
            btnEliminarRegistroProveedores.Click += btnEliminarRegistroProveedores_Click;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(909, 581);
            Controls.Add(btnRegistrar);
            Controls.Add(label1);
            Controls.Add(iconSalir);
            Controls.Add(btnLimpiarCampos);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnGuardarCambiosProveedores);
            Controls.Add(btnEliminarRegistroProveedores);
            Name = "FormProveedores";
            Text = "Control_Inventario [Proveedores]";
            Load += FormProveedores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtvEncontrados).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconSalir).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label20;
        private FontAwesome.Sharp.IconPictureBox iconSalir;
        private Label label1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButtonBuscarProveedor;
        private RadioButton rbtnBuscarId;
        private Label label2;
        private RadioButton rbtnBuscarNombre;
        private TextBox txtBuscarProveedor;
        private Label label3;
        private Panel panel4;
        private Button btnCrearProveedor;
        private Button btnEliminarProveedor;
        private Button btnActualizarProveedor;
        private Panel panel2;
        private Button btnLimpiarCampos;
        private Button btnRegistrar;
        private TextBox txtTelefonoProveedor;
        private Label label15;
        private TextBox txtCorreoProveedor;
        private Label label14;
        private TextBox txtDireccionProveedor;
        private Label label13;
        private Label label6;
        private Label label4;
        private Panel panel5;
        private Label label7;
        private TextBox txtIdProveedor;
        private RadioButton rbtnNitProveedor;
        private RadioButton rbtnCCProveedor;
        private Label label8;
        private TextBox txtNombreProveedor;
        private DataGridView dtvEncontrados;
        public Panel panel1;
        private ErrorProvider errorProvider1;
        private Button btnGuardarCambiosProveedores;
        private Button btnEliminarRegistroProveedores;
    }
}