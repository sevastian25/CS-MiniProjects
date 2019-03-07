using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;


namespace GuessTheNumber
{
    class Program
    {
        public static int guesses = 10;
        public static int score;
        public static bool correct = false;
        public static bool again = false;

        static void Main(string[] args)
        {
            Console.Clear();
            optionMenu();
        }

        static void guessNumber()
        {
            Random r = new Random();

            int val = r.Next(1, 100);
            int guess = 0;

            //Console.WriteLine("The magic number is {0}", val); //Used for testing purposes only
            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            while (!correct)
            {
                Console.Write("Guess: ");
                string input = Console.ReadLine();
                Thread.Sleep(250);

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("That's not a number.");
                    continue;
                }

                if (guesses <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("You didn't guess the number.");
                    Console.WriteLine("You scored 0 points.");
                    Console.ReadKey();
                    break;
                }

                if (guess < val)
                {
                    Console.Clear();
                    Console.WriteLine("No, the number I'm thinking is higher than {0}", guess);
                    guesses--;
                    Console.WriteLine("You got {0} remaining tries.", guesses);
                }
                else if (guess > val)
                {
                    Console.Clear();
                    Console.WriteLine("No, the number I'm thinking is lower than {0}", guess);
                    guesses--;
                    Console.WriteLine("You got {0} remaining tries.", guesses);
                }
                else
                {
                    Console.Clear();
                    correct = true;
                    Console.WriteLine("You guessed right!");
                    score = guesses * 10;
                    Console.WriteLine("You scored {0} points and had {1} remaining tries.", score, guesses);

                    Console.Write("Please enter your name: ");
                    string name = Console.ReadLine();
                    try
                    {
                        using (StreamWriter sw = new StreamWriter("C:/Users/2640/source/repos/GuessTheNumber/GuessTheNumber/ranks.txt", true))
                        {
                            sw.WriteLine("{0} | {1} points", name, score);
                            sw.Close();
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }

                    Thread.Sleep(500);
                    Console.WriteLine("Thanks for playing {0} !", name);
                    Thread.Sleep(3500);
                }
            }
        }

        static void optionMenu()
        {
            while (!again)
            {
                char option;

                Console.WriteLine("\n ......::::: Guess the Number Game :::::......");
                Console.WriteLine(" Please select one of the options available");
                Console.WriteLine(" S - Start Game | V - View Leaderboard | X - Exit");
                Console.WriteLine("          | C - Clear Leaderboard |               ");
                Console.Write(" Option: ");
                option = Convert.ToChar(Console.ReadLine().ToUpper());

                switch (option)
                {
                    case 'S':
                        Thread.Sleep(500);
                        Console.Clear();
                        guessNumber();
                        break;
                    case 'V':
                        Console.Clear();
                        Console.WriteLine("......::::: Leaderboard :::::......");
                        try
                        {
                            using (StreamReader sr = new StreamReader("C:/Users/2640/source/repos/GuessTheNumber/GuessTheNumber/ranks.txt", true))
                            {
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine(line);
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Exception: " + e.Message);
                        }
                        break;
                    case 'C':
                        char ans;
                        Console.WriteLine(" Are you sure you want to clear the Leaderboard ?");
                        Console.WriteLine(" Y - Yes | N - No ");
                        ans = Convert.ToChar(Console.ReadLine().ToUpper());

                        switch(ans)
                        {
                            case 'Y':
                                Console.Clear();
                                File.WriteAllBytes("C:/Users/2640/source/repos/GuessTheNumber/GuessTheNumber/ranks.txt", new byte[0]);
                                break;
                            case 'N':
                                Console.Clear();
                                optionMenu();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 'X':
                        Console.Clear();
                        for (int i = 0; i < 101; i++)
                        {
                            Thread.Sleep(7);
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("Application exitting. Good bye ! {0}%", i);
                        }
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Error! Invalid option selected.");
                        break;
                }
            }
        }

    }
}