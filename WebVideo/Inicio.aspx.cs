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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Imagen_Init(object sender, EventArgs e)
        {
            try
            {
                peliculaEN p = new peliculaEN();
                p = p.peliculaMasNueva();
                Titulo.Text = p.NombreP;
                Imagen.ImageUrl = p.Imagen;
                HyperLink.NavigateUrl = "Mostrar/Mostrar_Peliculas.aspx?id=" + p.IdP.ToString();
            }
            catch (Exception ex)
            {
                Response.Redirect("Pagina_Error.aspx?err=" + ex.Message);
            }
        }
    }
}