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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1.Views.Users
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {
        public SignUp()
        {
            InitializeComponent();
        }

        //Submit
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            //Email
            if (EmailTextBox.Text.Length == 0)
            {
                errormessage.Text = "Enter an email.";
                EmailTextBox.Focus();
            }
            else if (!Regex.IsMatch(EmailTextBox.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid email.";
                EmailTextBox.Select(0, EmailTextBox.Text.Length);
                EmailTextBox.Focus();
            }
            //Full name
            else if (FullNameTextBox.Text.Length == 0)
            {
                errormessage.Text = "Enter your full name.";
                FullNameTextBox.Focus();
            }
            //Username
            else if (UsernameTextBox.Text.Length == 0)
            {
                errormessage.Text = "Enter a username.";
                UsernameTextBox.Focus();
            }
            //Phone number
            else if (PhoneTextBox.Text.Length == 0)
            {
                errormessage.Text = "Enter your phone number.";
                PhoneTextBox.Focus();
            }
            else
            {
                string FullName = FullNameTextBox.Text;
                string UserName = UsernameTextBox.Text;
                string EmailAdd = EmailTextBox.Text;
                string Password = PasswordPassBox.Password;
                string ConfirmPass = ConfirmPassPassBox.Password;

                if (PasswordPassBox.Password.Length == 0)
                {
                    errormessage.Text = "Enter a password";
                    PasswordPassBox.Focus();
                }
                else if (ConfirmPassPassBox.Password.Length == 0)
                {
                    errormessage.Text = "Enter password to confirm";
                    ConfirmPassPassBox.Focus();
                }
                else if (PasswordPassBox.Password != ConfirmPassPassBox.Password)
                {
                    errormessage.Text = "Password not identical";
                    ConfirmPassPassBox.Focus();
                }
                else
                {
                    using (var db = new DataContext())
                    {
                        // var list = (from u in db.user select u).ToList();

                        User userregister = new User();
                        userregister.FullName = FullNameTextBox.Text;
                        userregister.UserName = UsernameTextBox.Text;
                        userregister.Email = EmailTextBox.Text;
                        userregister.PhoneNo = PhoneTextBox.Text;
                        userregister.Password = PasswordPassBox.Password;


                        db.Users.Add(userregister);
                        db.SaveChanges();

                    }

                    errormessage.Text = "You have Registered successfully.";
                    Reset();
                }
            }
        }

        //Reset
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            FullNameTextBox.Text = "";
            UsernameTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneTextBox.Text = "";
            PasswordPassBox.Password = "";
            ConfirmPassPassBox.Password = "";
        }

        //Cancel
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Login();
        }

        //Login
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Login();
        }
    }
}
