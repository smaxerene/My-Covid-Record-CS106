using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApp1
{
    public partial class AdminRecording : Window, INotifyPropertyChanged
    {
        private Item selectedItem;
        public Item SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged();
            }
        }

        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                searchText = value;
                FilterItems();
                OnPropertyChanged();
            }
        }

        public void UpdateCounts()
        {
            if (Items != null)
            {
                ConfirmCount = Items.Count(item => item.Status == "Confirm");
                UnvaccinatedCount = Items.Count(item => item.Status == "Unvaccinated");
                PartialCount = Items.Count(item => item.Status == "Partial");
            }
        }

        private ObservableCollection<Item> items;
        public ObservableCollection<Item> Items
        {
            get { return items; }
            set
            {
                items = value;
                OnPropertyChanged();
            }
        }

        private int confirmCount;
        public int ConfirmCount
        {
            get { return confirmCount; }
            set
            {
                confirmCount = value;
                OnPropertyChanged();
            }
        }

        private int unvaccinatedCount;
        public int UnvaccinatedCount
        {
            get { return unvaccinatedCount; }
            set
            {
                unvaccinatedCount = value;
                OnPropertyChanged();
            }
        }

        private int partialCount;
        public int PartialCount
        {
            get { return partialCount; }
            set
            {
                partialCount = value;
                OnPropertyChanged();
            }
        }

        public AdminRecording()
        {
            InitializeComponent();

            Items = new ObservableCollection<Item>
            {
                new Item { Name = "Ethan Sullivan", Description = "COVID-19 vaccine, RNA Based", AnotherDescription = "25 - Jun - 2021", Status = "" },
                new Item { Name = "Olivia Bennett", Description = "COVID-19 vaccine, RNA Based", AnotherDescription = "N/A", Status = "" },
                new Item { Name = "Mason Thompson", Description = "COVID-19 vaccine, RNA Based", AnotherDescription = "06 - Jan - 2022", Status = "" },
                new Item { Name = "Ava Parker", Description = "COVID-19 vaccine, RNA Based", AnotherDescription = "15 - Jul - 2022", Status = "" },
                new Item { Name = "Amelia Jensen", Description = "COVID-19 vaccine, RNA Based", AnotherDescription = "N/A", Status = "" },
                new Item { Name = "Isabella Thompson", Description = "COVID-19 vaccine, RNA Based", AnotherDescription = "06 - Jan - 2022", Status = "" },
                new Item { Name = "Liam Rodriguez", Description = "COVID-19 vaccine, RNA Based", AnotherDescription = "15 - Jul - 2022", Status = "" },
                new Item { Name = "Amelia Jensen", Description = "COVID-19 vaccine, RNA Based", AnotherDescription = "N/A", Status = "" },
                new Item { Name = "Emma Johnson", Description = "COVID-19 vaccine, RNA Based", AnotherDescription = "25 - Jun - 2021", Status = "" },
                new Item { Name = "Benjamin Smith", Description = "COVID-19 vaccine, RNA Based", AnotherDescription = "N/A", Status = "" },
                new Item { Name = "Olivia Davis", Description = "COVID-19 vaccine, RNA Based", AnotherDescription = "06 - Jan - 2022", Status = "" },
                new Item { Name = "Noah Anderson", Description = "COVID-19 vaccine, RNA Based", AnotherDescription = "15 - Jul - 2022", Status = "" },
                new Item { Name = "Sophia Martinez", Description = "COVID-19 vaccine, RNA Based", AnotherDescription = "N/A", Status = "" },
                new Item { Name = "William Brown", Description = "COVID-19 vaccine, RNA Based", AnotherDescription = "06 - Jan - 2022", Status = "" },
                new Item { Name = "Ava Taylor", Description = "COVID-19 vaccine, RNA Based", AnotherDescription = "15 - Jul - 2022", Status = "" },
                new Item { Name = "Amelia Jensen", Description = "COVID-19 vaccine, RNA Based", AnotherDescription = "N/A", Status = "" },
                new Item { Name = "Ava Taylor", Description = "COVID-19 vaccine, RNA Based", AnotherDescription = "06 - Jan - 2022", Status = "" }

            };

            DataContext = this;


        }




        private void FilterItems()
        {
            if (Items != null)
            {
                ICollectionView view = CollectionViewSource.GetDefaultView(Items);
                view.Filter = item =>
                {
                    if (item is Item currentItem)
                    {
                        return string.IsNullOrWhiteSpace(SearchText) ||
                            currentItem.Name.IndexOf(SearchText, StringComparison.OrdinalIgnoreCase) >= 0;
                    }

                    return false;
                };
            }
        }



        //private void dataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        //{
        //    SelectedItem = (Item)dataGrid.SelectedItem;
        //}

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            // Update the numbers based on the selected item
            if (selectedItem != null)
            {
                string selectedStatus = selectedItem.Content.ToString();

                switch (selectedStatus)
                {
                    case "Confirm":
                        ConfirmCount++;
                        break;
                    case "Unvaccinated":
                        UnvaccinatedCount++;
                        break;
                    case "Partial":
                        PartialCount++;
                        break;
                }
            }
        }


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }

    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string AnotherDescription { get; set; }
        public string Status { get; set; }
    }

}
