using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Menu
    {
        public void MainMenu(List<string> games)
        {
            bool gameOn = true;
            do
            {
                
                Console.WriteLine("===== Main Menu ======");
                Console.WriteLine(1 + " Sum two numbers");
                Console.WriteLine(2 + " Subtract two numbers");
                Console.WriteLine(3 + " Multiply two numbers");
                Console.WriteLine(4 + " Divide two numbers");
                Console.WriteLine(5 + " Game History");
                Console.WriteLine(6 + " Exit");

                Console.WriteLine("Seleccionar una operacion: ");
                string input = Console.ReadLine();
                Operaciones operaciones = new Operaciones();
                switch (input)
                {
                    case "1":

                        
                        operaciones.Addition("Select addition", games);
                        break;

                    case "2":
                        operaciones.Subtrac("Select subtract");
                        break;

                    case "3":
                        operaciones.Multiply("Select Multiply");
                        break;
                    case "4":
                        operaciones.Divide("Select Divide");
                        break;

                    case "5":
                        GetGame(games);
                        break;
                        

                    case "6":
                        Console.WriteLine("Select Exit");
                        gameOn = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;



                }


            } while (gameOn);

        }

        public void GetName()
        {
            Console.WriteLine("Welcome, enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"{name} has register at {DateTime.Now}");


        }

        public void GetGame(List<string> games)
        {
            Console.WriteLine("Games History");
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }

            Console.WriteLine("Press Any ket to go back to main menu");
            Console.ReadLine();
        }

        public void GetHistory(List<string> games, string typeGame, int scoreCount) {
            games.Add($"{DateTime.Now} - {typeGame}: score {scoreCount}");

        }
    
}
