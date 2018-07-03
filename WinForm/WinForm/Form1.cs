using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5KR3QEN\SQLEXPRESS;Initial Catalog=Collage;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            string selectqry = "select * from student where id=@id";
            SqlCommand cmd = new SqlCommand(selectqry, conn);
            cmd.Parameters.AddWithValue("id", searchtxt.Text);
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                MessageBox.Show(dataReader["name"].ToString());
            }
            conn.Close();
        }
        public void showData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5KR3QEN\SQLEXPRESS;Initial Catalog=Collage;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            string selectqry = "select * from student";
            SqlCommand cmd = new SqlCommand(selectqry, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            List<Student> studs = new List<Student>();
            while (dataReader.Read())
            {
                studs.Add(new Student(Convert.ToInt32(dataReader["id"]), dataReader["name"].ToString(), Convert.ToInt32(dataReader["age"]), dataReader["address"].ToString(), Convert.ToDouble(dataReader["salary"])));
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = studs;
            conn.Close();

        }
        private void insertbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5KR3QEN\SQLEXPRESS;Initial Catalog=Collage;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            string insertqry = "insert into student values (@id,@name,@age,@address,@salary)";
            SqlCommand cmd = new SqlCommand(insertqry, conn);
            cmd.Parameters.AddWithValue("id", idtxt.Text);
            cmd.Parameters.AddWithValue("name", nametxt.Text);
            cmd.Parameters.AddWithValue("age", agetxt.Text);
            cmd.Parameters.AddWithValue("address", addrtxt.Text);
            cmd.Parameters.AddWithValue("salary", saltxt.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            showData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5KR3QEN\SQLEXPRESS;Initial Catalog=Collage;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            string updateqry = "update student set name=@name, age=@age,address=@address,salary=@salary where id=@id";
            SqlCommand cmd = new SqlCommand(updateqry, conn);
            cmd.Parameters.AddWithValue("id", idtxt.Text);
            cmd.Parameters.AddWithValue("name", nametxt.Text);
            cmd.Parameters.AddWithValue("age", agetxt.Text);
            cmd.Parameters.AddWithValue("address", addrtxt.Text);
            cmd.Parameters.AddWithValue("salary", saltxt.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            showData();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5KR3QEN\SQLEXPRESS;Initial Catalog=Collage;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            string insertqry = "delete from student where id=@id";
            SqlCommand cmd = new SqlCommand(insertqry, conn);
            cmd.Parameters.AddWithValue("id", idtxt.Text);
            if (cmd.ExecuteNonQuery() < 1)
            {
                MessageBox.Show("No records affected");
            }
            conn.Close();
            showData();
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
