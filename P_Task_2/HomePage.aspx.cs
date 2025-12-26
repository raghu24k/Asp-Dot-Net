using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
            Response.Redirect("LoginPage.aspx");
        lbluser.Text = Session["user"].ToString();

    }

    protected void btnLogou_Click(object sender, EventArgs e)
    {
        Session["user"] = null;
        Response.Redirect("LoginPage.aspx");
    }
}