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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class UserReports : Page
    {
        public UserReports()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "Server=R4MOSS;Initial Catalog=AdminRecords;User ID=Dave;Password=ramozz";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string subject = Subjecttextbox.Text;
                string email = Emailtextbox.Text;
                string description = Descriptiontextbox.Text;
                MessageBox.Show("Your report has been submitted successfully!", "Report Submitted", MessageBoxButton.OK, MessageBoxImage.Information);
                string insertQuery = "INSERT INTO AdminRecords (Subject, Email, Description) VALUES (@Subject, @Email, @Description)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Subject", subject);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Description", description);

                    command.ExecuteNonQuery();
                }
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ReportRecieves reportRecievesPage = new ReportRecieves();
            Application.Current.MainWindow.Content = reportRecievesPage;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Homepage();
        }
    }
}
