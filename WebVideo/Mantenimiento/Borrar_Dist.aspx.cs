using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAD;
using System.Drawing;
using System.Data;


namespace WebVideo.Mantenimiento
{
    public partial class Borrar_Dist : System.Web.UI.Page
    {
        DistribuidoraCAD dist = new DistribuidoraCAD();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Borrar_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text != "")
            {
                int id;
                int.TryParse(TextBox1.Text, out id);
                try
                {
                    dist.borrarDistribuidora(id);
                    Err.Visible = true;
                    Err.ForeColor = Color.Green;
                    Err.Text = "DISTRIBUIDORA BORRADA";

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