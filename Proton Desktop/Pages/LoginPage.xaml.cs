using Proton_Desktop.ViewModels;
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

namespace Proton_Desktop.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();

            loginViewModel = new LoginViewModel();

            EmailBox.TextChanged += EmailBox_TextChanged;

            this.DataContext = loginViewModel;
        }

        private void EmailBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            loginViewModel.Email = EmailBox.Text;
        }

        private readonly LoginViewModel loginViewModel;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
