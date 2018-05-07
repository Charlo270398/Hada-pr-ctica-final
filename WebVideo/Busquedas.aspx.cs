using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

        

        protected void Btn_Serie(object sender, EventArgs e)
        {

        }

        protected void Btn_Pelicula(object sender, EventArgs e)
        {
            Response.Redirect("Peliculas/Mostrar_Peliculas.aspx?id=" + PeliculaBox.Text);
        }
    }
}