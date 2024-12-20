using MathGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<game> games = new List<game>
        {
            new game { Date = DateTime.Now.AddDays(-1), Type = GameType.Multiplication, Score = 1 },
            new game { Date = DateTime.Now, Type = GameType.Subtractio, Score = 3},
            new game { Date = DateTime.Now, Type = GameType.Division, Score = 2},
            new game { Date = DateTime.Now.AddDays(-1), Type = GameType.Multiplication, Score = 3},
        };
        internal static void GetGame()
        {
            Console.WriteLine(" 1. Addition \n 2. Subtractio \n 3.Division \n 4. Multiplication");
            Console.WriteLine("what game history do you want?");

            string typeGame = Console.ReadLine();

            if (Enum.TryParse(typeGame, true, out GameType parsedGameType))
            {
                var gamesPrint = games.Where(x => x.Type == parsedGameType);

                Console.WriteLine("Games History");
                foreach (var game1 in gamesPrint)
                {
                    Console.WriteLine($"{game1.Date} - {game1.Type}: {game1.Score} ");
                }

                Console.WriteLine("Press Any key to go back to main menu");
                Console.ReadLine();
            }


        }

        internal static void GetHistory(GameType typeGame, int scoreCount)
        {

            games.Add(new game
            {
                Date = DateTime.Now,
                Score = scoreCount,
                Type = typeGame
            });

        }

        internal static string? ValidationMenu(string input)
        {
            while (string.IsNullOrEmpty(input) || !Int32.TryParse(input, out _)) 
                {
                Console.WriteLine("The option is invalid");
                input = Console.ReadLine();
            }
            return input;
        }

        internal static string? ValidationGame(string input)
        {
            while (string.IsNullOrEmpty(input) || !Int32.TryParse(input, out _))
            {
                Console.WriteLine("The value is invalid");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
