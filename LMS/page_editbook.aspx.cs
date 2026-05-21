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
    public partial class page_editbook : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\prabh\OneDrive\Documents\Database4L.accdb");
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           
            string s = "select * from book where bid=" + TextBox1.Text + "";
            da = new OleDbDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox2.Text = ds.Tables[0].Rows[0][0].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0][1].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0][2].ToString();
                TextBox5.Text = ds.Tables[0].Rows[0][3].ToString();

            }
            else
                Response.Write("<script>alert('Record Not Found')</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s = "update book set bname='" + TextBox3.Text + "',author='" + TextBox4.Text + "',subject='" + TextBox5.Text + "' where bid="+TextBox1.Text+"";
            cmd=new OleDbCommand(s,con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Record Has Been Updated Successfully')</script>");
            TextBox1.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox1.Focus();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string s="delete from book where bid="+TextBox1.Text+"";
            cmd=new OleDbCommand(s,con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Record Has Been Deleted Successfully')</script>");
            
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox1.Focus();
        }
    }
}