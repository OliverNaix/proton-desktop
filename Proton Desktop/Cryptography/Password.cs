using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proton_Desktop.Cryptography
{
    public static class Password
    {
        public static string ConvertToHash(string password)
        {
            return  Convert.ToBase64String(
                    Crypto.ConvertToSHA256(
                    Encoding.UTF8.GetBytes(password)));
        }
    }
}
