using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

public class SHA
{
    public string ComputeSHA256Hash(string input)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = sha256.ComputeHash(bytes);

            StringBuilder result = new StringBuilder();
            foreach (byte b in hashBytes)
                result.Append(b.ToString("x2"));

            return result.ToString();
        }
    }

    public string ComputeFileSHA256Hash(string filePath)
    {
        using (SHA256 sha256 = SHA256.Create())
        using (FileStream fileStream = File.OpenRead(filePath))
        {
            byte[] hashBytes = sha256.ComputeHash(fileStream);

            StringBuilder result = new StringBuilder();
            foreach (byte b in hashBytes)
                result.Append(b.ToString("x2"));

            return result.ToString();
        }
    }
}
