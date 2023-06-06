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

namespace My_Covid_Record
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        //Submit
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
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
            else
            {
                string fullName = FullNameTextBox.Text;
                string userName = UsernameTextBox.Text;
                string email = EmailTextBox.Text;
                string password = PasswordPassBox.Password;

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
                    errormessage.Text = "";
                    string phoneNo = PhoneTextBox.Text;

                    SqlConnection con = new SqlConnection("Data Source=TESTPURU;Initial Catalog=Data;User ID=sa;Password=wintellect");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Registration (Fullname,Username,Email,PhoneNumber,Password) values('" + fullName + "','" + userName + "','" + email + "','" + phoneNo + "','" + password + "')", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
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
            Close();
        }

        //Login
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }
    }
}
