using Kernel;
using Kernel.BindingModels;
using Kernel.Models;
using Proton.Controlls;
using Proton.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Proton.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<DialogItemControl> Items { get; set; }
        public DialogItemControl SelectedItem { get; set; }

        private DialogPage currentDialog;
        public DialogPage CurrentDialog
        {
            get
            {
                return currentDialog;
            }
            set
            {
                currentDialog = value;
                OnPropertyChanged("CurrentDialog");
            }
        }
        public MainViewModel()
        {
            Items = new ObservableCollection<DialogItemControl>();
        }
        public ICommand SearchCommand
        {
            get => new Relay(async (obj) =>
            {
                Items.Clear();

                SearchBindingModel searchBindingModel = new SearchBindingModel();

                searchBindingModel.Email = (obj as TextBox).Text;

                List<Account> accounts = await Search.GetUsersByEmail(searchBindingModel);

                ShowItems(accounts);
            });
        }
        public void ShowItems(List<Account> accounts)
        {
            foreach (var i in accounts)
            {
                Items.Add(GetDialogItemControl(i));
            }
        }
        public ICommand SelectedItemChangedCommand
        {
            get => new Relay((obj)=>
            {
                if (SelectedItem != null)
                {
                    CurrentDialog = new DialogPage(SelectedItem.Account);
                }
            });
        }
        public DialogItemControl GetDialogItemControl(Account account)
        {
            return new DialogItemControl(account);
        }
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
      
    }
}
