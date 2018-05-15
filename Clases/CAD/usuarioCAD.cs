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
                DateTime fecha = DateTime.Now;
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "insert into Usuarios values ('" + user.Email;
                comando += "', '" + user.Contrasenya + "','" + user.Nombre + "','" + user.Apellidos + "','" + fecha + "','" + user.Pais + "', " + 0 + ")";
                SqlCommand cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }catch(Exception ex)
            { //*Email repetido. Introduzca otro.
                throw new Exception(ex.Message);
            }

        }
        public void borrarUsuario(usuarioEN user) {

            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "delete from Usuarios  where Email = '" + user.Email + "'";
                SqlCommand cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public usuarioEN mostrarUsuario(string email){

            usuarioEN user = new usuarioEN();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "select * from Usuarios where Email like '" + email + "'";
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
                if ((bool)reader["Administrador"])
                {
                    user.AdMin = true;
                }
                else
                {
                    user.AdMin = false;
                }

            }
            reader.Close();
            cn.Close();

            return user;
        }
        public bool existe(usuarioEN user) {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            int numero = 0;
            string comando = "select count(*) numero from Usuarios where Email like '" + user.Email + "'";
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                numero = (int)reader["numero"];

            }
            reader.Close();
            cn.Close();

            if(numero == 1)
            {
                return true;
            }
            else{
                return false;
            }
        }

        public List<usuarioEN> listaUsuarios()
        {
            try
            {
                usuarioEN user = new usuarioEN();
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "select * from Usuarios";
                SqlCommand cmd = new SqlCommand(comando, cn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user = new usuarioEN();
                    user.Email = reader["Email"].ToString();
                    user.Contrasenya = reader["Contrasenya"].ToString();
                    user.Nombre = reader["Nombre"].ToString();
                    user.Apellidos = reader["Apellidos"].ToString();
                    user.FechaA = reader["Fecha_Alta"].ToString();
                    user.Pais = (int)reader["Pais"];
                    if ((bool)reader["Administrador"])
                    {
                        user.AdMin = true;
                    }
                    else
                    {
                        user.AdMin = false;
                    }

                    lista.Add(user);
                }
                reader.Close();
                cn.Close();

                return lista;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void hacerAdmin(string email)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "update Usuarios set Administrador = "+ 1 + "where Email = '" + email + "'";
                SqlCommand cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void modificarDatos(usuarioEN user)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "update Usuarios set Nombre = '" + user.Nombre + "' ,Apellidos = '" + user.Apellidos + "', Pais = " + user.Pais +  " where Email = '" + user.Email + "'";
                SqlCommand cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void modificarContraseña(usuarioEN user)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "update Usuarios set Contrasenya = '" + user.Contrasenya + "' where Email = '" + user.Email + "'";
                SqlCommand cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<transaccionPeliculaEN> listaTransaccionesP(string email)
        {
            try
            {
                transaccionPeliculaEN trans = new transaccionPeliculaEN();
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "select * from TransaccionC where Email like " + email;
                SqlCommand cmd = new SqlCommand(comando, cn);
                var reader = cmd.ExecuteReader();
                List<transaccionPeliculaEN> lista = new List<transaccionPeliculaEN>();
                while (reader.Read())
                {
                    trans = new transaccionPeliculaEN();
                    trans.Email = reader["Email"].ToString();
                    trans.IdP = (int)reader["Id_Pelicula"];
                    trans.FechaC = reader["Fecha_Compra"].ToString();
                    trans.Alquiler = (bool)reader["Alquiler"];
                    if (trans.Alquiler)
                    {
                        trans.FechaF = reader["Fecha_Devolucion"].ToString(); ;
                    }
                    else
                    {
                        trans.FechaF = null;
                    }

                    lista.Add(trans);
                }
                reader.Close();
                cn.Close();

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
