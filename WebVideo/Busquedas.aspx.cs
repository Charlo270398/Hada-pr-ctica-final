﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAD;
using Clases.EN;

namespace WebVideo
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Btn_PeliculaC(object sender, EventArgs e)
        {
            if (PeliculaBox.Text != "")
            {
                peliculaCAD pelicula = new peliculaCAD();
                peliculaEN nombre = new peliculaEN(PeliculaBox.Text);
                List<string> ListaNombres = new List<string>();
                DWPeliculas.Visible = true;
                Btn_Pelicula2.Visible = true;
                for (int i = 0; i < pelicula.mostrarListaPeliculas(nombre).Count; i++)
                {
                    ListaNombres.Add(pelicula.mostrarListaPeliculas(nombre)[i].NombreP);
                }
                DWPeliculas.DataSource = ListaNombres;
                DWPeliculas.DataBind();
                DWPeliculas.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
                if (DWPeliculas.Items.Count == 1)
                {
                    ErrPelicula.Visible = true;
                    ErrPelicula.Text = "*Búsqueda vacía. Introduzca el carácter '%' para ver todos los títulos";
                }
                else
                {
                    ErrPelicula.Visible = false;
                }
            }
            else{
                ErrPelicula.Visible = true;
                ErrPelicula.Text = "*Campo vacío";
            }

            ErrSerie.Visible = false;
            ErrDirector.Visible = false;
            ErrSerie.Visible = false;
            DWActor.Visible = false;
            DWDirector.Visible = false;
            DWSeries.Visible = false;
            Btn_Actor2.Visible = false;
            Btn_Director2.Visible = false;
            Btn_Serie2.Visible = false;
        }

        protected void Btn_SerieC(object sender, EventArgs e)
        {

        }

        protected void Btn_Pelicula2C(object sender, EventArgs e)
        {
            if (DWPeliculas.SelectedItem.ToString() != "[Seleccionar]")
            {
                Response.Redirect("Peliculas/Mostrar_Peliculas.aspx?id=" + DWPeliculas.SelectedItem.ToString());
            }
            else
            {
                ErrPelicula.Visible = true;
                ErrPelicula.Text = "*Seleccione una película";
            }
        }

        protected void Btn_DirectorC(object sender, EventArgs e)
        {
            if (DirectorBox.Text != "")
            {
                directorCAD pelicula = new directorCAD();
                directorEN nombre = new directorEN(DirectorBox.Text);
                List<string> ListaNombres = new List<string>();
                DWDirector.Visible = true;
                Btn_Director2.Visible = true;
                for (int i = 0; i < pelicula.mostrarListaDirectores(nombre).Count; i++)
                {
                    ListaNombres.Add(pelicula.mostrarListaDirectores(nombre)[i].Nombre + " " + pelicula.mostrarListaDirectores(nombre)[i].Apellidos);
                }
                DWDirector.DataSource = ListaNombres.Distinct().ToList();
                DWDirector.DataBind();
                DWDirector.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            }
        }

        protected void Btn_Serie2C(object sender, EventArgs e)
        {

        }

        protected void Btn_Actor2C(object sender, EventArgs e)
        {

        }

        protected void Btn_Director2C(object sender, EventArgs e)
        {
            if (DWDirector.SelectedItem.ToString() != "[Seleccionar]")
            {
                Response.Redirect("Mostrar/Mostrar_Director.aspx?id=" + DWDirector.SelectedItem.ToString());
            }
            else
            {
                ErrDirector.Visible = true;
            }
        }
    }
}