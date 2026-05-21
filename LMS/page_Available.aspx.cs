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
    public partial class page_Available : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\prabh\OneDrive\Documents\Database4L.accdb");
            con.Open();
            Label1.Text = Request.QueryString["a"];
            string s = "select * from brequest where rid="+Label1.Text+"";
            da = new OleDbDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);    
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox1.Text = ds.Tables[0].Rows[0][2].ToString();
                TextBox2.Text = ds.Tables[0].Rows[0][3].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0][4].ToString();
               
            }
            int i;
            string s1 = "select bid from book order by bid desc";
            da=new OleDbDataAdapter(s1, con);   
            DataSet ds1= new DataSet(); 
            da.Fill(ds1);  
            if(ds.Tables[0].Rows.Count == 0 )
            {
                i = 1;
            }
            else
            {
                i = Convert.ToInt32(ds.Tables[0].Rows[0][0])+1;
            }
            TextBox4.Text=i.ToString();

            Label1.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
         
            string s = "insert into book values("+TextBox4.Text+",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            cmd= new OleDbCommand(s,con);
            cmd.ExecuteNonQuery();

            string s2 = "update brequest set rstatus='Available at "+ TextBox4.Text+" ' where rid=" + Label1.Text + "";
            cmd= new OleDbCommand(s2,con);
            cmd.ExecuteNonQuery();
            Response.Redirect("page_allrequest.aspx");

        }
    }
}