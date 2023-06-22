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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for UserProfile.xaml
    /// </summary>
    public partial class UserProfile : Page
    {
        //private readonly SignUp _signup;
        public UserProfile(SignUp signup)
        {
            InitializeComponent();

            // _signup = signup;

            using (var db = new DataContext())
            {
                User userregister = new User();

                //userregister.FullName = _signup.FullNameTextBox.Text;
                // userregister.UserName = _signup.UsernameTextBox.Text;
                // userregister.Email = _signup.EmailTextBox.Text;
                // userregister.PhoneNo = _signup.PhoneTextBox.Text;

                //Binding Data from SignUp Page
                Binding binding = new Binding("Text");

                //Full Name
                //Set binding behaviours
                // binding.Source = _signup.FullNameTextBox;
                binding.Mode = BindingMode.OneWay;
                //Attach the binding to the destination component
                //Name.SetBinding(Label.ContentProperty, binding);

                //Username
                // binding.Source = _signup.UsernameTextBox;
                binding.Mode = BindingMode.OneWay;
                Username.SetBinding(Label.ContentProperty, binding);

                //Email
                // binding.Source = _signup.EmailTextBox;
                binding.Mode = BindingMode.OneWay;
                Email.SetBinding(Label.ContentProperty, binding);

                //Phone Number
                // binding.Source = _signup.PhoneTextBox;
                binding.Mode = BindingMode.OneWay;
                Number.SetBinding(Label.ContentProperty, binding);
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
            // App.Current.MainWindow.Content = new UserProfile(_signup);
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
    }
}
