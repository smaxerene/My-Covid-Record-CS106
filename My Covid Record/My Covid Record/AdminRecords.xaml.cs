using System;
using System.Collections.Generic;
using System.Windows;

namespace My_Covid_Record
{
    public partial class AdminRecords : Window
    {
        public List<Record> Records { get; set; }

        public AdminRecords()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            Records = new List<Record>();

            // Generate sample data
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                string name = $"Person {i}";
                int index = random.Next(1, 100);
                string vaccineDetails = $"Vaccine details for {name}";
                DateTime lastDose = DateTime.Now.AddDays(-random.Next(1, 30));
                string status = "Vaccinated";

                Records.Add(new Record(index, name, vaccineDetails, lastDose, status));
            }

            // Set the data context for the Window
            DataContext = this;
        }

        private void RecordsDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Handle selection changed event
        }
    }

    public class Record
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string VaccineDetails { get; set; }
        public DateTime LastDose { get; set; }
        public string Status { get; set; }

        public List<string> StatusOptions { get; set; } = new List<string> { "Vaccinated", "Unvaccinated", "Partial" };

        public Record(int index, string name, string vaccineDetails, DateTime lastDose, string status)
        {
            Index = index;
            Name = name;
            VaccineDetails = vaccineDetails;
            LastDose = lastDose;
            Status = status;
        }
    }
}
