using System;
using CaesarCipherTest;
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

            // This is the correct way to call the static method.
            string encryptedText = CaesarCipher.Encryption(plainText, key);

            // Print the result
            WriteLine($"Original Text: {plainText}");
            WriteLine();
            WriteLine();
            WriteLine($"Encrypted Text: {encryptedText}");
            WriteLine();
            WriteLine();

            ReadKey();
        }
    }
}