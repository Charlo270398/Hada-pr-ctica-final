using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases.EN;
using System.Drawing;

namespace WebVideo.Mantenimiento
{
    public partial class Añadir_Dist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Borrar_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text != "")
            {
                distribuidoraEN distribuidora = new distribuidoraEN(-1, TextBox1.Text);
                try
                {
                    distribuidora.anyadirDistribuidora();
                    Err.Visible = true;
                    Err.ForeColor = Color.Green;
                    Err.Text = "DISTRIBUIDORA AÑADIDA";

                }
                catch (Exception ex)
                {
                    Err.Visible = true;
                    Err.ForeColor = Color.Red;
                    Err.Text = ex.Message;
                }
            }
            else
            {
                Err.Visible = true;
                Err.ForeColor = Color.Red;
                Err.Text = "*Campo vacío";
            }

        }
    }
}