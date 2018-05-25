using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;

namespace WebVideo
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected static List<int> listaID = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void Btn_PeliculaC(object sender, EventArgs e)
        {
            if (PeliculaBox.Text != "")
            {
                listaID.Clear();
                peliculaEN peli = new peliculaEN(-1, PeliculaBox.Text);
                List<string> ListaNombres = new List<string>();
                DWPeliculas.Visible = true;
                Btn_Pelicula2.Visible = true;
                List<peliculaEN> p = peli.mostrarListaPeliculas();
                for (int i = 0; i < p.Count; i++)
                {
                    ListaNombres.Add(p[i].NombreP);
                    listaID.Add(p[i].IdP);
                }
    
                DWPeliculas.DataSource = ListaNombres;
                DWPeliculas.DataBind();
                DWPeliculas.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
                if (DWPeliculas.Items.Count == 1)
                {
                    ErrPelicula.Visible = true;
                    ErrPelicula.Text = "*Búsqueda vacía. Introduzca el carácter '%' para ver todos los títulos";
                    DWPeliculas.Visible = false;
                    Btn_Pelicula2.Visible = false;
                }
                else
                {
                    ErrPelicula.Visible = false;
                }
            }
            else{
                ErrPelicula.Visible = true;
                ErrPelicula.Text = "*Campo vacío";
            }

            ErrSerie.Visible = false;
            ErrDistribuidora.Visible = false;
            ErrSerie.Visible = false;
            ErrDirector.Visible = false;
            DWActor.Visible = false;
            DWDistribuidora.Visible = false;
            DWSeries.Visible = false;
            DWDirector.Visible = false;
            Btn_Actor2.Visible = false;
            Btn_Distribuidora2.Visible = false;
            Btn_Serie2.Visible = false;
            Btn_Director2.Visible = false;
        }

        protected void Btn_SerieC(object sender, EventArgs e)
        {
            if (SerieBox.Text != "")
            {
                listaID.Clear();
                serieCAD serie = new serieCAD();
                serieEN nombre = new serieEN(-1, SerieBox.Text);
                List<string> ListaNombres = new List<string>();
                DWSeries.Visible = true;
                Btn_Serie2.Visible = true;
                List<serieEN> p = serie.mostrarListaSeries(nombre);
                for (int i = 0; i < p.Count; i++)
                {
                    ListaNombres.Add(p[i].Titulo);
                    listaID.Add(p[i].IdS);
                }
                DWSeries.DataSource = ListaNombres;
                DWSeries.DataBind();
                DWSeries.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
                if (DWSeries.Items.Count == 1)
                {
                    ErrSerie.Visible = true;
                    ErrSerie.Text = "*Búsqueda vacía. Introduzca el carácter '%' para ver todos los títulos";
                    DWSeries.Visible = false;
                    Btn_Serie2.Visible = false;
                }
                else
                {
                    ErrSerie.Visible = false;
                }
            }
            else
            {
                ErrSerie.Visible = true;
                ErrSerie.Text = "*Campo vacío";
            }
            ErrPelicula.Visible = false;
            ErrDistribuidora.Visible = false;
            ErrPelicula.Visible = false;
            ErrDirector.Visible = false;
            DWActor.Visible = false;
            DWDistribuidora.Visible = false;
            DWPeliculas.Visible = false;
            DWDirector.Visible = false;
            Btn_Actor2.Visible = false;
            Btn_Distribuidora2.Visible = false;
            Btn_Pelicula2.Visible = false;
            Btn_Director2.Visible = false;
        }

        protected void Btn_Serie2C(object sender, EventArgs e)
        {
            if (DWSeries.SelectedItem.ToString() != "[Seleccionar]")
            {
                Response.Redirect("Mostrar/Mostrar_Series.aspx?id=" + listaID[DWSeries.SelectedIndex - 1]);
            }
            else
            {
                ErrSerie.Visible = true;
                ErrSerie.Text = "*Seleccione una Serie";
            }
        }

        protected void Btn_Pelicula2C(object sender, EventArgs e)
        {
            if (DWPeliculas.SelectedItem.ToString() != "[Seleccionar]")
            {
                Response.Redirect("Mostrar/Mostrar_Peliculas.aspx?id=" + listaID[DWPeliculas.SelectedIndex-1]);                             
            }
            else
            {
                ErrPelicula.Visible = true;
                ErrPelicula.Text = "*Seleccione una película";
            }
        }

        protected void Btn_DirectorC(object sender, EventArgs e)
        {
            if (DirectorBox.Text != "")
            {
                listaID.Clear();
                directorEN director = new directorEN();
                director.Nombre = DirectorBox.Text;
                List<string> ListaNombres = new List<string>();
                DWDirector.Visible = true;
                Btn_Director2.Visible = true;
                List<directorEN> d = director.listaDirectoresConcretos();
                for (int i = 0; i < d.Count; i++)
                {
                    ListaNombres.Add(d[i].Nombre + " " + d[i].Apellidos);
                    listaID.Add(d[i].IdD);
                }
                DWDirector.DataSource = ListaNombres.Distinct().ToList();
                DWDirector.DataBind();
                DWDirector.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

                if (DWDirector.Items.Count == 1)
                {
                    ErrDirector.Visible = true;
                    ErrDirector.Text = "*Búsqueda vacía. Introduzca el carácter '%' para ver todos los directores";
                    DWDirector.Visible = false;
                    Btn_Director2.Visible = false;
                }
                else
                {
                    ErrDirector.Visible = false;
                    ErrPelicula.Text = "*Seleccione un director";
                }
            }
            else
            {
                ErrDirector.Visible = true;
                ErrDirector.Text = "*Campo vacío";
            }

            ErrSerie.Visible = false;
            ErrPelicula.Visible = false;
            ErrActor.Visible = false;
            ErrDistribuidora.Visible = false;
            DWActor.Visible = false;
            DWPeliculas.Visible = false;
            DWSeries.Visible = false;
            DWDistribuidora.Visible = false;
            Btn_Actor2.Visible = false;
            Btn_Pelicula2.Visible = false;
            Btn_Serie2.Visible = false;
            Btn_Distribuidora2.Visible = false;
        }


        protected void Btn_Director2C(object sender, EventArgs e)
        {
            if (DWDirector.SelectedItem.ToString() != "[Seleccionar]")
            {
                Response.Redirect("Mostrar/Mostrar_Director.aspx?id=" + +listaID[DWDirector.SelectedIndex - 1]);
            }
            else
            {
                ErrDirector.Visible = true;
            }
        }

        protected void Btn_DistribuidoraC(object sender, EventArgs e)
        {
            if (DistribuidoraBox.Text != "")
            {
                listaID.Clear();
                distribuidoraEN distribuidora = new distribuidoraEN(-1, DistribuidoraBox.Text);
                List<string> ListaNombres = new List<string>();
                DWDistribuidora.Visible = true;
                Btn_Distribuidora2.Visible = true;
                List<distribuidoraEN> d = distribuidora.listaDistribuidoras();
                for (int i = 0; i < d.Count; i++)
                {
                    ListaNombres.Add(d[i].Nombre);
                    listaID.Add(d[i].IdDis);
                }

                DWDistribuidora.DataSource = ListaNombres;
                DWDistribuidora.DataBind();
                DWDistribuidora.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
                if (DWDistribuidora.Items.Count == 1)
                {
                    ErrDistribuidora.Visible = true;
                    ErrDistribuidora.Text = "*Búsqueda vacía. Introduzca el carácter '%' para ver todas las distribuidoras";
                    DWDistribuidora.Visible = false;
                    Btn_Distribuidora2.Visible = false;
                }
                else
                {
                    ErrDistribuidora.Visible = false;
                }
            }
            else
            {
                ErrDistribuidora.Visible = true;
                ErrDistribuidora.Text = "*Campo vacío";
            }

            ErrSerie.Visible = false;
            ErrPelicula.Visible = false;
            ErrActor.Visible = false;
            ErrDirector.Visible = false;
            DWActor.Visible = false;
            DWPeliculas.Visible = false;
            DWSeries.Visible = false;
            DWDirector.Visible = false;
            Btn_Actor2.Visible = false;
            Btn_Pelicula2.Visible = false;
            Btn_Serie2.Visible = false;
            Btn_Director2.Visible = false;

        }
        protected void Btn_Distribuidora2C(object sender, EventArgs e)
        {
            if (DWDistribuidora.SelectedItem.ToString() != "[Seleccionar]")
            {
                Response.Redirect("Mostrar/Mostrar_Distribuidora.aspx?id=" + +listaID[DWDistribuidora.SelectedIndex - 1]);
            }
            else
            {
                ErrDistribuidora.Visible = true;
                ErrDistribuidora.Text = "*Seleccione una distribuidora";
            }

        }

        protected void Button_Actor(object sender, EventArgs e)
        {
            if (ActorBox.Text != "")
            {
                listaID.Clear();
                actorEN actor = new actorEN(-1, ActorBox.Text);
                List<string> ListaNombres = new List<string>();
                DWActor.Visible = true;
                Btn_Actor2.Visible = true;
                List<actorEN> d = actor.listaActores();
                for (int i = 0; i < d.Count; i++)
                {
                    ListaNombres.Add(d[i].Nombre + " " + d[i].Apellidos);
                    listaID.Add(d[i].IdAc);
                }

                DWActor.DataSource = ListaNombres;
                DWActor.DataBind();
                DWActor.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
                if (DWActor.Items.Count == 1)
                {
                    ErrActor.Visible = true;
                    ErrActor.Text = "*Búsqueda vacía. Introduzca el carácter '%' para ver todos los actores";
                    DWActor.Visible = false;
                    Btn_Actor2.Visible = false;
                }
                else
                {
                    ErrActor.Visible = false;
                }
            }
            else
            {
                ErrActor.Visible = true;
                ErrActor.Text = "*Campo vacío";
            }

            ErrSerie.Visible = false;
            ErrPelicula.Visible = false;
            ErrDistribuidora.Visible = false;
            ErrDirector.Visible = false;
            DWDistribuidora.Visible = false;
            DWPeliculas.Visible = false;
            DWSeries.Visible = false;
            DWDirector.Visible = false;
            Btn_Distribuidora2.Visible = false;
            Btn_Pelicula2.Visible = false;
            Btn_Serie2.Visible = false;
            Btn_Director2.Visible = false;

        }

        protected void Btn_Actor2C(object sender, EventArgs e)
        {
            if (DWActor.SelectedItem.ToString() != "[Seleccionar]")
            {
                Response.Redirect("Mostrar/Mostrar_Actor.aspx?id=" + +listaID[DWActor.SelectedIndex - 1]);
            }
            else
            {
                ErrActor.Visible = true;
                ErrActor.Text = "*Seleccione un actor";
            }
        }
    }
}