using Proton_Desktop.Network;
using Proton_Desktop.Pages;
using ProtonKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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

namespace Proton_Desktop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AppNavigation.CurrentWindow = this;
            AppNavigation.Navigate("MainPage");

            Actions.Actions.Init();

            //await Client.ConnectAsync(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9015));
        }
    }
}
