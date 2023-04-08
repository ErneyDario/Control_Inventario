using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Control_Inventario
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Conexion c= new Conexion();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void panelTrabajo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iButtonUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios frmUsuarios = new FormUsuarios();
            frmUsuarios.TopLevel = false;
            panelTrabajo.Controls.Add(frmUsuarios);
            frmUsuarios.Show();

        }

        private void iButtonInformes_Click(object sender, EventArgs e)
        {

        }

        private void iButtonVentas_Click(object sender, EventArgs e)
        {
            FormVentas frmVentas = new FormVentas();
            frmVentas.TopLevel = false;
            panelTrabajo.Controls.Add(frmVentas);
            frmVentas.Show();
        }

        private void iButtonInventario_Click(object sender, EventArgs e)
        {
            FormInventario frmInventario = new FormInventario();
            frmInventario.TopLevel = false;
            panelTrabajo.Controls.Add(frmInventario);
            frmInventario.Show();
        }
    }
}
