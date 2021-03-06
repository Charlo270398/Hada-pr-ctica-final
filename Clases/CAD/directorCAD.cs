﻿using System;
using System.Collections.Generic;
using System.Text;
using Clases.EN;
using System.Data.SqlClient;
using System.Configuration;
using CAD;

namespace CAD
{
    public class directorCAD : IdirectorCAD
    {
        public directorCAD()
        {

        }
        public List<directorEN> mostrarListaDirectores(directorEN director)
        {
            paisCAD pais = new paisCAD();
            List<directorEN> lista = new List<directorEN>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
            cn.Open();
            string comando = "";
            if(director.Nombre == "%")
            {
                comando = "select * from Director" + " Order by Apellidos, Nombre";
            }
            else
            {
                comando = "select distinct * from Director where Nombre like '%" + director.Nombre + "%' or Apellidos like '%" + director.Nombre + "%'" + " Order by Apellidos, Nombre";
            }
            SqlCommand cmd = new SqlCommand(comando, cn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                directorEN dir = new directorEN();
                dir.IdD = (int)reader["Id_Director"];
                dir.Nombre = reader["Nombre"].ToString();
                dir.Apellidos = reader["Apellidos"].ToString();
                dir.Nacionalidad = pais.mostrarPais((int)reader["Nacionalidad"]).Pais;
                lista.Add(dir);
            }
            reader.Close();
            cn.Close();

            return lista;
        }
        public void anyadirDirector(directorEN director) {

            try
            {
                paisCAD p = new paisCAD();
                int nextId = 1;
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "";
                SqlCommand cmd;
                comando = "insert into Director values (" + nextId + ", '";
                comando += director.Nombre + "', '" + director.Apellidos + "', ";
                comando += p.mostrarIdPais(director.Nacionalidad).IdPais + ")";
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
                    string comando = "select max(Id_Director) max from Director";
                    SqlCommand cmd = new SqlCommand(comando, cn);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nextId = (int)reader["max"] + 1;
                    }
                    reader.Close();
                    comando = "insert into Director values (" + nextId + ", '";
                    comando += director.Nombre + "', '" + director.Apellidos + "', ";
                    comando += p.mostrarIdPais(director.Nacionalidad).IdPais + ")";
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
        public void borrarDirector(int id) {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "delete from Director where Id_Director = " + id;
                SqlCommand cmd = new SqlCommand(comando, cn);
                cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex){
                throw new Exception(ex.Message);
            }
        }
        public directorEN mostrarDirector(directorEN director) {

            directorEN dir = new directorEN();
            try
            {
                paisCAD pais = new paisCAD();
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();              
                string comando = "";
                if (director.IdD != -1)
                {
                    comando = "select distinct * from Director where Id_Director = " + director.IdD;
                }
                else
                {
                    comando = "select distinct * from Director where Nombre like '" + director.Nombre + "' and Apellidos like '" + director.Apellidos + "'" + " Order by Apellidos, Nombre";
                }
                SqlCommand cmd = new SqlCommand(comando, cn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dir = new directorEN();
                    dir.IdD = (int)reader["Id_Director"];
                    dir.Nombre = reader["Nombre"].ToString();
                    dir.Apellidos = reader["Apellidos"].ToString();
                    dir.Nacionalidad = pais.mostrarPais((int)reader["Nacionalidad"]).Pais;
                }
                reader.Close();
                cn.Close();
            }
            catch (Exception)
            {

            }

            return dir;
        }
        public void modificarDirector(directorEN director) {
            try
            {
                paisCAD p = new paisCAD();
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bbdd"].ToString());
                cn.Open();
                string comando = "update Director set Nombre = '" + director.Nombre + "', ";
                comando += "Apellidos = '" + director.Apellidos + "', ";
                comando += "Nacionalidad= " + p.mostrarIdPais(director.Nacionalidad).IdPais + " where Id_Director = " + director.IdD;
                SqlCommand cmd = new SqlCommand(comando, cn);
                cmd = new SqlCommand(comando, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }catch(Exception ex) {
                throw new Exception(ex.Message);
            }
        }
        public bool existe(directorEN director) {return false; }
    }
}
