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
        public void borrarActor(int id) { }
        public actorEN mostrarActor(int id) { return null; }
        public void modificarActor(actorEN actor) { }
        public bool existe(actorEN actor) { return false; }
    }
}
