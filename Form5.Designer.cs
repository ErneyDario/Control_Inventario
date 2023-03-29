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
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.rbtndescripcion = new System.Windows.Forms.RadioButton();
            this.rbtncodigo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnnombre = new System.Windows.Forms.RadioButton();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtexistencias = new System.Windows.Forms.TextBox();
            this.txtarti = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.rbtndescripcion);
            this.panel3.Controls.Add(this.rbtncodigo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.rbtnnombre);
            this.panel3.Controls.Add(this.txtarticulo);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 75);
            this.panel3.TabIndex = 12;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(374, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(51, 45);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // rbtndescripcion
            // 
            this.rbtndescripcion.AutoSize = true;
            this.rbtndescripcion.Location = new System.Drawing.Point(281, 41);
            this.rbtndescripcion.Name = "rbtndescripcion";
            this.rbtndescripcion.Size = new System.Drawing.Size(87, 19);
            this.rbtndescripcion.TabIndex = 9;
            this.rbtndescripcion.TabStop = true;
            this.rbtndescripcion.Text = "Descripción";
            this.rbtndescripcion.UseVisualStyleBackColor = true;
            // 
            // rbtncodigo
            // 
            this.rbtncodigo.AutoSize = true;
            this.rbtncodigo.Location = new System.Drawing.Point(128, 41);
            this.rbtncodigo.Name = "rbtncodigo";
            this.rbtncodigo.Size = new System.Drawing.Size(64, 19);
            this.rbtncodigo.TabIndex = 8;
            this.rbtncodigo.TabStop = true;
            this.rbtncodigo.Text = "Codigo";
            this.rbtncodigo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Articulo";
            // 
            // rbtnnombre
            // 
            this.rbtnnombre.AutoSize = true;
            this.rbtnnombre.Location = new System.Drawing.Point(206, 41);
            this.rbtnnombre.Name = "rbtnnombre";
            this.rbtnnombre.Size = new System.Drawing.Size(69, 19);
            this.rbtnnombre.TabIndex = 7;
            this.rbtnnombre.TabStop = true;
            this.rbtnnombre.Text = "Nombre";
            this.rbtnnombre.UseVisualStyleBackColor = true;
            // 
            // txtarticulo
            // 
            this.txtarticulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtarticulo.Location = new System.Drawing.Point(85, 7);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.Size = new System.Drawing.Size(271, 23);
            this.txtarticulo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buscar por:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(17, 87);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 14);
            this.label20.TabIndex = 14;
            this.label20.Text = "Encontrados";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LavenderBlush;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Location = new System.Drawing.Point(12, 93);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(444, 173);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(475, 12);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(422, 503);
            this.listView2.TabIndex = 15;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpiarCampos);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.txttotal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtcantidad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtvalor);
            this.panel1.Controls.Add(this.txtdescripcion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtexistencias);
            this.panel1.Controls.Add(this.txtarti);
            this.panel1.Controls.Add(this.txtcodigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(12, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 243);
            this.panel1.TabIndex = 16;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(211, 197);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLimpiarCampos.Size = new System.Drawing.Size(100, 32);
            this.btnLimpiarCampos.TabIndex = 28;
            this.btnLimpiarCampos.Text = "Limpiar";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(327, 197);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(100, 32);
            this.button4.TabIndex = 27;
            this.button4.Text = "Agregar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.LavenderBlush;
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txttotal.Location = new System.Drawing.Point(331, 160);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(96, 23);
            this.txttotal.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(272, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Total";
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.Color.White;
            this.txtcantidad.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtcantidad.Location = new System.Drawing.Point(331, 124);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(96, 23);
            this.txtcantidad.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(247, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cantidad";
            // 
            // txtvalor
            // 
            this.txtvalor.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtvalor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvalor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtvalor.Location = new System.Drawing.Point(116, 124);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(91, 23);
            this.txtvalor.TabIndex = 22;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescripcion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtdescripcion.Location = new System.Drawing.Point(116, 75);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(311, 23);
            this.txtdescripcion.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(310, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Existencias";
            // 
            // txtexistencias
            // 
            this.txtexistencias.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtexistencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtexistencias.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtexistencias.Location = new System.Drawing.Point(394, 8);
            this.txtexistencias.Name = "txtexistencias";
            this.txtexistencias.Size = new System.Drawing.Size(33, 23);
            this.txtexistencias.TabIndex = 19;
            // 
            // txtarti
            // 
            this.txtarti.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtarti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtarti.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtarti.Location = new System.Drawing.Point(116, 41);
            this.txtarti.Name = "txtarti";
            this.txtarti.Size = new System.Drawing.Size(311, 23);
            this.txtarti.TabIndex = 18;
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtcodigo.Location = new System.Drawing.Point(116, 8);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(180, 23);
            this.txtcodigo.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Codigo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(57, 131);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 16);
            this.label19.TabIndex = 14;
            this.label19.Text = "Valor";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(17, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 16);
            this.label17.TabIndex = 12;
            this.label17.Text = "Descripción";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(40, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 16);
            this.label16.TabIndex = 10;
            this.label16.Text = "Articulo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(797, 521);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 29;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(691, 521);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 30;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(581, 521);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(100, 32);
            this.button3.TabIndex = 31;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(475, 521);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(100, 32);
            this.button6.TabIndex = 32;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(909, 587);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel3);
            this.Name = "FormVentas";
            this.Text = "Control de Inventario [Ventas]";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}