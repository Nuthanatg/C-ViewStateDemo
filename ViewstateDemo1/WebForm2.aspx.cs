﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//part-3 asp.net beniger
namespace ViewstateDemo1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }
        protected void Buttonl_Click(object sender, EventArgs e)
        {
            int ClicksCount = Convert.ToInt32(TextBox1.Text) + 1;
            TextBox1.Text = ClicksCount.ToString();
        }
    }
}