using System;
using System.Collections.Generic;
using System.Text;
using Clases.EN;
using System.Data.SqlClient;
using System.Configuration;
using CAD;

namespace Clases.CAD
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
            directorEN dir = new directorEN();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "";
            if(director.Nombre == "%")
            {
                comando = "select * from Director";
            }
            else
            {
                comando = "select * from Director where Nombre like '%" + director.Nombre + "%'";
            }
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dir.IdD = (int)reader["Id_Director"];
                dir.Nombre = reader["Nombre"].ToString();
                dir.Apellidos = reader["Apellidos"].ToString();
                dir.Nacionalidad = pais.mostrarPais((int)reader["Fecha_Alta"]).Pais;
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
            directorEN dir = new directorEN();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "";
            comando = "select * from Director where Nombre like '" + director.Nombre + "'";
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dir.IdD = (int)reader["Id_Director"];
                dir.Nombre = reader["Nombre"].ToString();
                dir.Apellidos = reader["Apellidos"].ToString();
                dir.Nacionalidad = pais.mostrarPais((int)reader["Fecha_Alta"]).Pais;
            }
            reader.Close();
            cn.Close();

            return dir;
        }
        public void modificarDirector(directorEN director) { }
        public bool existe(directorEN director) { return false; }
    }
}
