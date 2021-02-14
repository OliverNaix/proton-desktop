using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proton_Desktop.Actions
{
    public abstract class Action
    {
        public abstract string Type { get; }
        public abstract void Run(object value);
    }
}
