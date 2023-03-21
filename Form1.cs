namespace Control_Inventario
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labRecCont_Click(object sender, EventArgs e)
        {
            FormRecCont frm = new FormRecCont();
            frm.Show();
            this.Hide();

        }

        private void iBtnEntrar_Click(object sender, EventArgs e)
        {
            String usuario, contrasena;
            usuario = txtusuario.Text;
            contrasena = txtcontrasena.Text;

            if (usuario == "usuarioc#" && contrasena == "123")
            {
                FormPrincipal frm = new FormPrincipal();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos intentelo de nuevo");
            }
        }

        private void labelSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Segur(a)que desea salir del sistema?",
                                "consulta",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
