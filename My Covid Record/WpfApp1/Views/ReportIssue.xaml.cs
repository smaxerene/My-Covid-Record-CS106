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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ReportIssue.xaml
    /// </summary>
    public partial class ReportIssue : Window
    {
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }

        public ReportIssue()
        {
            InitializeComponent();
        }
       
        private string email;
        private string subject;
        private string description;

        public ReportIssue(string email, string subject, string description)
        {
            this.email = email;
            this.subject = subject;
            this.description = description;
        }
        public class ReportItem
        {
            public string Email { get; set; }
            public string IssueDate { get; set; }
            public string Status { get; set; }
        }

    }

}
