using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Operaciones : Program
    {
        int resultadoCorrecto;
        int num1;
        int num2;
        string resultado;

        //public Operaciones(int _num1, int _num2, string _resulado)
        //{
        //    num1 = _num1;
        //    num2 = _num2;
        //    resultado = _resulado;
        //}



        public void Addition(string message, List<string> games)
        {
            Menu menu = new Menu();
            Console.Clear();
            Console.WriteLine(message);
            Random random = new Random();

            int scoreCount = 0;
            for (int i = 0; i < 5; i++)
            {

                num1 = random.Next(1, 9);
                num2 = random.Next(1, 9);

                Console.WriteLine($"{num1} + {num2}");
                var input = Console.ReadLine();
                resultadoCorrecto = num1 + num2;

                if (resultadoCorrecto != int.Parse(input))
                {
                    Console.WriteLine("Resultado incorrecto, press any key to continue.");
                    Console.WriteLine(resultadoCorrecto);
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Resultado correcto!!");
                    scoreCount++;
                    Console.WriteLine($"Puntaje {scoreCount}");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                }


                if (i == 4)
                {
                    Console.WriteLine("Game over" + $" Puntaje total {scoreCount} Press Enter to go back to the main menu");
                } 
                
            }
            menu.GetHistory(games, "Addition", scoreCount);
        }
        public void Subtrac(string message, List<string> games)
        {
            Menu menu = new Menu();
            Console.Clear ();
            Console.WriteLine(message);
            Random random = new Random();

            int scoreCount = 0;
            for (int i = 0; i < 5; i++)
            {
                num1 = random.Next(1, 9);
                num2 = random.Next(1, 9);

                Console.WriteLine($"{num1} - {num2}");
                var input = Console.ReadLine();
                resultadoCorrecto = num1 - num2;

                if (resultadoCorrecto != int.Parse(input))
                {
                    Console.WriteLine("Resultado incorrecto, press any key to continue.");
                    Console.WriteLine(resultadoCorrecto);
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Resultado correcto!!");
                    scoreCount++;
                    Console.WriteLine($"Puntaje {scoreCount}");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (i == 4)
                {
                    Console.WriteLine("Game over" + $" Puntaje total {scoreCount} Press Enter to go back to the main menu");
                }


            }
            menu.GetHistory(games, "Subtraction", scoreCount);
        }

        public void Multiply(string message, List<string> games)
        {
            Menu menu = new Menu();
            Console.Clear ();
            Console.WriteLine(message);
            Random random = new Random();
            int scoreCount = 0;
            for (int i = 0; i < 5; i++)
            {
                num1 = random.Next(1, 9);
                num2 = random.Next(1, 9);

                Console.WriteLine($"{num1} x {num2}");
                var input = Console.ReadLine();
                resultadoCorrecto = num1 * num2;

                if (resultadoCorrecto != int.Parse(input))
                {
                    Console.WriteLine("Resultado incorrecto, press any key to continue.");
                    Console.WriteLine(resultadoCorrecto);
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Resultado correcto!!");
                    scoreCount++;
                    Console.WriteLine($"Puntaje {scoreCount}");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (i == 4)
                {
                    Console.WriteLine("Game over" + $" Puntaje total {scoreCount}");
                }
            }
            menu.GetHistory(games, "Subtraction", scoreCount);
        }

        public void Divide(string message, List<string> games)
        {
            Menu menu = new Menu();
            Console.Clear ();
            Console.WriteLine(message);
            Random random = new Random();
            int scoreCount = 0;
            for (int i = 0; i < 5; i++)
            {
                int[] dividenumbers = DivideNumbers();
                num1 = dividenumbers[0];
                num2 = dividenumbers[1];

                Console.WriteLine($"{num1} / {num2}");
                var input = Console.ReadLine();
                resultadoCorrecto = num1 / num2;

                if (resultadoCorrecto != int.Parse(input))
                {
                    Console.WriteLine("Resultado incorrecto, press any key to continue.");
                    Console.WriteLine(resultadoCorrecto);
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Resultado correcto!!");
                    scoreCount++;
                    Console.WriteLine($"Puntaje {scoreCount}");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (i == 4)
                {
                    Console.WriteLine("Game over" + $" Puntaje total {scoreCount}");
                }


            }

            menu.GetHistory(games, "Division", scoreCount);


            int[] DivideNumbers()
            {
                var random = new Random();

                num1 = random.Next(1, 99);
                num2 = random.Next(1, 99);

                while (num1 % num2 != 0)
                {
                    num1 = random.Next(1, 99);
                    num2 = random.Next(1, 99);
                }
                var result = new int[2];
                result[0] = num1;
                result[1] = num2;

                //foreach (int i in result)
                //{
                //    Console.WriteLine(i);
                //}
                //Console.WriteLine(result);
                return result;
            }

        }

    }
}
