using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherProjects
{
    public class HillCipher
    {
        private int[,] keyMatrix;
        private int determinant;
        private int determinantInverse;

        public HillCipher(int[,] keyMatrix)
        {
            this.keyMatrix = keyMatrix;
            this.determinant = (keyMatrix[0, 0] * keyMatrix[1, 1] - keyMatrix[0, 1] * keyMatrix[1, 0]) % 26;
            this.determinantInverse = ModularInverse(determinant, 26);
            if (determinantInverse == -1)
            {
                throw new ArgumentException("Invalid key matrix, determinant has no modular inverse.");
            }
        }

        public string Encrypt(string text)
        {
            return ProcessText(text, keyMatrix);
        }

        public string Decrypt(string text)
        {
            int[,] inverseMatrix = {
            { (keyMatrix[1, 1] * determinantInverse) % 26, (-keyMatrix[0, 1] * determinantInverse + 26) % 26 },
            { (-keyMatrix[1, 0] * determinantInverse + 26) % 26, (keyMatrix[0, 0] * determinantInverse) % 26 }
        };
            return ProcessText(text, inverseMatrix);
        }

        private string ProcessText(string text, int[,] matrix)
        {
            string result = "";
            text = text.Replace(" ", "").ToLower();
            for (int i = 0; i < text.Length; i += 2)
            {
                int[] pair = { text[i] - 'a', (i + 1 < text.Length ? text[i + 1] - 'a' : 'x' - 'a') };
                int[] transformed = {
                (matrix[0, 0] * pair[0] + matrix[0, 1] * pair[1]) % 26,
                (matrix[1, 0] * pair[0] + matrix[1, 1] * pair[1]) % 26
            };
                result += (char)(transformed[0] + 'a');
                result += (char)(transformed[1] + 'a');
            }
            return result;
        }

        private int ModularInverse(int a, int m)
        {
            for (int i = 1; i < m; i++)
            {
                if ((a * i) % m == 1)
                    return i;
            }
            return -1;
        }
    }

}
