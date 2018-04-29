using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebVideo.Peliculas
{
    public partial class Peliculas_index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImagePelicula1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Peliculas_index.aspx");
        }
        protected void imageSerie2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Peliculas_index.aspx");
        }
        protected void ImagePelicula3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Peliculas_individual.aspx");
        }
    }
}