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
    public partial class bookdetails : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.QueryString["a"];
            con=new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\prabh\OneDrive\Documents\Database4L.accdb");
            con.Open(); 
            string s="select * from book where bid="+Label1.Text+"";
            da=new OleDbDataAdapter(s,con);
            DataSet ds=new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                Label2.Text = ds.Tables[0].Rows[0][1].ToString();
                Label3.Text = ds.Tables[0].Rows[0][2].ToString();
                Label4.Text = ds.Tables[0].Rows[0][3].ToString();
            }
         
            
        }
    }
}