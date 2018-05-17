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
        public void devolver(int id, string email) {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "delete from TransaccionP where Email like '" + email + "' and Id_Pelicula = " + id;
                SqlCommand cmd = new SqlCommand(comando, cn);
                cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
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
        public transaccionPeliculaEN mostrarTransaccion(int id, string email) {
            try
            {
                transaccionPeliculaEN devolver = new transaccionPeliculaEN(id, email);
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "";
                SqlCommand cmd;
                comando = "select * from TransaccionP where Email like '" + email + "' and Id_Pelicula = " + id;
                cmd = new SqlCommand(comando, cn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    devolver.FechaC = reader["Fecha_Compra"].ToString();
                    if (reader.IsDBNull(4))
                    {
                        devolver.Alquiler = false;
                        devolver.FechaF = null;
                    }
                    else{
                        devolver.FechaF = reader["Fecha_Devolucion"].ToString();
                        devolver.Alquiler = true;
                    }
                }
                reader.Close();
                cn.Close();
                return devolver;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool existe(int id) { return false; }

        public List<int> eliminarAlquiladas(string email)
        {
            try
            {
                List<int> dev = new List<int>();
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "";
                SqlCommand cmd;
                comando = "select * from TransaccionP where Email like '" + email + "' and Alquiler = " + 1;
                cmd = new SqlCommand(comando, cn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (DateTime.Parse(reader["Fecha_Devolucion"].ToString())<=DateTime.Now)
                    {
                        devolver((int)reader["Id_Pelicula"],email);
                        dev.Add((int)reader["Id_Pelicula"]);
                    }

                }
                reader.Close();
                cn.Close();
                return dev;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
