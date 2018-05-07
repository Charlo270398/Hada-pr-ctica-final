using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Clases.EN;
using System.Data.SqlClient;



namespace CAD
{
    public class paisCAD
    {
        public paisCAD()
        {

        }


        public paisEN mostrarPais(int id) {

            paisEN devolver = new paisEN();
            
            devolver.IdPais = id;
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "select Pais from Paises where Id_pais = " + id.ToString();
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                 devolver.Pais = (reader["Pais"].ToString());
            }
            reader.Close();
            cn.Close();
      
            return devolver;

         }
        public paisEN mostrarIdPais(string nombre)
        {

            paisEN devolver = new paisEN();

            devolver.Pais = nombre;
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "select Id_pais from Paises where Pais = '" + nombre + "'";
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                devolver.IdPais = (int)(reader["Id_pais"]);
            }
            reader.Close();
            cn.Close();

            return devolver;

        }
        public List <paisEN> mostrarListaPaises()
        {
            List<paisEN> devolver = new List<paisEN>();
            paisEN pais = new paisEN();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "select * from Paises";
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                pais.IdPais = (int)reader["Id_pais"];
                pais.Pais = (reader["Pais"].ToString());
                devolver.Add(pais);
            }
            reader.Close();
            cn.Close();

            return devolver;

        }
    }
}
