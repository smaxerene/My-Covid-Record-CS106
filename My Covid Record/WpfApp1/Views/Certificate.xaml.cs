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
using System.Windows.Media; // For RenderTargetBitmap
using System.Windows.Media.Imaging;// For BitmapFrame, PngBitmapEncoder, PixelFormats
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO; // For FileStream
using Microsoft.Win32; // For SaveFileDialog

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for Certificate.xaml
    /// </summary>
    public partial class Certificate : Page, INotifyPropertyChanged
    {
        private Random random;
        private List<int> generatedNumbers;

        public Certificate()
        {
            InitializeComponent();

            random = new Random();
            generatedNumbers = new List<int>();

            GenerateRandomNumber();

            IsReadOnly = true;

            currentLoginUserID = (int)App.Current.Properties["CurrentUserId"];

            using (var db = new DataContext())
            {
                User currentUser = db.Users.Where(
                    x => x.Id == currentLoginUserID
                    ).FirstOrDefault();

                Name.Text = currentUser.FullName;
                Birthday.Text = currentUser.Birthday;
                Address.Text = currentUser.Address;
            }
            this.DataContext = this;
            LoadVaccineData();
        }

        private void GenerateRandomNumber()
        {
            int minNumber = 1000000;
            int maxNumber = 9000000;

            if (generatedNumbers.Count == (maxNumber - minNumber + 1))
            {
                RandomNumberTextBlock.Text = "All numbers have been generated.";
                return;
            }

            int randomNumber;

            do
            {
                randomNumber = random.Next(minNumber, maxNumber + 1);
            }
            while (generatedNumbers.Contains(randomNumber));

            generatedNumbers.Add(randomNumber);
            RandomNumberTextBlock.Text = $" {randomNumber}";
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


        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Login();
        }

        //Buttons
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            IsReadOnly = false;
        }

        private void EditPage_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new VaccineDetailsPage();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

            using (var db = new DataContext())
            {
                User currentUser = db.Users.Where(
                    x => x.Id == currentLoginUserID
                    ).FirstOrDefault();

                currentUser.FullName = Name.Text;
                currentUser.Birthday = Birthday.Text;
                currentUser.Address = Address.Text;

                db.Users.Update(currentUser);
                db.SaveChanges();
            }

            this.DataContext = this;

            IsReadOnly = true;
        }
        private void Download_Click(object sender, RoutedEventArgs e)
        {
            // Create a RenderTargetBitmap with the size of the Border element
            var renderTargetBitmap = new RenderTargetBitmap((int)myCertificate.ActualWidth, (int)myCertificate.ActualHeight, 96, 96, PixelFormats.Default);

            // Render the Border onto the RenderTargetBitmap
            renderTargetBitmap.Render(myCertificate);

            // Create a PngBitmapEncoder to encode the RenderTargetBitmap as a PNG image
            PngBitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(renderTargetBitmap));

            // Create a SaveFileDialog to prompt the user to choose the location to save the file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image (*.png)|*.png";
            saveFileDialog.DefaultExt = ".png";

            if (saveFileDialog.ShowDialog() == true)
            {
                string filePath = saveFileDialog.FileName;

                // Save the RenderTargetBitmap as a PNG file
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    encoder.Save(fileStream);
                }

                MessageBox.Show(" Your Covid-19 Certificate downloaded successfully.");
            }
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
