using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : System.Web.UI.Page
{
    SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDb)\LocalIss;Initial Catalog=Iss; Integrated Security = true;");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void signUpBtn_Click(object sender, EventArgs e)
    {
        msgLabel.Text = "";
        if (sqlCon.State == ConnectionState.Closed)
            sqlCon.Open();
        SqlCommand sqlCmd = new SqlCommand("CreateUser",sqlCon);
        sqlCmd.CommandType = CommandType.StoredProcedure;
        sqlCmd.Parameters.AddWithValue("@email", email.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@password", password.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@name",name.Text.Trim());
        try
        {
            sqlCmd.ExecuteNonQuery();
            HttpContext.Current.Response.Redirect("~/login.aspx");
        }
        catch
        {
            msgLabel.Text = "Email already exists!";
        }
        sqlCon.Close();
        email.Text = "";
        password.Text = "";
        name.Text = "";
    }
}