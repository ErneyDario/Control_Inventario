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
            this.labUsuario = new System.Windows.Forms.Label();
            this.labContraseña = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labVersion = new System.Windows.Forms.Label();
            this.labRecCont = new System.Windows.Forms.Label();
            this.labSalir = new System.Windows.Forms.Label();
            this.iBtnEntrar = new FontAwesome.Sharp.IconButton();
            this.picBoxBannerInferior = new System.Windows.Forms.PictureBox();
            this.picBoxBanerSup = new System.Windows.Forms.PictureBox();
            this.tBoxContraseña = new System.Windows.Forms.TextBox();
            this.tBoxUsuario = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBannerInferior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBanerSup)).BeginInit();
            this.SuspendLayout();
            // 
            // labUsuario
            // 
            this.labUsuario.AutoSize = true;
            this.labUsuario.Location = new System.Drawing.Point(136, 146);
            this.labUsuario.Name = "labUsuario";
            this.labUsuario.Size = new System.Drawing.Size(71, 19);
            this.labUsuario.TabIndex = 0;
            this.labUsuario.Text = "Usuario";
            // 
            // labContraseña
            // 
            this.labContraseña.AutoSize = true;
            this.labContraseña.Location = new System.Drawing.Point(105, 177);
            this.labContraseña.Name = "labContraseña";
            this.labContraseña.Size = new System.Drawing.Size(102, 19);
            this.labContraseña.TabIndex = 1;
            this.labContraseña.Text = "Contraseña";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labVersion);
            this.panel1.Controls.Add(this.labRecCont);
            this.panel1.Controls.Add(this.labSalir);
            this.panel1.Controls.Add(this.iBtnEntrar);
            this.panel1.Controls.Add(this.picBoxBannerInferior);
            this.panel1.Controls.Add(this.picBoxBanerSup);
            this.panel1.Controls.Add(this.tBoxContraseña);
            this.panel1.Controls.Add(this.tBoxUsuario);
            this.panel1.Controls.Add(this.labUsuario);
            this.panel1.Controls.Add(this.labContraseña);
            this.panel1.Location = new System.Drawing.Point(358, 178);
            this.panel1.MaximumSize = new System.Drawing.Size(615, 382);
            this.panel1.MinimumSize = new System.Drawing.Size(615, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 382);
            this.panel1.TabIndex = 2;
            // 
            // labVersion
            // 
            this.labVersion.AutoSize = true;
            this.labVersion.BackColor = System.Drawing.Color.LightCyan;
            this.labVersion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labVersion.ForeColor = System.Drawing.Color.Silver;
            this.labVersion.Location = new System.Drawing.Point(449, 366);
            this.labVersion.Name = "labVersion";
            this.labVersion.Size = new System.Drawing.Size(164, 14);
            this.labVersion.TabIndex = 9;
            this.labVersion.Text = "Control de Inventario 1.0";
            // 
            // labRecCont
            // 
            this.labRecCont.AutoSize = true;
            this.labRecCont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labRecCont.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labRecCont.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labRecCont.Location = new System.Drawing.Point(284, 218);
            this.labRecCont.Name = "labRecCont";
            this.labRecCont.Size = new System.Drawing.Size(143, 14);
            this.labRecCont.TabIndex = 8;
            this.labRecCont.Text = "Recuperar Contraseña";
            this.labRecCont.Click += new System.EventHandler(this.labRecCont_Click);
            // 
            // labSalir
            // 
            this.labSalir.AutoSize = true;
            this.labSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labSalir.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labSalir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labSalir.Location = new System.Drawing.Point(336, 244);
            this.labSalir.Name = "labSalir";
            this.labSalir.Size = new System.Drawing.Size(33, 14);
            this.labSalir.TabIndex = 7;
            this.labSalir.Text = "Salir";
            // 
            // iBtnEntrar
            // 
            this.iBtnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iBtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnEntrar.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.iBtnEntrar.IconColor = System.Drawing.Color.Black;
            this.iBtnEntrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEntrar.IconSize = 30;
            this.iBtnEntrar.Location = new System.Drawing.Point(468, 166);
            this.iBtnEntrar.Name = "iBtnEntrar";
            this.iBtnEntrar.Size = new System.Drawing.Size(74, 31);
            this.iBtnEntrar.TabIndex = 6;
            this.iBtnEntrar.UseVisualStyleBackColor = true;
            this.iBtnEntrar.Click += new System.EventHandler(this.iBtnEntrar_Click);
            // 
            // picBoxBannerInferior
            // 
            this.picBoxBannerInferior.Image = global::Control_Inventario.Properties.Resources.Primero;
            this.picBoxBannerInferior.Location = new System.Drawing.Point(0, 280);
            this.picBoxBannerInferior.Name = "picBoxBannerInferior";
            this.picBoxBannerInferior.Size = new System.Drawing.Size(615, 102);
            this.picBoxBannerInferior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBannerInferior.TabIndex = 5;
            this.picBoxBannerInferior.TabStop = false;
            // 
            // picBoxBanerSup
            // 
            this.picBoxBanerSup.Image = global::Control_Inventario.Properties.Resources.Primero;
            this.picBoxBanerSup.Location = new System.Drawing.Point(0, 0);
            this.picBoxBanerSup.Name = "picBoxBanerSup";
            this.picBoxBanerSup.Size = new System.Drawing.Size(615, 102);
            this.picBoxBanerSup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBanerSup.TabIndex = 4;
            this.picBoxBanerSup.TabStop = false;
            // 
            // tBoxContraseña
            // 
            this.tBoxContraseña.Location = new System.Drawing.Point(245, 171);
            this.tBoxContraseña.Name = "tBoxContraseña";
            this.tBoxContraseña.Size = new System.Drawing.Size(203, 27);
            this.tBoxContraseña.TabIndex = 3;
            // 
            // tBoxUsuario
            // 
            this.tBoxUsuario.Location = new System.Drawing.Point(245, 138);
            this.tBoxUsuario.Name = "tBoxUsuario";
            this.tBoxUsuario.Size = new System.Drawing.Size(203, 27);
            this.tBoxUsuario.TabIndex = 2;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1255, 589);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Inventario [Login]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBannerInferior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBanerSup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labUsuario;
        private Label labContraseña;
        private Panel panel1;
        private TextBox tBoxUsuario;
        private TextBox tBoxContraseña;
        private PictureBox picBoxBannerInferior;
        private PictureBox picBoxBanerSup;
        private FontAwesome.Sharp.IconButton iBtnEntrar;
        private Label labRecCont;
        private Label labSalir;
        private Label labVersion;
    }
}