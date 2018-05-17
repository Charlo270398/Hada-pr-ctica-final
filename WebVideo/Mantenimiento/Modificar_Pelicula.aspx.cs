using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;
using System.Drawing;

namespace WebVideo.Mantenimiento
{
    public partial class Modificar_Pelicula : System.Web.UI.Page
    {
        peliculaEN p = new peliculaEN();
        List<string> nombres = new List<string>();
        List<int> ListaIdP = new List<int>();
        List<int> listaIdDir = new List<int>();
        List<int> listaIdDist = new List<int>();
        List<int> listaIdSag = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void DWdia_Init(object sender, EventArgs e)
        {
            int i;
            List<int> nums = new List<int>();
            if (DWdir != null)
            {
                directorEN dir = new directorEN();
                List<directorEN> dirlist = dir.listaDirectores();
                listaIdDir.Clear();
                nombres.Clear();
                for (i = 0; i < dirlist.Count; i++)
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
                distribuidoraEN dist = new distribuidoraEN();
                nombres.Clear();
                listaIdDist.Clear();
                List<distribuidoraEN> dlist = dist.listaDistribuidoras();
                for (i = 0; i < dlist.Count; i++)
                {
                    nombres.Add(dlist[i].Nombre);
                    listaIdDist.Add(dlist[i].IdDis);
                }
                DWdist.DataSource = nombres;
                DWdist.DataBind();
                DWdist.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

            }
            if (DWsaga != null)
            {
                sagaEN s = new sagaEN();
                nombres.Clear();
                listaIdSag.Clear();
                List<sagaEN> slist = s.listaSagas();
                for (i = 0; i < slist.Count; i++)
                {
                    nombres.Add(slist[i].Nombre);
                    listaIdSag.Add(slist[i].IDsaga);
                }
                DWsaga.DataSource = nombres;
                DWsaga.DataBind();
                DWsaga.Items.Insert(0, new ListItem("NINGUNA", "0"));

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

        protected void DWCargar_Init(object sender, EventArgs e)
        {
            if (DWPelicula != null)
            {
                for (int i = 0; i < p.mostrarListaTodasPeliculas().Count; i++)
                {
                    nombres.Add(p.mostrarListaTodasPeliculas()[i].NombreP);
                    ListaIdP.Add(p.mostrarListaTodasPeliculas()[i].IdP);
                }
                DWPelicula.DataSource = nombres;
                DWPelicula.DataBind();
                DWPelicula.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            }

        }

        protected void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (DWPelicula.SelectedItem.ToString() != "[Seleccionar]")
            {
                try
                {
                    p.IdP = p.idPelicula();
                    p.FechaE = DWaño.SelectedItem.ToString() + "-" + DWmes.SelectedItem.ToString() + "-" + DWdia.SelectedItem.ToString();
                    p.NombreP = tituloBox.Text;
                    p.Duracion = int.Parse(duracionBox.Text);
                    p.Sinopsis = sinopsisBox.Text;
                    p.PrecioC = int.Parse(compraBox.Text);
                    p.PrecioA = int.Parse(alquilerBox.Text);
                    p.Imagen = imagenBox.Text;
                    p.Trailer = trailerBox.Text;
                    p.IdDir = listaIdDir[DWdir.SelectedIndex -1];
                    p.IdDist = listaIdDist[DWdist.SelectedIndex-1];
                    p.IdSaga = listaIdSag[DWsaga.SelectedIndex];
                    p.modificarPelicula();
                    Err.Text = "PELICULA MODIFICADA CORRECTAMENTE";
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
        }

        protected void Btn_Cargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DWPelicula.SelectedItem.ToString() != "[Seleccionar]")
                {
                    p.IdP = ListaIdP[DWPelicula.SelectedIndex - 1];
                    p = p.mostrarPelicula();

                    DWdia.SelectedIndex = int.Parse(p.FechaE.Substring(0, 2)) - 1;
                    DWmes.SelectedIndex = int.Parse(p.FechaE.Substring(3).Substring(0, 2)) - 1;
                    DWaño.SelectedIndex = int.Parse(p.FechaE.Substring(6).Substring(0, 5)) - 1900;
                    tituloBox.Text = p.NombreP;
                    duracionBox.Text = p.Duracion.ToString();
                    sinopsisBox.Text = p.Sinopsis;
                    compraBox.Text = (p.PrecioC).ToString();
                    alquilerBox.Text = (p.PrecioA).ToString();
                    imagenBox.Text = p.Imagen.Substring(24);
                    trailerBox.Text = p.Trailer;
                    directorEN dir = new directorEN();
                    dir.IdD = p.IdDir;
                    dir = dir.mostrarDirector();
                    bool stop = false;
                    for (int i = 0; i < DWdir.Items.Count && !stop; i++)
                    {
                        if (DWdir.Items[i].ToString() == dir.Nombre + " " + dir.Apellidos)
                        {
                            DWdir.SelectedIndex = i;
                            stop = true;
                        }
                    }
                    distribuidoraEN dist = new distribuidoraEN();
                    dist.IdDis = p.IdDist;
                    dist = dist.mostrarDistribuidora();
                    stop = false;
                    for (int i = 0; i < DWdist.Items.Count && !stop; i++)
                    {
                        if (DWdist.Items[i].ToString() == dist.Nombre)
                        {
                            DWdist.SelectedIndex = i;
                            stop = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Err.Text = ex.Message;
                Err.Visible = true;
                Err.ForeColor = Color.Red;
            }
        }
    }
}