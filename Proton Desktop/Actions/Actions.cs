using ProtonKernel.Models;
using System.Collections.Generic;


namespace Proton_Desktop.Actions
{
    public static class Actions
    {
        public static List<Action> ActionList { get; set; }
        public static void Add(Action action)
        {
            if (ActionList == null)
            {
                ActionList = new List<Action>();
            }

            ActionList.Add(action);
        }

        public static void Init()
        {
            Add(new LoginAction());
            Add(new PasswordAction());
        }

        public static void RunAction(Update update)
        {
            foreach (var i in ActionList)
            {
                if (i.Type == update.Type)
                {
                    i.Run(update.Object);

                    return;
                }
            }
        }
    }
}
