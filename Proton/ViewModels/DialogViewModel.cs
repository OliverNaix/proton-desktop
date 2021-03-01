using Kernel.Models;
using Proton.Controlls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Proton.ViewModels
{
    class DialogViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<MessageItemControl> MessageItemControls { get; set; }
        private string messageText;
        public string MessageText
        {
            get
            {
                return messageText;
            }
            set
            {
                messageText = value;
                OnPropertyChanged("MessageText");
            }
        }
        

        public DialogViewModel()
        {
            MessageItemControls = new ObservableCollection<MessageItemControl>();
        }

        public ICommand SendCommand
        {
            get => new Relay(async (obj) =>
            {
                Message message = new Message();

                message.Text = MessageText;
                message.From = AppData.Account.Username;
                message.SendByMe = true;
                message.To = (obj as TextBlock).Text;

                MessageItemControl messageItemControl = new MessageItemControl(message);
                

                MessageItemControls.Add(messageItemControl);
            });
        }

        public ICommand LoadMessagesCommand
        {
            get => new Relay(async (obj) =>
            {

            });
        }

        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
