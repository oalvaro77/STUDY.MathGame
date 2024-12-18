
namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.GetName();
            var games = new List<string>();
          
            menu.MainMenu(games);
        }


        
    }

    
}
