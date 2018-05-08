using System;
using System.Collections.Generic;
using System.Text;
using Clases.EN;
using System.Data.SqlClient;
using System.Configuration;

namespace Clases.CAD
{
    public class serieCAD : IserieCAD
    {
        public serieCAD()
        {

        }
  
        public void anyadirSerie(serieEN serie)
        {
            throw new NotImplementedException();
        }

        public void borrarSerie(serieEN serie)
        {
            throw new NotImplementedException();
        }

        public serieEN mostrarSerie(serieEN serie)
        {
            serieEN aux = new serieEN();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "";
            comando = "select * from Series where Nombre like '" + serie.Titulo + "'";
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                aux = new serieEN();
                aux.IdS = (int)reader["Id_Serie"];
                aux.Titulo = reader["Titulo"].ToString();
                aux.FechaE = reader["Fecha_Estreno"].ToString();
                aux.PrecioA = (float)reader["Precio_A"];
                aux.PrecioC = (float)reader["Precio_C"];
                aux.Imagen = reader["Imagen"].ToString();

            }
            reader.Close();
            cn.Close();

            return aux;
        }

        public serieEN mostrarSerieId(int idSerie)
        {
            serieEN aux = new serieEN();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "";
            comando = "select * from Series where Id_Serie = " + idSerie;
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                aux = new serieEN();
                aux.IdS = (int)reader["Id_Serie"];
                aux.Titulo = reader["Titulo"].ToString();
                aux.FechaE = reader["Fecha_Estreno"].ToString();
                aux.PrecioA = (float)reader["Precio_A"];
                aux.PrecioC = (float)reader["Precio_C"];
                aux.Imagen = reader["Imagen"].ToString();

            }
            reader.Close();
            cn.Close();

            return aux;
        }

        public List<serieEN> mostrarListaSeries(string titulo)
        {
            serieEN aux = new serieEN();
            List<serieEN> devolver = new List<serieEN>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "";
            if (titulo == "%")
            {
                comando = "select * from Series";
            }
            else
            {
                comando = "select * from Series where Nombre like '%" + titulo + "%'";
            }
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                aux = new serieEN();
                aux.IdS = (int)reader["Id_Serie"];
                aux.Titulo = reader["Titulo"].ToString();
                aux.FechaE = reader["Fecha_Estreno"].ToString();
                aux.PrecioA = (float)reader["Precio_A"];
                aux.PrecioC = (float)reader["Precio_C"];
                aux.Imagen = reader["Imagen"].ToString();
                devolver.Add(aux);

            }
            reader.Close();
            cn.Close();

            return devolver;
        }

        public void modificarSerie(serieEN serie)
        {
            throw new NotImplementedException();
        }

        public bool existe(serieEN serie)
        {
            throw new NotImplementedException();
        }
    }
}
