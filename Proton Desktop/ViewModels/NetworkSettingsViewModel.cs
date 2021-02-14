using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Proton_Desktop.ViewModels
{
    class NetworkSettingsViewModel
    {
        public string IPAddressString { get; set; }
        public string PortString { get; set; }
        public bool ApplyEnable { get; set; } = true;
        public ICommand Reconnect
        {
            get => new RelayCommand(async (o) =>
            {
                ApplyEnable = false;

     
                ApplyEnable = true;
            });
        }
    }
}
