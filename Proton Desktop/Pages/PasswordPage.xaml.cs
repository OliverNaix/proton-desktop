using Proton_Desktop.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Proton_Desktop.Pages
{
    /// <summary>
    /// Логика взаимодействия для PasswordPage.xaml
    /// </summary>
    public partial class PasswordPage : Page
    {
        public PasswordPage()
        {
            InitializeComponent();

            passwordViewModel = new PasswordViewModel();

            this.DataContext = passwordViewModel;
        }
        public bool IsValid { get; set; }

        private PasswordViewModel passwordViewModel;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            passwordViewModel.PasswordString = Password.Password;

            passwordViewModel.Continue.Execute("");
        }
    }
}
