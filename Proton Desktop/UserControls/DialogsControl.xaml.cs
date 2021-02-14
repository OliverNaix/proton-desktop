using ProtonKernel;
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

namespace Proton_Desktop.UserControls
{
    /// <summary>
    /// Логика взаимодействия для DialogsControl.xaml
    /// </summary>
    public partial class DialogsControl : UserControl
    {
        public DialogsControl()
        {
            InitializeComponent();
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var dialogs = await Dialogs.GetDialogsAsync();

            if (dialogs == null || dialogs.Count == 0)
            {
                return;
            }

            foreach (var i in dialogs)
            {
                var dialog = new DialogControl()
                {
                    Photo = new RGB(255, 0, 255),
                    Username = i.Users[0].Username
                };

                dialogBox.Items.Add(dialog);
            }
        }
    }
}
