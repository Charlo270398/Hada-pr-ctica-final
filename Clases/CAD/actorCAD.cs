using System;
using System.Collections.Generic;
using System.Text;
using Clases.EN;
using System.Data.SqlClient;
using System.Configuration;

namespace CAD
{
    public class actorCAD : IactorCAD
    {
        public actorCAD()
        {

        }
        public void anyadirActor(actorEN actor) {

            DateTime fecha = DateTime.Parse(actor.FechaNac);
            try
            {

                paisCAD p = new paisCAD();
                int nextId = 1;
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "";
                SqlCommand cmd;
                comando = "insert into Actores values (" + nextId + ", '";
                comando += actor.Nombre + "', '" + actor.Apellidos + "', '";
                comando += fecha + "', ";
                comando += p.mostrarIdPais(actor.Pais).IdPais + ")";
                cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception)
            {
                try
                {
                    paisCAD p = new paisCAD();
                    int nextId = 1;
                    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                    cn.Open();
                    string comando = "select max(Id_Actor) max from Actores";
                    SqlCommand cmd = new SqlCommand(comando, cn);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nextId = (int)reader["max"] + 1;
                    }
                    reader.Close();
                    comando = "insert into Actores values (" + nextId + ", '";
                    comando += actor.Nombre + "', '" + actor.Apellidos + "', '";
                    comando += fecha + "', ";
                    comando += p.mostrarIdPais(actor.Pais).IdPais + ")";
                    cmd = new SqlCommand(comando, cn);
                    cmd.ExecuteNonQuery();

                    cn.Close();
                }catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public void borrarActor(int id) {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "delete from Actores where Id_Actor = " + id;
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
        public actorEN mostrarActor(int id) {
            paisCAD pais = new paisCAD();
            actorEN act = new actorEN();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "";
            comando = "select * from Actores where Id_Actor = " + id;

            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
                act.IdAc = (int)reader["Id_Actor"];
                act.Nombre = reader["Nombre"].ToString();
                act.Apellidos = reader["Apellidos"].ToString();
                act.FechaNac = reader["Fecha_Nac"].ToString();
                act.Pais = pais.mostrarPais((int)reader["Nacionalidad"]).Pais;
            }
            reader.Close();
            cn.Close();

            return act;
        }
        public void modificarActor(actorEN actor) {
            paisCAD p = new paisCAD();
            DateTime fecha = DateTime.Parse(actor.FechaNac);
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "update Actores set Nombre = '" + actor.Nombre + "', ";
                comando += "Apellidos = '" + actor.Apellidos + "', Fecha_Nac = '"+ fecha + "', ";
                comando += "Nacionalidad= " + p.mostrarIdPais(actor.Pais).IdPais + " where Id_Actor = " + actor.IdAc;
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
        public bool existe(actorEN actor) { return false; }

        public List<actorEN> mostrarListaActores(actorEN actor)
        {
            paisCAD pais = new paisCAD();
            List<actorEN> lista = new List<actorEN>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "";
            if (actor.Nombre == "%")
            {
                comando = "select * from Actores";
            }
            else
            {
                comando = "select distinct * from Actores where Nombre like '%" + actor.Nombre + "%' or Apellidos like '%" + actor.Nombre + "%'";
            }
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                actorEN act = new actorEN();
                act.IdAc = (int)reader["Id_Actor"];
                act.Nombre = reader["Nombre"].ToString();
                act.Apellidos = reader["Apellidos"].ToString();
                act.FechaNac = reader["Fecha_Nac"].ToString();
                act.Pais = pais.mostrarPais((int)reader["Nacionalidad"]).Pais;
                lista.Add(act);
            }
            reader.Close();
            cn.Close();

            return lista;
        }

        public List<peliculaEN> peliculasActor(int id)
        {
            peliculaCAD p = new peliculaCAD();
            List<peliculaEN> lista = new List<peliculaEN>();
            List<int> IDs = new List<int>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "";

            comando = "select p.Id_Pelicula from Actores a, Peliculas p, Actuaciones ac where p.Id_Pelicula = ac.Id_Pelicula and a.Id_Actor = ac.Id_Actor";

            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                IDs.Add((int)reader["Id_Pelicula"]);
            }
            reader.Close();

            for(int i=0; i<IDs.Count; i++)
            {
                peliculaEN peli = new peliculaEN(IDs[i],"");
                lista.Add(p.mostrarPelicula(peli));
            }

            cn.Close();

            return lista;
        }

        public void insertarActuacion(int idAct, int idPel)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "insert into Actuaciones values("+ idPel + "," + idAct + ")";
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
    }
}
