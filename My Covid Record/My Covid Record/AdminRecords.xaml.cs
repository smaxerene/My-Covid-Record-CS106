using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace My_Covid_Record
{
    public partial class AdminRecords : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Retrieve data from the database
                List<DataItem> data = GetDataFromDatabase();

                // Bind the data to the ItemsControl
                DataList.DataSource = data;
                DataList.DataBind();
            }
        }

        private List<DataItem> GetDataFromDatabase()
        {
            List<DataItem> data = new List<DataItem>();

            // TODO: Replace with your database connection string
            string connectionString = "Your Database Connection String";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Year, Month, Day, Weekday FROM YourTable";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Create a new DataItem object and populate its properties
                    DataItem item = new DataItem();
                    item.Year = reader.GetString(0);
                    item.Month = reader.GetString(1);
                    item.Day = reader.GetString(2);
                    item.Weekday = reader.GetString(3);

                    // Add the item to the data list
                    data.Add(item);
                }

                reader.Close();
            }

            return data;
        }
    }

    public class DataItem
    {
        public string Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public string Weekday { get; set; }
    }
}
