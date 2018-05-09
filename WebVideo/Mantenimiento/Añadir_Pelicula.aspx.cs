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
    public partial class Añadir_Pelicula : System.Web.UI.Page
    {
        List<string> nombres = new List<string>();
        peliculaCAD p = new peliculaCAD();
        peliculaEN pelicula = new peliculaEN();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Añadir_Click(object sender, EventArgs e)
        {
            if(tituloBox.Text!="" && duracionBox.Text != "" && sinopsisBox.Text != "" && alquilerBox.Text != "" && compraBox.Text != "" && imagenBox.Text != "" && trailerBox.Text != "")
            {
                if(DWdir.SelectedItem.ToString() == "[Seleccionar]" && DWdist.SelectedItem.ToString() == "[Seleccionar]")
                {
                    pelicula = new peliculaEN();
                }
                else
                {
                    Err.Text = "*Quedan opciones sin seleccionar";
                    Err.Visible = true;
                    Err.ForeColor = Color.Red;
                }
            }
            else
            {
                Err.Text = "*Campos vacíos";
                Err.Visible = true;
                Err.ForeColor = Color.Red;
            }

        }

        protected void DWdia_Init(object sender, EventArgs e)
        {
            int i;
            List<int> nums = new List<int>();
            if (DWdir != null)
            {
                directorCAD d = new directorCAD();
                directorEN dir = new directorEN();

                nombres.Clear();
                for(i=0; i< d.mostrarListaDirectores(dir).Count; i++)
                {
                    nombres.Add(d.mostrarListaDirectores(dir)[i].Nombre + " " + d.mostrarListaDirectores(dir)[i].Apellidos);
                }
                DWdir.DataSource = nombres;
                DWdir.DataBind();
                DWdir.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

            }
            if (DWdist != null)
            {
                DistribuidoraCAD dist = new DistribuidoraCAD();
                nombres.Clear();
                for (i = 0; i < dist.mostrarListaDistribuidora().Count; i++)
                {
                    nombres.Add(dist.mostrarListaDistribuidora()[i].Nombre);
                }
                DWdist.DataSource = nombres;
                DWdist.DataBind();
                DWdist.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

            }
            if (DWdia != null)
            {
                nums.Clear();
                for (i = 1; i < 32; i++)
                {
                    nums.Add(i);
                }
                DWdia.DataSource = nums;
                DWdia.DataBind();

            }
            if (DWmes != null)
            {
                nums.Clear();
                for (i = 1; i < 13; i++)
                {
                    nums.Add(i);
                }
                DWmes.DataSource = nums;
                DWmes.DataBind();

            }
            if (DWaño != null)
            {
                nums.Clear();
                for (i = 1900; i < 2019; i++)
                {
                    nums.Add(i);
                }
                DWaño.DataSource = nums;
                DWaño.DataBind();

            }

        }
    }
}