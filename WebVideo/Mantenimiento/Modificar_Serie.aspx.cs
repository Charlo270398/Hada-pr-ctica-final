using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;
using CAD;
using System.Globalization;

namespace WebVideo.Mantenimiento
{
    public partial class Modificar_Serie : System.Web.UI.Page
    {
        serieEN serie = new serieEN();
        List<serieEN> listaSeries = new List<serieEN>();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (DWSeries.SelectedItem.ToString() != "[Seleccionar]")
            {
                if (fechaBox.Text.Length == 0 && tituloBox.Text.Length == 0 && sinopsisBox.Text.Length == 0 && compraBox.Text.Length == 0 && alquilerBox.Text.Length == 0 && imgBox.Text.Length == 0)
                {
                    serieCAD p = new serieCAD();
                    serie = new serieEN(-1, DWSeries.SelectedItem.ToString());
                    serie = p.mostrarSerie(serie); 
                    tituloBox.Text = serie.Titulo;
                    sinopsisBox.Text = serie.Sinopsis;
                    fechaBox.Text = serie.FechaE;
                    compraBox.Text = serie.PrecioC.ToString();
                    alquilerBox.Text = serie.PrecioA.ToString();
                    imgBox.Text = serie.Imagen;
                }
            }
            else
            {
                tituloBox.Text = "";
                sinopsisBox.Text = "";
                fechaBox.Text = "";
                compraBox.Text = "";
                alquilerBox.Text = "";
                imgBox.Text = "";
            }
            Btn_modificar.Visible = true;
            Err.Visible = false;
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
                Btn_modificar.Visible = false;
                Err.ForeColor = Color.Red;
                Err.Visible = true;
                Err.Text = "No hay series en la Base de Datos";
            }
        }

        protected void Btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                serieCAD p = new serieCAD();
                serie = new serieEN(-1, DWSeries.SelectedItem.ToString());
                serie = p.mostrarSerie(serie);
                if (tituloBox.Text.Length == 0 || sinopsisBox.Text.Length == 0 || fechaBox.Text.Length == 0 || compraBox.Text.Length == 0 || alquilerBox.Text.Length == 0 || imgBox.Text.Length == 0)
                {
                    Btn_modificar.Visible = true;
                    Err.ForeColor = Color.Red;
                    Err.Visible = true;
                    Err.Text = "*No puedes dejar ningún campo en blanco";
                }
                else if (tituloBox.Text == serie.Titulo && sinopsisBox.Text == serie.Sinopsis && fechaBox.Text == serie.FechaE && compraBox.Text == serie.PrecioC.ToString() && alquilerBox.Text == serie.PrecioA.ToString() && imgBox.Text == serie.Imagen)
                {
                    Btn_modificar.Visible = true;
                    Err.ForeColor = Color.Red;
                    Err.Visible = true;
                    Err.Text = "*No has realizado ningún cambio";
                }
                else
                {
                    serie.Titulo = tituloBox.Text;
                    serie.Sinopsis = sinopsisBox.Text;
                    serie.FechaE = fechaBox.Text;
                    serie.PrecioA = float.Parse(alquilerBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                    serie.PrecioC = float.Parse(compraBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                    serie.Imagen = imgBox.Text;
                    serie.modificarSerie();
                    Btn_modificar.Visible = false;
                    Err.ForeColor = Color.Green;
                    Err.Visible = true;
                    Err.Text = "Has realizado los cambios correctamente :)";
                }
            }catch(Exception ex)
            {
                Err.ForeColor = Color.Red;
                Err.Visible = true;
                Err.Text = ex.Message;
            }
        }
    }
}