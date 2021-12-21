using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace New_Assignment
{
    public partial class vendor : System.Web.UI.Page
    {
        string convir = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            VendorGrid();
        }
        void VendorGrid()
        {
            using (SqlConnection connect = new SqlConnection(convir))
            {
                connect.Open();
                SqlCommand sqlcom = new SqlCommand("select * from Vendor", connect);
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