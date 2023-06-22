using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp1
{
    public partial class UserReports : Window
    {
        private List<UserReport> reports;
        public UserReport SelectedReport { get; set; }

        public UserReports()
        {
            InitializeComponent();

            // Initialize the reports list (replace with your actual logic)
            reports = new List<UserReport>
            {
                new UserReport { Subject = "Issue 1", Description = "Description 1" },
                new UserReport { Subject = "Issue 2", Description = "Description 2" },
                new UserReport { Subject = "Issue 3", Description = "Description 3" }
            };


            // Bind the reports to the ListView
            reportsListView.ItemsSource = reports;
        }

        private void ListViewItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Set the selected item when the ListViewItem is clicked
            var listViewItem = sender as ListViewItem;
            if (listViewItem != null && listViewItem.IsSelected)
            {
                SelectedReport = listViewItem.DataContext as UserReport;
            }
        }

        private void OpenReportIssueWindow(List<UserReport> reports)
        {
            ReportIssue reportIssue = new ReportIssue(reports);
            reportIssue.Show();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedReport != null)
            {
                OpenReportIssueWindow(reports);
            }
            else
            {
                MessageBox.Show("Please select a report before submitting.");
            }
        }
    }

    public class UserReport
    {
        public string Subject { get; set; }
        public string Description { get; set; }
    }
}
