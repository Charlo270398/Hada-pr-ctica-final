using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAD;
using Clases.EN;
using System.Drawing;

namespace WebVideo.Mantenimiento
{
    public partial class Añadir_Saga : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Añadir_Click(object sender, EventArgs e)
        {
            Err.Visible = false;
            Err0.Visible = false;
            ErrInsert.Visible = false;

            if (TextBox1.Text == "" && TextBox2.Text == "")
            {
                Err.Text = "*Campo vacío";
                Err.ForeColor = Color.Red;
                Err.Visible = true;
            }
            else if (TextBox1.Text != "" && TextBox2.Text == "")
            {
                Err0.Text = "*Campo vacío";
                Err0.ForeColor = Color.Red;
                Err0.Visible = true;
            }
            else if (TextBox1.Text == "" && TextBox2.Text != "")
            {
                Err.Text = "*Campo vacío";
                Err.ForeColor = Color.Red;
                Err.Visible = true;
                Err0.Text = "*Campo vacío";
                Err0.ForeColor = Color.Red;
                Err0.Visible = true;
            }
            else{
                try
                {
                    sagaEN saga = new sagaEN(-1, TextBox1.Text, TextBox2.Text);
                    saga.anyadirSaga();
                    ErrInsert.Text = "AÑADIDA CORRECTAMENTE";
                    ErrInsert.ForeColor = Color.Green;
                    ErrInsert.Visible = true;
                }
                catch(Exception ex)
                {
                    ErrInsert.Text = ex.Message;
                    ErrInsert.ForeColor = Color.Red;
                    ErrInsert.Visible = true;
                }
            }
        }
    }
}