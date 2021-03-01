using Proton.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Proton.ApplicationContext
{
    public static class Navigation
    {
        public static Dictionary<string, Page> Pages { get; set; }
        public static Page CurrentPage { get; set; }
        public static MainWindow CurrentWindow { get; set; }
        public static Page CurrentFrontPage { get; set; }
        public static void Initialize()
        {
            Pages = new Dictionary<string, Page>();

            Pages.Add("LoginPage", new LoginPage());
            Pages.Add("MainPage", new MainPage());
            Pages.Add("SettingsPage", new SettingsPage());

        }
        public static void FrontHide()
        {
            (CurrentPage as MainPage).FrontFrame.Navigate(null);
        }
        public static void FrontNavigate(string pageName)
        {
            CurrentFrontPage = Pages[pageName];

            (CurrentPage as MainPage).FrontFrame.Navigate(CurrentFrontPage);
        }
        public static void Navigate(string pageName)
        {
            CurrentPage = Pages[pageName];

            CurrentWindow.Frame.Navigate(CurrentPage);
        }
    }
}
