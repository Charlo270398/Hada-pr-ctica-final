using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebVideo.Mantenimiento
{
    public partial class Main : System.Web.UI.Page
    {
        List<string> opList = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Dist_Click(object sender, EventArgs e)
        {
            if(DW_Dist.SelectedValue == "Añadir")
            {
                Response.Redirect("Añadir_Dist.aspx?");
            }
            else if(DW_Dist.SelectedValue == "Modificar")
            {
                Response.Redirect("Modificar_Dist.aspx?");
            }
            else
            {
                Response.Redirect("Borrar_Dist.aspx?");
            }

        }

        protected void DW_Dist_Init(object sender, EventArgs e)
        {
            opList.Add("Añadir");
            opList.Add("Modificar");
            opList.Add("Borrar");
            DW_Dist.DataSource = opList;
            DW_Dist.DataBind();
            DW_Dir.DataSource = opList;
            DW_Dir.DataBind();
            DW_Actor.DataSource = opList;
            DW_Actor.DataBind();

        }

        protected void Btn_Dir_Click(object sender, EventArgs e)
        {
            if (DW_Dir.SelectedValue == "Añadir")
            {
                Response.Redirect("Añadir_Director.aspx?");
            }
            else if (DW_Dir.SelectedValue == "Modificar")
            {
                Response.Redirect("Modificar_Director.aspx?");
            }
            else
            {
                Response.Redirect("Borrar_Director.aspx?");
            }

        }

        protected void Btn_Actor_Click(object sender, EventArgs e)
        {
            if (DW_Actor.SelectedValue == "Añadir")
            {
                Response.Redirect("Añadir_Actor.aspx?");
            }
            else if (DW_Actor.SelectedValue == "Modificar")
            {
                Response.Redirect("Modificar_Actor.aspx?");
            }
            else
            {
                Response.Redirect("Borrar_Actor.aspx?");
            }

        }
    }
}