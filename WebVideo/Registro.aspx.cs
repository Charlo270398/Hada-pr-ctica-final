using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAD;
using Clases.EN;

namespace WebVideo
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
           
        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {

        }

  

     
        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }
        
      
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        protected void DWPais_Init(object sender, EventArgs e)
        {
            if (DWPais != null)
            {
                paisCAD pais = new paisCAD();

                DWPais.DataSource = pais.mostrarListaPaises() ;
                DWPais.DataBind();
                DWPais.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

            }

        }

        protected void BTN_CREAR(object sender, EventArgs e)
        {
            Text_Email.BorderColor = Color.Green;
            Text_Cnt.BorderColor = Color.Green;
            Text_nom.BorderColor = Color.Green;
            Text_Rcnt.BorderColor = Color.Green;
            Text_ap.BorderColor = Color.Green;
            DWPais.BorderColor = Color.Green;
            Terminos.BackColor = Color.Gray;

            bool correcto = true;

            if(Text_Email.Text == "")
            {
                correcto = false;
                Text_Email.BorderColor = Color.Red;
            }
            if (Text_Cnt.Text == "")
            {
                correcto = false;
                Text_Cnt.BorderColor = Color.Red;
            }
            if (Text_nom.Text == "")
            {
                correcto = false;
                Text_nom.BorderColor = Color.Red;
            }
            if (Text_Rcnt.Text == "")
            {
                correcto = false;
                Text_Rcnt.BorderColor = Color.Red;
            }
            if (Text_ap.Text == "")
            {
                correcto = false;
                Text_ap.BorderColor = Color.Red;
            }
            if(DWPais.SelectedItem.ToString() == "[Seleccionar]")
            {
                correcto = false;
                DWPais.BorderColor = Color.Red;  
                
            }
            if (!Terminos.Checked)
            {
                correcto = false;
                Terminos.BackColor = Color.Red;
            }

            if (correcto)
            {
                paisCAD pais = new paisCAD();
                usuarioEN user = new usuarioEN();
                user.Apellidos = Text_ap.Text;
                user.Contrasenya = Text_Cnt.Text;
                user.Email = Text_Email.Text;
                user.Nombre = Text_nom.Text;
                user.Pais = pais.mostrarIdPais(DWPais.SelectedItem.ToString()).IdPais;
                DateTime fecha = DateTime.Now;
                user.FechaA = fecha.Date.ToString();       
                user.anyadirUsuario();
                
            }

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void IN_EMAIL (object sender, EventArgs e)
        {

        }

        protected void Email_Cambio(object sender, EventArgs e)
        {
           
        }
    }
}