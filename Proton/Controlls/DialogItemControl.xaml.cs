using Kernel;
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

namespace Proton.Controlls
{
    /// <summary>
    /// Логика взаимодействия для DialogItemControl.xaml
    /// </summary>
    public partial class DialogItemControl : UserControl
    {
        public DialogItemControl()
        {
            InitializeComponent();
        }

        public DialogItemControl(Account account)
        {
            InitializeComponent();

            Account = account;

            Username.Text = account.Username;
        }

        public Account Account { get; set; }
    }
}
