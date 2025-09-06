using System;
using System.Text;

namespace CaesarCipherTest
{
    public class CaesarCipherEncode
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
    }
}