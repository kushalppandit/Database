using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APS_WebForm
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5KR3QEN\SQLEXPRESS;Initial Catalog=Collage;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            String sql = "select * from users1 where uid=@uid and password=@pwd";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("uid", Session["uid"]);
            cmd.Parameters.AddWithValue("pwd", Session["pwd"]);
            SqlDataReader dataReader = cmd.ExecuteReader();
            User user;
            if (dataReader.Read())
            {
                user = new User(Convert.ToInt32(dataReader["id"]), dataReader["uid"].ToString(), dataReader["password"].ToString(), dataReader["name"].ToString());
                grd1.DataSource = null;
                grd1.DataSource = user;
                grd1.DataBind();
            }
        }

    }
}