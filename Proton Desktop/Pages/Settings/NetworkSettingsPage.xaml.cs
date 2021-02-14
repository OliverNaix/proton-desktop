﻿using Proton_Desktop.ViewModels;
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

namespace Proton_Desktop.Pages.Settings
{
    /// <summary>
    /// Логика взаимодействия для NetworkSettingsPage.xaml
    /// </summary>
    public partial class NetworkSettingsPage : Page
    {
        public NetworkSettingsPage()
        {
            InitializeComponent();

            networkSettingsViewModel = new NetworkSettingsViewModel();

            DataContext = networkSettingsViewModel;
        }

        private NetworkSettingsViewModel networkSettingsViewModel;
    }
}