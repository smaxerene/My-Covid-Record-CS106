using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace My_Covid_Record
{
    public partial class AdminRecords : Window, INotifyPropertyChanged
    {
        private List<Record> items;

        public List<Record> Items
        {
            get { return items; }
            set
            {
                if (items != value)
                {
                    items = value;
                    NotifyPropertyChanged("Items");
                }
            }
        }

        public AdminRecords()
        {
            InitializeComponent();
            InitializeData();
            DataContext = this;
        }

        private void InitializeData()
        {
            Items = new List<Record>();

            // Generate sample data
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                string name = $"Person {i}";
                string description = $"Vaccine details for {name}";
                string status = "Vaccinated";

                Items.Add(new Record(name, description, status));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Record : INotifyPropertyChanged
    {
        private string name;
        private string description;
        private string status;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }

        public string Status
        {
            get { return status; }
            set
            {
                if (status != value)
                {
                    status = value;
                    NotifyPropertyChanged("Status");
                }
            }
        }

        public Record(string name, string description, string status)
        {
            Name = name;
            Description = description;
            Status = status;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
