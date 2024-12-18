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
        internal static List<game> games = new List<game>();
        internal static void GetGame()
        {
            Console.WriteLine("Games History");
            foreach (var game1 in games)
            {
                Console.WriteLine($"{game1.Date} - {game1.Type}: {game1.Score} ");
            }

            Console.WriteLine("Press Any key to go back to main menu");
            Console.ReadLine();
        }

        internal static void GetHistory(string typeGame, int scoreCount)
        {

            games.Add(new game
            {
                Date = DateTime.Now,
                Score = scoreCount,
                Type = typeGame
            });

        }
    }
}
