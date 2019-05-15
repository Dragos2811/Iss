using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
public partial class login : System.Web.UI.Page
{
    SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDb)\LocalIss;Initial Catalog=Iss; Integrated Security = true;");

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void signInBtn_Click(object sender, EventArgs e)
    {
        if (sqlCon.State == ConnectionState.Closed)
            sqlCon.Open();
        SqlCommand sqlCmd = new SqlCommand("Login", sqlCon);
        sqlCmd.CommandType = CommandType.StoredProcedure;
        sqlCmd.Parameters.AddWithValue("@email", email.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@password", password.Text.Trim());
        SqlDataReader rd = sqlCmd.ExecuteReader();
        if (rd.HasRows)
        {
            rd.Read();
            msgLabel.ForeColor = System.Drawing.Color.Green;
            Session["username"] = email.Text.Trim();
            HttpContext.Current.Response.Redirect("~");
            msgLabel.Text = "Logare cu succes!";

        }
        else
        {
            msgLabel.ForeColor = System.Drawing.Color.Tomato;
            msgLabel.Text = "Parola si emailul nu corespund!";
        }

        sqlCon.Close();
        email.Text = "";
        password.Text = "";
    }
}