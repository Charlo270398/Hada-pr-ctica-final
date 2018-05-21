using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;


namespace WebVideo
{
    public partial class Inicio : System.Web.UI.Page
    {
        List<peliculaEN> lista = new List<peliculaEN>();
        Random rnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
        int lastRand = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                peliculaEN p = new peliculaEN();
                lista = p.mostrarListaTodasPeliculas();
                lastRand = rnd.Next(0, lista.Count);
                p = lista[lastRand];
                Titulo.Text = p.NombreP;
                Imagen.ImageUrl = p.Imagen;
                HyperLink.NavigateUrl = "Mostrar/Mostrar_Peliculas.aspx?id=" + p.IdP.ToString();
            }
            catch (Exception ex)
            {
                Response.Redirect("Pagina_Error.aspx?err=" + ex.Message);
            }
        }

        protected void Imagen_Init(object sender, EventArgs e)
        {
            
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {

            peliculaEN peli = new peliculaEN();
            lastRand = rnd.Next(0, lista.Count);
            peli = lista[lastRand];
            

            Titulo.Text = peli.NombreP;
            Imagen.ImageUrl = peli.Imagen;
            HyperLink.NavigateUrl = "Mostrar/Mostrar_Peliculas.aspx?id=" + peli.IdP.ToString();
        }
    }
}