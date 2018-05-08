using System;
using System.Collections.Generic;
using System.Text;
using Clases.EN;
using System.Data.SqlClient;
using System.Configuration;
using CAD;

namespace CAD
{
    public class directorCAD : IdirectorCAD
    {
        public directorCAD()
        {

        }
        public List<directorEN> mostrarListaDirectores(directorEN director)
        {
            paisCAD pais = new paisCAD();
            List<directorEN> lista = new List<directorEN>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "";
            if(director.Nombre == "%")
            {
                comando = "select * from Director";
            }
            else
            {
                comando = "select distinct * from Director where Nombre like '%" + director.Nombre + "%' or Apellidos like '%" + director.Nombre + "%'";
            }
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                directorEN dir = new directorEN();
                dir.IdD = (int)reader["Id_Director"];
                dir.Nombre = reader["Nombre"].ToString();
                dir.Apellidos = reader["Apellidos"].ToString();
                dir.Nacionalidad = pais.mostrarPais((int)reader["Nacionalidad"]).Pais;
                lista.Add(dir);
            }
            reader.Close();
            cn.Close();

            return lista;
        }
        public void anyadirDirector(directorEN director) { }
        public void borrarDirector(directorEN director) { }
        public directorEN mostrarDirector(directorEN director) {

            paisCAD pais = new paisCAD();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            directorEN dir = new directorEN(); 
            string comando = "";
            comando = "select distinct * from Director where Nombre like '%" + director.Nombre + "%' or Apellidos like '%" + director.Apellidos + "%'";
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dir = new directorEN();
                dir.IdD = (int)reader["Id_Director"];
                dir.Nombre = reader["Nombre"].ToString();
                dir.Apellidos = reader["Apellidos"].ToString();
                dir.Nacionalidad = pais.mostrarPais((int)reader["Nacionalidad"]).Pais;
            }
            reader.Close();
            cn.Close();

            return dir;
        }
        public void modificarDirector(directorEN director) { }
        public bool existe(directorEN director) { return false; }
    }
}
