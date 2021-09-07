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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page 
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SingUpBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.registerPage);
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (loginTextBox.Text == User.Login && passwordTextBox.Text == User.Password)
            {
                NavigationService.Navigate(Pages.calculatorPage);
            }
            else
            {
                MessageBox.Show("неправильно введенны данные");
            }

        }
    }
}
