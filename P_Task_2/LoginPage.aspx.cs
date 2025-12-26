using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1 == null) ;
        {
            Session["user"] = TextBox1.Text;
            Response.Redirect("HomePage.aspx");
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}