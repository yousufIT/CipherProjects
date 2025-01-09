using System;

namespace CipherProects
{
    public static class CaeserCipher
    {
        private static string Alphabet = "abcdefghijklmnopqrstuvwxyz";

        public static string Encryption(string p, int k)
        {
            string c = "";
            foreach (char x in p)
            {
                int index = Alphabet.IndexOf(x);
                if (index != -1) 
                {
                    c += Alphabet[(index + k) % Alphabet.Length];
                }
                else
                {
                    c += x;
                }
            }
            return c;
        }

        public static string Descryptioon(string c, int k)
        {
            string p = "";
            foreach (char x in c)
            {
                int index = Alphabet.IndexOf(x);
                if (index != -1) 
                {
                    p += Alphabet[(index - k + Alphabet.Length) % Alphabet.Length];
                }
                else
                {
                    p += x; 
                }
            }
            return p;
        }
    }
}
