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

namespace My_Covid_Record
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

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

                        Homepage homepage = new Homepage();
                        homepage.Show();
                        Close();


                    }

                }
            }
        }

        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            Close();
        }

        private void AdminLogin_Click(object sender, RoutedEventArgs e)
        {
            AdminLogin adminlogin = new AdminLogin();
            adminlogin.Show();
            Close();
        }
    }
}
