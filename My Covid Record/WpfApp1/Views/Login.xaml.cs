using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WpfApp1.Views.Users
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        //Login Button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxEmail.Text.Length == 0)
            {
                errormessage.Text = "Enter an email.";
                textBoxEmail.Focus();
            }
            else if (!Regex.IsMatch(textBoxEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid email.";
                textBoxEmail.Select(0, textBoxEmail.Text.Length);
                textBoxEmail.Focus();
            }
            else
            {
                using (var db = new DataContext())
                {
                    User isUserThere = db.Users.Where(
                        x => x.Email == textBoxEmail.Text &&
                        x.Password == passwordBox1.Password
                        ).FirstOrDefault();

                    //Wrong Email or Passwprd
                    if (isUserThere == null || isUserThere.Email != textBoxEmail.Text || isUserThere.Password != passwordBox1.Password)
                    {
                        errormessage.Text = "Incorrect Email or Password.";
                        textBoxEmail.Focus();
                    }
                    else
                    {
                        App.Current.MainWindow.Content = new Homepage();
                    }

                }
            }
        }
        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new SignUp();
        }

        //Sign Up Here Button
        private void AdminLogin_Click(object sender, RoutedEventArgs e)
        {
            //App.Current.MainWindow.Content = new ();
        }
    }
}
