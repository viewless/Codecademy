using System;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            Console.Write("Enter an amount to convert to coins: ");

            double money = double.Parse(Console.ReadLine());

            Console.WriteLine(money + " cents are equal to...");



            int goldValue = 10;
            int silverValue = 5;


            double goldCoins = Math.Floor(money / goldValue);
            double remainder = money % goldValue;


            double silverCoins = Math.Floor(remainder / silverValue);
            remainder %= silverValue;

            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {remainder}");
        }
    }
}
