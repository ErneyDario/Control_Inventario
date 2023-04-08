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
        public String insertar(String IdUsuario, String PrimerNombreUsuar, String SegundoNombreUsuar, String PrimerApellidoUsuar, String SegundoApellidoUsuar, String DireccionUsuar, String CorreoUsuar, String Telefono, String NombreUsuario, String Contraseña, String Rol)
        {
            String Salida = "si se inserto";
            try
            {
                cmd = new SqlCommand("Insert into Usuario(IdUsuario, PrimerNombreUsuar,SegundoNombreUsuar,PrimerApellidoUsuar,SegundoApellidoUsuar,DirrecionUsuar,CorreoUsuar,Telefono,NombreUsuario,Contraseña,Rol) values('" + IdUsuario + "','" + PrimerNombreUsuar + "','" + SegundoNombreUsuar + "','" + PrimerApellidoUsuar + "','" + SegundoApellidoUsuar + "','" + DireccionUsuar + "','" + CorreoUsuar + "','" + NombreUsuario + "','" + Contraseña + "','" + Rol + "')", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex )
            {
                Salida = "No se insertó intente nuevamente:" + ex.ToString();
            }
            return Salida;
        }   
    }
      









}

