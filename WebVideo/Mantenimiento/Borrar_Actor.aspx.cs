using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAD;
using Clases.EN;
using System.Drawing;

namespace WebVideo.Mantenimiento
{
    public partial class Borrar_Actor : System.Web.UI.Page
    {
        actorEN actor = new actorEN(-1, "", "", "", "");
        List<actorEN> listaA = new List<actorEN>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Borrar_Click(object sender, EventArgs e)
        {
            if(DWActor.Items.Count == 1)
            {
                Btn_Borrar.Visible = false;
                Err1.ForeColor = Color.Red;
                Err1.Visible = true;
                Err1.Text = "No quedan actores";
            }
            else
            {
                if (DWActor.SelectedItem.ToString() != "[Seleccionar]")
                {
                    try
                    {
                        bool stop = false;
                        for (int i = 0; i < listaA.Count && !stop; i++)
                        {
                            if (listaA[i].Nombre + " " + listaA[i].Apellidos == DWActor.SelectedItem.ToString())
                            {
                                actor.IdAc = listaA[i].IdAc;
                                stop = true;
                            }
                        }
                        actor.borrarActor();
                        Err1.ForeColor = Color.Green;
                        Err1.Visible = true;
                        Err1.Text = "BORRADO CORRECTAMENTE";

                        DWActor_Init(sender, e);
                    }
                    catch (Exception ex)
                    {
                        Err1.ForeColor = Color.Red;
                        Err1.Visible = true;
                        Err1.Text = ex.Message;
                    }
                }
            }

        }

        protected void DWActor_Init(object sender, EventArgs e)
        {
            int i;
            if (DWActor != null)
            {
                actorCAD actores = new actorCAD();
                actor.Nombre = "%";
                List<String> nombres = new List<string>();
                listaA = actores.mostrarListaActores(actor);
                for(i=0; i<listaA.Count; i++)
                {
                    nombres.Add(listaA[i].Nombre + " " + listaA[i].Apellidos); 
                }
                DWActor.DataSource = nombres;
                DWActor.DataBind();
                DWActor.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            }

            if (DWActor.Items.Count == 1)
            {
                Btn_Borrar.Visible = false;
                Err1.ForeColor = Color.Red;
                Err1.Visible = true;
                Err1.Text = "No quedan actores";
            }

        }
    }
}