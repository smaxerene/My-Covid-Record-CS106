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
        public UserProfile()
        {
            InitializeComponent();
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

        private void Certficate_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Certificate();
        }
    }
}
