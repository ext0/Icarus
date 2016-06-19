using Icarus.Crypto;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            CryptoKeySecurity sec = new CryptoKeySecurity();
            CspParameters cspp = new CspParameters(1);
            cspp.KeyContainerName = "keySecure";
            /*
            RSACryptoServiceProvider rsa;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = false;
            byte[] data = Encoding.ASCII.GetBytes("Hello World!");
            Console.WriteLine(BitConverter.ToString(data));
            byte[] encrypted = rsa.Encrypt(data, true);
            Console.WriteLine(BitConverter.ToString(encrypted));
            byte[] decrypted = rsa.Decrypt(encrypted, true);
            Console.WriteLine(BitConverter.ToString(decrypted));
            byte[] signed = rsa.SignData(data, CryptoConfig.MapNameToOID("MD5"));
            Console.WriteLine(BitConverter.ToString(signed));
            Console.WriteLine(rsa.VerifyData(data, "MD5", signed));
            */
            Console.ReadLine();
        }
    }
}
