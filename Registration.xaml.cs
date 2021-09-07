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

namespace MegaSuperBombaApp
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, RoutedEventArgs e)
        {

            if(passwordtextbox.Text != "" || passwordtextbox.Text.ToLower() !="passward" && logintextbox.Text != "" || logintextbox.Text.ToLower() != "login")
            {
                User user0 = new User(passwordtextbox.Text, logintextbox.Text);
                NavigationService.Navigate(Pages.loginPage);
            }
            else
            {
                MessageBox.Show("введите допустимые значения");
            }

        }
    }
}
