using System;
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

            }

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
            }
        }
    }
}