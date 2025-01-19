using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

public class SHA
{
    public string ComputeSHA512Hash(string input)
    {
        using (SHA512 sha512 = SHA512.Create())
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = sha512.ComputeHash(bytes);

            StringBuilder result = new StringBuilder();
            foreach (byte b in hashBytes)
                result.Append(b.ToString("x2"));

            return result.ToString();
        }
    }

    public string ComputeFileSHA512Hash(string filePath)
    {
        using (SHA512 sha512 = SHA512.Create())
        using (FileStream fileStream = File.OpenRead(filePath))
        {
            byte[] hashBytes = sha512.ComputeHash(fileStream);

            StringBuilder result = new StringBuilder();
            foreach (byte b in hashBytes)
                result.Append(b.ToString("x2"));

            return result.ToString();
        }
    }
}
