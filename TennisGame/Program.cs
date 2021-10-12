using System;
using TennisGame.Services;

namespace TennisGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var tennis = new Tennis();
            tennis.GameInfo();
            WriteLineRed("Actual score: " + tennis.GetScore() + "\n");

            while (!tennis.IsFinished())
            {
                Console.Write("Who win this point (0: home, 1: away): ");
                var point = Console.ReadLine();

                if (point == "0")
                    tennis.AssignPointToHome();
                else if (point == "1")
                    tennis.AssignPointToAway();
                else
                    Console.WriteLine("Point is not assigned. Please write 0 to assign point to home, 1 to assign point to away.");

                WriteLineRed("Actual score: " + tennis.GetScore() + "\n");
            }
        }

        private static void WriteLineRed(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
