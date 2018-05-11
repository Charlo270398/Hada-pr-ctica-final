using System;
using System.Collections.Generic;
using System.Text;
using Clases.EN;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CAD
{
    public class DistribuidoraCAD : IdistribuidoraCAD
    {
        public DistribuidoraCAD()
        {

        }
        public void anyadirDistribuidora(distribuidoraEN distribuidora) {
            try
            {
                int nextId = 1;
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "select max(Id_Distribuidora) max from Distribuidora";
                SqlCommand cmd;
                comando = "insert into Distribuidora values (" + nextId + ", '";
                comando += distribuidora.Nombre + "')";
                cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception)
            {
                try
                {
                    int nextId = 1;
                    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                    cn.Open();
                    string comando = "select max(Id_Distribuidora) max from Distribuidora";
                    SqlCommand cmd = new SqlCommand(comando, cn);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nextId = (int)reader["max"] + 1;
                    }
                    reader.Close();

                    comando = "insert into Distribuidora values (" + nextId + ", '";
                    comando += distribuidora.Nombre + "')";
                    cmd = new SqlCommand(comando, cn);
                    cmd.ExecuteNonQuery();

                    cn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);

                }

            }
        }
        public void borrarDistribuidora(int id) {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "delete from Distribuidora where Id_Distribuidora = " + id;
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
        public distribuidoraEN mostrarDistribuidora(int id) {

            distribuidoraEN d = new distribuidoraEN();
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "select * from Distribuidora where Id_Distribuidora = " + id;
                SqlCommand cmd = new SqlCommand(comando, cn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    d.IdDis = (int)reader["Id_Distribuidora"];
                    d.Nombre = reader["Nombre"].ToString();
                }
                reader.Close();
                cn.Close();
            }
            catch (Exception)
            {

            }

            return d;
        }
        public void modificarDistribuidora(distribuidoraEN distribuidora) {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "update Distribuidora set ";
                comando += "Nombre = '" + distribuidora.Nombre + "' where Id_Distribuidora = " + distribuidora.IdDis;
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
        public bool existe(int id) { return false; }

        public List<distribuidoraEN> mostrarListaDistribuidora()
        {
            List<distribuidoraEN> lista = new List<distribuidoraEN>();
            distribuidoraEN d = new distribuidoraEN();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "select * from Distribuidora" + " Order by Nombre";
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                d = new distribuidoraEN();
                d.IdDis = (int)reader["Id_Distribuidora"];
                d.Nombre = reader["Nombre"].ToString();
                lista.Add(d);
            }
            reader.Close();
            cn.Close();

            return lista;
        }      
    }
}
