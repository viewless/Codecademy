using System;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };


            string message = Console.ReadLine();
            char[] secretMessage = message.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];


            Random random = new Random();

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char temp = secretMessage[i];

                int ran = random.Next(1, 26);
                var index = (Array.IndexOf(alphabet, temp));
                index = (index + ran) % alphabet.Length;

                encryptedMessage[i] = alphabet[index];
            }

            foreach (var item in encryptedMessage)
            {
                Console.Write(item);
            }
        }
    }
}
