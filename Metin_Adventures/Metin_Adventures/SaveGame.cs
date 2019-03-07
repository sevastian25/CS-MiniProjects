using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Metin_Adventures
{
    class SaveGame
    {
        private static string savePath = @"C:\Users\2640\source\repos\Metin_Adventures\Metin_save\save.txt";

        public static void saveGame()
        {

            if (!File.Exists(savePath))
            {
                using (StreamWriter sw = File.CreateText(savePath))
                {
                    sw.WriteLine("Made by SV. Cristian");
                }
            }
            else
            {
                var lines = File.ReadAllLines(savePath);

                File.WriteAllText(savePath, String.Empty);

                using (StreamWriter sw = File.AppendText(savePath))
                {

                    sw.WriteLine(Program.Game_Over);
                    sw.WriteLine(Program.Char_HP_Current);
                    sw.WriteLine(Program.Char_HP_Full);
                    sw.WriteLine(Program.Char_EXP_Current);
                    sw.WriteLine(Program.Char_EXP_Full);
                    sw.WriteLine(Program.Char_Level);
                    sw.WriteLine(Program.Resting_Time);
                    sw.WriteLine(Program.questsCompleted);
                    sw.WriteLine(Program.quest1);
                    sw.WriteLine(Program.quest2);
                    sw.WriteLine(Program.quest3);
                    sw.WriteLine(Program.quest4);
                    sw.WriteLine(Program.quest5);

                    sw.WriteLine(Program.Strength);
                    sw.WriteLine(Program.Health);
                    sw.WriteLine(Program.Dexterity);
                    sw.WriteLine(Program.Inteligence);
                    sw.WriteLine(Program.Armour);

                    sw.WriteLine(Program.Char_Melee_Damage);
                    sw.WriteLine(Program.Char_Spell_Damage);
                    sw.WriteLine(Program.Char_Dagger_Damage);

                    sw.WriteLine(Program.Char_Damage);
                    sw.WriteLine(Program.Char_Defence);

                    sw.WriteLine(Program.Char_Name);
                    sw.WriteLine(Program.Char_Class);
                    sw.WriteLine(Program.Char_Status);

                    sw.WriteLine(Program.Equipped_Weapon);
                    sw.WriteLine(Program.Equipped_Armour);
                    sw.WriteLine(Program.Char_Location);

                    sw.WriteLine(Items.Inventory[0]);
                    sw.WriteLine(Items.Inventory[1]);
                    sw.WriteLine(Items.Inventory[2]);
                    sw.WriteLine(Items.Inventory[3]);
                    sw.WriteLine(Items.Inventory[4]);
                    sw.WriteLine(Items.Inventory[5]);
                    sw.WriteLine(Items.Inventory[6]);
                    sw.WriteLine(Items.Inventory[7]);
                    sw.WriteLine(Items.Inventory[8]);
                    sw.WriteLine(Items.Inventory[9]);
                    sw.WriteLine(Items.Inventory[10]);
                    sw.WriteLine(Items.Inventory[11]);
                    sw.WriteLine(Items.Inventory[12]);
                    sw.WriteLine(Items.Inventory[13]);
                    sw.WriteLine(Items.Inventory[14]);
                    sw.WriteLine(Items.Inventory[15]);
                    sw.WriteLine(Items.Inventory[16]);
                    sw.WriteLine(Items.Inventory[17]);
                    sw.WriteLine(Items.Inventory[18]);
                    sw.WriteLine(Items.Inventory[19]);

                    sw.WriteLine(Program.Fishing_Valley_Access);

                }
            }
        }
    }
}
