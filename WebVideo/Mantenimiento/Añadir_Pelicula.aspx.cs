using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAD;
using Clases.EN;
using System.Drawing;
using System.Globalization;

namespace WebVideo.Mantenimiento
{
    public partial class Añadir_Pelicula : System.Web.UI.Page
    {
        List<string> nombres = new List<string>();
        List<int> listaIdDir = new List<int>();
        List<int> listaIdDist = new List<int>();
        List<int> listaIdSag = new List<int>();
        peliculaCAD p = new peliculaCAD();
        peliculaEN pelicula = new peliculaEN();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Añadir_Click(object sender, EventArgs e)
        {
            if(tituloBox.Text!="" && duracionBox.Text != "" && sinopsisBox.Text != "" && alquilerBox.Text != "" && compraBox.Text != "" && imagenBox.Text != "" && trailerBox.Text != "")
            {
                if(DWdir.SelectedItem.ToString() != "[Seleccionar]" && DWdist.SelectedItem.ToString() != "[Seleccionar]")
                {
                    try
                    {
                        DistribuidoraCAD dist = new DistribuidoraCAD();
                        directorCAD dir = new directorCAD();
                        float precioC = float.Parse(compraBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                        float precioA = float.Parse(alquilerBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                        int duracion = int.Parse(duracionBox.Text, CultureInfo.InvariantCulture.NumberFormat); ;
                        int idDist = listaIdDist[DWdist.SelectedIndex - 1];
                        int idDir = listaIdDir[DWdir.SelectedIndex - 1];
                        int idSag = -1;
                        string fecha = DWdia.SelectedItem.ToString() + "-" + DWmes.SelectedItem.ToString() + "-" + DWaño.SelectedItem.ToString();
                        pelicula = new peliculaEN(-1, tituloBox.Text, duracion, fecha, sinopsisBox.Text, precioC, precioA, idDist, idDir, imagenBox.Text, idSag, trailerBox.Text);
                        pelicula.IdDir = idDir;
                        pelicula.IdDist = idDist;
                        pelicula.anyadirPelicula();
                        Err.Text = "AÑADIDO CORRECTAMENTE";
                        Err.Visible = true;
                        Err.ForeColor = Color.Green;
                    }
                    catch (Exception ex)
                    {
                        Err.Text = ex.Message;
                        Err.Visible = true;
                        Err.ForeColor = Color.Red;
                    }
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
                List < directorEN > dirlist = d.mostrarListaDirectores(dir);
                listaIdDir.Clear();
                nombres.Clear();
                for(i=0; i< dirlist.Count; i++)
                {
                    nombres.Add(dirlist[i].Nombre + " " + dirlist[i].Apellidos);
                    listaIdDir.Add(dirlist[i].IdD);
                }
                DWdir.DataSource = nombres;
                DWdir.DataBind();
                DWdir.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

            }
            if (DWdist != null)
            {
                DistribuidoraCAD dist = new DistribuidoraCAD();
                nombres.Clear();
                listaIdDist.Clear();
                List<distribuidoraEN> dlist = dist.mostrarListaDistribuidora();
                for (i = 0; i < dlist.Count; i++)
                {
                    nombres.Add(dlist[i].Nombre);
                    listaIdDist.Add(dlist[i].IdDis);
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