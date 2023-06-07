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
using System.Windows.Media.TextFormatting;

namespace Control_Inventario
{

    public partial class FormVentas : Form
    {
        private DataTable dt;
        public FormVentas()
        {
            InitializeComponent();
        }
        decimal TotalVenta = 0;
        decimal ATotal = 0;
        int factura = 0;
        int nuevaFactura = 0;
        decimal Valor = 0;
        decimal Cantidad = 0;
        conexionDB conectar = new conexionDB(); // Instanciamos la conexion a la base de datos
        private void FormVentas_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Articulo");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("ValorUni");
            dt.Columns.Add("ValorTotal");
            dgvVentas.DataSource = dt;
            dgvVentas.AllowUserToAddRows = false;

        }
        //Metodo para buscar un articulo
        private void BuscarArticulo()
        {
            if (rbtnCodigo.Checked)
            {
                try
                {
                    conectar.abrirDB();
                    SqlCommand buscar = new SqlCommand("SELECT * FROM Articulos WHERE Codigo LIKE '%" + txtBuscar.Text + "%'", conectar.conectarDB);
                    //buscar.Parameters.AddWithValue("@Articulo", txtBuscar.Text);
                    SqlDataAdapter adaptador = new SqlDataAdapter(buscar);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    if (dt.Rows.Count != 0)
                    {
                        dgvEncontrados.DataSource = dt;
                        conectar.cerrarDB();
                    }
                    else
                    {
                        conectar.cerrarDB();
                        MessageBox.Show("No hay resultados para esta busqueda");
                        this.txtBuscar.Text = "";
                        this.txtcodigo.Text = "";
                        this.txtexistencias.Text = "";
                        this.txtArticulo.Text = "";
                        this.txtDescripcion.Text = "";
                        this.txtValor.Text = "";
                        this.txtCantidad.Text = "";
                        this.txtTotal.Text = "";
                        rbtnCodigo.Checked = false;
                        rbtnNombre.Checked = false;
                        rbtnDescripcion.Checked = false;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (rbtnNombre.Checked)
                {
                    try
                    {
                        conectar.abrirDB();
                        SqlCommand buscar = new SqlCommand("SELECT * FROM Articulos WHERE Articulo LIKE '%" + txtBuscar.Text + "%'", conectar.conectarDB);
                        //buscar.Parameters.AddWithValue("@Articulo", txtBuscar.Text);
                        SqlDataAdapter adaptador = new SqlDataAdapter(buscar);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        if (dt.Rows.Count != 0)
                        {
                            dgvEncontrados.DataSource = dt;
                            conectar.cerrarDB();
                        }
                        else
                        {
                            conectar.cerrarDB();
                            MessageBox.Show("No hay resultados para esta busqueda");
                            this.txtBuscar.Text = "";
                            this.txtcodigo.Text = "";
                            this.txtexistencias.Text = "";
                            this.txtArticulo.Text = "";
                            this.txtDescripcion.Text = "";
                            this.txtValor.Text = "";
                            this.txtCantidad.Text = "";
                            this.txtTotal.Text = "";
                            rbtnCodigo.Checked = false;
                            rbtnNombre.Checked = false;
                            rbtnDescripcion.Checked = false;

                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    if (rbtnDescripcion.Checked)
                    {
                        try
                        {
                            conectar.abrirDB();
                            SqlCommand buscar = new SqlCommand("SELECT * FROM Articulos WHERE Descripcion LIKE '%" + txtBuscar.Text + "%'", conectar.conectarDB);
                            //buscar.Parameters.AddWithValue("@Articulo", txtBuscar.Text);
                            SqlDataAdapter adaptador = new SqlDataAdapter(buscar);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            if (dt.Rows.Count != 0)
                            {
                                dgvEncontrados.DataSource = dt;
                                conectar.cerrarDB();
                            }
                            else
                            {
                                conectar.cerrarDB();
                                MessageBox.Show("No hay resultados para esta busqueda");
                                this.txtBuscar.Text = "";
                                this.txtcodigo.Text = "";
                                this.txtexistencias.Text = "";
                                this.txtArticulo.Text = "";
                                this.txtDescripcion.Text = "";
                                this.txtValor.Text = "";
                                this.txtCantidad.Text = "";
                                this.txtTotal.Text = "";
                                rbtnCodigo.Checked = false;
                                rbtnNombre.Checked = false;
                                rbtnDescripcion.Checked = false;

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor seleccione un tipo de busqueda");
                    }
                }
            }
        }
        //Metodo para obtener el valor total de la factura
        private void TotalFactura()
        {
            decimal aFactura = 0;
            decimal tFactura = 0;
            try
            {
                if (dgvVentas.Rows.Count != 0)
                {
                    int count = 0;
                    foreach (DataGridViewRow row in dgvVentas.Rows)
                    {
                        aFactura = Convert.ToDecimal(dgvVentas.Rows[count].Cells[4].Value.ToString());
                        tFactura = tFactura + aFactura;
                        count++;
                    }
                }
                else
                {
                    aFactura = 0;
                }
                txtTotalVenta.Text = Convert.ToString(tFactura);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                BuscarArticulo();
            }
            else
            {
                errorProvider1.SetError(txtBuscar, "Por favor Ingrese un Parametro de busqueda");
            }

        }
        private void dgvEncontrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dgvEncontrados.SelectedCells[0].Value.ToString();
            txtArticulo.Text = dgvEncontrados.SelectedCells[1].Value.ToString();
            txtDescripcion.Text = dgvEncontrados.SelectedCells[2].Value.ToString();
            try
            {
                conectar.abrirDB();
                SqlCommand busacar1 = new SqlCommand("SELECT * FROM Stock WHERE CodArticulo = '" + txtcodigo.Text + "'", conectar.conectarDB);
                SqlDataReader reader = busacar1.ExecuteReader();
                reader.Read();
                txtValor.Text = reader["Venta"].ToString();
                txtexistencias.Text = reader["Existencias"].ToString();
                Valor = Convert.ToDecimal(txtValor.Text);
                conectar.cerrarDB();

            }
            catch (Exception ex)
            {
                conectar.cerrarDB();
                MessageBox.Show(ex.Message);
            }

        }
        private void txtIdCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                conectar.abrirDB();
                // Consultar Proveedor
                SqlCommand comando = new SqlCommand("SELECT RTRIM(PrimerNombre) + ' ' + RTRIM(primerApellido) AS Nombre FROM Clientes WHERE Id = @Codigo", conectar.conectarDB);
                comando.Parameters.AddWithValue("Codigo", txtIdCliente.Text);
                SqlDataReader valores = comando.ExecuteReader();

                if (valores.Read())
                {
                    string Nombre = valores["Nombre"].ToString();
                    txtNombreCliente.Text = Nombre;
                    conectar.cerrarDB();
                }
                else
                {
                    conectar.cerrarDB();
                    MessageBox.Show("El Cliente  no se encuentra registrado");
                }
                txtCantidad.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidad.Text != "")
                {
                    Cantidad = Convert.ToDecimal(txtCantidad.Text);
                    decimal Total = Valor * Cantidad;
                    txtTotal.Text = Convert.ToString(Total);
                }
                else
                {

                    txtTotal.Text = "0,00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text == "")
            {
                errorProvider1.SetError(txtIdCliente, "Digite un codigo de cliente");
            }
            else
            {
                if (txtcodigo.Text == "")
                {
                    errorProvider1.SetError(txtcodigo, "Se requiere un condigo de Articulo valido");
                }
                else
                {
                    if (txtCantidad.Text == "")
                    {
                        errorProvider1.SetError(txtCantidad, "Digite una cantidad valida de articulos");
                        MessageBox.Show("Por favor diligencie los campos marcados");
                    }
                    else
                    {
                        if (txtexistencias.Text != "0")
                        {
                            errorProvider1.SetError(txtCantidad, "");
                            errorProvider1.SetError(txtIdCliente, "");
                            errorProvider1.SetError(txtcodigo, "");
                            DataRow dr = dt.NewRow();
                            dr["Codigo"] = txtcodigo.Text;
                            dr["Articulo"] = txtArticulo.Text;
                            dr["Cantidad"] = txtCantidad.Text;
                            dr["ValorUni"] = txtValor.Text;
                            dr["ValorTotal"] = txtTotal.Text;

                            dt.Rows.Add(dr);
                            TotalFactura();
                            txtBuscar.Text = "";
                            txtcodigo.Text = "";
                            txtexistencias.Text = "";
                            txtArticulo.Text = "";
                            txtDescripcion.Text = "";
                            txtValor.Text = "";
                            txtCantidad.Text = "";
                            txtTotal.Text = "";
                            rbtnCodigo.Checked = false;
                            rbtnNombre.Checked = false;
                            rbtnDescripcion.Checked = false;
                            dgvEncontrados.DataSource = null;
                            errorProvider1.SetError(txtCantidad, "");
                            errorProvider1.SetError(txtIdCliente, "");
                            this.panel2.Enabled = false;
                            try
                            {
                                conectar.abrirDB();
                                SqlCommand ultimafactura = new SqlCommand("SELECT Factura FROM Ventas WHERE Item = (SELECT MAX(Item) FROM Ventas)", conectar.conectarDB);
                                SqlDataReader valor = ultimafactura.ExecuteReader();
                                if (valor.Read())
                                {
                                    factura = Convert.ToInt32(valor["Factura"].ToString());
                                    nuevaFactura = factura + 1;
                                    txtFactura.Text = Convert.ToString(nuevaFactura);
                                    conectar.cerrarDB();
                                }
                                else
                                {
                                    conectar.cerrarDB();
                                    nuevaFactura = 1000;
                                    txtFactura.Text = Convert.ToString(nuevaFactura);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                        else
                        {
                            MessageBox.Show("No hay existencias para este articulo, verifique fisicamente el inventario y realice un ajuste de inventario");
                        }

                    }
                }
            }

        }
        private void Registrar_Click(object sender, EventArgs e)
        {
            if (txtRecibido.Text == "")
            {
                errorProvider1.SetError(txtRecibido, "Por favor ingrese el valor de efectivo recibido");
            }
            else
            {
                errorProvider1.SetError(txtRecibido, "");
                if (txtFactura.Text != "")
                {
                    try
                    {
                        conectar.abrirDB();
                        int Salidas = 0;
                        SqlCommand Registrar = new SqlCommand("Insert into Ventas values (GetDate(), @CodArticulo ,@Cantidad, @ValorVenta, @Factura, @IdCliente ,@Usuario)", conectar.conectarDB);
                        SqlCommand buscar = new SqlCommand("SELECT Salidas FROM Stock WHERE CodArticulo = @Buscar", conectar.conectarDB);
                        SqlCommand actualizar = new SqlCommand("UPDATE Stock SET Salidas =  @Cantidad  WHERE CodArticulo = @Parametro ", conectar.conectarDB);
                        DataTable encontrados = new DataTable();

                        int i = 0;
                        foreach (DataGridViewRow row in dgvVentas.Rows)
                        {
                            //registramos la venta
                            Registrar.Parameters.Clear();
                            Registrar.Parameters.AddWithValue("@CodArticulo", Convert.ToString(row.Cells["Codigo"].Value));
                            Registrar.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(row.Cells["Cantidad"].Value));
                            Registrar.Parameters.AddWithValue("@ValorVenta", Convert.ToDecimal(row.Cells["ValorTotal"].Value));
                            Registrar.Parameters.AddWithValue("@Factura", Convert.ToString(txtFactura.Text));
                            Registrar.Parameters.AddWithValue("@IdCliente", Convert.ToInt32(txtIdCliente.Text));
                            Registrar.Parameters.AddWithValue("@Usuario", variablesGlobales.vRol);
                            Registrar.ExecuteNonQuery();
                            buscar.Parameters.Clear();
                            buscar.Parameters.AddWithValue("@Buscar", Convert.ToString(row.Cells["Codigo"].Value));
                            SqlDataAdapter Adaptador = new SqlDataAdapter(buscar);
                            Adaptador.Fill(encontrados);
                            dataGridView2.DataSource = encontrados;
                            Salidas = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value.ToString());
                            actualizar.Parameters.Clear();
                            actualizar.Parameters.AddWithValue("@Parametro", Convert.ToString(row.Cells["Codigo"].Value));
                            actualizar.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(row.Cells["Cantidad"].Value) + Salidas);
                            actualizar.ExecuteNonQuery();
                            Salidas = 0;
                            i++;
                        }
                        MessageBox.Show("Registros Agregados exitosamente");
                        conectar.cerrarDB();
                        txtIdCliente.Text = "";
                        txtNombreCliente.Text = "";
                        dgvVentas.DataSource = null;
                        txtFactura.Text = "";
                        txtCambio.Text = "";
                        txtRecibido.Text = "";
                        txtTotalVenta.Text = "";
                        dt.Clear();
                        this.panel2.Enabled = true;
                        if (MessageBox.Show("¿desea Agregar otra Venta?",
                              "Consulta",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question) == DialogResult.No)
                        {
                            txtBuscar.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }

        }
        private void txtRecibido_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal Total = Convert.ToDecimal(txtTotalVenta.Text);
                decimal Recibido = Convert.ToDecimal(txtRecibido.Text);
                decimal Cambio = Recibido - Total;
                if (Cambio < 0)
                {
                    MessageBox.Show("El valor recibido debe ser Igual o Mayor a el valor de la venta");
                    txtRecibido.Text = "";
                }
                else
                {
                    txtCambio.Text = Convert.ToString(Cambio);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            this.txtBuscar.Text = "";
            this.txtcodigo.Text = "";
            this.txtexistencias.Text = "";
            this.txtArticulo.Text = "";
            this.txtDescripcion.Text = "";
            this.txtValor.Text = "";
            this.txtCantidad.Text = "";
            this.txtTotal.Text = "";
            rbtnCodigo.Checked = false;
            rbtnNombre.Checked = false;
            rbtnDescripcion.Checked = false;
            dgvEncontrados.DataSource = null;
            errorProvider1.SetError(txtCantidad, "");
            errorProvider1.SetError(txtIdCliente, "");
        }
        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            this.txtBuscar.Text = "";
            this.txtcodigo.Text = "";
            this.txtexistencias.Text = "";
            this.txtArticulo.Text = "";
            this.txtDescripcion.Text = "";
            this.txtValor.Text = "";
            this.txtCantidad.Text = "";
            this.txtTotal.Text = "";
            rbtnCodigo.Checked = false;
            rbtnNombre.Checked = false;
            rbtnDescripcion.Checked = false;
            dgvEncontrados.DataSource = null;
            errorProvider1.SetError(txtCantidad, "");
            errorProvider1.SetError(txtIdCliente, "");
            txtIdCliente.Text = "";
            txtNombreCliente.Text = "";
            dt.Clear();
            txtFactura.Text = "";
            txtCambio.Text = "";
            txtRecibido.Text = "";
            txtTotalVenta.Text = "";
            this.panel2.Enabled = true;
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvVentas.SelectedRows)
                {
                    dgvVentas.Rows.Remove(row);
                    txtTotalVenta.Text = "";
                    TotalFactura();
                }
            }
            else
            {
                MessageBox.Show("No hay elmentos para eliminar");
            }
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿desea salir de ventas?, revise que no tengas productos ingresados",
                   "Consulta",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormPrincipal form = new FormPrincipal();
                form.Show();
                this.Hide();

            }
        }

        private void btnVentaDia_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT V.CodArticulo, A.Articulo, V.ValorVenta, V.Cantidad, V.Factura, V.Usuario" +
                                              " FROM Ventas V" +
                                              " JOIN Clientes C ON  V.CodCliente = C.Id" +
                                              " JOIN Articulos A ON V.CodArticulo = A.Codigo" +
                                              " WHERE V.Fecha = Convert(nchar(10),GETDATE(),20)";
            SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
            {
                dgvVentas.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay ventas registradas para este dia");
            }
        }
    }
}

