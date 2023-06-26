using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Npgsql;
using System.Data;

namespace WpfApp1.Views
{
    public partial class UserReports : Window
    {
        string connectionString = "Server=rosie.db.elephantsql.com;Port=866020 ;Database=zbjbtgnq;";

        public UserReports()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string subject = SubjectTextBox.Text;
                string email = EmailTextBox.Text;
                string description = DescriptionTextBox.Text;

                string insertQuery = "INSERT INTO Report (Subject, Email, Description) VALUES (@Subject, @Email, @Description)";

                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Subject", subject);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Description", description);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Your report has been submitted successfully!", "Report Submitted", MessageBoxButton.OK, MessageBoxImage.Information);

                // Clear the input fields
                EmailTextBox.Text = string.Empty;
                SubjectTextBox.Text = string.Empty;
                DescriptionTextBox.Text = string.Empty;

                // Refresh the reports list
                LoadReports();
            }
        }

        private void LoadReports()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Report";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        ReportsListBox.ItemsSource = dataTable.DefaultView;
                    }
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadReports();
        }
    }
}
