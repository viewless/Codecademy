using System;
using System.Dynamic;
using System.Threading;

namespace Mad_Libs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is a story game");
            Thread.Sleep(3000);
            Console.WriteLine();
            Console.WriteLine("Author: Viewless");
            Thread.Sleep(3000);
            Console.WriteLine();

            Console.WriteLine("Lets begin...");
            Thread.Sleep(3000);
            Console.WriteLine();
            // Give the Mad Lib a title:
            string title = "Roses...";

            Console.WriteLine(title);
            Thread.Sleep(3000);
            Console.WriteLine();
            // Define user input and variables:


            // The template for the story:


            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter three adjectives:");
            string firstAdj = Console.ReadLine();
            string secondAdj = Console.ReadLine();
            string thirdAdj = Console.ReadLine();

            Console.WriteLine("Enter a verb:");
            string verb = Console.ReadLine();

            Console.WriteLine("Enter two nouns:");
            string firstNoun = Console.ReadLine();
            string secondNoun = Console.ReadLine();

            Console.WriteLine("Enter an animal:");
            string animal = Console.ReadLine();
            Console.WriteLine("Enter a food:");
            string food = Console.ReadLine();
            Console.WriteLine("Enter a fruit:");
            string fruit = Console.ReadLine();
            Console.WriteLine("Enter a superhero:");
            string superhero = Console.ReadLine();
            Console.WriteLine("Enter a country:");
            string country = Console.ReadLine();
            Console.WriteLine("Enter a dessert:");
            string dessert = Console.ReadLine();
            Console.WriteLine("Enter a year:");
            string year = Console.ReadLine();




            // Print the story:

            string story = $"This morning {name} woke up feeling {firstAdj}. 'It is going to be a {secondAdj} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {thirdAdj}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {secondNoun}s ruled the world.";


            Console.WriteLine(story);
        }
    }
}
