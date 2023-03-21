namespace Control_Inventario
{
    partial class FormRecCont
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comBoxTipoId = new System.Windows.Forms.ComboBox();
            this.labVersion = new System.Windows.Forms.Label();
            this.lblregresar = new System.Windows.Forms.Label();
            this.iBtnEntrar = new FontAwesome.Sharp.IconButton();
            this.picBoxBannerInferior = new System.Windows.Forms.PictureBox();
            this.picBoxBanerSup = new System.Windows.Forms.PictureBox();
            this.tBoxContraseña = new System.Windows.Forms.TextBox();
            this.labTipId = new System.Windows.Forms.Label();
            this.labNumId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBannerInferior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBanerSup)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comBoxTipoId);
            this.panel1.Controls.Add(this.labVersion);
            this.panel1.Controls.Add(this.lblregresar);
            this.panel1.Controls.Add(this.iBtnEntrar);
            this.panel1.Controls.Add(this.picBoxBannerInferior);
            this.panel1.Controls.Add(this.picBoxBanerSup);
            this.panel1.Controls.Add(this.tBoxContraseña);
            this.panel1.Controls.Add(this.labTipId);
            this.panel1.Controls.Add(this.labNumId);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.MaximumSize = new System.Drawing.Size(615, 382);
            this.panel1.MinimumSize = new System.Drawing.Size(615, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 382);
            this.panel1.TabIndex = 3;
            // 
            // comBoxTipoId
            // 
            this.comBoxTipoId.FormattingEnabled = true;
            this.comBoxTipoId.Items.AddRange(new object[] {
            "Tarjerta de Identidad",
            "Cedula de Ciudadania",
            "Cedula de Extranjeria",
            "Pasaporte"});
            this.comBoxTipoId.Location = new System.Drawing.Point(240, 157);
            this.comBoxTipoId.Name = "comBoxTipoId";
            this.comBoxTipoId.Size = new System.Drawing.Size(203, 27);
            this.comBoxTipoId.TabIndex = 10;
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
            // lblregresar
            // 
            this.lblregresar.AutoSize = true;
            this.lblregresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblregresar.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblregresar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblregresar.Location = new System.Drawing.Point(315, 232);
            this.lblregresar.Name = "lblregresar";
            this.lblregresar.Size = new System.Drawing.Size(61, 14);
            this.lblregresar.TabIndex = 7;
            this.lblregresar.Text = "Regresar";
            this.lblregresar.Click += new System.EventHandler(this.labSalir_Click);
            // 
            // iBtnEntrar
            // 
            this.iBtnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iBtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnEntrar.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iBtnEntrar.IconColor = System.Drawing.Color.Black;
            this.iBtnEntrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEntrar.IconSize = 30;
            this.iBtnEntrar.Location = new System.Drawing.Point(449, 187);
            this.iBtnEntrar.Name = "iBtnEntrar";
            this.iBtnEntrar.Size = new System.Drawing.Size(74, 31);
            this.iBtnEntrar.TabIndex = 6;
            this.iBtnEntrar.UseVisualStyleBackColor = true;
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
            this.tBoxContraseña.Location = new System.Drawing.Point(240, 190);
            this.tBoxContraseña.Name = "tBoxContraseña";
            this.tBoxContraseña.Size = new System.Drawing.Size(203, 27);
            this.tBoxContraseña.TabIndex = 3;
            // 
            // labTipId
            // 
            this.labTipId.AutoSize = true;
            this.labTipId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labTipId.Location = new System.Drawing.Point(90, 163);
            this.labTipId.Name = "labTipId";
            this.labTipId.Size = new System.Drawing.Size(144, 16);
            this.labTipId.TabIndex = 0;
            this.labTipId.Text = "Tipo de Identificación";
            // 
            // labNumId
            // 
            this.labNumId.AutoSize = true;
            this.labNumId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labNumId.Location = new System.Drawing.Point(67, 200);
            this.labNumId.Name = "labNumId";
            this.labNumId.Size = new System.Drawing.Size(167, 16);
            this.labNumId.TabIndex = 1;
            this.labNumId.Text = "Numero de Identificacion";
            // 
            // FormRecCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(613, 381);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRecCont";
            this.Text = "Control de Inventario [Recuperar Contraseña]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBannerInferior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBanerSup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ComboBox comBoxTipoId;
        private Label labVersion;
        private Label lblregresar;
        private FontAwesome.Sharp.IconButton iBtnEntrar;
        private PictureBox picBoxBannerInferior;
        private PictureBox picBoxBanerSup;
        private TextBox tBoxContraseña;
        private Label labTipId;
        private Label labNumId;
    }
}