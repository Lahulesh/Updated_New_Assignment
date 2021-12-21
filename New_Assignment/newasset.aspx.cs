using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Assignment
{
    public partial class newasset : System.Web.UI.Page
    {
        string con = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            //newassetid.Enabled = false;
            /*VendorName();*/
            using (SqlConnection Connect = new SqlConnection(con))
            {
                Connect.Open();
                SqlCommand command2 = new SqlCommand("select VendorName from Vendor", Connect);
                SqlDataReader reader1 = command2.ExecuteReader();
                while (reader1.Read())
                {
                    this.DropDownList1.Items.Add(reader1["VendorName"].ToString());
                }
                reader1.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connect = new SqlConnection(con))
            {
                Connect.Open();
                SqlCommand cmd = new SqlCommand("insert into Asset values('"+newassetname.Text+"','"+DropDownList1.Text+"','"+Convert.ToDateTime(newassetpurchase.Text)+"','"+Convert.ToInt32(newassetcost.Text)+"')",Connect);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Data Inserted')</script>");
                /*Response.Redirect("newasset.aspx");*/
                reset();
            }
        }
        void reset()
        {
            newassetid.Text = "";
            newassetname.Text = "";
            newassetpurchase.Text = "";
            newassetcost.Text = "";
        }
        void VendorName()
        {
            using (SqlConnection Connect = new SqlConnection(con))
            {
                Connect.Open();
                SqlCommand command2 = new SqlCommand("select VendorName from Vendor", Connect);
                SqlDataReader reader1 = command2.ExecuteReader();
                while (reader1.Read())
                {
                    this.DropDownList1.Items.Add(reader1["VendorName"].ToString());
                }
                reader1.Close();
            }
        }

        /*protected void DropDownList1_Load(object sender, EventArgs e)
        {
            VendorName();
        }*/
    }
}