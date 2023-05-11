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
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }
        string tipoId = ""; //declaramos variable que captura el valor Text del rbtn checkeado
        bool ok; // variable de vaidacion de campos vacios
        string IdActualizar = "";//variable que captura el valor del id actualizar
        String IdEliminar = ""; //Variable que captura el valor del id a Eliminar
        conexionDB conectar = new conexionDB();// instanciamos la conexión a la DB
        private void FormProveedores_Load(object sender, EventArgs e)
        {
            this.btnRegistrar.Visible = true;
            this.btnGuardarCambiosProveedores.Visible = false;
            this.btnEliminarRegistroProveedores.Visible = false;
        }
        private void RegistrarProveedor()//Metodo crear un nuevo registro
        {
            conectar.abrirDB();
            SqlCommand consultaId = new SqlCommand("SELECT * FROM Proveedores WHERE IdProveedor =  @Id", conectar.conectarDB);
            consultaId.Parameters.AddWithValue("@Id", txtIdProveedor.Text);
            SqlDataReader valorId = consultaId.ExecuteReader();

            if (!valorId.Read())
            {
                conectar.cerrarDB();
                conectar.abrirDB();
                string crear = "Insert into Proveedores ([IdProveedor], [TipoDocumento], [NombreProveedor], [DireccionProveedor], [TelefonoProveedor], [CorreoProveedor])" +
                    "values ('" + txtIdProveedor.Text + "', '" + tipoId + "', '" + txtNombreProveedor.Text + "', '" + txtDireccionProveedor.Text + "', '" + txtTelefonoProveedor.Text + "', '" + txtCorreoProveedor.Text + "')";
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
        }
        private void ActualizarProveedor()//Metodo para actualizar registro
        {
            //creamos una variable para almacenar el paramatro a actualizar
            IdActualizar = txtIdProveedor.Text;
            //actualizamos el registro
            conectar.abrirDB();
            string cadena = "UPDATE Proveedores SET IdProveedor = '" + txtIdProveedor.Text + "', TipoDocumento = '" + tipoId + "', NombreProveedor = '" + txtNombreProveedor.Text + "'," +
                            " DireccionProveedor = '" + txtDireccionProveedor.Text + "' , TelefonoProveedor = '" + txtTelefonoProveedor.Text + "'," +
                            " CorreoProveedor = '" + txtCorreoProveedor.Text + "' WHERE IdProveedor = '" + IdActualizar + "'";
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
        private void EliminarRegistro() // Metodo para eliminar un registro
        {
            IdEliminar = txtIdProveedor.Text;
            conectar.abrirDB();
            string cadena = "Delete from Proveedores Where  IdProveedor = " + IdEliminar + "";
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
        private void limpiarCampos() // Metodo para limpir los controles del form form
        {
            this.txtBuscarProveedor.Text = "";
            this.txtIdProveedor.Text = "";
            this.txtNombreProveedor.Text = "";
            this.txtDireccionProveedor.Text = "";
            this.txtTelefonoProveedor.Text = "";
            this.txtCorreoProveedor.Text = "";
            this.rbtnBuscarId.Checked = false;
            this.rbtnBuscarNombre.Checked = false;
            this.rbtnNitProveedor.Checked = false;
            this.rbtnCCProveedor.Checked = false;
            this.dtvEncontrados.DataSource = null;
            // limpiarConfirmarTXT();
        }
        private bool confirmarTXT() // Validamos que los campos no esten vacios
        {
            ok = true;

            if (txtIdProveedor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtIdProveedor, "Ingrese el Identificador del Proveedor");
            }
            else
            {
                if (txtNombreProveedor.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(txtNombreProveedor, "ingrese por favor el Nombre del Proveedor");
                }
                else
                {
                    if (txtDireccionProveedor.Text == "")
                    {
                        ok = false;
                        errorProvider1.SetError(txtDireccionProveedor, "ingrese por favor la dirección del proveedor");
                    }
                    else
                    {
                        if (txtTelefonoProveedor.Text == "")
                        {
                            ok = false;
                            errorProvider1.SetError(txtTelefonoProveedor, " por favor el telefono del Proveedor");
                        }
                        else
                        {
                            if (txtCorreoProveedor.Text == "")
                            {
                                ok = false;
                                errorProvider1.SetError(txtCorreoProveedor, "ingrese por favor el correo del Proveedor");
                            }
                            else
                            {

                            }
                        }
                    }
                }
            }
            return ok;
        }
        private void limpiarConfirmarTXT()
        {
            errorProvider1.SetError(txtIdProveedor, "");
            errorProvider1.SetError(txtNombreProveedor, "");
            errorProvider1.SetError(txtDireccionProveedor, "");
            errorProvider1.SetError(txtTelefonoProveedor, "");
            errorProvider1.SetError(txtCorreoProveedor, "");
        } // Quitamos el error cuando los campos no estan vacios
        private void txtIdProveedor_KeyPress(object sender, KeyPressEventArgs e)// Validamos que el txtIdProveedor contenga valores correctos
        {
            bool validar = CondicionandoTxt.soloNum(e);
            if (!validar)
                errorProvider1.SetError(txtIdProveedor, "Ingrese solo numeros");
            else
                errorProvider1.SetError(txtIdProveedor, "");
        }
        private void txtBuscarProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbtnBuscarId.Checked == true)
            {
                bool validar = CondicionandoTxt.soloNum(e);
                if (!validar)
                    errorProvider1.SetError(txtBuscarProveedor, "Ingrese solo numeros");
                else
                    errorProvider1.SetError(txtBuscarProveedor, "");
            }
            /*else
            {
                bool validar = CondicionandoTxt.soloTex(e);
                if (!validar)
                    errorProvider1.SetError(txtBuscarProveedor, "Ingrese solo Texto");
                else
                    errorProvider1.SetError(txtBuscarProveedor, "");
            }*/
        } //Validamos que el txtBuscarProveedor tenga los valores correctos
        private void txtCorreoProveedor_Leave(object sender, EventArgs e)// Validamos que el txtCorreoProveedorores contenga los valores correctos
        {
            if (!CondicionandoTxt.soloEmail(txtCorreoProveedor.Text))
                errorProvider1.SetError(txtCorreoProveedor, "Ingrese un correo valido");
            else
                errorProvider1.SetError(txtCorreoProveedor, "");
        }
        private void rbtnBuscarId_Click(object sender, EventArgs e) //capturamos el click del rbtnBuscarID para evitar valores incorrectos
        {
            txtBuscarProveedor.Text = "";
        }
        private void iconSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿desea salir y volver al menu principal?",
                   "consulta",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }//Configuramos el boton salir
        private void btnCrearProveedor_Click(object sender, EventArgs e)
        {
            this.panel2.Enabled = true;
            this.panel1.Enabled = false;
            this.btnRegistrar.Visible = true;
            this.btnGuardarCambiosProveedores.Visible = false;
            this.btnEliminarRegistroProveedores.Visible = false;
        }//Configuramos el boton CrearProveedor
        private void btnActualizarProveedor_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = true;
            this.panel2.Enabled = false;
            this.btnRegistrar.Visible = false;
            this.btnGuardarCambiosProveedores.Visible = true;
            this.btnEliminarRegistroProveedores.Visible = false;
        }//Configuramos el boton actualizar proveedor
        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = true;
            this.panel2.Enabled = false;
            this.btnRegistrar.Visible = false;
            this.btnGuardarCambiosProveedores.Visible = false;
            this.btnEliminarRegistroProveedores.Visible = true;
        }// Configurar el boton EliminarProveedor
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }//Configuramos el boton limpiarCampos
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            limpiarConfirmarTXT();
            if (confirmarTXT())
            {
                if (rbtnCCProveedor.Checked)
                {
                    tipoId = rbtnCCProveedor.Text;
                    RegistrarProveedor();
                }
                else
                {
                    if (rbtnNitProveedor.Checked)
                    {
                        tipoId = rbtnNitProveedor.Text;
                        RegistrarProveedor();
                    }
                    else
                    {
                        MessageBox.Show("por favor Seleccione un tipo de Documento");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor verifique los campos marcados e ingrese la información");
            }
        }//configuramos el boton Registrar
        private void dtvEncontrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.panel2.Enabled = true;
            txtIdProveedor.Text = dtvEncontrados.SelectedCells[0].Value.ToString();
            tipoId = dtvEncontrados.SelectedCells[1].Value.ToString();
            txtNombreProveedor.Text = dtvEncontrados.SelectedCells[2].Value.ToString();
            txtDireccionProveedor.Text = dtvEncontrados.SelectedCells[3].Value.ToString();
            txtTelefonoProveedor.Text = dtvEncontrados.SelectedCells[4].Value.ToString();
            txtCorreoProveedor.Text = dtvEncontrados.SelectedCells[5].Value.ToString();
            if (tipoId.Contains("C.C."))
            {
                rbtnCCProveedor.Checked = true;
            }
            else
            {
                if (tipoId.Contains("NIT"))
                {
                    rbtnNitProveedor.Checked = true;
                }
                else
                {
                    MessageBox.Show("Verifique el tipo de Documento");
                }


            }
        }//Capturamos el dtvEncontrados en los txt
        private void iconButtonBuscarProveedor_Click(object sender, EventArgs e)
        {
            bool ConfirmarParametro = true;

            if (txtBuscarProveedor.Text == "")
            {
                ConfirmarParametro = false;
                errorProvider1.SetError(txtBuscarProveedor, "Ingrese un parametro de busqueda");
            }
            else
            {
                errorProvider1.SetError(txtBuscarProveedor, "");
                //Condicionamos la busqueda segun el tipo
                if (rbtnBuscarId.Checked == true)
                {
                    string consulta = " select * from Proveedores where IdProveedor= " + txtBuscarProveedor.Text + "";
                    SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                    SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                    {
                        dtvEncontrados.DataSource = dt;
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
                        string consulta = " select * from Proveedores where NombreProveedor = '" + txtBuscarProveedor.Text + "'";
                        SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                        SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                        {
                            dtvEncontrados.DataSource = dt;
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
        }//Configuramos el boton Buscar proveedor
        private void btnGuardarCambiosProveedores_Click(object sender, EventArgs e)
        {
            limpiarConfirmarTXT();
            if (confirmarTXT())
            {
                if (rbtnCCProveedor.Checked == true)
                {
                    tipoId = rbtnCCProveedor.Text;
                    ActualizarProveedor();
                }
                else
                {
                    if (rbtnNitProveedor.Checked == true)
                    {
                        tipoId += rbtnNitProveedor.Text;
                        ActualizarProveedor();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un tipo de Documento");
                    }
                }
            }
            else
            {
                MessageBox.Show("Verifique los espacios con error y diligencielos");
            }
        }//Configurar el boton GuardarCambiosProveedores
        private void btnEliminarRegistroProveedores_Click(object sender, EventArgs e)
        {
            limpiarConfirmarTXT();
            if (confirmarTXT())
            {
                //llamamos al metodo
                EliminarRegistro();
            }
            else
            {
                MessageBox.Show("Verifique los espacios con error y diligencielos");
            }
        }//configuramos el boton eliminarRegistroProveedores
    }
}

