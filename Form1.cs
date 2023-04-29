using System.Data.SqlClient;

namespace Control_Inventario
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        //Instanciamos la clase conexion
        conexionDB conectar = new conexionDB(); 

        private void labRecCont_Click(object sender, EventArgs e)
        {
            FormRecCont frm = new FormRecCont();
            frm.Show();
            this.Hide();
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

        private void iButtonEntrar_Click(object sender, EventArgs e)
        {
            //Abrit coneccion a DB
            conectar.abrirDB();
            // Consultar Uasuario
            SqlCommand comando = new SqlCommand("SELECT usuario, password FROM Usuarios WHERE usuario = @vusuario AND password =  @vpassword", conectar.conectarDB);
            comando.Parameters.AddWithValue("@vusuario", txtusuario.Text);
            comando.Parameters.AddWithValue("@vpassword", txtcontrasena.Text);
            SqlDataReader valores = comando.ExecuteReader();
            
            if (valores.Read())
            {
                conectar.cerrarDB();
                FormPrincipal frm = new FormPrincipal();
                frm.Show();
                this.Hide();
            }
            else
            {
                conectar.cerrarDB();
                MessageBox.Show("El usuario o contraseña son incorrectos, Verifique y vuelva a intentarlo");
                txtusuario.Text = "";
                txtcontrasena.Text = "";
            }




        }
    }
}
