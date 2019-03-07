using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGamesProject
{
    class HangMan
    {
        // First Pole 
        private static string pole1 = " "; // |

        //Top Pole
        private static string topPole = "          ";// "__________"

        //Hanger
        private static string hanger = " "; // |

        //Body
        private static string head = " "; // O
        private static string neck = " "; // |
        private static string leftArm = " "; // //
        private static string rightArm = " "; // \\
        private static string torso = " "; // |
        private static string leftLeg = " "; // //
        private static string rightLeg = " ";// \\
        private static int numberOfFails = 0;

        private static Random r = new Random();
        private static string[] words = { "AIRPLANE", "CHICKEN", "DINOSAUR", "HELICOPTER", "TOYOTA", "BUILDING" };
        private static string word = words[r.Next(0, words.Length)];

        public static string placeHolder = " _ ";
        public static char letter;

        public static void displayHangMan()
        {
            Console.WriteLine(".....::::: Hang Man :::::.....\n");
            Console.WriteLine("  {0}", topPole);
            Console.WriteLine("  {0}        {1}", pole1, hanger);
            Console.WriteLine("  {0}        {1}", pole1, head);
            Console.WriteLine("  {0}      {2}{1}{3}", pole1, neck, leftArm, rightArm);
            Console.WriteLine("  {0}        {1}", pole1, torso);
            Console.WriteLine("  {0}      {1} {2} ", pole1,leftLeg, rightLeg);
            Console.WriteLine("  {0}         ", pole1);
            Console.WriteLine("  {0}         ", pole1);
            Console.WriteLine("  {0}         ", pole1);
            Console.WriteLine("  {0}         ",pole1);
            Console.WriteLine("  {0}         ", pole1);
            Console.WriteLine("/------------\\");
            Console.WriteLine("\n");

            initiateGame();

        }

        static void initiateGame()
        {

            foreach (char c in word)
            {
                Console.Write(placeHolder);
            }

            string wordLetter = word;
            char[] array = wordLetter.ToArray();

            Console.WriteLine(word);

            for (int i = 0; i < word.Length; i++)
            {
                Console.Write("Guess the word. Type 1 letter: ");
                letter = Convert.ToChar(Console.ReadLine().ToUpper());
                if (letter != word[i])
                {
                    numberOfFails++;
                    Console.WriteLine("Wrong Letter !");
                }
                    if(numberOfFails == 1)
                    {
                        pole1 = "|";
                        Console.Clear();
                        displayHangMan();
                    }
                    else if (numberOfFails == 2)
                    {
                        pole1 = "|";
                        topPole = "__________";
                        Console.Clear();
                        displayHangMan();
                    }
                    else if (numberOfFails == 3)
                    {
                        pole1 = "|";
                        topPole = "__________";
                        hanger = "|";
                        Console.Clear();
                        displayHangMan();
                    }
                    else if (numberOfFails == 4)
                    {
                        pole1 = "|";
                        topPole = "__________";
                        hanger = "|";
                        head = "O";
                        Console.Clear();
                        displayHangMan();
                    }
                    else if (numberOfFails == 5)
                    {
                        pole1 = "|";
                        topPole = "__________";
                        hanger = "|";
                        head = "O";
                        neck = "|";
                        Console.Clear();
                        displayHangMan();
                    }
                    else if (numberOfFails == 6)
                    {
                        pole1 = "|";
                        topPole = "__________";
                        hanger = "|";
                        head = "O";
                        neck = "|";
                        leftArm = "//";
                        Console.Clear();
                        displayHangMan();
                    }
                    else if (numberOfFails == 7)
                    {
                        pole1 = "|";
                        topPole = "__________";
                        hanger = "|";
                        head = "O";
                        neck = "|";
                        leftArm = "//";
                        rightArm = "\\";
                        Console.Clear();
                        displayHangMan();
                    }
                    else if (numberOfFails == 8)
                    {
                        pole1 = "|";
                        topPole = "__________";
                        hanger = "|";
                        head = "O";
                        neck = "|";
                        leftArm = "//";
                        rightArm = "\\";
                        torso = "|";
                        Console.Clear();
                        displayHangMan();
                    }
                    else if (numberOfFails == 9)
                    {
                        pole1 = "|";
                        topPole = "__________";
                        hanger = "|";
                        head = "O";
                        neck = "|";
                        leftArm = "//";
                        rightArm = "\\";
                        torso = "|";
                        leftLeg = "//";
                        Console.Clear();
                        displayHangMan();
                    }
                    else if (numberOfFails == 10)
                    {
                        pole1 = "|";
                        topPole = "__________";
                        hanger = "|";
                        head = "O";
                        neck = "|";
                        leftArm = "//";
                        rightArm = "\\";
                        torso = "|";
                        leftLeg = "//";
                        rightLeg = "\\";
                        Console.Clear();
                        displayHangMan();

                        Console.WriteLine("You Loose !");
                    }
                }

            //Testing Purposes only
            foreach (char b in array)
            {
                Console.WriteLine(b);
            }

        }

    }
}
