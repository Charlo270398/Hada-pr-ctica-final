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
    public partial class Añadir_Actor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                for(i = 1; i<32; i++)
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

        protected void Btn_Añadir_Click(object sender, EventArgs e)
        {
            
            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                if (DWPais.SelectedItem.ToString() != "[Seleccionar]")
                {
                    try
                    {
                        string fecha = DWdia.SelectedItem.ToString() + "-" + DWmes.SelectedItem.ToString() + "-" + DWaño.SelectedItem.ToString();
                        paisCAD p = new paisCAD();
                        actorEN actor = new actorEN(-1, TextBox1.Text, TextBox2.Text, fecha, DWPais.SelectedItem.ToString());
                        actor.anyadirActor();
                        Err1.Text = "AÑADIDO CORRECTAMENTE";
                        Err1.Visible = true;
                        Err1.ForeColor = Color.Green;

                    }
                    catch (Exception ex)
                    {
                        Err1.ForeColor = Color.Red;
                        Err1.Text = ex.Message;
                        Err1.Visible = true;
                    }
                }
            }
            else if (TextBox1.Text == "" && TextBox2.Text != "")
            {
                Err.Visible = true;
                Err.ForeColor = Color.Red;
                Err.Text = "*Campo vacío";
            }
            else if (TextBox1.Text != "" && TextBox2.Text == "")
            {
                Err0.Visible = true;
                Err0.ForeColor = Color.Red;
                Err0.Text = "*Campo vacío";

            }
            else
            {
                Err.Visible = true;
                Err.ForeColor = Color.Red;
                Err.Text = "*Campo vacío";
                Err0.Visible = true;
                Err0.ForeColor = Color.Red;
                Err0.Text = "*Campo vacío";
            }

        }
    }
}