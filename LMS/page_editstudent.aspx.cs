using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

namespace LMS
{
    public partial class page_editstudent : System.Web.UI.Page
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
            string s = "update student set sid=" + TextBox2.Text + ",sname='" + TextBox3.Text + "',fname='" + TextBox4.Text + "',gender='"+TextBox8.Text+"',mobno='" + TextBox5.Text + "',degree='" + TextBox6.Text + "',branch='" + TextBox7.Text + "' where sid="+TextBox1.Text+"";
            cmd=new OleDbCommand(s,con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Record Has Been Successfully Updated')</script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox1.Focus();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string s = "select * from student where sid=" + TextBox1.Text + "";
            da=new OleDbDataAdapter(s,con);
            DataSet ds=new DataSet();   
            da.Fill(ds);    
            if(ds.Tables[0].Rows.Count!= 0  )
            { 
                TextBox2.Text = ds.Tables[0].Rows[0][0].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0][1].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0][2].ToString();
                TextBox8.Text = ds.Tables[0].Rows[0][3].ToString();
                TextBox5.Text = ds.Tables[0].Rows[0][4].ToString();
                TextBox6.Text = ds.Tables[0].Rows[0][5].ToString();
                TextBox7.Text = ds.Tables[0].Rows[0][6].ToString();
            }
            else
            { Response.Write("<script>alert('Record Not Found')</script>"); }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s="delete from student where sid="+TextBox1.Text+"";
            cmd=new OleDbCommand(s,con);    
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Record Has Been Deleted Successfully')</script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox1.Focus();   
        }
    }
}