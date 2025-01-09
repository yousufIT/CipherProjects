using System;
using System.Collections.Generic;
using System.Text;

namespace CipherProjects
{
    public class PlayfairCipher
    {
        private string key; 
        private char[,] keySquare;

        public PlayfairCipher(string key)
        {
            this.key = key.ToUpper();
            this.keySquare = CreateKeySquare(key); 
        }

        private char[,] CreateKeySquare(string key)
        {
            string cleanedKey = Helper.PrepareText(key);

            char[,] square = new char[5, 5];
            List<char> usedLetters = new List<char>();

            int index = 0;

            foreach (char character in cleanedKey)
            {
                if (!usedLetters.Contains(character))
                {
                    square[index / 5, index % 5] = character; 
                    usedLetters.Add(character);
                    index++;
                }
            }
            int i = cleanedKey.IndexOf('I');
            int j = cleanedKey.IndexOf('J');
            if ((j < i || (i == -1 && j > i)) && j >= 0)
            {
                for (char letter = 'A'; letter <= 'Z'; letter++)
                {
                    if (!usedLetters.Contains(letter) && letter != 'I') 
                    {
                        square[index / 5, index % 5] = letter; 
                        index++;
                    }
                }
                return square;
            }
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                if (!usedLetters.Contains(letter) && letter != 'J') 
                {
                        square[index / 5, index % 5] = letter; 
                        index++;
                }
            }
        return square; 
        }

        public string Encrypt(string plaintext)
        {
            string preparedText = Helper.PrepareText(plaintext);

            List<string> digraphs = CreateDigraphs(preparedText);

            StringBuilder ciphertext = new StringBuilder();
            foreach (string digraph in digraphs)
            {
                string encryptedPair = EncryptDigraph(digraph);
                ciphertext.Append(encryptedPair);
            }

            return ciphertext.ToString(); 
        }

        public string Decrypt(string ciphertext)
        {
            string preparedText = Helper.PrepareText(ciphertext);

            List<string> digraphs = CreateDigraphs(preparedText);

            StringBuilder plaintext = new StringBuilder();
            foreach (string digraph in digraphs)
            {
                string decryptedPair = DecryptDigraph(digraph);
                plaintext.Append(decryptedPair);
            }

            return plaintext.ToString(); 
        }

        private List<string> CreateDigraphs(string text)
        {
            List<string> digraphs = new List<string>();
            for (int i = 0; i < text.Length; i += 2)
            {
                string pair = text[i].ToString();
                if (i + 1 < text.Length)
                {
                    if (text[i] == text[i+1])
                    {
                        pair += 'Z';
                        i--;
                    }
                    else
                        pair += text[i + 1]; 
                }
                else
                {
                    pair += 'Z';
                }
                digraphs.Add(pair);
            }
            return digraphs; 
        }

        private string EncryptDigraph(string digraph)
        {
            int row1, col1, row2, col2;
            (row1, col1) = FindPosition(digraph[0]);
            (row2, col2) = FindPosition(digraph[1]);

            string encryptedPair;
            if (row1 == row2)
            {
                encryptedPair = keySquare[row1, (col1 + 1) % 5].ToString() +
                                keySquare[row2, (col2 + 1) % 5].ToString();
            }
            else if (col1 == col2)
            {
                encryptedPair = keySquare[(row1 + 1) % 5, col1].ToString() +
                                keySquare[(row2 + 1) % 5, col2].ToString();
            }
            else
            {
                encryptedPair = keySquare[row1, col2].ToString() +
                                keySquare[row2, col1].ToString();
            }

            return encryptedPair; 
        }

        private string DecryptDigraph(string digraph)
        {
            int row1, col1, row2, col2;
            (row1, col1) = FindPosition(digraph[0]);
            (row2, col2) = FindPosition(digraph[1]);

            string decryptedPair;
            if (row1 == row2)
            {
                decryptedPair = keySquare[row1, (col1 - 1 + 5) % 5].ToString() +
                                keySquare[row2, (col2 - 1 + 5) % 5].ToString();
            }
            else if (col1 == col2)
            {
                decryptedPair = keySquare[(row1 - 1 + 5) % 5, col1].ToString() +
                                keySquare[(row2 - 1 + 5) % 5, col2].ToString();
            }
            else
            {
                decryptedPair = keySquare[row1, col2].ToString() +
                                keySquare[row2, col1].ToString();
            }

            return decryptedPair;
        }

        private (int row, int col) FindPosition(char c)
        {
            for (int r = 0; r < 5; r++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (keySquare[r, col] == c)
                        return (r, col); 
                }
            }
            throw new Exception("Character not found in key square.");
        }

       
    }
}
