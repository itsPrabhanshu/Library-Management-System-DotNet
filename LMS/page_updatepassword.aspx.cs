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
    public partial class page_updatepassword : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;   
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\prabh\OneDrive\Documents\Database4L.accdb");
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }
          
        protected void Button2_Click1(object sender, EventArgs e)
        {
            string s = "select upass from student where sid=" + Session["a"] + " and upass='"+TextBox1.Text+"'";
            da = new OleDbDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                if (TextBox2.Text == TextBox3.Text)
                {
                    string s1 = "update student set upass='" + TextBox2.Text + "' where sid=" + Session["a"] + "";
                    cmd = new OleDbCommand(s1, con);
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('Password Has Been Updated Successfully')</script>");
                   
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                }
                else
                {
                    Response.Write("<script>alert('New Password And Confirm Password Not Matched')</script>d");
                }
            }
            else
            {
                Response.Write("<script>alert('Old Password Found Incorrect')</script>");
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            }
        }
    }
    
}