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
    public partial class Añadir_Actuacion : System.Web.UI.Page
    {
        actorEN actor = new actorEN(-1, "", "", "", "");
        List<actorEN> listaA = new List<actorEN>();
        peliculaEN pelicula = new peliculaEN();
        List<peliculaEN> listaPeliculas = new List<peliculaEN>();
        List<int> idAc = new List<int>();
        List<int> idPe = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Añadir_Click(object sender, EventArgs e)
        {
            if (DWPelicula.SelectedItem.ToString() != "[Seleccionar]")
            {
                actorCAD a = new actorCAD();
                try
                {
                    a.insertarActuacion(idAc[DWActor.SelectedIndex-1], idPe[DWPelicula.SelectedIndex - 1]);
                    Err1.Text = "AÑADIDA CORRECTAMENTE";
                    Err1.ForeColor = Color.Green;
                    Err1.Visible = true;
                    DWactuacion_init( sender,  e);

                }
                catch (Exception ex)
                {
                    Err1.Text = ex.Message;
                    Err1.ForeColor = Color.Red;
                    Err1.Visible = true;
                }

            }
            else
            {
                Err1.Text = "*Faltan campos por seleccionar";
                Err1.ForeColor = Color.Red;
                Err1.Visible = true;
            }
        }

        protected void DWactuacion_init(object sender, EventArgs e)
        {
            idPe.Clear();
            idAc.Clear();
            listaA.Clear();
            listaPeliculas.Clear();
            int i;
            if (DWActor != null)
            {
                actorCAD actores = new actorCAD();
                actor.Nombre = "%";
                List<String> nombres = new List<string>();
                listaA = actores.mostrarListaActores(actor);
                for (i = 0; i < listaA.Count; i++)
                {
                    nombres.Add(listaA[i].Nombre + " " + listaA[i].Apellidos);
                    idAc.Add(listaA[i].IdAc);
                }
                DWActor.DataSource = nombres;
                DWActor.DataBind();
                DWActor.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            }
            if (DWPelicula != null)
            {
                peliculaCAD p = new peliculaCAD();
                pelicula.NombreP = "%";
                List<String> nombres = new List<string>();
                listaPeliculas = p.mostrarListaPeliculas(pelicula);
                for (i = 0; i < listaPeliculas.Count; i++)
                {
                    nombres.Add(listaPeliculas[i].NombreP);
                    idPe.Add(listaPeliculas[i].IdP);
                }
                DWPelicula.DataSource = nombres;
                DWPelicula.DataBind();
                DWPelicula.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            }

            if (DWPelicula.Items.Count == 1)
            {
                Btn_Insertar1.Visible = false;
                Err1.ForeColor = Color.Red;
                Err1.Visible = true;
                Err1.Text = "No hay suficientes peliculas/actores";
            }
        }
    }
}