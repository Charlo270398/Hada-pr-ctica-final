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
        usuarioEN user = new usuarioEN();
        protected void Page_Load(object sender, EventArgs e)
        {
             
            Response.Charset = "utf-8";
            user = (usuarioEN)Session["user_session_data"];
            if (user != null)
            {
                menuSalir.Visible = true;
                menuMantenimiento.Visible = true;
                userTextBox.Visible = false;
                passTextBox.Visible = false;
                accederButton.Visible = false;
                nuevoUsuarioButton.Visible = false;
                Label1.Visible = false;
                Label2.Visible = false;
                err.Text = "BIENVENIDO " + user.Nombre;
                err.ForeColor = Color.Green;
                err.Visible = true;
            }
            else
            {
                menuMantenimiento.Visible = false;
                menuSalir.Visible = false;
                userTextBox.Visible = true;
                passTextBox.Visible = true;
                accederButton.Visible = true;
                nuevoUsuarioButton.Visible = true;
                Label1.Visible = true;
                Label2.Visible = true;
                err.Visible = false;
            }
        }

        protected void accederButton_Click(object sender, EventArgs e)
        {
            err.Visible = false;
            if (userTextBox.Text !="" && passTextBox.Text != "") {
                usuarioEN user = new usuarioEN(userTextBox.Text, passTextBox.Text);
                if (!user.existe())
                {
                    if (!user.validacion())
                    {
                        Session["user_session_data"] = user; //Creamos una sesion del usuario                                              
                        Response.Redirect("Area_Cliente.aspx");
                    }
                    else
                    {
                        err.Text = "*Contraseña incorrecta";
                        err.Visible = true;
                    }                   
                }
                else
                {
                    err.Text = "*Email inexistente";
                    err.Visible = true;
                }             
            }
            else
            {
                err.Text = "*Hay campos vacíos";
                err.Visible = true;
            }


        }

        protected void nuevoUsuarioButton_Click(object sender, EventArgs e)
        {

        }

        protected void menuMantenimiento_Init(object sender, EventArgs e)
        {
            menuMantenimiento.Visible = false;
            menuSalir.Visible = false;
        }

        protected void a(object sender, EventArgs e)
        {
            Session.Abandon();
        }
    }
}