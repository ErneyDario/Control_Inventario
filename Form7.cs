using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Inventario
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }
        string tipoDocumento = "";
        string IdActualizar = "";
        string IdEliminar = "";
        bool ok;
        conexionDB conectar = new conexionDB();
        private void nuevoRegistro()
        {
            //consultamos el numero de Documento ingresado para verificar que no este registrado
            conectar.abrirDB();
            SqlCommand consultaId = new SqlCommand("SELECT * FROM Clientes WHERE Id = @Id", conectar.conectarDB);
            consultaId.Parameters.AddWithValue("@Id", txtNumeroDoc.Text);
            SqlDataReader valorId = consultaId.ExecuteReader();

            if (!valorId.Read())
            {
                conectar.cerrarDB();
                //Realizamos el nuevo registro
                conectar.abrirDB();
                string crear = "Insert into Clientes ([Id], [tipoDoc], [primerNombre], [segundoNombre], [primerApellido], [segundoApellido], [direccion], [telefono], [correo])" +
                           "values ('" + txtNumeroDoc.Text + "', '" + tipoDocumento + "', '" + txtPrimerNombre.Text + "', '" + txtSegundoNombre.Text + "', '" + txtPrimerApellido.Text + "', '" + txtSegundoApellido.Text + "', '" + txtDireccion.Text + "', '" + txtTelefono.Text + "', '" + txtCorreo.Text + "')";
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
                    this.panel1.Enabled = false;
                    this.panel2.Enabled = false;
                }
            }
            else
            {
                conectar.cerrarDB();
                MessageBox.Show("el Documento ingresado ya se encuentra en la Base de Datos");
            }
        }
        private void actualizarRegistro()
        {
            //creamos una variable para almacenar el paramatro a actualizar
            IdActualizar = txtNumeroDoc.Text;
            //actualizamos el registro
            conectar.abrirDB();
            string cadena = "UPDATE Clientes SET Id = '" + txtNumeroDoc.Text + "', tipoDoc = '" + tipoDocumento + "', primerNombre = '" + txtPrimerNombre.Text + "', segundoNombre ='" + txtSegundoNombre.Text + "'," +
                            " primerApellido = '" + txtPrimerApellido.Text + "', segundoApellido = '" + txtSegundoApellido.Text + "', direccion = '" + txtDireccion.Text + "' , telefono= '" + txtTelefono.Text + "'," +
                            " correo = '" + txtCorreo.Text + "'  WHERE Id = '" + IdActualizar + "'";
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
        private void EliminarRegistros()
        {
            IdEliminar = txtNumeroDoc.Text;
            conectar.abrirDB();
            string cadena = "Delete from Clientes Where  Id = " + IdEliminar + "";
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
                this.panel1.Enabled = false;


            }


        }
        private void FormClientes_Load(object sender, EventArgs e)
        {
            this.btnRegistar.Visible = true;
            this.btnGuardarCambios.Visible = false;
            this.btnEliminarRegistro.Visible = false;
        }
        private bool confirmarTXT()
        {
            ok = true;

            if (txtNumeroDoc.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNumeroDoc, "Ingrese el Numero de Documento del Cliente");
            }
            else
            {
                if (txtPrimerNombre.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(txtPrimerNombre, "ingrese por favor el Nombre del Cliente");
                }
                else
                {
                    if (txtPrimerApellido.Text == "")
                    {
                        ok = false;
                        errorProvider1.SetError(txtPrimerApellido, "ingrese por favor el Apellido del Cliente");
                    }
                    else
                    {
                        if (txtCorreo.Text == "")
                        {
                            ok = false;
                            errorProvider1.SetError(txtCorreo, "ingrese por favor un Correo ");
                        }
                        else
                        {
                            if (txtTelefono.Text == "")
                            {
                                ok = false;
                                errorProvider1.SetError(txtTelefono, "ingrese por favor un Nombre de Usuario");
                            }
                        }
                    }
                }
            }
            return ok;
        }
        private void txtNumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = CondicionandoTxt.soloNum(e);
            if (!validar)
                errorProvider1.SetError(txtNumeroDoc, "Ingrese solo numeros");
            else
                errorProvider1.SetError(txtNumeroDoc, "");
        }
        private void txtBuscarClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbtnBuscarId.Checked == true)
            {
                bool validar = CondicionandoTxt.soloNum(e);
                if (!validar)
                    errorProvider1.SetError(txtBuscarClientes, "Ingrese solo numeros");
                else
                    errorProvider1.SetError(txtBuscarClientes, "");
            }
        }
        private void rbtnBuscarId_Click(object sender, EventArgs e)
        {
            txtBuscarClientes.Text = "";
        }
        private void limpiarConfirmarTXT()
        {
            errorProvider1.SetError(txtNumeroDoc, "");
            errorProvider1.SetError(txtPrimerNombre, "");
            errorProvider1.SetError(txtPrimerApellido, "");
            errorProvider1.SetError(txtCorreo, "");
            errorProvider1.SetError(txtTelefono, "");
        }
        private void limpiarCampos()
        {
            this.txtBuscarClientes.Text = "";
            this.txtNumeroDoc.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.txtCorreo.Text = "";
            this.txtPrimerNombre.Text = "";
            this.txtSegundoNombre.Text = "";
            this.txtPrimerApellido.Text = "";
            this.txtSegundoApellido.Text = "";
            this.rbtnBuscarId.Checked = false;
            this.rbtnBuscarNombre.Checked = false;
            this.rbtnTi.Checked = false;
            this.rbtnCC.Checked = false;
            this.rbtnCEx.Checked = false;
            this.rbtnPass.Checked = false;
            this.dtgvEncontrados.DataSource = null;
            limpiarConfirmarTXT();
        }
        private void btnCrearClientes_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = false;
            this.panel2.Enabled = true;
            this.btnRegistar.Visible = true;
            this.btnGuardarCambios.Visible = false;
            this.btnEliminarRegistro.Visible = false;
        }
        private void btnRegistar_Click(object sender, EventArgs e)
        {
            confirmarTXT(); //invocamos el metodo para validar que los campos no esten vacios
            limpiarConfirmarTXT(); //Invocamos el metodo que limpia los errores de los campos diligenciados
            if (confirmarTXT()) //condicionamos que mientras no haya errores en los txt pueda guardar el registro 
            {
                //capturamos el valor del rbt y ejecutamos el registro invocando el metodo
                if (rbtnTi.Checked == true)
                {
                    tipoDocumento += rbtnTi.Text;
                    nuevoRegistro();
                    tipoDocumento = "";
                }
                else
                {
                    if (rbtnCC.Checked == true)
                    {
                        tipoDocumento += rbtnCC.Text;
                        nuevoRegistro();
                        tipoDocumento = "";

                    }
                    else
                    {
                        if (rbtnCEx.Checked == true)
                        {
                            tipoDocumento += rbtnCEx.Text;
                            nuevoRegistro();
                            tipoDocumento = "";
                        }
                        else
                        {
                            if (rbtnPass.Checked == true)
                            {
                                tipoDocumento += rbtnPass.Text;
                                nuevoRegistro();
                                tipoDocumento = "";
                            }
                            else
                            {
                                MessageBox.Show("Por favor seleccion un tipo de documento");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor diligencie todos los datos");
            }

        }
        private void iconButtonBuscarClientes_Click(object sender, EventArgs e)
        {
            //Condicionamos el txtBuscarUsuario para que no este vacio al momento de realizar la consulta
            bool ConfirmarParametro = true;

            if (txtBuscarClientes.Text == "")
            {
                ConfirmarParametro = false;
                errorProvider1.SetError(txtBuscarClientes, "Ingrese un parametro de busqueda");
            }
            else
            {
                errorProvider1.SetError(txtBuscarClientes, "");

                //Condicionamos la busqueda segun el tipo
                if (rbtnBuscarId.Checked == true)
                {

                    string consulta = " select * from Clientes where Id= " + txtBuscarClientes.Text + "";
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
                    if (rbtnBuscarNombre.Checked == true)
                    {
                        string consulta = " select * from Clientes where primerNombre = '" + txtBuscarClientes.Text + "' OR segundoNombre = '" + txtBuscarClientes.Text + "' OR primerApellido = '" + txtBuscarClientes.Text + "' OR segundoApellido = '" + txtBuscarClientes.Text + "' ";
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
        private void btnActualizarClientes_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = true;
            this.panel2.Enabled = false;
            this.btnGuardarCambios.Visible = true;
            this.btnEliminarRegistro.Visible = false;
            this.btnRegistar.Visible = false;
        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            limpiarConfirmarTXT();

            if (confirmarTXT())
            {
                if (rbtnTi.Checked == true)
                {
                    tipoDocumento = rbtnTi.Text;
                    actualizarRegistro();
                    tipoDocumento = "";
                }
                else
                {
                    if (rbtnCC.Checked == true)
                    {
                        tipoDocumento += rbtnCC.Text;
                        actualizarRegistro();
                        tipoDocumento = "";
                    }
                    else
                    {
                        if (rbtnCEx.Checked == true)
                        {
                            tipoDocumento = rbtnCEx.Text;
                            actualizarRegistro();
                            tipoDocumento = "";
                        }
                        else
                        {
                            if (rbtnPass.Checked == true)
                            {
                                tipoDocumento = rbtnPass.Text;
                                actualizarRegistro();
                                tipoDocumento = "";
                            }
                            else
                            {
                                MessageBox.Show("Seleccione un tipo de Documento");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Verifique los espacios con error y diligencielos");
            }
        }
        private void btnEliminarClientes_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = true;
            this.panel2.Enabled = false;
            this.btnEliminarRegistro.Visible = true;
            this.btnGuardarCambios.Visible = false;
            this.btnRegistar.Visible = false;
        }
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
        private void dtgvEncontrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            if (tipoDocumento.Contains("T.I"))
            {
                rbtnTi.Checked = true;
                tipoDocumento = "";
            }
            else
            {
                if (tipoDocumento.Contains("C.C."))
                {
                    rbtnCC.Checked = true;
                    tipoDocumento = "";
                }
                else
                {
                    if (tipoDocumento.Contains("Pass"))
                    {
                        rbtnPass.Checked = true;
                        tipoDocumento = "";
                    }
                    else
                    {
                        if (tipoDocumento.Contains("C.Ex."))
                        {
                            rbtnCEx.Checked = true;
                            tipoDocumento = "";
                        }
                        else
                        {
                            MessageBox.Show("Verifique el tipo de Documento");
                        }
                    }
                }
            }
        }

        private void iconPictureSalir_Click(object sender, EventArgs e)
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
