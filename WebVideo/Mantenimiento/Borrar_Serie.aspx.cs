using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.CAD;
using Clases.EN;
using CAD;

namespace WebVideo.Mantenimiento
{
    public partial class Borrar_Serie : System.Web.UI.Page
    {
        serieEN serie = new serieEN();
        List<serieEN> listaSeries = new List<serieEN>();
        peliculaEN pelicula = new peliculaEN();
        List<peliculaEN> listaPeliculas = new List<peliculaEN>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void DWSeries_Init(object sender, EventArgs e)
        {
            int i;
            if (DWSeries != null)
            {
                serieCAD s = new serieCAD();
                serie.Titulo = "%";
                List<String> nombres = new List<string>();
                listaSeries = s.mostrarListaSeries(serie);
                for (i = 0; i < listaSeries.Count; i++)
                {
                    nombres.Add(listaSeries[i].Titulo);
                }
                DWSeries.DataSource = nombres;
                DWSeries.DataBind();
                DWSeries.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            }
            if (DWSeries.Items.Count == 1)
            {
                Btn_Borrar.Visible = false;
                Err.ForeColor = Color.Red;
                Err.Visible = true;
                Err.Text = "No hay series en la Base de Datos";
            }
            /*int i;
            if (DWSeries != null)
            {
                peliculaCAD p = new peliculaCAD();
                pelicula.NombreP = "%";
                List<String> nombres = new List<string>();
                listaPeliculas = p.mostrarListaPeliculas(pelicula);
                for (i = 0; i < listaPeliculas.Count; i++)
                {
                    nombres.Add(listaPeliculas[i].NombreP);
                }
                DWSeries.DataSource = nombres;
                DWSeries.DataBind();
                DWSeries.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            }
            if (DWSeries.Items.Count == 1)
            {
                Btn_Borrar.Visible = false;
                Err.ForeColor = Color.Red;
                Err.Visible = true;
                Err.Text = "No quedan directores";
            }*/
        }
        protected void Btn_Borrar_Click(object sender, EventArgs e)
        {
            if (DWSeries.Items.Count == 1)
            {
                Btn_Borrar.Visible = false;
                Err.ForeColor = Color.Red;
                Err.Visible = true;
                Err.Text = "No quedan directores";
            }
            else
            {
                if (DWSeries.SelectedItem.ToString() != "[Seleccionar]")
                {
                    try
                    {
                        bool stop = false;
                        for (int i = 0; i < listaSeries.Count && !stop; i++)
                        {
                            if (listaSeries[i].Titulo == DWSeries.SelectedItem.ToString())
                            {
                                serie.IdS = listaSeries[i].IdS;
                                stop = true;
                            }
                        }
                        serie.borrarSerie();
                        Err.ForeColor = Color.Green;
                        Err.Visible = true;
                        Err.Text = "BORRADO CORRECTAMENTE";

                        DWSeries_Init(sender, e);
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