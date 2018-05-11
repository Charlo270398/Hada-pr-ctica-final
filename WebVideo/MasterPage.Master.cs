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
<<<<<<< HEAD
            usuarioEN userS = (usuarioEN)Session["user_session_data"];
            if (userS != null)
            {
                btnSalir.Visible = true;
                menuMantenimiento.Visible = true;
                userTextBox.Visible = false;
                passTextBox.Visible = false;
                accederButton.Visible = false;
                nuevoUsuarioButton.Visible = false;
                Label1.Visible = false;
                Label2.Visible = false;
                user = userS;
                err.Text = "BIENVENIDO " + user.Nombre;
                err.ForeColor = Color.Green;
                err.Visible = true;
=======
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
>>>>>>> ffe516b13842f9d82f4acf12a663a814545fd02c
            }
            else
            {
                Nombre.Visible = false;
                menuRegistro.NavigateUrl = "Registro.aspx";
                menuRegistro.Text = "Registro";
                menuMantenimiento.Visible = false;
<<<<<<< HEAD
                btnSalir.Visible = false;
                userTextBox.Visible = true;
                passTextBox.Visible = true;
                accederButton.Visible = true;
                nuevoUsuarioButton.Visible = true;
                Label1.Visible = true;
                Label2.Visible = true;
                err.Visible = false;
=======
                menuSalir.Visible = false;
                menuLogin.Visible = true;
>>>>>>> ffe516b13842f9d82f4acf12a663a814545fd02c
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
<<<<<<< HEAD
            menuMantenimiento.Visible = false;
            btnSalir.Visible = false;
=======

>>>>>>> ffe516b13842f9d82f4acf12a663a814545fd02c
        }

        protected void SalirBTN(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Session["user_session_data"] = null;
            menuMantenimiento.Visible = false;
            btnSalir.Visible = false;
        }

        protected void salirButton_Click(object sender, EventArgs e)
        {
=======
>>>>>>> ffe516b13842f9d82f4acf12a663a814545fd02c

        }
    }
}