﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebVideo.Peliculas;
using Clases.EN;



    public partial class MasterPage : System.Web.UI.MasterPage
    {



        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void accederButton_Click(object sender, EventArgs e)
        {


        }
        protected void menuCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/inicio.aspx");
        }
        protected void nuevoUsuarioButton_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/Registro.aspx");
        }
    }

