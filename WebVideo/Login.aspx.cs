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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["user_session_data"] = null;
        }

        protected void BTN_LOGIN(object sender, EventArgs e)
        {

            if(Text_Email.Text != "" && Text_Pass.Text != ""){
                usuarioEN usuario = new usuarioEN(Text_Email.Text, Text_Pass.Text); //Buscamos el usuario que introducimos para iniciar sesion
                if (usuario.existe())
                {
                    usuario.cargarUsuario();
                    if (usuario.Contrasenya == Text_Pass.Text)
                    {
                        Session["user_session_data"] = usuario; 
                        Response.Redirect("Area_Cliente/Menu_Cliente.aspx"); 
                    }
                    else
                    {
                        Err.ForeColor = Color.Red;
                        Err.Text = "*Contraseña incorrecta";
                        Err.Visible = true;
                    }
                }
                else
                {
                    Err.ForeColor = Color.Red;
                    Err.Text = "*Email inexistente";
                    Err.Visible = true;
                }
            }
            else
            {
                Err.ForeColor = Color.Red;
                Err.Text = "*Quedan campos vacíos";
                Err.Visible = true;
            }
        }
    }
}