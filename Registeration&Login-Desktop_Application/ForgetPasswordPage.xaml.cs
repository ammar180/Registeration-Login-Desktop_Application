using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for ForgetPasswordPage.xaml
    /// </summary>
    public partial class ForgetPasswordPage : Page
    {
        RegisterationANDLoginEntities db = new RegisterationANDLoginEntities();
        public ForgetPasswordPage()
        {
            InitializeComponent();
        }

        private void btn_updatePassword_Click(object sender, RoutedEventArgs e)
        {
            if (txt_phoneNumber.Text == "" ||
                txt_NewPassword.Text == "" ||
                txt_NewPasswordConfirm.Text == "")
            {
                MessageBox.Show("Please fill the textBoxes!");
            }
            else
            {
                theUser theUser = db.theUsers.FirstOrDefault(x => x.PhoneNumber == txt_phoneNumber.Text);
                if (theUser == null )
                    MessageBox.Show("theUser Not exist!");
                if (txt_NewPassword.Text == txt_NewPasswordConfirm.Text)
                {
                    theUser.Password = txt_NewPasswordConfirm.Text;
                    db.theUsers.AddOrUpdate(theUser);
                    db.SaveChanges();
                    MessageBox.Show("Passwode update successfully!");
                    txt_NewPassword.Text = txt_NewPasswordConfirm.Text = txt_phoneNumber.Text = string.Empty;
                    SignINPage signIN = new SignINPage();
                    NavigationService.Navigate(signIN);
                }   
                else
                    MessageBox.Show("Please write the same password in two textboxes!");

                
            }

        }
    }
}
