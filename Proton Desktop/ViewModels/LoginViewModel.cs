using Proton_Desktop.Models;
using ProtonKernel;
using System.Windows.Input;

namespace Proton_Desktop.ViewModels
{
    class LoginViewModel
    {
        public string Email { get; set; }
        public ICommand Continue
        {
            get
            {
                return new RelayCommand(async (obj) =>  
                {
                    var update = await Authorization.EmailCheckAsync(Email);

                    Actions.Actions.RunAction(update);
                });
            }
        }
    }
}
