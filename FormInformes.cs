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
using System.Windows.Shapes;

namespace Control_Inventario
{
    public partial class FormInformes : Form
    {
        public FormInformes()
        {
            InitializeComponent();
        }
        conexionDB conectar = new conexionDB();
        int Boton = 0;
        private void BuscarUsuario()
        {
            if (cmbTipo.SelectedIndex == 0)
            {

                try
                {
                    string consulta = " SELECT * FROM Usuarios WHERE Id= " + txtBuscar.Text + "";
                    SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                    SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                    {
                        dtgvInformes.DataSource = dt;
                        txtBuscar.Text = "";
                        cmbTipo.ResetText();
                        txtBuscar.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbTipo.SelectedIndex == 1)
            {
                try
                {
                    string consulta = " select * from Usuarios where primerNombre = '" + txtBuscar.Text + "' OR segundoNombre = '" + txtBuscar.Text + "' OR primerApellido = '" + txtBuscar.Text + "' OR segundoApellido = '" + txtBuscar.Text + "' ";
                    SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                    SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                    {
                        dtgvInformes.DataSource = dt;

                        txtBuscar.Text = "";
                        cmbTipo.ResetText();
                        txtBuscar.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbTipo.SelectedIndex == 2)
            {
                try
                {
                    string consulta = " select * from Usuarios where usuario= '" + txtBuscar.Text + "' ";
                    SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                    SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                    {
                        dtgvInformes.DataSource = dt;

                        txtBuscar.Text = "";
                        cmbTipo.ResetText();
                        txtBuscar.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbTipo.SelectedIndex == 3)
            {
                try
                {
                    string consulta = " select * from Usuarios where rol= '" + txtBuscar.Text + "' ";
                    SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                    SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                    {
                        dtgvInformes.DataSource = dt;

                        txtBuscar.Text = "";
                        cmbTipo.ResetText();
                        txtBuscar.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un tipo de busqueda de la lista");
            }

        }
        private void BuscarProveedor()
        {
            if (cmbTipo.SelectedIndex == 0)
            {

                try
                {
                    string consulta = " select * from Proveedores where IdProveedor= " + txtBuscar.Text + "";
                    SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                    SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                    {
                        dtgvInformes.DataSource = dt;
                        txtBuscar.Text = "";
                        cmbTipo.ResetText();
                        txtBuscar.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbTipo.SelectedIndex == 1)
            {
                try
                {
                    string consulta = " select * from Proveedores where NombreProveedor LIKE '%" + txtBuscar.Text + "%'";
                    SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                    SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                    {
                        dtgvInformes.DataSource = dt;

                        txtBuscar.Text = "";
                        cmbTipo.ResetText();
                        txtBuscar.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un tipo de busqueda de la lista");
            }
        }
        private void BuscarClientes()
        {
            if (cmbTipo.SelectedIndex == 0)
            {

                try
                {
                    string consulta = " select * from Clientes where Id= " + txtBuscar.Text + "";
                    SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                    SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                    {
                        dtgvInformes.DataSource = dt;
                        txtBuscar.Text = "";
                        cmbTipo.ResetText();
                        txtBuscar.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbTipo.SelectedIndex == 1)
            {
                try
                {
                    string consulta = " select * from Clientes where primerNombre LIKE '%" + txtBuscar.Text + "%' OR segundoNombre LIKE '%" + txtBuscar.Text + "%'OR primerApellido LIKE '%" + txtBuscar.Text + "%' OR segundoApellido LIKE '%" + txtBuscar.Text + "%'";
                    SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                    SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                    {
                        dtgvInformes.DataSource = dt;

                        txtBuscar.Text = "";
                        cmbTipo.ResetText();
                        txtBuscar.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un tipo de busqueda de la lista");
            }
        }
        private void BuscarCompras()
        {
            if (cmbTipo.SelectedIndex == 0)
            {

                try
                {
                    if (rbtFecha.Checked)
                    {
                        if (txtBuscar.Text == "")
                        {
                            string consulta = "SELECT E.CodProveedor, P.NombreProveedor, E.Fecha, E.CodArticulo, A.Articulo, E.Cantidad, E.Valor, E.Factura, E.Usuario" +
                                              " FROM Entradas E" +
                                              " JOIN Proveedores P ON  E.CodProveedor = P.IdProveedor" +
                                              " JOIN Articulos A ON E.CodArticulo = A.Codigo" +
                                              " WHERE E.Fecha >= @FechaInicio AND E.Fecha <= @FechaFin";
                            SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                            Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                            Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                            {
                                dtgvInformes.DataSource = dt;
                                txtBuscar.Text = "";
                                cmbTipo.ResetText();
                                txtBuscar.ReadOnly = true;
                                rbtFecha.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                            }

                        }
                        else
                        {
                            string consulta = "SELECT E.CodProveedor, P.NombreProveedor, E.Fecha, E.CodArticulo, A.Articulo, E.Cantidad, E.Valor, E.Factura, E.Usuario" +
                                              " FROM Entradas E" +
                                              " JOIN Proveedores P ON  E.CodProveedor = P.IdProveedor" +
                                              " JOIN Articulos A ON E.CodArticulo = A.Codigo" +
                                              " WHERE E.CodProveedor = '" + Convert.ToInt64(txtBuscar.Text) + "' AND E.Fecha >= @FechaInicio AND E.Fecha <= @FechaFin";
                            SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                            Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                            Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                            {
                                dtgvInformes.DataSource = dt;
                                txtBuscar.Text = "";
                                cmbTipo.ResetText();
                                txtBuscar.ReadOnly = true;
                                rbtFecha.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                            }
                        }
                    }
                    else
                    {
                        string consulta = "SELECT E.CodProveedor, P.NombreProveedor, E.Fecha, E.CodArticulo, A.Articulo, E.Cantidad, E.Valor, E.Factura, E.Usuario" +
                                          " FROM Entradas E" +
                                          " JOIN Proveedores P ON  E.CodProveedor = P.IdProveedor" +
                                          " JOIN Articulos A ON E.CodArticulo = A.Codigo" +
                                          " WHERE E.CodProveedor = '" + Convert.ToInt64(txtBuscar.Text) + "' ";
                        SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                        SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                        {
                            dtgvInformes.DataSource = dt;
                            txtBuscar.Text = "";
                            cmbTipo.ResetText();
                            txtBuscar.ReadOnly = true;
                            pFecha.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbTipo.SelectedIndex == 1)
            {
                try
                {
                    if (rbtFecha.Checked)
                    {
                        if (txtBuscar.Text == "")
                        {
                            string consulta = "SELECT E.CodArticulo, A.Articulo, E.Cantidad, E.Valor, E.Factura, E.CodProveedor, P.NombreProveedor, E.Fecha, E.Usuario" +
                                          " FROM Entradas E" +
                                          " JOIN Proveedores P ON E.CodProveedor = P.IdProveedor" +
                                          " JOIN Articulos A ON E.CodArticulo = A.Codigo" +
                                          " WHERE E.Fecha >= @FechaInicio AND E.Fecha <= @FechaFin";
                            SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                            Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                            Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                            {
                                dtgvInformes.DataSource = dt;
                                txtBuscar.Text = "";
                                cmbTipo.ResetText();
                                txtBuscar.ReadOnly = true;
                                rbtFecha.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                            }

                        }
                        else
                        {
                            string consulta = "SELECT E.CodArticulo, A.Articulo, E.Cantidad, E.Valor, E.Factura, E.CodProveedor, P.NombreProveedor, E.Fecha, E.Usuario" +
                                          " FROM Entradas E" +
                                          " JOIN Proveedores P ON E.CodProveedor = P.IdProveedor" +
                                          " JOIN Articulos A ON E.CodArticulo = A.Codigo" +
                                          " WHERE E.CodArticulo = '" + txtBuscar.Text + "' AND E.Fecha >= @FechaInicio AND E.Fecha <= @FechaFin";
                            SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                            Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                            Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                            {
                                dtgvInformes.DataSource = dt;
                                txtBuscar.Text = "";
                                cmbTipo.ResetText();
                                txtBuscar.ReadOnly = true;
                                rbtFecha.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                            }
                        }
                    }
                    else
                    {
                        string consulta = "SELECT E.CodArticulo, A.Articulo, E.Cantidad, E.Valor, E.Factura, E.CodProveedor, P.NombreProveedor, E.Fecha, E.Usuario" +
                                          " FROM Entradas E" +
                                          " JOIN Proveedores P ON E.CodProveedor = P.IdProveedor" +
                                          " JOIN Articulos A ON E.CodArticulo = A.Codigo" +
                                          " WHERE E.CodArticulo = '" + txtBuscar.Text + "'";
                        SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                        SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                        {
                            dtgvInformes.DataSource = dt;
                            txtBuscar.Text = "";
                            cmbTipo.ResetText();
                            txtBuscar.ReadOnly = true;
                            pFecha.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbTipo.SelectedIndex == 2)
            {
                try
                {
                    if (rbtFecha.Checked)
                    {
                        if (txtBuscar.Text == "")
                        {
                            string consulta = " SELECT E.Factura, E.CodArticulo, A.Articulo, E.Cantidad, E.Valor,  E.CodProveedor, P.NombreProveedor, E.Fecha, E.Usuario" +
                                          " FROM Entradas E" +
                                          " JOIN Proveedores P ON E.CodProveedor = P.IdProveedor" +
                                          " JOIN Articulos A ON E.CodArticulo = A.Codigo" +
                                          " WHERE E.Fecha >= @FechaInicio AND E.Fecha <= @FechaFin";
                            SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                            Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                            Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                            {
                                dtgvInformes.DataSource = dt;
                                txtBuscar.Text = "";
                                cmbTipo.ResetText();
                                txtBuscar.ReadOnly = true;
                                rbtFecha.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                            }

                        }
                        else
                        {
                            string consulta = "SELECT E.Factura, E.CodArticulo, A.Articulo, E.Cantidad, E.Valor, E.CodProveedor, P.NombreProveedor, E.Fecha, E.Usuario" +
                                          " FROM Entradas E" +
                                          " JOIN Proveedores P ON E.CodProveedor = P.IdProveedor" +
                                          " JOIN Articulos A ON E.CodArticulo = A.Codigo" +
                                          " WHERE E.Factura = '" + txtBuscar.Text + "' AND E.Fecha >= @FechaInicio AND E.Fecha <= @FechaFin";
                            SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                            Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                            Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                            {
                                dtgvInformes.DataSource = dt;
                                txtBuscar.Text = "";
                                cmbTipo.ResetText();
                                txtBuscar.ReadOnly = true;
                                rbtFecha.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                            }
                        }
                    }
                    else
                    {
                        string consulta = "SELECT E.Factura, E.CodArticulo, A.Articulo, E.Cantidad, E.Valor, E.CodProveedor, P.NombreProveedor, E.Fecha, E.Usuario" +
                                          " FROM Entradas E" +
                                          " JOIN Proveedores P ON E.CodProveedor = P.IdProveedor" +
                                          " JOIN Articulos A ON E.CodArticulo = A.Codigo" +
                                          " WHERE E.Factura = '" + txtBuscar.Text + "'";
                        SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                        SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                        {
                            dtgvInformes.DataSource = dt;
                            txtBuscar.Text = "";
                            cmbTipo.ResetText();
                            txtBuscar.ReadOnly = true;
                            pFecha.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (cmbTipo.SelectedIndex == 3)
            {
                try
                {
                    if (rbtFecha.Checked)
                    {
                        if (txtBuscar.Text == "")
                        {
                            string consulta = " SELECT E.Usuario, E.CodArticulo, A.Articulo, E.Cantidad, E.Valor,  E.CodProveedor, P.NombreProveedor, E.Fecha,  E.Factura" +
                                          " FROM Entradas E" +
                                          " JOIN Proveedores P ON E.CodProveedor = P.IdProveedor" +
                                          " JOIN Articulos A ON E.CodArticulo = A.Codigo" +
                                          " WHERE E.Fecha >= @FechaInicio AND E.Fecha <= @FechaFin";
                            SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                            Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                            Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                            {
                                dtgvInformes.DataSource = dt;
                                txtBuscar.Text = "";
                                cmbTipo.ResetText();
                                txtBuscar.ReadOnly = true;
                                rbtFecha.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                            }

                        }
                        else
                        {
                            string consulta = "SELECT E.Usuario, E.CodArticulo, A.Articulo, E.Cantidad, E.Valor, E.CodProveedor, P.NombreProveedor, E.Fecha, E.Factura" +
                                          " FROM Entradas E" +
                                          " JOIN Proveedores P ON E.CodProveedor = P.IdProveedor" +
                                          " JOIN Articulos A ON E.CodArticulo = A.Codigo" +
                                          " WHERE E.Usuario = '" + txtBuscar.Text + "' AND E.Fecha >= @FechaInicio AND E.Fecha <= @FechaFin";
                            SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                            Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                            Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                            {
                                dtgvInformes.DataSource = dt;
                                txtBuscar.Text = "";
                                cmbTipo.ResetText();
                                txtBuscar.ReadOnly = true;
                                rbtFecha.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                            }
                        }
                    }
                    else
                    {
                        string consulta = "SELECT E.Factura, E.CodArticulo, A.Articulo, E.Cantidad, E.Valor, E.CodProveedor, P.NombreProveedor, E.Fecha, E.Usuario" +
                                          " FROM Entradas E" +
                                          " JOIN Proveedores P ON E.CodProveedor = P.IdProveedor" +
                                          " JOIN Articulos A ON E.CodArticulo = A.Codigo" +
                                          " WHERE E.Usuario = '" + txtBuscar.Text + "'";
                        SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                        SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                        {
                            dtgvInformes.DataSource = dt;
                            txtBuscar.Text = "";
                            cmbTipo.ResetText();
                            txtBuscar.ReadOnly = true;
                            pFecha.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void BuscarVentas()
        {
            if (cmbTipo.SelectedIndex == 0)
            {

                try
                {
                    if (rbtFecha.Checked)
                    {
                        if (txtBuscar.Text == "")
                        {
                            string consulta = "SELECT V.Factura, V.CodArticulo, A.Articulo, V.ValorVenta, V.Cantidad, V.CodCliente, RTRIM(C.primerNombre) + ' ' + RTRIM(C.primerApellido) AS Nombre, V.Usuario" +
                                              " FROM Ventas V" +
                                              " JOIN Clientes C ON  V.CodCliente = C.Id" +
                                              " JOIN Articulos A ON V.CodArticulo = A.Codigo" +
                                              " WHERE V.Fecha >= @FechaInicio AND V.Fecha <= @FechaFin";
                            SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                            Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                            Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                            {
                                dtgvInformes.DataSource = dt;
                                txtBuscar.Text = "";
                                cmbTipo.ResetText();
                                txtBuscar.ReadOnly = true;
                                rbtFecha.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                            }

                        }
                        else
                        {
                            string consulta = "SELECT V.Factura, V.CodArticulo, A.Articulo, V.ValorVenta, V.Cantidad, V.CodCliente, RTRIM(C.primerNombre) + ' ' + RTRIM(C.primerApellido) AS Nombre, V.Usuario" +
                                              " FROM Ventas V" +
                                              " JOIN Clientes C ON  V.CodCliente = C.Id" +
                                              " JOIN Articulos A ON V.CodArticulo = A.Codigo" +
                                              " WHERE V.Factura = '" + txtBuscar.Text + "' AND V.Fecha >= @FechaInicio AND V.Fecha <= @FechaFin";
                            SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                            Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                            Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                            {
                                dtgvInformes.DataSource = dt;
                                txtBuscar.Text = "";
                                cmbTipo.ResetText();
                                txtBuscar.ReadOnly = true;
                                rbtFecha.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                            }
                        }
                    }
                    else
                    {
                        string consulta = "SELECT V.Factura, V.CodArticulo, A.Articulo, V.ValorVenta, V.Cantidad, V.CodCliente, RTRIM(C.primerNombre) + ' ' + RTRIM(C.primerApellido) AS Nombre, V.Usuario" +
                                              " FROM Ventas V" +
                                              " JOIN Clientes C ON  V.CodCliente = C.Id" +
                                              " JOIN Articulos A ON V.CodArticulo = A.Codigo" +
                                              " WHERE V.Factura = '" + txtBuscar.Text + "'";
                        SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                        SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                        {
                            dtgvInformes.DataSource = dt;
                            txtBuscar.Text = "";
                            cmbTipo.ResetText();
                            txtBuscar.ReadOnly = true;
                            pFecha.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbTipo.SelectedIndex == 1)
            {
                try
                {
                    if (rbtFecha.Checked)
                    {
                        if (txtBuscar.Text == "")
                        {
                            string consulta = "SELECT V.CodArticulo, A.Articulo, V.ValorVenta, V.Cantidad, V.CodCliente, RTRIM(C.primerNombre) + ' ' + RTRIM(C.primerApellido) AS Nombre, V.Factura, V.Usuario" +
                                              " FROM Ventas V" +
                                              " JOIN Clientes C ON  V.CodCliente = C.Id" +
                                              " JOIN Articulos A ON V.CodArticulo = A.Codigo" +
                                              " WHERE V.Fecha >= @FechaInicio AND V.Fecha <= @FechaFin";
                            SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                            Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                            Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                            {
                                dtgvInformes.DataSource = dt;
                                txtBuscar.Text = "";
                                cmbTipo.ResetText();
                                txtBuscar.ReadOnly = true;
                                rbtFecha.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                            }

                        }
                        else
                        {
                            string consulta = "SELECT V.CodArticulo, A.Articulo, V.ValorVenta, V.Cantidad, V.CodCliente, RTRIM(C.primerNombre) + ' ' + RTRIM(C.primerApellido) AS Nombre, V.Factura, V.Usuario" +
                                              " FROM Ventas V" +
                                              " JOIN Clientes C ON  V.CodCliente = C.Id" +
                                              " JOIN Articulos A ON V.CodArticulo = A.Codigo" +
                                              " WHERE V.CodArticulo = '" + txtBuscar.Text + "' AND V.Fecha >= @FechaInicio AND V.Fecha <= @FechaFin";
                            SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                            Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                            Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                            {
                                dtgvInformes.DataSource = dt;
                                txtBuscar.Text = "";
                                cmbTipo.ResetText();
                                txtBuscar.ReadOnly = true;
                                rbtFecha.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                            }
                        }
                    }
                    else
                    {
                        string consulta = "SELECT V.CodArticulo, A.Articulo, V.ValorVenta, V.Cantidad, V.CodCliente, RTRIM(C.primerNombre) + ' ' + RTRIM(C.primerApellido) AS Nombre, V.Factura, V.Usuario" +
                                              " FROM Ventas V" +
                                              " JOIN Clientes C ON  V.CodCliente = C.Id" +
                                              " JOIN Articulos A ON V.CodArticulo = A.Codigo" +
                                              " WHERE V.CodArticulo = '" + txtBuscar.Text + "'";
                        SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                        SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                        {
                            dtgvInformes.DataSource = dt;
                            txtBuscar.Text = "";
                            cmbTipo.ResetText();
                            txtBuscar.ReadOnly = true;
                            pFecha.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbTipo.SelectedIndex == 2)
            {
                try
                {
                    if (rbtFecha.Checked)
                    {
                        if (txtBuscar.Text == "")
                        {
                            string consulta = " SELECT V.CodCliente, RTRIM(C.primerNombre) + ' ' + RTRIM(C.primerApellido) AS Nombre, V.Factura, V.CodArticulo, A.Articulo, V.Cantidad, V.ValorVenta,  V.Fecha, V.Usuario" +
                                              " FROM Ventas V" +
                                              " JOIN Clientes C ON  V.CodCliente = C.Id" +
                                              " JOIN Articulos A ON V.CodArticulo = A.Codigo" +
                                              " WHERE V.Fecha >= @FechaInicio AND V.Fecha <= @FechaFin";
                            SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                            Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                            Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                            {
                                dtgvInformes.DataSource = dt;
                                txtBuscar.Text = "";
                                cmbTipo.ResetText();
                                txtBuscar.ReadOnly = true;
                                rbtFecha.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                            }

                        }
                        else
                        {
                            string consulta = " SELECT V.CodCliente, RTRIM(C.primerNombre) + ' ' + RTRIM(C.primerApellido) AS Nombre, V.Factura, V.CodArticulo, A.Articulo, V.Cantidad, V.ValorVenta,  V.Fecha, V.Usuario" +
                                         " FROM Ventas V" +
                                         " JOIN Clientes C ON  V.CodCliente = C.Id" +
                                         " JOIN Articulos A ON V.CodArticulo = A.Codigo" +
                                         " WHERE V.CodCliente  = '" + txtBuscar.Text + "' AND V.Fecha >= @FechaInicio AND V.Fecha <= @FechaFin";
                            SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                            Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                            Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                            {
                                dtgvInformes.DataSource = dt;
                                txtBuscar.Text = "";
                                cmbTipo.ResetText();
                                txtBuscar.ReadOnly = true;
                                rbtFecha.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                            }
                        }
                    }
                    else
                    {
                        string consulta = " SELECT V.CodCliente, RTRIM(C.primerNombre) + ' ' + RTRIM(C.primerApellido) AS Nombre, V.Factura, V.CodArticulo, A.Articulo, V.Cantidad, V.ValorVenta,  V.Fecha, V.Usuario" +
                                         " FROM Ventas V" +
                                         " JOIN Clientes C ON  V.CodCliente = C.Id" +
                                         " JOIN Articulos A ON V.CodArticulo = A.Codigo" +
                                         " WHERE V.CodCliente  = '" + txtBuscar.Text + "'";
                        SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                        SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                        {
                            dtgvInformes.DataSource = dt;
                            txtBuscar.Text = "";
                            cmbTipo.ResetText();
                            txtBuscar.ReadOnly = true;
                            pFecha.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (cmbTipo.SelectedIndex == 3)
            {
                try
                {
                    if (rbtFecha.Checked)
                    {
                        if (txtBuscar.Text == "")
                        {
                            string consulta = " SELECT V.Usuario, V.CodArticulo, A.Articulo, V.Cantidad, V.ValorVenta,  V.CodCliente, RTRIM(C.primerNombre) + ' ' + RTRIM(C.primerApellido) AS Nombre  ,  V.Factura , V.Fecha" +
                                              " FROM Ventas V" +
                                              " JOIN Clientes C ON  V.CodCliente = C.Id" +
                                              " JOIN Articulos A ON V.CodArticulo = A.Codigo" +
                                              " WHERE V.Fecha >= @FechaInicio AND V.Fecha <= @FechaFin";
                            SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                            Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                            Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                            {
                                dtgvInformes.DataSource = dt;
                                txtBuscar.Text = "";
                                cmbTipo.ResetText();
                                txtBuscar.ReadOnly = true;
                                rbtFecha.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                            }

                        }
                        else
                        {
                            string consulta = " SELECT V.Usuario, V.CodArticulo, A.Articulo, V.Cantidad, V.ValorVenta,  V.CodCliente, RTRIM(C.primerNombre) + ' ' + RTRIM(C.primerApellido) AS Nombre  ,  V.Factura , V.Fecha" +
                                              " FROM Ventas V" +
                                              " JOIN Clientes C ON  V.CodCliente = C.Id" +
                                              " JOIN Articulos A ON V.CodArticulo = A.Codigo" +
                                              " WHERE V.Usuario = '" + txtBuscar.Text + "' AND V.Fecha >= @FechaInicio AND v.Fecha <= @FechaFin";
                            SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                            Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                            Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                            SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                            {
                                dtgvInformes.DataSource = dt;
                                txtBuscar.Text = "";
                                cmbTipo.ResetText();
                                txtBuscar.ReadOnly = true;
                                rbtFecha.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                            }
                        }
                    }
                    else
                    {
                        string consulta = " SELECT V.Usuario, V.CodArticulo, A.Articulo, V.Cantidad, V.ValorVenta,  V.CodCliente, RTRIM(C.primerNombre) + ' ' + RTRIM(C.primerApellido) AS Nombre  ,  V.Factura , V.Fecha" +
                                           " FROM Ventas V" +
                                           " JOIN Clientes C ON  V.CodCliente = C.Id" +
                                           " JOIN Articulos A ON V.CodArticulo = A.Codigo" +
                                           " WHERE V.Usuario = '" + txtBuscar.Text + "'";
                        SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                        SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                        {
                            dtgvInformes.DataSource = dt;
                            txtBuscar.Text = "";
                            cmbTipo.ResetText();
                            txtBuscar.ReadOnly = true;
                            pFecha.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void BuscarStock()
        {
            if (cmbTipo.SelectedIndex == 0)
            {

                try
                {
                    string consulta = "SELECT S.CodArticulo, A.Articulo, S.Valor, S.Venta, S.Entradas, S.Salidas, S.Existencias" +
                                      " FROM Stock S" +
                                      " JOIN Articulos A ON S.CodArticulo = A.Codigo" +
                                      " WHERE S.CodArticulo = '" + txtBuscar.Text + "'";
                    SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                    Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                    Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                    SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                    {
                        dtgvInformes.DataSource = dt;
                        txtBuscar.Text = "";
                        cmbTipo.ResetText();
                        txtBuscar.ReadOnly = true;
                        rbtFecha.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbTipo.SelectedIndex == 1)
            {

                try
                {
                    string consulta = "SELECT S.CodArticulo, A.Articulo, S.Valor, S.Venta, S.Entradas, S.Salidas, S.Existencias" +
                                              " FROM Stock S" +
                                              " JOIN Articulos A ON S.CodArticulo = A.Codigo" +
                                              " WHERE S.Salidas = (SELECT MAX(Salidas) FROM Stock)";
                    SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                    Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                    Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                    SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                    {
                        dtgvInformes.DataSource = dt;
                        txtBuscar.Text = "";
                        cmbTipo.ResetText();
                        txtBuscar.ReadOnly = true;
                        rbtFecha.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbTipo.SelectedIndex == 2)
            {

                try
                {
                    string consulta = "SELECT S.CodArticulo, A.Articulo, S.Valor, S.Venta, S.Entradas, S.Salidas, S.Existencias" +
                                              " FROM Stock S" +
                                              " JOIN Articulos A ON S.CodArticulo = A.Codigo" +
                                              " WHERE S.Salidas = (SELECT MIN(Salidas) FROM Stock)";
                    SqlCommand Comando = new SqlCommand(consulta, conectar.conectarDB);
                    Comando.Parameters.AddWithValue("@FechaInicio", dTPInicio.Value.Date);
                    Comando.Parameters.AddWithValue("@FechaFin", dTPFin.Value.Date);
                    SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    if (dt.Rows.Count != 0)// validamos que la busqueda sea efectiva
                    {
                        dtgvInformes.DataSource = dt;
                        txtBuscar.Text = "";
                        cmbTipo.ResetText();
                        txtBuscar.ReadOnly = true;
                        rbtFecha.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para esta consulta, verique sus datos e intente nuevamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Boton = 1;
            txtBuscar.Text = "";
            txtBuscar.ReadOnly = true;
            cmbTipo.ResetText();
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Id Usuario");
            cmbTipo.Items.Add("Nombre");
            cmbTipo.Items.Add("Usuario");
            cmbTipo.Items.Add("Rol");
            pFecha.Enabled = false;
            rbtFecha.Enabled = false;



            try
            {
                SqlCommand usuarios = new SqlCommand("SELECT * FROM Usuarios", conectar.conectarDB);
                SqlDataAdapter adaptador = new SqlDataAdapter(usuarios);
                DataTable du = new DataTable();
                adaptador.Fill(du);
                dtgvInformes.DataSource = du;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Boton = 2;
            txtBuscar.Text = "";
            cmbTipo.ResetText();
            txtBuscar.ReadOnly = true;
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Id");
            cmbTipo.Items.Add("Nombre");
            pFecha.Enabled = false;
            rbtFecha.Enabled = false;


            try
            {
                SqlCommand proveedores = new SqlCommand("SELECT * FROM Proveedores", conectar.conectarDB);
                SqlDataAdapter adaptador = new SqlDataAdapter(proveedores);
                DataTable dp = new DataTable();
                adaptador.Fill(dp);
                dtgvInformes.DataSource = dp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            Boton = 3;
            txtBuscar.Text = "";
            txtBuscar.ReadOnly = true;
            pFecha.Enabled = false;
            rbtFecha.Enabled = false;
            cmbTipo.ResetText();
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Id");
            cmbTipo.Items.Add("Nombre");
            try
            {
                SqlCommand clientes = new SqlCommand("SELECT * FROM Clientes", conectar.conectarDB);
                SqlDataAdapter adaptador = new SqlDataAdapter(clientes);
                DataTable dc = new DataTable();
                adaptador.Fill(dc);
                dtgvInformes.DataSource = dc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnInventario_Click(object sender, EventArgs e)
        {
            Boton = 4;
            txtBuscar.Text = "";
            cmbTipo.ResetText();
            txtBuscar.ReadOnly = true;
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Proveedor");
            cmbTipo.Items.Add("Articulos");
            cmbTipo.Items.Add("Factura");
            cmbTipo.Items.Add("Usuario");
            pFecha.Enabled = false;
            rbtFecha.Enabled = true;

            SqlCommand inventario = new SqlCommand("SELECT * FROM Entradas", conectar.conectarDB);
            SqlDataAdapter adaptador = new SqlDataAdapter(inventario);
            DataTable di = new DataTable();
            adaptador.Fill(di);
            dtgvInformes.DataSource = di;
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            Boton = 5;
            txtBuscar.Text = "";
            txtBuscar.ReadOnly = true;
            cmbTipo.ResetText();
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Factura");
            cmbTipo.Items.Add("Articulos");
            cmbTipo.Items.Add("Cliente");
            cmbTipo.Items.Add("Vendedor");
            pFecha.Enabled = false;
            rbtFecha.Enabled = true;
            SqlCommand ventas = new SqlCommand("SELECT * FROM Ventas", conectar.conectarDB);
            SqlDataAdapter adaptador = new SqlDataAdapter(ventas);
            DataTable dv = new DataTable();
            adaptador.Fill(dv);
            dtgvInformes.DataSource = dv;
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            Boton = 6;
            txtBuscar.Text = "";
            cmbTipo.ResetText();
            txtBuscar.ReadOnly = true;
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Articulos");
            cmbTipo.Items.Add("Articulo Mas Vendido");
            cmbTipo.Items.Add("Articulo Menos Vendido");
            pFecha.Enabled = false;
            rbtFecha.Enabled = false;
            SqlCommand stock = new SqlCommand("SELECT * FROM Stock", conectar.conectarDB);
            SqlDataAdapter adaptador = new SqlDataAdapter(stock);
            DataTable ds = new DataTable();
            adaptador.Fill(ds);
            dtgvInformes.DataSource = ds;
        }
        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            if (Boton == 1)
            {
                BuscarUsuario();
            }
            else if (Boton == 2)
            {
                BuscarProveedor();
            }
            else if (Boton == 3)
            {
                BuscarClientes();
            }
            else if (Boton == 4)
            {
                BuscarCompras();

            }
            else if (Boton == 5)
            {
                BuscarVentas();

            }
            else if (Boton == 6)
            {
                BuscarStock();

            }

        }
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscar.ReadOnly = false;
            dtgvInformes.DataSource = null;
            rbtFecha.Checked = false;

        }
        private void rbtFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtFecha.Checked)
            {
                pFecha.Enabled = true;
            }
            else
            {
                pFecha.Enabled = false;
            }

        }
        private void iconPictureBoxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInformes_Load(object sender, EventArgs e)
        {
         
        }
    }
}
