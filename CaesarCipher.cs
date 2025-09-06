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

        public static string Decryption(string ciphertext, int key)
        {
            StringBuilder plaintext = new StringBuilder();

            foreach (char character in ciphertext)
            {
                if (char.IsUpper(character))
                {
                    int newPosition = (character - 'A' - key) % 26;

                    //To wrap-around incase the newPosition value is negative
                    if (newPosition < 0)
                    {
                        newPosition += 26;
                    }

                    char newCharacter = (char)('A' + newPosition);


                    plaintext.Append(newCharacter);
                }
                else if (char.IsLower(character))
                {
                    int newPosition = (character - 'a' - key) % 26;

                    //To wrap-around incase the newPosition value is negative
                    if (newPosition < 0)
                    {
                        newPosition += 26;
                    }

                    char newCharacter = (char)('a' + newPosition);

                    plaintext.Append(newCharacter);
                }
                else
                {
                    plaintext.Append(character);
                }
            }
            return plaintext.ToString();
        }
    }
}