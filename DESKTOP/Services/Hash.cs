using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dinobazis.Services
{
    public static class Hash
    {
        public static bool Verify(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(Encrypt(password), hashedPassword);
        }
        public static string Encrypt(string text)
        {
            text += ">^˛^<"; // My special salt
            byte[] textBytes = Encoding.UTF8.GetBytes(text);
            byte[] hash = SHA512.Create().ComputeHash(textBytes);

            string hashedPwd = string.Empty;
            for (int i = 0; i < hash.Length; i++)
            {
                // x - hexadecimal(lowercase), 2 - precision
                hashedPwd += hash[i].ToString("x2");
            }

            return hashedPwd;
        }
    }
}
