using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Setting expiring date and time of the cookies
            Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "";
            // --------------- Adding Coockies ---------------------//
            if (apple.Checked)
                Response.Cookies["computer"]["apple"] = "apple";
            if (dell.Checked)
                Response.Cookies["computer"]["dell"] = "dell";
            if (lenovo.Checked)
                Response.Cookies["computer"]["lenovo"] = "lenovo";
            if (acer.Checked)
                Response.Cookies["computer"]["acer"] = "acer";
            if (sony.Checked)
                Response.Cookies["computer"]["sony"] = "sony";
            if (wipro.Checked)
                Response.Cookies["computer"]["wipro"] = "wipro";
            // --------------- Fetching Cookies -----------------------//
            if (Request.Cookies["computer"].Values.ToString() != null)
            {
                if (Request.Cookies["computer"]["apple"] != null)
                    Label2.Text += Request.Cookies["computer"]["apple"] + " ";
                if (Request.Cookies["computer"]["dell"] != null)
                    Label2.Text += Request.Cookies["computer"]["dell"] + " ";
                if (Request.Cookies["computer"]["lenovo"] != null)
                    Label2.Text += Request.Cookies["computer"]["lenovo"] + " ";
                if (Request.Cookies["computer"]["acer"] != null)
                    Label2.Text += Request.Cookies["computer"]["acer"] + " ";
                if (Request.Cookies["computer"]["sony"] != null)
                    Label2.Text += Request.Cookies["computer"]["sony"] + " ";
                if (Request.Cookies["computer"]["wipro"] != null)
                    Label2.Text += Request.Cookies["computer"]["wipro"] + " ";
            }
            else Label2.Text = "Please select your choice";
            Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);
        }

        protected void lenovo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
