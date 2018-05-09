using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;
using CAD;
using System.Drawing;

namespace WebVideo.Mantenimiento
{
    public partial class Añadir_Director : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void Btn_Añadir_Click(object sender, EventArgs e)
        {
            Err.Visible = false;
            Err0.Visible = false;
            Err1.Visible = false;

            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                if (DWPais.SelectedItem.ToString() != "[Seleccionar]")
                {
                    try
                    {
                        paisCAD p = new paisCAD();
                        directorEN director = new directorEN(TextBox1.Text, TextBox2.Text, DWPais.SelectedItem.ToString());
                        director.anyadirDirector();
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