using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Control_Inventario
{
    internal class conexionDB
    {
        //Cadena de Conexión
        string cadenaConexion = "Data source = DESKTOP-5U4MPGI; initial Catalog = Control_Inventario; Integrated Security = True";
        public SqlConnection conectarDB = new SqlConnection();

        //constructor
        public conexionDB ()
        {
            conectarDB.ConnectionString = cadenaConexion;
        }

        // metodo para abrir la conexión
        public void abrirDB()
        {
            try
            {
                conectarDB.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir db " + ex.Message);
            }
        }

        // Metodo para cerrar la conexión
        public void cerrarDB ()
        {
            conectarDB.Close();
        }
    }
}
