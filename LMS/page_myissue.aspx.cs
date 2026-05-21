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
    public partial class page_myissue : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            con=new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\prabh\OneDrive\Documents\Database4L.accdb");
            con.Open();
            string s = "select * from issue where sid=" + Session["a"] + "";
            da = new OleDbDataAdapter(s, con);
            DataSet ds=new DataSet();   
            da.Fill(ds);    
            GridView1.DataSource = ds;
            GridView1.DataBind();   
        }
    }
}