using Proton_Desktop.Cryptography;
using Proton_Desktop.Models;
using ProtonKernel;
using System.Windows.Input;

namespace Proton_Desktop.ViewModels
{
    class PasswordViewModel
    {
        public string PasswordString { get; set; }
        public ICommand Continue
        {
            get
            {
                return new RelayCommand(async (o) =>
                {
                    var update = await Authorization.PasswordCheckAsync(Password.ConvertToHash(PasswordString));

                    Actions.Actions.RunAction(update);
                });
            }
        }
    }
}
