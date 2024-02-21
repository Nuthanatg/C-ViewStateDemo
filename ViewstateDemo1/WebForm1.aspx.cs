using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//part-3 asp.net beniger
namespace ViewstateDemo1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //1st webform1.aspx
        //int ClicksCount = 0;
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {
        //        TextBox1.Text = "0";
        //    }
        //}

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    ClicksCount = ClicksCount + 1;

        //    TextBox1.Text = ClicksCount.ToString();
        //}

        int ClicksCount = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["Clicks"] != null)//"Clicks" is ViewState variable
            {
                ClicksCount = (int)ViewState["Clicks"] + 1;
            }
            TextBox1.Text = ClicksCount.ToString();
            ViewState["Clicks"] = ClicksCount;
        }

        ///or
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    ViewState["Clicks"] = ClicksCount;
        //    TextBox1.Text = ClicksCount.ToString();
        //}

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    ClicksCount = (int)ViewState["Clicks"] + 1;
        //    TextBox1.Text = ClicksCount.ToString();
        //    ViewState["Clicks"] = ClicksCount;
        //}
    }
}