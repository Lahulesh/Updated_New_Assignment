using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Assignment
{
    public partial class report : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
        string convir = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        DataSet dataSet;
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportGrid();
            TotalCost();
            /*display1();*/
            /*if (!Page.IsPostBack)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Connect"].ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from [Asset]";
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();
                table.Append("<table border='2'>");
                table.Append("<tr><th>Asset Id</th><th>Asset Name</th><th>Vendor Name</th><th>Purchase Date</th><th>Cost</th>");
                table.Append("</tr>");
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        table.Append("<tr>");
                        table.Append("<td>" + dr[0] + "</td>");
                        table.Append("<td>" + dr[1] + "</td>");
                        table.Append("<td>" + dr[2] + "</td>");
                        table.Append("<td>" + dr[3] + "</td>");
                        table.Append("<td id='total' onload='test(this)'>" + dr[4] + "</td>");
                        table.Append("</tr>");
                    }
                }
                table.Append("</table>");
                PlaceHolder1.Controls.Add(new Literal { Text = table.ToString()});
                dr.Close();
            }*/

        }
/*        private void display1()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Dataregister.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Asset where CreatedBy=@Cost", con);
            cmd.Parameters.AddWithValue("@Cost", label2.Text.Trim());
            cmd.ExecuteScalar();

            sda.Fill(ds);
            label1.Text = ds.Tables[0].Rows.Count.ToString();
            con.Close();
        }*/
        void TotalCost()
        {
            
            using (SqlConnection connect = new SqlConnection(convir))
            {
                /*int sum = 0;
                int Value = 0;*/
                connect.Open();
               /* DataTable dt = new DataTable();
                //SqlCommand sqlcom = new SqlCommand("SELECT SUM(Cost)FROM Asset", connect);

                for (int i = 0; i < dt.Rows.Count - 1; i++)
                {
                    sum += int.Parse(GridView1.Rows[i].Cells[Cost].Value.ToString());
                }*/

                
                DataAdapter.Fill(dt);
                //sqlcom.ExecuteReader();
                //SqlDataReader reader = sqlcom.ExecuteReader();
                //DataSet ds = new DataSet();

                //SqlDataAdapter da = new SqlDataAdapter("select SUM(Cost) as Cost from Asset", connect);
                //SqlCommand sc = new SqlCommand("select SUM(Cost) as Cost from Asset", connect);
                //Response.Write("<script>alert(sqlcom)</script>");
                //SqlDataReader rdr = sqlcom.ExecuteReader();
                //var total = da.Fill(ds);

                //Label2.Text = ds.Tables[0].Rows.Count.ToString();
                //Label2.DataBind();
                //DataTable dt = new DataTable();
                //DataSet dt = new DataSet();
                //int totalPrice = Convert.ToInt32(dt.("SUM(Cost)",string.Empty));
                //var total = totalPrice;

                //GridView2.DataSource = reader;
                //Label2.Text = total.ToString();


            }
        }
        private void display1()
        {
            SqlConnection con = new SqlConnection("Data Source=CSS-D-186;Initial Catalog=AssetRegister;User ID=sa;Password=sqlserver@1");
            con.Open();
            SqlCommand cmd = new SqlCommand("select SUM(Cost) as Cost from Asset", con);
            cmd.Parameters.AddWithValue("@Cost", Label2.Text.Trim());
            
            //cmd.ExecuteScalar();
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select SUM(Cost) as Cost from Asset", con);
            sda.Fill(ds);
            Label2.Text = ds.Tables[0].Rows.Count.ToString();
            con.Close();
        }
        void ReportGrid()
        {
            using (SqlConnection connect = new SqlConnection(convir))
            {
                connect.Open();
                SqlCommand sqlcom = new SqlCommand("select * from Asset", connect);
                //SqlCommand sqlcom = new SqlCommand("select * from Vendor where CityId (select CityName from City)", connect);
                SqlDataReader dr = sqlcom.ExecuteReader();
                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            }
        }
    }
}