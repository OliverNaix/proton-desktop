using Proton_Desktop.Cryptography;
using Proton_Desktop.Models;
using Proton_Desktop.Network;
using ProtonKernel;
using System.Windows.Input;

namespace Proton_Desktop.ViewModels
{
    class RegistrationViewModel
    {
        public string PasswordString { get; set; }

        public string ConfirmPassword { get; set; }

        public ICommand Continue
        {
            get => new RelayCommand(async o =>
                {
                    var update = await Registration.CreateAccountAsync(Password.ConvertToHash(PasswordString));

                    Actions.Actions.RunAction(update);
                });
        }
    }
}
