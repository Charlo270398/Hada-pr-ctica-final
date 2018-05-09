using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAD;
using System.Drawing;
using System.Data;
using Clases.EN;


namespace WebVideo.Mantenimiento
{
    public partial class Borrar_Dist : System.Web.UI.Page
    {
        DistribuidoraCAD dist = new DistribuidoraCAD();
        List<distribuidoraEN> listaDist = new List<distribuidoraEN>();
        distribuidoraEN d = new distribuidoraEN();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Borrar_Click(object sender, EventArgs e)
        {
            if (DWDist.Items.Count == 1)
            {
                Btn_Borrar.Visible = false;
                Err.ForeColor = Color.Red;
                Err.Visible = true;
                Err.Text = "No quedan distribuidoras";
            }
            else
            {
                if (DWDist.SelectedItem.ToString() != "[Seleccionar]")
                {
                    try
                    {
                        bool stop = false;
                        for (int i = 0; i < listaDist.Count && !stop; i++)
                        {
                            if (listaDist[i].Nombre == DWDist.SelectedItem.ToString())
                            {
                                d.IdDis = listaDist[i].IdDis;
                                stop = true;
                            }
                        }
                        d.borrarDistribuidora();
                        Err.ForeColor = Color.Green;
                        Err.Visible = true;
                        Err.Text = "BORRADO CORRECTAMENTE";

                        DWDist_Init(sender, e);
                    }
                    catch (Exception ex)
                    {
                        Err.ForeColor = Color.Red;
                        Err.Visible = true;
                        Err.Text = ex.Message;
                    }
                }
            }


        }

        protected void DWDist_Init(object sender, EventArgs e)
        {
            int i;
            if (DWDist != null)
            {
                d.Nombre = "%";
                List<String> nombres = new List<string>();
                listaDist = dist.mostrarListaDistribuidora();
                for (i = 0; i < listaDist.Count; i++)
                {
                    nombres.Add(listaDist[i].Nombre);
                }
                DWDist.DataSource = nombres;
                DWDist.DataBind();
                DWDist.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            }

            if (DWDist.Items.Count == 1)
            {
                Btn_Borrar.Visible = false;
                Err.ForeColor = Color.Red;
                Err.Visible = true;
                Err.Text = "No quedan directores";
            }
        }
    }
}