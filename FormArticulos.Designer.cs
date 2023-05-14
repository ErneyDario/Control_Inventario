namespace Control_Inventario
{
    partial class FormArticulos
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
            panel4 = new Panel();
            iconButtonSalir = new FontAwesome.Sharp.IconButton();
            iButtonSalir = new FontAwesome.Sharp.IconButton();
            btnCrearArticulo = new Button();
            btnEliminarArticulo = new Button();
            btnActualizarArticulo = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label20 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            iBtnBuscarArticulo = new FontAwesome.Sharp.IconButton();
            rbtnCodigo = new RadioButton();
            label2 = new Label();
            rbtnNombre = new RadioButton();
            txtBuscarArticulo = new TextBox();
            label3 = new Label();
            dtgvArticulosEncontrados = new DataGridView();
            panel2 = new Panel();
            txtDescripcion = new TextBox();
            txtArticulo = new TextBox();
            txtcodigo = new TextBox();
            label9 = new Label();
            label17 = new Label();
            label16 = new Label();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnGuardarCambios = new Button();
            btnEliminarRegistro = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvArticulosEncontrados).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(iconButtonSalir);
            panel4.Controls.Add(iButtonSalir);
            panel4.Controls.Add(btnCrearArticulo);
            panel4.Controls.Add(btnEliminarArticulo);
            panel4.Controls.Add(btnActualizarArticulo);
            panel4.Location = new Point(424, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(118, 312);
            panel4.TabIndex = 1;
            // 
            // iconButtonSalir
            // 
            iconButtonSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButtonSalir.BackColor = Color.FromArgb(64, 64, 64);
            iconButtonSalir.Cursor = Cursors.Hand;
            iconButtonSalir.DialogResult = DialogResult.OK;
            iconButtonSalir.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButtonSalir.ForeColor = Color.White;
            iconButtonSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            iconButtonSalir.IconColor = Color.White;
            iconButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSalir.IconSize = 20;
            iconButtonSalir.ImageAlign = ContentAlignment.BottomRight;
            iconButtonSalir.Location = new Point(6, 262);
            iconButtonSalir.Name = "iconButtonSalir";
            iconButtonSalir.RightToLeft = RightToLeft.Yes;
            iconButtonSalir.Size = new Size(100, 32);
            iconButtonSalir.TabIndex = 14;
            iconButtonSalir.Text = "Salir";
            iconButtonSalir.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonSalir.UseVisualStyleBackColor = false;
            iconButtonSalir.Click += iconButtonSalir_Click;
            // 
            // iButtonSalir
            // 
            iButtonSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iButtonSalir.BackColor = Color.FromArgb(64, 64, 64);
            iButtonSalir.Cursor = Cursors.Hand;
            iButtonSalir.DialogResult = DialogResult.OK;
            iButtonSalir.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iButtonSalir.ForeColor = Color.White;
            iButtonSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            iButtonSalir.IconColor = Color.White;
            iButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iButtonSalir.IconSize = 20;
            iButtonSalir.ImageAlign = ContentAlignment.BottomRight;
            iButtonSalir.Location = new Point(258, 18);
            iButtonSalir.Name = "iButtonSalir";
            iButtonSalir.RightToLeft = RightToLeft.Yes;
            iButtonSalir.Size = new Size(87, 32);
            iButtonSalir.TabIndex = 13;
            iButtonSalir.Text = "Salir";
            iButtonSalir.TextAlign = ContentAlignment.MiddleLeft;
            iButtonSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            iButtonSalir.UseVisualStyleBackColor = false;
            // 
            // btnCrearArticulo
            // 
            btnCrearArticulo.BackColor = Color.FromArgb(64, 64, 64);
            btnCrearArticulo.Cursor = Cursors.Hand;
            btnCrearArticulo.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearArticulo.ForeColor = Color.White;
            btnCrearArticulo.Location = new Point(6, 19);
            btnCrearArticulo.Name = "btnCrearArticulo";
            btnCrearArticulo.RightToLeft = RightToLeft.No;
            btnCrearArticulo.Size = new Size(100, 32);
            btnCrearArticulo.TabIndex = 1;
            btnCrearArticulo.Text = "Crear";
            btnCrearArticulo.UseVisualStyleBackColor = false;
            btnCrearArticulo.Click += btnCrearArticulo_Click;
            // 
            // btnEliminarArticulo
            // 
            btnEliminarArticulo.BackColor = Color.FromArgb(64, 64, 64);
            btnEliminarArticulo.Cursor = Cursors.Hand;
            btnEliminarArticulo.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarArticulo.ForeColor = Color.White;
            btnEliminarArticulo.Location = new Point(6, 180);
            btnEliminarArticulo.Name = "btnEliminarArticulo";
            btnEliminarArticulo.RightToLeft = RightToLeft.No;
            btnEliminarArticulo.Size = new Size(100, 32);
            btnEliminarArticulo.TabIndex = 3;
            btnEliminarArticulo.Text = "Eliminar";
            btnEliminarArticulo.UseVisualStyleBackColor = false;
            btnEliminarArticulo.Click += btnEliminarArticulo_Click;
            // 
            // btnActualizarArticulo
            // 
            btnActualizarArticulo.BackColor = Color.FromArgb(64, 64, 64);
            btnActualizarArticulo.Cursor = Cursors.Hand;
            btnActualizarArticulo.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizarArticulo.ForeColor = Color.White;
            btnActualizarArticulo.Location = new Point(6, 101);
            btnActualizarArticulo.Name = "btnActualizarArticulo";
            btnActualizarArticulo.RightToLeft = RightToLeft.No;
            btnActualizarArticulo.Size = new Size(100, 32);
            btnActualizarArticulo.TabIndex = 2;
            btnActualizarArticulo.Text = "Actualizar";
            btnActualizarArticulo.UseVisualStyleBackColor = false;
            btnActualizarArticulo.Click += btnActualizarArticulo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(33, 1);
            label1.Name = "label1";
            label1.Size = new Size(105, 19);
            label1.TabIndex = 5;
            label1.Text = "ARTICULOS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(label20);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dtgvArticulosEncontrados);
            panel1.Enabled = false;
            panel1.Location = new Point(21, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 157);
            panel1.TabIndex = 6;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(22, 78);
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
            panel3.Controls.Add(iBtnBuscarArticulo);
            panel3.Controls.Add(rbtnCodigo);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(rbtnNombre);
            panel3.Controls.Add(txtBuscarArticulo);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(377, 67);
            panel3.TabIndex = 5;
            // 
            // iBtnBuscarArticulo
            // 
            iBtnBuscarArticulo.BackColor = Color.FromArgb(64, 64, 64);
            iBtnBuscarArticulo.Cursor = Cursors.Hand;
            iBtnBuscarArticulo.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iBtnBuscarArticulo.IconColor = Color.White;
            iBtnBuscarArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iBtnBuscarArticulo.IconSize = 15;
            iBtnBuscarArticulo.Location = new Point(315, 8);
            iBtnBuscarArticulo.Name = "iBtnBuscarArticulo";
            iBtnBuscarArticulo.Size = new Size(41, 41);
            iBtnBuscarArticulo.TabIndex = 9;
            iBtnBuscarArticulo.UseVisualStyleBackColor = false;
            iBtnBuscarArticulo.Click += iBtnBuscarArticulo_Click;
            // 
            // rbtnCodigo
            // 
            rbtnCodigo.AutoSize = true;
            rbtnCodigo.Location = new Point(91, 38);
            rbtnCodigo.Name = "rbtnCodigo";
            rbtnCodigo.Size = new Size(35, 19);
            rbtnCodigo.TabIndex = 6;
            rbtnCodigo.TabStop = true;
            rbtnCodigo.Text = "Id";
            rbtnCodigo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 11);
            label2.Name = "label2";
            label2.Size = new Size(55, 14);
            label2.TabIndex = 4;
            label2.Text = "Articulo";
            // 
            // rbtnNombre
            // 
            rbtnNombre.AutoSize = true;
            rbtnNombre.Location = new Point(166, 37);
            rbtnNombre.Name = "rbtnNombre";
            rbtnNombre.Size = new Size(74, 19);
            rbtnNombre.TabIndex = 8;
            rbtnNombre.TabStop = true;
            rbtnNombre.Text = "Nombres";
            rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // txtBuscarArticulo
            // 
            txtBuscarArticulo.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtBuscarArticulo.Location = new Point(66, 8);
            txtBuscarArticulo.Name = "txtBuscarArticulo";
            txtBuscarArticulo.Size = new Size(240, 22);
            txtBuscarArticulo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 39);
            label3.Name = "label3";
            label3.Size = new Size(76, 14);
            label3.TabIndex = 6;
            label3.Text = "Buscar por:";
            // 
            // dtgvArticulosEncontrados
            // 
            dtgvArticulosEncontrados.BackgroundColor = Color.LavenderBlush;
            dtgvArticulosEncontrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvArticulosEncontrados.Location = new Point(12, 84);
            dtgvArticulosEncontrados.Name = "dtgvArticulosEncontrados";
            dtgvArticulosEncontrados.ReadOnly = true;
            dtgvArticulosEncontrados.RowTemplate.Height = 25;
            dtgvArticulosEncontrados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvArticulosEncontrados.Size = new Size(377, 70);
            dtgvArticulosEncontrados.TabIndex = 9;
            dtgvArticulosEncontrados.CellContentClick += dtgvArticulosEncontrados_CellContentClick;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtDescripcion);
            panel2.Controls.Add(txtArticulo);
            panel2.Controls.Add(txtcodigo);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label16);
            panel2.Enabled = false;
            panel2.Location = new Point(21, 175);
            panel2.Name = "panel2";
            panel2.Size = new Size(397, 102);
            panel2.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = SystemColors.Window;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(101, 65);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(287, 23);
            txtDescripcion.TabIndex = 7;
            // 
            // txtArticulo
            // 
            txtArticulo.BackColor = SystemColors.Window;
            txtArticulo.BorderStyle = BorderStyle.FixedSingle;
            txtArticulo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtArticulo.Location = new Point(101, 37);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.Size = new Size(287, 23);
            txtArticulo.TabIndex = 11;
            // 
            // txtcodigo
            // 
            txtcodigo.BackColor = SystemColors.Window;
            txtcodigo.BorderStyle = BorderStyle.FixedSingle;
            txtcodigo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtcodigo.Location = new Point(101, 8);
            txtcodigo.MaxLength = 20;
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(162, 23);
            txtcodigo.TabIndex = 10;
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
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(2, 71);
            label17.Name = "label17";
            label17.Size = new Size(81, 16);
            label17.TabIndex = 12;
            label17.Text = "Descripción";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(25, 43);
            label16.Name = "label16";
            label16.Size = new Size(58, 16);
            label16.TabIndex = 10;
            label16.Text = "Articulo";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(64, 64, 64);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(311, 286);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.RightToLeft = RightToLeft.No;
            btnRegistrar.Size = new Size(100, 32);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(197, 286);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.RightToLeft = RightToLeft.No;
            btnLimpiar.Size = new Size(100, 32);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.FromArgb(64, 64, 64);
            btnGuardarCambios.Cursor = Cursors.Hand;
            btnGuardarCambios.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarCambios.ForeColor = Color.White;
            btnGuardarCambios.Location = new Point(311, 280);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.RightToLeft = RightToLeft.No;
            btnGuardarCambios.Size = new Size(100, 44);
            btnGuardarCambios.TabIndex = 31;
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
            btnEliminarRegistro.Location = new Point(303, 280);
            btnEliminarRegistro.Name = "btnEliminarRegistro";
            btnEliminarRegistro.RightToLeft = RightToLeft.No;
            btnEliminarRegistro.Size = new Size(115, 44);
            btnEliminarRegistro.TabIndex = 32;
            btnEliminarRegistro.Text = "Eliminar Registro";
            btnEliminarRegistro.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEliminarRegistro.UseVisualStyleBackColor = false;
            btnEliminarRegistro.Click += btnEliminarRegistro_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(558, 332);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(btnGuardarCambios);
            Controls.Add(btnEliminarRegistro);
            Name = "FormArticulos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormArticulos";
            Load += FormArticulos_Load;
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvArticulosEncontrados).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private FontAwesome.Sharp.IconButton iButtonSalir;
        private Button btnCrearArticulo;
        private Button btnEliminarArticulo;
        private Button btnActualizarArticulo;
        private FontAwesome.Sharp.IconButton iconButtonSalir;
        private Label label1;
        private Panel panel1;
        private Label label20;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iBtnBuscarArticulo;
        private RadioButton rbtnCodigo;
        private Label label2;
        private RadioButton rbtnNombre;
        private TextBox txtBuscarArticulo;
        private Label label3;
        private DataGridView dtgvArticulosEncontrados;
        private Panel panel2;
        private TextBox txtDescripcion;
        private TextBox txtArticulo;
        private TextBox txtcodigo;
        private Label label9;
        private Label label17;
        private Label label16;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnGuardarCambios;
        private Button btnEliminarRegistro;
        private ErrorProvider errorProvider1;
    }
}