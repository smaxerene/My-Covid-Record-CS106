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
    /// Interaction logic for VaccineDetailsPage.xaml
    /// </summary>
    public partial class VaccineDetailsPage : Window
    {
        public VaccineDetailsPage()
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

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //Email
            if (Dose.Text.Length == 0)
            {
                errormessage.Text = "Enter Dose Number.";
                Dose.Focus();
            }
            //Date
            else if (Date.Text.Length == 0)
            {
                errormessage.Text = "Enter Date of Vaccination.";
                Date.Focus();
            }
            //Vaccine
            else if (Vaccine.Text.Length == 0)
            {
                errormessage.Text = "Enter Vaccine.";
                Vaccine.Focus();
            }
            //Brand
            else if (Brand.Text.Length == 0)
            {
                errormessage.Text = "Enter the Brand of the Vaccine.";
                Brand.Focus();
            }
            //Country
            else if (Country.Text.Length == 0)
            {
                errormessage.Text = "Enter Country of Vaccination.";
                Country.Focus();
            }
            else
            {
                string DoseNo = Dose.Text;
                string DateVacc = Date.Text;
                string Vacc = Vaccine.Text;
                string BrandVacc = Brand.Text;
                string CountryVacc = Country.Text;

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

                errormessage.Text = "You have successfully added details.";
                Reset();
            }
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

        private void Certficate_Click(object sender, RoutedEventArgs e)
        {
            Certificate certificate = new Certificate();
            certificate.Show();
            Close();
        }

        //Buttons
        private void EditUpload_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GenerateCert_Click(object sender, RoutedEventArgs e)
        {
            Certificate certificate = new Certificate();
            certificate.Show();
            Close();
        }
    }
}
