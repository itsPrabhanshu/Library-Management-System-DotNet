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
    public partial class page_profile : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            con=new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\prabh\OneDrive\Documents\Database4L.accdb");
            con.Open();
            Label1.Text = Session["a"].ToString();
            string s = "select * from student where sid=" + Label1.Text + "";
            da = new OleDbDataAdapter(s,con);
            DataSet ds=new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count!=0)
            {
                Label1.Text = ds.Tables[0].Rows[0][0].ToString();
                Label2.Text = ds.Tables[0].Rows[0][1].ToString();
                Label3.Text = ds.Tables[0].Rows[0][2].ToString();
                Label4.Text = ds.Tables[0].Rows[0][3].ToString();
                Label5.Text = ds.Tables[0].Rows[0][4].ToString();
                Label6.Text = ds.Tables[0].Rows[0][5].ToString();
                Label7.Text = ds.Tables[0].Rows[0][6].ToString();
            }
        }
    }
}