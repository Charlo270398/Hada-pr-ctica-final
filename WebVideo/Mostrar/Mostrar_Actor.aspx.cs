using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAD;
using Clases.EN;

namespace WebVideo.Mostrar
{
    public partial class Mostrar_Actor : System.Web.UI.Page
    {
        actorEN actor = new actorEN();
        List<int> listaID = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Btn_PeliculaC(object sender, EventArgs e)
        {
            if (DWPeliculas.SelectedItem.ToString() != "[Seleccionar]")
            {
                Response.Redirect("Mostrar_Peliculas.aspx?id=" + listaID[DWPeliculas.SelectedIndex - 1]);
            }
            else
            {
                ErrPelicula.Visible = true;
                ErrPelicula.Text = "*Seleccione una película";
            }
        }

        protected void DWPeliculas_Init(object sender, EventArgs e)
        {
            try
            {
                int id;
                int.TryParse(Request.QueryString["id"], out id);
                actor.IdAc = id;
                actorCAD aux = new actorCAD();
                peliculaCAD paux = new peliculaCAD();
                actor = aux.mostrarActor(actor.IdAc);
                NombreText.Text = actor.Nombre;
                ApellidosText.Text = actor.Apellidos;
                fechaNac.Text = actor.FechaNac.Substring(0, 10);
                paisCAD p = new paisCAD();
                nombrePais.Text = p.mostrarIdPais(actor.Pais).Pais;

                List<peliculaEN> peliculas = aux.peliculasActor(actor.IdAc);
                List<string> nombres = new List<string>();
                for (int i = 0; i < peliculas.Count; i++)
                {
                    nombres.Add(peliculas[i].NombreP);
                    listaID.Add(peliculas[i].IdP);
                }
                DWPeliculas.DataSource = nombres;
                DWPeliculas.DataBind();
                DWPeliculas.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            }catch(Exception ex)
            {
                Response.Redirect("../Pagina_Error.aspx?err=" + ex.Message);
            }
        }
    }
}