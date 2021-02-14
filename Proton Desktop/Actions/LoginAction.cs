using System;

namespace Proton_Desktop.Actions
{
    class LoginAction : Action
    {
        public override string Type
        {
            get => "login_action";
        }

        public override void Run(object value)
        {
            if (Convert.ToBoolean(value.ToString()) == true)
            {   
                AppNavigation.Navigate("PasswordPage");
            }
            else
            {
                AppNavigation.Navigate("RegistrationPage");
            }
        }
    }
}
