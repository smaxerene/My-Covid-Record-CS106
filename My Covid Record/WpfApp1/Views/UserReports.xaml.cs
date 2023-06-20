using System.Windows;

namespace WpfApp1
{
    public partial class UserReports : Window
    {
        public UserReports()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string subject = SubjectTextBox.Text;
            string description = DescriptionTextBox.Text;

            // Open the ReportIssue window and pass the details
            ReportIssue reportIssueWindow = new ReportIssue(email, subject, description);
            reportIssueWindow.ShowDialog();
        }
    }
}
