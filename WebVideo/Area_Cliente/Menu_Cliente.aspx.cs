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

                if (DWAlquiler != null)
                {
                    DWAlquiler.DataSource = null;
                    DWAlquiler.DataBind();
                    DWAlquiler.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

                }

                if (DWCompras != null)
                {

                    DWCompras.DataSource = null;
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

        }

        protected void Btn_CompraC(object sender, EventArgs e)
        {

        }

        protected void Btn_ContraseñaC(object sender, EventArgs e)
        {
            Response.Redirect("Cambiar_Contraseña.aspx");
        }

        protected void Btn_DatosC(object sender, EventArgs e)
        {
            Response.Redirect("Cambiar_Datos.aspx");
        }
    }
}