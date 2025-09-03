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
                    int newPosition = (character - 'A' + key) % 26;

                    char newCharacter = (char)('A' + newPosition);

                    ciphertext.Append(newCharacter);
                }

                else if (char.IsLower(character))
                {
                    int newPosition = (character - 'a' + key) % 26;

                    char newCharacter = (char)('a' + newPosition);

                    ciphertext.Append(newCharacter);
                }

                else
                {
                    ciphertext.Append(character);
                }
            }
            return ciphertext.ToString();
        }
    }
}