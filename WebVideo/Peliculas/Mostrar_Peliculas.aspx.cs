using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void imagePelicula1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void TituloIndividual_Init(object sender, EventArgs e)
        {
            
            peliculaCAD peli = new peliculaCAD();
            peliculaEN p = new peliculaEN(Request.QueryString["id"]);
            Titulo.Text = peli.mostrarPeliculas(p)[0].Imagen;

        }

        protected void imagePelicula1_Init(object sender, EventArgs e)
        {
            peliculaCAD peli = new peliculaCAD();
            peliculaEN p = new peliculaEN(Request.QueryString["id"]);
            Imagen.ImageUrl = peli.mostrarPeliculas(p)[0].Imagen;

        }

        protected void precioAlquilerText0_Init(object sender, EventArgs e)
        {

        }

        protected void I_sinopsis(object sender, EventArgs e)
        {
            Sinopsis.Text = "A";
        }
    }
}