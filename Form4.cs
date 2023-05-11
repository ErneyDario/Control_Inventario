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
        //Creamos e inicializamos las variables que captura el valor de Id a actualizar y a eliminar
        string IdActualizar = "";
        string IdEliminar = "";
        //
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            //Ocultamos el Icono que nos indican si la contraseña y la confirmacion son diferentes
            if (txtContrasena.Text == "")
            {
                this.iconPictureBox7.Visible = false;
            }
            //gestionamos los botnes al iniciar el form usuarios
            this.btnCrearUsuario.Visible = true;
            this.btnGuardarCambios.Visible = false;
            this.btnEliminarRegistro.Visible = false;
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
        //Creamos un metodo para limpiar los campos 
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
            limpiarConfirmarTXT();
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
                // Consultamos el nombre de usuario, para evitar que hayan duplicados
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
                        this.panel1.Enabled = false;
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
        //Creamos un metodo para actualizar un registro
        private void actualizarRegistro()
        {
            //creamos una variable para almacenar el paramatro a actualizar
            IdActualizar = txtNumeroDoc.Text;
            //actualizamos el registro
            conectar.abrirDB();
            string cadena = "UPDATE Usuarios SET Id = '" + txtNumeroDoc.Text + "', tipoDocumento = '" + tipoDocumento + "', primerNombre = '" + txtPrimerNombre.Text + "', segundoNombre ='" + txtSegundoNombre.Text + "'," +
                            " primerApellido = '" + txtPrimerApellido.Text + "', segundoApellido = '" + txtSegundoApellido.Text + "', direccion = '" + txtDireccion.Text + "' , telefono= '" + txtTelefono.Text + "'," +
                            " correo = '" + txtCorreo.Text + "' , usuario =  '" + txtUsuario.Text + "', password = '" + txtContrasena.Text + "', rol= '" + cmbRol.GetItemText(cmbRol.SelectedItem) + "' WHERE Id = '" + IdActualizar + "'";
            SqlCommand comando = new SqlCommand(cadena, conectar.conectarDB);
            comando.ExecuteNonQuery();
            //Invocamos el metodo para limpiarlos campos
            limpiarCampos();

            MessageBox.Show("Registro actualizado con Exito");
            conectar.cerrarDB();
            if (MessageBox.Show("¿desea Actualizar otro registro?",
               "Consulta",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.No)

            {
                this.panel2.Enabled = false;
                this.panel1.Enabled = false;
            }
            else
            {
                this.panel2.Enabled = false;
            }
        }
        //Creamos un metodo para Eliminar un registro
        private void EliminarRegistros()
        {
            IdEliminar = txtNumeroDoc.Text;
            conectar.abrirDB();
            string cadena = "Delete from Usuarios Where  Id = " + IdEliminar + "";
            SqlCommand comando = new SqlCommand(cadena, conectar.conectarDB);
            comando.ExecuteNonQuery();
            conectar.cerrarDB();
            MessageBox.Show("Registro Eliminado correctamente");
            // Invocamos el metodo para limpiar campos
            limpiarCampos();

            if (MessageBox.Show("¿desea Eliminar otro registro?",
               "Consulta",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.No)

            {
                this.panel2.Enabled = false;
                this.panel1.Enabled = false;
            }
            else
            {
                this.panel2.Enabled = false;


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
        // Condicionamos txtBuscarUsuario para que reciba solo numeros
        private void txtBuscarUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (rbtnId.Checked == true)
            {
                bool validar = CondicionandoTxt.soloNum(e);
                if (!validar)
                    errorProvider1.SetError(txtBuscarUsuario, "Ingrese solo numeros");
                else
                    errorProvider1.SetError(txtBuscarUsuario, "");
            }
            /*else
           {
                bool validar = CondicionandoTxt.soloTex(e);
                if (!validar)
                    errorProvider1.SetError(txtBuscarUsuario, "Ingrese solo Texto");
                else
                    errorProvider1.SetError(txtBuscarUsuario, "");
            }*/

        }
        // Condicionamos el txtCorreo para que reciba formatos de correo solamente
        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (!CondicionandoTxt.soloEmail(txtCorreo.Text))
                errorProvider1.SetError(txtCorreo, "Ingrese un correo valido");
            else
                errorProvider1.SetError(txtCorreo, "");
        }
        //Controlamos el rbtnId para evitar errores en la busqueda
        private void rbtnId_Click(object sender, EventArgs e)
        {
            txtBuscarUsuario.Text = "";
        }
        //tomamos el valor del drgv y lo enviamos a los txt del panel 2 para su edicion
        private void dtgvEncontrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.panel2.Enabled = true;
            txtNumeroDoc.Text = dtgvEncontrados.SelectedCells[0].Value.ToString();
            tipoDocumento = dtgvEncontrados.SelectedCells[1].Value.ToString(); //asignamos valor a la variable tipoDocumento para obtener el valor del rbtn
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
            // Condicionamos el valor retornado del dtgv en el campo rol para seleccionar el cmbRol
            if (dtgvEncontrados.SelectedCells[11].Value.ToString().Contains("Auxiliar"))
            {
                cmbRol.SelectedIndex = 1;
            }
            else
            {
                if (dtgvEncontrados.SelectedCells[11].Value.ToString().Contains("Administrador"))
                {
                    cmbRol.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Verifique y seleccione un rol para el usuario");
                }


            }
            
            //condicion para determinar el rbtn seleccionado
            if (tipoDocumento.Contains("CC"))
            {
                rbtnTipoCC.Checked = true;
            }
            else
            {
                if (tipoDocumento.Contains("C. Ext."))
                {
                    rbtnTipoCEx.Checked = true;
                }
                else
                {
                    if (tipoDocumento.Contains("Pasaporte"))
                    {
                        rbtnPasaporte.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("Verifique el tipo de Documento");
                    }
                }
            }
        }
        //Configuramos el boton Buscar
        private void iBtnBuscar_Click(object sender, EventArgs e)
        {
            //Condicionamos el txtBuscarUsuario para que no este vacio al momento de realizar la consulta
            bool ConfirmarParametro = true;

            if (txtBuscarUsuario.Text == "")
            {
                ConfirmarParametro = false;
                errorProvider1.SetError(txtBuscarUsuario, "Ingrese un parametro de busqueda");
            }
            else
            {
                errorProvider1.SetError(txtBuscarUsuario, "");

                //Condicionamos la busqueda segun el tipo
                if (rbtnId.Checked == true)
                {

                    string consulta = " select * from Usuarios where Id= " + txtBuscarUsuario.Text + "";
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
        }
        //configuramos el boton Crear 
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = false;
            this.panel2.Enabled = true;
            this.btnRegistrar.Visible = true;
            this.btnGuardarCambios.Visible = false;
            this.btnEliminarRegistro.Visible = false;
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
            this.btnGuardarCambios.Visible = true;
            this.btnEliminarRegistro.Visible = false;
            this.btnRegistrar.Visible = false;
        }
        //configuramos el btnGuardarCambios
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            limpiarConfirmarTXT();
            if (confirmarTXT())
            {
                if (txtContrasena.Text == txtConfirmarContrasena.Text)
                {
                    this.iconPictureBox7.Visible = false;
                    if (rbtnTipoCC.Checked == true)
                    {
                        tipoDocumento = rbtnTipoCC.Text;
                        actualizarRegistro();
                    }
                    else
                    {
                        if (rbtnTipoCEx.Checked == true)
                        {
                            tipoDocumento += rbtnTipoCEx.Text;
                            actualizarRegistro();
                        }
                        else
                        {
                            if (rbtnPasaporte.Checked == true)
                            {
                                tipoDocumento = rbtnPasaporte.Text;
                                actualizarRegistro();
                            }
                            else
                            {
                                MessageBox.Show("Seleccione un tipo de Documento");
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
                MessageBox.Show("Verifique los espacios con error y diligencielos");
            }
        }
        //configuramos el boton Eliminar
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            this.panel1.Enabled = true;
            this.panel2.Enabled = false;
            this.btnEliminarRegistro.Visible = true;
            this.btnGuardarCambios.Visible = false;
            this.btnRegistrar.Visible = false;
        }
        //Configuramos el boton EliminarRegistro 
        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            limpiarConfirmarTXT();
            if (confirmarTXT())
            {
                //llamamos al metodo
                EliminarRegistros();
            }
            else
            {
                MessageBox.Show("Verifique los espacios con error y diligencielos");
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
                Form.habilitarBotones();
                this.Close();
            }
        }


    }
}

