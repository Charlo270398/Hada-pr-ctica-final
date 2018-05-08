using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAD;
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
                peliculaCAD pelicula = new peliculaCAD();
                peliculaEN nombre = new peliculaEN(-1, PeliculaBox.Text);
                List<string> ListaNombres = new List<string>();
                DWPeliculas.Visible = true;
                Btn_Pelicula2.Visible = true;
                List<peliculaEN> p = pelicula.mostrarListaPeliculas(nombre);
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

        }

        protected void Btn_Pelicula2C(object sender, EventArgs e)
        {
            if (DWPeliculas.SelectedItem.ToString() != "[Seleccionar]")
            {
                Response.Redirect("Peliculas/Mostrar_Peliculas.aspx?id=" + listaID[DWPeliculas.SelectedIndex-1]);                             
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
                directorCAD pelicula = new directorCAD();
                directorEN nombre = new directorEN(DirectorBox.Text);
                List<string> ListaNombres = new List<string>();
                DWDirector.Visible = true;
                Btn_Director2.Visible = true;
                List<directorEN> d = pelicula.mostrarListaDirectores(nombre);
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
            ErrSerie.Visible = false;
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

        protected void Btn_Serie2C(object sender, EventArgs e)
        {

        }

        protected void Btn_Actor2C(object sender, EventArgs e)
        {

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
                DistribuidoraCAD pelicula = new DistribuidoraCAD();
                distribuidoraEN nombre = new distribuidoraEN(-1, DistribuidoraBox.Text);
                List<string> ListaNombres = new List<string>();
                DWDistribuidora.Visible = true;
                Btn_Distribuidora2.Visible = true;
                List<distribuidoraEN> d = pelicula.mostrarListaDistribuidora();
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
                    ErrDistribuidora.Text = "*Búsqueda vacía. Introduzca el carácter '%' para ver todos los títulos";
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
            ErrSerie.Visible = false;
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
                ErrPelicula.Text = "*Seleccione una distribuidora";
            }

        }

        
    }
}