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
    public partial class Mostrar_Distribuidora : System.Web.UI.Page
    {
        distribuidoraEN distribuidora = new distribuidoraEN();
        List<int> listaID = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Nombre_Init(object sender, EventArgs e)
        {
            try
            {
                int id;
                int.TryParse(Request.QueryString["id"], out id);
                distribuidora.IdDis = id;
                DistribuidoraCAD aux = new DistribuidoraCAD();
                peliculaCAD paux = new peliculaCAD();

                distribuidora = aux.mostrarDistribuidora(distribuidora.IdDis);

                NombreText.Text = distribuidora.Nombre;

                List<string> listaNombres = new List<string>();
                List<peliculaEN> listaP = paux.mostrarListaPeliculasDistribuidora(distribuidora.IdDis);
                for (int i = 0; i < listaP.Count; i++)
                {
                    listaNombres.Add(listaP[i].NombreP);
                    listaID.Add(listaP[i].IdP);
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
    }
}