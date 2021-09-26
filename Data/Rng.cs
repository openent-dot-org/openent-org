using System;
using System.Security.Cryptography;

namespace ECNcloud.Data
{
    public class Rng
    {
        private RNGCryptoServiceProvider Rand = new();

        private int RandomInteger(int min, int max)
        {
            uint scale = uint.MaxValue;
            while (scale == uint.MaxValue)
            {
                byte[] fourBytes = new byte[4];
                Rand.GetBytes(fourBytes);
                scale = BitConverter.ToUInt32(fourBytes, 0);
            }

            return (int) (min + (max - min) * (scale / (double) uint.MaxValue));
        }

        public string[] GetKeys()
        {
            string finalUserKey = "";
            string finalUserSubdirectory = "";
            char[] finalKey = new char[48];
            const string characters = "0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF";
            for (int i = 0; i < 48; ++i)
            {
                int random = RandomInteger(1, 36);
                finalKey[i] = characters[random];
            }

            Console.WriteLine("");
            for (int i = 0; i < 48; ++i)
            {
                finalUserKey += finalKey[i];
            }

            char[] finalSubdirectory = new char[48];
            const string characters2 = "0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF";
            for (int i = 0; i < 48; ++i)
            {
                int random = RandomInteger(1, 36);
                finalSubdirectory[i] = characters2[random];
            }

            Console.WriteLine("");
            for (int i = 0; i < 48; ++i)
            {
                finalUserSubdirectory += finalSubdirectory[i];
            }

            return new[] {finalUserKey, finalUserSubdirectory};
        }
    }
}