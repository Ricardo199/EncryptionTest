using System;
using System.Text;

namespace CaesarCipherTest
{
    public class CaesarCipher
    {
        public static string Encryption(string plaintext, int key)
        {
            StringBuilder ciphertext = new StringBuilder();

            foreach (char character in plaintext)
            {
                if (char.IsUpper(character))
                {
                    // Shift uppercase character by key, wrap around alphabet
                    char ch = (char)(((character + key - 65) % 26) + 65);
                    ciphertext.Append(ch);
                }
                else if (char.IsLower(character))
                {
                    // Shift lowercase character by key, wrap around alphabet
                    char ch = (char)(((character + key - 97) % 26) + 97);
                    ciphertext.Append(ch);
                }
                else
                {
                    // Non-alphabetic characters are not encrypted
                    ciphertext.Append(character);
                }
            }
            return ciphertext.ToString();
        }

        public static string Decryption(string cipherText, int key)
        {
            StringBuilder decryptedText = new StringBuilder();
            foreach (char c in cipherText)
            {
                if (char.IsLetter(c))
                {
                    // Determine the ASCII offset based on character case ('A' for uppercase, 'a' for lowercase)
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    // Shift character backwards by key, wrap around alphabet using modulo
                    char decryptedChar = (char)((((c + 26) - offset - key) % 26) + offset);
                    decryptedText.Append(decryptedChar);
                }
                else
                {
                    // Non-letter characters are appended unchanged
                    decryptedText.Append(c);
                }
            }
            // Return the fully decrypted string
            return decryptedText.ToString();
        }
    }
}