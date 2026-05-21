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
    public partial class page_bookissue : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\prabh\OneDrive\Documents\Database4L.accdb");
            con.Open(); 
            Label1.Text = DateTime.Now.ToShortDateString();
            Label2.Text = DateTime.Now.AddDays(14).ToShortDateString(); 
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string s2 = "select bid from book where bid=" + TextBox1.Text + "";
            da = new OleDbDataAdapter(s2, con);
            DataSet ds1 = new DataSet();
            da.Fill(ds1);
            if (ds1.Tables[0].Rows.Count != 0)
            {
                string s1 = "select sid from student where sid=" + TextBox2.Text + "";
                da = new OleDbDataAdapter(s1, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    string s3 = "select * from issue where bid=" + TextBox1.Text + "";
                    da=new OleDbDataAdapter(s3, con);
                    DataSet ds2= new DataSet(); 
                    da.Fill(ds2 );

                    if (ds2.Tables[0].Rows.Count == 0)
                    {
                        string s = "insert into issue values(" + TextBox1.Text + "," + TextBox2.Text + ",'" + Label1.Text + "','" + Label2.Text + "')";
                        cmd = new OleDbCommand(s, con);
                        cmd.ExecuteNonQuery();
                        Response.Write("<script>alert('Book Issued Successfully')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Book Has Issued Already')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Student Id Not Found')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Book Id Not Found')</script>");
            }
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox1.Focus();   
        }
    }
}