using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Inventario
{
    public partial class FormArticulos : Form
    {
        public FormArticulos()
        {
            InitializeComponent();
        }
        conexionDB conectar = new conexionDB();
        bool ok;
        string IdActualizar = "";
        string IdEliminar = "";
        private void FormArticulos_Load(object sender, EventArgs e)
        {
            this.btnRegistrar.Visible = true;
            this.btnGuardarCambios.Visible = false;
            this.btnEliminarRegistro.Visible = false;
        }
        private bool confirmarTXT()
        {
            ok = true;

            if (txtcodigo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtArticulo, "Ingrese el Numero de Documento del Usuario");
            }
            else
            {
                if (txtArticulo.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(txtArticulo, "ingrese por favor el Apellido del Usuario");
                }
                else
                {
                    if (txtDescripcion.Text == "")
                    {
                        ok = false;
                        errorProvider1.SetError(txtDescripcion, "ingrese por favor un Correo Electronico");
                    }
                }
            }
            return ok;
        }
        private void limpiarConfirmarTXT()
        {
            errorProvider1.SetError(txtcodigo, "");
            errorProvider1.SetError(txtArticulo, "");
            errorProvider1.SetError(txtDescripcion, "");
            errorProvider1.SetError(txtBuscarArticulo, "");

        }
        private void limpiarCampos()
        {
            this.txtcodigo.Text = "";
            this.txtArticulo.Text = "";
            this.txtDescripcion.Text = "";
            this.txtBuscarArticulo.Text = "";
            this.dtgvArticulosEncontrados.DataSource = null;
            this.rbtnCodigo.Checked = false;
            this.rbtnNombre.Checked = false;
            limpiarConfirmarTXT();
        }
        private void nuevoRegistro()
        {
            //consultamos el numero de Documento ingresado para verificar que no este registrado
            conectar.abrirDB();
            SqlCommand consultaId = new SqlCommand("SELECT * FROM Articulos WHERE Codigo = @codigo", conectar.conectarDB);
            consultaId.Parameters.AddWithValue("@codigo", txtcodigo.Text);
            SqlDataReader valorId = consultaId.ExecuteReader();

            if (!valorId.Read())
            {
                conectar.cerrarDB();
                //Realizamos el nuevo registro
                conectar.abrirDB();
                string crear = "Insert into Articulos ([Codigo], [Articulo], [Descripcion])" +
                                "values ('" + txtcodigo.Text + "', '" + txtArticulo.Text + "', '" + txtDescripcion.Text + "')";
                SqlCommand comando = new SqlCommand(crear, conectar.conectarDB);
                comando.ExecuteNonQuery();
                //Invocamos el metodo para limpiarlos campos
                limpiarCampos();

                MessageBox.Show("Registro agregado con exito");
                conectar.cerrarDB();
                if (MessageBox.Show("¿desea Agregar otro Articulo?",
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
                MessageBox.Show("El articulo ya ha sido creado");
            }
        }
        private void actualizarRegistro()
        {
            //creamos una variable para almacenar el paramatro a actualizar
            IdActualizar = txtcodigo.Text;
            //actualizamos el registro
            conectar.abrirDB();
            string cadena = "UPDATE Articulos SET Codigo = '" + txtcodigo.Text + "', Articulo = '" + txtArticulo.Text + "', Descripcion = '" + txtDescripcion.Text + "' WHERE Codigo= '" + IdActualizar + "'";
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
            IdEliminar = txtcodigo.Text;
            conectar.abrirDB();
            string cadena = "Delete from Articulos Where  Codigo = '" + IdEliminar + "'";
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
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void btnCrearArticulo_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = false;
            this.panel2.Enabled = true;
            this.btnRegistrar.Visible = true;
            this.btnGuardarCambios.Visible = false;
            this.btnEliminarRegistro.Visible = false;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            confirmarTXT(); //invocamos el metodo para validar que los campos no esten vacios
            limpiarConfirmarTXT(); //Invocamos el metodo que limpia los errores de los campos diligenciados
            if (confirmarTXT()) //condicionamos que mientras no haya errores en los txt pueda guardar el registro 
            {
                nuevoRegistro();
            }
            else
            {
                MessageBox.Show("Por favor diligencie todos los datos");
            }
        }
        private void iconButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnActualizarArticulo_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = true;
            this.panel2.Enabled = false;
            this.btnGuardarCambios.Visible = true;
            this.btnEliminarRegistro.Visible = false;
            this.btnRegistrar.Visible = false;
        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (confirmarTXT())
            {
                actualizarRegistro();
            }
            else
            {
                MessageBox.Show("verifique los campos con erro y diligencielos");
            }

        }
        private void iBtnBuscarArticulo_Click(object sender, EventArgs e)
        {
            //Condicionamos el txtBuscarUsuario para que no este vacio al momento de realizar la consulta
            bool ConfirmarParametro = true;

            if (txtBuscarArticulo.Text == "")
            {
                ConfirmarParametro = false;
                errorProvider1.SetError(txtBuscarArticulo, "Ingrese un parametro de busqueda");
            }
            else
            {
                errorProvider1.SetError(txtBuscarArticulo, "");

                //Condicionamos la busqueda segun el tipo
                if (rbtnCodigo.Checked == true)
                {

                    string consulta = " select * from Articulos where Codigo = '" + txtBuscarArticulo.Text + "'";
                    SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                    SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                    {
                        dtgvArticulosEncontrados.DataSource = dt;
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
                        string consulta = " select * from Articulos where Articulo = '" + txtBuscarArticulo.Text + "'";
                        SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                        SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                        {
                            dtgvArticulosEncontrados.DataSource = dt;
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
        private void dtgvArticulosEncontrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.panel2.Enabled = true;
            txtcodigo.Text = dtgvArticulosEncontrados.SelectedCells[0].Value.ToString();
            txtArticulo.Text = dtgvArticulosEncontrados.SelectedCells[1].Value.ToString();
            txtDescripcion.Text = dtgvArticulosEncontrados.SelectedCells[2].Value.ToString();
        }
        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = true;
            this.panel2.Enabled = false;
            this.btnEliminarRegistro.Visible = true;
            this.btnGuardarCambios.Visible = false;
            this.btnRegistrar.Visible = false;
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
    }
}

