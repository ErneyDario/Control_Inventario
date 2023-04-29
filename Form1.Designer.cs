namespace Control_Inventario
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labUsuario = new Label();
            labContraseña = new Label();
            panel1 = new Panel();
            iButtonEntrar = new FontAwesome.Sharp.IconButton();
            labelSalir = new Label();
            txtcontrasena = new TextBox();
            labVersion = new Label();
            labRecCont = new Label();
            picBoxBannerInferior = new PictureBox();
            picBoxBanerSup = new PictureBox();
            txtusuario = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxBannerInferior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBanerSup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // labUsuario
            // 
            labUsuario.AutoSize = true;
            labUsuario.Location = new Point(136, 146);
            labUsuario.Name = "labUsuario";
            labUsuario.Size = new Size(71, 19);
            labUsuario.TabIndex = 0;
            labUsuario.Text = "Usuario";
            // 
            // labContraseña
            // 
            labContraseña.AutoSize = true;
            labContraseña.Location = new Point(105, 177);
            labContraseña.Name = "labContraseña";
            labContraseña.Size = new Size(102, 19);
            labContraseña.TabIndex = 1;
            labContraseña.Text = "Contraseña";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LavenderBlush;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(iButtonEntrar);
            panel1.Controls.Add(labelSalir);
            panel1.Controls.Add(txtcontrasena);
            panel1.Controls.Add(labVersion);
            panel1.Controls.Add(labRecCont);
            panel1.Controls.Add(picBoxBannerInferior);
            panel1.Controls.Add(picBoxBanerSup);
            panel1.Controls.Add(txtusuario);
            panel1.Controls.Add(labUsuario);
            panel1.Controls.Add(labContraseña);
            panel1.Location = new Point(358, 178);
            panel1.MaximumSize = new Size(615, 382);
            panel1.MinimumSize = new Size(615, 382);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 382);
            panel1.TabIndex = 2;
            // 
            // iButtonEntrar
            // 
            iButtonEntrar.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            iButtonEntrar.IconColor = Color.Black;
            iButtonEntrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iButtonEntrar.IconSize = 20;
            iButtonEntrar.Location = new Point(441, 150);
            iButtonEntrar.Name = "iButtonEntrar";
            iButtonEntrar.Size = new Size(75, 38);
            iButtonEntrar.TabIndex = 13;
            iButtonEntrar.UseVisualStyleBackColor = true;
            iButtonEntrar.Click += iButtonEntrar_Click;
            // 
            // labelSalir
            // 
            labelSalir.AutoSize = true;
            labelSalir.Cursor = Cursors.Hand;
            labelSalir.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelSalir.ForeColor = SystemColors.HotTrack;
            labelSalir.Location = new Point(305, 227);
            labelSalir.Name = "labelSalir";
            labelSalir.Size = new Size(33, 14);
            labelSalir.TabIndex = 12;
            labelSalir.Text = "Salir";
            labelSalir.Click += labelSalir_Click;
            // 
            // txtcontrasena
            // 
            txtcontrasena.Location = new Point(224, 174);
            txtcontrasena.Name = "txtcontrasena";
            txtcontrasena.PasswordChar = '*';
            txtcontrasena.Size = new Size(203, 27);
            txtcontrasena.TabIndex = 11;
            txtcontrasena.UseSystemPasswordChar = true;
            // 
            // labVersion
            // 
            labVersion.AutoSize = true;
            labVersion.BackColor = Color.LightCyan;
            labVersion.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labVersion.ForeColor = Color.Silver;
            labVersion.Location = new Point(449, 366);
            labVersion.Name = "labVersion";
            labVersion.Size = new Size(164, 14);
            labVersion.TabIndex = 9;
            labVersion.Text = "Control de Inventario 1.0";
            // 
            // labRecCont
            // 
            labRecCont.AutoSize = true;
            labRecCont.Cursor = Cursors.Hand;
            labRecCont.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labRecCont.ForeColor = SystemColors.HotTrack;
            labRecCont.Location = new Point(254, 204);
            labRecCont.Name = "labRecCont";
            labRecCont.Size = new Size(143, 14);
            labRecCont.TabIndex = 8;
            labRecCont.Text = "Recuperar Contraseña";
            labRecCont.Click += labRecCont_Click;
            // 
            // picBoxBannerInferior
            // 
            picBoxBannerInferior.Image = Properties.Resources.Primero;
            picBoxBannerInferior.Location = new Point(0, 280);
            picBoxBannerInferior.Name = "picBoxBannerInferior";
            picBoxBannerInferior.Size = new Size(615, 102);
            picBoxBannerInferior.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxBannerInferior.TabIndex = 5;
            picBoxBannerInferior.TabStop = false;
            // 
            // picBoxBanerSup
            // 
            picBoxBanerSup.Image = Properties.Resources.Primero;
            picBoxBanerSup.Location = new Point(0, 0);
            picBoxBanerSup.Name = "picBoxBanerSup";
            picBoxBanerSup.Size = new Size(615, 102);
            picBoxBanerSup.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxBanerSup.TabIndex = 4;
            picBoxBanerSup.TabStop = false;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(224, 138);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(203, 27);
            txtusuario.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Gray;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Gray;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.Location = new Point(0, 0);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(32, 32);
            iconPictureBox2.TabIndex = 4;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Gray;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.Location = new Point(8, 8);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(32, 32);
            iconPictureBox3.TabIndex = 5;
            iconPictureBox3.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1255, 589);
            Controls.Add(iconPictureBox3);
            Controls.Add(iconPictureBox2);
            Controls.Add(iconPictureBox1);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de Inventario [Login]";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxBannerInferior).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBanerSup).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labUsuario;
        private Label labContraseña;
        private Panel panel1;
        private TextBox txtusuario;
        private PictureBox picBoxBannerInferior;
        private PictureBox picBoxBanerSup;
        private FontAwesome.Sharp.IconButton iBtnEntrar;
        private Label labRecCont;
        private Label labVersion;
        private TextBox txtcontrasena;
        private Label labelSalir;
        private FontAwesome.Sharp.IconButton iButtonEntrar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
    }
}