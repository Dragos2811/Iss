using System;
using System.Data;
using System.Data.SqlClient;
public partial class admin : System.Web.UI.Page
{
    SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDb)\LocalIss;Initial Catalog=Iss; Integrated Security = true;");
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void submitBtn_Click(object sender, EventArgs e)
    {
        msgLabel.Text = "";
        if (title.Text == "")
        {
            msgLabel.Text += "No title<br>";
        }
        if (date.Text == "")
        {
            msgLabel.Text += "No genre<br>";
        }
        if (!fnUpload.HasFile)
        {
            msgLabel.Text += "No file selected<br>";
        }
        else
        {
            if(System.IO.Path.GetExtension(fnUpload.FileName) != ".png")
            {
                msgLabel.Text += "No correct file<br>";
            }
        }
        /*if(msgLabel.Text == "")
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("AddMovie", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@title", title.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@genre", genre.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@imgPath", fnUpload.FileName);
            sqlCmd.Parameters.AddWithValue("@rate", rate.Text.Trim());
            fnUpload.SaveAs(Request.PhysicalApplicationPath + "/UploadFiles/" + fnUpload.FileName);
            sqlCmd.ExecuteNonQuery();
            title.Text = "";
            genre.Text = "";
            rate.Text = "";
        }*/
        
    }

}