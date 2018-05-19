using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases.EN;
using System.Data.SqlClient;
using System.Configuration;

namespace CAD
{
    public class transaccionSerieCAD : ItransaccionSerieCAD
    {
        public transaccionSerieCAD()
        {

        }
        public void alquilar(int idSerie, string email) {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "";
                SqlCommand cmd;
                comando = "insert into TransaccionS values ('" + email + "' , " + idSerie + " , '" + DateTime.Now + "' , " + 1 + " ,  '" + DateTime.Now.AddDays(7) + "')";
                cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception)
            {
                throw new Exception("La serie ya está en alquiler/compra");
            }
        }
        public void devolver(int id) { }
        public void comprar(int idSerie, string email) {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "";
                SqlCommand cmd;
                comando = "insert into TransaccionS values ('" + email + "' , " + idSerie + " , '" + DateTime.Now + "' , " + 0 + " ,  null)";
                cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception)
            {
                throw new Exception("La serie ya está en alquiler/compra");
            }
        }
        public void modificarCompra(int id) { }
        public transaccionSerieEN modificarAlquiler(int id, string email) {
            try
            {
                transaccionSerieEN devolver = new transaccionSerieEN(id, email);
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "";
                SqlCommand cmd;
                comando = "select * from TransaccionS where Email like '" + email + "' and Id_Serie = " + id;
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
                    else
                    {
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
        public transaccionSerieEN mostrarTransaccion(int id, string email)
        {
            try
            {
                transaccionSerieEN devolver = new transaccionSerieEN(id, email);
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "";
                SqlCommand cmd;
                comando = "select * from TransaccionS where Email like '" + email + "' and Id_Serie = " + id;
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
                    else
                    {
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
    }
}
