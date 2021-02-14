using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Proton_Desktop.ViewModels
{
    /// <summary>
    /// Класс хуй 
    /// </summary>
    class MainViewModel
    {
        public string SearchString { get; set; }
        public ICommand SearchCommand
        {
            get => new RelayCommand(async (o) =>
            {
                await ProtonKernel.Search.User(SearchString);
            });
        }
    }
}
