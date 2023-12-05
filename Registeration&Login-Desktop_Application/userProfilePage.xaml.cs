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
    /// Interaction logic for userProfilePage.xaml
    /// </summary>
    public partial class userProfilePage : Page
    {
        int ID = 0;
        public userProfilePage(string userName, int id)
        {
            InitializeComponent();
            ID = id;
            lab_profile.Content = userName + " Profile";
            InitialInfo();
        }

        private void InitialInfo()
        {
            RegisterationANDLoginEntities db = new RegisterationANDLoginEntities();
            theUser user = db.theUsers.FirstOrDefault(x => x.userID == ID);
            labUserName.Content += user.Username;
            for (int i = 0; i < user.Password.Length; i++)
                labPassword.Content += "*";

            labAge.Content += Convert.ToString(user.Age);
            labGender.Content += user.Gender;
            labPhone.Content += user.Gender;
            labCity.Content += user.City;
        }

        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            SignINPage signIN = new SignINPage();
            NavigationService.Navigate(signIN);
        }
    }
}
