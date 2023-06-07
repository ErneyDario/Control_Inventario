using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace Control_Inventario
{
    public partial class FormInventario : Form
    {
        private DataTable dt;
        public FormInventario()
        {
            InitializeComponent();
        }
        bool ok;
        string registro = "";
        string factura = "";
        string CodProveedor = "";
        conexionDB conectar = new conexionDB();
        private void FormInventario_Load(object sender, EventArgs e)
        {
            this.btnRegistrar.Visible = true;
            dt = new DataTable();
            dt.Columns.Add("Factura");
            dt.Columns.Add("IdProveedor");
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Articulo");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Valor");
            dt.Columns.Add("Venta");
            dt.Columns.Add("Cantidad");
            dtgvEntradas.DataSource = dt;
            dtgvEntradas.AllowUserToAddRows = false;

        }
        private void txtIdProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = CondicionandoTxt.soloNum(e);
            if (!validar)
                errorProvider1.SetError(txtIdProveedor, "Ingrese solo numeros");
            else
                errorProvider1.SetError(txtIdProveedor, "");

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                conectar.abrirDB();
                // Consultar Proveedor
                SqlCommand comando = new SqlCommand("SELECT * FROM Proveedores WHERE IdProveedor = @IdProveedor", conectar.conectarDB);
                comando.Parameters.AddWithValue("@IdProveedor", txtIdProveedor.Text);
                SqlDataReader valores = comando.ExecuteReader();

                if (valores.Read())
                {

                    txtNombreProveedor.Text = valores["NombreProveedor"].ToString();
                    conectar.cerrarDB();
                }
                else
                {
                    conectar.cerrarDB();
                    MessageBox.Show("El proveedor no se encuentra registrado");
                }

                txtcodigo.Focus();
            }
        }
        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                conectar.abrirDB();
                // Consultar Proveedor
                SqlCommand comando = new SqlCommand("SELECT * FROM Articulos WHERE Codigo = @Codigo", conectar.conectarDB);
                comando.Parameters.AddWithValue("Codigo", txtcodigo.Text);
                SqlDataReader valores = comando.ExecuteReader();

                if (valores.Read())
                {

                    txtArticulo.Text = valores["Articulo"].ToString();
                    txtdescripcion.Text = valores["Descripcion"].ToString();
                    conectar.cerrarDB();
                }
                else
                {
                    conectar.cerrarDB();
                    MessageBox.Show("El Articulo no se encuentra registrado");
                }

                txtvalor.Focus();
            }
        }
        private void limpiarCampos()
        {
            this.txtFactura.Text = "";
            this.txtIdProveedor.Text = "";
            this.txtNombreProveedor.Text = "";
            this.txtcodigo.Text = "";
            this.txtArticulo.Text = "";
            this.txtdescripcion.Text = "";
            this.txtvalor.Text = "";
            this.txtValorVenta.Text = "";
            this.txtExistencias.Text = "";
            this.dt.Clear();
        }
        private bool confirmarTXT()
        {
            ok = true;

            if (txtFactura.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtFactura, "ingrese la Factura");
            }
            else
            {
                if (txtIdProveedor.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(txtIdProveedor, "ingrese por favor el Id del Proveedor");
                }
                else
                {
                    if (txtcodigo.Text == "")
                    {
                        ok = false;
                        errorProvider1.SetError(txtcodigo, "ingrese por favor el Codigo del Articulo");
                    }
                    else
                    {
                        if (txtvalor.Text == "")
                        {
                            ok = false;
                            errorProvider1.SetError(txtvalor, "ingrese el valor del Compra");
                        }
                        else
                        {
                            if (txtValorVenta.Text == "")
                            {
                                ok = false;
                                errorProvider1.SetError(txtValorVenta, "Por favor Ingrese el valor de venta");
                            }
                            else
                            {
                                if (txtExistencias.Text == "")
                                {
                                    ok = false;
                                    errorProvider1.SetError(txtExistencias, "Por favor ingrese la cantidad");
                                }
                                else
                                {
                                    limpiarConfirmarTXT();
                                }
                            }

                        }

                    }
                }
            }
            return ok;
        }
        private void limpiarConfirmarTXT()
        {
            errorProvider1.SetError(txtFactura, "");
            errorProvider1.SetError(txtIdProveedor, "");
            errorProvider1.SetError(txtcodigo, "");
            errorProvider1.SetError(txtArticulo, "");
            errorProvider1.SetError(txtdescripcion, "");
            errorProvider1.SetError(txtvalor, "");
            errorProvider1.SetError(txtValorVenta, "");
            errorProvider1.SetError(txtExistencias, "");
        }
        private void btnIngresarInventario_Click(object sender, EventArgs e)
        {
            this.panel4.Enabled = true;
            this.panel3.Enabled = false;
            this.btnRegistrar.Visible = true;
            this.btnGuardarCambios.Visible = false;
            this.btnEliminarRegistro.Visible = false;
            this.btnLimpiar.Visible = true;
            this.btnAgregarEntrada.Visible = true;
            this.btnAgregarEntrada.Enabled = true;
            this.btnLimpiar.Enabled = true;
            this.txtFactura.Text = "";
            this.txtIdProveedor.Text = "";
            this.txtNombreProveedor.Text = "";
            this.txtcodigo.Text = "";
            this.txtArticulo.Text = "";
            this.txtdescripcion.Text = "";
            this.txtvalor.Text = "";
            this.txtValorVenta.Text = "";
            this.txtExistencias.Text = "";
            this.cmbTipoBusqueda.ResetText();
            this.txtBuscar.Text = "";
            this.dt.Clear();
        }
        private void btnAgregarEntrada_Click(object sender, EventArgs e)
        {
            limpiarConfirmarTXT();
            if (confirmarTXT())
            {
                try
                {
                    conectar.abrirDB();
                    SqlCommand consultaFactura = new SqlCommand("SELECT * FROM Entradas WHERE Factura  =  @Factura", conectar.conectarDB);
                    consultaFactura.Parameters.AddWithValue("@Factura", txtFactura.Text);
                    SqlDataReader valorId = consultaFactura.ExecuteReader();

                    if (!valorId.Read())
                    {
                        conectar.cerrarDB();

                        DataRow dr = dt.NewRow();
                        dr["Factura"] = txtFactura.Text;
                        dr["IdProveedor"] = txtIdProveedor.Text;
                        dr["Codigo"] = txtcodigo.Text;
                        dr["Articulo"] = txtArticulo.Text;
                        dr["Descripcion"] = txtdescripcion.Text;
                        dr["Valor"] = txtvalor.Text;
                        dr["Venta"] = txtValorVenta.Text;
                        dr["Cantidad"] = txtExistencias.Text;
                        dt.Rows.Add(dr);
                        txtArticulo.Text = "";
                        txtcodigo.Text = "";
                        txtdescripcion.Text = "";
                        txtvalor.Text = "";
                        txtValorVenta.Text = "";
                        txtExistencias.Text = "";
                    }
                    else
                    {
                        conectar.cerrarDB();
                        MessageBox.Show("La factura digitada ya fue ingresada, por favir verifique e intente nuevamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor diligencie todos los campos marcados");
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaramos las variables que controlaran la actualización de la tabla Stock
                int Entrada = 0;
                decimal Valor = 0;
                decimal Venta = 0;
                // Declaramos las sentencias, que agregaran un nuevo registro, consultaran y actualizaran la tabla Stock
                SqlCommand agregar = new SqlCommand("Insert into Entradas values (GetDate(), @Codigo ,@Cantidad, @Valor, @Venta, @Factura, @IdProveedor,@Usuario)", conectar.conectarDB);
                SqlCommand buscar = new SqlCommand("SELECT Entradas, Valor, Venta FROM Stock WHERE CodArticulo = @Buscar", conectar.conectarDB);
                SqlCommand cadena = new SqlCommand("UPDATE Stock SET Entradas =  @Entrada, Valor = @ValorS, Venta = @VentaS  WHERE CodArticulo = @Parametro ", conectar.conectarDB);
                DataTable encontrados = new DataTable();
                conectar.abrirDB();
                //Recorremos el datagridview
                int i = 0; // contador para contar las filas del datagridview quien controla la actualizacion de la tabla stock
                foreach (DataGridViewRow row in dtgvEntradas.Rows)
                {
                    //registramos la entrada
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@Factura", Convert.ToString(row.Cells["Factura"].Value));
                    agregar.Parameters.AddWithValue("@IdProveedor", Convert.ToString(row.Cells["IdProveedor"].Value));
                    agregar.Parameters.AddWithValue("@Codigo", Convert.ToString(row.Cells["Codigo"].Value));
                    agregar.Parameters.AddWithValue("@Valor", Convert.ToDecimal(row.Cells["Valor"].Value));
                    agregar.Parameters.AddWithValue("@Venta", Convert.ToDecimal(row.Cells["Venta"].Value));
                    agregar.Parameters.AddWithValue("@Usuario", variablesGlobales.vNombreUsuario);
                    agregar.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(row.Cells["Cantidad"].Value));
                    //Traemos los Articulos en Stock que se afectaran con la nueva entrada
                    agregar.ExecuteNonQuery();
                    buscar.Parameters.Clear();
                    buscar.Parameters.AddWithValue("@Buscar", Convert.ToString(row.Cells["Codigo"].Value));
                    SqlDataAdapter Adaptador = new SqlDataAdapter(buscar);
                    Adaptador.Fill(encontrados);
                    //Capturamos los valores que contienen cada articulo para hacer la operacion de actualizacion de valores
                    dataGridView1.DataSource = encontrados;
                    Entrada = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    Valor = Convert.ToDecimal(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    Venta = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    //Condicionamos la actualizacion
                    if (Entrada == 0)
                    {
                        cadena.Parameters.Clear();
                        cadena.Parameters.AddWithValue("@Parametro", Convert.ToString(row.Cells["Codigo"].Value));
                        cadena.Parameters.AddWithValue("@Entrada", Convert.ToInt32(row.Cells["Cantidad"].Value));
                        cadena.Parameters.AddWithValue("@ValorS", Convert.ToDecimal(row.Cells["Valor"].Value));
                        cadena.Parameters.AddWithValue("VentaS", Convert.ToDecimal(row.Cells["Venta"].Value));
                        cadena.ExecuteNonQuery();
                    }
                    else
                    {
                        cadena.Parameters.Clear();
                        cadena.Parameters.AddWithValue("@Parametro", Convert.ToString(row.Cells["Codigo"].Value));
                        cadena.Parameters.AddWithValue("@Entrada", Entrada + Convert.ToInt32(row.Cells["Cantidad"].Value));
                        cadena.Parameters.AddWithValue("@ValorS", (Convert.ToDecimal(row.Cells["Valor"].Value) + Valor) / 2);
                        cadena.Parameters.AddWithValue("VentaS", Convert.ToDecimal(row.Cells["Venta"].Value));
                        cadena.ExecuteNonQuery();
                    }
                    Entrada = 0;
                    Valor = 0;
                    Venta = 0;
                    i++;
                }
                MessageBox.Show("Registros Agregados exitosamente");
                conectar.cerrarDB();
                limpiarCampos();
                //dtgvEntradas.DataSource = dt;
                if (MessageBox.Show("¿desea Agregar otra Factura?",
                          "Consulta",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.panel4.Enabled = false;
                    this.panel3.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnEditarInventario_Click(object sender, EventArgs e)
        {
            this.panel3.Enabled = true;
            this.panel4.Enabled = false;
            this.btnRegistrar.Visible = false;
            this.btnEliminarRegistro.Visible = false;
            this.btnAgregarEntrada.Visible = false;
            this.btnLimpiar.Visible = false;
            this.btnGuardarCambios.Visible = true;
            this.txtFactura.Text = "";
            this.txtIdProveedor.Text = "";
            this.txtNombreProveedor.Text = "";
            this.txtcodigo.Text = "";
            this.txtArticulo.Text = "";
            this.txtdescripcion.Text = "";
            this.txtvalor.Text = "";
            this.txtValorVenta.Text = "";
            this.txtExistencias.Text = "";
            this.cmbTipoBusqueda.ResetText();
            this.txtBuscar.Text = "";
            this.btnAgregarEntrada.Enabled = false;
            this.btnLimpiar.Enabled = false;
            this.dt.Clear();
        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {

            limpiarConfirmarTXT();
            if (confirmarTXT())
            {
                try
                {
                    conectar.abrirDB();
                    if (factura != txtFactura.Text)
                    {
                        if (MessageBox.Show("Esta a punto de actualizar el numero de la Factura,¿esta seguro?",
                            "consulta",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SqlCommand cadena = new SqlCommand("UPDATE Entradas SET Fecha = GetDate(),  Factura = @Factura, Usuario = @Usuario  WHERE Factura = @Parametro ", conectar.conectarDB);
                            cadena.Parameters.AddWithValue("@Factura", txtFactura.Text);
                            cadena.Parameters.AddWithValue("@Parametro", factura);
                            cadena.Parameters.AddWithValue("@Usuario", variablesGlobales.vNombreUsuario);
                            cadena.ExecuteNonQuery();
                            MessageBox.Show("Actualización exitosa");
                            this.txtFactura.Text = "";
                            this.txtIdProveedor.Text = "";
                            this.txtNombreProveedor.Text = "";
                            this.txtcodigo.Text = "";
                            this.txtArticulo.Text = "";
                            this.txtdescripcion.Text = "";
                            this.txtvalor.Text = "";
                            this.txtValorVenta.Text = "";
                            this.txtExistencias.Text = "";
                            this.dtgvEntradas.Columns.Clear();
                            this.cmbTipoBusqueda.ResetText();
                            this.txtBuscar.Text = "";
                            this.panel4.Enabled = false;
                            if (MessageBox.Show("¿desea Actualizar otro registro?",
                               "Consulta",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) == DialogResult.No)
                            {
                                this.panel4.Enabled = false;
                                this.panel3.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        if (CodProveedor != txtIdProveedor.Text)
                        {
                            if (MessageBox.Show("Esta a punto de actualizar el Codigo del Proveedor,¿esta seguro?",
                            "consulta",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                SqlCommand cadena = new SqlCommand("UPDATE Entradas SET Fecha = GetDate(), CodProveedor = @CodProveedor, Usuario = @Usuario  WHERE Factura = @Parametro ", conectar.conectarDB);
                                cadena.Parameters.AddWithValue("@CodProveedor", txtIdProveedor.Text);
                                cadena.Parameters.AddWithValue("@Parametro", factura);
                                cadena.Parameters.AddWithValue("@Usuario", variablesGlobales.vNombreUsuario);
                                cadena.ExecuteNonQuery();
                                MessageBox.Show("Actualización Exitosa");
                                this.txtFactura.Text = "";
                                this.txtIdProveedor.Text = "";
                                this.txtNombreProveedor.Text = "";
                                this.txtcodigo.Text = "";
                                this.txtArticulo.Text = "";
                                this.txtdescripcion.Text = "";
                                this.txtvalor.Text = "";
                                this.txtValorVenta.Text = "";
                                this.txtExistencias.Text = "";
                                this.dtgvEntradas.Columns.Clear();
                                this.cmbTipoBusqueda.ResetText();
                                this.txtBuscar.Text = "";
                                this.panel4.Enabled = false;
                                if (MessageBox.Show("¿desea Actualizar otro registro?",
                               "Consulta",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) == DialogResult.No)
                                {
                                    this.panel4.Enabled = false;
                                    this.panel3.Enabled = false;
                                }
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Esta a punto de actualizar los datos de un registro,¿esta seguro?",
                            "consulta",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                SqlCommand cadena = new SqlCommand("UPDATE Entradas SET Fecha = GetDate(), CodArticulo = @CodArticulo, Valor = @Valor, ValorVenta = @ValorVenta, Cantidad = @Cantidad, Usuario = @Usuario  WHERE Item = @Parametro ", conectar.conectarDB);
                                cadena.Parameters.AddWithValue("@CodArticulo", txtcodigo.Text);
                                cadena.Parameters.AddWithValue("@Valor", Convert.ToDecimal(txtvalor.Text));
                                cadena.Parameters.AddWithValue("@ValorVenta", Convert.ToDecimal(txtValorVenta.Text));
                                cadena.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(txtExistencias.Text));
                                cadena.Parameters.AddWithValue("@Parametro", registro);
                                cadena.Parameters.AddWithValue("@Usuario", variablesGlobales.vNombreUsuario);
                                cadena.ExecuteNonQuery();
                                MessageBox.Show("Actualización Exitosa");
                                this.txtFactura.Text = "";
                                this.txtIdProveedor.Text = "";
                                this.txtNombreProveedor.Text = "";
                                this.txtcodigo.Text = "";
                                this.txtArticulo.Text = "";
                                this.txtdescripcion.Text = "";
                                this.txtvalor.Text = "";
                                this.txtValorVenta.Text = "";
                                this.txtExistencias.Text = "";
                                this.dtgvEntradas.Columns.Clear();
                                this.cmbTipoBusqueda.ResetText();
                                this.txtBuscar.Text = "";
                                this.panel4.Enabled = false;
                                if (MessageBox.Show("¿desea Actualizar otro registro?",
                               "Consulta",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) == DialogResult.No)
                                {
                                    this.panel4.Enabled = false;
                                    this.panel3.Enabled = false;


                                }

                            }
                        }
                    }
                    conectar.cerrarDB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void btnEliminarInventario_Click(object sender, EventArgs e)
        {
            this.panel3.Enabled = true;
            this.panel4.Enabled = false;
            this.btnRegistrar.Visible = false;
            this.btnGuardarCambios.Visible = false;
            this.btnEliminarRegistro.Visible = true;
            this.btnLimpiar.Visible = false;
            this.btnAgregarEntrada.Visible = false;
            this.txtFactura.Text = "";
            this.txtIdProveedor.Text = "";
            this.txtNombreProveedor.Text = "";
            this.txtcodigo.Text = "";
            this.txtArticulo.Text = "";
            this.txtdescripcion.Text = "";
            this.txtvalor.Text = "";
            this.txtValorVenta.Text = "";
            this.txtExistencias.Text = "";
            this.dt.Clear();
            this.cmbTipoBusqueda.ResetText();
            this.txtBuscar.Text = "";

        }
        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            limpiarConfirmarTXT();
            if (confirmarTXT())
            {
                try
                {
                    conectar.abrirDB();
                    SqlCommand eliminar = new SqlCommand("DELETE ENTRADAS WHERE Item = @Eliminar", conectar.conectarDB);
                    eliminar.Parameters.AddWithValue("@Eliminar", registro);
                    eliminar.ExecuteNonQuery();
                    MessageBox.Show("Registro eliminado exitosamente");
                    this.txtFactura.Text = "";
                    this.txtIdProveedor.Text = "";
                    this.txtNombreProveedor.Text = "";
                    this.txtcodigo.Text = "";
                    this.txtArticulo.Text = "";
                    this.txtdescripcion.Text = "";
                    this.txtvalor.Text = "";
                    this.txtValorVenta.Text = "";
                    this.txtExistencias.Text = "";
                    this.dtgvEntradas.DataSource = null;
                    this.cmbTipoBusqueda.ResetText();
                    this.txtBuscar.Text = "";
                    this.panel4.Enabled = false;
                    conectar.cerrarDB();
                    if (MessageBox.Show("¿desea Eliminar otro registro?",
                   "Consulta",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.No)
                    {
                        this.panel4.Enabled = false;
                        this.panel3.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por Favor seleccione el registro a eliminar");
            }

        }
        private void btnGestionArticulos_Click(object sender, EventArgs e)
        {
            FormArticulos frm = new FormArticulos();
            frm.ShowDialog();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtFactura.Text = "";
            this.txtIdProveedor.Text = "";
            this.txtNombreProveedor.Text = "";
            this.txtcodigo.Text = "";
            this.txtArticulo.Text = "";
            this.txtdescripcion.Text = "";
            this.txtvalor.Text = "";
            this.txtValorVenta.Text = "";
            this.txtExistencias.Text = "";
        }
        private void iconPictureBoxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void iBtnBuscar_Click(object sender, EventArgs e)
        {

            if (cmbTipoBusqueda.GetItemText(cmbTipoBusqueda.SelectedItem) == "Articulo")
            {
                if (txtBuscar.Text != "")
                {
                    conectar.abrirDB();
                    SqlCommand buscar = new SqlCommand("SELECT * FROM Entradas WHERE CodArticulo  =  @Buscar", conectar.conectarDB);
                    buscar.Parameters.AddWithValue("@Buscar", txtBuscar.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(buscar);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count != 0)
                    {
                        dtgvEntradas.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("No hay resultados para esta busqueda");
                        txtBuscar.Text = "";
                        cmbTipoBusqueda.ResetText();
                        conectar.cerrarDB();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un parametro de busqueda");
                }
            }
            else
            {
                if (cmbTipoBusqueda.GetItemText(cmbTipoBusqueda.SelectedItem) == "Factura")
                {
                    if (txtBuscar.Text != "")
                    {
                        conectar.abrirDB();
                        SqlCommand buscar = new SqlCommand("SELECT * FROM Entradas WHERE Factura =  @Buscar", conectar.conectarDB);
                        buscar.Parameters.AddWithValue("@Buscar", txtBuscar.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(buscar);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count != 0)
                        {
                            dtgvEntradas.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No hay resultados para esta busqueda");
                            txtBuscar.Text = "";
                            cmbTipoBusqueda.ResetText();
                            conectar.cerrarDB();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese un parametro de busqueda");
                    }
                }
                else
                {
                    if (cmbTipoBusqueda.GetItemText(cmbTipoBusqueda.SelectedItem) == "Proveedor")
                    {
                        if (txtBuscar.Text != "")
                        {
                            conectar.abrirDB();
                            SqlCommand buscar = new SqlCommand("SELECT * FROM Entradas WHERE CodProveedor  =  @Buscar", conectar.conectarDB);
                            buscar.Parameters.AddWithValue("@Buscar", txtBuscar.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(buscar);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            if (dt.Rows.Count != 0)
                            {
                                dtgvEntradas.DataSource = dt;

                            }
                            else
                            {
                                MessageBox.Show("No hay resultados para esta busqueda");
                                txtBuscar.Text = "";
                                cmbTipoBusqueda.ResetText();
                                conectar.cerrarDB();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor ingrese un parametro de busqueda");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor seleccione un tipo de busqueda");
                    }

                }
            }
        }
        private void dtgvEntradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.panel4.Enabled = true;
            registro = dtgvEntradas.SelectedCells[0].Value.ToString();
            txtFactura.Text = dtgvEntradas.SelectedCells[6].Value.ToString();
            txtIdProveedor.Text = dtgvEntradas.SelectedCells[7].Value.ToString();
            txtcodigo.Text = dtgvEntradas.SelectedCells[2].Value.ToString();
            txtvalor.Text = dtgvEntradas.SelectedCells[4].Value.ToString();
            txtValorVenta.Text = dtgvEntradas.SelectedCells[5].Value.ToString();
            txtExistencias.Text = dtgvEntradas.SelectedCells[3].Value.ToString();
            factura = txtFactura.Text;
            CodProveedor = txtIdProveedor.Text;


            // Consultar Proveedor
            if (conectar.conectarDB.State == ConnectionState.Closed)
            {
                conectar.abrirDB();
            }
            SqlCommand comando = new SqlCommand("SELECT * FROM Proveedores WHERE IdProveedor = @IdProveedor", conectar.conectarDB);
            comando.Parameters.AddWithValue("@IdProveedor", txtIdProveedor.Text);
            SqlDataReader valores = comando.ExecuteReader();

            if (valores.Read())
            {
                txtNombreProveedor.Text = valores["NombreProveedor"].ToString();
            }
            conectar.cerrarDB();

            // Consultar Proveedor
            conectar.abrirDB();
            SqlCommand comand = new SqlCommand("SELECT * FROM Articulos WHERE Codigo = @Codigo", conectar.conectarDB);
            comand.Parameters.AddWithValue("Codigo", txtcodigo.Text);
            SqlDataReader valor = comand.ExecuteReader();
            if (valor.Read())
            {

                txtArticulo.Text = valor["Articulo"].ToString();
                txtdescripcion.Text = valor["Descripcion"].ToString();
            }
            conectar.cerrarDB();
        }
        private void btnLimpirForm_Click(object sender, EventArgs e)
        {
            this.txtFactura.Text = "";
            this.txtIdProveedor.Text = "";
            this.txtNombreProveedor.Text = "";
            this.txtcodigo.Text = "";
            this.txtArticulo.Text = "";
            this.txtdescripcion.Text = "";
            this.txtvalor.Text = "";
            this.txtValorVenta.Text = "";
            this.txtExistencias.Text = "";
            this.cmbTipoBusqueda.ResetText();
            this.txtBuscar.Text = "";
            this.dt.Clear();
        }
    }
}




