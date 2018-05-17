using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebVideo
{
    public partial class Pagina_Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void err_Init(object sender, EventArgs e)
        {
            err.Text = Request.QueryString["err"];
        }
    }
}