using System.Collections.Generic;
using System.Windows;

namespace WpfApp1
{
    public partial class ReportIssue : Window
    {
        private List<UserReport> reports;

        public List<Report> Reports { get; set; }
        public string SelectedStatus { get; set; }

        public ReportIssue(List<Report> reports)
        {
            InitializeComponent();
            Reports = reports;
            DataContext = this;
        }

        public ReportIssue(List<UserReport> reports)
        {
            this.reports = reports;
        }
    }

    public class Report
    {
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
    }
}
