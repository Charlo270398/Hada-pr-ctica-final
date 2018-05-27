using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;

namespace WebVideo.Series
{
    public partial class Mostrar_Series : System.Web.UI.Page
    {

        serieEN serie = new serieEN();

        protected void Page_Load(object sender, EventArgs e)
        {
            Application.Lock();
            Application["PageRequestCount"] =
                ((int)Application["PageRequestCount"]) + 1;
            Application.UnLock();
        }

        protected void imageSerie1_Click(object sender, ImageClickEventArgs e)
        {

        }
        protected void imageSerie1_Init(object sender, EventArgs e)
        {
            try
            {
                int id;
                int.TryParse(Request.QueryString["id"], out id);//Recuperamos id Serie
                serie = new serieEN(id, "");
                serie = serie.mostrarSerie();
                Titulo_S.Text = serie.Titulo;
                Texto_Sinopsis.Text = serie.Sinopsis;
                Imagen.ImageUrl = serie.Imagen;
                float precio = serie.PrecioA / 100;
                precioAnumtext.Text = precio.ToString() + "€";
                fechaEstrenotext.Text = serie.FechaE;
                precio = serie.PrecioC / 100;
                precioCnumtext.Text = precio.ToString() + "€";
                Response.Charset = "utf-8";
                usuarioEN user = (usuarioEN)Session["user_session_data"];
                if (user != null)
                {
                    adquirirText.Visible = true;
                    adquirirText.NavigateUrl = "../Transaccions.aspx?id=" + serie.IdS;
                }
            }catch(Exception ex)
            {
                Response.Redirect("../Pagina_Error.aspx?err=" + ex.Message);
            }

        }
    }
}