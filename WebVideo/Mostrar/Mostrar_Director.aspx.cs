using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;

namespace WebVideo.Mostrar
{
    public partial class Mostrar_Director : System.Web.UI.Page
    {

        directorEN director = new directorEN();//Director a cargar
        List<int> listaID = new List<int>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Nombre_Init(object sender, EventArgs e)
        {
            try
            {
                int id;
                int.TryParse(Request.QueryString["id"], out id);//Recuperamos Id del director
                director = new directorEN(id);//Cargamos Id del director
                director = director.mostrarDirector();//Cargamos datos del director

                NombreText.Text = director.Nombre;
                ApellidosText.Text = director.Apellidos;
                nombrePais.Text = director.Nacionalidad;

                List<string> listaNombres = new List<string>();
                List<peliculaEN> listaP = director.peliculasDirector();//Cargamos la lista de peliculas del director
                for (int i = 0; i < listaP.Count; i++)
                {
                    listaNombres.Add(listaP[i].NombreP);
                    listaID.Add(listaP[i].IdP);//Se guarda la id asociada a cada nombre de la lista
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

        }
    }
}