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
    public partial class page_newstudent : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\prabh\OneDrive\Documents\Database4L.accdb");
            con.Open();
            int i;
            string s= "select sid from student order by sid desc"; 
            da = new OleDbDataAdapter(s,con);
            DataSet ds= new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count==0)
            {
                i = 101;
            }
            else
            {
                i = Convert.ToInt32(ds.Tables[0].Rows[0][0]) + 1;
            }

            Label1.Text=i.ToString();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string r;
            if (RadioButton1.Checked == true)
            {
                r = "Male";
            }
            else if(RadioButton2.Checked == true) 
            {
                r = "Female";
            }
            else
            {
                r = "";
            }

            string s = "insert into student values(" + Label1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "','" + r + "','" + TextBox4.Text + "','" + DropDownList1.Text + "','" + DropDownList2.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')";
            cmd= new OleDbCommand(s,con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Record Has Been Inserted')</script>");
            Label1.Text= (Convert.ToInt32(Label1.Text)+1).ToString();
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox2.Focus();
        }
    }
}