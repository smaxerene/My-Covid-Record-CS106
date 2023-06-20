using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class VaccineDetailsPage : Page
    {
        ObservableCollection<UserDetails> UserDetail = new ObservableCollection<UserDetails>();

        public VaccineDetailsPage()
        {
            InitializeComponent();
            ListView.ItemsSource = UserDetail;
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
            //To ListView
            UserDetail.Add(new UserDetails()
            {
                DoseNo = Dose.Text,
                Date = Date.Text,
                Vaccine = Vaccine.Text,
                Brand = Brand.Text,
                Country = Country.Text
            });

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
            Reset();
        }

        //public class UserDetails
        //{
        //    public string DoseNo { get; set; }
        //    public string Date { get; set; }
        //    public string Vaccine { get; set; }
        //    public string Brand { get; set; }
        //    public string Country { get; set; }
        //}

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

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (ListView.SelectedItems.Count > 0)
            {
                //Dose.Text = ListView.SelectedItems[0].SubItems[0].Text;
                //Date.Text = ListView.SelectedItems[0].SubItems[1].Text;
                //Vaccine.Text = ListView.SelectedItems[0].SubItems[2].Text;
                //Brand.Text = ListView.SelectedItems[0].SubItems[3].Text;
                //Country.Text = ListView.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (ListView.SelectedItems.Count > 0)
            {
                //ListView.Text = Dose.Text;
                //ListView.SelectedItems[0].SubItems[1].Text = Date.Text;
                //ListView.SelectedItems[0].SubItems[2].Text = Vaccine.Text;
                //ListView.SelectedItems[0].SubItems[3].Text = Brand.Text;
                //ListView.SelectedItems[0].SubItems[4].Text = Country.Text;
            }
        }

        private void RemoveAll_Click(object sender, RoutedEventArgs e)
        {
            if (ListView.SelectedItems.Count > 0)
            {
                //ListView.SelectedItemsRemove(ListView.SelectedItemsProperty[0]);

            }
        }

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
    }
}
