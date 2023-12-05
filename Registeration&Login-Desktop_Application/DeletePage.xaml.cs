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
    /// Interaction logic for DeletePage.xaml
    /// </summary>
    public partial class DeletePage : Page
    {
        RegisterationANDLoginEntities db = new RegisterationANDLoginEntities();
        public DeletePage()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sendder, RoutedEventArgs e)
        {
            var user = db.theUsers.FirstOrDefault(x => x.PhoneNumber == txtPhone.Text);
            if (user != null)
            {
                db.theUsers.Remove(user);
                db.SaveChanges();
                MessageBox.Show("User Removed Successfully");
            }
            else
            {
                MessageBox.Show("User Note Exist!");
            }
        }

        private void txtPhone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
