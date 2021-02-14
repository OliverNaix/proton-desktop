using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proton_Desktop.Cryptography
{
    public static class Crypto
    {
        public static byte[] ConvertToSHA256(byte[] buffer)
        {
            using (SHA256 sha = SHA256.Create())
            {
                return sha.ComputeHash(buffer);
            }
        }


    }
}
