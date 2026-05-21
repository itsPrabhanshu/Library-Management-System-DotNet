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
    public partial class page_newbook : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con= new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\prabh\OneDrive\Documents\Database4L.accdb");
            con.Open();
            int id;
            string s = "select bid from book order by bid desc";
            da=new OleDbDataAdapter(s,con);
            DataSet ds=new DataSet();
            da.Fill(ds);
            if(ds.Tables[0].Rows.Count==0  )
            {
                id = 1;
            }
            else
            {
                id = Convert.ToInt32(ds.Tables[0].Rows[0][0])+1;    
            }

            Label1.Text=id.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" || TextBox2.Text != "" || TextBox3.Text != "")
            {

                string s = "insert into book values(" + Label1.Text + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
                cmd = new OleDbCommand(s, con);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Record Has Been Inserted')</script>");
                Label1.Text=(Convert.ToInt32(Label1.Text)+1).ToString();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox1.Focus();
            }
            else
                Response.Write("<script>alert('Cannot Insert An Empty Record')</script>");
            
        }
    }
}