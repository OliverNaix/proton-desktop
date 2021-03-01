using Kernel.Models;
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
    /// Логика взаимодействия для MessageItemControl.xaml
    /// </summary>
    public partial class MessageItemControl : UserControl
    {
        public MessageItemControl()
        {
            InitializeComponent();
        }
        public Message Message { get; set; }
        public MessageItemControl(Message message)
        {
            InitializeComponent();

            this.Message = message;

            this.MessageText.Text = message.Text;
            this.Username.Text = message.From;
            this.Datetime.Text = message.Datetime;
        }
    }
}
