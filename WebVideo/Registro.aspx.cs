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
using Clases.EN;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace WebVideo
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        public string CalculateMD5Hash(string input)

        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
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
            try
            {
                if (DWPais != null)
                {
                    paisEN pais = new paisEN();
                    Session["user_session_data"] = null;
                    DWPais.DataSource = pais.mostrarListaNombresPaises();
                    DWPais.DataBind();
                    DWPais.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
                }
            }catch(Exception ex)
            {
                Response.Redirect("Pagina_Error.aspx?err=" + ex.Message);
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
                EmailErr.Text = "*Campo vacío.";
                correcto = false;
                Text_Email.BorderColor = Color.Red;
                EmailErr.Visible = true;
            }
            else if (!Text_Email.Text.Contains("@gmail.")&&!Text_Email.Text.Contains("@hotmail.")&& !Text_Email.Text.Contains("@yahoo."))
            {
                correcto = false;
                EmailErr.Text = "*Dominio incorrecto. Pruebe con @gmail,@hotmail o @yahoo.";
                Text_Email.BorderColor = Color.Red;
                EmailErr.Visible = true;
            }

            if (Text_Cnt.Text == "")
            {
                CntErr.Text = "*Campo vacío";
                correcto = false;
                Text_Cnt.BorderColor = Color.Red;
                CntErr.Visible = true;
            }
            else
            {
                if (Text_Cnt.Text.Length < 7)
                {
                    correcto = false;
                    CntErr.Text = "*La contraseña debe tener como mínimo 7 caracteres";
                    Text_Cnt.BorderColor = Color.Red;
                    CntErr.Visible = true;
                }
            }

            if (Text_nom.Text == "")
            {
                correcto = false;
                Text_nom.BorderColor = Color.Red;
                NombreErr.Visible = true;
            }

            if (Text_Rcnt.Text == "")
            {
                RcntErr.Text = "*Campo vacío.";
                correcto = false;
                Text_Rcnt.BorderColor = Color.Red;
                RcntErr.Visible = true;
            }
            else if (Text_Rcnt.Text != Text_Cnt.Text && Text_Rcnt.Text!="")
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
                string hash = CalculateMD5Hash(Text_Cnt.Text);
                paisEN pais = new paisEN(DWPais.SelectedItem.ToString());
                usuarioEN user = new usuarioEN();
                user.Apellidos = Text_ap.Text;
                user.Contrasenya = hash;
                user.Email = Text_Email.Text;
                user.Nombre = Text_nom.Text;
                user.Pais = pais.mostrarIdPais().IdPais;
                DateTime fecha = DateTime.Now;
                user.FechaA = fecha.Date.ToString();
                try
                {
                    SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
                    cliente.EnableSsl = true;
                    cliente.Credentials = new System.Net.NetworkCredential("hookinVideoclub@gmail.com", "hookin123");
                    string contenido = "Hola, " + user.Nombre + ". Le informamos de que su registro se ha completado correctamente.\n";
                    contenido += "Fecha del registro: " + (DateTime.Now).ToString();
                    contenido += "\nPuede consultar su cuenta en la aplicación de Hookin.\n\n";
                    contenido += "El equipo de Cuentas de Hookin";
                    MailMessage mail = new MailMessage("hookinVideoclub@gmail.com", user.Email, "¡Bienvenido a Hookin!", contenido);
                    user.anyadirUsuario();
                    cliente.Send(mail);
                    Session["user_session_data"] = user;
                    Response.Redirect("Area_Cliente/Menu_Cliente.aspx");
                }
                catch(Exception ex)
                {
                    EmailErr.Visible = true;
                    EmailErr.Text = ex.Message;
                }
                
            }
            else
            {
                EmailErr.Visible = false;
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