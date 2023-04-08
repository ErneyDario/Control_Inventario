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
            btnLimpiarCampos = new Button();
            panel3 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtarticulo = new TextBox();
            comboBox1 = new ComboBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            listView1 = new ListView();
            panel1 = new Panel();
            textBox3 = new TextBox();
            label10 = new Label();
            txtdescripcion = new TextBox();
            txtvalor = new TextBox();
            label8 = new Label();
            txtexistencias = new TextBox();
            txtarti = new TextBox();
            txtcodigo = new TextBox();
            label9 = new Label();
            label19 = new Label();
            label17 = new Label();
            label16 = new Label();
            button2 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = Color.FromArgb(64, 64, 64);
            btnLimpiarCampos.Cursor = Cursors.Hand;
            btnLimpiarCampos.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiarCampos.ForeColor = Color.White;
            btnLimpiarCampos.Location = new Point(418, 21);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.RightToLeft = RightToLeft.No;
            btnLimpiarCampos.Size = new Size(100, 40);
            btnLimpiarCampos.TabIndex = 30;
            btnLimpiarCampos.Text = "Ver Inventario";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dateTimePicker2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(txtarticulo);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(iconButton1);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(418, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(474, 155);
            panel3.TabIndex = 31;
            panel3.Paint += panel3_Paint;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(285, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(54, 23);
            textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(285, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(54, 23);
            textBox1.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(247, 125);
            label5.Name = "label5";
            label5.Size = new Size(36, 14);
            label5.TabIndex = 18;
            label5.Text = "Max:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(246, 93);
            label4.Name = "label4";
            label4.Size = new Size(33, 14);
            label4.TabIndex = 17;
            label4.Text = "Min:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(138, 121);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(103, 23);
            dateTimePicker2.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(91, 125);
            label2.Name = "label2";
            label2.Size = new Size(46, 14);
            label2.TabIndex = 15;
            label2.Text = "Hasta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(87, 94);
            label1.Name = "label1";
            label1.Size = new Size(48, 14);
            label1.TabIndex = 14;
            label1.Text = "Desde:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(138, 90);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(103, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // txtarticulo
            // 
            txtarticulo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtarticulo.Location = new Point(85, 61);
            txtarticulo.Name = "txtarticulo";
            txtarticulo.Size = new Size(254, 23);
            txtarticulo.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Articulo", "Articulo Por Factura", "Articulo Por Proveedor", "Articulo Por Fecha", "Articulo Por Valor", "Articulo Por Cantidad" });
            comboBox1.Location = new Point(85, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(254, 23);
            comboBox1.TabIndex = 11;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(64, 64, 64);
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(363, 37);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(52, 43);
            iconButton1.TabIndex = 10;
            iconButton1.UseVisualStyleBackColor = false;
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
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.LavenderBlush;
            iconPictureBox1.BackgroundImageLayout = ImageLayout.Center;
            iconPictureBox1.Cursor = Cursors.Hand;
            iconPictureBox1.ForeColor = Color.FromArgb(64, 64, 64);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            iconPictureBox1.IconColor = Color.FromArgb(64, 64, 64);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox1.IconSize = 38;
            iconPictureBox1.Location = new Point(854, 21);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(38, 40);
            iconPictureBox1.TabIndex = 33;
            iconPictureBox1.TabStop = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(5, 276);
            listView1.Name = "listView1";
            listView1.Size = new Size(888, 265);
            listView1.TabIndex = 34;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtdescripcion);
            panel1.Controls.Add(txtvalor);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtexistencias);
            panel1.Controls.Add(txtarti);
            panel1.Controls.Add(txtcodigo);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Location = new Point(5, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 155);
            panel1.TabIndex = 35;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Window;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(296, 93);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(91, 23);
            textBox3.TabIndex = 31;
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
            txtdescripcion.Size = new Size(287, 23);
            txtdescripcion.TabIndex = 29;
            // 
            // txtvalor
            // 
            txtvalor.BackColor = SystemColors.Window;
            txtvalor.BorderStyle = BorderStyle.FixedSingle;
            txtvalor.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtvalor.Location = new Point(101, 93);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(91, 23);
            txtvalor.TabIndex = 22;
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
            // txtexistencias
            // 
            txtexistencias.BackColor = SystemColors.Window;
            txtexistencias.BorderStyle = BorderStyle.FixedSingle;
            txtexistencias.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtexistencias.Location = new Point(101, 122);
            txtexistencias.Name = "txtexistencias";
            txtexistencias.Size = new Size(91, 23);
            txtexistencias.TabIndex = 19;
            // 
            // txtarti
            // 
            txtarti.BackColor = SystemColors.Window;
            txtarti.BorderStyle = BorderStyle.FixedSingle;
            txtarti.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtarti.Location = new Point(101, 35);
            txtarti.Name = "txtarti";
            txtarti.Size = new Size(287, 23);
            txtarti.TabIndex = 18;
            // 
            // txtcodigo
            // 
            txtcodigo.BackColor = SystemColors.Window;
            txtcodigo.BorderStyle = BorderStyle.FixedSingle;
            txtcodigo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtcodigo.Location = new Point(101, 8);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(162, 23);
            txtcodigo.TabIndex = 17;
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
            label17.Click += label17_Click;
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
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(204, 238);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(100, 32);
            button2.TabIndex = 28;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(313, 238);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(100, 32);
            button4.TabIndex = 27;
            button4.Text = "Agregar";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox4);
            panel2.Location = new Point(5, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 65);
            panel2.TabIndex = 36;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LavenderBlush;
            textBox6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(64, 35);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(322, 23);
            textBox6.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(272, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(114, 23);
            textBox5.TabIndex = 7;
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
            // textBox4
            // 
            textBox4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(64, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(99, 23);
            textBox4.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(536, 21);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(100, 40);
            button1.TabIndex = 37;
            button1.Text = "Editar Inventario";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(659, 21);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(100, 40);
            button3.TabIndex = 38;
            button3.Text = "Eliminar Inventario";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 64, 64);
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(676, 547);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(100, 32);
            button5.TabIndex = 39;
            button5.Text = "Limpiar";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(64, 64, 64);
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(792, 547);
            button6.Name = "button6";
            button6.RightToLeft = RightToLeft.No;
            button6.Size = new Size(100, 32);
            button6.TabIndex = 40;
            button6.Text = "Guardar";
            button6.UseVisualStyleBackColor = false;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(910, 593);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(listView1);
            Controls.Add(iconPictureBox1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(btnLimpiarCampos);
            Name = "FormInventario";
            Text = "Control_Inventario [Inventario]";
            Load += FormInventario_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLimpiarCampos;
        private Panel panel3;
        private ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label3;
        private TextBox txtarticulo;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private ListView listView1;
        private Panel panel1;
        private TextBox txtdescripcion;
        private Button button2;
        private Button button4;
        private TextBox txtvalor;
        private Label label8;
        private TextBox txtexistencias;
        private TextBox txtarti;
        private TextBox txtcodigo;
        private Label label9;
        private Label label19;
        private Label label17;
        private Label label16;
        private TextBox textBox3;
        private Label label10;
        private Panel panel2;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
        private Button button1;
        private Button button3;
        private Button button5;
        private Button button6;
    }
}