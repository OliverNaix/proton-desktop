using System;
using System.Collections.Generic;
using System.Text;

namespace Kernel.Models
{
    public class Message
    {
        public string Text { get; set; }
        public string From { get; set; }
        public bool SendByMe { get; set; }
        public string To { get; set; }
        public string Datetime
        {
            get => DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
