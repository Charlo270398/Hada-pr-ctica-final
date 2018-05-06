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


        public paisEN mostrarNombrePais(int id) {

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

    }
}
