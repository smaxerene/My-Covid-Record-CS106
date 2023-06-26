using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Npgsql;

namespace WpfApp1.Views
{
    public partial class ReportRecieves : Window
    {
        public ReportRecieves()
        {
            InitializeComponent();

            string connectionString = "Server=rosie.db.elephantsql.com;Port=866020 ;Database=zbjbtgnq;";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM public.\"Report\"";
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int reportId = reader.GetInt32(0);
                            string subject = reader.GetString(1);
                            string email = reader.GetString(2);
                            string description = reader.GetString(3);
                            // Add the report data to your UI elements or collection for display
                            reportListView.Items.Add(new ReportItem { ReportId = reportId, Subject = subject, Email = email, Description = description });
                        }
                    }
                }
            }
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
    }
}
