using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace Control_Inventario
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        // Instanciamos la conexión

        conexionDB conectar = new conexionDB();

        public void Form3_Load(object sender, EventArgs e)
        {
            this.lblNombreUsuario.Text = variablesGlobales.vNombreUsuario;
            this.lblRol.Text = variablesGlobales.vRol;

            if (variablesGlobales.vRol.Contains("Auxiliar", StringComparison.OrdinalIgnoreCase))
            {
                this.iButtonInformes.Enabled = false;
                this.iButtonUsuarios.Enabled = false;  
            }  
        }
         public void habilitarBotones()

        {
            this.iButtonVentas.Enabled = true;
           /* if (variablesGlobales.vRol.Contains("Auxiliar", StringComparison.OrdinalIgnoreCase))
            {
                this.iButtonInformes.Enabled = false;
                this.iButtonUsuarios.Enabled = false;
                this.iButtonVentas.Enabled = true;
                this.iButtonInventario.Enabled = true;
                this.iButtonClientes.Enabled = true;
                this.iButtonProveedores.Enabled = true;
            }
            else
            {
                this.iButtonInformes.Enabled = true;
                this.iButtonUsuarios.Enabled = true;
                this.iButtonVentas.Enabled = true;
                this.iButtonInventario.Enabled = true;
                this.iButtonClientes.Enabled = true;
                this.iButtonProveedores.Enabled = true;
            }*/
        }

        public void iButtonUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios frmUsuarios = new FormUsuarios();
            frmUsuarios.TopLevel = false;
            panelTrabajo.Controls.Add(frmUsuarios);
            frmUsuarios.Show();
            this.iButtonVentas.Enabled = false;
            this.iButtonInventario.Enabled = false;
            this.iButtonClientes.Enabled = false;
            this.iButtonProveedores.Enabled = false;
            this.iButtonInformes.Enabled = false;
        }


        public void iButtonVentas_Click(object sender, EventArgs e)
        {
            FormVentas frmVentas = new FormVentas();
            frmVentas.TopLevel = false;
            panelTrabajo.Controls.Add(frmVentas);
            frmVentas.Show();
            this.iButtonInventario.Enabled = false;
            this.iButtonClientes.Enabled = false;
            this.iButtonProveedores.Enabled = false;
            this.iButtonInformes.Enabled = false;
            this.iButtonUsuarios.Enabled = false;
        }

        private void iButtonInventario_Click(object sender, EventArgs e)
        {
            FormInventario frmInventario = new FormInventario();
            frmInventario.TopLevel = false;
            panelTrabajo.Controls.Add(frmInventario);
            frmInventario.Show();
            this.iButtonVentas.Enabled = false;
            this.iButtonClientes.Enabled = false;
            this.iButtonProveedores.Enabled = false;
            this.iButtonInformes.Enabled = false;
            this.iButtonUsuarios.Enabled = false;

        }

        private void iButtonClientes_Click(object sender, EventArgs e)
        {
            FormClientes frmClientes = new FormClientes();
            frmClientes.TopLevel = false;
            panelTrabajo.Controls.Add(frmClientes);
            frmClientes.Show();
            this.iButtonVentas.Enabled = false;
            this.iButtonInventario.Enabled = false;
            this.iButtonUsuarios.Enabled = false;
            this.iButtonProveedores.Enabled = false;
            this.iButtonInformes.Enabled = false;
        }

        private void iButtonProveedores_Click_1(object sender, EventArgs e)
        {
            FormProveedores frmProveedores = new FormProveedores();
            frmProveedores.TopLevel = false;
            panelTrabajo.Controls.Add(frmProveedores);
            frmProveedores.Show();
            this.iButtonVentas.Enabled = false;
            this.iButtonInventario.Enabled = false;
            this.iButtonClientes.Enabled = false;
            this.iButtonUsuarios.Enabled = false;
            this.iButtonInformes.Enabled = false;
        }


        private void iButtonSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerrar sesión?",
                    "Consulta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormLogin form = new FormLogin();
                form.Show();
                this.Hide();
            }
        }
    }
}
