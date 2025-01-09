using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherProjects
{
    public class Helper
    {
        public static string PrepareText(string text)
        {
            return text.Replace(" ", "").ToUpper();
        }

        public static int ConvertCharToBinary(char ch)
        {
            return (int)ch;
        }

        public static char ConvertBinaryToChar(int binary)
        {
            return (char)binary;
        }

        public static string ConvertToBase64(string input)
        {
            byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(inputBytes);
        }

        public static string ConvertFromBase64(string base64Input)
        {
            byte[] decodedBytes = Convert.FromBase64String(base64Input);
            return System.Text.Encoding.UTF8.GetString(decodedBytes);
        }

        public static int Det2DArray(int[,] matrix)
        {
            if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2) throw new Exception("matrix should be 2x2");
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }

        public static int[,] Multiplication(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(0) != 2 || matrix1.GetLength(1) != 2) throw new Exception("matrix1 should be 2x2");
            int n = matrix2.GetLength(0);
            int m = matrix2.GetLength(1);
            if (n != 2) throw new Exception("matrix should be 2xm");

            int[,] result = new int[2, m];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result[i, j] = matrix1[i, 0] * matrix2[0, j] + matrix1[i, 1] * matrix2[1, j];
                }
            }

            return result;
        }

        public static int[,] Summation(int[,] matrix1, int[,] matrix2)
        {
           
            int n = matrix1.GetLength(1); // Get the number of columns

            int[,] result = new int[2, n]; // Create a result matrix with the same size

            // Perform element-wise addition
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        public static int[,] Subtraction(int[,] matrix1, int[,] matrix2, int modValue)
        {
           
            int n = matrix1.GetLength(1); // Get the number of columns

            int[,] result = new int[2, n]; // Create a result matrix with the same size

            // Perform element-wise subtraction
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];

                    // If the result is negative, apply the modulo operation directly
                    if (result[i, j] < 0)
                    {
                        result[i, j] = (result[i, j] % -modValue + modValue) % modValue; // Ensure non-negative result
                    }
                }
            }

            return result;
        }



        public static int[,] Inverse(int[,] matrix, int mod)
        {
            if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
                throw new Exception("matrix should be 2x2");

            int det = Det2DArray(matrix) % mod;
            if (det < 0) det += mod;

            // Find the modular inverse of the determinant in modulo 26
            int detInverse = ModInverse(det, mod);
            if (detInverse == -1)
                throw new Exception("Determinant has no modular inverse, so the key matrix is invalid.");

            int[,] adjugate = {
        { matrix[1, 1], -matrix[0, 1] },
        { -matrix[1, 0], matrix[0, 0] }
    };

            // Apply modular inverse and mod to adjugate
            int[,] result = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = (detInverse * adjugate[i, j] % mod + mod) % mod;
                }
            }
            return result;
        }

        public static int ExtendedGcd(int a, int b, ref List<(int x, int y)> values)
        {
            if (values.Count == 0)
            {
                values = [(1, 0), (0, 1)];
            }

            var value0 = values.SkipLast(1).Last();
            var value1 = values.Last();

            int r = a % b;

            if (r == 0)
            {
                return b;
            }

            int q = a / b;
            int x = value0.x - q * value1.x;
            int y = value0.y - q * value1.y;

            values.Add((x, y));

            return ExtendedGcd(b, a % b, ref values);

        }

        public static int ModInverse(int a, int m)
        {
            List<(int x, int y)> values = new List<(int x, int y)>();

            int gcd = ExtendedGcd(a, m, ref values);

            if (gcd != 1)
            {
                throw new Exception("Modular inverse does not exist as gcd(a, m) != 1.");
            }

            int modInverse = values.Last().x;

            if (modInverse < 0)
            {
                modInverse += m;
            }

            return modInverse;
        }
        public static int[,] CreateMatrixB(string b1,string b2)
        {
            if(b1.Length!=b2.Length)
                throw new NotImplementedException();
            int[,] matrix = new int[2, b1.Length];
            b1 = b1.Replace(",","");
            b2 = b2.Replace(",", "");
            for(int i = 0; i < b1.Length; i++)
            {
                matrix[0,i] = (int)b1[i];
                matrix[1,i] = (int)b2[i];
            }
            return matrix;
        }

    }
}

