using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Control_Inventario
{
    internal class Conexion
    {
        SqlConnection conn;
        SqlCommand cmd;

        SqlDataReader dr;
        SqlDataAdapter adaptador;
        DataSet ds;
        SqlDataAdapter da;
        DataTable dt;

        public Conexion()
        {
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=BDControl_Inventario;Integrated Security=True");
                conn.Open();
                MessageBox.Show("Conexion abierta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos:" + ex.ToString());
            }
        }
        public String insertar(String IdUsuario, String PrimerNombreUsuar, String SegundoNombreUsuar, String PrimerApellidoUsuar, String SegundoApellidoUsuar, String DireccionUsuar, String CorreoUsuar, String Telefono, String NombreUsuario, String Contraseña, String Confirmar)
        {
            String Salida = "si se inserto";
            try
            {
                cmd = new SqlCommand("Insert into Usuario(IdUsuario, PrimerNombreUsuar,SegundoNombreUsuar,PrimerApellidoUsuar,SegundoApellidoUsuar,DirrecionUsuar,CorreoUsuar,Telefono,NombreUsuario,Contraseña,Confirmar) values('" + IdUsuario + "','" + PrimerNombreUsuar + "','" + SegundoNombreUsuar + "','" + PrimerApellidoUsuar + "','" + SegundoApellidoUsuar + "','" + DireccionUsuar + "','" + CorreoUsuar + "','" + Telefono + "','" + NombreUsuario + "','" + Contraseña + "','" + Confirmar + "')", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Salida = "No se insertó intente nuevamente:" + ex.ToString();
            }
            return Salida;
        }
        public int UsuarioRegistrado(String IdUsuario)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from Usuario where IdUsuario=" + IdUsuario + "", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar:" + ex.ToString());
            }
            return contador;
        }
        public int VentaRegistrada(String CodigoVenta)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from Ventas where CodigoVenta=" + CodigoVenta + "", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar la venta:" + ex.ToString());
            }
            return contador;
            }


            public void CargarVentas(DataGridView dgv)
            {
                try
                {
                    da = new SqlDataAdapter("select * from Ventas", conn);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo llenar el datagridview:" + ex.ToString());
                }
            }

            public void CargarUsuario(DataGridView dgv)
            {
                try
                {
                    da = new SqlDataAdapter("select * from Usuario", conn);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo llenar el datagridview:" + ex.ToString());
                }




            }








        }

    }


