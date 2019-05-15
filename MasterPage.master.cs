using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null) {
            Console.Write(Session["username"]);
            loginBtn.Visible = false;
            hello.Text += Session["username"];
            hello.Visible = true;
            }
        else
        {
            hello.Visible = false;
            loginBtn.Visible = true;
        }
    }
}
