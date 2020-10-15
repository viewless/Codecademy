using System;
using System.ComponentModel;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@#$%&*+?";

            Console.WriteLine("Enter your password:");

            string password = Console.ReadLine();

            int score = 0;

            if (password.Length >= minLength)
            {
                score++;
            }

            for (int i = 0; i < uppercase.Length; i++)
            {
                if (password.Contains(uppercase[i]))
                {
                    score++;
                    break;
                }
            }

            for (int i = 0; i < lowercase.Length; i++)
            {
                if (password.Contains(lowercase[i]))
                {
                    score++;
                    break;
                }
            }

            for (int i = 0; i < digits.Length; i++)
            {
                if (password.Contains(digits[i]))
                {
                    score++;
                    break;
                }
            }

            for (int i = 0; i < specialChars.Length; i++)
            {
                if (password.Contains(specialChars[i]))
                {
                    score++;
                    break;
                }
            }


            switch (score)
            {
                case 1:
                    Console.WriteLine($"{password} scores a {score}. Weak.");
                    break;
                case 2:
                    Console.WriteLine($"{password} scores a {score}. Medium.");
                    break;
                case 3:
                    Console.WriteLine($"{password} scores a {score}. Strong.");
                    break;
                case 4:
                    Console.WriteLine($"{password} scores a {score}. Extremely strong!");
                    break;
                case 5:
                    Console.WriteLine($"{password} scores a {score}. Extremely strong again!");
                    break;
                case 0:
                    Console.WriteLine($"{password} scores a {score}. It’s a bunch of spaces…It doesn’t meet any of the standards.");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}
