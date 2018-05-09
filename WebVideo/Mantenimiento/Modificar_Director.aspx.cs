using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAD;
using System.Drawing;
using Clases.EN;

namespace WebVideo.Mantenimiento
{
    public partial class Modificar_Director : System.Web.UI.Page
    {
        directorCAD d = new directorCAD();
        List<directorEN> listaDir = new List<directorEN>();
        directorEN director = new directorEN();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DWDirector_Init(object sender, EventArgs e)
        {
            int i;
            if (DWDirector != null)
            {
                director.Nombre = "%";
                List<String> nombres = new List<string>();
                listaDir = d.mostrarListaDirectores(director);
                for (i = 0; i < listaDir.Count; i++)
                {
                    nombres.Add(listaDir[i].Nombre + " " + listaDir[i].Apellidos);
                }
                DWDirector.DataSource = nombres;
                DWDirector.DataBind();
                DWDirector.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            }

            if (DWDirector.Items.Count == 1)
            {
                Btn_Modificar1.Visible = false;
                ErrM.ForeColor = Color.Red;
                ErrM.Visible = true;
                ErrM.Text = "No quedan directores";
            }

        }

        protected void DWPais_Init(object sender, EventArgs e)
        {
            if (DWPais != null)
            {
                paisCAD pais = new paisCAD();

                DWPais.DataSource = pais.mostrarListaPaises();
                DWPais.DataBind();
                DWPais.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

            }
        }

        protected void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (DWDirector.Items.Count == 1)
            {
                Btn_Modificar1.Visible = false;
                ErrM.ForeColor = Color.Red;
                ErrM.Visible = true;
                ErrM.Text = "No quedan directores";
            }
            else
            {
                if (DWDirector.SelectedItem.ToString() != "[Seleccionar]" && DWPais.SelectedItem.ToString() != "[Seleccionar]")
                {
                    if (TextBox1.Text != "" && TextBox2.Text != "")
                    {
                        try
                        {
                            director = new directorEN(TextBox1.Text, TextBox2.Text, DWPais.SelectedItem.ToString());
                            bool stop = false;
                            for (int i = 0; i < listaDir.Count && !stop; i++)
                            {
                                if (listaDir[i].Nombre + " " + listaDir[i].Apellidos == DWDirector.SelectedItem.ToString())
                                {
                                    director.IdD = listaDir[i].IdD;
                                    stop = true;
                                }
                            }
                            director.modificarDirector();
                            ErrM.ForeColor = Color.Green;
                            ErrM.Visible = true;
                            ErrM.Text = "MODIFICADO CORRECTAMENTE";


                            DWDirector_Init(sender, e);
                        }
                        catch (Exception ex)
                        {
                            ErrM.ForeColor = Color.Red;
                            ErrM.Visible = true;
                            ErrM.Text = ex.Message;
                        }
                    }
                    else
                    {
                        ErrM.ForeColor = Color.Red;
                        ErrM.Visible = true;
                        ErrM.Text = "*Quedan campos vacíos";
                    }
                }
            }

        }
    }
}