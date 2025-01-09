namespace CipherProects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaeserCipher caeserCipher = new CaeserCipher();
            //Console.WriteLine("please enter the word for cipher:");
            //string word=Console.ReadLine();
            //Console.WriteLine("please enter K:");
            //string k = Console.ReadLine();
            //var c=caeserCipher.Encryption(word,int.Parse( k));
            //Console.WriteLine(c);
            //Console.WriteLine(caeserCipher.Descryptioon(c, int.Parse(k)));

            int a = 5; 
            int b = 8; 
            int m = 26; 
            string plaintext = "affine cipher";

            string ciphertext = AffineCipher.Encrypt(plaintext, a, b, m);
            Console.WriteLine(ciphertext);

            string decryptedText = AffineCipher.Decrypt(ciphertext, a, b, m);
            Console.WriteLine(decryptedText);



















            Console.ReadKey();


            
        }
    }
}
