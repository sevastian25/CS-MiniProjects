using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Metin_Adventures
{
    class LoadGame
    {
        private static string loadPath = @"C:\Users\2640\source\repos\Metin_Adventures\Metin_save\save.txt";

        public static void loadGame()
        {
            var lines = File.ReadAllLines(loadPath);


            //Program File
            Program.Game_Over = int.Parse(lines[0]);
            Program.Char_HP_Current = double.Parse(lines[1]);
            Program.Char_HP_Full = double.Parse(lines[2]);
            Program.Char_EXP_Current = double.Parse(lines[3]);
            Program.Char_EXP_Full = double.Parse(lines[4]);
            Program.Char_Level = int.Parse(lines[5]);
            Program.Resting_Time = int.Parse(lines[6]);
            Program.questsCompleted = int.Parse(lines[7]);
            Program.quest1 = int.Parse(lines[8]);
            Program.quest2 = int.Parse(lines[9]);
            Program.quest3 = int.Parse(lines[10]);
            Program.quest4 = int.Parse(lines[11]);
            Program.quest5 = int.Parse(lines[12]);

            Program.Strength = double.Parse(lines[13]);
            Program.Health = double.Parse(lines[14]);
            Program.Dexterity = double.Parse(lines[15]);
            Program.Inteligence = double.Parse(lines[16]);
            Program.Armour = double.Parse(lines[17]);

            Program.Char_Melee_Damage = double.Parse(lines[18]);
            Program.Char_Spell_Damage = double.Parse(lines[19]);
            Program.Char_Dagger_Damage = double.Parse(lines[20]);

            Program.Char_Damage = double.Parse(lines[21]);
            Program.Char_Defence = double.Parse(lines[22]);

            Program.Char_Name = lines[23];
            Program.Char_Class = lines[24];
            Program.Char_Status = lines[25];

            Program.Equipped_Weapon = lines[26];
            Program.Equipped_Armour = lines[27];
            Program.Char_Location = lines[28];

            //Items
            Items.Inventory.Add(lines[29]);
            Items.Inventory.Add(lines[30]);
            Items.Inventory.Add(lines[31]);
            Items.Inventory.Add(lines[32]);
            Items.Inventory.Add(lines[33]);
            Items.Inventory.Add(lines[34]);
            Items.Inventory.Add(lines[35]);
            Items.Inventory.Add(lines[36]);
            Items.Inventory.Add(lines[37]);
            Items.Inventory.Add(lines[38]);
            Items.Inventory.Add(lines[39]);
            Items.Inventory.Add(lines[40]);
            Items.Inventory.Add(lines[41]);
            Items.Inventory.Add(lines[42]);
            Items.Inventory.Add(lines[43]);
            Items.Inventory.Add(lines[44]);
            Items.Inventory.Add(lines[45]);
            Items.Inventory.Add(lines[46]);
            Items.Inventory.Add(lines[47]);
            Items.Inventory.Add(lines[48]);

            Program.Fishing_Valley_Access = int.Parse(lines[49]);


            Console.Clear();
            Functions.drawGUI();
        }




    }
}