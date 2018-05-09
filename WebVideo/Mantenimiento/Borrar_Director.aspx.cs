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
    public partial class Borrar_Director : System.Web.UI.Page
    {
        directorEN director = new directorEN( "", "", "");
        List<directorEN> listaD = new List<directorEN>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DWDirector_Init(object sender, EventArgs e)
        {
            int i;
            if (DWDirector != null)
            {
                    directorCAD dir = new directorCAD();
                    director.Nombre = "%";
                    List<String> nombres = new List<string>();
                    listaD = dir.mostrarListaDirectores(director);
                    for (i = 0; i < listaD.Count; i++)
                    {
                        nombres.Add(listaD[i].Nombre + " " + listaD[i].Apellidos);
                    }
                    DWDirector.DataSource = nombres;
                    DWDirector.DataBind();
                    DWDirector.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            }

            if (DWDirector.Items.Count == 1)
            {
                Btn_Borrar.Visible = false;
                Err1.ForeColor = Color.Red;
                Err1.Visible = true;
                Err1.Text = "No quedan directores";
            }

        }

        protected void Btn_Borrar_Click(object sender, EventArgs e)
        {
            if (DWDirector.Items.Count == 1)
            {
                Btn_Borrar.Visible = false;
                Err1.ForeColor = Color.Red;
                Err1.Visible = true;
                Err1.Text = "No quedan directores";
            }
            else
            {
                if (DWDirector.SelectedItem.ToString() != "[Seleccionar]")
                {
                    try
                    {
                        bool stop = false;
                        for (int i = 0; i < listaD.Count && !stop; i++)
                        {
                            if (listaD[i].Nombre + " " + listaD[i].Apellidos == DWDirector.SelectedItem.ToString())
                            {
                                director.IdD = listaD[i].IdD;
                                stop = true;
                            }
                        }
                        director.borrarDirector();
                        Err1.ForeColor = Color.Green;
                        Err1.Visible = true;
                        Err1.Text = "BORRADO CORRECTAMENTE";

                        DWDirector_Init(sender, e);
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
    }
}