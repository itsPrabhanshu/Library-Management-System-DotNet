using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace LMS
{
    public partial class sveiw : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;   
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\prabh\OneDrive\Documents\Database4L.accdb");
            con.Open();
            if (!IsPostBack)
            {
                string id = Request.QueryString["sid"];
                string s = "select * from student where sid=" + id + "";
                da = new OleDbDataAdapter(s, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                TextBox2.Text = ds.Tables[0].Rows[0][0].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0][1].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0][2].ToString();
                TextBox8.Text = ds.Tables[0].Rows[0][3].ToString();
                TextBox5.Text = ds.Tables[0].Rows[0][4].ToString();
                TextBox6.Text = ds.Tables[0].Rows[0][5].ToString();
                TextBox7.Text = ds.Tables[0].Rows[0][6].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string s = "update student set sname='" + TextBox3.Text + "',fname='" + TextBox4.Text + "',gender='" + TextBox8.Text + "',mobno='" + TextBox5.Text + "',degree='" + TextBox6.Text + "',branch='" + TextBox7.Text + "' where sid=" +TextBox2.Text+"";
            cmd = new OleDbCommand(s, con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Record Has Been Updated Successfully')</script>");
            string s1 = "select * from student where sid=" +  TextBox2.Text+ "";
            da = new OleDbDataAdapter(s1, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
         
                TextBox2.Text = ds.Tables[0].Rows[0][0].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0][1].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0][2].ToString();
                TextBox8.Text = ds.Tables[0].Rows[0][3].ToString();
                TextBox5.Text = ds.Tables[0].Rows[0][4].ToString();
                TextBox6.Text = ds.Tables[0].Rows[0][5].ToString();
                TextBox7.Text = ds.Tables[0].Rows[0][6].ToString();
          
                Response.Redirect("sveiw.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s="delete from student where sid=" +TextBox2.Text+"";
            cmd=new OleDbCommand(s, con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Record Has Been Deleted')</script>");
            Response.Redirect("sveiw.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("page_allstudent.aspx");
        }
    }
}