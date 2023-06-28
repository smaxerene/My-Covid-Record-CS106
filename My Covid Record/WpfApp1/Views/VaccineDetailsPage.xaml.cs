using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for VaccineDetailsPage.xaml
    /// </summary>
    public partial class VaccineDetailsPage : Page, INotifyPropertyChanged
    {

        public VaccineDetailsPage()
        {
            InitializeComponent();

            currentLoginUserID = (int)App.Current.Properties["CurrentUserId"];

            LoadVaccineData();

            this.DataContext = this;

        }

        private void LoadVaccineData()
        {
            using (var db = new DataContext())
            {
                var vaccineList = (from ud in db.UserDetails
                                   where ud.UserId == currentLoginUserID
                                   select ud
                                   ).ToList();

                VaccineData.ItemsSource = vaccineList;
            }

        }

        private int currentLoginUserID;
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Homepage();
        }

        //Account 
        private void btnClosePopup_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }

        private void btnShowPopup_Click(object sender, RoutedEventArgs e)
        {
            if (sender == btnShowPopup)
            {
                myPopup.IsOpen = true;
            }
        }

        private void PersonalDeets_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new UserProfile();
        }

        private void GenerateQR_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new QRPage();
        }

        private void Certificate_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Certificate();
        }

        private void Notif_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new VaccineDetailsPage();
        }

        private void Report_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new UserReport();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Login();
        }

        //To Database & DataGrid
        private void Add_Click(object sender, RoutedEventArgs e)
        {

            //To Database & dataGrid
            using (var db = new DataContext())
            {
                UserDetails userdetails = new UserDetails();

                userdetails.DoseNo = Dose.Text;
                userdetails.Date = Date.Text;
                userdetails.Vaccine = Vaccine.Text;
                userdetails.Brand = Brand.Text;
                userdetails.Country = Country.Text;
                userdetails.UserId = currentLoginUserID;

                db.UserDetails.Add(userdetails);
                db.SaveChanges();

            }

            //To DataGrid
            LoadVaccineData();

            Reset();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            Dose.Text = "";
            Date.Text = "";
            Vaccine.Text = "";
            Brand.Text = "";
            Country.Text = "";
        }

        private void RemoveAll_Click(object sender, RoutedEventArgs e)
        {
            VaccineData.Items.Clear();

            using (var db = new DataContext())
            {
                UserDetails userdetails = new UserDetails();

                userdetails.DoseNo = Dose.Text;
                userdetails.Date = Date.Text;
                userdetails.Vaccine = Vaccine.Text;
                userdetails.Brand = Brand.Text;
                userdetails.Country = Country.Text;

                db.UserDetails.Remove(userdetails);
                db.SaveChanges();
            }
        }

        //DataGrid Row
        private void btnCloseEditPopUp_Click(object sender, RoutedEventArgs e)
        {
            myEditPopup.IsOpen = false;
        }

        private void btnEditShowPopUp_Click(object sender, RoutedEventArgs e)
        {
            myEditPopup.IsOpen = true;

            if (VaccineData.SelectedItem != null)
            {
                var selectedUser = (UserDetails)VaccineData.SelectedItem;

                // Populate the edit fields with the selected row data
                EditDose.Text = selectedUser.DoseNo;
                EditDate.Text = selectedUser.Date;
                EditVaccine.Text = selectedUser.Vaccine;
                EditBrand.Text = selectedUser.Brand;
                EditCountry.Text = selectedUser.Country;
            }
        }

        private void btnSaveEditPopup_Click(object sender, RoutedEventArgs e)
        {
            if (VaccineData.SelectedItem != null)
            {
                var selectedUser = (UserDetails)VaccineData.SelectedItem;

                using (var db = new DataContext())
                {
                    UserDetails userDetails = db.UserDetails.Find(selectedUser.Id);

                    if (userDetails != null)
                    {
                        userDetails.DoseNo = EditDose.Text;
                        userDetails.Date = EditDate.Text;
                        userDetails.Vaccine = EditVaccine.Text;
                        userDetails.Brand = EditBrand.Text;
                        userDetails.Country = EditCountry.Text;

                        db.UserDetails.Update(userDetails);
                        db.SaveChanges();
                    }
                }
                this.DataContext = this;
                LoadVaccineData();

                myEditPopup.IsOpen = false;
            }

        }

        private void DeleteRow_Click(object sender, RoutedEventArgs e)
        {
            if (VaccineData.SelectedItem != null)
            {
                var selectedUser = (UserDetails)VaccineData.SelectedItem;

                using (var db = new DataContext())
                {
                    db.UserDetails.Remove(selectedUser);
                    db.SaveChanges();
                }
                LoadVaccineData();
            }
        }

        //Other Buttons
        private void Certficate_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Certificate();
        }

        //Buttons
        private void GenerateCert_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Certificate();
        }

        // Event handler for property change notifications
        public event PropertyChangedEventHandler PropertyChanged;

        // Raises the PropertyChanged event when a property value changes
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }


}