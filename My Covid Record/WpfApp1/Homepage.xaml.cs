using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace My_Covid_Record
{
    /// <summary>
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Homepage : Window, INotifyPropertyChanged
    {
        public Homepage()
        {
            InitializeComponent();

            // Set initial values for properties
            ShowComments = true;
            BackgroundValue = new SolidColorBrush(Colors.Green);
            HorizontalAlignmentValue = HorizontalAlignment.Right;

            // Set this Page instance as the data context
            this.DataContext = this;
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
        // Flag indicating whether to show comments
        private bool ShowComments
        {
            get; set;
        }

        // Property for the background color
        private Brush _backgroundValue;
        public Brush BackgroundValue
        {
            get { return _backgroundValue; }
            set
            {
                _backgroundValue = value;
                OnPropertyChanged("BackgroundValue");
            }
        }

        // Property for the horizontal alignment
        private HorizontalAlignment _horizontalAlignmentValue;
        public HorizontalAlignment HorizontalAlignmentValue
        {
            get { return _horizontalAlignmentValue; }
            set
            {
                _horizontalAlignmentValue = value;
                OnPropertyChanged("HorizontalAlignmentValue");
            }
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // This method is triggered when the text in the TextBox is changed
            // You can add custom logic here if needed
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SliderButton_Click(object sender, RoutedEventArgs e)
        {
            // This method is triggered when the Button is clicked
            if (ShowComments == false)
            {
                // If ShowComments is false, change properties to show comments
                ShowComments = true;
                BackgroundValue = new SolidColorBrush(Colors.Green);
                HorizontalAlignmentValue = HorizontalAlignment.Right;
            }
            else
            {
                // If ShowComments is true, change properties to hide comments
                ShowComments = false;
                BackgroundValue = new SolidColorBrush(Colors.Gray);
                HorizontalAlignmentValue = HorizontalAlignment.Left;
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            // This method is triggered when the text in the TextBox is changed
            // You can add custom logic here if needed
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