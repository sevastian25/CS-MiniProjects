using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MiniGamesProject
{
    class XandO
    {
        private static string nameP1;
        private static string nameP2;

        private static string A1 = " "; private static string A2 = " "; private static string A3 = " ";
        private static string B1 = " "; private static string B2 = " "; private static string B3 = " ";
        private static string C1 = " "; private static string C2 = " "; private static string C3 = " ";

        private static string pick1, pick2;

        private static bool A1en = true; private static bool A2en = true; private static bool A3en = true;
        private static bool B1en = true; private static bool B2en = true; private static bool B3en = true;
        private static bool C1en = true; private static bool C2en = true; private static bool C3en = true;


        private static bool turn1 = true;
        private static bool turn2 = false;
        private static bool end = false;

        private static char choiceXO;

        public static void showMenuXO()
        {
            Console.Clear();
            Console.Write("Please enter Player1's name: ");
            nameP1 = Console.ReadLine();
            Console.Write("Please enter Player2's name: ");
            nameP2 = Console.ReadLine();
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine(" ......:::::: X and O ::::::......");
            Console.WriteLine("Welcome {0} & {1}, What would you like to do ?", nameP1, nameP2);
            Console.WriteLine("| A - Start Game | B - View Leader Board | X - Exit |");
            choiceXO = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (choiceXO)
            {
                case 'A':
                    drawXOboard();
                    playXO();
                    break;
                case 'B':
                    break;
                case 'X':
                    break;
                default:
                    Console.WriteLine("Error! That is not an option.");
                    break;
            }
        }

        public static void drawXOboard()
        {
            Console.Clear();
            Console.WriteLine("  ___1___|___2___|___3___");
            Console.WriteLine(" |       |       |       |");
            Console.WriteLine("A|   {0}   |   {1}   |   {2}   |", A1, A2, A3);
            Console.WriteLine(" |_______|_______|_______|");
            Console.WriteLine(" |       |       |       |");
            Console.WriteLine("B|   {0}   |   {1}   |   {2}   |", B1, B2, B3);
            Console.WriteLine(" |_______|_______|_______|");
            Console.WriteLine(" |       |       |       |");
            Console.WriteLine("C|   {0}   |   {1}   |   {2}   |", C1, C2, C3);
            Console.WriteLine(" |_______|_______|_______|\n");
        }

        public static void playXO()
        {

            while (end != true)
            {

                while (turn1 == true && turn2 == false)
                {
                    Console.Write("{0} select a Square: ", nameP1);
                    pick1 = Console.ReadLine().ToUpper();
                    checkMoveP1();
                }

                while (turn2 == true && turn1 == false)
                {
                    Console.Write("{0} select Square: ", nameP2);
                    pick2 = Console.ReadLine().ToUpper();
                    checkMoveP2();
                }
            }
        }

        static void checkMoveP1()
        {
            switch (pick1)
            {
                case "A1":
                    if (A1en == true)
                    {
                        A1 = "X";
                        turn1 = false;
                        turn2 = true;
                        A1en = false;
                        Console.Clear();
                        drawXOboard();
                        checkWinP1();
                    }
                    else if (A1en == false)
                    {
                        Console.WriteLine("That square is occupied. Choose another one.");
                    }
                    break;
                case "A2":
                    if (A2en == true)
                    {
                        A2 = "X";
                        turn1 = false;
                        turn2 = true;
                        A2en = false;
                        Console.Clear();
                        drawXOboard();
                        checkWinP1();
                    }
                    else if (A2en == false)
                    {
                        Console.WriteLine("That square is occupied. Choose another one.");
                    }
                    break;
                case "A3":
                    if (A3en == true)
                    {
                        A3 = "X";
                        turn1 = false;
                        turn2 = true;
                        A3en = false;
                        Console.Clear();
                        drawXOboard();
                        checkWinP1();
                    }
                    else if (A3en == false)
                    {
                        Console.WriteLine("That square is occupied. Choose another one.");
                    }
                    break;
                case "B1":
                    if (B1en == true)
                    {
                        B1 = "X";
                        turn1 = false;
                        turn2 = true;
                        B1en = false;
                        Console.Clear();
                        drawXOboard();
                        checkWinP1();
                    }
                    else if (B1en == false)
                    {
                        Console.WriteLine("That square is occupied. Choose another one.");
                    }
                    break;
                case "B2":
                    if (B2en == true)
                    {
                        B2 = "X";
                        turn1 = false;
                        turn2 = true;
                        B2en = false;
                        Console.Clear();
                        drawXOboard();
                        checkWinP1();
                    }
                    else if (B2en == false)
                    {
                        Console.WriteLine("That square is occupied. Choose another one.");
                    }
                    break;
                case "B3":
                    if (B3en == true)
                    {
                        B3 = "X";
                        turn1 = false;
                        turn2 = true;
                        B3en = false;
                        Console.Clear();
                        drawXOboard();
                        checkWinP1();
                    }
                    else if (B3en == false)
                    {
                        Console.WriteLine("That square is occupied. Choose another one.");
                    }
                    break;
                case "C1":
                    if (C1en == true)
                    {
                        C1 = "X";
                        turn1 = false;
                        turn2 = true;
                        C1en = false;
                        Console.Clear();
                        drawXOboard();
                        checkWinP1();
                    }
                    else if (C1en == false)
                    {
                        Console.WriteLine("That square is occupied. Choose another one.");
                    }
                    break;
                case "C2":
                    if (C2en == true)
                    {
                        C2 = "X";
                        turn1 = false;
                        turn2 = true;
                        C2en = false;
                        Console.Clear();
                        drawXOboard();
                        checkWinP1();
                    }
                    else if (C2en == false)
                    {
                        Console.WriteLine("That square is occupied. Choose another one.");
                    }
                    break;
                case "C3":
                    if (C3en == true)
                    {
                        C3 = "X";
                        turn1 = false;
                        turn2 = true;
                        C3en = false;
                        Console.Clear();
                        drawXOboard();
                        checkWinP1();
                    }
                    else if (C3en == false)
                    {
                        Console.WriteLine("That square is occupied. Choose another one.");
                    }
                    break;
            }
        }

        static void checkMoveP2()
        {
            switch (pick2)
            {
                case "A1":
                    if (A1en == true)
                    {
                        A1 = "O";
                        turn1 = true;
                        turn2 = false;
                        A1en = false;
                        Console.Clear();
                        drawXOboard();
                        checkWinP2();
                    }
                    else if (A1en == false)
                    {
                        Console.WriteLine("That square is occupied. Choose another one.");
                    }
                    break;
                case "A2":
                    if (A2en == true)
                    {
                        A2 = "O";
                        turn1 = true;
                        turn2 = false;
                        A2en = false;
                        Console.Clear();
                        drawXOboard();
                        checkWinP2();
                    }
                    else if (A2en == false)
                    {
                        Console.WriteLine("That square is occupied. Choose another one.");
                    }
                    break;
                case "A3":
                    if (A3en == true)
                    {
                        A3 = "O";
                        turn1 = true;
                        turn2 = false;
                        A3en = false;
                        Console.Clear();
                        drawXOboard();
                        checkWinP2();
                    }
                    else if (A3en == false)
                    {
                        Console.WriteLine("That square is occupied. Choose another one.");
                    }
                    break;
                case "B1":
                    if (B1en == true)
                    {
                        B1 = "O";
                        turn1 = true;
                        turn2 = false;
                        B1en = false;
                        Console.Clear();
                        drawXOboard();
                        checkWinP2();
                    }
                    else if (B1en == false)
                    {
                        Console.WriteLine("That square is occupied. Choose another one.");
                    }
                    break;
                case "B2":
                    if (B2en == true)
                    {
                        B2 = "O";
                        turn1 = true;
                        turn2 = false;
                        B2en = false;
                        Console.Clear();
                        drawXOboard();
                        checkWinP2();
                    }
                    else if (B2en == false)
                    {
                        Console.WriteLine("That square is occupied. Choose another one.");
                    }
                    break;
                case "B3":
                    if (B3en == true)
                    {
                        B3 = "O";
                        turn1 = true;
                        turn2 = false;
                        B3en = false;
                        Console.Clear();
                        drawXOboard();
                        checkWinP2();
                    }
                    else if (B3en == false)
                    {
                        Console.WriteLine("That square is occupied. Choose another one.");
                    }
                    break;
                case "C1":
                    if (C1en == true)
                    {
                        C1 = "O";
                        turn1 = true;
                        turn2 = false;
                        C1en = false;
                        Console.Clear();
                        drawXOboard();
                        checkWinP2();
                    }
                    else if (C1en == false)
                    {
                        Console.WriteLine("That square is occupied. Choose another one.");
                    }
                    break;
                case "C2":
                    if (C2en == true)
                    {
                        C2 = "O";
                        turn1 = true;
                        turn2 = false;
                        C2en = false;
                        Console.Clear();
                        drawXOboard();
                        checkWinP2();
                    }
                    else if (C2en == false)
                    {
                        Console.WriteLine("That square is occupied. Choose another one.");
                    }
                    break;
                case "C3":
                    if (C3en == true)
                    {
                        C3 = "O";
                        turn1 = true;
                        turn2 = false;
                        C3en = false;
                        Console.Clear();
                        drawXOboard();
                        checkWinP2();
                    }
                    else if (C3en == false)
                    {
                        Console.WriteLine("That square is occupied. Choose another one.");
                    }
                    break;
            }
        }

        static void checkWinP1()
        {
            if(A1 == "X" && A2 == "X" && A3 == "X")
            {
                Console.WriteLine("Well done {0}. You beat {1} and WON !!", nameP1, nameP2);
                end = true;
                turn1 = false;
                turn2 = false;

            }
            else if (C1 == "X" && C2 == "X" && C3 == "X")
            {
                Console.WriteLine("Well done {0}. You beat {1} and WON !!", nameP1, nameP2);
                end = true;
                turn1 = false;
                turn2 = false;
            }
            else if(B1 == "X" && B2 == "X" && B3 == "X")
            {
                Console.WriteLine("Well done {0}. You beat {1} and WON !!", nameP1, nameP2);
                end = true;
                turn1 = false;
                turn2 = false;
            }
            else if (A1 == "X" && B2 == "X" && C3 == "X")
            {
                Console.WriteLine("Well done {0}. You beat {1} and WON !!", nameP1, nameP2);
                end = true;
                turn1 = false;
                turn2 = false;
            }
            else if (A3 == "X" && B2 == "X" && C1 == "X")
            {
                Console.WriteLine("Well done {0}. You beat {1} and WON !!", nameP1, nameP2);
                end = true;
                turn1 = false;
                turn2 = false;
            }
            else if (A2 == "X" && B2 == "X" && C2 == "X")
            {
                Console.WriteLine("Well done {0}. You beat {1} and WON !!", nameP1, nameP2);
                end = true;
                turn1 = false;
                turn2 = false;
            }
        }

        static void checkWinP2()
        {
            if (A1 == "O" && A2 == "O" && A3 == "O")
            {
                Console.WriteLine("Well done {0}. You beat {1} and WON !!", nameP2, nameP1);
                end = true;
                turn1 = false;
                turn2 = false;

            }
            else if (C1 == "O" && C2 == "O" && C3 == "O")
            {
                Console.WriteLine("Well done {0}. You beat {1} and WON !!", nameP2, nameP1);
                end = true;
                turn1 = false;
                turn2 = false;
            }
            else if (B1 == "O" && B2 == "O" && B3 == "O")
            {
                Console.WriteLine("Well done {0}. You beat {1} and WON !!", nameP2, nameP1);
                end = true;
                turn1 = false;
                turn2 = false;
            }
            else if (A1 == "O" && B2 == "O" && C3 == "O")
            {
                Console.WriteLine("Well done {0}. You beat {1} and WON !!", nameP2, nameP1);
                end = true;
                turn1 = false;
                turn2 = false;
            }
            else if (A3 == "O" && B2 == "O" && C1 == "O")
            {
                Console.WriteLine("Well done {0}. You beat {1} and WON !!", nameP2, nameP1);
                end = true;
                turn1 = false;
                turn2 = false;
            }
            else if (A2 == "O" && B2 == "O" && C2 == "O")
            {
                Console.WriteLine("Well done {0}. You beat {1} and WON !!", nameP2, nameP1);
                end = true;
                turn1 = false;
                turn2 = false;
            }
            else if (A1en == false && A2en == false && A3en == false && B1en == false && B2en == false && B3en == false && C1en == false && C2en == false && C3en == false )
            {
                Console.WriteLine("Game Ended. It's a DRAW !");
                end = true;
                turn1 = false;
                turn2 = false;
            }
        }
    }

}
