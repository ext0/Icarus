using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Icarus.Crypto
{
    public class RandomString
    {
        private char[] CharSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
        internal char[] BuiltChars;
        public RandomString(int Length, CspParameters Csp = null)
        {
            byte y = 0xFF;
            BuiltChars = new char[Length];
            using (RNGCryptoServiceProvider rng = (Csp == null) ? new RNGCryptoServiceProvider() : new RNGCryptoServiceProvider(Csp))
            {
                byte[] data = new byte[2];
                for (int i = 0; i < Length; i++)
                {
                    rng.GetBytes(data);
                    y = (byte)((data[0] + data[1]) % CharSet.Length);
                    BuiltChars[i] = CharSet[y];
                }
            }
        }
        static public implicit operator String(RandomString RS)
        {
            return new String(RS.BuiltChars);
        }
    }
}
