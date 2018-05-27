using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;
using System.Drawing;
using System.Text;
using System.Security.Cryptography;

namespace WebVideo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["user_session_data"] = null;
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

        protected void BTN_LOGIN(object sender, EventArgs e)
        {
            try
            {
                if (Text_Email.Text != "" && Text_Pass.Text != "")
                {
                    string passw = CalculateMD5Hash(Text_Pass.Text);
                    usuarioEN usuario = new usuarioEN(Text_Email.Text, passw); //Buscamos el usuario que introducimos para iniciar sesion
                    if (usuario.existe())
                    {
                        usuario.cargarUsuario();
                        if (usuario.Contrasenya == passw)
                        {
                            Session["user_session_data"] = usuario;
                            Response.Redirect("Area_Cliente/Menu_Cliente.aspx");
                        }
                        else
                        {
                            Err.ForeColor = Color.Red;
                            Err.Text = "*Contraseña incorrecta";
                            Err.Visible = true;
                        }
                    }
                    else
                    {
                        Err.ForeColor = Color.Red;
                        Err.Text = "*Email inexistente";
                        Err.Visible = true;
                    }
                }
                else
                {
                    Err.ForeColor = Color.Red;
                    Err.Text = "*Quedan campos vacíos";
                    Err.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Err.ForeColor = Color.Red;
                Err.Text = ex.Message;
                Err.Visible = true;
            }
        }
    }
}