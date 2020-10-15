using System;

namespace Spacemane_Game
{
    class Program
    {
        static void Main(string[] args)
        {
           Game game = new Game();
            game.Greet();
            do
            {
                game.Display();
                game.Ask();
                if (game.DidLose())
                {
                    game.Display();
                    Console.WriteLine("Oh no! The UFO just flew away with another person!");
                    break;
                }
                else if (game.DidWin())
                {
                    game.Display();
                    Console.WriteLine("Hooray! You saved the person and earned a medal of honor!");
                    break;
                }
            } while (true);

           
        }
  }
}
