﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases.EN;
using System.Data.SqlClient;
using System.Configuration;

namespace CAD
{
    public class serieCAD : IserieCAD
    {
        public serieCAD()
        {

        }

        public void anyadirSerie(serieEN serie)
        {
            try
            {
                string fecha = serie.FechaE;
                int nextId = 1;
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "";
                SqlCommand cmd;
                comando = "insert into Series values (" + nextId + ", '";
                comando += serie.Titulo + "', '";
                comando += fecha + "', '";
                comando += serie.Sinopsis + "', " + serie.PrecioC + ", " + serie.PrecioA + ", ";
                comando += " '../images/series_img/" + serie.Imagen + "')";
                cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception)
            {
                try
                {
                    string fecha = serie.FechaE;
                    int nextId = 1;
                    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                    cn.Open();
                    string comando = "select max(Id_Serie) max from Series";
                    SqlCommand cmd = new SqlCommand(comando, cn);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nextId = (int)reader["max"] + 1;
                    }
                    reader.Close();
                    comando = "insert into Series values (" + nextId + ", '";
                    comando += serie.Titulo + "', '";
                    comando += fecha + "', '";
                    comando += serie.Sinopsis + "', '" + serie.PrecioC + "', '" + serie.PrecioA + "', ";
                    comando += "'../images/series_img/" + serie.Imagen + "')";
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

        public serieEN mostrarSerie(serieEN serie)
        {
            serieEN aux = new serieEN();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando;
            if (serie.IdS != -1)
            {
                comando = "select * from Series where Id_Serie = " + serie.IdS;
            }
            else
            {
                comando = "select * from Series where Titulo like '" + serie.Titulo + "'";
            }
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                aux = new serieEN();
                aux.IdS = (int)reader["Id_Serie"];
                aux.Titulo = reader["Titulo"].ToString();
                aux.FechaE = reader["Fecha_Estreno"].ToString();
                aux.Sinopsis = reader["Sinopsis"].ToString();
                aux.PrecioA = (int)reader["Precio_A"];
                aux.PrecioC = (int)reader["Precio_C"];
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

        public List<serieEN> mostrarListaSeries(serieEN serie)
        {
            serieEN aux = new serieEN();
            List<serieEN> devolver = new List<serieEN>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "";
            if (serie.Titulo == "%")
            {
                comando = "select * from Series order by Titulo";
            }
            else
            {
                comando = "select * from Series where Titulo like '%" + serie.Titulo + "%' order by Titulo";
            }
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                aux = new serieEN();
                aux.IdS = (int)reader["Id_Serie"];
                aux.Titulo = reader["Titulo"].ToString();
                aux.FechaE = reader["Fecha_Estreno"].ToString();
                aux.Sinopsis = reader["Sinopsis"].ToString();
                aux.PrecioA = (int)reader["Precio_A"];
                aux.PrecioC = (int)reader["Precio_C"];
                aux.Imagen = reader["Imagen"].ToString();
                devolver.Add(aux);
            }
            reader.Close();
            cn.Close();

            return devolver;
        }

        public void borrarSerie(int id)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "delete from Series where Id_Serie = " + id;
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

        public void modificarSerie(serieEN serie)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "update Series set";
                comando += " Titulo = '" + serie.Titulo;
                comando += "', Fecha_Estreno = '" + serie.FechaE;
                comando += "', Sinopsis = '" + serie.Sinopsis;
                comando += "', Precio_C = " + serie.PrecioC;
                comando += ", Precio_A = " + serie.PrecioA;
                comando += ", Imagen = '" + serie.Imagen;
                comando += "' where Id_Serie = " + serie.IdS;
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

        public bool existe(serieEN serie)
        {
            throw new NotImplementedException();
        }
    }
}
