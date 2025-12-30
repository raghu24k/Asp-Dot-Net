using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoanMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
            Response.Redirect("LoginPage.aspx");
        lbluser.Text = Session["user"].ToString();

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateApplication.aspx");
    }

    protected void btnLogou_Click(object sender, EventArgs e)
    {
        Session["user"] = null;
        Response.Redirect("LoginPage.aspx");

    }

    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");

    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewApplication.aspx");

    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("RemoveApplication.aspx");

    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewApplication.aspx");

    }
}
