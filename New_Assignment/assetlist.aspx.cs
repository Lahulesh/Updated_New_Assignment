using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Assignment
{
    public partial class assetlist : System.Web.UI.Page
    {
        string convir = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        //StringBuilder table = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                GridDataShow();
                /*GridAll();*/
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /* using (SqlConnection Connect = new SqlConnection(con))
             {
                 Connect.Open();
                 SqlCommand cmd = new SqlCommand();
                 string sqlquery = "select * from Asset where AssetName like '%'+AssetName+'%'";
                 cmd.CommandText = sqlquery;
                 cmd.Connection = Connect;
                 cmd.Parameters.AddWithValue("@AssetName", searchtext.Text);
                 DataTable dt = new DataTable();
                 SqlDataAdapter adapter = new SqlDataAdapter();
                 adapter.SelectCommand = new SqlCommand(sqlquery, Connect);
                 adapter.Fill(dt);
                 GridView1.DataSource = dt;
                 GridView1.DataBind();
             }*/
            SqlConnection Connect = new SqlConnection(convir);
            Connect.Open();             
            //string find = 
            SqlCommand com = new SqlCommand("SELECT * FROM Vendor WHERE VendorName = 'Lahulesh'",Connect);
            //com.Parameters.Add("@assetname", SqlDbType.NVarChar).Value = TextBox1.Text;
            //com.Parameters.Add("@vendorname", SqlDbType.NVarChar).Value = TextBox1.Text;

            com.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(com);
            //da.SelectCommand = com;
            DataSet ds = new DataSet();
//            GridView1.DataSource = da;
            //GridView1.DataSource = find;
            da.Fill(ds);
            GridView1.DataSource = da;
            GridView1.DataBind();


        }
        void GridDataShow()
        {
            using (SqlConnection connect = new SqlConnection(convir))
            {
                connect.Open();
                SqlCommand sqlcom = new SqlCommand("select * from Asset", connect);
                SqlDataReader dr = sqlcom.ExecuteReader();
                if(dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.Rows[0].Cells[0].Text);
            using (SqlConnection connect = new SqlConnection(convir))
            {
                connect.Open();
                SqlCommand sqlcom = new SqlCommand("delete from Asset where AssetID='"+ id + "'", connect);
                int t = sqlcom.ExecuteNonQuery();
                if(t > 0)
                {
                    Response.Write("<script>alert('Data has Deleted')</script>");
                    GridView1.EditIndex = -1;
                    GridDataShow();
                }
            }
        }
        void GridAll()
        {
            /*using (SqlConnection connect = new SqlConnection(convir))
            {
                connect.Open();
                SqlCommand sqlcom = new SqlCommand("select * from Asset", connect);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
            }*/
            SqlConnection connect = new SqlConnection(convir);
            connect.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Vendor",connect);
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}