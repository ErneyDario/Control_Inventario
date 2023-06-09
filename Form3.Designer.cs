﻿namespace Control_Inventario
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
            panelTrabajo = new Panel();
            panel1 = new Panel();
            lblRol = new Label();
            iPicBoxPerfil = new FontAwesome.Sharp.IconPictureBox();
            lblNombreUsuario = new Label();
            panel2 = new Panel();
            iButtonSalir = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            iButtonUsuarios = new FontAwesome.Sharp.IconButton();
            iButtonInformes = new FontAwesome.Sharp.IconButton();
            iButtonProveedores = new FontAwesome.Sharp.IconButton();
            iButtonClientes = new FontAwesome.Sharp.IconButton();
            iButtonInventario = new FontAwesome.Sharp.IconButton();
            iButtonVentas = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iPicBoxPerfil).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelTrabajo
            // 
            panelTrabajo.Anchor = AnchorStyles.None;
            panelTrabajo.BackColor = Color.LavenderBlush;
            panelTrabajo.BorderStyle = BorderStyle.FixedSingle;
            panelTrabajo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            panelTrabajo.ForeColor = Color.Black;
            panelTrabajo.Location = new Point(200, 12);
            panelTrabajo.Margin = new Padding(8);
            panelTrabajo.Name = "panelTrabajo";
            panelTrabajo.Padding = new Padding(6);
            panelTrabajo.Size = new Size(1053, 660);
            panelTrabajo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblRol);
            panel1.Controls.Add(iPicBoxPerfil);
            panel1.Controls.Add(lblNombreUsuario);
            panel1.Location = new Point(11, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 115);
            panel1.TabIndex = 0;
            // 
            // lblRol
            // 
            lblRol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.Transparent;
            lblRol.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRol.ForeColor = Color.FromArgb(64, 64, 64);
            lblRol.Location = new Point(71, 63);
            lblRol.Name = "lblRol";
            lblRol.Padding = new Padding(1, 0, 20, 0);
            lblRol.RightToLeft = RightToLeft.Yes;
            lblRol.Size = new Size(95, 14);
            lblRol.TabIndex = 1;
            lblRol.Text = "RolUSuario";
            lblRol.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iPicBoxPerfil
            // 
            iPicBoxPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iPicBoxPerfil.BackColor = Color.LavenderBlush;
            iPicBoxPerfil.ForeColor = Color.Black;
            iPicBoxPerfil.IconChar = FontAwesome.Sharp.IconChar.User;
            iPicBoxPerfil.IconColor = Color.Black;
            iPicBoxPerfil.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iPicBoxPerfil.IconSize = 62;
            iPicBoxPerfil.Location = new Point(3, 20);
            iPicBoxPerfil.Name = "iPicBoxPerfil";
            iPicBoxPerfil.Size = new Size(62, 70);
            iPicBoxPerfil.SizeMode = PictureBoxSizeMode.CenterImage;
            iPicBoxPerfil.TabIndex = 0;
            iPicBoxPerfil.TabStop = false;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = Color.Transparent;
            lblNombreUsuario.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            lblNombreUsuario.Location = new Point(68, 45);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(86, 18);
            lblNombreUsuario.TabIndex = 0;
            lblNombreUsuario.Text = "UserName";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.LavenderBlush;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(iButtonSalir);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(iButtonProveedores);
            panel2.Controls.Add(iButtonClientes);
            panel2.Controls.Add(iButtonInventario);
            panel2.Controls.Add(iButtonVentas);
            panel2.Location = new Point(12, 16);
            panel2.Margin = new Padding(12);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(3);
            panel2.Size = new Size(182, 660);
            panel2.TabIndex = 2;
            // 
            // iButtonSalir
            // 
            iButtonSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iButtonSalir.BackColor = Color.LavenderBlush;
            iButtonSalir.Cursor = Cursors.Hand;
            iButtonSalir.FlatStyle = FlatStyle.Flat;
            iButtonSalir.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iButtonSalir.ForeColor = Color.FromArgb(64, 64, 64);
            iButtonSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            iButtonSalir.IconColor = Color.FromArgb(64, 64, 64);
            iButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iButtonSalir.Location = new Point(58, 587);
            iButtonSalir.Name = "iButtonSalir";
            iButtonSalir.Size = new Size(66, 63);
            iButtonSalir.TabIndex = 0;
            iButtonSalir.Text = "Salir";
            iButtonSalir.TextAlign = ContentAlignment.BottomCenter;
            iButtonSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            iButtonSalir.UseVisualStyleBackColor = false;
            iButtonSalir.Click += iButtonSalir_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LavenderBlush;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(iButtonUsuarios);
            panel3.Controls.Add(iButtonInformes);
            panel3.Location = new Point(11, 428);
            panel3.Name = "panel3";
            panel3.Size = new Size(161, 146);
            panel3.TabIndex = 3;
            // 
            // iButtonUsuarios
            // 
            iButtonUsuarios.BackColor = Color.FromArgb(64, 64, 64);
            iButtonUsuarios.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iButtonUsuarios.ForeColor = Color.White;
            iButtonUsuarios.IconChar = FontAwesome.Sharp.IconChar.None;
            iButtonUsuarios.IconColor = Color.Black;
            iButtonUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iButtonUsuarios.Location = new Point(34, 84);
            iButtonUsuarios.Name = "iButtonUsuarios";
            iButtonUsuarios.Size = new Size(102, 44);
            iButtonUsuarios.TabIndex = 5;
            iButtonUsuarios.Text = "Usuarios";
            iButtonUsuarios.UseVisualStyleBackColor = false;
            iButtonUsuarios.Click += iButtonUsuarios_Click;
            // 
            // iButtonInformes
            // 
            iButtonInformes.BackColor = Color.FromArgb(64, 64, 64);
            iButtonInformes.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iButtonInformes.ForeColor = Color.White;
            iButtonInformes.IconChar = FontAwesome.Sharp.IconChar.None;
            iButtonInformes.IconColor = Color.Black;
            iButtonInformes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iButtonInformes.Location = new Point(33, 14);
            iButtonInformes.Name = "iButtonInformes";
            iButtonInformes.Size = new Size(102, 44);
            iButtonInformes.TabIndex = 4;
            iButtonInformes.Text = "Informes";
            iButtonInformes.UseVisualStyleBackColor = false;
            // 
            // iButtonProveedores
            // 
            iButtonProveedores.BackColor = Color.FromArgb(64, 64, 64);
            iButtonProveedores.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iButtonProveedores.ForeColor = Color.White;
            iButtonProveedores.IconChar = FontAwesome.Sharp.IconChar.None;
            iButtonProveedores.IconColor = Color.Black;
            iButtonProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iButtonProveedores.Location = new Point(44, 367);
            iButtonProveedores.Name = "iButtonProveedores";
            iButtonProveedores.Size = new Size(102, 44);
            iButtonProveedores.TabIndex = 3;
            iButtonProveedores.Text = "Proveedores";
            iButtonProveedores.UseVisualStyleBackColor = false;
            iButtonProveedores.Click += iButtonProveedores_Click_1;
            // 
            // iButtonClientes
            // 
            iButtonClientes.BackColor = Color.FromArgb(64, 64, 64);
            iButtonClientes.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iButtonClientes.ForeColor = Color.White;
            iButtonClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            iButtonClientes.IconColor = Color.Black;
            iButtonClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iButtonClientes.Location = new Point(44, 296);
            iButtonClientes.Name = "iButtonClientes";
            iButtonClientes.Size = new Size(102, 44);
            iButtonClientes.TabIndex = 2;
            iButtonClientes.Text = "Clientes";
            iButtonClientes.UseVisualStyleBackColor = false;
            iButtonClientes.Click += iButtonClientes_Click;
            // 
            // iButtonInventario
            // 
            iButtonInventario.BackColor = Color.FromArgb(64, 64, 64);
            iButtonInventario.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iButtonInventario.ForeColor = Color.White;
            iButtonInventario.IconChar = FontAwesome.Sharp.IconChar.None;
            iButtonInventario.IconColor = Color.Black;
            iButtonInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iButtonInventario.Location = new Point(44, 222);
            iButtonInventario.Name = "iButtonInventario";
            iButtonInventario.Size = new Size(102, 44);
            iButtonInventario.TabIndex = 1;
            iButtonInventario.Text = "Inventario";
            iButtonInventario.UseVisualStyleBackColor = false;
            iButtonInventario.Click += iButtonInventario_Click;
            // 
            // iButtonVentas
            // 
            iButtonVentas.BackColor = Color.FromArgb(64, 64, 64);
            iButtonVentas.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iButtonVentas.ForeColor = Color.White;
            iButtonVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            iButtonVentas.IconColor = Color.Black;
            iButtonVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iButtonVentas.Location = new Point(44, 148);
            iButtonVentas.Name = "iButtonVentas";
            iButtonVentas.Size = new Size(102, 44);
            iButtonVentas.TabIndex = 0;
            iButtonVentas.Text = "Ventas";
            iButtonVentas.UseVisualStyleBackColor = false;
            iButtonVentas.Click += iButtonVentas_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1270, 674);
            Controls.Add(panel2);
            Controls.Add(panelTrabajo);
            Name = "FormPrincipal";
            Text = "Control_Inventario [Principal]";
            WindowState = FormWindowState.Maximized;
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iPicBoxPerfil).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTrabajo;
        private Panel panel1;
        private Label lblRol;
        private Label lblNombreUsuario;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iButtonProveedores;
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