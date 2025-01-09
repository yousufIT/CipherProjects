using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherProects
{
    public class AffineCipher
    {
        public static int ModInverse(int a, int b)
        {
            List<int> r = new List<int>(); 
            List<int> x = new List<int>(); 
            List<int> y = new List<int>(); 

            r.Add(a); 
            r.Add(b); 
            x.Add(1); 
            x.Add(0); 
            y.Add(0); 
            y.Add(1);

            int i = 1;

           
            while (r[i] != 0)
            {
                int q = r[i - 1] / r[i];
                int r1 = r[i - 1] % r[i];
                int x1 = x[i - 1] - q * x[i];
                int y1 = y[i - 1] - q * y[i];
                r.Add(r1);
                x.Add(x1);
                y.Add(y1);

                i++; 
            }

            if (r[i - 1] == 1)
            {
                int inverse = (y[i-1] + a) % a;
                return inverse;
            }
            else
            {
                Console.WriteLine("Modular inverse does not exist");
                return -1;
            }
        }
        public static string Encrypt(string plaintext, int a, int b, int m)
        {
            string ciphertext = "";
            if (ModInverse(m, a) == -1) return "there is no ModInverse";
            foreach (char c in plaintext)
            {
                if (char.IsLetter(c))
                {
                    char enc = (char)((a * (c - 'a') + b) % m + 'a');
                    ciphertext += enc;
                }
                else
                {
                    ciphertext += c; 
                }
                
            }

            return ciphertext;
        }

        public static string Decrypt(string ciphertext, int a, int b, int m)
        {
            string plaintext = "";
            int a_inv = ModInverse(m,a); 
            foreach (char c in ciphertext)
            {
               
                if (char.IsLetter(c))
                {
                    char dec = (char)((a_inv * ((c - 'a' - b  + m)) % m) + 'a');
                    plaintext += dec;
                }
                else
                {
                    plaintext += c; 
                }
            }

            return plaintext;
        }

    }
}
