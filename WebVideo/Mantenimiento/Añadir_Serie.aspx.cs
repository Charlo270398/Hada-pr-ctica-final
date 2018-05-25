using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAD;
using Clases.CAD;
using Clases.EN;
using System.Drawing;
using System.Globalization;

namespace WebVideo.Mantenimiento
{
    public partial class Añadir_Serie : System.Web.UI.Page
    {
        serieCAD s = new serieCAD();
        serieEN serie = new serieEN();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Insertar_Click(object sender, EventArgs e)
        {

            if (titulo_textBox.Text != "" && sinopsis_textBox.Text != "" && estreno_textBox.Text != "" && alquiler_textBox.Text != "" && compra_textBox.Text != "" && imagen_textBox.Text != "")
            {
                try
                {
                    float precioC = float.Parse(compra_textBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                    float precioA = float.Parse(alquiler_textBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                    serie = new serieEN(-1, titulo_textBox.Text, estreno_textBox.Text, sinopsis_textBox.Text, precioC, precioA, imagen_textBox.Text);
                    serie.anyadirSerie();
                    Err.Text = "AÑADIDO CORRECTAMENTE";
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
            else
            {
                Err.Text = "*Campos vacíos";
                Err.Visible = true;
                Err.ForeColor = Color.Red;
            }
        }
    }
}