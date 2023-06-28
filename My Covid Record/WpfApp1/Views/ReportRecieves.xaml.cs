using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;

namespace WpfApp1.Views
{
    public partial class ReportRecieves : Page
    {
        public List<ReportItem> ReportItems { get; set; }

        public ReportRecieves()
        {
            InitializeComponent();
            ReportItems = new List<ReportItem>();
            LoadData();
            DataContext = this;
        }

        private void LoadData()
        {
            string connectionString = "Server=R4MOSS;Initial Catalog=AdminRecords;User ID=Dave;Password=ramozz";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM dbo.AdminRecords\r\n";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int reportId = reader.GetInt32(0);
                            string subject = reader.GetString(1);
                            string email = reader.GetString(2);
                            string description = reader.GetString(3);

                            ReportItems.Add(new ReportItem { ReportId = reportId, Subject = subject, Email = email, Description = description });
                        }
                    }
                }
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int reportId = Convert.ToInt32(button.Tag);

            ReportItem reportItemToRemove = null;
            foreach (ReportItem item in ReportItems)
            {
                if (item.ReportId == reportId)
                {
                    reportItemToRemove = item;
                    break;
                }
            }

            if (reportItemToRemove != null)
            {
                DeleteItemFromDatabase(reportId); // Step 1: Delete the item from the database
                ReportItems.Remove(reportItemToRemove);
                // Update the data context to reflect the changes
                DataContext = null;
                DataContext = this;
            }
        }



        private void DeleteItemFromDatabase(int reportId)
        {
            string connectionString = "Server=R4MOSS;Initial Catalog=AdminRecords;User ID=Dave;Password=ramozz";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Step 1: Delete the item from the table
                string deleteQuery = "DELETE FROM dbo.AdminRecords WHERE ID = @ReportId";
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@ReportId", reportId);
                    command.ExecuteNonQuery();
                }

                // Step 2: Reset the identity column
                string resetIdentityQuery = "DBCC CHECKIDENT ('dbo.AdminRecords', RESEED, 0)";
                using (SqlCommand command = new SqlCommand(resetIdentityQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Step 3: Reassign new values to the identity column
                string reassignIdentityQuery = "DBCC CHECKIDENT ('dbo.AdminRecords', RESEED)";
                using (SqlCommand command = new SqlCommand(reassignIdentityQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }




        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Homepage();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new AdminRecording();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        public class ReportItem
        {
            public int ReportId { get; set; }
            public string Subject { get; set; }
            public string Email { get; set; }
            public string Description { get; set; }

            public ReportItem()
            {
                Subject = string.Empty;
                Email = string.Empty;
                Description = string.Empty;
            }
        }
    }
}
