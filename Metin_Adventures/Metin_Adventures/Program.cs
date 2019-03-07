using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Metin_Adventures
{
    public class Program
    {
        public static int Game_Over = 0;

        //Character
        public static double Char_HP_Current = 39;
        public static double Char_HP_Full = 100;
        public static double Char_EXP_Current = 0;
        public static double Char_EXP_Full = 100;
        public static int Char_Level = 1;
        public static int Resting_Time;
        public static int questsCompleted = 0;
        public static int quest1 = 1, quest2 = 1, quest3 = 1, quest4 = 1, quest5 = 1;

        //Stats
        public static double Strength;
        public static double Health;
        public static double Dexterity;
        public static double Inteligence;
        public static double Armour;

        public static double Char_Melee_Damage;
        public static double Char_Spell_Damage;
        public static double Char_Dagger_Damage;

        public static double Char_Damage;
        public static double Char_Defence;

        public static int Fishing_Valley_Access = 0;

        //Strings
        public static string Char_Name;
        public static string Char_Class;
        public static string Char_Status;
        public static string Current_Command;

        public static string Equipped_Weapon = "Fists";
        public static string Equipped_Armour = "Cloth Robe";
        public static string Char_Location = "Jinsoo";



        static void Main(string[] args)
        {
            Functions.printMainMenu();
            string choice = Console.ReadLine().ToUpper();

            switch(choice)
            {
                case "1": case "NEW GAME":
                    Functions.newGame();
                    for (int f = 0; f <= 19; f++)
                    {
                        Items.Inventory.Add("Empty Slot");
                    }
                    break;

                case "2": case "LOAD GAME":
                    LoadGame.loadGame();
                    break;
            }


            do
            {

                Functions.checks();

                Functions.drawGUI();

                //Functions.giveQuest();


//--------------------------------------------------------------------------Type Command Start
                ConsoleKeyInfo cki;
                while (true)
                {
                    cki = Console.ReadKey();
                     if (cki.Key == ConsoleKey.Spacebar)
                        Functions.Commands();
                    break;
                }
//--------------------------------------------------------------------------Type Command End

            }
            while (Game_Over == 0);
        }
    }
}
