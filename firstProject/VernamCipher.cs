using System;

namespace CipherProjects
{
    public class VernamCipher
    {
        private string key; 
        public VernamCipher(string key)
        {
            Initialize(key);
        }

        private void Initialize(string key)
        {
            this.key = key.ToUpper();
        }

        public string Encrypt(string plaintext)
        {
            string preparedText = Helper.PrepareText(plaintext);
            if (preparedText.Length != key.Length)
            {
                return "Error: Key length must be equal to plaintext length.";
            }

            char[] ciphertextArray = new char[preparedText.Length];
            for (int i = 0; i < preparedText.Length; i++)
            {
                int p = Helper.ConvertCharToBinary(preparedText[i]);
                int k = Helper.ConvertCharToBinary(this.key[i]);
                int c = p ^ k;
                ciphertextArray[i] = Helper.ConvertBinaryToChar(c);
            }
            string ciphertext = new string(ciphertextArray);
            return Helper.ConvertToBase64(ciphertext);
        }

        public string Decrypt(string ciphertext)
        {
            string decodedText = Helper.ConvertFromBase64(ciphertext);

            if (decodedText.Length != key.Length)
            {
                return "Error: Key length must be equal to ciphertext length.";
            }

            char[] plaintextArray = new char[decodedText.Length];
            for (int i = 0; i < decodedText.Length; i++)
            {
                int c = Helper.ConvertCharToBinary(decodedText[i]);
                int k = Helper.ConvertCharToBinary(this.key[i]);
                int p = c ^ k;
                plaintextArray[i] = Helper.ConvertBinaryToChar(p);
            }

            return new string(plaintextArray);
        }

       
    }
}
