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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UserProfile.xaml
    /// </summary>
    public partial class UserProfile : Window
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            Close();
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
            UserProfile userprofile = new UserProfile();
            userprofile.Show();
            Close();
        }

        private void GenerateQR_Click(object sender, RoutedEventArgs e)
        {
            QRPage qrpage = new QRPage();
            qrpage.Show();
            Close();
        }

        private void Certficate_Click(object sender, RoutedEventArgs e)
        {
            Certificate certificate = new Certificate();
            certificate.Show();
            Close();
        }
    }
}
