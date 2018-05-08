using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAD;
using Clases.EN;

namespace WebVideo.Mostrar
{
    public partial class Mostrar_Director : System.Web.UI.Page
    {

        directorEN director = new directorEN();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Nombre_Init(object sender, EventArgs e)
        {
            int id;
            int.TryParse(Request.QueryString["id"], out id);
            director.IdD = id;
            directorCAD aux = new directorCAD();

            director = aux.mostrarDirector(director);

            NombreText.Text = director.Nombre;
            ApellidosText.Text = director.Apellidos;
            nombrePais.Text = director.Nacionalidad;

        }

        protected void Btn_PeliculaC(object sender, EventArgs e)
        {

        }
    }
}