using System;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDb)\LocalIss;Initial Catalog=Iss; Integrated Security = true;");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (sqlCon.State == ConnectionState.Closed)
            sqlCon.Open();
        SqlCommand sqlCmd = new SqlCommand("GetMovies", sqlCon);
        sqlCmd.CommandType = CommandType.StoredProcedure;
        SqlDataReader rd = sqlCmd.ExecuteReader();
        rd.Read();
        int a = 1;
    }
}