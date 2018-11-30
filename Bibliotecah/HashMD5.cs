using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecah
{
    class HashMD5
    {
        public static string GetMD5(MD5 md5Hash, string cadena)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(cadena));
            StringBuilder sBuilder = new StringBuilder();

            for (int x = 0; x < data.Length; x++)
            {
                sBuilder.Append(data[x].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static bool VerfyMD5(MD5 md5Hash, string cadena, string hash)
        {
            string hashEntrada = GetMD5(md5Hash, cadena);

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashEntrada, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
