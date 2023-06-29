using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
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
using Npgsql;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for UserProfile.xaml
    /// </summary>
    public partial class UserProfile : Page, INotifyPropertyChanged
    {

        public UserProfile()
        {
            InitializeComponent();

            int currentuserId = (int)App.Current.Properties["CurrentUserId"];

            IsReadOnly = true;

            using (var db = new DataContext())
            {
                User currentUser = db.Users.Where(
                    x => x.Id == currentuserId
                    ).FirstOrDefault();

                Greeting.Text = currentUser.FullName;
                Name.Text = currentUser.FullName;
                Username.Text = currentUser.UserName;
                Email.Text = currentUser.Email;
                Number.Text = currentUser.PhoneNo;
            }

            this.DataContext = this;
        }

        private bool _isReadOnly;
        public bool IsReadOnly
        {
            get { return _isReadOnly; }
            set
            {
                _isReadOnly = value;
                OnPropertyChanged("IsReadOnly");
            }
        }


        //Menu
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

            App.Current.MainWindow.Content = new UserReports();
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Login();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            IsReadOnly = false;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            int currentuserId = (int)App.Current.Properties["CurrentUserId"];

            using (var db = new DataContext())
            {
                User currentUser = db.Users.Where(
                    x => x.Id == currentuserId
                    ).FirstOrDefault();

                currentUser.FullName = Name.Text;
                currentUser.UserName = Username.Text;
                currentUser.Email = Email.Text;
                currentUser.PhoneNo = Number.Text;

                db.Users.Update(currentUser);
                db.SaveChanges();
            }

            this.DataContext = this;

            IsReadOnly = true;
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

        private void ForgotPassWord_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
