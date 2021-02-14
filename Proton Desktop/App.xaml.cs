using Proton_Desktop.Network;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Proton_Desktop
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ProtonStartup = new Startup();

            ProtonStartup.InitializeNetwork();
        }

        public Startup ProtonStartup { get; set; }
    }
}
