using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;

namespace WebVideo.Mostrar
{
    public partial class Mostrar_Actor : System.Web.UI.Page
    {
        actorEN actor = new actorEN();//Actor a mostrar
        List<int> listaID = new List<int>();//Lista con id asociados para peliculas
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Btn_PeliculaC(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Response.Redirect("../Pagina_Error.aspx?err=" + ex.Message);
            }
        }

        protected void DWPeliculas_Init(object sender, EventArgs e)
        {
            try
            {
                int id;
                int.TryParse(Request.QueryString["id"], out id);//Recuperamos id del actor
                actor = new actorEN(id,"");//Cargamos id del actor en el EN
                actor = actor.mostrarActor();//Cargamos los datos del actor
                NombreText.Text = actor.Nombre;
                ApellidosText.Text = actor.Apellidos;
                fechaNac.Text = actor.FechaNac.Substring(0, 10);
                paisEN p = new paisEN(actor.Pais);
                nombrePais.Text = p.mostrarIdPais().Pais;

                List<peliculaEN> peliculas = actor.mostrarPeliculasActor();
                List<string> nombres = new List<string>();
                for (int i = 0; i < peliculas.Count; i++)//Guardamos nombres en la lista desplegable
                {
                    nombres.Add(peliculas[i].NombreP);
                    listaID.Add(peliculas[i].IdP);//Asociamos id a cada nombre de la lista
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