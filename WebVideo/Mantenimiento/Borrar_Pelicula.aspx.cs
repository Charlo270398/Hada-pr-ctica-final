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
    public partial class Borrar_Pelicula : System.Web.UI.Page
    {
        peliculaEN pelicula = new peliculaEN();
        List<peliculaEN> listaPeliculas = new List<peliculaEN>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DWPelicula_Init(object sender, EventArgs e)
        {
            int i;
            if (DWPelicula != null)
            {
                peliculaCAD p = new peliculaCAD();
                pelicula.NombreP = "%";
                List<String> nombres = new List<string>();
                listaPeliculas = p.mostrarListaPeliculas(pelicula);
                for (i = 0; i < listaPeliculas.Count; i++)
                {
                    nombres.Add(listaPeliculas[i].NombreP);
                }
                DWPelicula.DataSource = nombres;
                DWPelicula.DataBind();
                DWPelicula.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            }
            if (DWPelicula.Items.Count == 1)
            {
                Btn_Borrar.Visible = false;
                Err.ForeColor = Color.Red;
                Err.Visible = true;
                Err.Text = "No quedan directores";
            }
        }

        protected void Btn_Borrar_Click(object sender, EventArgs e)
        {
            if (DWPelicula.Items.Count == 1)
            {
                Btn_Borrar.Visible = false;
                Err.ForeColor = Color.Red;
                Err.Visible = true;
                Err.Text = "No quedan directores";
            }
            else
            {
                if (DWPelicula.SelectedItem.ToString() != "[Seleccionar]")
                {
                    try
                    {
                        bool stop = false;
                        for (int i = 0; i < listaPeliculas.Count && !stop; i++)
                        {
                            if (listaPeliculas[i].NombreP == DWPelicula.SelectedItem.ToString())
                            {
                                pelicula.IdP = listaPeliculas[i].IdP;
                                stop = true;
                            }
                        }
                        pelicula.borrarPelicula();
                        Err.ForeColor = Color.Green;
                        Err.Visible = true;
                        Err.Text = "BORRADO CORRECTAMENTE";

                        DWPelicula_Init(sender, e);
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
    }
}