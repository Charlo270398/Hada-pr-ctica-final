using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases.EN;
using System.Data.SqlClient;
using System.Configuration;



namespace CAD
{
    public class usuarioCAD : IusuarioCAD
    {
        List<usuarioEN> lista = new List<usuarioEN>();
        public void anyadirUsuario(usuarioEN user){

            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "insert into Usuarios values ('" + user.Email;
                comando += "', '" + user.Contrasenya + "','" + user.Nombre + "','" + user.Apellidos + "','" + user.FechaA + "','" + user.Pais + "')";
                SqlCommand cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }catch(Exception e)
            {


            }

        }
        public void borrarUsuario(usuarioEN user) {}
        public usuarioEN mostrarUsuario(string email){ return null; }
        public void modificarUsuario(usuarioEN user) {}
        public bool existe(usuarioEN user) { return false; }

        public List<usuarioEN> listaUsuarios()
        {
            usuarioEN user = new usuarioEN();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "select * from Usuarios";
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user.Email = reader["Email"].ToString();
                user.Contrasenya = reader["Contrasenya"].ToString();
                user.Nombre = reader["Nombre"].ToString();
                user.Apellidos = reader["Apellidos"].ToString();
                user.FechaA = reader["Fecha_Alta"].ToString();
                user.Pais = (int)reader["Pais"];

                lista.Add(user);
            }
            reader.Close();
            cn.Close();

            return lista;
        }

    }
}
