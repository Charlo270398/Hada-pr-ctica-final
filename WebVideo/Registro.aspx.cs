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
            EmailErr.Visible = false;
            CntErr.Visible = false;
            NombreErr.Visible = false;
            RcntErr.Visible = false;
            PaisErr.Visible = false;
            ApellidosErr.Visible = false;
            TerminosErr.Visible = false;

            if (Text_Email.Text == "")
            {
                correcto = false;
                Text_Email.BorderColor = Color.Red;
                EmailErr.Visible = true;
            }
            if (Text_Cnt.Text == "")
            {
                correcto = false;
                Text_Cnt.BorderColor = Color.Red;
                CntErr.Visible = true;
            }
            if (Text_nom.Text == "")
            {
                correcto = false;
                Text_nom.BorderColor = Color.Red;
                NombreErr.Visible = true;
            }

            if (Text_Rcnt.Text == "")
            {
                correcto = false;
                Text_Rcnt.BorderColor = Color.Red;
                RcntErr.Visible = true;
            }
            else if (Text_Rcnt.Text != Text_Cnt.Text)
            {
                RcntErr.Text = "*Contraseña distinta";
                correcto = false;
                Text_Rcnt.BorderColor = Color.Red;
                RcntErr.Visible = true;
            }

            if (Text_ap.Text == "")
            {
                correcto = false;
                Text_ap.BorderColor = Color.Red;
                ApellidosErr.Visible = true;
            }
            if(DWPais.SelectedItem.ToString() == "[Seleccionar]")
            {
                correcto = false;
                DWPais.BorderColor = Color.Red;
                PaisErr.Visible = true;
                
            }
            if (!Terminos.Checked)
            {
                correcto = false;
                TerminosErr.Visible = true;
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

        protected void Text_Email_DataBinding(object sender, EventArgs e)
        {
           
        }
    }
}