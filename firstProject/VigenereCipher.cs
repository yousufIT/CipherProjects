using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherProjects
{
    public class VigenereCipher
    {
        private string key;

        public VigenereCipher(string key)
        {
            this.key = key.ToUpper();
        }

        public string Encrypt(string text)
        {
            return ProcessText(text, (p, k) => (p + k) % 26);
        }

        public string Decrypt(string text)
        {
            return ProcessText(text, (c, k) => (c - k + 26) % 26);
        }

        private string ProcessText(string text, Func<int, int, int> func)
        {
            string result = "";
            int keyIndex = 0;

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    int textPos = c - offset;
                    int keyPos = key[keyIndex % key.Length] - 'A';
                    result += (char)(func(textPos, keyPos) + offset);
                    keyIndex++;
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }
    }

}
