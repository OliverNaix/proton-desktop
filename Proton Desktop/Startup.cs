using ProtonKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proton_Desktop
{
    public class Startup
    {
        public Startup()
        { 
        
        }

        public async void InitializeNetwork()
        {
            await Client.ConnectAsync(
                new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9015)
                );
        }
    }
}
