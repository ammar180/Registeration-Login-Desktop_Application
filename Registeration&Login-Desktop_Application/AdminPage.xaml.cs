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
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        RegisterationANDLoginEntities db = new RegisterationANDLoginEntities();
        public AdminPage()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var user = db.theUsers.Where(x => x.City == txtSearch.Text);
            lab_Result.Content = $"User in \"{txtSearch.Text}\"";
            if (user != null)
            {
                UsersDG.ItemsSource = user.ToList();
            }
            else
                MessageBox.Show("User Note Exist!");
        }

        private void btn_NavDelete_Click(object sender, RoutedEventArgs e)
        {
            DeletePage deletePage = new DeletePage();
            this.NavigationService.Navigate(deletePage);
        }

        private void txtPhone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
