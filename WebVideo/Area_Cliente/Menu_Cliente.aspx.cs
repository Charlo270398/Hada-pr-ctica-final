using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;
using System.Drawing;

namespace WebVideo
{
    public partial class Area_Clientes : System.Web.UI.Page
    {
        List<string> nombres = new List<string>();

        List<int> listaIDA = new List<int>();
        List<int> listaIDC = new List<int>();

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


                if (DWAlquiler != null)
                {
                    peliculaEN peli = new peliculaEN();
                    List<transaccionPeliculaEN> lista = user.listaAlquileresP();
                    nombres.Clear();
                    for (int i = 0; i < lista.Count; i++)
                    {
                        peli = new peliculaEN();
                        peli.IdP = lista[i].IdP;
                        nombres.Add(peli.mostrarPelicula().NombreP);
                    }
                    DWAlquiler.DataSource = nombres;
                    DWAlquiler.DataBind();
                    DWAlquiler.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

                }

                if (DWCompras != null)
                {
                    peliculaEN peli = new peliculaEN();
                    List <transaccionPeliculaEN> lista = user.listaComprasP();
                    nombres.Clear();
                    for (int i = 0; i<lista.Count; i++)
                    {
                        peli = new peliculaEN();
                        peli.IdP = lista[i].IdP;
                        nombres.Add(peli.mostrarPelicula().NombreP);
                    }
                    DWCompras.DataSource = nombres;
                    DWCompras.DataBind();
                    DWCompras.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

                }

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

        protected void Btn_CompraC(object sender, EventArgs e)
        {

            if (DWCompras.SelectedItem.ToString() != "[Seleccionar]")
            {
                Response.Redirect("../Mostrar/Mostrar_Factura.aspx?id=" + listaIDC[DWCompras.SelectedIndex - 1]);
            }

        }

        protected void Btn_ContraseñaC(object sender, EventArgs e)
        {

            Response.Redirect("Cambiar_Contraseña.aspx");

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


        protected void DWCompras_Init(object sender, EventArgs e)
        {
            usuarioEN user = (usuarioEN)Session["user_session_data"];
            if (DWAlquiler != null)
            {
                peliculaEN peli = new peliculaEN();
                List<transaccionPeliculaEN> lista = user.listaAlquileresP();
                nombres.Clear();
                listaIDA.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    peli = new peliculaEN();
                    peli.IdP = lista[i].IdP;
                    listaIDA.Add(peli.IdP);
                    nombres.Add(peli.mostrarPelicula().NombreP);
                }
                DWAlquiler.DataSource = nombres;
                DWAlquiler.DataBind();
                DWAlquiler.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

            }

            if (DWCompras != null)
            {
                peliculaEN peli = new peliculaEN();
                List<transaccionPeliculaEN> lista = user.listaComprasP();
                nombres.Clear();
                listaIDC.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    peli = new peliculaEN();
                    peli.IdP = lista[i].IdP;
                    listaIDC.Add(peli.IdP);
                    nombres.Add(peli.mostrarPelicula().NombreP);
                }
                DWCompras.DataSource = nombres;
                DWCompras.DataBind();
                DWCompras.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

            }

        }

    }
}