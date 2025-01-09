using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CipherProjects
{
    public class ADFGVXCipher
    {
        private string key; 
        private char[,] polybiusSquare; 
        private string adfgvxChars = "ADFGVX"; 

        public ADFGVXCipher(string key)
        {
            this.key = key.ToUpper();
            this.polybiusSquare = CreatePolybiusSquare();
        }

        private char[,] CreatePolybiusSquare()
        {
            char[,] square = new char[6, 6];
            HashSet<char> usedChars = new HashSet<char>();
            int index = 0;

            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (!usedChars.Contains(c))
                {
                    square[index / 6, index % 6] = c;
                    usedChars.Add(c);
                    index++;
                }
            }

            for (char c = '0'; c <= '9'; c++)
            {
                if (!usedChars.Contains(c))
                {
                    square[index / 6, index % 6] = c; 
                    usedChars.Add(c);
                    index++;
                }
            }

            return square; 
        }

        public string Encrypt(string plaintext)
        {
            string preparedText = Helper.PrepareText(plaintext);

            StringBuilder encodedText = new StringBuilder();
            foreach (char c in preparedText)
            {
                (int row, int col) = FindPosition(c); 
                encodedText.Append(adfgvxChars[row]);
                encodedText.Append(adfgvxChars[col]); 
            }

            string transposedText = Transpose(encodedText.ToString());

            return transposedText;
        }

        public string Decrypt(string ciphertext)
        {
            string encodedText = ReverseTranspose(ciphertext);

            StringBuilder plaintext = new StringBuilder();
            for (int i = 0; i < ciphertext.Length; i += 2)
            {
                int row = FindRowIndex(encodedText[i]);
                int col = FindColIndex(encodedText[i + 1]);
                plaintext.Append(polybiusSquare[row, col]);
            }

            return plaintext.ToString();
        }

        private (int, int) FindPosition(char c)
        {
            for (int r = 0; r < 6; r++)
            {
                for (int col = 0; col < 6; col++)
                {
                    if (polybiusSquare[r, col] == c)
                        return (r, col);
                }
            }
            throw new Exception("Character not found in Polybius square.");
        }

        private string Transpose(string text)
        {
            int numRows = (int)Math.Ceiling((double)text.Length / key.Length);
            char[,] table = new char[numRows, key.Length];

            int textIndex = 0;
            for (int r = 0; r < numRows; r++)
            {
                for (int c = 0; c < key.Length; c++)
                {
                    if (textIndex < text.Length)
                    {
                        table[r, c] = text[textIndex++];
                    }
                    else
                    {
                        table[r, c] = '\0';
                    }
                }
            }

            int[] keyOrder = GetKeyOrder();

            StringBuilder result = new StringBuilder();
            for (int k = 0; k < key.Length; k++)
            {
                int col = keyOrder[k];
                for (int r = 0; r < numRows; r++)
                {
                    if (table[r, col] != '\0')
                    {
                        result.Append(table[r, col]);
                    }
                }
            }

            return result.ToString();
        }

        private string ReverseTranspose(string text)
        {
            int numRows = (int)Math.Ceiling((double)text.Length / key.Length);
            char[,] table = new char[numRows, key.Length];
            if (numRows * key.Length > text.Length)
            {
                int temp = numRows * key.Length - text.Length;
                while (temp > 0)
                {
                    table[numRows - 1, key.Length - temp] = '1';
                    temp--;
                }
            }
            int[] keyOrder = GetKeyOrder();

            int textIndex = 0;
            for (int k = 0; k < key.Length; k++)
            {
                int col = keyOrder[k];
                for (int r = 0; r < numRows; r++)
                {
                    if (table[r,col]=='1') continue;
                    if (textIndex < text.Length)
                    {
                        table[r, col] = text[textIndex++];
                    }
                }
            }

            StringBuilder result = new StringBuilder();
            for (int r = 0; r < numRows; r++)
            {
                for (int c = 0; c < key.Length; c++)
                {
                    if (table[r, c] != '\0')
                    {
                        result.Append(table[r, c]);
                    }
                }
            }

            return result.ToString();
        }

        private int FindRowIndex(char ch)
        {
            return adfgvxChars.IndexOf(ch);
        }

        private int FindColIndex(char ch)
        {
            return adfgvxChars.IndexOf(ch);
        }


        private int[] GetKeyOrder()
        {
            char[] keyChars = key.ToCharArray();
            int[] order = Enumerable.Range(0, key.Length).ToArray();

            Array.Sort(keyChars, order);
            return order;
        }
    }
}
