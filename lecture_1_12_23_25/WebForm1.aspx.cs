using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;

namespace lecture_1_12_23_25
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label2.Text = "You selected: " + Calendar1.SelectedDate.ToShortDateString();    

            Label4.Text = "Date of Birth: " + Calendar1.SelectedDate.ToShortDateString();   

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //FileUpload1.SaveAs(Server.MapPath("~/") + FileUpload1.FileName);
            //Label5.Text = "File uploaded to: " + Server.MapPath("~/") + FileUpload1.FileName;

            string files = FileUpload1.FileName;
            string path = Server.MapPath("~/FILES/") + files;
            FileUpload1.SaveAs(path);
            //Response.Redirect("WebForm1.aspx");
            Label5.Text = "File uploaded to: ";
        }

        protected void button5_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           MultiView1.ActiveViewIndex = 1;
        }

        protected void prebtn_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            //Wizard1.ActivateIndex = 0;
        }
    }
}