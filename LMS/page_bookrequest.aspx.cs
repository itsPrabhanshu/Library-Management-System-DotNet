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
    public partial class page_bookrequest : System.Web.UI.Page
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            con=new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\prabh\OneDrive\Documents\Database4L.accdb"); 
            con.Open();
            Label3.Text=DateTime.Now.ToShortDateString();   
            Label2.Text = Session["a"].ToString();
            int i;
            string s = "select rid from brequest order by rid desc";
            da = new OleDbDataAdapter(s, con);
            DataSet ds=new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0 )
            {
                i = 1;
            }
            else
            {
                i = Convert.ToInt32(ds.Tables[0].Rows[0][0]) + 1;
            }
            Label1.Text= i.ToString();  

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            string s = "insert into brequest values(" + Label1.Text + "," + Label2.Text + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + Label3.Text + "','Pending')";
            cmd= new OleDbCommand(s,con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Book Request Applied')</script>");
            Label1.Text=(Convert.ToInt32(Label1.Text)+1).ToString();    
           
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox1.Focus();   

        }
    }
}