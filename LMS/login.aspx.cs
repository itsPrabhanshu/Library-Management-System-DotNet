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
    public partial class login : System.Web.UI.Page
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
            string s = "select * from login where id='" + TextBox1.Text + "' and pass='" + TextBox2.Text + "'";
            da= new OleDbDataAdapter(s,con);
            DataSet ds = new DataSet();
            da.Fill(ds);    
            if(ds.Tables[0].Rows.Count != 0 )
            {
                Response.Redirect("page_home.aspx");
            }
            else
            {
                string s1="select sid from student where uid='"+TextBox1.Text+"' and upass='"+TextBox2.Text+"'";
                da=new OleDbDataAdapter(s1,con);
                DataSet ds2 = new DataSet();
                da.Fill(ds2);
                if (ds2.Tables[0].Rows.Count!=0)
                {
                    Session["a"] = ds2.Tables[0].Rows[0][0];
                    Response.Redirect("page_profile.aspx");
                }
                Response.Write("<script>alert('Invalid Id Or Password')</script>");
            }

        }
    }
}