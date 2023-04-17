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
    public partial class FormUsuarios : Form
    {
        Conexion c = new Conexion();
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c.UsuarioRegistrado(txtIdUsuario.Text) == 0)
            {
                c.insertar(txtIdUsuario.Text, txtPrimerNombreUsuar.Text, txtsegundoNombreUsuar.Text, txtPrimerApellidoUsuar.Text, txtSegundoApellidoUsuar.Text, txtDireccionUsuar.Text, txtcorreoUsuar.Text, txtNombreUsuario.Text, txtContrseña.Text, txttelefono.Text, txtConfirmar.Text);
                MessageBox.Show(c.insertar(txtIdUsuario.Text, txtPrimerNombreUsuar.Text, txtsegundoNombreUsuar.Text, txtPrimerApellidoUsuar.Text, txtSegundoApellidoUsuar.Text, txtDireccionUsuar.Text, txtcorreoUsuar.Text, txtNombreUsuario.Text, txtContrseña.Text, txttelefono.Text, txtConfirmar.Text));

            }
            else
            {
                MessageBox.Show("no es posible registrar, el usuario ya existe");
            }

        }

        private string String(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9, string text10, string text11)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {



        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "";
            this.txtIdUsuario.Text = "";
            this.txtPrimerNombreUsuar.Text = "";
            this.txtsegundoNombreUsuar.Text = "";
            this.txtSegundoApellidoUsuar.Text = "";
            this.txtPrimerApellidoUsuar.Text = "";
            this.txtDireccionUsuar.Text = "";
            this.txtcorreoUsuar.Text = "";
            this.txttelefono.Text = "";
            this.txtNombreUsuario.Text = "";
            this.txtContrseña.Text = "";
            this.txtConfirmar.Text = "";

            rbtn1.Checked = false;
            rbtn2.Checked = false;
            rbtn3.Checked = false;
            rbtnCEX.Checked = false;
            rbtnTI.Checked = false;
            rbtnCC.Checked = false;
            rbtnPass.Checked = false;













        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            c.CargarUsuario(dgvUsuario);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿desea salir y volver al menu principal?",
                    "consulta",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormPrincipal Form = new FormPrincipal();
                Form.Show();
                this.Hide();
            }




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormUsuarios_Load_1(object sender, EventArgs e)
        {

        }
    }
}


