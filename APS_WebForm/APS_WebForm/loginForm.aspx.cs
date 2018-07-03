using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APS_WebForm
{
    public partial class loginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sbmt_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5KR3QEN\SQLEXPRESS;Initial Catalog=Collage;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            String sql = "select uid, password from users1 where uid=@uid and password=@pwd";
            SqlCommand cmd = new SqlCommand(sql,conn);
            String userid = uid.Text.ToString();
            String password = pwd.Text.ToString();
            cmd.Parameters.AddWithValue("uid", uid.Text);
            cmd.Parameters.AddWithValue("pwd", pwd.Text);
            SqlDataReader dataReader = cmd.ExecuteReader();
            if(dataReader.Read())
            {
                if(dataReader["uid"].ToString().Equals(userid) && dataReader["password"].ToString().Equals(password))
                {
                    Session["uid"] = userid;
                    Session["pwd"] = password;
                    Response.Redirect("Details.aspx");
                }
                else
                {
                    Response.Write("Invalid User Id and Password");
                }
            }
            else
            {
                Response.Write("Invalid User Id and Password");
            }
        }
    }
}