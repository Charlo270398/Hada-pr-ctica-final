using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;
using CAD;
using System.Drawing;

namespace WebVideo
{
    public partial class Area_Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            paisCAD p = new paisCAD();
            Response.Charset = "utf-8";
            usuarioEN user = (usuarioEN)Session["user_session_data"];

            pais.Text = p.mostrarPais(user.Pais).Pais;
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

        protected void Btn_AlquilerC(object sender, EventArgs e)
        {

        }

        protected void Btn_CompraC(object sender, EventArgs e)
        {

        }
    }
}