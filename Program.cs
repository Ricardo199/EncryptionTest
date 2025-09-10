using System;
using CaesarCipherTest;
using static System.Console;

namespace EncryptionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flg = "y";

            // Loop until user chooses to exit
            while (flg != "n" && flg != "no")
            {

                Console.Clear();
                Write("Enter a text to encript: ");
                string plainText = ReadLine();
                Write("Enter a key (number): ");
                int key = Int32.Parse(ReadLine());

                string encryptedText = CaesarCipher.Encryption(plainText, key);

                // Print the result
                WriteLine();
                WriteLine();
                WriteLine($"Encrypted Text: {encryptedText}");
                WriteLine();

                //Ask user if they want to decrypt the message
                Write("Would you like to decrypt the message? ");
                string dec = ReadLine();
                dec = dec.ToLower();

                if (dec == "y" || dec == "yes")
                {
                    //Decrypt the message
                    string decryptedText = CaesarCipher.Decryption(encryptedText, key);
                    WriteLine();
                    WriteLine($"Decrypted Text: {decryptedText}");
                    WriteLine();
                    flg = "y";
                    Write("Would you like to encrypt another message? ");
                    string again = ReadLine();
                    again = again.ToLower();
                    if (again == "n" || again == "no")
                    {
                        //Exit the program
                        WriteLine("Goodbye!");
                        WriteLine("press any key to exit...");
                        flg = "n";
                        dec = "n";
                        ReadKey();
                    }
                    else
                    {
                        flg = "y";
                    }
                }
                else if (dec == "n" || dec == "no")
                {
                    //Ask user if they want to encrypt another message
                    Write("Would you like to encrypt another message? ");
                    string again = ReadLine();
                    again = again.ToLower();
                    if (again == "n" || again == "no")
                    {
                        //Exit the program
                        WriteLine("Goodbye!");
                        flg = "n";
                        WriteLine("press any key to exit...");
                        ReadKey();
                    }
                    else
                    {
                        flg = "y";
                    }
                }
            }
        }
    }
}