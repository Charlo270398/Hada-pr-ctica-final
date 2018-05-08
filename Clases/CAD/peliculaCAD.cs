using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases.EN;
using System.Data.SqlClient;
using System.Configuration;

namespace CAD
{
    public class peliculaCAD : IpeliculaCAD
    {
        public peliculaCAD()
        {

        }
       
        public void anyadirPelicula(peliculaEN id) { }
        public void borrarPelicula(peliculaEN id) { }
        public List<peliculaEN> mostrarListaPeliculas(peliculaEN pelicula) {

            peliculaEN aux = new peliculaEN();
            List<peliculaEN> devolver = new List<peliculaEN>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "";
            if (pelicula.NombreP == "%")
            {
                comando = "select * from Peliculas";
            }
            else
            {
                comando = "select * from Peliculas where Nombre like '%" + pelicula.NombreP + "%'";
            }
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                aux.IdP = (int)reader["Id_Pelicula"];
                aux.NombreP = reader["Nombre"].ToString();
                aux.Duracion = (int)reader["Duracion"];
                aux.FechaE = reader["Fecha_Estreno"].ToString();
                aux.Sinopsis = reader["Sinopsis"].ToString();
                aux.PrecioA = (float)reader["Precio_A"];
                aux.PrecioC = (float)reader["Precio_C"];
                aux.IdDist = (int)reader["Id_Distribuidora"];
                aux.IdDist = (int)reader["Id_Director"];
                aux.Imagen = reader["Imagen"].ToString();
                aux.Trailer = reader["Trailer"].ToString();
                if (reader["Id_Saga"] != null)
                {
                    
                }
                else
                {
                    aux.IdSaga = -1;
                }
                
                devolver.Add(aux);

            }
            reader.Close();
            cn.Close();

            return devolver;
        }
        public peliculaEN mostrarPelicula(peliculaEN pelicula)
        {

            peliculaEN aux = new peliculaEN();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "select * from Peliculas where Nombre like '" + pelicula.NombreP + "'";
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                aux.IdP = (int)reader["Id_Pelicula"];
                aux.NombreP = reader["Nombre"].ToString();
                aux.Duracion = (int)reader["Duracion"];
                aux.FechaE = reader["Fecha_Estreno"].ToString();
                aux.Sinopsis = reader["Sinopsis"].ToString();
                aux.PrecioA = (float)reader["Precio_A"];
                aux.PrecioC = (float)reader["Precio_C"];
                aux.IdDist = (int)reader["Id_Distribuidora"];
                aux.IdDist = (int)reader["Id_Director"];
                aux.Imagen = reader["Imagen"].ToString();
                aux.Trailer = reader["Trailer"].ToString();
                if (reader["Id_Saga"] != null)
                {

                }
                else
                {
                    aux.IdSaga = -1;
                }
            }
            reader.Close();
            cn.Close();

            return aux;
        }

        public void modificarPelicula(peliculaEN id) { }
        public bool existe(peliculaEN id) { return false; }

    }
}
