using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.EN;
using System.Data.SqlClient;
using System.Configuration;

namespace CAD
{
    public class sagaCAD : IsagaCAD
    {
        public void anyadirSaga(sagaEN saga)
        {
            try
            {
                int nextId = 1;
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "";
                SqlCommand cmd;
                comando = "insert into Saga values (" + nextId + ", '";
                comando += saga.Descripcion + "', '" + saga.Nombre + "')";
                cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception)
            {
                try
                {
                    int nextId = 1;
                    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                    cn.Open();
                    string comando = "select max(Id_Saga) max from Saga";
                    SqlCommand cmd = new SqlCommand(comando, cn);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nextId = (int)reader["max"] + 1;
                    }
                    reader.Close();
                    comando = "insert into Saga values (" + nextId + ", '";
                    comando += saga.Descripcion + "', '" + saga.Nombre + "')";
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

        public void borrarSaga(int id)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "delete from Saga where Id_Saga = " + id;
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

        public bool existe(sagaEN saga)
        {
            return false;
        }

        public List<sagaEN> listaSagas()
        {
            List<sagaEN> dev = new List<sagaEN>();
            sagaEN saga;
            string comando = "Select * from Saga order by Nombre";
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                saga = new sagaEN();
                saga.IDsaga = (int)reader["Id_Saga"];
                saga.Descripcion = reader["Descripcion"].ToString();
                saga.Nombre = reader["Nombre"].ToString();
                dev.Add(saga);
            }
            reader.Close();
            cn.Close();
            return dev;
        }

        public void modificarSaga(sagaEN saga)
        {

        }

        public sagaEN mostrarSaga(int id)
        {
            sagaEN saga = new sagaEN();
            string comando = "Select * from Saga where Id_Saga =" + id;
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {          
                saga.IDsaga = (int)reader["Id_Saga"];
                saga.Descripcion = reader["Descripcion"].ToString();
                saga.Nombre = reader["Nombre"].ToString();
            }
            reader.Close();
            cn.Close();
            return saga;
        }
    }
}
