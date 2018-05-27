using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;

namespace WebVideo.Mostrar
{
    public partial class Mostrar_Distribuidora : System.Web.UI.Page
    {
        distribuidoraEN distribuidora = new distribuidoraEN();
        List<int> listaID = new List<int>();//Lista Id asociadas
        protected void Page_Load(object sender, EventArgs e)
        {
            Application.Lock();
            Application["PageRequestCount"] =
                ((int)Application["PageRequestCount"]) + 1;
            Application.UnLock();
        }

        protected void Nombre_Init(object sender, EventArgs e)
        {
            try
            {
                int id;
                int.TryParse(Request.QueryString["id"], out id);//Recuperamos el id de la dist.
                distribuidora = new distribuidoraEN(id,"");//Cargamos el id de la dist.

                distribuidora = distribuidora.mostrarDistribuidora();//Cargamos la distribuidora
                NombreText.Text = distribuidora.Nombre;

                List<string> listaNombres = new List<string>();
                List<peliculaEN> listaP = distribuidora.listaPeliculasDistribuidora();//Cargamos las peliculas de la dist.
                for (int i = 0; i < listaP.Count; i++)
                {
                    listaNombres.Add(listaP[i].NombreP);
                    listaID.Add(listaP[i].IdP);//Asociamos id a nombre en la lista
                }
                DWPeliculas.DataSource = listaNombres;
                DWPeliculas.DataBind();
                DWPeliculas.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            }catch(Exception ex)
            {
                Response.Redirect("../Pagina_Error.aspx?err=" + ex.Message);
            }

        }

        protected void Btn_PeliculaC(object sender, EventArgs e)
        {
            try
            {
                if (DWPeliculas.SelectedItem.ToString() != "[Seleccionar]")
                {
                    Response.Redirect("Mostrar_Peliculas.aspx?id=" + listaID[DWPeliculas.SelectedIndex - 1], false);//Ponemos false porque si no hay excepción
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
    }
}