using System;

namespace EncryptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region AES Encryption

            //your Key
            Console.WriteLine("Please enter a password to use:");
            string password = Console.ReadLine();

            //string to encrypt
            Console.WriteLine("Please enter a string to encrypt:");
            string plaintext = Console.ReadLine();
            Console.WriteLine();

            //encryption value
            Console.WriteLine("Your encrypted string is:");
            string encryptedstring = StringCipher.Encrypt(plaintext, password);
            Console.WriteLine(encryptedstring);
            Console.WriteLine();

            //decryption
            Console.WriteLine("Your decrypted string is:");
            string decryptedstring = StringCipher.Decrypt(encryptedstring, password);
            Console.WriteLine(decryptedstring);

            #endregion


            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
