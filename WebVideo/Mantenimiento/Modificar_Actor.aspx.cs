using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using Clases.EN;
using CAD;

namespace WebVideo.Mantenimiento
{
    public partial class Modificar_Actor : System.Web.UI.Page
    {
        actorEN actor = new actorEN();
        actorCAD a = new actorCAD();
        List<actorEN> listaA = new List<actorEN>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (DWActor.Items.Count == 1)
            {
                Btn_Modificar1.Visible = false;
                ErrM.ForeColor = Color.Red;
                ErrM.Visible = true;
                ErrM.Text = "No quedan actores";
            }
            else
            {
                if (DWActor.SelectedItem.ToString() != "[Seleccionar]" && DWPais.SelectedItem.ToString() != "[Seleccionar]")
                {
                    if (TextBox1.Text != "" && TextBox2.Text != "")
                    {
                        try
                        {
                            string fecha = DWdia.SelectedItem.ToString() + "-" + DWmes.SelectedItem.ToString() + "-" + DWaño.SelectedItem.ToString();
                            actor = new actorEN(-1, TextBox1.Text, TextBox2.Text, fecha, DWPais.SelectedItem.ToString());
                            bool stop = false;
                            for (int i = 0; i < listaA.Count && !stop; i++)
                            {
                                if (listaA[i].Nombre + " " + listaA[i].Apellidos == DWActor.SelectedItem.ToString())
                                {
                                    actor.IdAc = listaA[i].IdAc;
                                    stop = true;
                                }
                            }
                            actor.modificarActor();
                            ErrM.ForeColor = Color.Green;
                            ErrM.Visible = true;
                            ErrM.Text = "MODIFICADO CORRECTAMENTE";


                            DWActor_Init(sender, e);
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

        protected void DWActor_Init(object sender, EventArgs e)
        {
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
                }
                DWActor.DataSource = nombres;
                DWActor.DataBind();
                DWActor.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            }

            if (DWActor.Items.Count == 1)
            {
                Btn_Modificar1.Visible = false;
                ErrM.ForeColor = Color.Red;
                ErrM.Visible = true;
                ErrM.Text = "No quedan actores";
            }

        }

        protected void DWPais_Init(object sender, EventArgs e)
        {
            int i;
            List<int> nums = new List<int>();
            if (DWPais != null)
            {
                paisCAD pais = new paisCAD();

                DWPais.DataSource = pais.mostrarListaPaises();
                DWPais.DataBind();
                DWPais.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

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