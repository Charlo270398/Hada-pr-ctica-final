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
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Charset = "utf-8";
            usuarioEN user = (usuarioEN)Session["user_session_data"];
            if (user != null)
            {
                if (user.AdMin)
                {
                    menuMantenimiento.Visible = true;
                }
                menuSalir.Visible = true;
                menuLogin.Visible = false;
                menuRegistro.Text = "Área cliente";
                menuRegistro.NavigateUrl = "Area_cliente.aspx";
                Nombre.Visible = true;
                Nombre.ForeColor = Color.Black;
                Nombre.Text = "Sesión iniciada como: " + user.Email;
            }
            else
            {
                Nombre.Visible = false;
                menuRegistro.NavigateUrl = "Registro.aspx";
                menuRegistro.Text = "Registro";
                menuMantenimiento.Visible = false;
                menuSalir.Visible = false;
                menuLogin.Visible = true;
            }
        }

        protected void accederButton_Click(object sender, EventArgs e)
        {

        }

        protected void nuevoUsuarioButton_Click(object sender, EventArgs e)
        {

        }

        protected void menuMantenimiento_Init(object sender, EventArgs e)
        {

        }

        protected void a(object sender, EventArgs e)
        {

        }
    }
}