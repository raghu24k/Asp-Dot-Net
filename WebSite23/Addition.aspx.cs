using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Addition : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnadd_Click(object sender, EventArgs e)
    {
        int num1 = Convert.ToInt32(txtbox1.Text);
        int num2 = Convert.ToInt32(txtbox2.Text);
        int r = num1 + num2;
        lblresult.Text =r.ToString();
       
    }

    protected void btnreset_Click(object sender, EventArgs e)
    {
        txtbox1.Text = "";
        txtbox2.Text = "";
        lblresult.Text = "";
    }

    protected void btnsub_Click(object sender, EventArgs e)
    {
        int num1 = Convert.ToInt32(txtbox1.Text);
        int num2 = Convert.ToInt32(txtbox2.Text);
        int r = num1 - num2;
        lblresult.Text = r.ToString();
    }

    protected void btnmulti_Click(object sender, EventArgs e)
    {
        int num1 = Convert.ToInt32(txtbox1.Text);
        int num2 = Convert.ToInt32(txtbox2.Text);
        int r = num1 * num2;
        lblresult.Text = r.ToString();
    }

    protected void btndiv_Click(object sender, EventArgs e)
    {
        int num1 = Convert.ToInt32(txtbox1.Text);
        int num2 = Convert.ToInt32(txtbox2.Text);
        int r = num1 / num2;
        lblresult.Text = r.ToString();
    }
}