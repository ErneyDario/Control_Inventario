using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        // Conexion c = new Conexion();
        public FormUsuarios()
        {
            InitializeComponent();
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

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            this.panel2.Enabled = true;

        }
        //limpiamos txt y rbtn
        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            this.txtBuscarUsuario.Text = "";
            this.txtNumeroDoc.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.txtCorreo.Text = "";
            this.txtPrimerNombre.Text = "";
            this.txtSegundoNombre.Text = "";
            this.txtPrimerApellido.Text = "";
            this.txtSegundoApellido.Text = "";
            this.txtUsuario.Text = "";
            this.txtContrasena.Text = "";
            this.txtConfirmarContrasena.Text = "";
            this.cmbRol.ResetText(); ; //Limpiamos combobox
            this.rbtnId.Checked = false;
            this.rbtnNombre.Checked = false;
            this.rbtnUsuario.Checked = false;
            this.rbtnTipoCC.Checked = false;
            this.rbtnTipoCEx.Checked = false;
            this.rbtnPasaporte.Checked = false;

        }
        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           //Instanaciamos conexion a DB
            conexionDB conectar = new conexionDB();

            //Creamos e inicializamos la variable que capturara el valor del radiobutton seleccionado
            string tipoDocumento = "";

            //Condicionamos la seleccion del radiobutton
            if (rbtnTipoCC.Checked == true) 
            {
                tipoDocumento += rbtnTipoCC.Text;
            }
            else
            {
                if (rbtnTipoCEx.Checked == true)
                {
                    tipoDocumento += rbtnTipoCEx.Text;
                }
                else
                {

                    if (rbtnPasaporte.Checked == true)
                    {
                        tipoDocumento += rbtnPasaporte.Text;
                    }
                    else
                    {
                        MessageBox.Show("Por favor seleccion un tipo de documento"); //condicionamos el radiobutton para que no este vacio
                    }

                }
            }
            //MessageBox.Show(tipoDocumento);

            //abrimos la base de datos e insertamos el registro
            conectar.abrirDB();
            string crear = "Insert into Usuarios ([Id], [tipoDocumento], [primerNombre], [segundoNombre], [primerApellido], [segundoApellido], [direccion], [telefono], [correo], [usuario], [password], [rol])" +
                   "values ('"+txtNumeroDoc.Text+"', '"+tipoDocumento+"', '"+txtPrimerNombre.Text+"', '"+txtSegundoNombre.Text+"', '"+txtPrimerApellido.Text+"', '"+txtSegundoApellido.Text+ "', '"+txtDireccion.Text+"', '"+txtTelefono.Text+"', '"+txtCorreo.Text+"', '"+txtUsuario.Text+"', '"+txtContrasena.Text+"', '"+cmbRol.GetItemText(cmbRol.SelectedItem)+"')";
            SqlCommand comando = new SqlCommand(crear, conectar.conectarDB);
            comando.ExecuteNonQuery();

            MessageBox.Show("Registro agregado con exito");

            this.txtNumeroDoc.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.txtCorreo.Text = "";
            this.txtPrimerNombre.Text = "";
            this.txtSegundoNombre.Text = "";
            this.txtPrimerApellido.Text = "";
            this.txtSegundoApellido.Text = "";
            this.txtUsuario.Text = "";
            this.txtContrasena.Text = "";
            this.txtConfirmarContrasena.Text = "";
            this.cmbRol.ResetText(); ; //Limpiamos combobox
            this.rbtnId.Checked = false;
            this.rbtnNombre.Checked = false;
            this.rbtnUsuario.Checked = false;
            this.rbtnTipoCC.Checked = false;
            this.rbtnTipoCEx.Checked = false;
            this.rbtnPasaporte.Checked = false;
            conectar.cerrarDB();
        }
    }
}




