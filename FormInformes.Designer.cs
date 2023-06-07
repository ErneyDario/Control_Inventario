namespace Control_Inventario
{
    partial class FormInformes
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
            dtgvInformes = new DataGridView();
            btnUsuarios = new Button();
            btnProveedores = new Button();
            btnClientes = new Button();
            btnInventario = new Button();
            btnVentas = new Button();
            btnStock = new Button();
            label2 = new Label();
            txtBuscar = new TextBox();
            dTPInicio = new DateTimePicker();
            dTPFin = new DateTimePicker();
            pFecha = new Panel();
            label4 = new Label();
            label1 = new Label();
            rbtFecha = new RadioButton();
            cmbTipo = new ComboBox();
            label3 = new Label();
            iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            iconPictureBoxSalir = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgvInformes).BeginInit();
            pFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBoxSalir).BeginInit();
            SuspendLayout();
            // 
            // dtgvInformes
            // 
            dtgvInformes.BackgroundColor = Color.LavenderBlush;
            dtgvInformes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvInformes.Location = new Point(12, 141);
            dtgvInformes.Name = "dtgvInformes";
            dtgvInformes.RowTemplate.Height = 25;
            dtgvInformes.Size = new Size(878, 422);
            dtgvInformes.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(64, 64, 64);
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(12, 4);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.RightToLeft = RightToLeft.No;
            btnUsuarios.Size = new Size(88, 48);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Ver Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = Color.FromArgb(64, 64, 64);
            btnProveedores.Cursor = Cursors.Hand;
            btnProveedores.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Location = new Point(149, 4);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.RightToLeft = RightToLeft.No;
            btnProveedores.Size = new Size(92, 48);
            btnProveedores.TabIndex = 3;
            btnProveedores.Text = "Ver Proveedores";
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(64, 64, 64);
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(286, 4);
            btnClientes.Name = "btnClientes";
            btnClientes.RightToLeft = RightToLeft.No;
            btnClientes.Size = new Size(95, 48);
            btnClientes.TabIndex = 4;
            btnClientes.Text = "Ver Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.FromArgb(64, 64, 64);
            btnInventario.Cursor = Cursors.Hand;
            btnInventario.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInventario.ForeColor = Color.White;
            btnInventario.Location = new Point(422, 4);
            btnInventario.Name = "btnInventario";
            btnInventario.RightToLeft = RightToLeft.No;
            btnInventario.Size = new Size(92, 48);
            btnInventario.TabIndex = 5;
            btnInventario.Text = "Ver Compras";
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(64, 64, 64);
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(558, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.RightToLeft = RightToLeft.No;
            btnVentas.Size = new Size(92, 48);
            btnVentas.TabIndex = 6;
            btnVentas.Text = "Ver Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.FromArgb(64, 64, 64);
            btnStock.Cursor = Cursors.Hand;
            btnStock.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStock.ForeColor = Color.White;
            btnStock.Location = new Point(698, 4);
            btnStock.Name = "btnStock";
            btnStock.RightToLeft = RightToLeft.No;
            btnStock.Size = new Size(92, 48);
            btnStock.TabIndex = 7;
            btnStock.Text = "Ver Inventario";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 101);
            label2.Name = "label2";
            label2.Size = new Size(47, 14);
            label2.TabIndex = 8;
            label2.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.LavenderBlush;
            txtBuscar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBuscar.Location = new Point(35, 112);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.ReadOnly = true;
            txtBuscar.Size = new Size(271, 23);
            txtBuscar.TabIndex = 9;
            // 
            // dTPInicio
            // 
            dTPInicio.CalendarMonthBackground = Color.LavenderBlush;
            dTPInicio.CalendarTitleBackColor = SystemColors.ControlText;
            dTPInicio.CalendarTitleForeColor = Color.LavenderBlush;
            dTPInicio.Format = DateTimePickerFormat.Short;
            dTPInicio.Location = new Point(69, 5);
            dTPInicio.Name = "dTPInicio";
            dTPInicio.Size = new Size(102, 23);
            dTPInicio.TabIndex = 10;
            dTPInicio.Value = new DateTime(2023, 5, 28, 0, 0, 0, 0);
            // 
            // dTPFin
            // 
            dTPFin.CalendarMonthBackground = Color.LavenderBlush;
            dTPFin.CalendarTitleBackColor = SystemColors.ControlText;
            dTPFin.CalendarTitleForeColor = Color.LavenderBlush;
            dTPFin.Format = DateTimePickerFormat.Short;
            dTPFin.Location = new Point(69, 30);
            dTPFin.Name = "dTPFin";
            dTPFin.Size = new Size(102, 23);
            dTPFin.TabIndex = 11;
            dTPFin.Value = new DateTime(2023, 6, 3, 14, 30, 4, 0);
            // 
            // pFecha
            // 
            pFecha.Controls.Add(label4);
            pFecha.Controls.Add(label1);
            pFecha.Controls.Add(dTPFin);
            pFecha.Controls.Add(dTPInicio);
            pFecha.Location = new Point(328, 81);
            pFecha.Name = "pFecha";
            pFecha.Size = new Size(186, 54);
            pFecha.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 36);
            label4.Name = "label4";
            label4.Size = new Size(42, 14);
            label4.TabIndex = 18;
            label4.Text = "Hasta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 14);
            label1.TabIndex = 17;
            label1.Text = "Desde";
            // 
            // rbtFecha
            // 
            rbtFecha.AutoSize = true;
            rbtFecha.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbtFecha.Location = new Point(328, 62);
            rbtFecha.Name = "rbtFecha";
            rbtFecha.RightToLeft = RightToLeft.Yes;
            rbtFecha.Size = new Size(100, 18);
            rbtFecha.TabIndex = 19;
            rbtFecha.TabStop = true;
            rbtFecha.Text = "Incluir fecha";
            rbtFecha.UseVisualStyleBackColor = true;
            rbtFecha.CheckedChanged += rbtFecha_CheckedChanged;
            // 
            // cmbTipo
            // 
            cmbTipo.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(35, 76);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(271, 22);
            cmbTipo.TabIndex = 14;
            cmbTipo.Text = "Seleccione";
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 64);
            label3.Name = "label3";
            label3.Size = new Size(116, 14);
            label3.TabIndex = 15;
            label3.Text = "Tipo de Busqueda";
            // 
            // iconButtonBuscar
            // 
            iconButtonBuscar.BackColor = Color.FromArgb(64, 64, 64);
            iconButtonBuscar.Cursor = Cursors.Hand;
            iconButtonBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButtonBuscar.IconColor = Color.White;
            iconButtonBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonBuscar.IconSize = 30;
            iconButtonBuscar.Location = new Point(542, 81);
            iconButtonBuscar.Name = "iconButtonBuscar";
            iconButtonBuscar.Size = new Size(51, 45);
            iconButtonBuscar.TabIndex = 16;
            iconButtonBuscar.UseVisualStyleBackColor = false;
            iconButtonBuscar.Click += iconButtonBuscar_Click;
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
            iconPictureBoxSalir.IconSize = 44;
            iconPictureBoxSalir.Location = new Point(846, 4);
            iconPictureBoxSalir.Name = "iconPictureBoxSalir";
            iconPictureBoxSalir.Size = new Size(44, 48);
            iconPictureBoxSalir.TabIndex = 34;
            iconPictureBoxSalir.TabStop = false;
            iconPictureBoxSalir.Click += iconPictureBoxSalir_Click;
            // 
            // FormInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(902, 621);
            Controls.Add(iconPictureBoxSalir);
            Controls.Add(label2);
            Controls.Add(rbtFecha);
            Controls.Add(iconButtonBuscar);
            Controls.Add(label3);
            Controls.Add(cmbTipo);
            Controls.Add(pFecha);
            Controls.Add(txtBuscar);
            Controls.Add(btnStock);
            Controls.Add(btnVentas);
            Controls.Add(btnInventario);
            Controls.Add(btnClientes);
            Controls.Add(btnProveedores);
            Controls.Add(btnUsuarios);
            Controls.Add(dtgvInformes);
            Name = "FormInformes";
            Text = "Control_Inventario[FormInformes]";
            Load += FormInformes_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvInformes).EndInit();
            pFecha.ResumeLayout(false);
            pFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBoxSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvInformes;
        private Button btnUsuarios;
        private Button btnProveedores;
        private Button btnClientes;
        private Button btnInventario;
        private Button btnVentas;
        private Button btnStock;
        private Label label2;
        private TextBox txtBuscar;
        private DateTimePicker dTPInicio;
        private DateTimePicker dTPFin;
        private Panel pFecha;
        private ListBox lbTipoBusqueda;
        private ComboBox cmbTipo;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButtonBuscar;
        private RadioButton rbtFecha;
        private Label label4;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSalir;
    }
}