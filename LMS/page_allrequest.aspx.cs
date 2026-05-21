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
    public partial class page_allrequest : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\prabh\OneDrive\Documents\Database4L.accdb");
            con.Open();
            string s = "select * from brequest";
            da=new OleDbDataAdapter(s,con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();   
        }

       

        protected void Linkbutton1_Command1(object sender, CommandEventArgs e)
        {
            string id=e.CommandName;
            string s1 = "update brequest set rstatus='Acccept' where rid="+id+" ";
            cmd=new OleDbCommand(s1,con);
            cmd.ExecuteNonQuery();
            string s = "select * from brequest";
            da = new OleDbDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            
            
        }

        protected void Linkbutton2_Command(object sender, CommandEventArgs e)
        {
           string id=e.CommandName;
            string s2 = "update brequest set rstatus='Reject' where rid=" + id + "";
            cmd=new OleDbCommand(s2,con);    
            cmd.ExecuteNonQuery();
            string s = "select * from brequest";
            da = new OleDbDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            
        }

        protected void Linkbutton3_Command(object sender, CommandEventArgs e)
        {
            string id = e.CommandName;
            string s3 = "update brequest set rstatus='Ordered' where rid=" + id + "";
            cmd = new OleDbCommand(s3, con);
            cmd.ExecuteNonQuery();
            string s = "select * from brequest";
            da = new OleDbDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
           
        }

        protected void Linkbutton4_Command(object sender, CommandEventArgs e)
        {
            string id = e.CommandName;
            Response.Redirect("page_Available.aspx?a=" + id );
            string s = "select * from brequest";
            da = new OleDbDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();



        }
    }
}