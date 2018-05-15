using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;

namespace WebVideo.Mostrar
{
    public partial class Mostrar_Factura : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void FechaDevText_Init(object sender, EventArgs e)
        {
            try
            {
                usuarioEN user = (usuarioEN)Session["user_session_data"];
                int id;
                int.TryParse(Request.QueryString["id"], out id);
                transaccionPeliculaEN t = new transaccionPeliculaEN(id, user.Email);
                t = t.mostrarTransaccionPelicula();
                peliculaEN p = new peliculaEN(id, "");
                p = p.mostrarPelicula();
                producto.Text = p.NombreP;
                float precio;
                if (t.Alquiler)
                {
                    tipo.Text = "Alquiler";
                    fechaDevNum.Visible = true;
                    fechaDevNum.Text = t.FechaF;
                    FechaDevText.Visible = true;
                    precio = p.PrecioA / 100;
                    importe.Text = precio.ToString() + "€";
                }
                else
                {
                    tipo.Text = "Compra estándar";
                    precio = p.PrecioC / 100;
                    importe.Text = precio.ToString() + "€";
                }
                fechaPago.Text = t.FechaC.Substring(0, 11);


            }
            catch (Exception)
            {
                Response.Redirect("../Pagina_Error.aspx");
            }
        }
    }
}