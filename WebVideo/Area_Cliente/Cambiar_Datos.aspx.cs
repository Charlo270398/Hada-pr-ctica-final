using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using Clases.EN;

namespace WebVideo.Area_Cliente
{
    public partial class Cambiar_Datos : System.Web.UI.Page
    {
        usuarioEN user = new usuarioEN();
        protected void Page_Load(object sender, EventArgs e)
        {
            user = (usuarioEN)Session["user_session_data"];
        }

        protected void BTN_CAMBIARC(object sender, EventArgs e)
        {
            Err.Visible = false;
            if(Text_nombre.Text == "" || Text_apellidos.Text == "")
            {
                Err.Visible = true;
                Err.Text = "*Existen campos vacíos";
                Err.ForeColor = Color.Red;
            }
            else
            {
                paisEN p = new paisEN(DWPais.SelectedItem.ToString());
                try
                {
                    user.Nombre = Text_nombre.Text;
                    user.Apellidos = Text_apellidos.Text;
                    user.Pais = p.mostrarIdPais().IdPais;
                    user.modificarDatos();
                    Err.Visible = true;
                    Err.Text = "Datos cambiados correctamente";
                    Err.ForeColor = Color.Green;
                    Session["user_session_data"] = user;
                }
                catch (Exception ex)
                {
                    Err.Visible = true;
                    Err.Text = ex.Message;
                    Err.ForeColor = Color.Red;
                }
            }
        }

        protected void DWPais_Init(object sender, EventArgs e)
        {
            if (DWPais != null)
            {
                paisEN pais = new paisEN();
                DWPais.DataSource = pais.mostrarListaNombresPaises();
                DWPais.DataBind();
            }
            
        }
    }
}