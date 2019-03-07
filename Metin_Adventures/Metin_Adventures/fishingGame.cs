using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Metin_Adventures
{
    class fishingGame
    {
        public static int[] fishTime = { 350, 100, 220, 580, 900, 400, 580, 670, 999, 945, 290 };
        public static int stopFishing = 0;

        public static void fishGame()
        {
            Console.WriteLine("Start Fishing ? [Yes/No]");
            Console.Write("Answer: ");
            string ans = Console.ReadLine().ToUpper();

            if (ans == "YES")
            {
                ConsoleKeyInfo cki;
                while (true)
                {
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.X)
                        stopFishing = 1;
                    break;
                }

                Console.WriteLine("To Stop fishing press X at any time.");
                Thread.Sleep(2500);
                Console.Clear();
                Functions.drawGUI();

                while (stopFishing != 1)
                {
                    Random t = new Random();
                    int fTime = fishTime[t.Next(0, fishTime.Length)];

                    int loadingLength = 5;
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 - 3);
                    Console.Write("Fishing..");

                    for (int i = 0; i < loadingLength; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(fTime);
                    }

                    Console.WriteLine("You have a fish on the line !");
                    Thread.Sleep(2500);

                    Console.Clear();
                    Functions.drawGUI();

                    Console.WriteLine("In order to catch the fish you have to guess its WEIGHT.");
                    Console.WriteLine("You only have 4 tries");

                    int tries = 0;
                    Random rnd = new Random();
                    int weight = rnd.Next(1, 10);

                    while (tries != 4)
                    {
                        Console.Write("Guess: ");
                        int guess = Convert.ToInt32(Console.ReadLine());

                        if (guess > weight)
                        {
                            Console.WriteLine("You guessed too BIG ! Try again.");
                            tries++;
                            Console.ReadLine();
                        }
                        else if(guess < weight)
                        {
                            Console.WriteLine("You guessed too SMALL ! Try again.");
                            tries++;
                            Console.ReadLine();
                        }
                        else if (guess == weight)
                        {
                            Console.WriteLine("You guessed the weight of the fish !");
                            Console.WriteLine("The fish was carrying {0}");
                            //add upgrade item to inventory.

                            tries = 4;
                            Console.ReadLine();
                        }
                    }

                }

            }

        }
    }
}
