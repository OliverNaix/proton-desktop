using Kernel;
using Kernel.BindingModels;
using Kernel.Models;
using Newtonsoft.Json;
using Proton.ApplicationContext;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Proton.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public LoginViewModel()
        {
            IsEnabled = true;

            IsValid = Visibility.Hidden;
        }
        public string Email { get; set; }
        public string Password { get; set; }
        private bool enabled;
        public bool IsEnabled
        {
            get
            {
                return enabled;
            }
            set
            {
                enabled = value;
                OnPropertyChanged("IsEnabled");
            }
        }

        private Visibility isValid;
        public Visibility IsValid
        {
            get
            {
                return isValid;
            }
            set
            {
                isValid = value;
                OnPropertyChanged("IsValid");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
        public ICommand Login
        {
            get
            {
                return new Relay(async (obj) =>
                {
                    IsValid = Visibility.Hidden;

                    IsEnabled = false;

                    Update update = await Authorization.SignIn(new LoginBindingModel()
                    {
                        Email = this.Email,
                        Password = (obj as PasswordBox).Password
                    });

                    IsEnabled = true;

                    Switcher(update);
                });
            }
        }

        private void Switcher(Update update)
        {
            if (update.OperationComplete)
            {
                AppData.Token   = update.Token;

                AppData.Account = JsonConvert.DeserializeObject<Account>(update.Object.ToString());

                Navigation.Navigate("MainPage");
            }
            else
            {
                IsValid = Visibility.Visible;
            }
        }
     
    }
}
