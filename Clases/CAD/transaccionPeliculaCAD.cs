using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases.EN;
using System.Data.SqlClient;
using System.Configuration;

namespace CAD
{
    public class transaccionPeliculaCAD : ItransaccionPeliculaCAD
    {
        public transaccionPeliculaCAD()
        {

        }
        public void alquilar(int id) { }
        public void devolver(int id) { }
        public void comprar(int idPelicula, string email) {

            try
            {
                DateTime fecha = DateTime.Now.AddDays(7);
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "";
                SqlCommand cmd;
                comando = "insert into TransaccionC values ('" + email + "' , " + idPelicula + " , '" + fecha + "' , " + 0 + " ,  null)";
                cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }catch(Exception ex)
            {
                throw new Exception("La película ya ha sido comprada previamente");
            }
        }
        public void modificarCompra(int id) { }
        public void modificarAlquiler(int id) { }
        public transaccionPeliculaEN mostrarTransaccion(int id) { return null; }
        public bool existe(int id) { return false; }
    }
}
