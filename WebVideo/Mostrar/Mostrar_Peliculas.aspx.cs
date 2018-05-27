using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;

namespace WebVideo.Peliculas
{
    public partial class Mostrar_Peliculas : System.Web.UI.Page
    {

        peliculaEN pelicula = new peliculaEN();

        protected void Page_Load(object sender, EventArgs e)
        {
            Application.Lock();
            Application["PageRequestCount"] =
                ((int)Application["PageRequestCount"]) + 1;
            Application.UnLock();
        }

        protected void imagePelicula1_Click(object sender, ImageClickEventArgs e)
        {

        }
        protected void imagePelicula1_Init(object sender, EventArgs e)
        {
            try
            {
                
                int id;
                int.TryParse(Request.QueryString["id"], out id);//Recuperamos Id de la pelicula
                pelicula = new peliculaEN(id, "");//Cargamos id de la pelicula
                pelicula = pelicula.mostrarPelicula();//Cargamos datos de la pelicula
                directorEN d = new directorEN(pelicula.IdDir);
                distribuidoraEN dis = new distribuidoraEN(pelicula.IdDist,"");
                Titulo.Text = pelicula.NombreP;
                Texto_Sinopsis.Text = pelicula.Sinopsis;
                Imagen.ImageUrl = pelicula.Imagen;
                float precio = pelicula.PrecioA / 100;//Conversion a euros
                precioAnumtext.Text = precio.ToString() + "€";
                fechaEstrenotext.Text = pelicula.FechaE.Substring(0, 10);
                precio = pelicula.PrecioC / 100;
                precioCnumtext.Text = precio.ToString() + "€";
                TrailerLink.NavigateUrl = pelicula.Trailer;
                duracionNumtext.Text = pelicula.Duracion.ToString() + " min";
                mostrarDirText.Text = d.mostrarDirector().Nombre + " " + d.mostrarDirector().Apellidos;
                mostrarDirText.NavigateUrl = "Mostrar_Director.aspx?id=" + pelicula.IdDir;
                mostrarDistText.Text = dis.mostrarDistribuidora().Nombre;
                mostrarDistText.NavigateUrl = "Mostrar_Distribuidora.aspx?id=" + pelicula.IdDist;
                if (pelicula.IdSaga != -1)
                {
                    sagaEN s = new sagaEN(pelicula.IdSaga, "","");
                    mostrarSaga.Visible = true;
                    SagaText.Visible = true;
                    mostrarSaga.Text = s.mostrarSaga().Nombre;

                }
                Response.Charset = "utf-8";
                usuarioEN user = (usuarioEN)Session["user_session_data"];//Cargamos el usuario si hay sesion iniciada
                if (user != null)
                {
                    adquirirText.Visible = true;
                    adquirirText.NavigateUrl = "../Transaccion.aspx?id=" + pelicula.IdP;
                }
            }catch (Exception ex)
            {
                Response.Redirect("../Pagina_Error.aspx?err=" + ex.Message);
            }

        }
    }
}