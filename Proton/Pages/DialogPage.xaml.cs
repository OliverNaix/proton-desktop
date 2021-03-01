using Kernel;
using Kernel.Models;
using Proton.Controlls;
using Proton.ViewModels;
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

namespace Proton.Pages
{
    /// <summary>
    /// Логика взаимодействия для DialogPage.xaml
    /// </summary>
    public partial class DialogPage : Page
    {
        public DialogPage()
        {
            InitializeComponent();
        }

        public DialogPage(Account account)
        {
            InitializeComponent();

            Username.Text = account.Email;

            this.DataContext = new DialogViewModel();
        }
    }
}
