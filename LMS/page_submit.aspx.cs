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
    public partial class page_submit : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            con=new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\prabh\OneDrive\Documents\Database4L.accdb");
            con.Open(); 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select * from issue where bid=" + TextBox1.Text + "";
            da=new OleDbDataAdapter(s,con);
            DataSet ds=new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count!=0 )
            {
                LinkButton1.Text = ds.Tables[0].Rows[0][0].ToString();
                LinkButton2.Text = ds.Tables[0].Rows[0][1].ToString();
                Label3.Text = ds.Tables[0].Rows[0][2].ToString();
                Label4.Text = ds.Tables[0].Rows[0][3].ToString();

            }
            else
            {
                Response.Write("<script>alert('Book Not Issued')</script>");
                TextBox1.Text = "";
                LinkButton1.Text = "";
                LinkButton2.Text = "";
                Label3.Text = "";
                Label4.Text = "";
                TextBox1.Focus();





            }
            


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s="delete from issue where bid="+TextBox1.Text+"";
            cmd=new OleDbCommand(s,con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Record Has Been Submitted Successfully')</script>");
            TextBox1.Text = "";
            LinkButton1.Text = "";
            LinkButton2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            TextBox1.Focus();

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("bookdetails.aspx?a="+LinkButton1.Text);
            
        }


        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("page_studentdetails2.aspx?b="+LinkButton2.Text);
        }
    }
}