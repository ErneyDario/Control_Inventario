namespace Control_Inventario
{
    partial class FormPrincipal
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
            this.panelTrabajo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iPicBoxPerfil = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iButtonSalir = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iButtonUsuarios = new FontAwesome.Sharp.IconButton();
            this.iButtonInformes = new FontAwesome.Sharp.IconButton();
            this.iconProveedores = new FontAwesome.Sharp.IconButton();
            this.iButtonClientes = new FontAwesome.Sharp.IconButton();
            this.iButtonInventario = new FontAwesome.Sharp.IconButton();
            this.iButtonVentas = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPicBoxPerfil)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTrabajo
            // 
            this.panelTrabajo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTrabajo.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelTrabajo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panelTrabajo.ForeColor = System.Drawing.Color.White;
            this.panelTrabajo.Location = new System.Drawing.Point(200, 12);
            this.panelTrabajo.Margin = new System.Windows.Forms.Padding(8);
            this.panelTrabajo.Name = "panelTrabajo";
            this.panelTrabajo.Padding = new System.Windows.Forms.Padding(6);
            this.panelTrabajo.Size = new System.Drawing.Size(1053, 660);
            this.panelTrabajo.TabIndex = 0;
            this.panelTrabajo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTrabajo_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.iPicBoxPerfil);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 111);
            this.panel1.TabIndex = 0;
            // 
            // iPicBoxPerfil
            // 
            this.iPicBoxPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iPicBoxPerfil.BackColor = System.Drawing.Color.LavenderBlush;
            this.iPicBoxPerfil.ForeColor = System.Drawing.Color.Black;
            this.iPicBoxPerfil.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iPicBoxPerfil.IconColor = System.Drawing.Color.Black;
            this.iPicBoxPerfil.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.iPicBoxPerfil.IconSize = 64;
            this.iPicBoxPerfil.Location = new System.Drawing.Point(51, 3);
            this.iPicBoxPerfil.Name = "iPicBoxPerfil";
            this.iPicBoxPerfil.Size = new System.Drawing.Size(64, 68);
            this.iPicBoxPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iPicBoxPerfil.TabIndex = 0;
            this.iPicBoxPerfil.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rol";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.iButtonSalir);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.iconProveedores);
            this.panel2.Controls.Add(this.iButtonClientes);
            this.panel2.Controls.Add(this.iButtonInventario);
            this.panel2.Controls.Add(this.iButtonVentas);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(12);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(182, 660);
            this.panel2.TabIndex = 2;
            // 
            // iButtonSalir
            // 
            this.iButtonSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iButtonSalir.BackColor = System.Drawing.Color.LavenderBlush;
            this.iButtonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iButtonSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iButtonSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iButtonSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iButtonSalir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iButtonSalir.Location = new System.Drawing.Point(58, 594);
            this.iButtonSalir.Name = "iButtonSalir";
            this.iButtonSalir.Size = new System.Drawing.Size(66, 63);
            this.iButtonSalir.TabIndex = 0;
            this.iButtonSalir.Text = "Salir";
            this.iButtonSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iButtonSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iButtonSalir.UseVisualStyleBackColor = false;
            this.iButtonSalir.Click += new System.EventHandler(this.iButtonSalir_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.iButtonUsuarios);
            this.panel3.Controls.Add(this.iButtonInformes);
            this.panel3.Location = new System.Drawing.Point(11, 428);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 146);
            this.panel3.TabIndex = 3;
            // 
            // iButtonUsuarios
            // 
            this.iButtonUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iButtonUsuarios.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iButtonUsuarios.ForeColor = System.Drawing.Color.White;
            this.iButtonUsuarios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iButtonUsuarios.IconColor = System.Drawing.Color.Black;
            this.iButtonUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iButtonUsuarios.Location = new System.Drawing.Point(34, 84);
            this.iButtonUsuarios.Name = "iButtonUsuarios";
            this.iButtonUsuarios.Size = new System.Drawing.Size(102, 44);
            this.iButtonUsuarios.TabIndex = 5;
            this.iButtonUsuarios.Text = "Usuarios";
            this.iButtonUsuarios.UseVisualStyleBackColor = false;
            // 
            // iButtonInformes
            // 
            this.iButtonInformes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iButtonInformes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iButtonInformes.ForeColor = System.Drawing.Color.White;
            this.iButtonInformes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iButtonInformes.IconColor = System.Drawing.Color.Black;
            this.iButtonInformes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iButtonInformes.Location = new System.Drawing.Point(33, 14);
            this.iButtonInformes.Name = "iButtonInformes";
            this.iButtonInformes.Size = new System.Drawing.Size(102, 44);
            this.iButtonInformes.TabIndex = 4;
            this.iButtonInformes.Text = "Informes";
            this.iButtonInformes.UseVisualStyleBackColor = false;
            // 
            // iconProveedores
            // 
            this.iconProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconProveedores.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconProveedores.ForeColor = System.Drawing.Color.White;
            this.iconProveedores.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconProveedores.IconColor = System.Drawing.Color.Black;
            this.iconProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProveedores.Location = new System.Drawing.Point(44, 367);
            this.iconProveedores.Name = "iconProveedores";
            this.iconProveedores.Size = new System.Drawing.Size(102, 44);
            this.iconProveedores.TabIndex = 3;
            this.iconProveedores.Text = "Proveedores";
            this.iconProveedores.UseVisualStyleBackColor = false;
            // 
            // iButtonClientes
            // 
            this.iButtonClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iButtonClientes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iButtonClientes.ForeColor = System.Drawing.Color.White;
            this.iButtonClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iButtonClientes.IconColor = System.Drawing.Color.Black;
            this.iButtonClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iButtonClientes.Location = new System.Drawing.Point(44, 296);
            this.iButtonClientes.Name = "iButtonClientes";
            this.iButtonClientes.Size = new System.Drawing.Size(102, 44);
            this.iButtonClientes.TabIndex = 2;
            this.iButtonClientes.Text = "Clientes";
            this.iButtonClientes.UseVisualStyleBackColor = false;
            // 
            // iButtonInventario
            // 
            this.iButtonInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iButtonInventario.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iButtonInventario.ForeColor = System.Drawing.Color.White;
            this.iButtonInventario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iButtonInventario.IconColor = System.Drawing.Color.Black;
            this.iButtonInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iButtonInventario.Location = new System.Drawing.Point(44, 222);
            this.iButtonInventario.Name = "iButtonInventario";
            this.iButtonInventario.Size = new System.Drawing.Size(102, 44);
            this.iButtonInventario.TabIndex = 1;
            this.iButtonInventario.Text = "Inventario";
            this.iButtonInventario.UseVisualStyleBackColor = false;
            // 
            // iButtonVentas
            // 
            this.iButtonVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iButtonVentas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iButtonVentas.ForeColor = System.Drawing.Color.White;
            this.iButtonVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iButtonVentas.IconColor = System.Drawing.Color.Black;
            this.iButtonVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iButtonVentas.Location = new System.Drawing.Point(44, 148);
            this.iButtonVentas.Name = "iButtonVentas";
            this.iButtonVentas.Size = new System.Drawing.Size(102, 44);
            this.iButtonVentas.TabIndex = 0;
            this.iButtonVentas.Text = "Ventas";
            this.iButtonVentas.UseVisualStyleBackColor = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1270, 674);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTrabajo);
            this.Name = "FormPrincipal";
            this.Text = "Control_Inventario [Principal]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPicBoxPerfil)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTrabajo;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconProveedores;
        private FontAwesome.Sharp.IconButton iButtonClientes;
        private FontAwesome.Sharp.IconButton iButtonInventario;
        private FontAwesome.Sharp.IconButton iButtonVentas;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iButtonUsuarios;
        private FontAwesome.Sharp.IconButton iButtonInformes;
        private FontAwesome.Sharp.IconButton iButtonSalir;
        private FontAwesome.Sharp.IconPictureBox iPicBoxPerfil;
    }
}