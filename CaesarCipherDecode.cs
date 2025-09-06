using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionTest
{
    internal class CaesarCipherDecode
    {
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
