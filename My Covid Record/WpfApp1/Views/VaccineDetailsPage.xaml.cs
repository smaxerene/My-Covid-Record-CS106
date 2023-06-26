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
        ObservableCollection<UserDetails> UserDetail = new ObservableCollection<UserDetails>();

        public VaccineDetailsPage()
        {
            InitializeComponent();

            LoadVaccineData();
        }

        private void LoadVaccineData()
        {
            using (var db = new DataContext())
            {
                var vaccineList = db.UserDetails.ToList();
                VaccineData.ItemsSource = vaccineList;
            }

        }

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

        private void Settings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Login();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

            //To Database
            using (var db = new DataContext())
            {

                UserDetails userdetails = new UserDetails();

                userdetails.DoseNo = Dose.Text;
                userdetails.Date = Date.Text;
                userdetails.Vaccine = Vaccine.Text;
                userdetails.Brand = Brand.Text;
                userdetails.Country = Country.Text;

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

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            /* int currentuserId = (int)App.Current.Properties["CurrentUserId"];

             using (var db = new DataContext())
             {
                 UserDetails currentUserDetails = db.UserDetails.Where(
                     x => x.Id == currentuserId
                     ).FirstOrDefault();

                 currentUserDetails.DoseNo = Dose.Text;
                 currentUserDetails.Date = Date.Text;
                 currentUserDetails.Vaccine = Vaccine.Text;
                 currentUserDetails.Brand = Brand.Text;
                 currentUserDetails.Country = Brand.Text;

                 db.Users.Update(currentUserDetails);
                 db.SaveChanges();
             }

             this.DataContext = this; */

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

        /* private void btnCloseEditPopUp_Click(object sender, RoutedEventArgs e)
         {
             myEditPopup.IsOpen = false;
         }

         private void btnEditShowPopUp_Click(object sender, RoutedEventArgs e)
         {
             if (sender == EditShowPopUp)
             {
                 myEditPopup.IsOpen = true;
             }
         }*/

        //Other Buttons
        private void Certficate_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Certificate();
        }

        //Buttons
        private void EditUpload_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GenerateCert_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Certificate();
        }

        private void VaccineData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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