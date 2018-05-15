﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.CAD;
using Clases.EN;
using CAD;

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
                serieCAD p = new serieCAD();
                serie = new serieEN(-1, DWSeries.SelectedItem.ToString());
                serie = p.mostrarSerie(serie);
                tituloBox.Text = serie.Titulo;
                sinopsisBox.Text = serie.Sinopsis;
                fechaBox.Text = serie.FechaE;
                compraBox.Text = serie.PrecioC.ToString();
                alquilerBox.Text = serie.PrecioA.ToString();
                imgBox.Text = serie.Imagen;
                //tituloBox.Text
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
    }
}