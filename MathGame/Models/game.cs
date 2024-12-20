using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Models
{
    internal class game
    {
        public DateTime Date { get; set; }

        public int Score { get; set; }
        public GameType Type { get; set; }
    }

    internal enum GameType
    {
        Addition,
        Subtractio,
        Multiplication,
        Division
    }
}
