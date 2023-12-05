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

namespace Registeration_Login_Desktop_Application
{
    /// <summary>
    /// Interaction logic for SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        RegisterationANDLoginEntities db = new RegisterationANDLoginEntities();
        bool validPassword = false,
            validAge = false,
            validPhone = false;
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void txt_phoneNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (txt_phoneNumber.Text.Length == 11)
                validPhone = true;
            else
                validPhone = false;
        }

        private void btn_SignUp_Click(object sender, RoutedEventArgs e)
        {
            theUser user = new theUser();
            user.Username = txt_userName.Text;
            user.userID = db.theUsers.Max(x => x.userID) + 1;
            IsValidPassword();
            if (validPassword)
            {
                user.Password = txt_password.Text;
                user.City = combCity.SelectedItem.ToString().Split(' ').Last();

                int theAge = int.Parse(txt_age.Text);

                if (theAge > 16 && theAge < 60)
                {
                    user.Age = theAge;
                    if (validPhone)
                    {
                        user.PhoneNumber = txt_phoneNumber.Text;
                        if (radMale.IsChecked == true)
                            user.Gender = "Male";
                        else if (radFemale.IsChecked == true)
                            user.Gender = "Female";
                        else
                            MessageBox.Show("Gender: must be binary “Male” or “Female”!");

                        db.theUsers.Add(user);
                        db.SaveChanges();
                        MessageBox.Show("SignUP Succ");

                    }
                    else
                        MessageBox.Show("Please enter a phone number has 11 Digits and that must be Unique!");
                }
                else
                    MessageBox.Show("Age must be from 18 to 60!");
            }
            else
                MessageBox.Show("Password must contain characters, numbers and special characters!");

        }

        private void IsValidPassword()
        {
            bool hasDigit = false,
                hasLetter = false,
                hasSpecial = false;

            string password = txt_password.Text;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                    hasDigit = true;
                if (char.IsLetter(c))
                    hasLetter = true;
                if (!char.IsLetterOrDigit(c))
                    hasSpecial = true;
            }
            if (hasSpecial && hasLetter && hasDigit)
                validPassword = true;
            else
                validPassword = false;
        }

        private void btn_SingIN_Click(object sender, RoutedEventArgs e)
        {
            SignINPage iNPage = new SignINPage();
            NavigationService.Navigate(iNPage);
        }

        private void txt_password_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txt_age_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
