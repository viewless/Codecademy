using System;

namespace Hobbies
{
    class Program
    {
        static void Main(string[] args)
        {

            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "his");

            Console.WriteLine(sam.ViewProfile());
           

            sam.SetHobbies(new string[] { "listening to audiobooks and podcasts", "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice columns" });

        }
    }
}
