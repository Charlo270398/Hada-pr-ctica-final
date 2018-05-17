using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;
using System.Drawing;
using System.Net.Mail;

namespace WebVideo
{
    public partial class Area_Clientes : System.Web.UI.Page
    {
        List<string> nombres = new List<string>();
        List<int> listaIDA = new List<int>();
        List<int> listaIDC = new List<int>();
        List<int> listaIDAS = new List<int>();
        List<int> listaIDCS = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                paisEN p = new paisEN();
                Response.Charset = "utf-8";
                usuarioEN user = (usuarioEN)Session["user_session_data"];
                p.IdPais = user.Pais;
                pais.Text = p.mostrarNombrePais().Pais;
                nombre.Text = user.Nombre + " " + user.Apellidos;
                email.Text = user.Email;
                fecha.Text = user.FechaA.Substring(0,11);
                if (user.AdMin)
                {
                    admin.Visible = true;
                }
            }
            catch (Exception)
            {
                Response.Redirect("../Pagina_Error.aspx");
            }

        }

        protected void Btn_AlquilerC(object sender, EventArgs e)
        {
            if (DWAlquiler.SelectedItem.ToString() != "[Seleccionar]")
            {
                Response.Redirect("../Mostrar/Mostrar_Factura.aspx?id=" + listaIDA[DWAlquiler.SelectedIndex - 1].ToString());
            }
        }

        protected void Btn_AlquilerC0(object sender, EventArgs e)
        {
            if (DWAlquiler0.SelectedItem.ToString() != "[Seleccionar]")
            {
                Response.Redirect("../Mostrar/Mostrar_Facturas.aspx?id=" + listaIDAS[DWAlquiler0.SelectedIndex - 1].ToString());
            }
        }

        protected void Btn_CompraC(object sender, EventArgs e)
        {
            if (DWCompras.SelectedItem.ToString() != "[Seleccionar]")
            {
                Response.Redirect("../Mostrar/Mostrar_Factura.aspx?id=" + listaIDC[DWCompras.SelectedIndex - 1].ToString());
            }
        }

        protected void Btn_CompraC0(object sender, EventArgs e)
        {
            if (DWCompras0.SelectedItem.ToString() != "[Seleccionar]")
            {
                Response.Redirect("../Mostrar/Mostrar_Facturas.aspx?id=" + listaIDCS[DWCompras0.SelectedIndex - 1].ToString());
            }
        }

        protected void Btn_ContraseñaC(object sender, EventArgs e)
        {
            
        }

        protected void Btn_DatosC(object sender, EventArgs e)
        {
            Response.Redirect("Cambiar_Datos.aspx");
        }

        protected void Btn_BorrarC(object sender, EventArgs e)
        {
            try
            {
                usuarioEN user = (usuarioEN)Session["user_session_data"];
                user.borrarUsuario();
                Session["user_session_data"] = null;
                Response.Redirect("../Inicio.aspx");
            }catch(Exception)
            {
                Response.Redirect("../Pagina_Error.aspx");
            }

            
        }

        protected void enviarMensajeDevueltas(peliculaEN p)
        {
            usuarioEN user = (usuarioEN)Session["user_session_data"];
            SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
            cliente.EnableSsl = true;
            cliente.Credentials = new System.Net.NetworkCredential("hookinVideoclub@gmail.com", "hookin123");
            string contenido = "Hola, " + user.Nombre + ". Le informamos de que el alquiler de la película " + p.NombreP + " acaba de vencer.\n";
            contenido += "Puede volver a alquilar la película usando nuestra aplicación.\n\n";
            contenido += "El equipo de Cuentas de Hookin";
            MailMessage mail = new MailMessage("hookinVideoclub@gmail.com", user.Email, "Devolución", contenido);
            cliente.Send(mail);

        }

        protected void DWCompras_Init(object sender, EventArgs e)
        {
            usuarioEN user = (usuarioEN)Session["user_session_data"];
            transaccionPeliculaEN t = new transaccionPeliculaEN();
            t.Email = user.Email;
            List <int> devueltas = t.eliminarAlquiladas();

            for(int i = 0; i<devueltas.Count; i++)
            {
                peliculaEN p = new peliculaEN(devueltas[i],"");
                enviarMensajeDevueltas(p.mostrarPelicula());
            }

            if (DWAlquiler != null)
            {
                peliculaEN peli = new peliculaEN();
                List<transaccionPeliculaEN> lista = user.listaAlquileresP();
                nombres.Clear();
                listaIDA.Clear();
                nombres.Add("[Seleccionar]");
                for (int i = 0; i < lista.Count; i++)
                {
                    peli = new peliculaEN();
                    peli.IdP = lista[i].IdP;
                    listaIDA.Add(peli.IdP);
                    nombres.Add(peli.mostrarPelicula().NombreP);
                }
                
                DWAlquiler.DataSource = nombres;
                DWAlquiler.DataBind();


            }

            if (DWCompras != null)
            {
                peliculaEN peli = new peliculaEN();
                List<transaccionPeliculaEN> lista = user.listaComprasP();
                nombres.Clear();
                listaIDC.Clear();
                nombres.Add("[Seleccionar]");
                for (int i = 0; i < lista.Count; i++)
                {
                    peli = new peliculaEN();
                    peli.IdP = lista[i].IdP;
                    listaIDC.Add(peli.IdP);
                    nombres.Add(peli.mostrarPelicula().NombreP);
                }
                
                DWCompras.DataSource = nombres;
                DWCompras.DataBind();
            }

            if(DWAlquiler0 != null)
            {
                nombres.Clear();
                listaIDAS.Clear();
                serieEN serie = new serieEN();
                List<transaccionSerieEN> lista2 = user.listaAlquileresS();
                nombres.Add("[Seleccionar]");
                for (int i = 0; i < lista2.Count; i++)
                {
                    serie = new serieEN();
                    serie.IdS = lista2[i].IdS;
                    listaIDAS.Add(serie.IdS);
                    nombres.Add(serie.mostrarSerie().Titulo);
                }
                DWAlquiler0.DataSource = nombres;
                DWAlquiler0.DataBind();
            }
            if(DWCompras0 != null)
            {
                nombres.Clear();
                listaIDCS.Clear();
                serieEN serie = new serieEN();
                List<transaccionSerieEN> lista2 = user.listaComprasS();
                nombres.Add("[Seleccionar]");
                for (int i = 0; i < lista2.Count; i++)
                {
                    serie = new serieEN();
                    serie.IdS = lista2[i].IdS;
                    listaIDCS.Add(serie.IdS);
                    nombres.Add(serie.mostrarSerie().Titulo);
                }
                DWCompras0.DataSource = nombres;
                DWCompras0.DataBind();
            }

        }
    }
}