﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAD;
using Clases.EN;

namespace WebVideo.Peliculas
{
    public partial class Mostrar_Peliculas : System.Web.UI.Page
    {

        peliculaCAD p = new peliculaCAD();
        peliculaEN pelicula = new peliculaEN();
     
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void imagePelicula1_Click(object sender, ImageClickEventArgs e)
        {

        }
        protected void imagePelicula1_Init(object sender, EventArgs e)
        {
            directorCAD d = new directorCAD();
            DistribuidoraCAD dis = new DistribuidoraCAD();
            int id;
            int.TryParse(Request.QueryString["id"], out id);
            pelicula = new peliculaEN(id, "");
            pelicula = p.mostrarPelicula(pelicula);
            Titulo.Text = pelicula.NombreP;
            Texto_Sinopsis.Text = pelicula.Sinopsis;
            Imagen.ImageUrl = pelicula.Imagen;
            float precio = pelicula.PrecioA / 100;
            precioAnumtext.Text = precio.ToString() + "€";
            fechaEstrenotext.Text = pelicula.FechaE.Substring(0, 10);
            precio = pelicula.PrecioC / 100;
            precioCnumtext.Text = precio.ToString() + "€";
            TrailerLink.NavigateUrl = pelicula.Trailer;
            duracionNumtext.Text = pelicula.Duracion.ToString() + " min";
            directorEN director = new directorEN(pelicula.IdDir);
            mostrarDirText.Text =  d.mostrarDirector(director).Nombre + " " + d.mostrarDirector(director).Apellidos;
            mostrarDirText.NavigateUrl = "Mostrar_Director.aspx?id=" + pelicula.IdDir;
            mostrarDistText.Text =  dis.mostrarDistribuidora(pelicula.IdDist).Nombre;
            mostrarDistText.NavigateUrl = "Mostrar_Distribuidora.aspx?id=" + pelicula.IdDist;
            if (pelicula.IdSaga != -1)
            {
                sagaCAD s = new sagaCAD();
                mostrarSaga.Visible = true;
                SagaText.Visible = true;
                mostrarSaga.Text = s.mostrarSaga(pelicula.IdSaga).Nombre;
            }

        }
    }
}