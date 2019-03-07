using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGamesProject
{
    class Program
    {
        public static char choiceMain;

        private static void Main(string[] args)
        {
            Console.Clear();
            showMenu();

        }

        static void showMenu()
        {
            Console.Clear();
            Console.WriteLine(" ......:::::: Mini Games ::::::......");
            Console.WriteLine(" Please select one of the mini-games");
            Console.WriteLine("| A - X/O | B - Hang-Man | C - Snake |");
            choiceMain = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (choiceMain)
            {
                case 'A':
                    XandO.showMenuXO();
                    break;
                case 'B':
                    HangMan.displayHangMan();
                    break;
                case 'C':
                    Snake.snakeGame();
                    break;
                default:
                    Console.WriteLine("Error! That is not an option.");
                    break;
            }
        }
    }
}
