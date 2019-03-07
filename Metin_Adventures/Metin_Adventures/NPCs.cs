using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Metin_Adventures
{
    class NPCs
    {

        public static void fisherman()
        {
            Thread.Sleep(300);
            Console.SetCursorPosition(35, 9);
            Console.WriteLine("Fisherman: ");
            Thread.Sleep(300);
            Console.SetCursorPosition(35, 11);
            Console.WriteLine("Welcome {0}", Program.Char_Name);
            Thread.Sleep(300);
            Console.SetCursorPosition(35, 12);
            Console.WriteLine("Im the Fisherman of this town");
            Thread.Sleep(300);
            Console.SetCursorPosition(35, 13);
            Console.WriteLine("The greatest Fisherman in the region");
            Thread.Sleep(300);
            Console.SetCursorPosition(35, 14);
            Console.WriteLine("Fishing is a great way of finding Upgrade Items,");
            Thread.Sleep(300);
            Console.SetCursorPosition(35, 15);
            Console.WriteLine("But it does require skill and patience.");
            Thread.Sleep(300);
            Console.SetCursorPosition(35, 17);
            Console.WriteLine("Bring me: Walnut, Rusty Blade, Chain Link and Cloth");
            Thread.Sleep(300);
            Console.SetCursorPosition(35, 18);
            Console.WriteLine("And i shall craft you a Fishing Rod and give you access to 'Fishing Valley'");
            Console.ReadLine();

            if (Items.Inventory.Contains("Walnut") && Items.Inventory.Contains("Rusty Blade") && Items.Inventory.Contains("Chain Link") && Items.Inventory.Contains("Cloth"))
            {
                Thread.Sleep(300);
                Console.SetCursorPosition(35, 20);
                Console.WriteLine("I can see that you have the upgrade items.");
                Thread.Sleep(300);
                Console.SetCursorPosition(35, 21);
                Console.WriteLine("Would you like me to craft you a Fishing Rod ? (Yes/No)");
                Thread.Sleep(300);
                Console.SetCursorPosition(35, 22);
                Console.Write("Choice: ");
                string choice = Console.ReadLine().ToUpper();
                
                if(choice == "YES")
                {

                    for (int i = 0; i < Items.Inventory.Count; i++)
                    {
                        if (Items.Inventory[i].Contains("Walnut"))
                        {
                            Items.Inventory[i] = "Empty Slot";
                            break;
                        }
                    }
                    for (int i = 0; i < Items.Inventory.Count; i++)
                    {
                        if (Items.Inventory[i].Contains("Rusty Blade"))
                        {
                            Items.Inventory[i] = "Empty Slot";
                            break;
                        }
                    }
                    for (int i = 0; i < Items.Inventory.Count; i++)
                    {
                        if (Items.Inventory[i].Contains("Chain Link"))
                        {
                            Items.Inventory[i] = "Empty Slot";
                            break;
                        }
                    }
                    for (int i = 0; i < Items.Inventory.Count; i++)
                    {
                        if (Items.Inventory[i].Contains("Cloth"))
                        {
                            Items.Inventory[i] = "Empty Slot";
                            break;
                        }
                    }

                    for (int i = 0; i < Items.Inventory.Count; i++)
                    {
                        if (Items.Inventory[i].Contains("Empty Slot"))
                        {
                            Items.Inventory[i] = "Fishing Rod";
                            Program.Fishing_Valley_Access = 1;
                            Console.SetCursorPosition(35, 24);
                            Console.WriteLine("You received 'Fishing Rod' & access to 'Fishing Valley'");
                            Console.ReadLine();
                            break;
                        }
                    }

                }
                else { }

            }
            else
            {

            }

        }






        public static void blackSmith()
        {
            Thread.Sleep(300);
            Console.SetCursorPosition(43, 9);
            Console.WriteLine("Blacksmith: ");
            Thread.Sleep(300);
            Console.SetCursorPosition(43, 11);
            Console.WriteLine("Welcome {0}", Program.Char_Name);
            Thread.Sleep(300);
            Console.SetCursorPosition(43, 12);
            Console.WriteLine("Im the Blacksmith of this town");
            Thread.Sleep(300);
            Console.SetCursorPosition(43, 13);
            Console.WriteLine("The Best Blacksmith in the whole region");
            Thread.Sleep(300);
            Console.SetCursorPosition(43, 14);
            Console.WriteLine("If you provide me the upgrade items...");
            Thread.Sleep(300);
            Console.SetCursorPosition(43, 15);
            Console.WriteLine("I may or may not be able to upgrade your gear.");
            Thread.Sleep(300);
            Console.SetCursorPosition(43, 16);
            Console.WriteLine("So tell me, why are you here ?");
            Thread.Sleep(300);
            Console.SetCursorPosition(43, 18);
            Console.WriteLine("[1] Upgrade my Weapon | [2] Upgrade my Armour | [3] Nevermind");
            Console.SetCursorPosition(43, 20);
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                Functions.drawGUI();
                Thread.Sleep(300);
                Console.SetCursorPosition(43, 9);
                Console.WriteLine("To upgrade your weapon, i will need: ");
                Thread.Sleep(300);
                Console.SetCursorPosition(43, 11);
                Console.WriteLine("Blue Rose");
                Thread.Sleep(300);
                Console.SetCursorPosition(43, 12);
                Console.WriteLine("Rusty Blade");
                Thread.Sleep(300);
                Console.SetCursorPosition(43, 13);
                Console.WriteLine("Porcelain");
                Thread.Sleep(300);
                Console.SetCursorPosition(43, 14);
                Console.WriteLine("Unknown Talisman");

                if (Items.Inventory.Contains("Blue Rose") && Items.Inventory.Contains("Rusty Blade") && Items.Inventory.Contains("Porcelain") && Items.Inventory.Contains("Unknown Talisman"))
                {
                    Thread.Sleep(300);
                    Console.SetCursorPosition(43, 17);
                    Console.WriteLine("I can see that you have the upgrade items.");
                    Thread.Sleep(300);
                    Console.SetCursorPosition(43, 18);
                    Console.WriteLine("Would you like me to try and upgrade your weapon ?");
                    Thread.Sleep(300);
                    Console.SetCursorPosition(43, 19);
                    Console.WriteLine("Chance of success is 80%.");
                    Thread.Sleep(300);
                    Console.SetCursorPosition(43, 20);
                    Console.WriteLine("If the upgrade process fails you will loose the weapon.");
                    Thread.Sleep(300);
                    Console.SetCursorPosition(43, 22);
                    Console.Write("Continue ? Yes/No: ");
                    string answer = Console.ReadLine().ToUpper();

                    if (answer == "YES")
                    {
                        if (Program.Equipped_Weapon == "Sword + 5" || Program.Equipped_Weapon == "Long Sword + 5" || Program.Equipped_Weapon == "Silver Sword + 5" || Program.Equipped_Weapon == "Battle Sword + 5" || Program.Equipped_Weapon == "Daggers + 5" || Program.Equipped_Weapon == "Scrissor Daggers + 5" || Program.Equipped_Weapon == "Silver Daggers + 5" || Program.Equipped_Weapon == "Battle Daggers + 5" || Program.Equipped_Weapon == "Staff + 5" || Program.Equipped_Weapon == "Void Staff + 5" || Program.Equipped_Weapon == "Silver Staff + 5" || Program.Equipped_Weapon == "Battle Staff + 5" || Program.Equipped_Weapon == "Poleaxe + 5" || Program.Equipped_Weapon == "Long Poleaxe + 5" || Program.Equipped_Weapon == "Silver Poleaxe + 5" || Program.Equipped_Weapon == "Battle Poleaxe + 5")
                        {
                            Console.SetCursorPosition(43, 24);
                            Console.WriteLine("Your weapon is fully upgraded.");
                            Console.ReadLine();
                        }
                        else if (Program.Equipped_Weapon == "Fists")
                        {
                            Console.SetCursorPosition(43, 24);
                            Console.WriteLine("Your Fists can not be upgraded.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Random d = new Random();
                            int[] chance_upgrade = { 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1, 1, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 1, 1 };
                            int upgrade_chance = chance_upgrade[d.Next(0, chance_upgrade.Length)];

                            if (upgrade_chance != 0)
                            {
                                Console.SetCursorPosition(43, 24);
                                if (Program.Equipped_Weapon == "Sword + 0")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Sword + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Sword + 1")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Sword + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Sword + 2")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Sword + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Sword + 3")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Sword + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Sword + 4")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Sword + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Long Sword + 0")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Long Sword + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Long Sword + 1")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Long Sword + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Long Sword + 2")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Long Sword + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Long Sword + 3")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Long Sword + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Long Sword + 4")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Long Sword + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Sword + 0")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Sword + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Sword + 1")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Sword + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Sword + 2")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Sword + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Sword + 3")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Sword + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Sword + 4")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Sword + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Sword + 0")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Sword + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Sword + 1")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Sword + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Sword + 2")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Sword + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Sword + 3")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Sword + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Sword + 4")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Sword + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Daggers + 0")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Daggers + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Daggers + 1")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Daggers + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Daggers + 2")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Daggers + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Daggers + 3")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Daggers + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Daggers + 4")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Daggers + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Scrissor Daggers + 0")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Scrissor Daggers + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Scrissor Daggers + 1")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Scrissor Daggers + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Scrissor Daggers + 2")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Scrissor Daggers + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Scrissor Daggers + 3")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Scrissor Daggers + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Scrissor Daggers + 4")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Scrissor Daggers + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Daggers + 0")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Daggers + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Daggers + 1")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Daggers + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Daggers + 2")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Daggers + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Daggers + 3")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Daggers + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Daggers + 4")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Daggers + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Daggers + 0")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Daggers + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Daggers + 1")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Daggers + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Daggers + 2")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Daggers + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Daggers + 3")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Daggers + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Daggers + 4")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Daggers + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Staff + 0")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Staff + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Staff + 1")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Staff + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Staff + 2")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Staff + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Staff + 3")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Staff + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Staff + 4")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Staff + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Void Staff + 0")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Void Staff + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Void Staff + 1")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Void Staff + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Void Staff + 2")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Void Staff + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Void Staff + 3")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Void Staff + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Void Staff + 4")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Void Staff + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Staff + 0")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Staff + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Staff + 1")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Staff + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Staff + 2")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Staff + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Staff + 3")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Staff + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Staff + 4")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Staff + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Staff + 0")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Staff + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Staff + 1")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Staff + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Staff + 2")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Staff + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Staff + 3")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Staff + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Staff + 4")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Staff + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Poleaxe + 0")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Poleaxe + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Poleaxe + 1")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Poleaxe + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Poleaxe + 2")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Poleaxe + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Poleaxe + 3")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Poleaxe + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Poleaxe + 4")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Poleaxe + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Long Poleaxe + 0")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Long Poleaxe + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Long Poleaxe + 1")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Long Poleaxe + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Long Poleaxe + 2")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Long Poleaxe + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Long Poleaxe + 3")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Long Poleaxe + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Long Poleaxe + 4")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Long Poleaxe + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Poleaxe + 0")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Poleaxe + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Poleaxe + 1")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Poleaxe + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Poleaxe + 2")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Poleaxe + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Poleaxe + 3")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Poleaxe + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Silver Poleaxe + 4")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Silver Poleaxe + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Poleaxe + 0")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Poleaxe + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Poleaxe + 1")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Poleaxe + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Poleaxe + 2")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Poleaxe + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Poleaxe + 3")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Poleaxe + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }
                                else if (Program.Equipped_Weapon == "Battle Poleaxe + 4")
                                {
                                    Program.Equipped_Weapon = "Fists";
                                    Items.item_equipped_w = "a";
                                    Items.weaponsDamage();
                                    Program.Equipped_Weapon = "Battle Poleaxe + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_w = "a";
                                }


                                Console.ReadLine();
                            }
                            else
                            {
                                Console.SetCursorPosition(43, 24);
                                Console.WriteLine("Upgrade process failed !");
                                Console.ReadLine();
                            }
                        }
                    }
                    else if (answer == "NO")
                    {

                    }
                }
                else
                {
                    Thread.Sleep(300);
                    Console.SetCursorPosition(43, 17);
                    Console.WriteLine("You do not have the upgrade items.");
                    Thread.Sleep(300);
                    Console.SetCursorPosition(43, 18);
                    Console.WriteLine("Come back to me when you have them.");
                    Console.ReadLine();
                }
            }
            else if (choice == "2")
            {
                Thread.Sleep(300);
                Console.WriteLine("To upgrade your armour, i will need: ");
                Thread.Sleep(300);
                Console.WriteLine("Red Rose");
                Thread.Sleep(300);
                Console.WriteLine("Chain Link");
                Thread.Sleep(300);
                Console.WriteLine("Leather");
                Thread.Sleep(300);
                Console.WriteLine("Empty Can");

                if (Items.Inventory.Contains("Red Rose") && Items.Inventory.Contains("Chain Link") && Items.Inventory.Contains("Leather") && Items.Inventory.Contains("Empty Can"))
                {
                    Thread.Sleep(300);
                    Console.WriteLine("I can see that you have the upgrade items.");
                    Thread.Sleep(300);
                    Console.WriteLine("Would you like me to try and upgrade your armour ?");
                    Thread.Sleep(300);
                    Console.WriteLine("There might be a chance that it will fail");
                    Thread.Sleep(300);
                    Console.WriteLine("If the upgrade process fails you will loose your armour.");
                    Thread.Sleep(300);
                    Console.Write("Continue ? Yes/No: ");
                    string answer = Console.ReadLine().ToUpper();

                    if (answer == "YES")
                    {
                        if (Program.Equipped_Armour == "Cloth Armour + 5" || Program.Equipped_Armour == "Leather Armour + 5" || Program.Equipped_Armour == "Chain Armour + 5" || Program.Equipped_Armour == "Battle Armour + 5")
                        {
                            Console.SetCursorPosition(43, 24);
                            Console.WriteLine("Your armour is fully upgraded.");
                            Console.ReadLine();
                        }
                        else if (Program.Equipped_Armour == "Cloth Robe")
                        {
                            Console.SetCursorPosition(43, 24);
                            Console.WriteLine("Your Cloth Robe can not be upgraded.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Random d = new Random();
                            int[] chance_upgrade = { 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1, 1, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 1, 1 };
                            int upgrade_chance = chance_upgrade[d.Next(0, chance_upgrade.Length)];

                            if (upgrade_chance != 0)
                            {
                                Console.SetCursorPosition(43, 24);
                                if (Program.Equipped_Armour == "Cloth Armour + 0")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Cloth Armour + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Cloth Armour + 1")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Cloth Armour + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Cloth Armour + 2")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Cloth Armour + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Cloth Armour + 3")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Cloth Armour + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Cloth Armour + 4")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Cloth Armour + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Leather Armour + 0")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Leather Armour + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Leather Armour + 1")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Leather Armour + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Leather Armour + 2")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Leather Armour + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Leather Armour + 3")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Leather Armour + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Leather Armour + 4")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Leather Armour + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Chain Armour + 0")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Chain Armour + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Chain Armour + 1")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Chain Armour + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Chain Armour + 2")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Chain Armour + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Chain Armour + 3")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Chain Armour + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Chain Armour + 4")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Chain Armour + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Battle Armour + 0")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Battle Armour + 1";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Battle Armour + 1")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Battle Armour + 2";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Battle Armour + 2")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Battle Armour + 3";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Battle Armour + 3")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Battle Armour + 4";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                else if (Program.Equipped_Armour == "Battle Armour + 4")
                                {
                                    Program.Equipped_Armour = "Cloth Robe";
                                    Items.item_equipped_a = "a";
                                    Items.armourDefence();
                                    Program.Equipped_Armour = "Battle Armour + 5";
                                    Console.WriteLine("Upgrade has been successfull !");
                                    Items.item_equipped_a = "a";
                                }
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.SetCursorPosition(43, 24);
                                Console.WriteLine("Upgrade process failed !");
                                Console.ReadLine();
                            }
                        }

                    }
                    else if (answer == "NO")
                    {

                    }
                }
                else
                {
                    Thread.Sleep(300);
                    Console.SetCursorPosition(43, 17);
                    Console.WriteLine("You do not have the upgrade items.");
                    Thread.Sleep(300);
                    Console.SetCursorPosition(43, 18);
                    Console.WriteLine("Come back to me when you have them.");
                    Console.ReadLine();
                }

            }
            else if (choice == "3")
            {
                Thread.Sleep(300);
                Console.Clear();
                Functions.drawGUI();
            }

        }
    }
}
