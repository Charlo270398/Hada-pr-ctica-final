﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebVideo.Series
{
    public partial class Series_index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageSerie1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Series_individual.aspx");
        }
    }
}