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
        public actorEN mostrarActor(int id) { return null; }
        public void modificarActor(actorEN actor) { }
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
    }
}
