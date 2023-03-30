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
            panel3 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            rbtndescripcion = new RadioButton();
            rbtncodigo = new RadioButton();
            label2 = new Label();
            rbtnnombre = new RadioButton();
            txtarticulo = new TextBox();
            label3 = new Label();
            label20 = new Label();
            listView1 = new ListView();
            listView2 = new ListView();
            panel1 = new Panel();
            btnLimpiarCampos = new Button();
            button4 = new Button();
            txttotal = new TextBox();
            label6 = new Label();
            txtcantidad = new TextBox();
            label5 = new Label();
            txtvalor = new TextBox();
            txtdescripcion = new TextBox();
            label4 = new Label();
            txtexistencias = new TextBox();
            txtarti = new TextBox();
            txtcodigo = new TextBox();
            label1 = new Label();
            label19 = new Label();
            label17 = new Label();
            label16 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            label7 = new Label();
            textBox1 = new TextBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(iconButton1);
            panel3.Controls.Add(rbtndescripcion);
            panel3.Controls.Add(rbtncodigo);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(rbtnnombre);
            panel3.Controls.Add(txtarticulo);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(444, 75);
            panel3.TabIndex = 12;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(64, 64, 64);
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(374, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(51, 45);
            iconButton1.TabIndex = 10;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // rbtndescripcion
            // 
            rbtndescripcion.AutoSize = true;
            rbtndescripcion.Location = new Point(281, 41);
            rbtndescripcion.Name = "rbtndescripcion";
            rbtndescripcion.Size = new Size(87, 19);
            rbtndescripcion.TabIndex = 9;
            rbtndescripcion.TabStop = true;
            rbtndescripcion.Text = "Descripción";
            rbtndescripcion.UseVisualStyleBackColor = true;
            // 
            // rbtncodigo
            // 
            rbtncodigo.AutoSize = true;
            rbtncodigo.Location = new Point(128, 41);
            rbtncodigo.Name = "rbtncodigo";
            rbtncodigo.Size = new Size(64, 19);
            rbtncodigo.TabIndex = 8;
            rbtncodigo.TabStop = true;
            rbtncodigo.Text = "Codigo";
            rbtncodigo.UseVisualStyleBackColor = true;
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
            // rbtnnombre
            // 
            rbtnnombre.AutoSize = true;
            rbtnnombre.Location = new Point(206, 41);
            rbtnnombre.Name = "rbtnnombre";
            rbtnnombre.Size = new Size(69, 19);
            rbtnnombre.TabIndex = 7;
            rbtnnombre.TabStop = true;
            rbtnnombre.Text = "Nombre";
            rbtnnombre.UseVisualStyleBackColor = true;
            // 
            // txtarticulo
            // 
            txtarticulo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtarticulo.Location = new Point(85, 7);
            txtarticulo.Name = "txtarticulo";
            txtarticulo.Size = new Size(271, 23);
            txtarticulo.TabIndex = 5;
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
            label20.Location = new Point(17, 87);
            label20.Name = "label20";
            label20.Size = new Size(84, 14);
            label20.TabIndex = 14;
            label20.Text = "Encontrados";
            // 
            // listView1
            // 
            listView1.BackColor = Color.LavenderBlush;
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Location = new Point(12, 93);
            listView1.Name = "listView1";
            listView1.Size = new Size(444, 119);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(475, 12);
            listView2.Name = "listView2";
            listView2.Size = new Size(422, 503);
            listView2.TabIndex = 15;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLimpiarCampos);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(txttotal);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtcantidad);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtvalor);
            panel1.Controls.Add(txtdescripcion);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtexistencias);
            panel1.Controls.Add(txtarti);
            panel1.Controls.Add(txtcodigo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Location = new Point(12, 272);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 243);
            panel1.TabIndex = 16;
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
            btnLimpiarCampos.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(327, 197);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(100, 32);
            button4.TabIndex = 27;
            button4.Text = "Agregar";
            button4.UseVisualStyleBackColor = false;
            // 
            // txttotal
            // 
            txttotal.BackColor = Color.LavenderBlush;
            txttotal.BorderStyle = BorderStyle.FixedSingle;
            txttotal.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txttotal.Location = new Point(331, 160);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(96, 23);
            txttotal.TabIndex = 26;
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
            // txtcantidad
            // 
            txtcantidad.BackColor = Color.White;
            txtcantidad.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtcantidad.Location = new Point(331, 124);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(96, 23);
            txtcantidad.TabIndex = 24;
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
            // txtvalor
            // 
            txtvalor.BackColor = Color.LavenderBlush;
            txtvalor.BorderStyle = BorderStyle.FixedSingle;
            txtvalor.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtvalor.Location = new Point(116, 124);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(91, 23);
            txtvalor.TabIndex = 22;
            // 
            // txtdescripcion
            // 
            txtdescripcion.BackColor = Color.LavenderBlush;
            txtdescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtdescripcion.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtdescripcion.Location = new Point(116, 75);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(311, 23);
            txtdescripcion.TabIndex = 21;
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
            txtexistencias.Size = new Size(33, 23);
            txtexistencias.TabIndex = 19;
            // 
            // txtarti
            // 
            txtarti.BackColor = Color.LavenderBlush;
            txtarti.BorderStyle = BorderStyle.FixedSingle;
            txtarti.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtarti.Location = new Point(116, 41);
            txtarti.Name = "txtarti";
            txtarti.Size = new Size(311, 23);
            txtarti.TabIndex = 18;
            // 
            // txtcodigo
            // 
            txtcodigo.BackColor = Color.LavenderBlush;
            txtcodigo.BorderStyle = BorderStyle.FixedSingle;
            txtcodigo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtcodigo.Location = new Point(116, 8);
            txtcodigo.Name = "txtcodigo";
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(797, 521);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(100, 32);
            button1.TabIndex = 29;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(691, 521);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(100, 32);
            button2.TabIndex = 30;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(581, 521);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(100, 32);
            button3.TabIndex = 31;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(64, 64, 64);
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(475, 521);
            button6.Name = "button6";
            button6.RightToLeft = RightToLeft.No;
            button6.Size = new Size(100, 32);
            button6.TabIndex = 32;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(12, 218);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 48);
            panel2.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(24, 14);
            label7.Name = "label7";
            label7.Size = new Size(72, 16);
            label7.TabIndex = 4;
            label7.Text = "Id_Cliente";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(114, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 23);
            textBox1.TabIndex = 5;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(909, 587);
            Controls.Add(panel2);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(listView2);
            Controls.Add(label20);
            Controls.Add(listView1);
            Controls.Add(panel3);
            Name = "FormVentas";
            Text = "Control de Inventario [Ventas]";
            Load += FormVentas_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private RadioButton rbtndescripcion;
        private RadioButton rbtncodigo;
        private Label label2;
        private RadioButton rbtnnombre;
        private TextBox txtarticulo;
        private Label label3;
        private Label label20;
        private ListView listView1;
        private ListView listView2;
        private Panel panel1;
        private TextBox txtdescripcion;
        private Label label4;
        private TextBox txtexistencias;
        private TextBox txtarti;
        private TextBox txtcodigo;
        private Label label1;
        private Label label19;
        private Label label17;
        private Label label16;
        private TextBox txtvalor;
        private TextBox txttotal;
        private Label label6;
        private TextBox txtcantidad;
        private Label label5;
        private Button btnLimpiarCampos;
        private Button button4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Panel panel2;
        private Label label7;
        private TextBox textBox1;
    }
}