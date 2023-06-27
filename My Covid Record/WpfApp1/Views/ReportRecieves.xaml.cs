using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for ReportRecieves.xaml
    /// </summary>
    public partial class ReportRecieves : Page
    {
        public ReportRecieves()
        {
            InitializeComponent();

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

                            reportListView.Items.Add(new ReportItem { ReportId = reportId, Subject = subject, Email = email, Description = description });
                        }
                    }
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private class ReportItem
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
            App.Current.MainWindow.Content = new ReportRecieves();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

