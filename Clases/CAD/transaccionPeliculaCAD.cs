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
        public void alquilar(int idPelicula, string email) {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "";
                SqlCommand cmd;
                comando = "insert into TransaccionP values ('" + email + "' , " + idPelicula + " , '" + DateTime.Now + "' , " + 1 + " ,  '" + DateTime.Now.AddDays(7) + "')";
                cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("La película ya está en alquiler/compra");
            }
        }
        public void devolver(int id) { }
        public void comprar(int idPelicula, string email) {

            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "";
                SqlCommand cmd;
                comando = "insert into TransaccionP values ('" + email + "' , " + idPelicula + " , '" + DateTime.Now + "' , " + 0 + " ,  null)";
                cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }catch(Exception ex)
            {
                throw new Exception("La película ya está en alquiler/compra");
            }
        }
        public void modificarCompra(int id) { }
        public void modificarAlquiler(int id) { }
        public transaccionPeliculaEN mostrarTransaccion(int id) { return null; }
        public bool existe(int id) { return false; }
    }
}
