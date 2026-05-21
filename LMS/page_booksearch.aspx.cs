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
    public partial class page_booksearch : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\prabh\OneDrive\Documents\Database4L.accdb");
            con.Open(); 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s= "select * from book where bid="+TextBox1.Text+"";
            da=new OleDbDataAdapter(s,con);
            DataSet ds=new DataSet();
            da.Fill(ds);    
            if(ds.Tables[0].Rows.Count!= 0)
            {
                Label1.Text = ds.Tables[0].Rows[0][0].ToString();
                Label2.Text = ds.Tables[0].Rows[0][1].ToString();
                Label3.Text = ds.Tables[0].Rows[0][2].ToString();
                Label4.Text = ds.Tables[0].Rows[0][3].ToString();
            }
            else
            {
                Response.Write("<script>alert('Book Not Found')</script>");
            }
        }
    }
}