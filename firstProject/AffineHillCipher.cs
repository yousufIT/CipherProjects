using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherProjects
{
    public class AffineHillCipher
    {
        private static string alphabet = "abcdefghijklmnopqrstuvwxyz";

        public string Encryption(string plainText, int[,] key1, int[,] key2)
        {
            if (plainText.Length % 2 != 0) plainText += 'z';

            StringBuilder sb = new StringBuilder();
            int[,] arr = PrepareMatrix(plainText);

            int[,] result = Helper.Multiplication(key1, arr);
            result = Helper.Summation(result, key2);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    int num = (result[i, j] % 26 + 26) % 26;
                    sb.Append(alphabet[num]);
                }
            }

            return sb.ToString();
        }

        public string Decryption(string cipherText, int[,] key1, int[,] key2)
        {
            if (cipherText.Length % 2 != 0) cipherText += 'z';

            int[,] inversekey1 = Helper.Inverse(key1, 26);

            StringBuilder sb = new StringBuilder();
            int[,] arr = PrepareMatrix(cipherText);
            arr = Helper.Subtraction(arr, key2, 26);

            int[,] result = Helper.Multiplication(inversekey1, arr);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    int num = (result[i, j] % 26 + 26) % 26;
                    sb.Append(alphabet[num]);
                }
            }

            return sb.ToString();
        }

        private int[,] PrepareMatrix(string text)
        {
            int len = text.Length;
            int[,] arr = new int[2, len / 2];
            for (int i = 0; i < len; i++)
            {
                arr[i / (len / 2), i % (len / 2)] = alphabet.IndexOf(text[i]);
            }
            return arr;
        }
    }
}

