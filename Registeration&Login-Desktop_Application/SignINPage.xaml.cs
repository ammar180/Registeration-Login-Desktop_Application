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
    /// Interaction logic for SignINPage.xaml
    /// </summary>
    public partial class SignINPage : Page
    {
        RegisterationANDLoginEntities db = new RegisterationANDLoginEntities();
        public SignINPage()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_userName.Text == "" || txt_password.Text == "")
                    MessageBox.Show("Please Fill the TextBoxs Data");
                else
                {
                    if (CombWho.SelectedIndex == 0)
                    {
                        //User Navigation
                        var theUser = db.theUsers.FirstOrDefault(
                            x => x.Username == txt_userName.Text
                            && x.Password == txt_password.Text);
                        if (theUser != null)
                        {
                            userProfilePage profilePage = new userProfilePage(theUser.Username, theUser.userID);
                            NavigationService.Navigate(profilePage);
                        }
                        else
                            MessageBox.Show("Wrong user name or password for user");
                    }
                    else if(CombWho.SelectedIndex == 1)
                    {
                        var theAdmin = db.Admins.FirstOrDefault(
                            x => x.admin_username == txt_userName.Text
                            && x.admin_pass == txt_password.Text);
                        if (theAdmin != null)
                        {
                            AdminPage adPage = new AdminPage();
                            this.NavigationService.Navigate(adPage);
                        }
                        else
                            MessageBox.Show("Wrong user name or password for Admin");
                    }
                }
            }
            catch { }            
        }

        private void btn_foregetPassword_Click(object sender, RoutedEventArgs e)
        {
            ForgetPasswordPage FPpage = new ForgetPasswordPage();
            NavigationService.Navigate(FPpage);
        }

        private void btn_SignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUpPage signUPpage = new SignUpPage();
            NavigationService.Navigate(signUPpage);
        }
    }
}
