using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["HMSConnectString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Tbl_DoctorLogin", con);
                con.Open();
                GridView1.DataSource = com.ExecuteReader();
                GridView1.DataBind();
            }
        }
    }
}