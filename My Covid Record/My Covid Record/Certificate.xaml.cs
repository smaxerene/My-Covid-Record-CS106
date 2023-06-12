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

namespace My_Covid_Record
{
    /// <summary>
    /// Interaction logic for Certificate.xaml
    /// </summary>
    public partial class Certificate : Window
    {
        public Certificate()
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

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            VaccineDetailsPage details = new VaccineDetailsPage();
            details.Show();
            Close();
        }
        private void Download_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
