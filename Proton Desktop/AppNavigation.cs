using Proton_Desktop.Pages;
using Proton_Desktop.Pages.Settings;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Proton_Desktop
{
    public static class AppNavigation
    {
        public static Window CurrentWindow { get; set; }
        public static Page CurrentPage { get; set; }
        public static Dictionary<string, Page> ActivePages { get; set; }
        public static void Init()
        {
            if (ActivePages == null)
            {
                ActivePages = new Dictionary<string, Page>();
            }

            ActivePages.Add("LoadingPage", new LoadingPage());

            ActivePages.Add("LoginPage", new LoginPage());

            ActivePages.Add("MainPage", new MainPage());

            ActivePages.Add("RegistrationPage", new RegistrationPage());

            ActivePages.Add("PasswordPage", new PasswordPage());

            ActivePages.Add("SettingsPage", new SettingsPage());
        }
        public static void Navigate(string pagename)
        {
            if (ActivePages == null)
            {
                Init();
            }

            if (ActivePages[pagename] != null)
            {
                ((CurrentWindow as dynamic).Frame as Frame).Navigate(ActivePages[pagename]);

                CurrentPage = ActivePages[pagename];
            }
        }
    }
}
