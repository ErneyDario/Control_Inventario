using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Control_Inventario
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        //Instanaciamos conexion a DB
        conexionDB conectar = new conexionDB();
        // Creamos varible para condicionar los campos vacios
        bool ok;
        //Creamos e inicializamos la variable que capturara el valor del radiobutton seleccionado
        string tipoDocumento = "";
        //
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            //Ocultamos el Icono que nos indican si la contraseña y la confirmacion sondiferentes
            if (txtContrasena.Text == "")
            {
                this.iconPictureBox7.Visible = false;
            }
        }
        //Creamos un metodo para confirmar que los campos requeridos no esten vacios
        private bool confirmarTXT()
        {
            ok = true;

            if (txtNumeroDoc.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNumeroDoc, "Ingrese el Numero de Documento del Usuario");
            }
            else
            {
                if (txtPrimerNombre.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(txtPrimerNombre, "ingrese por favor el Nombre del Usuario");
                }
                else
                {
                    if (txtPrimerApellido.Text == "")
                    {
                        ok = false;
                        errorProvider1.SetError(txtPrimerApellido, "ingrese por favor el Apellido del Usuario");
                    }
                    else
                    {
                        if (txtCorreo.Text == "")
                        {
                            ok = false;
                            errorProvider1.SetError(txtCorreo, "ingrese por favor un Correo Electronico");
                        }
                        else
                        {
                            if (txtUsuario.Text == "")
                            {
                                ok = false;
                                errorProvider1.SetError(txtUsuario, "ingrese por favor un Nombre de Usuario");
                            }
                            else
                            {
                                if (txtContrasena.Text == "")
                                {
                                    ok = false;
                                    errorProvider1.SetError(txtContrasena, "ingrese por favor una Contraseña");
                                }
                                else
                                {
                                    if (txtConfirmarContrasena.Text == "")
                                    {
                                        ok = false;
                                        errorProvider1.SetError(txtConfirmarContrasena, "Por favor confirme la Contraseña");
                                    }
                                    else
                                    {
                                        if (cmbRol.SelectedIndex == -1)
                                        {
                                            ok = false;
                                            errorProvider1.SetError(cmbRol, "Por favor seleccione un rolo");
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            }
            return ok;
        }
        //creamos un metodo para limpar los errores de los campos vacios
        private void limpiarConfirmarTXT()
        {
            errorProvider1.SetError(txtNumeroDoc, "");
            errorProvider1.SetError(txtPrimerNombre, "");
            errorProvider1.SetError(txtPrimerApellido, "");
            errorProvider1.SetError(txtCorreo, "");
            errorProvider1.SetError(txtUsuario, "");
            errorProvider1.SetError(txtContrasena, "");
            errorProvider1.SetError(txtConfirmarContrasena, "");
            errorProvider1.SetError(cmbRol, "");
        }
        //Creamos un metodo para limpiar los cambios 
        private void limpiarCampos()
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
            this.dtgvEncontrados.DataSource = null;
        }
        //Creamos un metodo para insertar un nuevo registro
        private void nuevoRegistro()
        {
            //consultamos el numero de Documento ingresado para verificar que no este registrado
            conectar.abrirDB();
            SqlCommand consultaId = new SqlCommand("SELECT * FROM Usuarios WHERE Id = @Id", conectar.conectarDB);
            consultaId.Parameters.AddWithValue("@Id", txtNumeroDoc.Text);
            SqlDataReader valorId = consultaId.ExecuteReader();

            if (!valorId.Read())
            {
                conectar.cerrarDB();
                // Condultamos el nombre de usruario, para evitar que hayan duplicados
                conectar.abrirDB();
                SqlCommand consultaUser = new SqlCommand("SELECT * FROM Usuarios WHERE usuario = @usuario", conectar.conectarDB);
                consultaUser.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                SqlDataReader valorUser = consultaUser.ExecuteReader();

                if (!valorUser.Read())
                {
                    conectar.cerrarDB();
                    //Realizamos el nuevo registro
                    conectar.abrirDB();
                    string crear = "Insert into Usuarios ([Id], [tipoDocumento], [primerNombre], [segundoNombre], [primerApellido], [segundoApellido], [direccion], [telefono], [correo], [usuario], [password], [rol])" +
                               "values ('" + txtNumeroDoc.Text + "', '" + tipoDocumento + "', '" + txtPrimerNombre.Text + "', '" + txtSegundoNombre.Text + "', '" + txtPrimerApellido.Text + "', '" + txtSegundoApellido.Text + "', '" + txtDireccion.Text + "', '" + txtTelefono.Text + "', '" + txtCorreo.Text + "', '" + txtUsuario.Text + "', '" + txtContrasena.Text + "', '" + cmbRol.GetItemText(cmbRol.SelectedItem) + "')";
                    SqlCommand comando = new SqlCommand(crear, conectar.conectarDB);
                    comando.ExecuteNonQuery();
                    //Invocamos el metodo para limpiarlos campos
                    limpiarCampos();

                    MessageBox.Show("Registro agregado con exito");
                    conectar.cerrarDB();
                    if (MessageBox.Show("¿desea Agregar otro registro?",
                       "Consulta",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) == DialogResult.No)
                    {
                        this.panel2.Enabled = false;
                    }
                }
                else
                {
                    conectar.cerrarDB();
                    MessageBox.Show("El nombre de usuario ya existe, por favor ingrese uno diferente");
                }
            }
            else
            {
                conectar.cerrarDB();
                MessageBox.Show("el Documento ingresado ya se encuentra en la Base de Datos");
            }


        }
        // Condicionamos txtNumeroDoc para que reciba solo numeros
        private void txtNumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = CondicionandoTxt.soloNum(e);
            if (!validar)
                errorProvider1.SetError(txtNumeroDoc, "Ingrese solo numeros");
            else
                errorProvider1.SetError(txtNumeroDoc, "");
        }
        // Condicionamos el txtCorreo para que reciba formatos de correo solamente
        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (!CondicionandoTxt.soloEmail(txtCorreo.Text))
                errorProvider1.SetError(txtCorreo, "Ingrese un correo valido");
            else
                errorProvider1.SetError(txtCorreo, "");
        }
        //configuramos el boton Crear 
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = false;
            this.panel2.Enabled = true;
        }
        //Configuramos el boton crear
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            confirmarTXT(); //invocamos el metodo para validar que los campos no esten vacios
            limpiarConfirmarTXT(); //Invocamos el metodo que limpia los errores de los campos diligenciados
            if (confirmarTXT()) //condicionamos que mientras no haya errores en los txt pueda guardar el registro 
            {
                if (txtContrasena.Text == txtConfirmarContrasena.Text) //Condicionamos que la contraseña coincida con la confirmación
                {
                    this.iconPictureBox7.Enabled = false;
                    //capturamos el valor del rbt y ejecutamos el registro invocando el metodo
                    if (rbtnTipoCC.Checked == true)
                    {
                        tipoDocumento += rbtnTipoCC.Text;
                        nuevoRegistro();

                    }
                    else
                    {
                        if (rbtnTipoCEx.Checked == true)
                        {
                            tipoDocumento += rbtnTipoCEx.Text;
                            nuevoRegistro();
                        }
                        else
                        {
                            if (rbtnPasaporte.Checked == true)
                            {
                                tipoDocumento += rbtnPasaporte.Text;
                                nuevoRegistro();
                            }
                            else
                            {
                                MessageBox.Show("Por favor seleccion un tipo de documento"); //condicionamos el radiobutton para que no este vacio
                            }
                        }
                    }
                }
                else
                {
                    this.iconPictureBox7.Visible = true;
                    MessageBox.Show("La contraseña ingresada y la confirmación de contraseña,  no coinciden");
                }
            }
            else
            {
                MessageBox.Show("Por favor diligencie todos los datos");
            }

        }
        //Configuramos el boton Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = true;
            this.panel2.Enabled = false;
        }
        //Configuramos el boton Buscar
        private void iBtnBuscar_Click(object sender, EventArgs e)
        {
            //Condicionamos la busqueda segun el tipo
            if (rbtnId.Checked == true)
            {
                string consulta = " select * from Usuarios where Id= " + txtBuscarUsuario.Text + " ";
                SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                {
                    dtgvEncontrados.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                    limpiarCampos();
                }
            }
            else
            {
                if (rbtnNombre.Checked == true)
                {
                    string consulta = " select * from Usuarios where primerNombre = '" + txtBuscarUsuario.Text + "' OR segundoNombre = '" + txtBuscarUsuario.Text + "' OR primerApellido = '" + txtBuscarUsuario.Text + "' OR segundoApellido = '" + txtBuscarUsuario.Text + "' ";
                    SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                    SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                    {
                        dtgvEncontrados.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                        limpiarCampos();
                    }
                }
                else
                {
                    if (rbtnUsuario.Checked == true)
                    {
                        string consulta = " select * from Usuarios where usuario= '" + txtBuscarUsuario.Text + "' ";
                        SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                        SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                        {
                            dtgvEncontrados.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                            limpiarCampos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor seleccion un tipo de busqueda");
                    }
                }
            }
        }
        //limpiamos txt y rbtn
        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        //Configuramos el boton salir
        private void iButtonSalir_Click(object sender, EventArgs e)
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

        private void dtgvEncontrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.panel2.Enabled = true;
            txtNumeroDoc.Text = dtgvEncontrados.SelectedCells[0].Value.ToString();
            txtPrimerNombre.Text = dtgvEncontrados.SelectedCells[2].Value.ToString();
            txtSegundoNombre.Text = dtgvEncontrados.SelectedCells[3].Value.ToString();
            txtPrimerApellido.Text = dtgvEncontrados.SelectedCells[4].Value.ToString();
            txtSegundoApellido.Text = dtgvEncontrados.SelectedCells[5].Value.ToString();
            txtDireccion.Text = dtgvEncontrados.SelectedCells[6].Value.ToString();
            txtTelefono.Text = dtgvEncontrados.SelectedCells[7].Value.ToString();
            txtCorreo.Text = dtgvEncontrados.SelectedCells[8].Value.ToString();
            txtUsuario.Text = dtgvEncontrados.SelectedCells[9].Value.ToString();
            txtContrasena.Text = dtgvEncontrados.SelectedCells[10].Value.ToString();
            txtConfirmarContrasena.Text = txtContrasena.Text;
            cmbRol.SelectedText = dtgvEncontrados.SelectedCells[11].Value.ToString();
            /*if (dtgvEncontrados.SelectedCells[1].Value.ToString() == rbtnCC.Text)
            {
                rbtnCC.Checked = true;
            }
            else
            {
                if (dtgvEncontrados.SelectedCells[1].Value.ToString() == rbtnCEX.Text)
                {
                    rbtnCEX.Checked = true;
                }
                else
                {
                    if (dtgvEncontrados.SelectedCells[1].Value.ToString() == rbtnPasaporte.Text)
                    {
                        rbtnPasaporte.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("Verifique el tipo de Documento");
                    }
                }
            }*/
        }
    }
}
