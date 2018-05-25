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
       
        public void anyadirPelicula(peliculaEN pelicula) {

            try
            {
                DateTime fecha = DateTime.Parse(pelicula.FechaE);
                paisCAD p = new paisCAD();
                int nextId = 1;
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "";
                SqlCommand cmd;
                comando = "insert into Peliculas values (" + nextId + ", '";
                comando += pelicula.NombreP + "', " + pelicula.Duracion + ", '";
                comando += fecha + "', '";
                comando += pelicula.Sinopsis + "', " + pelicula.PrecioC + ", " + pelicula.PrecioA + ", " + pelicula.IdDist + ", ";
                comando += pelicula.IdDir + ", '../images/peliculas_img/" + pelicula.Imagen + "', ";
                if(pelicula.IdSaga == -1)
                {
                    comando += "null" + ", '" + pelicula.Trailer + "')";
                }
                else
                {
                    comando += pelicula.IdSaga + ", '" + pelicula.Trailer + "')";
                }
                cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception)
            {
                try
                {
                    DateTime fecha = DateTime.Parse(pelicula.FechaE);
                    paisCAD p = new paisCAD();
                    int nextId = 1;
                    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                    cn.Open();
                    string comando = "select max(Id_Pelicula) max from Peliculas";
                    SqlCommand cmd = new SqlCommand(comando, cn);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nextId = (int)reader["max"] + 1;
                    }
                    reader.Close();
                    comando = "insert into Peliculas values (" + nextId + ", '";
                    comando += pelicula.NombreP + "', " + pelicula.Duracion + ", '";
                    comando += fecha + "', '";
                    comando += pelicula.Sinopsis + "', '" +  pelicula.PrecioC.ToString() + "', '" + pelicula.PrecioA.ToString() + "', " + pelicula.IdDist + ", ";
                    comando += pelicula.IdDir + ", '../images/peliculas_img/" + pelicula.Imagen + "', ";
                    if (pelicula.IdSaga == -1)
                    {
                        comando += "null" + ", '" + pelicula.Trailer + "')";
                    }
                    else
                    {
                        comando += pelicula.IdSaga + ", '" + pelicula.Trailer + "')";
                    }
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
        public void borrarPelicula(int id) {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "delete from Peliculas where Id_Pelicula = " + id;
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
        public List<peliculaEN> mostrarListaPeliculas(peliculaEN pelicula) {

            peliculaEN aux = new peliculaEN();
            List<peliculaEN> devolver = new List<peliculaEN>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "";
            if (pelicula.NombreP == "%")
            {
                comando = "select * from Peliculas order by Nombre";
            }
            else
            {
                comando = "select * from Peliculas where Nombre like '%" + pelicula.NombreP + "%' order by Nombre";
            }
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                aux = new peliculaEN();
                aux.IdP = (int)reader["Id_Pelicula"];
                aux.NombreP = reader["Nombre"].ToString();
                aux.Duracion = (int)reader["Duracion"];
                aux.FechaE = reader["Fecha_Estreno"].ToString();
                aux.Sinopsis = reader["Sinopsis"].ToString();
                aux.PrecioA = (int) reader["Precio_A"];
                aux.PrecioC = (int) reader["Precio_C"];
                aux.IdDist = (int)reader["Id_Distribuidora"];
                aux.IdDir = (int)reader["Id_Director"];
                aux.Imagen = reader["Imagen"].ToString();
                aux.Trailer = reader["Trailer"].ToString();
                if (reader.IsDBNull(10)) {
                    aux.IdSaga = -1;
                }
                else
                {
                    aux.IdSaga = (int)reader["Id_Saga"];
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
            string comando;
            if (pelicula.IdP != -1)
            {
                comando  = "select * from Peliculas where Id_Pelicula = " + pelicula.IdP;
            }
            else
            {
                comando = "select * from Peliculas where Nombre like '" + pelicula.NombreP + "'";
            }
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                aux = new peliculaEN();
                aux.IdP = (int)reader["Id_Pelicula"];
                aux.NombreP = reader["Nombre"].ToString();
                aux.Duracion = (int)reader["Duracion"];
                aux.FechaE = reader["Fecha_Estreno"].ToString();
                aux.Sinopsis = reader["Sinopsis"].ToString();
                aux.PrecioA = (int)reader["Precio_A"];
                aux.PrecioC = (int)reader["Precio_C"];
                aux.IdDist = (int)reader["Id_Distribuidora"];
                aux.IdDir = (int)reader["Id_Director"];
                aux.Imagen = reader["Imagen"].ToString();
                aux.Trailer = reader["Trailer"].ToString();
                if (reader.IsDBNull(10))
                {
                    aux.IdSaga = -1;
                }
                else
                {
                    aux.IdSaga = (int)reader["Id_Saga"];
                }
            }
            reader.Close();
            cn.Close();

            return aux;
        }

        public List<peliculaEN> mostrarListaPeliculasDirector(int idDir)
        {

            peliculaEN aux = new peliculaEN();
            List<peliculaEN> devolver = new List<peliculaEN>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "";
            comando = "select * from Peliculas where Id_Director = " +idDir;
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                aux = new peliculaEN();
                aux.IdP = (int)reader["Id_Pelicula"];
                aux.NombreP = reader["Nombre"].ToString();
                aux.Duracion = (int)reader["Duracion"];
                aux.FechaE = reader["Fecha_Estreno"].ToString();
                aux.Sinopsis = reader["Sinopsis"].ToString();
                aux.PrecioA = (int)reader["Precio_A"];
                aux.PrecioC = (int)reader["Precio_C"];
                aux.IdDist = (int)reader["Id_Distribuidora"];
                aux.IdDist = (int)reader["Id_Director"];
                aux.Imagen = reader["Imagen"].ToString();
                aux.Trailer = reader["Trailer"].ToString();
                if (reader.IsDBNull(10))
                {
                    aux.IdSaga = -1;
                }
                else
                {
                    aux.IdSaga = (int)reader["Id_Saga"];
                }

                devolver.Add(aux);

            }
            reader.Close();
            cn.Close();

            return devolver;
        }

        public void modificarPelicula(peliculaEN pelicula)
        {
            try
            {
                DateTime fecha = DateTime.Parse(pelicula.FechaE);
                paisCAD p = new paisCAD();
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "";
                SqlCommand cmd;
                comando = "update Peliculas set Id_Pelicula = " + pelicula.IdP + ", Nombre = '";
                comando += pelicula.NombreP + "', Duracion = " + pelicula.Duracion + ", Fecha_Estreno = '";
                comando += fecha + "', Sinopsis = '";
                comando += pelicula.Sinopsis + "', Precio_C = " + pelicula.PrecioC + ", Precio_A = " + pelicula.PrecioA + ", Id_Distribuidora = " + pelicula.IdDist + ",  Id_Director = ";
                comando += pelicula.IdDir + ", Imagen = '../images/peliculas_img/" + pelicula.Imagen + "', Id_Saga = ";
                if (pelicula.IdSaga == -1)
                {
                    comando += "null" + ", Trailer = '" + pelicula.Trailer + "'where Id_Pelicula = " + pelicula.IdP;
                }
                else
                {
                    comando += pelicula.IdSaga + ", Trailer = '" + pelicula.Trailer + "' where Id_Pelicula = " + pelicula.IdP;
                }
                cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool existe(peliculaEN id) { return false; }

        public List<peliculaEN> mostrarListaPeliculasDistribuidora(int idDist)
        {
            peliculaEN aux = new peliculaEN();
            List<peliculaEN> devolver = new List<peliculaEN>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "";
            comando = "select * from Peliculas where Id_Distribuidora = " + idDist;
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                aux = new peliculaEN();
                aux.IdP = (int)reader["Id_Pelicula"];
                aux.NombreP = reader["Nombre"].ToString();
                aux.Duracion = (int)reader["Duracion"];
                aux.FechaE = reader["Fecha_Estreno"].ToString();
                aux.Sinopsis = reader["Sinopsis"].ToString();
                aux.PrecioA = (int)reader["Precio_A"];
                aux.PrecioC = (int)reader["Precio_C"];
                aux.IdDist = (int)reader["Id_Distribuidora"];
                aux.IdDir = (int)reader["Id_Director"];
                aux.Imagen = reader["Imagen"].ToString();
                aux.Trailer = reader["Trailer"].ToString();
                if (reader.IsDBNull(10))
                {
                    aux.IdSaga = -1;
                }
                else
                {
                    aux.IdSaga = (int)reader["Id_Saga"];
                }

                devolver.Add(aux);

            }
            reader.Close();
            cn.Close();

            return devolver;
        }

        public peliculaEN mostrarPeliculaRandom()
        {
            peliculaEN aux = new peliculaEN();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando;

            comando = "select top 1 percent* from Peliculas order by newid()";
             
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                aux = new peliculaEN();
                aux.IdP = (int)reader["Id_Pelicula"];
                aux.NombreP = reader["Nombre"].ToString();
                aux.Duracion = (int)reader["Duracion"];
                aux.FechaE = reader["Fecha_Estreno"].ToString();
                aux.Sinopsis = reader["Sinopsis"].ToString();
                aux.PrecioA = (int)reader["Precio_A"];
                aux.PrecioC = (int)reader["Precio_C"];
                aux.IdDist = (int)reader["Id_Distribuidora"];
                aux.IdDir = (int)reader["Id_Director"];
                aux.Imagen = reader["Imagen"].ToString();
                aux.Trailer = reader["Trailer"].ToString();
                if (reader.IsDBNull(10))
                {
                    aux.IdSaga = -1;
                }
                else
                {
                    aux.IdSaga = (int)reader["Id_Saga"];
                }
            }
            reader.Close();
            cn.Close();

            return aux;
        }

        public int idPelicula(string nombre)
        {
            try
            {
                int aux = -1;
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando;

                comando = "select Id_Pelicula from Peliculas where Nombre like '" + nombre + "'";

                SqlCommand cmd = new SqlCommand(comando, cn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    aux = (int)reader["Id_Pelicula"];
                }
                reader.Close();
                cn.Close();

                return aux;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<peliculaEN> mostrarUltimosEstrenos()
        {
            peliculaEN aux = new peliculaEN();
            List<peliculaEN> devolver = new List<peliculaEN>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "";
            comando = "SELECT TOP 2 * FROM peliculas order by Fecha_Estreno desc";
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                aux = new peliculaEN();
                aux.IdP = (int)reader["Id_Pelicula"];
                aux.NombreP = reader["Nombre"].ToString();
                aux.Duracion = (int)reader["Duracion"];
                aux.FechaE = reader["Fecha_Estreno"].ToString();
                aux.Sinopsis = reader["Sinopsis"].ToString();
                aux.PrecioA = (int)reader["Precio_A"];
                aux.PrecioC = (int)reader["Precio_C"];
                aux.IdDist = (int)reader["Id_Distribuidora"];
                aux.IdDir = (int)reader["Id_Director"];
                aux.Imagen = reader["Imagen"].ToString();
                aux.Trailer = reader["Trailer"].ToString();
                if (reader.IsDBNull(10))
                {
                    aux.IdSaga = -1;
                }
                else
                {
                    aux.IdSaga = (int)reader["Id_Saga"];
                }

                devolver.Add(aux);

            }
            reader.Close();
            cn.Close();

            return devolver;
        }
    }
}
