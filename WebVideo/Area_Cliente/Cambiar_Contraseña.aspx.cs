using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;
using System.Drawing;

namespace WebVideo.Area_Cliente
{
    public partial class Cambiar_Contraseña : System.Web.UI.Page
    {
        usuarioEN user = new usuarioEN();
        protected void Page_Load(object sender, EventArgs e)
        {
            user = (usuarioEN)Session["user_session_data"];
        }

        protected void BTN_CAMBIARC(object sender, EventArgs e)
        {
            Err.Visible = false;
            if(Text_Pass0.Text == "" || Text_Pass1.Text == "" || Text_Pass2.Text == "")
            {
                Err.Visible = true;
                Err.Text = "*Existen campos vacíos";
            }
            else
            {
                if (Text_Pass1.Text.Length < 7 || Text_Pass2.Text.Length < 7)
                {
                    Err.Visible = true;
                    Err.Text = "*Las contraseñas deben tener como mínimo 7 caracteres";
                }
                else
                {
                    if (Text_Pass0.Text != user.Contrasenya)
                    {
                        Err.Visible = true;
                        Err.Text = "*La contraseña actual es distinta";
                    }
                    else
                    {
                        if (Text_Pass1.Text != Text_Pass2.Text)
                        {
                            Err.Visible = true;
                            Err.Text = "*Contraseñas nuevas distintas";
                        }
                        else
                        {
                            try
                            {
                                user.Contrasenya = Text_Pass1.Text;
                                user.modificarContraseña();
                                Session["user_session_data"] = user;
                                Err.Visible = true;
                                Err.Text = "Contraseña cambiada correctamente";
                                Err.ForeColor = Color.Green;
                            }
                            catch (Exception ex)
                            {
                                Err.Visible = true;
                                Err.Text = ex.Message;
                            }
                        }
                    }
                }
            }
        }
    }
}