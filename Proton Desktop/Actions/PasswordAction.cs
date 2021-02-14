using Proton_Desktop.Pages;
using System;

namespace Proton_Desktop.Actions
{
    class PasswordAction : Action
    {
        public override string Type {
            get => "password_action";
        }
        public override void Run(object value)
        {
            if (Convert.ToBoolean(value.ToString()))
            {
                AppNavigation.Navigate("MainPage");
            }
            else
            {
                (AppNavigation.CurrentPage as PasswordPage).InvalidString.Visibility = System.Windows.Visibility.Visible;

                AppNavigation.Navigate("PasswordPage");
            }
        }
    }
}
