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
    public partial class FormInventario : Form
    {
        private DataTable dt;
        public FormInventario()
        {
            InitializeComponent();


        }
        bool ok;
        conexionDB conectar = new conexionDB();
        private void FormInventario_Load(object sender, EventArgs e)
        {
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
        }
        private void btnAgregarEntrada_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();

            dr[0] = txtFactura.Text;
            dr[1] = txtIdProveedor.Text;
            dr[2] = txtcodigo.Text;
            dr[3] = txtArticulo.Text;
            dr[4] = txtdescripcion.Text;
            dr[5] = txtvalor.Text;
            dr[6] = txtValorVenta.Text;
            dr[7] = txtExistencias.Text;
            dt.Rows.Add(dr);
        }
        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
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
                }
                else
                {
                    MessageBox.Show("El Articulo no se encuentra registrado");
                }
                conectar.cerrarDB();
                txtvalor.Focus();
            }
        }
        private void btnGestionArticulos_Click(object sender, EventArgs e)
        {
            FormArticulos frm = new FormArticulos();
            frm.ShowDialog();
        }
        private bool confirmarTXT()
        {
            ok = true;

            if (txtFactura.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtFactura, "Ingrese el Numero de Documento del Usuario");
            }
            else
            {
                if (txtIdProveedor.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(txtIdProveedor, "ingrese por favor el Nombre del Usuario");
                }
                else
                {
                    if (txtcodigo.Text == "")
                    {
                        ok = false;
                        errorProvider1.SetError(txtcodigo, "ingrese por favor el Apellido del Usuario");
                    }
                    else
                    {
                        if (txtArticulo.Text == "")
                        {
                            ok = false;
                            errorProvider1.SetError(txtArticulo, "ingrese por favor un Correo Electronico");
                        }
                        else
                        {
                            if (txtdescripcion.Text == "")
                            {
                                ok = false;
                                errorProvider1.SetError(txtdescripcion, "ingrese por favor un Nombre de Usuario");
                            }
                            else
                            {
                                if (txtvalor.Text == "")
                                {
                                    ok = false;
                                    errorProvider1.SetError(txtvalor, "ingrese por favor una Contraseña");
                                }
                                else
                                {
                                    if (txtValorVenta.Text == "")
                                    {
                                        ok = false;
                                        errorProvider1.SetError(txtValorVenta, "Por favor confirme la Contraseña");
                                    }
                                    else
                                    {
                                        if (txtExistencias.Text == "")
                                        {
                                            ok = false;
                                            errorProvider1.SetError(txtExistencias, "Por favor seleccione un rolo");
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
        private void iconPictureBoxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtIdProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                }
                else
                {
                    MessageBox.Show("El proveedor no se encuentra registrado");
                }
                conectar.cerrarDB();
                txtcodigo.Focus();
            }
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlCommand agregar = new SqlCommand("Insert into Entradas values (@Factura, @IdProveedor, @Codigo, @Articulo, @Descripcion, @Valor, @Vent, @Existencias)", conectar.conectarDB);
            conectar.abrirDB();
            try
            {
                foreach (DataGridViewRow row in dtgvEntradas.Rows)
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@Factura", Convert.ToString(row.Cells["Factura"].Value));
                    agregar.Parameters.AddWithValue("@IdProveedor", Convert.ToString(row.Cells["IdProveedor"].Value));
                    agregar.Parameters.AddWithValue("@Codigo", Convert.ToString(row.Cells["Codigo"].Value));
                    agregar.Parameters.AddWithValue("@Articulo", Convert.ToString(row.Cells["Articulo"].Value));
                    agregar.Parameters.AddWithValue("Descripcion", Convert.ToString(row.Cells["Descripcion"].Value));
                    agregar.Parameters.AddWithValue("@Valor", Convert.ToString(row.Cells["Valor"].Value));
                    agregar.Parameters.AddWithValue("@Venta", Convert.ToString(row.Cells["Venta"].Value));
                    agregar.Parameters.AddWithValue("@Cantidad", Convert.ToString(row.Cells["Cantidad"].Value));
                    agregar.ExecuteNonQuery();
                }
                MessageBox.Show("Registros Agregados exitosamente");
            }catch(Exception ex)
            {
                MessageBox.Show("Error al agrgar los datos" );
            }
            finally
            {
                conectar.cerrarDB();
            }

        }
    }
}
