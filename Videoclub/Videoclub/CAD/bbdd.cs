using System;
using System.Configuration;
using System.Data.SqlClient;

namespace CAD
{
    public class bbdd
    {
        private SqlConnection bd;
        public SqlConnection getConexion { get { return bd; } }
        private string nombre;
       

        public bbdd()
        {
            nombre = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            try
            {
                bd = new SqlConnection(nombre);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

    }
}

