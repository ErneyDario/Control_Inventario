using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Inventario
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            c.CargarVentas(dgvVentas);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿decea salir de ventas?, revise que no tengas productos ingresados",
                    "Consulta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormPrincipal form = new FormPrincipal();
                form.Show();
                this.Hide();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.txtarticulo.Text = "";
            this.txtcodigo.Text = "";
            this.txtexistencias.Text = "";
            this.txtarti.Text = "";
            this.txtdescripcion.Text = "";
            this.txtvalor.Text = "";
            this.txtcantidad.Text = "";
            this.txttotal.Text = "";
            
            rbtncodigo.Checked= false;
            rbtnnombre.Checked = false;
            rbtndescripcion.Checked = false;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

