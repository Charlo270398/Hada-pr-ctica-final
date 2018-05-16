using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;
using CAD;
using System.Drawing;

namespace WebVideo.Mantenimiento
{
    public partial class Main : System.Web.UI.Page
    {
        List<string> opList = new List<string>();
        usuarioEN user = new usuarioEN();
        usuarioCAD u = new usuarioCAD();
        List<usuarioEN> listaU = new List<usuarioEN>();

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
            opList.Add("Borrar");
            DW_Actuaciones.DataBind();
            DW_Actuaciones.DataSource = opList;
            DW_Actuaciones.DataBind();
            opList.Add("Modificar");
            DW_Dist.DataSource = opList;
            DW_Dist.DataBind();
            DW_Dir.DataSource = opList;
            DW_Dir.DataBind();
            DW_Actor.DataSource = opList;
            DW_Actor.DataBind();
            DW_Pelicula.DataSource = opList;
            DW_Pelicula.DataBind();
            DW_Saga.DataBind();
            DW_Saga.DataSource = opList;
            DW_Saga.DataBind();
            DW_Serie.DataSource = opList;
            DW_Serie.DataBind();
            listaU = u.listaUsuarios();
            opList.Clear();
            opList.Add("[Seleccionar]");
                for (int i = 0; i < listaU.Count; i++)
                {
                    opList.Add(listaU[i].Email);
                }
            DW_Privilegios.DataSource = opList;
            DW_Privilegios.DataBind();


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

        protected void Btn_Pelicula_Click(object sender, EventArgs e)
        {
            if (DW_Pelicula.SelectedValue == "Añadir")
            {
                Response.Redirect("Añadir_Pelicula.aspx?");
            }
            else if (DW_Pelicula.SelectedValue == "Modificar")
            {
                Response.Redirect("Modificar_Pelicula.aspx?");
            }
            else
            {
                Response.Redirect("Borrar_Pelicula.aspx?");
            }
        }

        protected void Btn_Serie_Click(object sender, EventArgs e)
        {
            if (DW_Serie.SelectedValue == "Añadir")
            {
                Response.Redirect("Añadir_Serie.aspx?");
            }
            else if (DW_Serie.SelectedValue == "Modificar")
            {
                Response.Redirect("Modificar_Serie.aspx?");
            }
            else
            {
                Response.Redirect("Borrar_Serie.aspx?");
            }
        }

        protected void Btn_Saga_Click(object sender, EventArgs e)
        {
            if (DW_Saga.SelectedValue == "Añadir")
            {
                Response.Redirect("Añadir_Saga.aspx?");
            }
            else if (DW_Saga.SelectedValue == "Modificar")
            {
                Response.Redirect("Modificar_Saga.aspx?");
            }
            else
            {
                Response.Redirect("Borrar_Saga.aspx?");
            }

        }

        protected void Btn_Actuaciones_Click(object sender, EventArgs e)
        {
            if (DW_Actuaciones.SelectedValue == "Añadir")
            {
                Response.Redirect("Añadir_Actuacion.aspx?");
            }
            else
            {
                Response.Redirect("Borrar_Actuacion.aspx?");
            }

        }

        protected void Btn_Privilegios_Click(object sender, EventArgs e)
        {
            if(DW_Privilegios.SelectedItem.ToString() != "[Seleccionar]")
            {
                bool stop = false;
                for(int i = 0; i<listaU.Count && !stop; i++)
                {
                    if(DW_Privilegios.SelectedItem.ToString() == listaU[i].Email){
                        stop = true;
                        if (!listaU[i].AdMin)
                        {
                            try
                            {
                                listaU[i].hacerAdmin();
                                err.Text = "AHORA " + DW_Privilegios.SelectedItem.ToString() + " ES ADMIN";
                                err.ForeColor = Color.Green;
                                err.Visible = true;
                            }
                            catch (Exception ex)
                            {
                                err.Text = ex.Message;
                                err.ForeColor = Color.Red;
                                err.Visible = true;
                            }
                        }
                        else
                        {
                            err.Text = DW_Privilegios.SelectedItem.ToString() + " YA ES ADMIN";
                            err.ForeColor = Color.Red;
                            err.Visible = true;
                        }
                        
                    }
                }
            }
        }
    }
}