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
    public partial class Modificar_Dist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Modificar_Click(object sender, EventArgs e)
        {
            Err.Visible = false;
            Err0.Visible = false;
            Err1.Visible = false;

            if (TextBox1.Text!="" && TextBox2.Text != "")
            {
                int id;
                int.TryParse(TextBox1.Text, out id);
                try
                {
                    distribuidoraEN distribuidora = new distribuidoraEN(id, TextBox2.Text);
                    distribuidora.modificarDistribuidora();
                    Err1.Text = "MODIFICACIÓN REALIZADA";
                    Err1.Visible = true;
                    Err1.ForeColor = Color.Green;

                }
                catch(Exception ex)
                {
                    Err1.ForeColor = Color.Red;
                    Err1.Text = ex.Message;
                    Err1.Visible = true;
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