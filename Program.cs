using System;
using CaesarCipherTest;
using CaesarDecipherTest;
using static System.Console;

namespace EncryptionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Write("Enter a text to scramble: ");
            string plainText = ReadLine();
            int key = 17;

            
            string encryptedText = CaesarCipher.Encryption(plainText, key);

            // Print the result
            WriteLine();
            WriteLine();
            WriteLine($"Encrypted Text: {encryptedText}");
            WriteLine();

            string decipheredText = CaesarDecipher.Decryption(encryptedText,key);

            WriteLine();
            WriteLine($"Decrypted Text: {decipheredText}");
            WriteLine();
            
            ReadKey();
        }
    }
}