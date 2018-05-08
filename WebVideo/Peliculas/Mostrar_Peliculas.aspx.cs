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
            int id;
            int.TryParse(Request.QueryString["id"], out id);
            peliculaCAD peli = new peliculaCAD();
            peliculaEN p = new peliculaEN(id, "");
            Titulo.Text = peli.mostrarPelicula(p).NombreP;

        }

        protected void imagePelicula1_Init(object sender, EventArgs e)
        {
            int id;
            int.TryParse(Request.QueryString["id"], out id);
            peliculaCAD peli = new peliculaCAD();
            peliculaEN p = new peliculaEN(id, "");
            Imagen.ImageUrl = peli.mostrarPelicula(p).Imagen;

        }

        protected void precioAlquilerText0_Init(object sender, EventArgs e)
        {

        }

        protected void I_sinopsis(object sender, EventArgs e)
        {
            int id;
            int.TryParse(Request.QueryString["id"], out id);
            peliculaCAD peli = new peliculaCAD();
            peliculaEN p = new peliculaEN(id, "");
            Texto_Sinopsis.Text = peli.mostrarPelicula(p).Sinopsis;
        }

        protected void precioAnumtext_Init(object sender, EventArgs e)
        {
            int id;
            int.TryParse(Request.QueryString["id"], out id);
            peliculaCAD peli = new peliculaCAD();
            peliculaEN p = new peliculaEN(id, "");
            precioAnumtext.Text = peli.mostrarPelicula(p).PrecioA.ToString() + "€";
        }

        protected void fechaEstrenotext_Init(object sender, EventArgs e)
        {
            int id;
            int.TryParse(Request.QueryString["id"], out id);
            peliculaCAD peli = new peliculaCAD();
            peliculaEN p = new peliculaEN(id, "");
            fechaEstrenotext.Text = peli.mostrarPelicula(p).FechaE;

        }

        protected void precioCnumtext_Init(object sender, EventArgs e)
        {
            int id;
            int.TryParse(Request.QueryString["id"], out id);
            peliculaCAD peli = new peliculaCAD();
            peliculaEN p = new peliculaEN(id, "");
            precioCnumtext.Text = peli.mostrarPelicula(p).PrecioC.ToString() + "€";
        }

        protected void cargaTrailer(object sender, EventArgs e)
        {
            int id;
            int.TryParse(Request.QueryString["id"], out id);
            peliculaCAD peli = new peliculaCAD();
            peliculaEN p = new peliculaEN(id, "");
            TrailerLink.NavigateUrl = peli.mostrarPelicula(p).Trailer;
       
        }

        protected void duraciontext_Init(object sender, EventArgs e)
        {
            int id;
            int.TryParse(Request.QueryString["id"], out id);
            peliculaCAD peli = new peliculaCAD();
            peliculaEN p = new peliculaEN(id, "");
            duracionNumtext.Text = peli.mostrarPelicula(p).Duracion.ToString() + " min";
        }
    }
}